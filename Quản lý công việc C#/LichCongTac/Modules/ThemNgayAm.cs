using System;
using System.Collections.Generic;
using System.Text;
using Pabo.Calendar;
using System.Drawing;

namespace LichCongTac.Modules
{
    public class ThemNgayAm
    {
        Modules.ChuyenDoiNgay chuyendoingay = new ChuyenDoiNgay();
        Modules.TinhThu tinhThu = new TinhThu();

        public void TextOfDay(int intNam,MonthCalendar monthCa)
        {
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

            DateItem[] d = new DateItem[365 + i];
            d.Initialize();
            for (int k = 0; k < 365 + i; k++)
                d[k] = new DateItem();
            //for (int k = intNumberYear; k < intDieuKien; k++)
            //    d[k] = new DateItem();
            for (int j = 0; j < 365+i; j++)
            {
                
                if (j < Thang1)
                {
                    d[j].Date = new DateTime(intNam, 1, j + 1);
                    string strNgayAm = chuyendoingay.convertSolar2Lunar(j + 1, 1, intNam);
                    if (strNgayAm.Substring(0,2)=="1/")
                    {
                        d[j].Text = strNgayAm;
                        strNgayAm = chuyendoingay.convertSolar2Lunar(j, 1, intNam);
                        try
                        {
                            d[j - 1].Text = strNgayAm;
                        }
                        catch
                        {
                            DateItem[] date = new DateItem[1];
                            date.Initialize();
                            date[0] = new DateItem();
                            date[0].Date = new DateTime(intNam - 1, 12, 31);
                            string strDateAm = chuyendoingay.convertSolar2Lunar(31, 12, intNam - 1);
                            date[0].Text = strDateAm;
                        }
                    }
                    else
                    {
                        int a = strNgayAm.IndexOf("/");
                        d[j].Text = strNgayAm.Substring(0, a);
                    }
                    //Chủ Nhật Màu Đỏ
                    int intTinhThu = tinhThu.ThuTrongThang(intNam, 1, j + 1);
                    if (intTinhThu % 7 == 1)
                    {
                        //d[j].TextColor = Color.Red;
                        d[j].DateColor = Color.Red;
                    }
                }
                if (j >= Thang1 && j < Thang2)
                {
                    d[j].Date = new DateTime(intNam, 2, ((j + 1) - Thang1));
                    string strNgayAm = chuyendoingay.convertSolar2Lunar((j + 1) - Thang1, 2, intNam);
                    if (strNgayAm.Substring(0, 2) == "1/")
                    {
                        d[j].Text = strNgayAm;
                        strNgayAm = chuyendoingay.convertSolar2Lunar(j - Thang1, 2, intNam);
                        d[j - 1].Text = strNgayAm;
                    }
                    else
                    {
                        int a = strNgayAm.IndexOf("/");
                        d[j].Text = strNgayAm.Substring(0, a);
                    }
                    //Chủ Nhật Màu Đỏ
                    int intTinhThu = tinhThu.ThuTrongThang(intNam, 2, ((j + 1) - Thang1));
                    if (intTinhThu % 7 == 1)
                    {
                        //d[j].TextColor = Color.Red;
                        d[j].DateColor = Color.Red;
                    }
                }
                if (j >= Thang2 && j < Thang3)
                {
                    d[j].Date = new DateTime(intNam, 3, (j + 1) - Thang2);
                    string strNgayAm = chuyendoingay.convertSolar2Lunar((j + 1) - Thang2, 3, intNam);
                    if (strNgayAm.Substring(0, 2) == "1/")
                    {
                        d[j].Text = strNgayAm;
                        strNgayAm = chuyendoingay.convertSolar2Lunar(j - Thang2, 3, intNam);
                        d[j - 1].Text = strNgayAm;
                    }
                    else
                    {
                        int a = strNgayAm.IndexOf("/");
                        d[j].Text = strNgayAm.Substring(0, a);
                    }
                    //Chủ Nhật Màu Đỏ
                    int intTinhThu = tinhThu.ThuTrongThang(intNam, 3, (j + 1) - Thang2);
                    if (intTinhThu % 7 == 1)
                    {
                        //d[j].TextColor = Color.Red;
                        d[j].DateColor = Color.Red;
                    }
                }
                if (j >= Thang3 && j < Thang4)
                {
                    d[j].Date = new DateTime(intNam, 4, (j + 1) - Thang3);
                    string strNgayAm = chuyendoingay.convertSolar2Lunar((j + 1) - Thang4, 4, intNam);
                    if (strNgayAm.Substring(0, 2) == "1/")
                    {
                        d[j].Text = strNgayAm;
                        strNgayAm = chuyendoingay.convertSolar2Lunar(j - Thang3, 4, intNam);
                        d[j - 1].Text = strNgayAm;
                    }
                    else
                    {
                        int a = strNgayAm.IndexOf("/");
                        d[j].Text = strNgayAm.Substring(0, a);
                    }
                    //Chủ Nhật Màu Đỏ
                    int intTinhThu = tinhThu.ThuTrongThang(intNam, 4, (j + 1) - Thang3);
                    if (intTinhThu % 7 == 1)
                    {
                        //d[j].TextColor = Color.Red;
                        d[j].DateColor = Color.Red;
                    }
                }
                if (j >= Thang4 && j < Thang5)
                {
                    d[j].Date = new DateTime(intNam, 5, (j + 1) - Thang4);
                    string strNgayAm = chuyendoingay.convertSolar2Lunar((j + 1) - Thang4, 5, intNam);
                    if (strNgayAm.Substring(0, 2) == "1/")
                    {
                        d[j].Text = strNgayAm;
                        strNgayAm = chuyendoingay.convertSolar2Lunar(j - Thang4, 5, intNam);
                        d[j - 1].Text = strNgayAm;
                    }
                    else
                    {
                        int a = strNgayAm.IndexOf("/");
                        d[j].Text = strNgayAm.Substring(0, a);
                    }
                    //Chủ Nhật Màu Đỏ
                    int intTinhThu = tinhThu.ThuTrongThang(intNam, 5, (j + 1) - Thang4);
                    if (intTinhThu % 7 == 1)
                    {
                        //d[j].TextColor = Color.Red;
                        d[j].DateColor = Color.Red;
                    }
                }
                if (j >= Thang5 && j < Thang6)
                {
                    d[j].Date = new DateTime(intNam, 6, (j + 1) - Thang5);
                    string strNgayAm = chuyendoingay.convertSolar2Lunar((j + 1) - Thang5, 6, intNam);
                    if (strNgayAm.Substring(0, 2) == "1/")
                    {
                        d[j].Text = strNgayAm;
                        strNgayAm = chuyendoingay.convertSolar2Lunar(j - Thang5, 6, intNam);
                        d[j - 1].Text = strNgayAm;
                    }
                    else
                    {
                        int a = strNgayAm.IndexOf("/");
                        d[j].Text = strNgayAm.Substring(0, a);
                    }
                    //Chủ Nhật Màu Đỏ
                    int intTinhThu = tinhThu.ThuTrongThang(intNam, 6, (j + 1) - Thang5);
                    if (intTinhThu % 7 == 1)
                    {
                        //d[j].TextColor = Color.Red;
                        d[j].DateColor = Color.Red;
                    }
                }
                if (j >= Thang6 && j < Thang7)
                {
                    d[j].Date = new DateTime(intNam, 7, (j + 1) - Thang6);
                    string strNgayAm = chuyendoingay.convertSolar2Lunar((j + 1) - Thang6, 7, intNam);
                    if (strNgayAm.Substring(0, 2) == "1/")
                    {
                        d[j].Text = strNgayAm;
                        strNgayAm = chuyendoingay.convertSolar2Lunar(j - Thang6, 7, intNam);
                        d[j - 1].Text = strNgayAm;
                    }
                    else
                    {
                        int a = strNgayAm.IndexOf("/");
                        d[j].Text = strNgayAm.Substring(0, a);
                    }
                    //Chủ Nhật Màu Đỏ
                    int intTinhThu = tinhThu.ThuTrongThang(intNam, 7, (j + 1) - Thang6);
                    if (intTinhThu % 7 == 1)
                    {
                        //d[j].TextColor = Color.Red;
                        d[j].DateColor = Color.Red;
                    }
                }
                if (j >= Thang7 && j < Thang8)
                {
                    d[j].Date = new DateTime(intNam, 8, (j + 1) - Thang7);
                    string strNgayAm = chuyendoingay.convertSolar2Lunar((j + 1) - Thang7, 8, intNam);
                    if (strNgayAm.Substring(0, 2) == "1/")
                    {
                        d[j].Text = strNgayAm;
                        strNgayAm = chuyendoingay.convertSolar2Lunar(j - Thang7, 8, intNam);
                        d[j - 1].Text = strNgayAm;
                    }
                    else
                    {
                        int a = strNgayAm.IndexOf("/");
                        d[j].Text = strNgayAm.Substring(0, a);
                    }
                    //Chủ Nhật Màu Đỏ
                    int intTinhThu = tinhThu.ThuTrongThang(intNam, 8, (j + 1) - Thang7);
                    if (intTinhThu % 7 == 1)
                    {
                        //d[j].TextColor = Color.Red;
                        d[j].DateColor = Color.Red;
                    }
                }
                if (j >= Thang8 && j < Thang9)
                {
                    d[j].Date = new DateTime(intNam, 9, (j + 1) - Thang8);
                    string strNgayAm = chuyendoingay.convertSolar2Lunar((j + 1) - Thang8, 9, intNam);
                    if (strNgayAm.Substring(0, 2) == "1/")
                    {
                        d[j].Text = strNgayAm;
                        strNgayAm = chuyendoingay.convertSolar2Lunar(j - Thang8, 9, intNam);
                        d[j - 1].Text = strNgayAm;
                    }
                    else
                    {
                        int a = strNgayAm.IndexOf("/");
                        d[j].Text = strNgayAm.Substring(0, a);
                    }
                    //Chủ Nhật Màu Đỏ
                    int intTinhThu = tinhThu.ThuTrongThang(intNam, 9, (j + 1) - Thang8);
                    if (intTinhThu % 7 == 1)
                    {
                        //d[j].TextColor = Color.Red;
                        d[j].DateColor = Color.Red;
                    }
                }
                if (j >= Thang9 && j < Thang10)
                {
                    d[j].Date = new DateTime(intNam, 10, (j + 1) - Thang9);
                    string strNgayAm = chuyendoingay.convertSolar2Lunar((j + 1) - Thang9, 10, intNam);
                    if (strNgayAm.Substring(0, 2) == "1/")
                    {
                        d[j].Text = strNgayAm;
                        strNgayAm = chuyendoingay.convertSolar2Lunar(j - Thang9, 10, intNam);
                        d[j - 1].Text = strNgayAm;
                    }
                    else
                    {
                        int a = strNgayAm.IndexOf("/");
                        d[j].Text = strNgayAm.Substring(0, a);
                    }
                    //Chủ Nhật Màu Đỏ
                    int intTinhThu = tinhThu.ThuTrongThang(intNam, 10, (j + 1) - Thang9);
                    if (intTinhThu % 7 == 1)
                    {
                        //d[j].TextColor = Color.Red;
                        d[j].DateColor = Color.Red;
                    }
                }
                if (j >= Thang10 && j < Thang11)
                {
                    d[j].Date = new DateTime(intNam, 11, (j + 1) - Thang10);
                    string strNgayAm = chuyendoingay.convertSolar2Lunar((j + 1) - Thang10, 11, intNam);
                    if (strNgayAm.Substring(0, 2) == "1/")
                    {
                        d[j].Text = strNgayAm;
                        strNgayAm = chuyendoingay.convertSolar2Lunar(j - Thang10, 11, intNam);
                        d[j - 1].Text = strNgayAm;
                    }
                    else
                    {
                        int a = strNgayAm.IndexOf("/");
                        d[j].Text = strNgayAm.Substring(0, a);
                    }
                    //Chủ Nhật Màu Đỏ
                    int intTinhThu = tinhThu.ThuTrongThang(intNam, 11, (j + 1) - Thang10);
                    if (intTinhThu % 7 == 1)
                    {
                        //d[j].TextColor = Color.Red;
                        d[j].DateColor = Color.Red;
                    }
                }
                if (j >= Thang11 && j < Thang12)
                {
                    d[j].Date = new DateTime(intNam, 12, (j + 1) - Thang11);
                    string strNgayAm = chuyendoingay.convertSolar2Lunar((j + 1) - Thang11, 12, intNam);
                    if (strNgayAm.Substring(0, 2) == "1/")
                    {
                        d[j].Text = strNgayAm;
                        strNgayAm = chuyendoingay.convertSolar2Lunar(j - Thang11, 12, intNam);
                        d[j - 1].Text = strNgayAm;
                    }
                    else
                    {
                        int a = strNgayAm.IndexOf("/");
                        d[j].Text = strNgayAm.Substring(0, a);
                    }
                    //Chủ Nhật Màu Đỏ
                    int intTinhThu = tinhThu.ThuTrongThang(intNam, 12, (j + 1) - Thang11);
                    if (intTinhThu % 7 == 1)
                    {
                        //d[j].TextColor = Color.Red;
                        d[j].DateColor = Color.Red;
                    }
                }

                //Ngày Tết Thì Màu Đỏ
                if (d[j].Text == "1/1")
                {
                    d[j].TextColor = Color.Red;
                    d[j].DateColor = Color.Red;
                    d[j-1].TextColor = Color.Red;
                    d[j-1].DateColor = Color.Red;
                    d[j+1].TextColor = Color.Red;
                    d[j+1].DateColor = Color.Red;
                    d[j+2].TextColor = Color.Red;
                    d[j+2].DateColor = Color.Red;
                }          
            }
            monthCa.AddDateInfo(d);
        }
    }
}
