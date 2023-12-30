using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
    public class HoSoKheUocLayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachHoSoKheUoc()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoSoKheUoc");
            m_Ds.Load(cmd);
            return this.m_Ds;
        }

        public DataTable LayHoSoKheUocTheoMa(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoSoKheUoc WHERE MaSoKU=@ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;
            m_Ds.Load(cmd);
            return this.m_Ds;
        }

        public DataTable LayLaiSuatTheoMa(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoSoKheUoc WHERE MaSoKU=@ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;
            m_Ds.Load(cmd);
            return this.m_Ds;
        }

        public DataTable LayHoSoKheUoc(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoSoKheUoc WHERE MaSoKU='%" + ma + "%'");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;
            m_Ds.Load(cmd);
            return this.m_Ds;
        }

        public DataTable TimHoSoKheUocTheoMa(String maku)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoSoKheUoc WHERE MaSoKU LIKE '%" + maku + "%'");
            cmd.Parameters.Add("maku", SqlDbType.Char, 10).Value = maku;
            this.m_Ds.Load(cmd);
            return m_Ds;
        }

        public DataTable TimHoSoKheUocTheoMaDoiTac(String madoitac)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoSoKheUoc WHERE MaDoiTac LIKE '%" + madoitac + "%'");
            cmd.Parameters.Add("madoitac", SqlDbType.Char, 10).Value = madoitac;
            m_Ds.Load(cmd);
            return m_Ds;
        }

        public DataTable TimHoSoKheUocTheoNgayDuyet(DateTime ngayduyet)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoSoKheUoc WHERE NgayDuyet LIKE '%" + ngayduyet + "%'");
            cmd.Parameters.Add("ngayduyet", SqlDbType.Char, 10).Value = ngayduyet;
            this.m_Ds.Load(cmd);
            return m_Ds;
        }

        public DataTable TimHoSoKheUocTheoMaNV(String manv)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HoSoKheUoc WHERE MaNV LIKE '%" + manv + "%'");
            cmd.Parameters.Add("manv", SqlDbType.Char, 10).Value = manv;
            m_Ds.Load(cmd);
            return m_Ds;
        }

        public DataRow NewRow()
        {
            return m_Ds.NewRow();
        }

        public void Add(DataRow row)
        {
            this.m_Ds.Rows.Add(row);
        }

        public bool Save()
        {
            return (m_Ds.ExecuteNoneQuery() > 0);
        }

        public void UPDATE(String maku, long sotien_ht)
        {
            SqlCommand cmd = new SqlCommand("UPDATE HoSoKheUoc SET SoTienHienTai='" + sotien_ht + "' WHERE MaSoKU = '" + maku + "'");
            m_Ds.Load(cmd);
            //return (m_Ds.ExecuteNoneQuery() > 0);
        }

        public void UPDATENGAY(String maku, DateTime ngaytinhlai)
        {
            SqlCommand cmd = new SqlCommand("UPDATE HoSoKheUoc SET NgayTinhLai='" + ngaytinhlai + "' WHERE MaSoKU = '" + maku + "'");
            m_Ds.Load(cmd);
            //return (m_Ds.ExecuteNoneQuery() > 0);
        }


//        public DataTable TinhLai(String ma)
//        {
//            SqlCommand cmd = new SqlCommand("SELECT HoSoKheUoc.SoTienHienTai, LaiSuat.LaiSuat, HoSoKheUoc.MaSoKU
//FROM  HoSoKheUoc,LaiSuat WHERE MaLaiSuat LIKE '%" + ma + "%'" );
//            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;
//            m_Ds.Load(cmd);
//            return this.m_Ds;
       // }

        




    }
}
