using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHangDienTu.Business.EntitiesClass
{
    class EC_tb_HDB
    {
        private string sohdb;
        private string manv;
        private string ngayban;
        private string makh;
        private string tongtien;

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
                    throw new Exception("Mã không được bỏ trống");
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
        public string MAKH
        {
            get
            {
                return makh;
            }
            set
            {
                makh = value;
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
