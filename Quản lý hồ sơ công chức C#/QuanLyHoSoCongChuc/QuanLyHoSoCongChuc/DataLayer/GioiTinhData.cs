using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace QuanLyHoSoCongChuc.DataLayer
{
    public class GioiTinhData
    {
        DataService m_GioiTinhData = new DataService();
        public DataTable LayDsGioiTinh()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GioiTinh");
            m_GioiTinhData.Load(cmd);
            return m_GioiTinhData;
        }

    }
}
