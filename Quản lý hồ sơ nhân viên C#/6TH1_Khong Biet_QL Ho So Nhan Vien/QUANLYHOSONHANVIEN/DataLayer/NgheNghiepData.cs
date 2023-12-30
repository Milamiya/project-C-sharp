using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class NgheNghiepData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachNGHENGHIEP()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM NGHENGHIEP");
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
        public DataTable ThemNGHENGHIEP( string ma,string tennghe, string ghichu)
        {
            //long ma = ThamSo.TaoMaNgheNghiep;
            //ThamSo.TaoMaNgheNghiep = ma + 1;
            //string maso = "NN" + ma.ToString();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO NGHENGHIEP(MANN,TENNN,GHICHU) values(N'" + ma + "',N'" + tennghe + "',N'" + ghichu + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable UpdateNGHENGHIEP(string tennghe, string ghichu, string mann)
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE NGHENGHIEP SET tennn=N'" + tennghe + "',ghichu=N'" + ghichu + "' WHERe mann = '" + mann + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteNGHENGHIEP(string maNN)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM NGHENGHIEP WHERE MANN ='" + maNN + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
