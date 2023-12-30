using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHangDienTu.Business.EntitiesClass
{
    class EC_tb_Nuocsx
    {
        private string manuoc;
        private string tennuoc;

        public string MANUOC
        {
            get
            {
                return manuoc;
            }
            set
            {
                manuoc = value;
                if (manuoc == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string TENNUOC
        {
            get
            {
                return tennuoc;
            }
            set
            {
                tennuoc = value;
            }
        }
    }
}
