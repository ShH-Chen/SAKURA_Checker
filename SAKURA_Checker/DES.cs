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
        }

        public void SetKey(byte[] key)
        {
            des.Key = key;
            enc = des.CreateEncryptor(des.Key, des.IV);
            dec = des.CreateDecryptor(des.Key, des.IV);
        }

        public void Encrypt(ref byte[] ciphertext, byte[] key, byte[] plaintext)
        {
            ciphertext = enc.TransformFinalBlock(plaintext, 0, plaintext.Length);
        }

        public void Decrypt(byte[] plaintext, byte[] ciphertext)
        {
            plaintext = dec.TransformFinalBlock(ciphertext, 0, ciphertext.Length);
        }
    }
}

