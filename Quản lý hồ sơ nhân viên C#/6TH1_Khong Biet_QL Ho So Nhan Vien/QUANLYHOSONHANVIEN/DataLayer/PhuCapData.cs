using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
   public  class PhuCapData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachPHUCAP()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM PHUCAP ");
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

        public DataTable ThemPHUCAP(string ma, string ten,string heso)
        {
            OleDbCommand cmd = new OleDbCommand("INSERT INTO PHUCAP(MAPC,TENPC,HESO) values(N'" + ma + "',N'" + ten + "',N'" + heso + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable UpdatePHUCAP(string ten, string ma,string heso)
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE PHUCAP SET TENPC=N'" + ten + "',HESO=N'" + heso + "' WHERe MAPC = '" + ma + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeletePHUCAP(string mahoc)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM PHUCAP WHERE MAPC ='" + mahoc + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
