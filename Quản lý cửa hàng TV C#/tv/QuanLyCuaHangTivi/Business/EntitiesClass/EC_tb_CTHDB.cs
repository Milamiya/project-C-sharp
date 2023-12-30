using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCuaHangTivi.Business.EntitiesClass
{
    class EC_tb_CTHDB
    {
        private string sohdb;
        private string mativi;
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
            }
        }
        public string MATIVI
        {
            get
            {
                return mativi;
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
