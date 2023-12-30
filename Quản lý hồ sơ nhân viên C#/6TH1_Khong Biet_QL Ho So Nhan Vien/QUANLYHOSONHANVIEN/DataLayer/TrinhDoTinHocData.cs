using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class TrinhDoTinHocData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachTRINHDOTINHOC()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM TRINHDOTINHOC");
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
        public DataTable ThemTRINHDOTINHOC(string ma, string tennghe)
        {
            //long ma = ThamSo.TaoMaNgheNghiep;
            //ThamSo.TaoMaNgheNghiep = ma + 1;
            //string maso = "NN" + ma.ToString();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO TRINHDOTINHOC(MATDTH,TENTDTH) values(N'" + ma + "',N'" + tennghe + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable UpdateTRINHDOTINHOC(string tennghe, string mann)
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE TRINHDOTINHOC SET TENTDTH=N'" + tennghe + "' WHERe matdth = '" + mann + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteTRINHDOTINHOC(string maNN)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM TRINHDOTINHOC WHERE MATDTH ='" + maNN + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
