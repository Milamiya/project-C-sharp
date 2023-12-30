using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCuaHangTivi.Business.EntitiesClass
{
    class EC_tb_Calam
    {
        private string maca;
        private string tenca;

        public string MACA
        {
            get
            {
                return maca;
            }
            set
            {
                maca = value;
                if (maca == "")
                {
                    throw new Exception("Mã làm không được để trống. Xin nhập đầy đủ");
                }
            }
        }
        public string TENCA
        {
            get
            {
                return tenca;
            }
            set
            {
                tenca = value;
            }
        }
    }
}
