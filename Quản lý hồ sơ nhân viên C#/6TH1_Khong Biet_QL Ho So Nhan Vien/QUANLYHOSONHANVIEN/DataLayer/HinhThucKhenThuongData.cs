using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class HinhThucKhenThuongData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachHINHTHUCKHETHUONG()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM HINHTHUCKHEnTHUONG ");
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

        public DataTable ThemHINHTHUCKHETHUONG(string ma, string ten)
        {
            OleDbCommand cmd = new OleDbCommand("INSERT INTO HINHTHUCKHEnTHUONG(mahtkt,TENHTKT) values(N'" + ma + "',N'" + ten + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable UpdateHINHTHUCKHETHUONG(string ten, string ma)
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE HINHTHUCKHEnTHUONG SET TENHTKT=N'" + ten + "' WHERe MAHTKT = '" + ma + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteHINHTHUCKHETHUONG(string mahoc)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM HINHTHUCKHEnTHUONG WHERE MAHTKT ='" + mahoc + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
