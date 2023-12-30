using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class MeoVat
    {
        public string Mameovat { get; set; }
        public string Temeovat { get; set; }
        public string Noidung { get; set; }
        public DateTime Ngaynhap { get; set; }
        public string Nguon { get; set; }
        public string HinhAnh { get; set; }
        public string Machuyenmuc { get; set; }
        public int Danhgia { get; set; }

        public MeoVat()
        { 
        }

        public MeoVat(string mamv, string temmv, string noidung, DateTime ngaynhap, string nguon, string hinhanh, string madm,int danhgia)
        {
            Mameovat = mamv;
            Temeovat = temmv;
            Noidung = noidung;
            Ngaynhap = ngaynhap;
            Nguon = nguon;
            HinhAnh = hinhanh;
            Machuyenmuc = madm;
            Danhgia = danhgia;
        }

    }
}
