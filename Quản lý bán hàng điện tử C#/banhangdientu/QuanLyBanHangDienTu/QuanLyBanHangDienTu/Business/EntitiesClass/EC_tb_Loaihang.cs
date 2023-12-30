using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHangDienTu.Business.EntitiesClass
{
    class EC_tb_Loaihang
    {
        private string maloai;
        private string manhom;
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
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string MANHOM
        {
            get
            {
                return manhom;
            }
            set
            {
                manhom = value;
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
