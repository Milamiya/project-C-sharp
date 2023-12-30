using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCafe.Business.EntitiesClass
{
    class EC_tb_CTHDN
    {
        private string mahdn;
        private string masp;
        private string soluong;
        private string dongia;
        private string thanhtien;
        private string khuyenmai;

        public string MAHDN
        {
            get
            {
                return mahdn;
            }
            set
            {
                mahdn = value;
                if (mahdn == "")
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
