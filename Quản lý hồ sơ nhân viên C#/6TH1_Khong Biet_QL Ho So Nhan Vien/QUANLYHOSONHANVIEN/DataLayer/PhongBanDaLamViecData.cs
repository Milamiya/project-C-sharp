using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class PhongBanDaLamViecData
    {
        DataService m_Ds = new DataService();

        public DataTable DANHSACHPHONGBANDALAMVIEC(string str)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM PHONGBANDALAMVIEC where manv='" + str + "'");
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

        public DataTable ThemDANHSACHPHONGBANDALAMVIEC(string txtManv,string cmbPhongbanDalamviec,string cmbChucdanhPBDLV,string dtiTungayPBDLV,string dtiDenngayPBDLV,string txtGhichuPBDLV)
        {
            long ma = ThamSo.TaoDanhSachPHONGBANDALAMVIEC;
            ThamSo.TaoDanhSachPHONGBANDALAMVIEC = ma + 1;
            string maso = "DSPBDLV" + ma.ToString();

            string tungay = dtiTungayPBDLV.Substring(0, 10);
            string denngay = dtiDenngayPBDLV.Substring(0, 10);

            OleDbCommand cmd = new OleDbCommand("INSERT INTO PHONGBANDALAMVIEC(MAPBDLV,MANV,PHONGBAN,CHUCDANH,TUNGAY,DENNGAY,GHICHU) values(N'" + maso + "',N'" + txtManv + "',N'" + cmbPhongbanDalamviec + "',N'" + cmbChucdanhPBDLV + "',N'" + tungay + "',N'" + denngay + "',N'" + txtGhichuPBDLV + "')");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable CapNhatDANHSACHPHONGBANDALAMVIEC(string cmbPhongbanDalamviec,string cmbChucdanhPBDLV,string dtiTungayPBDLV,string dtiDenngayPBDLV,string txtGhichuPBDLV, string ma)
        {
            string tungay = dtiTungayPBDLV.Substring(0, 10);
            string denngay = dtiDenngayPBDLV.Substring(0, 10);
            OleDbCommand cmd = new OleDbCommand("UPDATE PHONGBANDALAMVIEC SET PHONGBAN=N'" + cmbPhongbanDalamviec + "',CHUCDANH=N'" + cmbChucdanhPBDLV + "',TUNGAY=N'" + tungay + "',DENNGAY=N'" + denngay + "',GHICHU=N'" + txtGhichuPBDLV + "' WHERe mapbdlv = '" + ma + "'");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteDANHSACHPHONGBANDALAMVIEC(string MAPBDLV )
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM PHONGBANDALAMVIEC WHERE MAPBDLV ='" + MAPBDLV + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
