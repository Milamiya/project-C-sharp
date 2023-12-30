using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCuaHangTivi.Business.EntitiesClass
{
    class EC_tb_HDB
    {
        private string sohdb;
        private string manv;
        private string ngayban;
        private string makhach;
        private string thue;

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
                    throw new Exception("Số hóa đơn bán không được để trống");
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
        public string MAKHACH
        {
            get
            {
                return makhach;
            }
            set
            {
                makhach = value;
            }
        }
        public string THUE
        {
            get
            {
                return thue;
            }
            set
            {
                thue = value;
            }
        }
    }
}
