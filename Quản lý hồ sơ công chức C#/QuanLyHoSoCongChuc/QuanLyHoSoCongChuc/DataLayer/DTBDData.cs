using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace QuanLyHoSoCongChuc.DataLayer
{
    public class DTBDData
    {
        DataService m_DTBDData = new DataService();
        public DataTable LayGiaTriDTBD()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DangHocBoiDuongDaoTao");
            m_DTBDData.Load(cmd);
            return m_DTBDData;
        }
    }
}
