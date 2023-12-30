using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCafe.Business.EntitiesClass
{
    class EC_tb_Khachhang
    {
        private string makh;
        private string tenkh;

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
        public string TENKH
        {
            get
            {
                return tenkh;
            }
            set
            {
                tenkh = value;
            }
        }
    }
}
