using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class VanBangData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachVANBANG()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM VANBANG ");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataRow NewRow()
        {
            return m_Ds.NewRow();
        }
        public void Add(DataRow row)
        {
            m_Ds.Rows.Add(row);
        }
        public bool Save()
        {
            return m_Ds.ExecuteNoneQuery() > 0;
        }

        public DataTable ThemVANBANG(string ma, string ten)
        {
            OleDbCommand cmd = new OleDbCommand("INSERT INTO VANBANG(mavb,tenvb) values(N'" + ma + "',N'" + ten + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable UpdateVANBANG(string ten, string ma)
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE VANBANG SET tenvb=N'" + ten + "' WHERe mavb = '" + ma + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteVANBANG(string mahoc)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM VANBANG WHERE mavb ='" + mahoc + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
