using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class DanhSachNgoaiNguData
    {
        DataService m_Ds = new DataService();

        public DataTable DANHSACHNGOAINGU(string str)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM DANHSACHNGOAINGU where manv='" + str + "'");
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

        public DataTable ThemDANHSACHNGOAINGU(string manv, string cmbngoaingu,string trinhdo)
        {
            long ma = ThamSo.TaoDanhSachNGOAINGU;
            ThamSo.TaoDanhSachNGOAINGU = ma + 1;
            string maso = "DSNN" + ma.ToString();


            OleDbCommand cmd = new OleDbCommand("INSERT INTO DANHSACHNGOAINGU(madsnn,tenngoaingu,manv,trinhdo) values(N'" + maso + "',N'" + cmbngoaingu + "',N'" + manv + "',N'" + trinhdo + "')"); 
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable CapNhatDANHSACHNGOAINGU(string cmbnghenghiep,string trinhdo ,string ma)
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE DANHSACHNGOAINGU SET tenngoaingu=N'" + cmbnghenghiep + "',trinhdo=N'" + trinhdo + "' WHERe madsnn = '" + ma + "'");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteDANHSACHNGOAINGU(string maQHGD)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM DANHSACHNGOAINGU WHERE madsnn ='" + maQHGD + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
