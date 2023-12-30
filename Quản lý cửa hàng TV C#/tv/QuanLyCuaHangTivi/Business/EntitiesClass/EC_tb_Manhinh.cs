using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCuaHangTivi.Business.EntitiesClass
{
    class EC_tb_Manhinh
    {
        private string mamanhinh;
        private string tenmanhinh;

        public string MAMANHINH
        {
            get
            {
                return mamanhinh;
            }
            set
            {
                mamanhinh = value;
                if (mamanhinh == "")
                {
                    throw new Exception("Mã làm không được để trống. Xin nhập đầy đủ");
                }
            }
        }
        public string TENMANHINH
        {
            get
            {
                return tenmanhinh;
            }
            set
            {
                tenmanhinh = value;
            }
        }
    }
}
