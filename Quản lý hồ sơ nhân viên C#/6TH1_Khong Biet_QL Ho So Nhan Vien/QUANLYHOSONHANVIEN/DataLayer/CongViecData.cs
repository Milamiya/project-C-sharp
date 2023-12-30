using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class CongViecData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachCONGVIEC()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM CONGVIEC");
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
        public DataTable ThemCONGVIEC(string ma, string tennghe)
        {
            //long ma = ThamSo.TaoMaNgheNghiep;
            //ThamSo.TaoMaNgheNghiep = ma + 1;
            //string maso = "NN" + ma.ToString();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO CONGVIEC(MACV,TENCV) values(N'" + ma + "',N'" + tennghe + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable UpdateCONGVIEC(string tennghe,  string mann)
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE CONGVIEC SET TENCV=N'" + tennghe + "' WHERe MACV = '" + mann + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteCONGVIEC(string maNN)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM CONGVIEC WHERE MACV ='" + maNN + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
