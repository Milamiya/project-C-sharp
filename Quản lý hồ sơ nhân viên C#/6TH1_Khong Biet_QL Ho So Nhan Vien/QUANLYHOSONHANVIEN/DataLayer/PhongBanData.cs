using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class PhongBanData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachPhongBan(String str)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM PHONGBAN WHERE MAPB='" + str+  "'");
            m_Ds.Load(cmd);

            return m_Ds;
        }
        public DataTable DanhsachPhongBan()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM PHONGBAN");
            m_Ds.Load(cmd);

            return m_Ds;
        }
        public DataTable Danhsach()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM a");
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
        public DataTable ThemPhongBan(string txtTenphong, string txtMota)
        {
            long ma = ThamSo.TaoMaPhongBan;
            ThamSo.TaoMaPhongBan = ma + 1;
            string maso = "PHONG" + ma.ToString();

            OleDbCommand cmd = new OleDbCommand("INSERT INTO PHONGBAN(MAPB,TENPB,MOTA) values(N'" + maso + "',N'" + txtTenphong + "',N'" + txtMota + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable CapNhatPhongBan(string txtTenphong,string txtMota,string  mapb)
        {           
            OleDbCommand cmd = new OleDbCommand("UPDATE PHONGBAN SET TENPB=N'" + txtTenphong + "',MOTA=N'" + txtMota + "' WHERe MAPB = '" + mapb + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeletePhongBan(string mapb)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM PHONGBAN WHERE MAQTKT ='" + mapb + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        
    }
}
