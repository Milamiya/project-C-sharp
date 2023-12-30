using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class HinhThucKyLuatData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachHINHTHUCKYLUAT()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM HINHTHUCKYLUAT");
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

        public DataTable ThemHINHTHUCKYLUAT(string ma, string tennghe)
        {
            //long ma = ThamSo.TaoMaNgheNghiep;
            //ThamSo.TaoMaNgheNghiep = ma + 1;
            //string maso = "NN" + ma.ToString();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO HINHTHUCKYLUAT(MAKL,TENKL) values(N'" + ma + "',N'" + tennghe + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable UpdateHINHTHUCKYLUAT(string tennghe, string mann)
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE HINHTHUCKYLUAT SET TENKL=N'" + tennghe + "' WHERe MAKL = '" + mann + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteHINHTHUCKYLUAT(string maNN)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM HINHTHUCKYLUAT WHERE makl ='" + maNN + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
