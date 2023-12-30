using System;
using System.Collections.Generic;
using System.Text;

namespace BaoCaoThongKe.BusinessObject
{
    public class QL_DoanhNghiep_InFo
    {
        //public QL_DoanhNghiep_InFo() { }
        //public QL_DoanhNghiep_InFo(int MaDoanhNghiep, string TenDoanhNghiep)
        //{
        //    MaDoanhNghiep = M_MaDoanhNghiep;
        //    TenDoanhNghiep = M_TenDoanhNghiep;
        //}

        private int M_MaDoanhNghiep;

        public int MaDoanhNghiep
        {
            get { return M_MaDoanhNghiep; }
            set { M_MaDoanhNghiep = value; }
        }

        private string M_TenDoanhNghiep;

        public string TenDoanhNghiep
        {
            get { return M_TenDoanhNghiep; }
            set { M_TenDoanhNghiep = value; }
        }
	    
        private string M_DiaChi;

        public string DiaChi
        {
            get { return M_DiaChi; }
            set { M_DiaChi = value; }
        }

        private string M_DienThoai;

        public string DienThoai
        {
            get { return M_DienThoai; }
            set { M_DienThoai = value; }
        }

        private string M_Fax;

        public string Fax
        {
            get { return M_Fax; }
            set { M_Fax = value; }
        }

        private string M_Email;

        public string Email
        {
            get { return M_Email; }
            set { M_Email = value; }
        }

        private string M_TrangWeb;

        public string TrangWeb
        {
            get { return M_TrangWeb; }
            set { M_TrangWeb = value; }
        }

        private Huyen_Thi_InFo M_TenHuyen;

        public Huyen_Thi_InFo TenHuyen
        {
            get { return M_TenHuyen; }
            set { M_TenHuyen = value; }
        }

        private Xa_Phuong_InFo M_MaXa;

        public Xa_Phuong_InFo MaXa
        {
            get { return M_MaXa; }
            set { M_MaXa = value; }
        }

        private string M_TenXa;

        public string TenXa
        {
            get { return M_TenXa; }
            set { M_TenXa = value; }
        }
        	
	
    }
}
