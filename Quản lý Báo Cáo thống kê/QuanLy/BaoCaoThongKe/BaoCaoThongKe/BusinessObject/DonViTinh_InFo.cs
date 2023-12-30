using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace BaoCaoThongKe.BusinessObject
{
    public class DonViTinh_InFo
    {
        public DonViTinh_InFo() { }

        public DonViTinh_InFo(string MaDonViTinh,string TenDonViTinh)
        {
            MaDonViTinh = M_MaDonViTinh;
            TenDonViTinh = M_TenDonViTinh;
        }
        private string M_MaDonViTinh;

        public string MaDonViTinh
        {
            get { return M_MaDonViTinh; }
            set { M_MaDonViTinh = value; }
        }

        private string M_TenDonViTinh;

        public string TenDonViTinh
        {
            get { return M_TenDonViTinh; }
            set { M_TenDonViTinh = value; }
        }

	
    }
}
