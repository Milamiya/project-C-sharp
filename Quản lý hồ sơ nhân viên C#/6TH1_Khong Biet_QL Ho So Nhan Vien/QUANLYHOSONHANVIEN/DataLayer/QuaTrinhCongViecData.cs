using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class QuaTrinhCongViecData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachQUATRINHCONGVIEC(string manv)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM QUATRINHCONGVIEC where manv='" + manv + "'");
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
        public DataTable ThemQUATRINHCONGVIEC(string cmbTencongviecQTCV,string txtDonviQTCV,string dtiNgayhieulucQTCV, string txtManv)
        {
            long ma = ThamSo.TaoMaDANHSACHCONGVIEC;
            ThamSo.TaoMaDANHSACHCONGVIEC = ma + 1;
            string maso = ma.ToString();
            String ngayHL = dtiNgayhieulucQTCV.Substring(0, 10);

            OleDbCommand cmd = new OleDbCommand("INSERT INTO QUATRINHCONGVIEC(MAQTCV,MANV,TENCONGVIEC,DONVI,NGAYHIEULUC) values(N'" + maso + "',N'" + txtManv + "',N'" + cmbTencongviecQTCV + "',N'" + txtDonviQTCV + "',N'" + ngayHL + "')");
            //OleDbCommand cmd = new OleDbCommand("INSERT INTO QUATRINHCONGTACNUOCNGOAI(MAQTCTNN,MANV,MASOQD,NUOCCONGTAC,TENCOQUAN,MUCDICH) values(N'" + maso + "',N'" + manv + "',N'" + soquyetdinh + "',N'" + nuoccongtac + "',N'" + tencoquan + "',N'" + mucdich + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable CapNhatQUATRINHCONGVIEC(string cmbTencongviecQTCV, string txtDonviQTCV, string dtiNgayhieulucQTCV, string MAQTCV)
        {
            String ngayHL = dtiNgayhieulucQTCV.Substring(0, 10);

            OleDbCommand cmd = new OleDbCommand("UPDATE QUATRINHCONGVIEC SET TENCONGVIEC=N'" + cmbTencongviecQTCV + "',DONVI=N'" + txtDonviQTCV + "',NGAYHIEULUC=N'" + ngayHL + "' WHERe MAQTCV = '" + MAQTCV + "'");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteQUATRINHCONGVIEC(string maQTBD)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM QUATRINHCONGVIEC WHERE MAQTCV ='" + maQTBD + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
