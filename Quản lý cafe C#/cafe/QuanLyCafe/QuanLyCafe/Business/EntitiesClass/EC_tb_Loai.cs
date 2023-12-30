using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCafe.Business.EntitiesClass
{
    class EC_tb_Loai
    {
        private string maloai;
        private string tenloai;

        public string MALOAI
        {
            get
            {
                return maloai;
            }
            set
            {
                maloai = value;
                if (maloai == "")
                {
                    throw new Exception("Mã không để trống");
                }
            }
        }
        public string TENLOAI
        {
            get
            {
                return tenloai;
            }
            set
            {
                tenloai = value;
            }
        }
    }
}
