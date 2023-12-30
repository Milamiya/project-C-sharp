using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class HinhThucDaoTaoData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachHINHTHUCDAOTAO()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM HINHTHUCDAOTAO ");
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

        public DataTable ThemHINHTHUCDAOTAO(string ma, string ten)
        {
            OleDbCommand cmd = new OleDbCommand("INSERT INTO HINHTHUCDAOTAO(mahtdt,tenhtdt) values(N'" + ma + "',N'" + ten + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable UpdateHINHTHUCDAOTAO(string ten, string ma)
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE HINHTHUCDAOTAO SET tenhtdt=N'" + ten + "' WHERe mahtdt = '" + ma + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteHINHTHUCDAOTAO(string mahoc)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM HINHTHUCDAOTAO WHERE mahtdt ='" + mahoc + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
