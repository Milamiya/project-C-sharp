using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    class QuaTrinhCongTacData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachQuaTrinhCT(string manv)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM QUATRINHCONGTAC where manv='" + manv + "'");
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
        public DataTable ThemQUATRINHCONGTAC(string ngaybatdau, string ngayketthuc, string congvieccuthe, string ghichu, string noicongtac, string chucvucaonhat, string manv)
        {
            long ma = ThamSo.TaoMaQUATRINHCONGTAC;
            ThamSo.TaoMaQUATRINHCONGTAC = ma + 1;
            string maso = ma.ToString();
            String ngayBD = ngaybatdau.Substring(0, 10);
            String ngayKT = ngayketthuc.Substring(0, 10);

            //MessageBox.Show("INSERT INTO QUATRINHCONGTAC(MAQTCT,MANV,NGAYBATDAU,NGAYKETTHUC,CONGVIECCUTHE,GHICHU,NOICONGTAC,CHUCVUCAONHAT) values(N'" + maso + "',N'" + manv + "',N'" + ngaybatdau + "',N'" + ngayketthuc + "',N'" + congvieccuthe + "',N'" + ghichu + "',N'" + noicongtac + "',N'" + chucvucaonhat + "')");

            OleDbCommand cmd = new OleDbCommand("INSERT INTO QUATRINHCONGTAC(MAQTCT,MANV,NGAYBATDAU,NGAYKETTHUC,CONGVIECCUTHE,GHICHU,NOICONGTAC,CHUCVUCAONHAT) values(N'" + maso + "',N'" + manv + "',N'" + ngayBD + "',N'" + ngayKT + "',N'" + congvieccuthe + "',N'" + ghichu + "',N'" + noicongtac + "',N'" + chucvucaonhat + "')");
            //OleDbCommand cmd = new OleDbCommand("INSERT INTO QUATRINHCONGTACNUOCNGOAI(MAQTCTNN,MANV,MASOQD,NUOCCONGTAC,TENCOQUAN,MUCDICH) values(N'" + maso + "',N'" + manv + "',N'" + soquyetdinh + "',N'" + nuoccongtac + "',N'" + tencoquan + "',N'" + mucdich + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable CapNhatQUATRINHCONGTAC(string ngaybatdau, string ngayketthuc, string congvieccuthe, string ghichu, string noicongtac, string chucvucaonhat, string maQTCT)
        {
            String ngayBD = ngaybatdau.Substring(0, 10);
            String ngayKT = ngayketthuc.Substring(0, 10);
            OleDbCommand cmd = new OleDbCommand("UPDATE QUATRINHCONGTAC SET NGAYBATDAU=N'" + ngayBD + "',NGAYKETTHUC=N'" + ngayKT + "',CONGVIECCUTHE=N'" + congvieccuthe + "',GHICHU=N'" + ghichu + "',NOICONGTAC=N'" + noicongtac + "',CHUCVUCAONHAT=N'" + chucvucaonhat + "' WHERe MAQTCT = '" + maQTCT + "'");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteQTCT(string maQTCT)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM QUATRINHCONGTAC WHERE MAQTCT ='" + maQTCT + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
