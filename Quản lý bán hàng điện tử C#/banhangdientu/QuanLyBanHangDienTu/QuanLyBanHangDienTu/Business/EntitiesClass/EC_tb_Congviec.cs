using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHangDienTu.Business.EntitiesClass
{
    class EC_tb_Congviec
    {
        private string macv;
        private string tencv;

        public string MACV
        {
            get
            {
                return macv;
            }
            set
            {
                macv = value;
                if (macv == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string TENCV
        {
            get
            {
                return tencv;
            }
            set
            {
                tencv = value;
            }
        }
    }
}
