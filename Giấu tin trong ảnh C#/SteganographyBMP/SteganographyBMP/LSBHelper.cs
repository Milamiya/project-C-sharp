using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SteganographyBMP
{
    class LSBHelper
    {
        public static void Encode(FileStream inStream, byte[] message, FileStream outStream)
        {
            int byteRead;       //1 byte doc vao tu inStream ( phai dung kieu int do ReadByte() tra ve kieu byte)
            byte byteWrite;     // 1 byte de viet vao ouStream
            int i = 0;          // chay trong mang byte Message
            int j = 0;          //chay tung bit trong 1 byte Message[i]
            while ((byteRead = inStream.ReadByte()) != -1)    // trong khi con chua ket thuc Stream
            {
                byteWrite = (byte)byteRead; // cast (ep kieu)

                if (i < message.Length)       // thong diep van con
                {
                    byte bit = BitWise.Extract(message[i], j++);   // trich 1 bit tu vi tri j tu message[i] ra
                    BitWise.Replace(ref byteWrite, 0, bit);            // thay the bit vao vi tri 0 (LSB)                                         
                    if (j == 8) { j = 0; i++; }    // da trich het 8 bit cua message[i]
                }
                //viet ra ouStream (co nhung truong hop nhung Byte cuoi khong bi thay doi
                outStream.WriteByte(byteWrite);
            }

            if (i < message.Length) //i chua chay het mang Messsage[]
                throw new Exception("Thong diep qua lon de giau");
        }

        public static byte[] Decode(FileStream inStream,int length) // doc ra 1 mang byte[] co chieu dai la Length trong file Stego
        {
            int byteIndex = 0;  // chay trong mang byte[]
            int bitIndex = 0;   // chay trong 8 bit cua tung byte
            byte[] arrResult=new byte[length];
            int byteRead;   // byte doc vao tu file Stego
            while ((byteRead = inStream.ReadByte()) != -1)
            {
                byte bit = BitWise.Extract((byte)byteRead, 0);  // lay ra 1 bit vi tri thu 0;
                // thay the bit nay vao trong Byte result[byteIndex] hien tai,o vi tri byteIndex
                BitWise.Replace(ref arrResult[byteIndex], bitIndex++, bit);
                if (bitIndex == 8)    // ta da thu duoc 1 byte
                {                    
                    bitIndex = 0;
                    byteIndex++;
                }
                if (byteIndex == length) break; // ta da lay du noi dung thong diep
            }
            return arrResult;
        }
    }
}
