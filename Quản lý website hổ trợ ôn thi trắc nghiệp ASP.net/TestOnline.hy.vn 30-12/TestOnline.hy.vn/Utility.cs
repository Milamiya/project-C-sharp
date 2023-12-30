using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace sdh.utehy.edu.vn
{
    public class Utility
    {
        public Utility()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public enum State
        {
            APPROVE,
            DELETED,
            DRAFT,
            PUBLISH,
            WAIT
        }
        public enum Log
        {
            CREATED,
            UPDATED,
            DELETED,
            APPROVE,
            PUBLISH,
            REMOVED,
            PREVIEW,
            ISANSWER
        }
        public enum Code
        {
            ANNOUNCES
        }
        /// <summary>
        /// Phương thức này lấy về định dạnh ngày tháng do người dùng chọn
        /// </summary>
        /// <param name="string">Ngày cần định dạng</param>
        /// <returns>String</returns>
        public static string DateFormat(object date)
        {
            DateTime d = Convert.ToDateTime(date);
            //if (System.Threading.Thread.CurrentThread.CurrentCulture.Name == "vi-VN")
            return d.ToString("dd/MM/yyyy").ToUpper();
            //else return d.ToString("MM/dd/yyyy").ToUpper();
        }
        public static string DateFormat(DateTime date)
        {
            //if (System.Threading.Thread.CurrentThread.CurrentCulture.Name == "vi-VN")
            return date.ToString("dd/MM/yyyy").ToUpper();
            //else return d.ToString("MM/dd/yyyy").ToUpper();
        }
        public static string DateFormat1(DateTime date)
        {
            //if (System.Threading.Thread.CurrentThread.CurrentCulture.Name == "vi-VN")
            return date.ToString("MM/dd/yyyy").ToUpper();
            //else return d.ToString("MM/dd/yyyy").ToUpper();
        }
        public static string GetFullDateTime(object date)
        {
            DateTime d = Convert.ToDateTime(date);
            string full = "";
            switch (d.DayOfWeek)
            {
                case DayOfWeek.Monday: full += "Thứ hai, "; break;
                case DayOfWeek.Tuesday: full += "Thứ ba, "; break;
                case DayOfWeek.Wednesday: full += "Thứ tư, "; break;
                case DayOfWeek.Thursday: full += "Thứ năm, "; break;
                case DayOfWeek.Friday: full += "Thứ sáu, "; break;
                case DayOfWeek.Saturday: full += "Thứ bảy, "; break;
                case DayOfWeek.Sunday: full += "Chủ nhật, "; break;
            }
            full += d.ToString("dd/MM/yyyy hh:mm");

            return full;

        }
        public static string ConvertDate(string date)
        {
            try
            {
                string[] tmp = date.Split(new char[1] { '/' });
                if (tmp.Length > 2)
                {
                    return tmp[1] + "/" + tmp[0] + "/" + tmp[2];
                }
                return "";
            }
            catch
            {
                return "";
            }
        }
    }
}
