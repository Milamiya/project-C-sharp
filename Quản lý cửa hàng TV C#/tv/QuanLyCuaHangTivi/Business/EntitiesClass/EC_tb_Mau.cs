using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCuaHangTivi.Business.EntitiesClass
{
    class EC_tb_Mau
    {
        private string mamau;
        private string tenmau;

        public string MAMAU
        {
            get
            {
                return mamau;
            }
            set
            {
                mamau = value;
                if (mamau == "")
                {
                    throw new Exception("Mã Không được để trống");
                }
            }
        }
        public string TENMAU
        {
            get
            {
                return tenmau;
            }
            set
            {
                tenmau = value;
            }
        }
    }
}
