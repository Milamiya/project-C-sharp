using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class QuanHeGiaDinhData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachQUANHEGIADINH(string manv)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM QUANHEGIADINH where manv='" + manv + "'");
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
        public DataTable ThemQUANHEGIADINH(string dtiNgaysinhQHGD,string txtQuanheQHGD,string txtHotenQHGD,string txtGhichuQHGD,string txtNghenghiepQHGD,string txtDiachiQHGD, string txtManv)
        {
            long ma = ThamSo.TaoMaQUANHEGIADINH;
            ThamSo.TaoMaQUANHEGIADINH = ma + 1;
            string maso = ma.ToString();
            String ngaySinh = dtiNgaysinhQHGD.Substring(0, 10);
            //String ngayKT = dtiNgayketthucCM.Substring(0, 10);


            OleDbCommand cmd = new OleDbCommand("INSERT INTO QUANHEGIADINH(MAQHGD,MANV,QUANHE,HOTEN,GHICHU,NGHENGHIEP,DIACHI,NGAYSINH) values(N'" + maso + "',N'" + txtManv + "',N'" + txtQuanheQHGD + "',N'" + txtHotenQHGD + "',N'" + txtGhichuQHGD + "',N'" + txtNghenghiepQHGD + "',N'" + txtDiachiQHGD + "',N'" + ngaySinh + "')");
            //OleDbCommand cmd = new OleDbCommand("INSERT INTO QUATRINHCONGTACNUOCNGOAI(MAQTCTNN,MANV,MASOQD,NUOCCONGTAC,TENCOQUAN,MUCDICH) values(N'" + maso + "',N'" + manv + "',N'" + soquyetdinh + "',N'" + nuoccongtac + "',N'" + tencoquan + "',N'" + mucdich + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable CapNhatQUANHEGIADINH(string dtiNgaysinhQHGD, string txtQuanheQHGD, string txtHotenQHGD, string txtGhichuQHGD, string txtNghenghiepQHGD, string txtDiachiQHGD, string maQHGD)
        {
            String ngaySINH = dtiNgaysinhQHGD.Substring(0, 10);
            //String ngayKT = dtiNgayketthucCM.Substring(0, 10);
            OleDbCommand cmd = new OleDbCommand("UPDATE QUANHEGIADINH SET QUANHE=N'" + txtQuanheQHGD + "',NGAYSINH=N'" + ngaySINH + "',HOTEN=N'" + txtHotenQHGD + "',GHICHU=N'" + txtGhichuQHGD + "',DIACHI=N'" + txtDiachiQHGD + "',NGHENGHIEP=N'" + txtNghenghiepQHGD + "' WHERe MAQHGD = '" + maQHGD + "'");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteQUANHEGIADINH(string maQHGD)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM QUANHEGIADINH WHERE MAQHGD ='" + maQHGD + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
