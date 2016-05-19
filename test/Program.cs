using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SAKURA
{
    class Program
    {
        static void Main(string[] args)
        {
            Filemove filemove = new Filemove("F:\\Project\\PowerAttackPj\\Data\\Original2.5w\\backup");
            filemove.open(1);

            filemove.move(20001);
            filemove.move(20002);

            filemove.close();
        }
    }
}
