using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SAKURA 
{
    class Filewriter
    {
        private FileStream fs_pt;
        private FileStream fs_ct;
        private FileStream fs_key;
        private StreamWriter sw_pt;
        private StreamWriter sw_ct;
        private StreamWriter sw_key;
        private int savelock = 0;

        public void openfile()
        {
            if (savelock == 0)
            {
                savelock++;
                fs_pt = new FileStream("plaintext.txt", FileMode.Append);
                fs_key = new FileStream("key.txt", FileMode.Append);
                fs_ct = new FileStream("ciphertext.txt", FileMode.Append);
                sw_pt = new StreamWriter(fs_pt, Encoding.Default);
                sw_key = new StreamWriter(fs_key, Encoding.Default);
                sw_ct = new StreamWriter(fs_ct, Encoding.Default);
            }
        }


        public void closefile()
        {
            if (savelock == 1)
            {
                savelock--;
                sw_ct.Close();
                sw_key.Close();
                sw_pt.Close();
                fs_ct.Close();
                fs_pt.Close();
                fs_key.Close();
            }
        }

        public void write(byte[] plaintext, byte[] key, byte[] ciphertext)
        {
            if (savelock == 1)
            {
                FileWrite(key, sw_key);                            // shenal注：把密钥写入data.txt
                FileWrite(plaintext, sw_pt);                       // shenal注：把明文写入data.txt
                FileWrite(ciphertext, sw_ct);                      // shenal注：把密文写入data.txt
            }
        }

        void FileWrite(byte[] byte_buffer, StreamWriter sw)                                      
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
    }
}
