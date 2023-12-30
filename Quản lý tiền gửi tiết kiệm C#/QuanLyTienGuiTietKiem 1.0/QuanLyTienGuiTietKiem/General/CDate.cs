using System;
using System.Collections.Generic;

using System.Text;
using CDateExeption;

namespace QuanLyTienGuiTietKiem.General
{
    public class CDate
    {
        int m_Year;
        int m_Month;
        int m_Day;

        //Thang ung voi so ngay la:     0   1   2   3   4   5   6   7   8   9  10  11  12
        int[] NgayThang = new int[13] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        
        //Ham dung khong doi so
        public CDate()
        {
            m_Year = 0;
            m_Month = 0;
            m_Day = 0;
        }

        //Ham dung co 1 doi so kieu CDate
        public CDate(CDate d)
        {
            if (IsLeapYear(d.m_Year))
                NgayThang[2] = 29;

            this.m_Year = d.m_Year;
            this.m_Month = d.m_Month;
            this.m_Day = d.m_Day;
        }

        //Ham dung co 3 doi so year, month, day
        public CDate(int year, int month, int day)
        {
            if (!IsDay(day, month, year))
                throw new CDateExe("Ngay khong hop le!");
            if (!IsMonth(month))
                throw new CDateExe("Thang khong hop le!");
            if (!IsYear(year))
                throw new CDateExe("Nam khong hop le!");

            if (IsLeapYear(year))
                NgayThang[2] = 29;

            this.m_Year = year;
            this.m_Month = month;
            this.m_Day = day;
        }

        //Ham dung co 1 doi so DateTime, lay ngay thang hien tai
        public CDate(DateTime dt)
        {
            if (IsLeapYear(dt.Year))
                NgayThang[2] = 29;

            this.m_Year = dt.Year;
            this.m_Month = dt.Month;
            this.m_Day = dt.Day;
        }

        public DateTime ToDateTime
        {
            get { return new DateTime(m_Year, m_Month, m_Day); }
        }

       
        //public int sumDateTime(CDate c)
        //{
        //    int tong = 0;
        //    tong = c.m_Year + c.m_Month + c.m_Day;
        //    return tong;
        //}

        //public static bool operator >(CDate d1, CDate d2)
        //{
        //    return sumDateTime(d1) > d2.sumDateTime(d2);
        //}

        //public static bool operator <(CDate d1, CDate d2)
        //{
        //    return d1.sumDateTime(d1) > d2.sumDateTime(d2);
        //}
        //Year property
        public int Year
        {
            get
            {
                return this.m_Year;
            }
            set
            {
                if (!IsYear(value))
                    throw new CDateExe("Nam khong hop le");
                this.m_Year = value;
            }
        }

        //Month property
        public int Month
        {
            get
            {
                return this.m_Month; 
            }
            set
            {
                if (!IsMonth(value))
                    throw new CDateExe("Thang khong hop le");
                this.m_Month = value;
            }
        }

        //Day property
        public int Day
        {
            get
            {
                return this.m_Day;
            }
            set
            {
                if (!IsDay(value, m_Month, m_Year))
                    throw new CDateExe("Ngay khong hop le");
                if (IsLeapYear())
                    NgayThang[2] = 29;
                this.m_Day = value;
            }
        }

        //-------------------------------------------------------
        //Phuong thuc tang len 1 nam
        public void IncYear()
        {
            m_Year++;
        }

        //Phuong thuc giam xuong 1 nam
        public void DecYear()
        {
            m_Year--;
            if (m_Year < 0)
                throw new CDateExe("Khong the giam nam duoc nua!");
        }

        //Phuong thuc tang len 1 thang
        public void IncMonth()
        {
            m_Month++;
            if (m_Month == 13)
            {
                IncYear();
                m_Month = 0;
            }
        }

        //Phuong thuc giam xuong 1 thang
        public void DecMonth()
        {
            m_Month--;
            if (m_Month == 0)
            {
                DecYear();
                m_Month = 12;
            }
        }

        //Phuong thuc tang len 1 ngay
        public void IncDay()
        {
            m_Day++;
            if (m_Day == NgayThang[m_Month] + 1)
            {
                IncMonth();
                m_Day = 1;
            }
        }

        //Phuong thuc giam xuong 1 ngay
        public void DecDay()
        {
            m_Day--;
            if (m_Day == 0)
            {
                DecMonth();
                m_Day = NgayThang[m_Month];
            }
        }

