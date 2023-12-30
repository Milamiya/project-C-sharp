using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class DotDaoTaoData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachDOTDAOTAO()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM DOTDAOTAO ");
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

        public DataTable ThemDOTDAOTAO(string txtTenddt,string txtNoidt,string txtNganhdt,string txtChuyennganh,string txtHinhthucdt,string dtiNgaybatdau,string dtiNgayketthuc)
        {
            long ma = ThamSo.TaoMaDOTDAOTAO;
            ThamSo.TaoMaDOTDAOTAO = ma + 1;
            String ngayBD = dtiNgaybatdau.Substring(0, 10);
            String ngayKT = dtiNgayketthuc.Substring(0, 10);
            OleDbCommand cmd = new OleDbCommand("INSERT INTO DOTDAOTAO(MADDT,TENDDT,NOIDT,NGANHDT,CHUYENNGANH,NGAYBATDAU,NGAYKETTHUC,HINHTHUCDAOTAO) values(N'" + ma + "',N'" + txtTenddt + "',N'" + txtNoidt + "',N'" + txtNganhdt + "',N'" + txtChuyennganh + "',N'" + ngayBD + "',N'" + ngayKT + "',N'" + txtHinhthucdt + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable UpdateDOTDAOTAO(string txtTenddt, string txtNoidt, string txtNganhdt, string txtChuyennganh, string txtHinhthucdt, string dtiNgaybatdau, string dtiNgayketthuc,string MADTT)
        {
            String ngayBD = dtiNgaybatdau.Substring(0, 10);
            String ngayKT = dtiNgayketthuc.Substring(0, 10);
            OleDbCommand cmd = new OleDbCommand("UPDATE DOTDAOTAO SET TENDDT=N'" + txtTenddt + "',NOIDT=N'" + txtNoidt + "',NGANHDT=N'" + txtNganhdt + "',CHUYENNGANH=N'" + txtChuyennganh + "',NGAYBATDAU=N'" + ngayBD + "',NGAYKETTHUC=N'" + ngayKT + "',HINHTHUCDAOTAO=N'" + txtHinhthucdt + "' WHERe MADDT = '" + MADTT + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteDOTDAOTAO(string maDDT)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM DOTDAOTAO WHERE MADDT ='" + maDDT + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
