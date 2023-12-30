using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCafe.Business.EntitiesClass
{
    class EC_tb_HDN
    {
        private string mahdn;
        private string ngaynhap;
        private string manv;
        private string mancc;
        private string tongtien;

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
        public string NGAYNHAP
        {
            get
            {
                return ngaynhap;
            }
            set
            {
                ngaynhap = value;
            }
        }
        public string MANV
        {
            get
            {
                return manv;
            }
            set
            {
                manv = value;
                if (manv == "")
                {
                    throw new Exception("Mã không để trống");
                }
            }
        }
        public string MANCC
        {
            get
            {
                return mancc;
            }
            set
            {
                mancc = value;
                if (mancc == "")
                {
                    throw new Exception("Mã không để trống");
                }
            }
        }
        public string TONGTIEN
        {
            get
            {
                return tongtien;
            }
            set
            {
                tongtien = value;
            }
        }
    }
}
