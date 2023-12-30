using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCafe.Business.EntitiesClass
{
    class EC_tb_HDB
    {
        private string mahdb;
        private string ngayban;
        private string manv;
        private string makh;
        private string tongtien;

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
        public string NGAYBAN
        {
            get
            {
                return ngayban;
            }
            set
            {
                ngayban = value;
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
        public string MAKH
        {
            get
            {
                return makh;
            }
            set
            {
                makh = value;
                if (makh == "")
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