        //-------------------------------------------------------
        //Phuong thuc tang len n nam
        public void IncYear(int n)
        {
            m_Year = m_Year + n;
        }
        //Phuong thuc giam xuong n nam
        public void DecYear(int n)
        {
            for (int i = 0; i < n; i++)
                DecYear();
        }
        //-------------------------------------------------------
        //Phuong thuc tang len n thang
        public void IncMonth(int n)
        {
            for (int i = 0; i < n; i++)
                IncMonth();
        }
        //Phuong thuc giam xuong n thang
        public void DecMonth(int n)
        {
            for (int i = 0; i < n; i++)
                DecMonth();
        }
        //-------------------------------------------------------
        //Phuong thuc tang len n ngay
        public void IncDay(int n)
        {
            for (int i = 0; i < n; i++)
                IncDay();
        }
        //Phuong thuc giam xuong n ngay
        public void DecDay(int n)
        {
            for (int i = 0; i < n; i++)
                DecDay();
        }
        //-------------------------------------------------------
        //Kiem tra nam hop le
        public bool IsYear()
        {
            return (m_Year >= 0);
        }
        public bool IsYear(int y)
        {
            return (y >= 0);
        }
        //Kiem tra thang hop le
        public bool IsMonth()
        {
            return (m_Month >= 1 && m_Month <= 12);
        }
        public bool IsMonth(int m)
        {
            return (m >= 1 && m <= 12);
        }
        //Kiem tra ngay hop le
        public bool IsDay()
        {
            return (m_Day >= 1 && m_Day <= NgayThang[m_Month]);
        }
        public bool IsDay(int d, int m, int y)
        {
            if (IsLeapYear(y) && m == 2)
                return (d <= 29 && d > 0);
            else if (m == 2)
                return (d <= 28 && d > 0);
            else
                return (d >= 1 && d <= NgayThang[m_Month]);
        }
        // Nam nhuan la nam: + Chia het cho 400
        //                   + Chia het cho 4 va khong chia het cho 100
        public bool IsLeapYear()
        {
            return ((m_Year % 400 == 0) || (m_Year % 4 == 0 && m_Year % 100 != 100));
        }
        //
        public bool IsLeapYear(int y)
        {
            return ((y % 400 == 0) || (y % 4 == 0 && y % 100 != 100));
        }
        //-------------------------------------------------------
        public CDate PreYear()
        {
            CDate d = new CDate(m_Year, m_Month, m_Day);
            d.DecYear();
            return d;
        }
        //
        public CDate NextYear()
        {
            CDate d = new CDate(m_Year, m_Month, m_Day);
            d.IncYear();
            return d;
        }
        //
        public CDate PreMonth()
        {
            CDate d = new CDate(m_Year, m_Month, m_Day);
            d.DecMonth();
            return d;
        }
        //
        public CDate NextMonth()
        {
            CDate d = new CDate(m_Year, m_Month, m_Day);
            d.IncMonth();
            return d;
        }
        //
        public CDate PreSecond()
        {
            CDate d = new CDate(m_Year, m_Month, m_Day);
            d.DecDay();
            return d;
        }
        //
        public CDate NextSecond()
        {
            CDate d = new CDate(m_Year, m_Month, m_Day);
            d.IncDay();
            return d;
        }
        //-------------------------------------------------------
        public CDate PreYear(int n)
        {
            CDate d = new CDate(m_Year, m_Month, m_Day);
            for (int i = 0; i < n; i++)
                d.DecYear();
            return d;
        }
        //
        public CDate NextYear(int n)
        {
            CDate d = new CDate(m_Year, m_Month, m_Day);
            for (int i = 0; i < n; i++)
                d.IncYear();
            return d;
        }
        //
        public CDate PreMonth(int n)
        {
            CDate d = new CDate(m_Year, m_Month, m_Day);
            for (int i = 0; i < n; i++)
                d.DecMonth();
            return d;
        }
        //
        public CDate NextMonth(int n)
        {
            CDate d = new CDate(m_Year, m_Month, m_Day);
            for (int i = 0; i < n; i++)
                d.IncMonth();
            return d;
        }
        //
        public CDate PreSecond(int n)
        {
            CDate d = new CDate(m_Year, m_Month, m_Day);
            for (int i = 0; i < n; i++)
                d.DecDay();
            return d;
        }
        //
        public CDate NextSecond(int n)
        {
            CDate d = new CDate(m_Year, m_Month, m_Day);
            for (int i = 0; i < n; i++)
                d.IncDay();
            return d;
        }
        //-------------------------------------------------------
        public long MonthOrder()
        {
            return (m_Year * 12 + m_Month);
        }
        //
        public int DayOrderInYear()
        {
            int tmp = 0;
            for (int i = 0; i < m_Month; i++)
            {
                tmp = NgayThang[i];
            }
            return tmp + m_Day;
        }
        //So thu tu ngay tu nam cong nguyen
        public long DayOrder()
        {
            int tmp = 0;
            for (int i = 1; i < m_Year; i++)
            {
                tmp += 365;
                if (IsLeapYear(i))
                    tmp++;
            }
            return tmp + DayOrderInYear();
        }
        //So thu tu tuan tu nam cong nguyen
        public long WeekOrder()
        {
            return DayOrder() / 7;
        }
        //-------------------------------------------------------
        public int YearDistance(CDate d)
        {
            return (Math.Abs(d.m_Year - m_Year));
        }
        //
        public long MonthDistance(CDate d)
        {
            return (Math.Abs(d.MonthOrder() - MonthOrder()));
        }
        //
        public long DayDistance(CDate d)
        {
            return (Math.Abs(d.DayOrder() - DayOrder()));
        }
    }
}
