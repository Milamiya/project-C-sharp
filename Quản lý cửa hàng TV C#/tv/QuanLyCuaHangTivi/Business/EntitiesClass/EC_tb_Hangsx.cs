using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCuaHangTivi.Business.EntitiesClass
{
    class EC_tb_Hangsx
    {
        private string mahang;
        private string tenhang;

        public string MAHANG
        {
            get
            {
                return mahang;
            }
            set
            {
                mahang = value;
                if (mahang == "")
                {
                    throw new Exception("Mã  không được để trống. Xin nhập đầy đủ");
                }
            }
        }
        public string TENHANG
        {
            get
            {
                return tenhang;
            }
            set
            {
                tenhang = value;
            }
        }
    }
}
