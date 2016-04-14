using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.IO;                                                                    // wanganl注：文件操作必须using这句

namespace SAKURA
{
    class Controller
    {
        private BackgroundWorker worker;
        private CipherModule targetModule;
        private AES pcModule;

        public Controller()
        {
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            pcModule = new AES();
        }

        public void Open(uint index)
        {
            targetModule = new CipherModule(index);
        }

        public void Close()
        {
            targetModule.Dispose();
        }

        public void AddCompletedEventHandler(RunWorkerCompletedEventHandler handler)
        {
            worker.RunWorkerCompleted += handler;
        }

        public void AddProgressChangedEventHandler(ProgressChangedEventHandler handler)
        {
            worker.ProgressChanged += handler;
        }

        public void Run(ControllerArgs args)
        {
            worker.RunWorkerAsync((object)args);
        }

        public void Cancel()
        {
            worker.CancelAsync();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            ControllerArgs args = (ControllerArgs)e.Argument;
            ControllerArgs res = args.Clone();
            int progress = 0;

            e.Cancel = false;

            // initialize
            res.last = false;
            res.error = false;
            res.current_trace = 0;
            pcModule.SetKey(res.key);
            targetModule.Reset();
            targetModule.SetModeEncrypt(true);
            targetModule.SetKey(res.key);
            worker.ReportProgress(0, (object)res);
            string fold = "C:\\powertrace\\C2power traces";
            string filename;

            FileStream fs_pt = new FileStream("plaintext.txt", FileMode.Append);
            FileStream fs_key = new FileStream("key.txt", FileMode.Append);
            FileStream fs_ct = new FileStream("ciphertext.txt", FileMode.Append);
            StreamWriter sw_pt = new StreamWriter(fs_pt, Encoding.Default);
            StreamWriter sw_key = new StreamWriter(fs_key, Encoding.Default);
            StreamWriter sw_ct = new StreamWriter(fs_ct, Encoding.Default);

            int inittime;
            while (res.endless || res.current_trace < res.traces) {
                res.answer = null;
                res.ciphertext = null;
                res.difference = null;
                res.current_trace++;

                inittime = System.Environment.TickCount;

                if (!res.endless)
                {
                    progress = (int)(100 * res.current_trace / res.traces);
                }

                if (res.randomGeneration)
                {
                    res.plaintext = res.rand.generatePlaintext();
                }

                pcModule.Encrypt(ref res.answer, res.key, res.plaintext);
                worker.ReportProgress(progress, (object)res);
                if (args.check)
                    targetModule.Run(ref res.ciphertext, res.plaintext, 0, ref res.elapsed);
                else targetModule.Run(ref res.ciphertext, res.plaintext, args.wait, ref res.elapsed);

                res.diff = Utils.differenceByteArray(ref res.difference, res.answer, res.ciphertext);

                //***************************************************************************************************************************
                // wanganl注：把res.current_trace这个编号转换为byte[]型，然后写入data.txt
                byte[] temp_num = new byte[2];
                temp_num[0] = (byte)(System.Math.Floor((double)(res.current_trace / 256)) % 256);
                temp_num[1] = (byte)(res.current_trace % 256);

                //wanganl_FileWrite(temp_num);                                        // wanganl注：把每次加密的编号（4位16进制数）写入data.txt
                //wanganl_FileWrite(res.key);                                         // wanganl注：把密钥写入data.txt
                //wanganl_FileWrite(res.plaintext);                                   // wanganl注：把明文写入data.txt
                //wanganl_FileWrite(res.plaintext_mask);                              // wanganl注：把明文掩码写入data.txt
                //wanganl_FileWrite(res.ciphertext);                                  // wanganl注：把密文写入data.txt
                bool skip = false;
                if (args.check)
                {
                    filename = fold + (res.current_trace - 1).ToString("d5");
                    filename = filename + ".dat";
                    int startTime = Environment.TickCount;
                    while (File.Exists(filename) == false)
                    {
                        System.Threading.Thread.Sleep(10);
                        int runtime = Environment.TickCount - startTime;
                        if (runtime > 1000) { skip = true; res.current_trace -= 1; break; }
                    }
                    startTime = System.Environment.TickCount;
                    while (true)
                    {
                        try
                        {
                            FileInfo file = new FileInfo(filename);
                            if (file.Length > 100000) break;
                            int runtime = Environment.TickCount - startTime;
                            if (runtime > 1000) { break; }
                        }
                        catch { break; }
                        System.Threading.Thread.Sleep(10);
                    }
                    System.Threading.Thread.Sleep(args.wait);
                }
                //wanganl_FileWrite(temp_num); // wanganl：把每次加密的编号（4位16进制数）写入data.txt
                if (skip == false)
                {
                    FileWrite(res.key,sw_key);                                             // shenal注：把密钥写入data.txt
                    FileWrite(res.plaintext,sw_pt);                                   // shenal注：把明文写入data.txt
                    FileWrite(res.ciphertext,sw_ct);                                  // shenal注：把密文写入data.txt
                }
                //****************************************************************************************************************************

                worker.ReportProgress(progress, (object)res);

                if (res.diff)
                {
                    res.error = true;
                    if (!res.continueIfError)
                    {
                        break;
                    }
                }

                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                if (res.single)
                {
                    progress = 100;
                    break;
                }
                res.elapsed = (double)(Environment.TickCount - inittime)/1000;

            }   //while loop end here

            sw_ct.Close();
            sw_key.Close();
            sw_pt.Close();
            fs_ct.Close();
            fs_pt.Close();
            fs_key.Close();

            res.last = true;
            worker.ReportProgress(progress, (object)res);
            e.Result = (object)res;
        
        }

