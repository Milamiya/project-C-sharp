using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BaoCaoThongKe.BusinessObject
{
    public class LoaiCongTrinh_InFo
    {
        //public LoaiCongTrinh_InFo() { }
        //public LoaiCongTrinh_InFo(int MaLoaiCongTrinh,string TenLoaiCongTrinh)
        //{
        //    MaLoaiCongTrinh = M_MaLoaiCongTrinh;
        //    TenLoaiCongTrinh = M_TenLoaiCongTrinh;

        //}

        private int M_MaLoaiCongTrinh;

        public int MaLoaiCongTrinh
        {
            get { return M_MaLoaiCongTrinh; }
            set { M_MaLoaiCongTrinh = value; }
        }

        private string M_TenLoaiCongTrinh;

        public string TenLoaiCongTrinh
        {
            get { return M_TenLoaiCongTrinh; }
            set { M_TenLoaiCongTrinh = value; }
        }
	
	
    }
}
