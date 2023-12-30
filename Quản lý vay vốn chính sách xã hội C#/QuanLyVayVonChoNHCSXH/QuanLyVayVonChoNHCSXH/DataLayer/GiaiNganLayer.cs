using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
    public class GiaiNganLayer
    {

        DataService m_Ds= new DataService();

        public DataTable DanhSachGiaiNgan()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GiaiNgan");
            m_Ds.Load(cmd);
            return this.m_Ds;
        }

        public DataTable LayGiaiNgan(String sbt)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GiaiNgan WHERE SoButToan='%" + sbt + "%'");
            cmd.Parameters.Add("sbt", SqlDbType.Char, 10).Value = sbt;
            m_Ds.Load(cmd);
            return this.m_Ds;
        }

        public DataTable LayGiaiNganTheoKU(String maso)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GiaiNgan WHERE MaSoKU='%" + maso + "%'");
            cmd.Parameters.Add("maso", SqlDbType.Char, 10).Value = maso;
            m_Ds.Load(cmd);
            return this.m_Ds;
        }

        public DataTable TimGiaiNganTheoSBT(String sbt)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GiaiNgan WHERE SoButToan LIKE '%" + sbt + "%'");
            cmd.Parameters.Add("sbt", SqlDbType.Char, 10).Value = sbt;
            this.m_Ds.Load(cmd);
            return m_Ds;
        }

        public DataTable TimGiaiNganTheoNgay(DateTime ngay)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GiaiNgan WHERE NgayGiaiNgan LIKE '%" + ngay + "%'");
            cmd.Parameters.Add("ngay", SqlDbType.Char, 10).Value = ngay;
            m_Ds.Load(cmd);
            return m_Ds;
        }

        public DataTable TimGiaiNganTheoMaKU(String maku)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GiaiNgan WHERE MaSoKU LIKE '%" + maku + "%'");
            cmd.Parameters.Add("maku", SqlDbType.Char, 10).Value = maku;
            this.m_Ds.Load(cmd);
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
