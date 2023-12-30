using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHangDienTu.Business.EntitiesClass
{
    class EC_tb_Donvitinh
    {
        private string madonvi;
        private string tendonvi;

        public string MADONVI
        {
            get
            {
                return madonvi;
            }
            set
            {
                madonvi = value;
                if (madonvi == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string TENDONVI
        {
            get
            {
                return tendonvi;
            }
            set
            {
                tendonvi = value;
            }
        }
    }
}
