using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteganographyBMP
{
    class BitWise
    {
        public static byte Extract(byte B, int pos)     // trich 1 bit tu byteA tai vi tri bit pos
        {
            return (byte)((B & (1 << pos)) >> pos);     // cao tham that
        }

        public static void Replace(ref byte B, int pos, byte value)
        {
            B= (byte) (value == 1 ? B | (1 << pos) : B & ~(1 << pos));    //potay.com.vn
        }
    }
}
