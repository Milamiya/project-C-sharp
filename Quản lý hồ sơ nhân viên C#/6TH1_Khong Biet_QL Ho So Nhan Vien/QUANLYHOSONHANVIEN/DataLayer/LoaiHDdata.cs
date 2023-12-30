using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class LoaiHDdata
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachLOAIHD()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM LOAIHOPDONG ");
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

        public DataTable ThemLOAIHD(string ma, string ten)
        {
            OleDbCommand cmd = new OleDbCommand("INSERT INTO LOAIHOPDONG(MALOAIHd,TENLOAIHD) values(N'" + ma + "',N'" + ten + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable UpdateLOAIHD(string ten, string ma)
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE LOAIHOPDONG SET Tenloaihd=N'" + ten + "' WHERe MALOAIHd = '" + ma + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteLOAIHD(string mahoc)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM LOAIHOPDONG WHERE MALOAIHd ='" + mahoc + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
