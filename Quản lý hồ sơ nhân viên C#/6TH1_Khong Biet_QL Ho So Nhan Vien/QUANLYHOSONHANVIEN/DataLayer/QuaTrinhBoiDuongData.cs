using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class QuaTrinhBoiDuongData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachQuaTrinhBoiDuong(string manv)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM QUATRINHBOIDUONG where manv='" + manv + "'");
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
        public DataTable ThemQUATRINHBOIDUONG(string dtiNgaybatdauNDBD, string dtiNgayketthucNDBD,string txtHinhthucNDBD,string txtNoiboidungNDBD,string txtNoidungNDBD,string txtGhichuNDBD, string txtManv)
        {
            long ma = ThamSo.TaoMaQUATRINHBOIDUONG;
            ThamSo.TaoMaQUATRINHBOIDUONG = ma + 1;
            string maso = ma.ToString();
            String ngayBD = dtiNgaybatdauNDBD.Substring(0, 10);
            String ngayKT = dtiNgayketthucNDBD.Substring(0, 10);
            

            OleDbCommand cmd = new OleDbCommand("INSERT INTO QUATRINHBOIDUONG(MAQTBD,MANV,NGAYBATDAU,NGAYKETTHUC,HINHTHUC,NOIBOIDUONG,NOIDUNGBOIDUONG,GHICHU) values(N'" + maso + "',N'" + txtManv + "',N'" + ngayBD + "',N'" + ngayKT + "',N'" + txtHinhthucNDBD + "',N'" + txtNoiboidungNDBD + "',N'" + txtNoidungNDBD + "',N'" + txtGhichuNDBD + "')");
            //OleDbCommand cmd = new OleDbCommand("INSERT INTO QUATRINHCONGTACNUOCNGOAI(MAQTCTNN,MANV,MASOQD,NUOCCONGTAC,TENCOQUAN,MUCDICH) values(N'" + maso + "',N'" + manv + "',N'" + soquyetdinh + "',N'" + nuoccongtac + "',N'" + tencoquan + "',N'" + mucdich + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable CapNhatQUATRINHBOIDUONG(string dtiNgaybatdauNDBD, string dtiNgayketthucNDBD, string txtHinhthucNDBD, string txtNoiboidungNDBD, string txtNoidungNDBD, string txtGhichuNDBD, string maQTBD)
        {
            String ngayBD = dtiNgaybatdauNDBD.Substring(0, 10);
            String ngayKT = dtiNgayketthucNDBD.Substring(0, 10);
            OleDbCommand cmd = new OleDbCommand("UPDATE QUATRINHBOIDUONG SET NGAYBATDAU=N'" + ngayBD + "',NGAYKETTHUC=N'" + ngayKT + "',HINHTHUC=N'" + txtHinhthucNDBD + "',NOIBOIDUONG=N'" + txtNoiboidungNDBD + "',NOIDUNGBOIDUONG=N'" + txtNoidungNDBD + "',GHICHU=N'" + txtGhichuNDBD + "' WHERe MAQTBD = '" + maQTBD + "'");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteQUATRINHBOIDUONG(string maQTBD)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM QUATRINHBOIDUONG WHERE MAQTBD ='" + maQTBD + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
