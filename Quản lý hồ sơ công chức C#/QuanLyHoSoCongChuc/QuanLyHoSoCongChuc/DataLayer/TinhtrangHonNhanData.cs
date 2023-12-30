using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace QuanLyHoSoCongChuc.DataLayer
{
    public class TinhTrangHonNhanData
    {
        DataService m_TinhTrangHonNhanData = new DataService();
        // DataService ds = new DataService();
        public DataTable LayDanhSachTinhTrangHonNhan()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TinhTrangHonNhan");
            m_TinhTrangHonNhanData.Load(cmd);
            return m_TinhTrangHonNhanData;
        }

        public DataRow ThemDongMoi()
        {
            return m_TinhTrangHonNhanData.NewRow();
        }

        public void ThemTinhTrangHonNhan(DataRow m_Row)
        {
            m_TinhTrangHonNhanData.Rows.Add(m_Row);
        }

        public bool LuuTinhTrangHonNhan()
        {
            return m_TinhTrangHonNhanData.ExecuteNoneQuery() > 0;
        }

    }
}
