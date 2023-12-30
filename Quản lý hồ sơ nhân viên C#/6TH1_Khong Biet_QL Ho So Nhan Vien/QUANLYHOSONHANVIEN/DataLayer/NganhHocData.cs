using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class NganhHocData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachNganhHoc()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM NGANHHOC ");
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

        public DataTable ThemNganhHoc(string ma, string ten)
        {
            OleDbCommand cmd = new OleDbCommand("INSERT INTO nganhhoc(MANh,TENNh) values(N'" + ma + "',N'" + ten + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable UpdateNganhNganhHoc(string ten, string ma)
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE nganhhoc SET tennh=N'" + ten + "' WHERe manh = '" + ma + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteNganhNganhHoc(string mahoc)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM NGANHHOC WHERE MAnh ='" + mahoc + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
