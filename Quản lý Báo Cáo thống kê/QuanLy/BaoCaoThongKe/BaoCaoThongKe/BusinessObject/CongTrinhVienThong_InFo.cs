using System;
using System.Collections.Generic;
using System.Text;

namespace BaoCaoThongKe.BusinessObject
{
    public class CongTrinhVienThong_InFo
    {
        public CongTrinhVienThong_InFo() 
        {
            M_MaLoaiCongTrinh = new LoaiCongTrinh_InFo();
            M_MaDoanhNghiep = new QL_DoanhNghiep_InFo();
        }
        private int M_MaCongTrinh;

        public int MaCongTrinh
        {
            get { return M_MaCongTrinh; }
            set { M_MaCongTrinh = value; }
        }

        private string M_TenCongTrinh;

        public string TenCongTrinh
        {
            get { return M_TenCongTrinh; }
            set { M_TenCongTrinh = value; }
        }

        private LoaiCongTrinh_InFo M_MaLoaiCongTrinh;

        public LoaiCongTrinh_InFo MaLoaiCongTrinh
        {
            get { return M_MaLoaiCongTrinh; }
            set { M_MaLoaiCongTrinh = value; }
        }
        
        private QL_DoanhNghiep_InFo M_MaDoanhNghiep;

        public QL_DoanhNghiep_InFo MaDoanhNghiep
        {
            get { return M_MaDoanhNghiep; }
            set { M_MaDoanhNghiep = value; }
        }
        
	
	
	
    }
}
