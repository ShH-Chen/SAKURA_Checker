using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.IO;                                                                    // wanganl注：文件操作必须using这句
using System.Diagnostics;

namespace SAKURA
{
    class Controller
    {
        private BackgroundWorker worker;
        private CipherModule targetModule;
        private AES pcModule;
        private DES DESCrypto;
        private Stopwatch sw;
        private Filewriter filewrite;

        public Controller()
        {
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            pcModule = new AES();
            DESCrypto = new DES();
            sw = new Stopwatch();
            filewrite = new Filewriter();
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
            res.current_trace = res.CurrentNum;
            pcModule.SetKey(res.key);
            DESCrypto.SetKey(res.key);
            targetModule.Reset();
            targetModule.SetModeEncrypt(true);
            targetModule.SetKey(res.key);
            worker.ReportProgress(0, (object)res);
            //string fold = "D:\\powertrace\\C2power traces";
            string fold = res.path + "\\C2power traces";
            string backupfold = res.path + "\\backup"+ "\\C2power traces";
            string filename;

            filewrite.openfile();
           
            while (res.endless || res.current_trace < res.traces) {
                int bytenum = 0;
                double elapsed = 0.0;
                res.answer = null;
                res.ciphertext = null;
                res.difference = null;
                res.current_trace++;
                sw.Reset();
                sw.Start();

                if (res.current_trace % 1000 == 0)
                {
                    targetModule.Dispose();
                    targetModule.Reset();
                    targetModule.SetModeEncrypt(true);
                    targetModule.SetKey(res.key);
                    targetModule.open();

                    filewrite.closefile();
                    filewrite.openfile();
                }


                if (!res.endless)
                {
                    progress = (int)(100 * res.current_trace / res.traces);
                }

                if (res.Algorithm == "AES")
                {
                    bytenum = 16;
                    if (res.randomGeneration)
                    {
                        res.plaintext = res.rand.generatePlaintext(bytenum);
                    }
                    pcModule.Encrypt(ref res.answer, res.key, res.plaintext);
                    if (args.check)
                        targetModule.RunAES(ref res.ciphertext, res.plaintext, 0, ref elapsed);
                    else targetModule.RunAES(ref res.ciphertext, res.plaintext, args.wait, ref elapsed);
                }
                else if (res.Algorithm == "DES")
                {
                    bytenum = 8;
                    if (res.randomGeneration)
                    {
                        res.plaintext = res.rand.generatePlaintext(bytenum);
                    }
                    DESCrypto.Encrypt(ref res.answer, res.plaintext);
                    if (args.check)
                        targetModule.RunDES(ref res.ciphertext, res.plaintext, 0, ref elapsed);
                    else targetModule.RunDES(ref res.ciphertext, res.plaintext, args.wait, ref elapsed);
                }
                else break;
            
                res.diff = Utils.differenceByteArray(ref res.difference, res.answer, res.ciphertext);


                //***************************************************************************************************************************
                bool skip = false;
                if (args.check)
                {
                    /*检测文件是否被创建*/
                    filename = fold + (res.current_trace - 1).ToString("d5") + ".dat";
                    int startTime = Environment.TickCount;
                    while (File.Exists(filename) == false)
                    {
                        System.Threading.Thread.Sleep(10);
                        int runtime = Environment.TickCount - startTime;
                        if (runtime > 1000) { skip = true; res.current_trace -= 1; break; }
                    }
                    /*把上一个文件移入backup文件夹*/
                    if (res.current_trace >= 2 && File.Exists(fold + (res.current_trace - 2).ToString("d5")+".dat"))
                    {
                        File.Move(fold+(res.current_trace-2).ToString("d5") + ".dat", 
                            backupfold+(res.current_trace-2).ToString("d5") + ".dat");
                    }

                    /*检测文件是否完成写入*/
                    startTime = Environment.TickCount;
                    while (true)
                    {
                        try
                        {
                            //  FileInfo file = new FileInfo(filename);
                            //  if (file.Length > 100000) break;
                            if (fileisOpen(filename) == false) break;
                            int runtime = Environment.TickCount - startTime;
                            if (runtime > 1000) { break; }
                        }
                        catch { break; }
                        System.Threading.Thread.Sleep(10);
                    }
                    System.Threading.Thread.Sleep(args.wait);
                }
                sw.Stop();
                res.elapsed = ((double)sw.ElapsedMilliseconds) / 1000;
                //wanganl_FileWrite(temp_num); // wanganl：把每次加密的编号（4位16进制数）写入data.txt
                if (skip == false)
                {
                    filewrite.write(res.plaintext,res.key,res.ciphertext);
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
            }   //while loop end here

            filewrite.closefile();

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
            while (hex_String.Length < 32)
            {
                hex_String = hex_String + "0";
            }
            sw.Write(hex_String);
            sw.Write("\r\n");                                                       // shenal注：\r是光标去下行开头，\n是换行
        }   // shenal注：自定义文件存储函数结束
            //********************************************************************************************************************************
        public bool fileisOpen(string fileName)
        {
            bool inUse = true;
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None);
                inUse = false;
            }
            catch (System.IO.FileNotFoundException)
            {
                inUse = false;
            }
            catch
            {
                inUse = true;
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
            return inUse;
        }
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
        //add by chens
        public bool check;
        public string path;
        public long CurrentNum;
        public string Algorithm;
        

        public ControllerArgs Clone()
        {
            return (ControllerArgs)MemberwiseClone();
        }
    }
}
