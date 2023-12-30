using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class QuaTrinhCongTacNNData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachQUATRINHCONGTACNUOCNGOAITheoMANV(string str)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM QUATRINHCONGTACNUOCNGOAI WHERE MANV like '" + str + "'");
            m_Ds.Load(cmd);

            return m_Ds;
        }
        public DataTable DanhsachQUATRINHCONGTACNUOCNGOAITheoMAQTCTNN(string str)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM GHICHU WHERE MAGC like '" + str + "'");
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

        public DataTable ThemQUATRINHCONGTACNN(string soquyetdinh, string nuoccongtac, string tencoquan, string mucdich, string ngaybatdau, string ngayketthuc,string manv)
        {
            long ma = ThamSo.TaoMaQUATRINHCONGTACNN;
            ThamSo.TaoMaQUATRINHCONGTACNN = ma + 1;
            string maso = ma.ToString();
            String ngayBD = ngaybatdau.Substring(0, 10);
            String ngayKT = ngayketthuc.Substring(0, 10);
            
            OleDbCommand cmd = new OleDbCommand("INSERT INTO QUATRINHCONGTACNUOCNGOAI(MAQTCTNN,MANV,MASOQD,NUOCCONGTAC,TENCOQUAN,MUCDICH,NGAYBATDAU,NGAYKETTHUC) values(N'" + maso + "',N'" + manv + "',N'" + soquyetdinh + "',N'" + nuoccongtac + "',N'" + tencoquan + "',N'" + mucdich + "',N'" + ngayBD + "',N'" + ngayKT + "')");
            //OleDbCommand cmd = new OleDbCommand("INSERT INTO QUATRINHCONGTACNUOCNGOAI(MAQTCTNN,MANV,MASOQD,NUOCCONGTAC,TENCOQUAN,MUCDICH) values(N'" + maso + "',N'" + manv + "',N'" + soquyetdinh + "',N'" + nuoccongtac + "',N'" + tencoquan + "',N'" + mucdich + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable CapNhatQUATRINHCONGTACNN(string soquyetdinh, string nuoccongtac, string tencoquan, string mucdich, string ngaybatdau, string ngayketthuc, string maQTCTNN)
        {
            String ngayBD = ngaybatdau.Substring(0, 10);
            String ngayKT = ngayketthuc.Substring(0, 10);
            OleDbCommand cmd = new OleDbCommand("UPDATE QUATRINHCONGTACNUOCNGOAI SET MASOQD=N'" + soquyetdinh + "',NUOCCONGTAC=N'" + nuoccongtac + "',TENCOQUAN=N'" + tencoquan + "',MUCDICH=N'" + mucdich + "',NGAYBATDAU=N'" + ngayBD + "',NGAYKETTHUC=N'" + ngayKT + "' WHERe MAQTCTNN = '" + maQTCTNN + "'");            

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteQTCTNN(string maQTCTNN)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM QUATRINHCONGTACNUOCNGOAI WHERE MAQTCTNN ='" + maQTCTNN + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
