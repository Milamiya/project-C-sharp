using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class GhichuData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachGhiChuTheoMANV(string str)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM GHICHU WHERE MANV like '" + str + "'");
            m_Ds.Load(cmd);

            return m_Ds;
        }
        public DataTable DanhsachGhiChuTheoMAGC(string str)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM GHICHU WHERE MAGC like '" + str + "'");
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

        public DataTable ThemGhiChu(string tennv,string manv,string datetime,string loaighichu,string tieude,string noidung)
        {
            long ma = ThamSo.TaoMaGhichu;
            ThamSo.TaoMaGhichu = ma + 1;
            string maso = ma.ToString();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO GHICHU(MAGC,MALOAIGC,MANV,NGAYTAO,TIEUDE,NOIDUNG,NGUOITAO) values(N'" + ma + "',N'" + loaighichu + "',N'" + manv + "',N'" + datetime + "',N'" + tieude + "',N'" + noidung + "',N'" + tennv + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable UpdateGhichu(string maghichu, string loaighichu, string tieude, string noidung)
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE GHICHU SET MALOAIGC=N'" + loaighichu + "',TIEUDE=N'" + tieude + "',NOIDUNG=N'" + noidung + "' WHERe MAGC = '" + maghichu + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteGhichu(string maghichu)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM GHICHU WHERE MAGC ='" + maghichu + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
