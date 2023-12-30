using System;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace QuanLyDaoTao.Utilities
{
    /// <summary>
    /// Class tiện ích. Gồm những phương thức tĩnh.
    /// </summary>
    public static class UtilitiesClass
    {
        /// <summary>
        /// Mã hóa chuỗi bằng MD5
        /// </summary>
        /// <param name="text">Chuỗi cần mã hóa</param>
        /// <returns>String: Chuỗi sau khi mã hóa</returns>
        public static string MaHoaMD5(string text)
        {
            text = text.Trim();
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            //chuyển chuỗi truyền vào sang khối các byte
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            //băm MD5
            bytes = md5Hasher.ComputeHash(bytes);
            StringBuilder str = new StringBuilder();
            foreach (byte b in bytes)
            {
                str.Append(b.ToString("x2"));
            }
            return str.ToString();
        }

        /// <summary>
        /// Lấy tất cả các ngày đầu tuần là thứ hai của 1 tháng
        /// </summary>
        public static List<DateTime> GetWeeks(this DateTime date)
        {
            // first generate all dates in the month of 'date'
            var dates = Enumerable.Range(1, DateTime.DaysInMonth(date.Year, date.Month)).Select(n => new DateTime(date.Year, date.Month, n));
            // then filter the only the start of weeks
            var weekends = from d in dates
                           where d.DayOfWeek == DayOfWeek.Monday
                           select d;
            return weekends.ToList<DateTime>();
        }

        /// <summary>
        /// Lấy ngày đầu tuần của 1 ngày
        /// </summary>
        public static DateTime GetWeek(this DateTime date)
        {
            // first generate all dates in the month of 'date'
            var dates = Enumerable.Range(1, DateTime.DaysInMonth(date.Year, date.Month)).Select(n => new DateTime(date.Year, date.Month, n));
            // then filter the only the start of weeks
            return dates.Single(d => d.DayOfWeek == DayOfWeek.Monday && d >= date && d <= date.AddDays(7)).AddDays(-7);
        }

        #region Đọc số thành chữ
        /// <summary>
        /// Chuyển từng nhóm 3 số sang chữ
        /// </summary>
        private static string ConvertGroup(string so, int group)
        {
            try
            {
                string kq = "";
                for (int i = 0; i <= so.Length - 1; i++)
                {
                    switch (int.Parse(so[i].ToString()))
                    {
                        case 0:
                            if (so.Length - 1 - i != 0)
                                kq += "không ";
                            break;
                        case 1:
                            if (i == 0 && !(so.Length == 2 && so[0] == '1'))
                                kq += "một ";
                            else if (i == 1 && so.Length != 2)
                                kq += "mười ";
                            else if (i == 2)
                                if (so[1] == '1')
                                    kq += "một ";
                                else
                                    kq += "mốt ";
                            else if (i == 1)
                                kq += "một ";
                            break;
                        case 2:
                            kq += "hai ";
                            break;
                        case 3:
                            kq += "ba ";
                            break;
                        case 4:
                            kq += "bốn ";
                            break;
                        case 5:
                            if (2 == i)
                                kq += "lăm ";
                            else
                                kq += "năm ";
                            break;
                        case 6:
                            kq += "sáu ";
                            break;
                        case 7:
                            kq += "bảy ";
                            break;
                        case 8:
                            kq += "tám ";
                            break;
                        case 9:
                            kq += "chín ";
                            break;
                        default:
                            break;
                    }//end switch

                    if (so.Length == 3)
                    {
                        switch (i)
                        {
                            case 1:
                                if (so[1] == '1')
                                    kq += "";
                                else
                                    kq += "mươi ";
                                break;
                            case 0:
                                kq += "trăm ";
                                break;
                            default:
                                break;
                        }//end switch
                    }
                    else if (so.Length == 2)
                    {
                        switch (i)
                        {
                            case 1:
                                kq += "";
                                break;
                            case 0:
                                if (so[i] == '1')
                                    kq += "mười ";
                                else
                                    kq += "mươi ";
                                break;
                            default:
                                break;
                        }//end switch
                    }
                }//end for

                switch (group)
                {
                    case 1:
                    case 4:
                    case 7:
                        kq += "ngàn ";
                        break;
                    case 2:
                    case 5:
                    case 8:
                        kq += "triệu ";
                        break;
                    case 3:
                    case 6:
                    case 9:
                        kq += "tỷ ";
                        break;
                    default:
                        kq += "";
                        break;
                }
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string DocSo(string soCanDoc)
        {
            try
            {
                string chu = "";
                int soGroup = soCanDoc.Length / 3;
                if (soCanDoc.Length % 3 != 0)
                    soGroup += 1;

                chu += ConvertGroup(soCanDoc.Substring(0, soCanDoc.Length - ((soGroup - 1) * 3)), soGroup - 1);

                for (int i = soGroup - 1; i > 0; i--)
                {
                    chu += ConvertGroup(soCanDoc.Substring(soCanDoc.Length - (i * 3), 3), i - 1);
                }
                return (chu[0].ToString().ToUpper() + chu.Substring(1)).Trim();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}