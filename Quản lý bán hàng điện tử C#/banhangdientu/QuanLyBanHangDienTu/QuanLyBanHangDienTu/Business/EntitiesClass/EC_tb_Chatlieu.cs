using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHangDienTu.Business.EntitiesClass
{
    class EC_tb_Chatlieu
    {
        private string machatlieu;
        private string tenchatlieu;

        public string MACHATLIEU
        {
            get
            {
                return machatlieu;
            }
            set
            {
                machatlieu = value;
                if (machatlieu == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string TENCHATLIEU
        {
            get
            {
                return tenchatlieu;
            }
            set
            {
                tenchatlieu = value;
            }
        }
    }
}
