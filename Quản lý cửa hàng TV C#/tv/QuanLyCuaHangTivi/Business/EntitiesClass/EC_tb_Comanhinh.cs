using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCuaHangTivi.Business.EntitiesClass
{
    class EC_tb_Comanhinh
    {
        private string maco;

        public string MACO
        {
            get
            {
                return maco;
            }
            set
            {
                maco = value;
                if (maco == "")
                {
                    throw new Exception("Mã không được để trống. Xin nhập đầy đủ");
                }
            }
        }
    }
}
