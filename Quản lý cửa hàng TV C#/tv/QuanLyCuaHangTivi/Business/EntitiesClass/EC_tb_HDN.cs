using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCuaHangTivi.Business.EntitiesClass
{
    class EC_tb_HDN
    {
        private string sohdn;
        private string manv;
        private string ngaynhap;
        private string mancc;

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
                    throw new Exception("Số hóa đơn nhập không được để trống");
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
    }
}
