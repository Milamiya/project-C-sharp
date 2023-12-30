using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace BaoCaoThongKe.BusinessObject
{
    public class QL_DuAn_InFo
    {
        public QL_DuAn_InFo(int MaDuAn,string TenDuAn)
        {
            MaDuAn = M_MaDuAn;
            TenDuAn = M_TenDuAn;
        }
        private int M_MaDuAn;

        public int MaDuAn
        {
            get { return M_MaDuAn; }
            set { M_MaDuAn = value; }
        }

        private string M_TenDuAn;

        public string TenDuAn
        {
            get { return M_TenDuAn; }
            set { M_TenDuAn = value; }
        }
        //3
        private LoaiDuAn_InFo M_Loaiduan;

        public LoaiDuAn_InFo Loaiduan
        {
            get { return M_Loaiduan; }
            set { M_Loaiduan = value; }
        }
        //4
        private QL_DoanhNghiep_InFo M_Doanhnghiep;
        public QL_DoanhNghiep_InFo Doanhnghiep
        {
            get { return M_Doanhnghiep; }
            set { M_Doanhnghiep = value; }
        }

        public QL_DuAn_InFo()
        {
            M_Loaiduan = new LoaiDuAn_InFo();
            M_Doanhnghiep = new QL_DoanhNghiep_InFo();
        }
        //5
        private string M_DiaDiemXayDung;

        public string DiaDiemXayDung
        {
            get { return M_DiaDiemXayDung; }
            set { M_DiaDiemXayDung = value; }
        }
        //6
        private string M_ThoiGian;

        public string ThoiGian
        {
            get { return M_ThoiGian; }
            set { M_ThoiGian = value; }
        }
        //7
        private string M_NangLucThietKe;

        public string NangLucThietKe
        {
            get { return M_NangLucThietKe; }
            set { M_NangLucThietKe = value; }
        }
        //8
        private int M_TongVon;

        public int TongVon
        {
            get { return M_TongVon; }
            set { M_TongVon = value; }
        }	

    }
}