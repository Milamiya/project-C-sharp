using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SteganographyBMP
{
    class CryptoHelper
    {
        public static byte[] Encrypt(byte[] message,string password)
        {
            return CommonMethod(message, password);
        }

        public static byte[] Decrypt(byte[] message, string password)
        {
            return CommonMethod(message, password);
        }

        // ham su dung chung cho ca viec ma hoa lan giai ma
        private static byte[] CommonMethod(byte[] message, string password)
        {
            byte[] salt = { 35, 1, 76 };    // dung cho viec sinh khoa
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(password, salt);
            byte[] key = pdb.GetBytes(128);     // dua doi tuong pdb ve dang khoa 128 bit
            byte[] retMessage = new byte[message.Length];
            for (int i = 0; i < message.Length; i++)
            {
                int index = i % key.Length;     // vi chieu dai cua thong diep co the lon hon chieu dai cua khoa
                retMessage[i] = (Byte)(key[index] ^ message[i]);    // thuc hien phep XOR , muc dich la sau khi thuc hien phep XOR 2 lan ta se duoc nguyen ban
            }

            return retMessage;  
        }
    }
}
