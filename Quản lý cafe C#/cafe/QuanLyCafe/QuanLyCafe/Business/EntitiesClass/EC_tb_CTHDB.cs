using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCafe.Business.EntitiesClass
{
    class EC_tb_CTHDB
    {
        private string mahdb;
        private string masp;
        private string tensp;
        private string soluong;
        private string thanhtien;
        private string khuyenmai;

        public string MAHDB
        {
            get
            {
                return mahdb;
            }
            set
            {
                mahdb = value;
                if (mahdb == "")
                {
                    throw new Exception("Mã không để trống");
                }
            }
        }
        public string MASP
        {
            get
            {
                return masp;
            }
            set
            {
                masp = value;
                if (masp == "")
                {
                    throw new Exception("Mã không để trống");
                }
            }
        }
        public string TENSP
        {
            get
            {
                return tensp;
            }
            set
            {
                tensp = value;
                if (tensp == "")
                {
                    throw new Exception("Tên sản phẩm không để trống");
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
        public string KHUYENMAI
        {
            get
            {
                return khuyenmai;
            }
            set
            {
                khuyenmai = value;
            }
        }
    }
}
