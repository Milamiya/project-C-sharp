using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class DotDanhGiaData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachDOTDANHGIA()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM DOTDANHGIA");
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
        public DataTable ThemDOTDANHGIA(string txtTen,string dtiNgaybatdau,string dtiNgayketthuc,string txtNhanxet)
        {
            long ma = ThamSo.TaoMaDanhSachDanhGia;
            ThamSo.TaoMaDanhSachDanhGia = ma + 1;
            string maso = "DG" + ma.ToString();
            string ngayBT = dtiNgaybatdau.Substring(0, 10);
            string ngayKT = dtiNgayketthuc.Substring(0, 10);
            OleDbCommand cmd = new OleDbCommand("INSERT INTO DOTDANHGIA(MADDG,TENDDG,NGAYBATDAU,NGAYKETTHUC,NHANXET) values(N'" + maso + "',N'" + txtTen + "',N'" + ngayBT + "',N'" + ngayKT + "',N'" + txtNhanxet + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable UpdateDOTDANHGIA(string txtTen, string dtiNgaybatdau, string dtiNgayketthuc, string txtNhanxet, string maddg)
        {
            string ngayBT = dtiNgaybatdau.Substring(0, 10);
            string ngayKT = dtiNgayketthuc.Substring(0, 10);

            OleDbCommand cmd = new OleDbCommand("UPDATE DOTDANHGIA SET TENDDG=N'" + txtTen + "',NGAYBATDAU=N'" + ngayBT + "',NGAYKETTHUC=N'" + ngayKT + "',NHANXET=N'" + txtNhanxet + "' WHERe MADDG = '" + maddg + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteDOTDANHGIA(string MADDG)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM DOTDANHGIA WHERE MADDG ='" + MADDG + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
