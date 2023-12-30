using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class ThanNhanNuocNgoaiData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachTHANNHANNUOCNGOAI(string str)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM THANNHANNUOCNGOAI WHERE MANV like '" + str + "'");
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

        public DataTable ThemTHANNHANNUOCNGOAI(string txtHotenTNNN,string dtiNgaysinhTNNN,string txtQuanheTNNN,string txtNamdinhcuTNNN,string txtNuocdinhcuTNNN,string cmbQuoctichTNNN, string MANV)
        {
            long ma = ThamSo.TaoMaTHANNHANNUOCNGOAI;
            ThamSo.TaoMaTHANNHANNUOCNGOAI = ma + 1;
            string maso = ma.ToString();
            String ngaySinh = dtiNgaysinhTNNN.Substring(0, 10);

            //MessageBox.Show("INSERT INTO THANNHANNUOCNGOAI(MATNNN,HOTEN,NGAYSINH,QUANHE,NAMDINHCU,NUOCDINHCU,QUOCTICH,MANV) values(N'" + maso + "',N'" + txtHotenTNNN + "',N'" + ngaySinh + "',N'" + txtQuanheTNNN + "',N'" + txtNamdinhcuTNNN + "',N'" + txtNuocdinhcuTNNN + "',N'" + cmbQuoctichTNNN + "',N'" + MANV + "')");

            OleDbCommand cmd = new OleDbCommand("INSERT INTO THANNHANNUOCNGOAI(MATNNN,HOTEN,NGAYSINH,QUANHE,NAMDINHCU,NUOCDINHCU,QUOCTICH,MANV) values(N'" + maso + "',N'" + txtHotenTNNN + "',N'" + ngaySinh + "',N'" + txtQuanheTNNN + "',N'" + txtNamdinhcuTNNN + "',N'" + txtNuocdinhcuTNNN + "',N'" + cmbQuoctichTNNN + "',N'" + MANV + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable UpdateTHANNHANNUOCNGOAI(string txtHotenTNNN, string dtiNgaysinhTNNN, string txtQuanheTNNN, string txtNamdinhcuTNNN, string txtNuocdinhcuTNNN, string cmbQuoctichTNNN, string matnnn)
        {
            String ngaySinh = dtiNgaysinhTNNN.Substring(0, 10);
            OleDbCommand cmd = new OleDbCommand("UPDATE THANNHANNUOCNGOAI SET HOTEN=N'" + txtHotenTNNN + "',NGAYSINH=N'" + ngaySinh + "',QUANHE=N'" + txtQuanheTNNN + "',NAMDINHCU=N'" + txtNamdinhcuTNNN + "',NUOCDINHCU=N'" + txtNuocdinhcuTNNN + "',QUOCTICH=N'" + cmbQuoctichTNNN + "' WHERE MATnnn ='" + matnnn + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteTHANNHANNUOCNGOAI(string maTNNN)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM THANNHANNUOCNGOAI WHERE MATNNN ='" + maTNNN + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
