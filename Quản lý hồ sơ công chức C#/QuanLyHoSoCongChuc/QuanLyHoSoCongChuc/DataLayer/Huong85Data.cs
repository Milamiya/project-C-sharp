using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace QuanLyHoSoCongChuc.DataLayer
{
    public class Huong85Data
    {
        DataService m_Huong85Data = new DataService();
        public DataTable LayGiaTri()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Huong85");
            m_Huong85Data.Load(cmd);
            return m_Huong85Data;
        }
    }
}
