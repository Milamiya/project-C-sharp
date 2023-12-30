using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class ChucVuData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachChucVu()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM CHUCVU");
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
        public DataTable ThemChucvu(string ma, string tennghe, string phucap)
        {
            OleDbCommand cmd = new OleDbCommand("INSERT INTO CHUCVU(macv,tencv,phucap) values(N'" + ma + "',N'" + tennghe + "',N'" + phucap + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable UpdateChucvu(string tennghe, string phucap, string ma)
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE CHUCVU SET TENCV=N'" + tennghe + "',PHUCAP=N'" + phucap + "' WHERe macv = '" + ma + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteChucvu(string maNN)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM CHUCVU WHERE MACV ='" + maNN + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
