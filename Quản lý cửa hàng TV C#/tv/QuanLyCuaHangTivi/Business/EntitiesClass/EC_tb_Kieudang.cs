using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCuaHangTivi.Business.EntitiesClass
{
    class EC_tb_Kieudang
    {
        private string makieu;
        private string tenkieu;

        public string MAKIEU
        {
            get
            {
                return makieu;
            }
            set
            {
                makieu = value;
                if (makieu == "")
                {
                    throw new Exception("Mã làm không được để trống. Xin nhập đầy đủ");
                }
            }
        }
        public string TENKIEU
        {
            get
            {
                return tenkieu;
            }
            set
            {
                tenkieu = value;
            }
        }
    }
}
