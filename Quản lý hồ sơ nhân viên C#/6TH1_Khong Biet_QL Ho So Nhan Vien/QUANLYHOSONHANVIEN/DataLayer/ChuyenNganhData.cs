using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class ChuyenNganhData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachChuyenNganh()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM CHUYENNGANH ");
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

        public DataTable ThemChuyenNganh(string txtNganhdaotao,string txtHedaotao,string txtGhichu)
        {
            long ma = ThamSo.TaoMaChuyenNganh;
            ThamSo.TaoMaChuyenNganh = ma + 1;
            string maso = "CN" + ma.ToString();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO CHUYENNGANH(MACHUYENNGANH,NGANHDAOTAO,HEDAOTAO,GHICHU) values(N'" + maso + "',N'" + txtNganhdaotao + "',N'" + txtHedaotao + "',N'" + txtGhichu + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable UpdateChuyenNganh(string txtNganhdaotao, string txtHedaotao, string txtGhichu, string MACN )
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE CHUYENNGANH SET NGANHDAOTAO=N'" + txtNganhdaotao + "',HEDAOTAO=N'" + txtHedaotao + "',GHICHU=N'" + txtGhichu + "' WHERe MACHUYENNGANH = '" + MACN + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteChuyenNganh(string maCN)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM CHUYENNGANH WHERE MACHUYENNGANH ='" + maCN + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
