using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class ThongTinNhanSuData
    {
        DataService m_Ds = new DataService();
        public DataTable DanhsachNhanVien()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM NHANVIEN");
            m_Ds.Load(cmd);

            return m_Ds;
        }
        public DataTable DanhsachNhanVienNghiViec()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM NHANVIEN WHERE THOIVIEC='True'");
            m_Ds.Load(cmd);

            return m_Ds;
        }
        public DataTable DanhsachNhanVienConLamViec()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM NHANVIEN WHERE THOIVIEC='True'");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable DanhsachNhanVienTheoPhong(string maphong,string trangthai)
        {
            //MessageBox.Show("SELECT * FROM NHANVIEN WHERE phongban like '" + maphong + "' and TRANGTHAI ='" + trangthai + "'");
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM NHANVIEN WHERE phongban like '" + maphong + "' and TRANGTHAI ='" + trangthai + "'");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable ThemThongTinChinh(string txtManv,string  ckbGioitinh,string  txtHoten,string cmbPhongban,string dtiNgaycap,string dtiNgaysinh,string nvphutrach,string chucvu,string bidanh,string diachi,string cmnd,string tinhtranhhonnhan,string dienthoaiLh,string dienthoaiCT,string dienthoaiNha,string email,string fax,string noicap,string tinh,string quanhuyen,string tpgiadinh)
        {
            String ngayCap = dtiNgaycap.Substring(0, 10);
            String ngaySinh = dtiNgaysinh.Substring(0, 10);
            string trangthai = "TRUE";

            OleDbCommand cmd = new OleDbCommand("INSERT INTO NHANVIEN(MANV,GIOITINH,HOTEN,PHONGBAN,NGAYCAP,NGAYSINH,NVPHUTRACH,CHUCVU,BIDANH,DIACHI,CMND,TINHTRANGHONNHAN,DIENTHOAILH,DIENTHOAICT,DIENTHOAINHA,EMAIL,FAX,TRANGTHAI,NOICAP,TINH,QUANHUYEN,THANHPHANGD) values(N'" + txtManv + "',N'" + ckbGioitinh + "',N'" + txtHoten + "',N'" + cmbPhongban + "',N'" + ngayCap + "',N'" + ngaySinh + "',N'" + nvphutrach + "',N'" + chucvu + "',N'" + bidanh + "',N'" + diachi + "',N'" + cmnd + "',N'" + tinhtranhhonnhan + "',N'" + dienthoaiLh + "',N'" + dienthoaiCT + "',N'" + dienthoaiNha + "',N'" + email + "',N'" + fax + "',N'" + trangthai + "',N'" + noicap + "',N'" + tinh + "',N'" + quanhuyen + "',N'" + tpgiadinh + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable UpdateThemThongTinChinh(string manv, string cmbCalamviec, string txtSohopdong, string dtiBatdauhopdong, string dtiHethanhopdong, string txtHinhthuctuyendung, string cmbTrinhdotinhoc, string txtHocham, string txtHocvi, string txtSobhxh, string txtSobhyt, string txtCannang, string txtCao, string txtNhommau, string txtSuckhoe, string txtTaokhoannganhang, string txtTennganhang, string txtDiachinganhang)
        {
            String ngayBatdauhopdong = dtiBatdauhopdong.Substring(0, 10);
            String ngayHethanhopdong = dtiHethanhopdong.Substring(0, 10);
            MessageBox.Show("UPDATE NHANVIEN SET CALAMVIEC=N'" + cmbCalamviec + "',SOHD=N'" + txtSohopdong + "',BATDAUHD=N'" + ngayBatdauhopdong + "',HETHANHD=N'" + ngayHethanhopdong + "',HINHTHUCTUYENDUNG=N'" + txtHinhthuctuyendung + "',TRINHDOTINHOC=N'" + cmbTrinhdotinhoc + "',HOCHAM=N'" + txtHocham + "',HOCVI=N'" + txtHocvi + "',SOBHXH=N'" + txtSobhxh + "',SOBHYT=N'" + txtSobhyt + "',CANNANG=N'" + txtCannang + "',CAO=N'" + txtCao + "',SUCKHOE=N'" + txtSuckhoe + "',TAIKHOANNH=N'" + txtTaokhoannganhang + "',TENNH=N'" + txtTennganhang + "',DIACHINH=N'" + txtDiachinganhang + "' WHERe MANV = '" + manv + "'");

            OleDbCommand cmd = new OleDbCommand("UPDATE NHANVIEN SET CALAMVIEC=N'" + cmbCalamviec + "',SOHD=N'" + txtSohopdong + "',BATDAUHD=N'" + ngayBatdauhopdong + "',HETHANHD=N'" + ngayHethanhopdong + "',HINHTHUCTUYENDUNG=N'" + txtHinhthuctuyendung + "',TRINHDOTINHOC=N'" + cmbTrinhdotinhoc + "',HOCHAM=N'" + txtHocham + "',HOCVI=N'" + txtHocvi + "',SOBHXH=N'" + txtSobhxh + "',SOBHYT=N'" + txtSobhyt + "',CANNANG=N'" + txtCannang + "',CAO=N'" + txtCao + "',SUCKHOE=N'" + txtSuckhoe + "',TAIKHOANNH=N'" + txtTaokhoannganhang + "',TENNH=N'" + txtTennganhang + "',DIACHINH=N'" + txtDiachinganhang + "' WHERe MANV = '" + manv + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable ThoiViecNV(String maNV)
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE NHANVIEN SET TRANGTHAI='FALSE',NVPHUTRACH='' WHERE MANV='" + maNV + "'");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable ThemNhanVien(string manv,string trangthai,string gioitinh,string hoten,string bidanh,string cmnd,string dtiNgaycap,string  txtNoicap,string  txtDiachi ,string  txtDienthoaiLH ,string  txtDienthoaiCT,string txtDienthoaiNha ,string txtEmail  ,string  txtFax,string dtiNgaySinh  ,string  txtTinh ,string txtQuanHuyen ,string cmbTinhTrangHonnhan ,string  txtThanhPhanGD ,string  cmbNvphutrach,
                    string  cmbPhongBan ,string  cmbChucVu, string cmbCalamviec,string  txtSohopdong ,string dtiBatdauhopdong ,string  dtiHethanhopdong
            ,string ckbThuviec,string ckbNhanvienphucvu ,string txtHinhthuctuyendung ,string cmbTrinhdotinhoc,string txtHocham ,string  txtHocvi   ,
            string txtSobhxh,
               string  txtSobhyt,
               string  txtCannang,
              string   txtCao,
              string   txtNhommau,
              string   txtSuckhoe,
               string  txtTaokhoannganhang,
               string  txtTennganhang,
               string  txtDiachinganhang,
            string thuongphatthang,string tongphat,string tongthuong,string  luong,string phucaptn,string phucapdh,string phucapkv,string phucapkhac
            ,string hinh)
        {
            string ngayCap = dtiNgaycap.Substring(0, 10);
            string ngaySinh = dtiNgaySinh.Substring(0, 10);
            string ngaybatdauhd = dtiBatdauhopdong.Substring(0,10);
            string ngayketthuchd = dtiHethanhopdong.Substring(0, 10);

            OleDbCommand cmd = new OleDbCommand("INSERT INTO NHANVIEN(MANV,TRANGTHAI,GIOITINH,HOTEN,BIDANH,CMND,NGAYCAP,NOICAP,DIACHI,DIENTHOAILH,DIENTHOAICT,DIENTHOAINHA,EMAIL,FAX,NGAYSINH,TINH,QUANHUYEN,TINHTRANGHONNHAN,THANHPHANGD,NVPHUTRACH,PHONGBAN,CHUCVU,CALAMVIEC,SOHD,BATDAUHD,HETHANHD,THUVIEC,NVPHUCVU,HINHTHUCTUYENDUNG,TRINHDOTINHOC,HOCHAM,HOCVI,SOBHXH,SOBHYT,CANNANG,CAO,NHOMMAU,SUCKHOE,TAIKHOANNH,TENNH,DIACHINH,THUONGPHATTHANG,TONGPHAT,TONGTHUONG,LUONG,PHUCAPTN,PHUCAPDH,PHUCAPKV,PHUCAPKHAC,HINHNV) values(N'" + manv + "',N'" + trangthai + "',N'" + gioitinh + "',N'" + hoten + "',N'" + bidanh + "',N'" + cmnd + "',N'" + ngayCap + "',N'" + txtNoicap + "',N'" + txtDiachi + "',N'" + txtDienthoaiLH + "',N'" + txtDienthoaiCT + "',N'" + txtDienthoaiNha + "',N'" + txtEmail + "',N'" + txtFax + "',N'" + ngaySinh + "',N'" + txtTinh + "',N'" + txtQuanHuyen + "',N'" + cmbTinhTrangHonnhan + "',N'" + txtThanhPhanGD + "',N'" + cmbNvphutrach + "',N'" + cmbPhongBan + "',N'" + cmbChucVu + "',N'" + cmbCalamviec + "',N'" + txtSohopdong + "',N'" + ngaybatdauhd + "',N'" + ngayketthuchd + "',N'" + ckbThuviec + "',N'" + ckbNhanvienphucvu + "',N'" + txtHinhthuctuyendung + "',N'" + cmbTrinhdotinhoc + "',N'" + txtHocham + "',N'" + txtHocvi + "',N'" + txtSobhxh + "',N'" + txtSobhyt + "',N'" + txtCannang + "',N'" + txtCao + "',N'" + txtNhommau + "',N'" + txtSuckhoe + "',N'" + txtTaokhoannganhang + "',N'" + txtTennganhang + "',N'" + txtDiachinganhang + "',N'" + thuongphatthang + "',N'" + tongphat + "',N'" + tongthuong + "',N'" + luong + "',N'" + phucaptn + "',N'" + phucapdh + "',N'" + phucapkv + "',N'" + phucapkhac + "',N'" + hinh + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable CapNhatNhanVien(string gioitinh, string hoten, string bidanh, string cmnd, string dtiNgaycap, string txtNoicap, string txtDiachi, string txtDienthoaiLH, string txtDienthoaiCT, string txtDienthoaiNha, string txtEmail, string txtFax, string dtiNgaySinh, string txtTinh, string txtQuanHuyen, string cmbTinhTrangHonnhan, string txtThanhPhanGD, string cmbNvphutrach,
                    string cmbPhongBan, string cmbChucVu, string cmbCalamviec, string txtSohopdong, string dtiBatdauhopdong, string dtiHethanhopdong
            , string ckbThuviec, string ckbNhanvienphucvu, string txtHinhthuctuyendung, string cmbTrinhdotinhoc, string txtHocham, string txtHocvi,
            string txtSobhxh,
               string txtSobhyt,
               string txtCannang,
              string txtCao,
              string txtNhommau,
              string txtSuckhoe,
               string txtTaokhoannganhang,
               string txtTennganhang,
               string txtDiachinganhang,
            string thuongphatthang, string tongphat, string tongthuong, string luong, string phucaptn, string phucapdh, string phucapkv, string phucapkhac, string tenLogo, string manv)
        {
            string ngayCap = dtiNgaycap.Substring(0, 10);
            string ngaySinh = dtiNgaySinh.Substring(0, 10);
            string ngaybatdauhd = dtiBatdauhopdong.Substring(0, 10);
            string ngayketthuchd = dtiHethanhopdong.Substring(0, 10);

            OleDbCommand cmd = new OleDbCommand("UPDATE NHANVIEN SET GIOITINH=N'" + gioitinh + "',HOTEN=N'" + hoten + "',BIDANH=N'" + bidanh + "',CMND=N'" + cmnd + "',NGAYCAP=N'" + ngayCap + "',NOICAP=N'" + txtNoicap + "',DIACHI=N'" + txtDiachi + "',DIENTHOAILH=N'" + txtDienthoaiLH + "',DIENTHOAICT=N'" + txtDienthoaiCT + "',DIENTHOAINHA=N'" + txtDienthoaiNha + "',EMAIL=N'" + txtEmail + "',FAX=N'" + txtFax + "',NGAYSINH=N'" + ngaySinh + "',TINH=N'" + txtTinh + "',QUANHUYEN=N'" + txtQuanHuyen + "',TINHTRANGHONNHAN=N'" + cmbTinhTrangHonnhan + "',THANHPHANGD=N'" + txtThanhPhanGD + "',NVPHUTRACH=N'" + cmbNvphutrach + "',PHONGBAN=N'" + cmbPhongBan + "',CHUCVU=N'" + cmbChucVu + "',CALAMVIEC=N'" + cmbCalamviec + "',SOHD=N'" + txtSohopdong + "',BATDAUHD=N'" + ngaybatdauhd + "',HETHANHD=N'" + ngayketthuchd + "',HINHTHUCTUYENDUNG=N'" + txtHinhthuctuyendung + "',THUVIEC=N'" + ckbThuviec + "',NVPHUCVU=N'" + ckbNhanvienphucvu + "',TRINHDOTINHOC=N'" + cmbTrinhdotinhoc + "',HOCHAM=N'" + txtHocham + "',HOCVI=N'" + txtHocvi + "',SOBHXH=N'" + txtSobhxh + "',SOBHYT=N'" + txtSobhyt + "',CANNANG=N'" + txtCannang + "',CAO=N'" + txtCao + "',NHOMMAU=N'" + txtNhommau + "',SUCKHOE=N'" + txtSuckhoe + "',TAIKHOANNH=N'" + txtTaokhoannganhang + "',TENNH=N'" + txtTennganhang + "',DIACHINH=N'" + txtDiachinganhang + "',HINHNV=N'" + tenLogo + "' WHERe MANV = '" + manv + "'");
            m_Ds.Load(cmd);

            return m_Ds;
        }
    }
}
