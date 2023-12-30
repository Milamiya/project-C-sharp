using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    class ThongTinCongTyData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachTHONGTINCONGTY()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM THONGTINCONGTY ");
            m_Ds.Load(cmd);

            return m_Ds;
        }
    }
}
