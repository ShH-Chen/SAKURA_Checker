using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace SAKURA
{
    class CipherModule : IDisposable
    {
        private SBus bus;

        public CipherModule(uint index)
        {
            bus = new SBus(index);
        }

        public void open()
        {
            bus.restartInTask();
            bus.open();
        }

        public void Dispose()
        {
            bus.restartInTask();
            bus.Dispose();
        }

        public void Reset()
        {
            bus.restartInTask();
            bus.SbusWrite((uint)Address.CONT, (uint)Cont.IPRST);
            bus.SbusWrite((uint)Address.CONT, (uint)Cont.ZERO);
        }

        public void SetModeEncrypt(bool encrypt)
        {
            bus.restartInTask();
            bus.SbusWrite((uint)Address.MODE, (uint)(encrypt ? Mode.ENC : Mode.DEC));
        }

        public void SetKey(byte[] key)
        {
            bus.restartInTask();
            bus.SbusWriteBurst((uint)Address.KEY0, key, key.Length);
            bus.SbusWrite((uint)Address.CONT, (uint)Cont.KSET);
            WaitDone();
        }

        public void RunAES(ref byte[] outputtext, byte[] inputtext, int wait)
        {
            bus.restartInTask();

            bus.SbusWriteBurst((uint)(Address.ITEXT0 + 0x0020), inputtext, inputtext.Length);
            bus.SbusWrite((uint)Address.CONT, (uint)Cont.RUN);            
            WaitDone();
            outputtext = new byte[16];
            bus.SbusReadBurst((uint)Address.OTEXT0, outputtext, outputtext.Length);

            bus.stopInTask();
            if (wait>50) System.Threading.Thread.Sleep(wait-50);
        }

        public void RunDES(ref byte[] outputtext, byte[] inputtext, int wait)
        {
            bus.restartInTask();

            bus.SbusWriteBurst((uint)(Address.ITEXT0 + 0x0020), inputtext, inputtext.Length);
            bus.SbusWrite((uint)Address.CONT, (uint)Cont.RUN);
            WaitDone();
            outputtext = new byte[8];
            bus.SbusReadBurst((uint)Address.OTEXT0, outputtext, outputtext.Length);

            bus.stopInTask();
            if (wait > 50) System.Threading.Thread.Sleep(wait - 50);
        }


        private void WaitDone()
        {
            while (bus.SbusRead((uint)Address.CONT) != 0x0000)
            {
                System.Threading.Thread.Sleep(10);
            }
        }

        private enum Address : ushort
        {
            CONT = 0x0002,
            MODE = 0x000c,
            KEY0 = 0x0100,
            ITEXT0 = 0x0120,
            OTEXT0 = 0x0180
        }

        private enum Mode : ushort
        {
            ENC = 0x0000,
            DEC = 0x0001
        }

        private enum Cont : ushort
        {
            ZERO = 0x0000,
            RUN = 0x0001,
            KSET = 0x0002,
            IPRST = 0x0004
        }
    }
}
