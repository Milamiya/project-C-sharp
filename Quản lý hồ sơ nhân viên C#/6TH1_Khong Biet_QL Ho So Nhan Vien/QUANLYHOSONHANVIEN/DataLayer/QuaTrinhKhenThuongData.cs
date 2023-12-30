using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class QuaTrinhKhenThuongData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachQuaTrinhKT(string manv)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM QUATRINHKHENTHUONG where manv='" + manv + "'");
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
        public DataTable ThemKHENTHUONG(string txtSoquyetdinhQTKT,string dtiNgayquyetdinhQTKT,string txtHinhthucQTKT,string txtLydoQTKT,string txtGhichuQTKT,string txtCoquankhenthuongQTKT,string cmbNguoikyQTKT,string txtManv)
        {
            long ma = ThamSo.TaoMaKhenThuong;
            ThamSo.TaoMaKhenThuong = ma + 1;
            string maso = ma.ToString();

            string ngayQD = dtiNgayquyetdinhQTKT.Substring(0, 10);

            OleDbCommand cmd = new OleDbCommand("INSERT INTO QUATRINHKHENTHUONG(MAQTKT,MANV,SOQD,NGAYQD,HINHTHUC,LYDO,GHICHU,COQUANKHENTHUONG,NGUOIKY) values(N'" + ma + "',N'" + txtManv + "',N'" + txtSoquyetdinhQTKT + "',N'" + ngayQD + "',N'" + txtHinhthucQTKT + "',N'" + txtLydoQTKT + "',N'" + txtGhichuQTKT + "',N'" + txtCoquankhenthuongQTKT + "',N'" + cmbNguoikyQTKT + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable UpdateKHENTHUONG(string txtSoquyetdinhQTKT, string dtiNgayquyetdinhQTKT, string txtHinhthucQTKT, string txtLydoQTKT, string txtGhichuQTKT, string txtCoquankhenthuongQTKT, string cmbNguoikyQTKT, string maqtkt)
        {
            string ngayQD = dtiNgayquyetdinhQTKT.Substring(0, 10);
            OleDbCommand cmd = new OleDbCommand("UPDATE QUATRINHKHENTHUONG SET SOQD=N'" + txtSoquyetdinhQTKT + "',NGAYQD=N'" + ngayQD + "',HINHTHUC=N'" + txtHinhthucQTKT + "',LYDO=N'" + txtLydoQTKT + "',GHICHU=N'" + txtGhichuQTKT + "',COQUANKHENTHUONG=N'" + txtCoquankhenthuongQTKT + "',NGUOIKY=N'" + cmbNguoikyQTKT + "' WHERe MAQTKT = '" + maqtkt + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteKHENTHUONG(string makt)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM QUATRINHKHENTHUONG WHERE MAQTKT ='" + makt + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
