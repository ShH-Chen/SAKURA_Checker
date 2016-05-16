using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;



namespace SAKURA
{
    class DES
    {
        private DESCryptoServiceProvider des;
        private ICryptoTransform enc;
        private ICryptoTransform dec;

        public DES()
        {
            des = new DESCryptoServiceProvider();
            des.BlockSize = 64;
            des.FeedbackSize = 64;
            des.KeySize = 64;
            des.Mode = CipherMode.ECB;
            des.Padding = PaddingMode.None;
            des.IV = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            des.Key = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08 };
        }

        public void SetKey(byte[] key)
        {
            byte[] deskey = new byte[8];
            if (key.Length > des.KeySize / 8) {
                Array.Copy(key,0, deskey,0, 8);
            }
            else
            { Array.Copy(key,0, deskey,0, key.Length); }
            des.Key = deskey;
            enc = des.CreateEncryptor(des.Key, des.IV);
            dec = des.CreateDecryptor(des.Key, des.IV);
        }

        public void Encrypt(ref byte[] ciphertext, byte[] plaintext)
        {
            ciphertext = enc.TransformFinalBlock(plaintext, 0, des.KeySize/8);
        }

        public void Decrypt(byte[] plaintext, byte[] ciphertext)
        {
            plaintext = dec.TransformFinalBlock(ciphertext, 0, des.KeySize/8);
        }
    }
}

