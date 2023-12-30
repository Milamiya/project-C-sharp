using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class TrinhDoData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachTRINHDO()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM TRINHDO ");
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

        public DataTable ThemTRINHDO(string ma, string ten)
        {
            OleDbCommand cmd = new OleDbCommand("INSERT INTO TRINHDO(matd,tentd) values(N'" + ma + "',N'" + ten + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable UpdateTRINHDO(string ten, string ma)
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE TRINHDO SET tentd=N'" + ten + "' WHERe matd = '" + ma + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteTRINHDO(string mahoc)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM TRINHDO WHERE matd ='" + mahoc + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
