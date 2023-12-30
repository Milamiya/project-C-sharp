using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCuaHangTivi.Business.EntitiesClass
{
    class EC_tb_CTHDN
    {
        private string sohdn;
        private string mativi;
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
            }
        }
        public string MATIVI
        {
            get
            {
                return mativi; ;
            }
            set
            {
                mativi = value;
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
