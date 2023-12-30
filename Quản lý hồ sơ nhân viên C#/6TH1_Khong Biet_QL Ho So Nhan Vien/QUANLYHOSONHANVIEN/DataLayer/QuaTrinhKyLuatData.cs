using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class QuaTrinhKyLuatData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachQuaTrinhKYLUAT(string manv)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM QUATRINHKYLUAT where manv='" + manv + "'");
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
        public DataTable ThemKYLUAT(string txtSoquyetdinhQTKl, string dtiNgayquyetdinhQTKl, string txtHinhthucQTKl, string txtLydoQTKl, string txtGhichuQTKl, string txtCoquankyluatQTKl,string cmbHinhthuckyluatQTKL, string cmbNguoikyQTKl, string txtManv)
        {
            long ma = ThamSo.TaoMaKyLuat;
            ThamSo.TaoMaKyLuat = ma + 1;
            string maso = ma.ToString();

            string ngayQD = dtiNgayquyetdinhQTKl.Substring(0, 10);

            OleDbCommand cmd = new OleDbCommand("INSERT INTO QUATRINHKYLUAT(MAQTKL,MANV,SOQD,NGAYQD,HINHTHUC,LYDO,GHICHU,COQUANKYLUAT,HINHTHUCKYLUAT,NGUOIKY) values(N'" + ma + "',N'" + txtManv + "',N'" + txtSoquyetdinhQTKl + "',N'" + ngayQD + "',N'" + txtHinhthucQTKl + "',N'" + txtLydoQTKl + "',N'" + txtGhichuQTKl + "',N'" + txtCoquankyluatQTKl + "',N'" + cmbHinhthuckyluatQTKL + "',N'" + cmbNguoikyQTKl + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable UpdateKYLUAT(string txtSoquyetdinhQTKl, string dtiNgayquyetdinhQTKl, string txtHinhthucQTKl, string txtLydoQTKl, string txtGhichuQTKl, string txtCoquankyluatQTKl, string cmbHinhthuckyluatQTKL, string cmbNguoikyQTKl, string maqtkl)
        {
            string ngayQD = dtiNgayquyetdinhQTKl.Substring(0, 10);
            OleDbCommand cmd = new OleDbCommand("UPDATE QUATRINHKYLUAT SET SOQD=N'" + txtSoquyetdinhQTKl + "',NGAYQD=N'" + ngayQD + "',HINHTHUC=N'" + txtHinhthucQTKl + "',LYDO=N'" + txtLydoQTKl + "',GHICHU=N'" + txtGhichuQTKl + "',COQUANKYLUAT=N'" + txtCoquankyluatQTKl + "',HINHTHUCKYLUAT=N'" + cmbHinhthuckyluatQTKL + "',NGUOIKY=N'" + cmbNguoikyQTKl + "' WHERe MAQTKL = '" + maqtkl + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteKYLUAT(string makL)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM QUATRINHKYLUAT WHERE MAQTKL ='" + makL + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
