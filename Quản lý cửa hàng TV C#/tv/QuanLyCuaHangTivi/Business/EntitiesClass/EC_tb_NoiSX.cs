using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCuaHangTivi.Business.EntitiesClass
{
    class EC_tb_NoiSX
    {
        private string manoisx;
        private string tennoisx;

        public string MANOISX
        {
            get
            {
                return manoisx;
            }
            set
            {
                manoisx = value;
                if (manoisx == "")
                {
                    throw new Exception("Mã nơi sản xuất không được để trống. Xin nhập đầy đủ");
                }
            }
        }
        public string TENNOISX
        {
            get
            {
                return tennoisx;
            }
            set
            {
                tennoisx = value;
            }
        }
    }
}
