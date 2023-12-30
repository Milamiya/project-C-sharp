using System;
using System.Collections.Generic;
using System.Text;

namespace LichCongTac.Modules
{
    public class ChuyenDoiNgay
    {
        private double timeZone = 7.0 ;
        //Lấy Ngày Julius
        public long getJulius(int intNgay, int intThang, int intNam)
        {
            int a, y, m, jd;
            a = (int)((14 - intThang) / 12);
            y = intNam + 4800 - a;
            m = intThang + 12 * a - 3;
            jd = intNgay + (int)((153 * m + 2) / 5) + 365 * y + (int)(y / 4) - (int)(y / 100) + (int)(y / 400) - 32045;
            if (jd < 2299161)
            {
                jd = intNgay + (int)((153 * m + 2) / 5) + 365 * y + (int)(y / 4) - 32083;
            }
            return jd;
        }

        // Từ ngày Julius chuyển ra ngày thường
        public string jdToDate(int jd)
        {
            int a, b, c, d, e, m; 
            int day, month, year;
            if (jd > 2299160)
            { // After 5/10/1582, Gregorian calendar
                a = jd + 32044;
                b = (int)((4 * a + 3) / 146097);
                c = a - (int)((b * 146097) / 4);
            }
            else
            {
                b = 0;
                c = jd + 32082;
            }
            d = (int)((4 * c + 3) / 1461);
            e = c - (int)((1461 * d) / 4);
            m = (int)((5 * e + 2) / 153);
            day = e - (int)((153 * m + 2) / 5) + 1;
            month = m + 3 - 12 * (int)(m / 10);
            year = b * 100 + d - 4800 + (int)(m / 10);
            return day.ToString() + "/" + month.ToString() + "/" + year.ToString(); 
        }

        //Tính ngày Sóc
        public int getNewMoonDay(int k)
        {
            double T, T2, T3, dr, Jd1, M, Mpr, F, C1, deltat, JdNew;
            T = k / 1236.85;
            T2 = T * T;
            T3 = T2 * T;
            dr = Math.PI / 180;
            Jd1 = 2415020.75933 + 29.53058868 * k + 0.0001178 * T2 - 0.000000155 * T3;
            Jd1 = Jd1 + 0.00033 * Math.Sin((166.56 + 132.87 * T - 0.009173 * T2) * dr); // Mean new moon
            M = 359.2242 + 29.10535608 * k - 0.0000333 * T2 - 0.00000347 * T3; // Sun's mean anomaly
            Mpr = 306.0253 + 385.81691806 * k + 0.0107306 * T2 + 0.00001236 * T3; // Moon's mean anomaly
            F = 21.2964 + 390.67050646 * k - 0.0016528 * T2 - 0.00000239 * T3; // Moon's argument of latitude
            C1 = (0.1734 - 0.000393 * T) * Math.Sin(M * dr) + 0.0021 * Math.Sin(2 * dr * M);
            C1 = C1 - 0.4068 * Math.Sin(Mpr * dr) + 0.0161 * Math.Sin(dr * 2 * Mpr);
            C1 = C1 - 0.0004 * Math.Sin(dr * 3 * Mpr);
            C1 = C1 + 0.0104 * Math.Sin(dr * 2 * F) - 0.0051 * Math.Sin(dr * (M + Mpr));
            C1 = C1 - 0.0074 * Math.Sin(dr * (M - Mpr)) + 0.0004 * Math.Sin(dr * (2 * F + M));
            C1 = C1 - 0.0004 * Math.Sin(dr * (2 * F - M)) - 0.0006 * Math.Sin(dr * (2 * F + Mpr));
            C1 = C1 + 0.0010 * Math.Sin(dr * (2 * F - Mpr)) + 0.0005 * Math.Sin(dr * (2 * Mpr + M));
            if (T < -11)
            {
                deltat = 0.001 + 0.000839 * T + 0.0002261 * T2 - 0.00000845 * T3 - 0.000000081 * T * T3;
            }
            else
            {
                deltat = -0.000278 + 0.000265 * T + 0.000262 * T2;
            }
            JdNew = Jd1 + C1 - deltat;
            return (int)(JdNew + 0.5 + timeZone / 24);
        }

