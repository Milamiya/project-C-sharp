using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCuaHangTivi.Business.EntitiesClass
{
    class EC_tb_Khachhang
    {
        private string makhach;
        private string tenkhach;
        private string diachi;
        private string dienthoai;

        public string MAKHACH
        {
            get
            {
                return makhach;
            }
            set
            {
                makhach = value;
                if (makhach == "")
                {
                    throw new Exception("Mã khách hàng không được để trống");
                }
            }
        }
        public string TENKHACH
        {
            get
            {
                return tenkhach;
            }
            set
            {
                tenkhach = value;
            }
        }
        public string DIACHI
        {
            get
            {
                return diachi;
            }
            set
            {
                diachi = value;
            }
        }
        public string DIENTHOAI
        {
            get
            {
                return dienthoai;
            }
            set
            {
                dienthoai = value;
            }
        }
    }
}
