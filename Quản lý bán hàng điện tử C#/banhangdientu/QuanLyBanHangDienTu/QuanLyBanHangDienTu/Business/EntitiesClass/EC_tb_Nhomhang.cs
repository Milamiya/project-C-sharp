using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHangDienTu.Business.EntitiesClass
{
    class EC_tb_Nhomhang
    {
        private string manhom;
        private string tennhom;
        private string congcu;

        public string MANHOM
        {
            get
            {
                return manhom;
            }
            set
            {
                manhom = value;
                if (manhom == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string TENNHOM
        {
            get
            {
                return tennhom;
            }
            set
            {
                tennhom = value;
            }
        }
        public string CONGCU
        {
            get
            {
                return congcu;
            }
            set
            {
                congcu = value;
            }
        }
    }
}
