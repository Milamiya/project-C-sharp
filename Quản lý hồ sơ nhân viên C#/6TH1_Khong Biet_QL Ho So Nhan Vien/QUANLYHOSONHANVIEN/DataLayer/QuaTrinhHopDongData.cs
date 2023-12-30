using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class QuaTrinhHopDongData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachQuaTrinhHOPDONG(string manv)
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM QUATRINHHOPDONG where manv='" + manv + "'");
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
        public DataTable ThemQUATRINHHOPDONG(string txtManv,string txtMahdqthd,string dtiNgaybatdauqthd,string dtiNgayketthucqthd,string dtiNgaykyqthd,string numLankyqthd,string txtHinhthucqthd,string txtNoidungqthd,string txtGhichuqthd,string txtvitriqthd,string cmbChucVu,string txtMucluongqthd,string cmbNguoikyqthd)
        {
            //long ma = ThamSo.TaoMaQUATRINHCONGTAC;
            //ThamSo.TaoMaQUATRINHCONGTAC = ma + 1;
            //string maso = ma.ToString();
            String ngayBD = dtiNgaybatdauqthd.Substring(0, 10);
            String ngayKT = dtiNgayketthucqthd.Substring(0, 10);
            string ngayKy = dtiNgaykyqthd.Substring(0, 10);

            //MessageBox.Show("INSERT INTO QUATRINHCONGTAC(MAQTCT,MANV,NGAYBATDAU,NGAYKETTHUC,CONGVIECCUTHE,GHICHU,NOICONGTAC,CHUCVUCAONHAT) values(N'" + maso + "',N'" + manv + "',N'" + ngaybatdau + "',N'" + ngayketthuc + "',N'" + congvieccuthe + "',N'" + ghichu + "',N'" + noicongtac + "',N'" + chucvucaonhat + "')");

            OleDbCommand cmd = new OleDbCommand("INSERT INTO QUATRINHHOPDONG(MAHD,MANV,NGAYBATDAU,NGAYKETTHUC,LANKY,HINHTHUC,NOIDUNG,GHICHU,VITRI,CHUCVU,MUCLUONG,NGUOIKY,NGAYKY) values(N'" + txtMahdqthd + "',N'" + txtManv + "',N'" + ngayBD + "',N'" + ngayKT + "',N'" + numLankyqthd + "',N'" + txtHinhthucqthd + "',N'" + txtNoidungqthd + "',N'" + txtGhichuqthd + "',N'" + txtvitriqthd + "',N'" + cmbChucVu + "',N'" + txtMucluongqthd + "',N'" + cmbNguoikyqthd + "',N'" + ngayKy + "')");
            //OleDbCommand cmd = new OleDbCommand("INSERT INTO QUATRINHCONGTACNUOCNGOAI(MAQTCTNN,MANV,MASOQD,NUOCCONGTAC,TENCOQUAN,MUCDICH) values(N'" + maso + "',N'" + manv + "',N'" + soquyetdinh + "',N'" + nuoccongtac + "',N'" + tencoquan + "',N'" + mucdich + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable CapNhatQUATRINHHOPDONG(string dtiNgaybatdauqthd, string dtiNgayketthucqthd, string dtiNgaykyqthd, string numLankyqthd, string txtHinhthucqthd, string txtNoidungqthd, string txtGhichuqthd, string txtvitriqthd, string cmbChucVu, string txtMucluongqthd, string cmbNguoikyqthd,string mahd)
        {
            String ngayBD = dtiNgaybatdauqthd.Substring(0, 10);
            String ngayKT = dtiNgayketthucqthd.Substring(0, 10);
            string ngayKy = dtiNgaykyqthd.Substring(0, 10);
            //MessageBox.Show("UPDATE QUATRINHHOPDONG SET NGAYBATDAU=N'" + ngayBD + "',NGAYKETTHUC=N'" + ngayKT + "',NGAYKY=N'" + ngayKy + "',LANKY=N'" + numLankyqthd + "',HINHTHUC=N'" + txtHinhthucqthd + "',NOIDUNG=N'" + txtNoidungqthd + "',GHICHU=N'" + txtGhichuqthd + "',VITRI=N'" + txtvitriqthd + "',CHUCVU=N'" + cmbChucVu + "',MUCLUONG=N'" + txtMucluongqthd + "',NGUOIKY=N'" + cmbNguoikyqthd + "' WHERe MAHD = '" + mahd + "'");
            OleDbCommand cmd = new OleDbCommand("UPDATE QUATRINHHOPDONG SET NGAYBATDAU=N'" + ngayBD + "',NGAYKETTHUC=N'" + ngayKT + "',NGAYKY=N'" + ngayKy + "',LANKY=N'" + numLankyqthd + "',HINHTHUC=N'" + txtHinhthucqthd + "',NOIDUNG=N'" + txtNoidungqthd + "',GHICHU=N'" + txtGhichuqthd + "',VITRI=N'" + txtvitriqthd + "',CHUCVU=N'" + cmbChucVu + "',MUCLUONG=N'" + txtMucluongqthd + "',NGUOIKY=N'" + cmbNguoikyqthd + "' WHERe MAHD = '" + mahd + "'");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteQUATRINHHOPDONG(string ma)
        {
            //MessageBox .Show ("DELETE FROM QUATRINHHOPDONG WHERE mahd ='" + ma + "'");
            OleDbCommand cmd = new OleDbCommand("DELETE FROM QUATRINHHOPDONG WHERE mahd ='" + ma + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
    }
}
