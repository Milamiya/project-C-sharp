using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class DanhSachNgheNghiepData
    {
        DataService m_Ds = new DataService();

        public DataTable DANHSACHNGHENGHIEP(string str)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM DANHSACHNGHENGHIEP where manv='" + str + "'");
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

        public DataTable ThemDANHSACHNGHENGHIEP(string manv,string cmbnghenghiep)
        {
            long ma = ThamSo.TaoDanhSachNgheNghiep;
            ThamSo.TaoDanhSachNgheNghiep = ma + 1;
            string maso = "DSNN" + ma.ToString();


            OleDbCommand cmd = new OleDbCommand("INSERT INTO danhsachnghenghiep(madsnn,tennghenghiep,manv) values(N'" + maso + "',N'" + cmbnghenghiep + "',N'" + manv + "')");
            //OleDbCommand cmd = new OleDbCommand("INSERT INTO QUATRINHCONGTACNUOCNGOAI(MAQTCTNN,MANV,MASOQD,NUOCCONGTAC,TENCOQUAN,MUCDICH) values(N'" + maso + "',N'" + manv + "',N'" + soquyetdinh + "',N'" + nuoccongtac + "',N'" + tencoquan + "',N'" + mucdich + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable CapNhatDANHSACHNGHENGHIEP(string cmbnghenghiep, string ma)
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE DANHSACHNGHENGHIEP SET TENNGHENGHIEP=N'" + cmbnghenghiep + "' WHERe madsnn = '" + ma + "'");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteDANHSACHNGHENGHIEP(string maQHGD)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM danhsachnghenghiep WHERE madsnn ='" + maQHGD + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