        //Tính toạ độ mặt trời
        public int getSunLongitude(int jdn)
        {
            double T, T2, dr, M, L0, DL, L;
            T = (jdn - 2451545.5 - timeZone / 24) / 36525; // Time in Julian centuries from 2000-01-01 12:00:00 GMT
            T2 = T * T;
            dr = Math.PI / 180; // degree to radian
            M = 357.52910 + 35999.05030 * T - 0.0001559 * T2 - 0.00000048 * T * T2; // mean anomaly, degree
            L0 = 280.46645 + 36000.76983 * T + 0.0003032 * T2; // mean longitude, degree
            DL = (1.914600 - 0.004817 * T - 0.000014 * T2) * Math.Sin(dr * M);
            DL = DL + (0.019993 - 0.000101 * T) * Math.Sin(dr * 2 * M) + 0.000290 * Math.Sin(dr * 3 * M);
            L = L0 + DL; // true longitude, degree
            L = L * dr;
            L = L - Math.PI * 2 * (int)(L / (Math.PI * 2)); // Normalize to (0, 2*PI)
            return (int)(L / Math.PI * 6);
        }

        //Tìm ngày bắt đầu tháng 11 âm lịch 
        public int getLunarMonthll(int intNam)
        {
            double k, off, nm, sunLong;
            off = getJulius(31, 12, intNam) - 2415021;
            k = (int)(off / 29.530588853);
            nm = getNewMoonDay((int)k);
            sunLong = getSunLongitude((int)nm); // sun longitude at local midnight
            if (sunLong >= 9)
            {
                nm = getNewMoonDay((int)k - 1);
            }
            return (int)nm;
        }

        //Xác định tháng nhuận
        public int getLeapMonthOffset(double a11)
        {
            double last, arc;
            int k, i;
            k = (int)((a11 - 2415021.076998695) / 29.530588853 + 0.5);
            last = 0;
            i = 1; // We start with the month following lunar month 11
            arc = getSunLongitude((int)getNewMoonDay((int)(k + i)));
            do
            {
                last = arc;
                i++;
                arc = getSunLongitude((int)getNewMoonDay((int)(k + i)));
            } while (arc != last && i < 14);
            return i - 1;
        }

        //Đổi ngày dương ra ngày âm
        public string convertSolar2Lunar(int intNgay, int intThang, int intNam)
        {
            double dayNumber, monthStart, a11, b11, lunarDay, lunarMonth, lunarYear;
            //double lunarLeap;
            int k, diff;
            dayNumber = getJulius(intNgay,intThang,intNam);
            k = (int)((dayNumber - 2415021.076998695) / 29.530588853);
            monthStart = getNewMoonDay(k + 1);
            if (monthStart > dayNumber)
            {
                monthStart = getNewMoonDay(k);
            }
            a11 = getLunarMonthll(intNam);
            b11 = a11;
            if (a11 >= monthStart)
            {
                lunarYear = intNam;
                a11 = getLunarMonthll(intNam - 1);
            }
            else
            {
                lunarYear = intNam + 1;
                b11 = getLunarMonthll(intNam + 1);
            }
            lunarDay = dayNumber - monthStart + 1;
            diff = (int)((monthStart - a11) / 29);
            //lunarLeap = 0;
            lunarMonth = diff + 11;
            if (b11 - a11 > 365)
            {
                int leapMonthDiff = getLeapMonthOffset(a11);
                if (diff >= leapMonthDiff)
                {
                    lunarMonth = diff + 10;
                    if (diff == leapMonthDiff)
                    {
                        //lunarLeap = 1;
                    }
                }
            }
            if (lunarMonth > 12)
            {
                lunarMonth = lunarMonth - 12;
            }
            if (lunarMonth >= 11 && diff < 4)
            {
                lunarYear -= 1;
            }
            string strNgay = lunarDay.ToString();
            string strThang = lunarMonth.ToString();
            //string strNam = lunarYear.ToString();
            return strNgay + "/" + strThang;
        }
    }
}
