using System;
using System.Collections.Generic;
using System.Text;

namespace ShutdownManager.Modules
{
    public class SumDayOfYear
    {
        public int SumDay(int intNam, int intThang, int intNgay)
        {
            int intSoNam = ((intNam - 1) * 365) + ((intNam - 1) / 4);
            int i;
            if (intNam % 4 == 0)
            {
                i = 1;
            }
            else
            {
                i = 0;
            }
            int Thang1 = 31;
            int Thang2 = Thang1 + 28 + i;
            int Thang3 = Thang2 + 31;
            int Thang4 = Thang3 + 30;
            int Thang5 = Thang4 + 31;
            int Thang6 = Thang5 + 30;
            int Thang7 = Thang6 + 31;
            int Thang8 = Thang7 + 31;
            int Thang9 = Thang8 + 30;
            int Thang10 = Thang9 + 31;
            int Thang11 = Thang10 + 30;
            int Thang12 = Thang11 + 31;
            int intSoThang = intThang - 1;
            if (intSoThang == 0)
            {
                intSoThang = 0;
            }
            if (intSoThang == 1)
            {
                intSoThang = Thang1;
            }
            if (intSoThang == 2)
            {
                intSoThang = Thang2;
            }
            if (intSoThang == 3)
            {
                intSoThang = Thang3;
            }
            if (intSoThang == 4)
            {
                intSoThang = Thang4;
            }
            if (intSoThang == 5)
            {
                intSoThang = Thang5;
            }
            if (intSoThang == 6)
            {
                intSoThang = Thang6;
            }
            if (intSoThang == 7)
            {
                intSoThang = Thang7;
            }
            if (intSoThang == 8)
            {
                intSoThang = Thang8;
            }
            if (intSoThang == 9)
            {
                intSoThang = Thang9;
            }
            if (intSoThang == 10)
            {
                intSoThang = Thang10;
            }
            if (intSoThang == 11)
            {
                intSoThang = Thang11;
            }

            return intSoNam + intSoThang + intNgay;
        }
    }
}
