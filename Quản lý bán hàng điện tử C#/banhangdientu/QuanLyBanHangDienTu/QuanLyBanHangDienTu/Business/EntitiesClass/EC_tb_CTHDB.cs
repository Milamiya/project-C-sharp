using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHangDienTu.Business.EntitiesClass
{
    class EC_tb_CTHDB
    {
        private string sohdb;
        private string mahang;
        private string soluong;
        private string giamgia;
        private string thanhtien;

        public string SOHDB
        {
            get
            {
                return sohdb;
            }
            set
            {
                sohdb = value;
                if (sohdb == "")
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
