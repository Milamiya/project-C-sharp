using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class DanhGiaData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachDANHGIA(string manv)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM DANHGIA where manv='" + manv + "'");
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
        public DataTable ThemDANHGIA(string cmbDotdanhgiadg,string dtiNgaydanhgiadg,string txtXeploaidg,string txtNhanxetdg, string txtManv)
        {
            long ma = ThamSo.TaoMaDanhSachDanhGia;
            ThamSo.TaoMaDanhSachDanhGia = ma + 1;
            string maso = ma.ToString();
            String ngayDG = dtiNgaydanhgiadg.Substring(0, 10);


            OleDbCommand cmd = new OleDbCommand("INSERT INTO DANHGIA(MADSDG,MANV,DOTDANHGIA,NGAYDANHGIA,XEPLOAI,NHANXET) values(N'" + maso + "',N'" + txtManv + "',N'" + cmbDotdanhgiadg + "',N'" + ngayDG + "',N'" + txtXeploaidg + "',N'" + txtNhanxetdg + "')");            

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable CapNhatDANHGIA(string cmbDotdanhgiadg, string dtiNgaydanhgiadg, string txtXeploaidg, string txtNhanxetdg, string madsdg)
        {
            String ngayDG = dtiNgaydanhgiadg.Substring(0, 10);
            
            OleDbCommand cmd = new OleDbCommand("UPDATE DANHGIA SET DOTDANHGIA=N'" + cmbDotdanhgiadg + "',NGAYDANHGIA=N'" + ngayDG + "',XEPLOAI=N'" + txtXeploaidg + "',NHANXET=N'" + txtNhanxetdg + "' WHERe MADSDG = '" + madsdg + "'");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteDANHGIA(string MADSDG)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM DANHGIA WHERE MADSDG ='" + MADSDG + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
