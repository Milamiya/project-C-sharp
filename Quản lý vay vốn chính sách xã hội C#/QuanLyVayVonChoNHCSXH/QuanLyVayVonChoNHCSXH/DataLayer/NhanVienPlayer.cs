using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
    public class NhanVienPlayer
    {

        DataService m_Ds= new DataService();

        public DataTable DanhSachNhanVien()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien");
            m_Ds.Load(cmd);
            return this.m_Ds;
        }

        public DataTable LayNhanVien(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE MaNV='%" + ma + "%'");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;
            m_Ds.Load(cmd);
            return this.m_Ds;
        }

        public DataTable TimNhanVienTheoMa(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE MaNV LIKE '%" + ma + "%'");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;
            this.m_Ds.Load(cmd);
            return m_Ds;
        }

        public DataTable TimNhanVienTheoTen(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE HoTenNV LIKE '%' + @ten + '%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;
            m_Ds.Load(cmd);
            return m_Ds;
        }       
        
        public DataTable TimNhanVienTheoMaPB(String mapb)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE MaPhongBan LIKE '%" + mapb + "%'");
            cmd.Parameters.Add("mapb", SqlDbType.Char, 10).Value = mapb;
            this.m_Ds.Load(cmd);
            return m_Ds;
        }

        public DataTable TimNhanVienTheoMaCV(String macv)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE MaChucVu LIKE '%" + macv + "%'");
            cmd.Parameters.Add("macv", SqlDbType.Char, 10).Value = macv;
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




    }
}
