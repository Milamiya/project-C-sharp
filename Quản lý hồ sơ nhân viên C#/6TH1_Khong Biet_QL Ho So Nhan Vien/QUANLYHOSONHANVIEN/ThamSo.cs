using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace QUANLYHOSONHANVIEN
{
    public class ThamSo
    {
        public static QUANLYHOSONHANVIEN.BusinessObject.NhanVienInfo LayTTNhanVien(string ma)
        {
            QUANLYHOSONHANVIEN.BusinessObject.NhanVienInfo nhanvien = new QUANLYHOSONHANVIEN.BusinessObject.NhanVienInfo();
            DataService m_Ds = new DataService();
            m_Ds.Load(new OleDbCommand("select hoten,manv from nhanvien where manv='" + ma + "'"));
            if (m_Ds.Rows.Count > 0)
            {
                nhanvien.MaNV = m_Ds.Rows[0]["MANV"].ToString();
                nhanvien.HoTen  = m_Ds.Rows[0]["HOTEN"].ToString();
            }
            return nhanvien;
        }
        public static QUANLYHOSONHANVIEN.BusinessObject.ThongTinCongTyInfo LayTTCongTy()
        {
            QUANLYHOSONHANVIEN.BusinessObject.ThongTinCongTyInfo congty = new QUANLYHOSONHANVIEN.BusinessObject.ThongTinCongTyInfo();
            DataService m_Ds = new DataService();
            m_Ds.Load(new OleDbCommand("select * from THONGTINCONGTY"));
            if (m_Ds.Rows.Count > 0)
            {
                congty.TenCT = m_Ds.Rows[0]["TENCT"].ToString();
                congty.DiaChi = m_Ds.Rows[0]["DIACHI"].ToString();
                congty.DiaThoai = m_Ds.Rows[0]["DIENTHOAI"].ToString();
                congty.ThuDienTu = m_Ds.Rows[0]["THUDIENTU"].ToString();
                congty.SebSite = m_Ds.Rows[0]["WEBSITE"].ToString();                
            }
            return congty;
        }
        public static QUANLYHOSONHANVIEN.BusinessObject.DangNhapInfo LayTTDangNhap(string ma)
        {
            QUANLYHOSONHANVIEN.BusinessObject.DangNhapInfo thongtindangnhap = new QUANLYHOSONHANVIEN.BusinessObject.DangNhapInfo();
            DataService m_Ds = new DataService();
            m_Ds.Load(new OleDbCommand("select * from nguoidung where username='" + ma + "'"));
            if (m_Ds.Rows.Count > 0)
            {
                thongtindangnhap.username = m_Ds.Rows[0]["USERNAME"].ToString();
                thongtindangnhap.password = m_Ds.Rows[0]["PASSWORD"].ToString();
                thongtindangnhap.quyen = m_Ds.Rows[0]["quyen"].ToString();                
            }
            return thongtindangnhap;
        }

        public static long TaoMaNhanVien
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MANV FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MANV = " + value));
            }
        }
        public static long TaoMaPHUCAP
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MAPC FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MAPC = " + value));
            }
        }
        public static long TaoMaHINHTHUCKHENTHUONG
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MAHTKT FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MAHTKT = " + value));
            }
        }
        public static long TaoMaHINHTHUCDAOTAO
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MAHTDT FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MAHTDT = " + value));
            }
        }
        public static long TaoMaQTHD
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MAQTHD FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MAQTHD = " + value));
            }
        }
        public static long TaoMaGhichu
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MAGC FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MAGC = " + value));
            }
        }
        public static long TaoMaQUATRINHCONGTACNN
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MAQTCTNN FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MAQTCTNN = " + value));
            }
        }
        public static long TaoMaQUATRINHCONGTAC
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MAQTCT FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MAQTCT = " + value));
            }
        }
        public static long TaoMaQUATRINHDAOTAO
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MAQTDT FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MAQTDT = " + value));
            }
        }

        public static long TaoMaKhenThuong
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MAQTKT FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MAQTKT = " + value));
            }
        }

        public static long TaoMaKyLuat
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MAQTKL FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MAQTKL = " + value));
            }
        }

        public static long TaoMaQUATRINHBOIDUONG
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MAQTBD FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MAQTBD = " + value));
            }
        }
        public static long TaoMaCHUYENMON
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MACM FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MACM = " + value));
            }
        }

        public static long TaoMaChuyenNganh
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MACN FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MACN = " + value));
            }
        }
        public static long TaoMaDOTDAOTAO
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MADDT FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MADDT = " + value));
            }
        }
        public static long TaoMaTHAMGIADAOTAO
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MATGDT FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MATGDT = " + value));
            }
        }
        public static long TaoMaQUANHEGIADINH
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MAQHGD FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MAQHGD = " + value));
            }
        }
        public static long TaoMaTHANNHANNUOCNGOAI
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MATNNN FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MATNNN = " + value));
            }
        }
        public DataTable LuuThongTinCongTy(String tenct, String diachi, string dienthoai, string thudientu, string website,string logo)
        {
            DataService m_Ds = new DataService();
            MessageBox.Show("UPDATE THONGTINCONGTY SET TENCT=N'" + tenct + "',DIACHI=N'" + diachi + "',DIENTHOAI=N'" + dienthoai + "',THUDIENTU=N'" + thudientu + "',WEBSITE=N'" + website + "',LOGO=N'" + logo + "'");
            //OleDbCommand cmd = new OleDbCommand("UPDATE THONGTINCONGTY SET TENCT=N'" + tenct + "',DIACHI=N'" + diachi + "'");
            OleDbCommand cmd = new OleDbCommand("UPDATE THONGTINCONGTY SET TENCT=N'" + tenct + "',DIACHI=N'" + diachi + "',DIENTHOAI=N'" + dienthoai + "',THUDIENTU=N'" + thudientu + "',WEBSITE=N'" + website + "',logo=N'" + logo + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public static long TaoMaNguoidung
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT manguoidung FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET manguoidung = " + value));
            }
        }
        public static long TaoMaPhongBan
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT mapb FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET mapb = " + value));
            }
        }
        public static long TaoMaNgheNghiep
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT mann FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET mann = " + value));
            }
        }
        public static long TaoMaCONGVIEC
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MACONGVIEC FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MACONGVIEC = " + value));
            }
        }
        public static long TaoMaDotDanhGia
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT maddg FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET maddg = " + value));
            }
        }
        public static long TaoMaDanhSachDanhGia
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT madsdg FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET madsdg = " + value));
            }
        }
        public static long TaoMaChucVu
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT macv FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET macv = " + value));
            }
        }
        public static long TaoDanhSachNgheNghiep        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT madsnn FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET madsnn = " + value));
            }
        }
        public static long TaoDanhSachNGOAINGU
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT madsnnGU FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET madsnnGU = " + value));
            }
        }
        public static long TaoDanhSachPHONGBANDALAMVIEC
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MAPBDLV FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MAPBDLV = " + value));
            }
        }
        public static long TaoMaNGOAINGU
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT mangoaingu FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET mangoaingu = " + value));
            }
        }
        public static long TaoMaHINHTHUCKL
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MAKL FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MAKL = " + value));
            }
        }
        public static long TaoMaNganhHOC
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MANH FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MANH = " + value));
            }
        }
        public static long TaoMaLOAIHD
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MALOAIHD FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MALOAIHD = " + value));
            }
        }
        public static long TaoMaTRINHDO
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MATD FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MATD = " + value));
            }
        }
        public static long TaoMaVANBANG
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MAVB FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MAVB = " + value));
            }
        }
        public static long TaoMaTDTH
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MaTDTH FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MaTDTH = " + value));
            }
        }
        public static long TaoMaDANHSACHCONGVIEC
        {
            get
            {
                DataService ds = new DataService();
                object obj = ds.ExecuteScalar(new OleDbCommand("SELECT MADSCV FROM ThamSo"));
                return Convert.ToInt64(obj);
            }
            set
            {
                DataService ds = new DataService();
                ds.ExecuteNoneQuery(new OleDbCommand("UPDATE ThamSo SET MADSCV = " + value));
            }
        }
    }
}
