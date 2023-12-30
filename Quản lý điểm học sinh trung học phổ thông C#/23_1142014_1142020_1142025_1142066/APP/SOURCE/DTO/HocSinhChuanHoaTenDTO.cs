using System;
using System.Collections;

namespace QLHS.DTO
{
    public class HocSinhChuanHoaTenDTO
    {
        public int STT { get; set; }
        public string MaHocSinh { get; set; }
        public string TenHocSinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Ten { get; set; }
        public string TenLot { get; set; }
        public string Ho { get; set; }

        public static int SoSanh(string sv1, string sv2)
        {
            return sv1.CompareTo(sv2);
        }

        #region Nested type: newHocSinhChuanHoaTenDTO

        public class newHocSinhChuanHoaTenDTO : IComparer
        {
            #region IComparer Members

            public int Compare(object sinhvien1, object sinhvien2)
            {
                var sv1 = sinhvien1 as HocSinhChuanHoaTenDTO;
                var sv2 = sinhvien2 as HocSinhChuanHoaTenDTO;
                int kt = 0;
                string[] str1 = sv1.TenHocSinh.ToLower().Split(' ');
                string[] str2 = sv2.TenHocSinh.ToLower().Split(' ');
                kt = SoSanh(str1[str1.Length - 1], str2[str2.Length - 1]); //so sanh theo ten
                if (kt == 0)
                {
                    kt = SoSanh(str1[0], str2[0]); //so sanh theo ho
                }
                if (kt == 0)
                {
                    string tam1 =
                        sv1.TenHocSinh.Substring(str1[0].Length,
                                                 (sv1.TenHocSinh.Length - str1[0].Length - str1[str1.Length - 1].Length -
                                                  1)).Trim();
                    string tam2 =
                        sv2.TenHocSinh.Substring(str2[0].Length,
                                                 (sv2.TenHocSinh.Length - str2[0].Length - str2[str2.Length - 1].Length -
                                                  1)).Trim();
                    kt = SoSanh(tam1, tam2);
                }
                return kt;
            }

            #endregion
        }

        #endregion
    }
}