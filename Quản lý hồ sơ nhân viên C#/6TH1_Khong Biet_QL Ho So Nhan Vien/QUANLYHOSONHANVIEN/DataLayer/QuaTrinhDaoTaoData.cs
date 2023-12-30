using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class QuaTrinhDaoTaoData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachQuaTrinhDaoTao(string manv)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM QUATRINHDAOTAO where manv='" + manv + "'");
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
        public DataTable ThemQUATRINHDAOTAO(string  txtNamnhaphocQTDT,string txtNamketthucQTDT,string txtBangcapQTDT,string txtGhichuQTDT,string txtNoidaotaoQTDT,string cmbNganhdaotaoQTDT,string cmbChuyennganhQTDT,string txtHinhthucQTDT,string txtManv)
        {
            long ma = ThamSo.TaoMaQUATRINHDAOTAO;
            ThamSo.TaoMaQUATRINHDAOTAO = ma + 1;
            string maso = ma.ToString();

            //MessageBox.Show("INSERT INTO QUATRINHCONGTAC(MAQTCT,MANV,NGAYBATDAU,NGAYKETTHUC,CONGVIECCUTHE,GHICHU,NOICONGTAC,CHUCVUCAONHAT) values(N'" + maso + "',N'" + manv + "',N'" + ngaybatdau + "',N'" + ngayketthuc + "',N'" + congvieccuthe + "',N'" + ghichu + "',N'" + noicongtac + "',N'" + chucvucaonhat + "')");

            OleDbCommand cmd = new OleDbCommand("INSERT INTO QUATRINHDAOTAO(MAQTDT,MANV,NAMNHAPHOC,NAMKETTHUC,BANGCAP,GHICHU,NOIDAOTAO,NGANHDAOTAO,CHUYENNGANH,HINHTHUC) values(N'" + maso + "',N'" + txtManv + "',N'" + txtNamnhaphocQTDT + "',N'" + txtNamketthucQTDT + "',N'" + txtBangcapQTDT + "',N'" + txtGhichuQTDT + "',N'" + txtNoidaotaoQTDT + "',N'" + cmbNganhdaotaoQTDT + "',N'" + cmbChuyennganhQTDT + "',N'" + txtHinhthucQTDT + "')");
            //OleDbCommand cmd = new OleDbCommand("INSERT INTO QUATRINHCONGTACNUOCNGOAI(MAQTCTNN,MANV,MASOQD,NUOCCONGTAC,TENCOQUAN,MUCDICH) values(N'" + maso + "',N'" + manv + "',N'" + soquyetdinh + "',N'" + nuoccongtac + "',N'" + tencoquan + "',N'" + mucdich + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable CapNhatQUATRINHDAOTAO(string txtNamnhaphocQTDT,string txtNamketthucQTDT,string txtBangcapQTDT,string txtGhichuQTDT,string txtNoidaotaoQTDT,string cmbNganhdaotaoQTDT,string cmbChuyennganhQTDT,string txtHinhthucQTDT,string  maQTDT)
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE QUATRINHDAOTAO SET NAMNHAPHOC=N'" + txtNamnhaphocQTDT + "',NAMKETTHUC=N'" + txtNamketthucQTDT + "',BANGCAP=N'" + txtBangcapQTDT + "',GHICHU=N'" + txtGhichuQTDT + "',NOIDAOTAO=N'" + txtNoidaotaoQTDT + "',NGANHDAOTAO=N'" + cmbNganhdaotaoQTDT + "',CHUYENNGANH=N'" + cmbChuyennganhQTDT + "',HINHTHUC=N'" + txtHinhthucQTDT + "' WHERe MAQTDT = '" + maQTDT + "'");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteQUATRINHDAOTAO(string maQTDT)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM QUATRINHDAOTAO WHERE MAQTDT ='" + maQTDT + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
