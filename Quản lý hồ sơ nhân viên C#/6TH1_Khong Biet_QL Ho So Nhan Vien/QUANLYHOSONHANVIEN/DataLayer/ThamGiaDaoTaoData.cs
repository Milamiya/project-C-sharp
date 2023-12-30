using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class ThamGiaDaoTaoData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachTHAMGIADAOTAO(string str)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM THAMGIADAOTAO WHERE MANV like '" + str + "'");
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

        public DataTable ThemTHAMGIADAOTAO(string cmbdotdaotao,string MANV)
        {
            long ma = ThamSo.TaoMaTHAMGIADAOTAO;
            ThamSo.TaoMaTHAMGIADAOTAO = ma + 1;
            string maso = ma.ToString();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO THAMGIADAOTAO(MATGDT,DOTDAOTAO,MANV) values(N'" + maso + "',N'" + cmbdotdaotao + "',N'" + MANV + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable UpdateTHAMGIADAOTAO(string cmbdotdaotao,string matgdt)
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE THAMGIADAOTAO SET DOTDAOTAO=N'" + cmbdotdaotao + "' WHERE MATGDT ='" + matgdt + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteTHAMGIADAOTAO(string maTGDT)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM THAMGIADAOTAO WHERE MATGDT ='" + maTGDT + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
