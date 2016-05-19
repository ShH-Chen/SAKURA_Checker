using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SAKURA
{
    class Filemove
    {
        private FileStream fswrite;
        public string readPath;
        public int index = 0;

        public Filemove(string path)
        {
            readPath = path;
        }

        public void open(int idx)
        {
            string filename = readPath + "\\PowerTrace" + idx.ToString("d5") + ".dat";
            fswrite = new FileStream(filename, FileMode.Create, FileAccess.Write);
            index = idx;
        }

        public void move(int idx)
        {
            if ((int)(idx / 10000) != index) { close(); open(idx / 10000); }
            string filename = readPath + "\\C2power traces" + idx.ToString("d5") + ".dat";
            string head = "\t\t\t\tidx:" + idx.ToString("d5") + "\n";
            byte[] head_byte = Encoding.UTF8.GetBytes(head);

            FileStream fsread = new FileStream(filename, FileMode.Open, FileAccess.Read);

            int length = (int)fsread.Length;
            byte[] buf = new byte[length + head_byte.Length];

            Array.Copy(head_byte, buf, head_byte.Length);

            fsread.Read(buf, head_byte.Length, length);
            fsread.Close();

            fswrite.Write(buf, 0, buf.Length);
        }

        public void close()
        {
            fswrite.Close();
        }
    }
}
