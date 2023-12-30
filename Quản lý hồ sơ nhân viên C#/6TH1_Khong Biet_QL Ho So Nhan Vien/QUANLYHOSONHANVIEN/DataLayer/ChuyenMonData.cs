using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class ChuyenMonData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachCHUYENMON(string manv)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM CHUYENMON where manv='" + manv + "'");
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
        public DataTable ThemCHUYENMON(string dtiNgaybatdauCM,string  dtiNgayketthucCM,string cmbChuyenmonCM,string txtBangcapCM, string txtManv)
        {
            long ma = ThamSo.TaoMaCHUYENMON;
            ThamSo.TaoMaCHUYENMON = ma + 1;
            string maso = ma.ToString();
            String ngayBD = dtiNgaybatdauCM.Substring(0, 10);
            String ngayKT = dtiNgayketthucCM.Substring(0, 10);


            OleDbCommand cmd = new OleDbCommand("INSERT INTO CHUYENMON(MACm,MANV,NGAYBATDAU,NGAYKETTHUC,CHUYENMON,BANGCAp) values(N'" + maso + "',N'" + txtManv + "',N'" + ngayBD + "',N'" + ngayKT + "',N'" + cmbChuyenmonCM + "',N'" + txtBangcapCM + "')");
            //OleDbCommand cmd = new OleDbCommand("INSERT INTO QUATRINHCONGTACNUOCNGOAI(MAQTCTNN,MANV,MASOQD,NUOCCONGTAC,TENCOQUAN,MUCDICH) values(N'" + maso + "',N'" + manv + "',N'" + soquyetdinh + "',N'" + nuoccongtac + "',N'" + tencoquan + "',N'" + mucdich + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable CapNhatCHUYENMON(string dtiNgaybatdauCM, string dtiNgayketthucCM, string cmbChuyenmonCM, string txtBangcapCM, string maCM)
        {
            String ngayBD = dtiNgaybatdauCM.Substring(0, 10);
            String ngayKT = dtiNgayketthucCM.Substring(0, 10);
            OleDbCommand cmd = new OleDbCommand("UPDATE CHUYENMON SET NGAYBATDAU=N'" + ngayBD + "',NGAYKETTHUC=N'" + ngayKT + "',CHUYENMON=N'" + cmbChuyenmonCM + "',BANGCAP=N'" + txtBangcapCM + "' WHERe MACM = '" + maCM + "'");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteCHUYENMON(string maCM)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM CHUYENMON WHERE MACM ='" + maCM + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
