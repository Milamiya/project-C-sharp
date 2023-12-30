using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace QuanLyHoSoCongChuc.DataLayer
{
    public class DienUuTienGiaDinhData
    {
        DataService m_DienUuTienGiaDinhData = new DataService();
        // DataService ds = new DataService();
        public DataTable LayDsDienUuTienGiaDinh()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DienUuTienGiaDinh");
            m_DienUuTienGiaDinhData.Load(cmd);
            return m_DienUuTienGiaDinhData;
        }

        public DataRow ThemDongMoi()
        {
            return m_DienUuTienGiaDinhData.NewRow();
        }

        public void ThemDienUuTienGiaDinh(DataRow m_Row)
        {
            m_DienUuTienGiaDinhData.Rows.Add(m_Row);
        }

        public bool LuuDienUuTienGiaDinh()
        {
            return m_DienUuTienGiaDinhData.ExecuteNoneQuery() > 0;
        }

    }
}
