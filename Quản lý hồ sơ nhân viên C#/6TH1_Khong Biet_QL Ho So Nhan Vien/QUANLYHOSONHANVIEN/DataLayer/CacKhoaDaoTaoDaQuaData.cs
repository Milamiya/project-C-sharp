using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class CacKhoaDaoTaoDaQuaData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachCACKHOADAOTAODAQUA(string str)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM CACKHOADAOTAODAQUA where manv='" + str + "'");
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
    }
}