      //***********************************************************************************************************************************
        public void wanganl_FileWrite(byte[] byte_buffer)                                             // wanganl注：自定义文件存储函数
        {
            // 数据被写到data.txt里，进来的是byte数组，输出的是16进制的string，一个数存一行
            string hex_String = string.Empty;
            if (byte_buffer != null)
            {
                StringBuilder strB = new StringBuilder();
                for (int i = 0; i < byte_buffer.Length; i++)
                    strB.Append(byte_buffer[i].ToString("X2"));
                hex_String = strB.ToString();
            }
            FileStream fs = new FileStream("data.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.Write(hex_String);
            sw.Write("\r\n");                                                       // wanganl注：\r是光标去下行开头，\n是换行
            sw.Close();
            fs.Close();
        }   // wanganl注：自定义文件存储函数结束
        //********************************************************************************************************************************

        //***********************************************************************************************************************************
        public void FileWrite(byte[] byte_buffer , StreamWriter sw)                                             // shenal注：自定义文件存储函数
        {
            // 数据被写到data.txt里，进来的是byte数组，输出的是16进制的string，一个数存一行
            string hex_String = string.Empty;
            if (byte_buffer != null)
            {
                StringBuilder strB = new StringBuilder();
                for (int i = 0; i < byte_buffer.Length; i++)
                    strB.Append(byte_buffer[i].ToString("X2"));
                hex_String = strB.ToString();
            }
            //FileStream fs = new FileStream("plaintext.txt", FileMode.Append);
           // StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.Write(hex_String);
            sw.Write("\r\n");                                                       // shenal注：\r是光标去下行开头，\n是换行
            //sw.Close();
            //fs.Close();
        }   // shenal注：自定义文件存储函数结束
        //********************************************************************************************************************************
    }

    public struct ControllerArgs
    {
        public bool single;
        public long traces;
        public bool endless;
        public long current_trace;
        public byte[] key;
        public byte[] plaintext;
        public bool randomGeneration;
        public int wait;
        public byte[] ciphertext;
        public byte[] answer;
        public byte[] difference;
        public bool diff;
        public bool continueIfError;
        public bool error;
        public double elapsed;
        public RandGen rand;
        public bool last;
        public bool check;
        

        public ControllerArgs Clone()
        {
            return (ControllerArgs)MemberwiseClone();
        }
    }
}
