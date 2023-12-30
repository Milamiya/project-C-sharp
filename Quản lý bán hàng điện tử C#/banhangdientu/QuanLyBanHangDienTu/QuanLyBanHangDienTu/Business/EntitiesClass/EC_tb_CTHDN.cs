using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHangDienTu.Business.EntitiesClass
{
    class EC_tb_CTHDN
    {
        private string sohdn;
        private string mahang;
        private string soluong;
        private string dongia;
        private string giamgia;
        private string thanhtien;

        public string SOHDN
        {
            get
            {
                return sohdn;
            }
            set
            {
                sohdn = value;
                if (sohdn == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string MAHANG
        {
            get
            {
                return mahang;
            }
            set
            {
                mahang = value;
                if (mahang == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string SOLUONG
        {
            get
            {
                return soluong;
            }
            set
            {
                soluong = value;
            }
        }
        public string DONGIA
        {
            get
            {
                return dongia;
            }
            set
            {
                dongia = value;
            }
        }
        public string GIAMGIA
        {
            get
            {
                return giamgia;
            }
            set
            {
                giamgia = value;
            }
        }
        public string THANHTIEN
        {
            get
            {
                return thanhtien;
            }
            set
            {
                thanhtien = value;
            }
        }
    }
}
