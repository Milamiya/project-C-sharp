using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHangDienTu.Business.EntitiesClass
{
    class EC_tb_HDN
    {
        private string sohdn;
        private string manv;
        private string ngaynhan;
        private string mancc;
        private string tongtien;

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
        public string NGAYNHAN
        {
            get
            {
                return ngaynhan;
            }
            set
            {
                ngaynhan = value;
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
