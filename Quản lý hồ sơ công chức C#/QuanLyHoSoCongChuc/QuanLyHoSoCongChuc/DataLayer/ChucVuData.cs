using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace QuanLyHoSoCongChuc.DataLayer
{
    public class ChucVuData
    {
        DataService m_ChucVuData = new DataService();
        // DataService ds = new DataService();
        public DataTable LayDsChucVu()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ChucVu");
            m_ChucVuData.Load(cmd);
            return m_ChucVuData;
        }

        public DataRow ThemDongMoi()
        {
            return m_ChucVuData.NewRow();
        }

        public void ThemChucVu(DataRow m_Row)
        {
            m_ChucVuData.Rows.Add(m_Row);
        }

        public bool LuuChucVu()
        {
            return m_ChucVuData.ExecuteNoneQuery() > 0;
        }

    }
}
