using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace UIT_Pokemon
{
    public class TimePlay
    {
        public int hour, minute, second;
        public String showtime="";
        public TimePlay()
        {
            Reset();
        }
        public void Reset()
        {
            hour = minute = second = 0;
            showtime = "00 : 00 : 00 ";
        }
        public void lifetime()
        {
            showtime="";
            second++;
            if(second>=60)
            {
                second -= 60;
                minute++;
            }
            if (minute >= 60)
            {
                minute -= 60;
                hour++;
            }
            if (hour < 10)
                showtime += "0";
            showtime += hour.ToString()+" : ";
            if (minute < 10)
                showtime += "0";
            showtime += minute.ToString() + " : ";
            if (second < 10)
                showtime += "0";
            showtime +=  second.ToString() ;
        }
    }
}
