using System;
using System.Collections.Generic;
using System.Text;

namespace LichCongTac.Modules
{
    public class ConvertTime
    {
        public int Convert(string str)
        {
            int intFirstColon = str.IndexOf(":");
            string strHour = str.Substring(0, intFirstColon);
            int intSpace = str.IndexOf(" ");
            string strMinutes = str.Substring(intFirstColon+1,intSpace-intFirstColon);
            string strTime = str.Substring(intSpace + 1, 2);
            int intHour = System.Convert.ToInt32(strHour);
            intHour = intHour * 60;
            int intMinutes = System.Convert.ToInt32(strMinutes);
            int intTime=0;
            if (strTime == "AM")
            {
                intTime = 0;
            }
            if (strTime == "PM")
            {
                intTime = 12 * 60;
            }
            int intResult = intHour + intMinutes + intTime;
            return intResult;
        }
    }
}
