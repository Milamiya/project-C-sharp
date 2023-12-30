using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QUANLYHOSONHANVIEN.BusinessObject
{
    public class NhanVienInfo
    {
        public NhanVienInfo() { }
        public NhanVienInfo(string manv)
        {
            m_MaNV = manv;
        }
        private string m_MaNV;
        public string MaNV
        { 
            get {return m_MaNV;}
            set { m_MaNV = value; }
        }
        private string m_picture;
        public string picture
        {
            get { return m_picture; }
            set { m_picture = value; }
        }
        private string m_HoTen;
        public string HoTen
        {
            get { return m_HoTen; }
            set { m_HoTen = value; }
        }
        private string m_HoTenKhac;
        public string HoTenKhac
        {
            get { return m_HoTenKhac; }
            set { m_HoTenKhac = value; }
        }
        private string m_GioiTinh;
        public string GioiTinh
        {
            get { return m_GioiTinh; }
            set { m_GioiTinh = value; }
        }
        private string m_NgaySinh;
        public string NgaySinh
        {
            get { return m_NgaySinh; }
            set { m_NgaySinh = value; }
        }
        private string m_NoiSinh;
        public string NoiSinh   
        {
            get { return m_NoiSinh; }
            set { m_NoiSinh = value; }
        }
        private string m_HoKhau;
        public string HoKhau
        {
            get { return m_HoKhau; }
            set { m_HoKhau = value; }
        }
        private string m_QueQuan;
        public string QueQuan
        {
            get { return m_QueQuan; }
            set { m_QueQuan = value; }
        }
        private string m_DiaChi;
        public string DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }
        private string m_TruQuan;
        public string TruQuan
        {
            get { return m_TruQuan; }
            set { m_TruQuan = value; }
        }
        private string m_BaoTin;
        public string BaoTin
        {
            get { return m_BaoTin; }
            set { m_BaoTin = value; }
        }
        private string m_Email;
        public string Email
        {
            get { return m_Email; }
            set { m_Email = value; }
        }
        private string m_Tel_CQ;
        public string Tel_CQ
        {
            get { return m_Tel_CQ; }
            set { m_Tel_CQ = value; }
        }
        private string m_Tel_NR;
        public string Tel_NR
        {
            get { return m_Tel_NR; }
            set { m_Tel_NR = value; }
        }
        private string m_fax;
        public string fax
        {
            get { return m_fax; }
            set { m_fax = value; }
        }
        private string m_MAPHONG;
        public string MAPHONG
        {
            get { return m_MAPHONG; }
            set { m_MAPHONG = value; }
        }
        private string m_MACV;
        public string MACV
        {
            get { return m_MACV; }
            set { m_MACV = value; }
        }
        private string m_MADT;
        public string MADT
        {
            get { return m_MADT; }
            set { m_MADT = value; }
        }
        private string m_MATG;
        public string MATG
        {
            get { return m_MATG; }
            set { m_MATG = value; }
        }
       
        private string m_MaBacLuong;
        public string MaBacLuong
        {
            get { return m_MaBacLuong; }
            set { m_MaBacLuong = value; }
        }
        private string m_NgayXepLuong;
        public string NgayXepLuong
        {
            get { return m_NgayXepLuong; }
            set { m_NgayXepLuong = value; }
        }
        private float m_HeSoLuong;
        public float HeSoLuong
        {
            get { return m_HeSoLuong; }
            set { m_HeSoLuong = value; }
        }
        private float m_PhuCapChucVu;
        public float PhuCapChucVu
        {
            get { return m_PhuCapChucVu; }
            set { m_PhuCapChucVu = value; }
        }
        private string m_TaiKhoan;
        public string TaiKhoan
        {
            get { return m_TaiKhoan; }
            set { m_TaiKhoan = value; }
        }
        private string m_NoiKhamBenh;
        public string NoiKhamBenh
        {
            get { return m_NoiKhamBenh; }
            set { m_NoiKhamBenh = value; }
        }
        private string m_CMND;
        public string CMND
        {
            get { return m_CMND; }
            set { m_CMND = value; }
        }
        
        private string m_NGAYCAP;
        public string NGAYCAP
        {
            get { return m_NGAYCAP; }
            set { m_NGAYCAP = value; }
        }
        
        private string m_NOICAP;
        public string NOICAP
        {
            get { return m_NOICAP; }
            set { m_NOICAP = value; }
        }
        private string m_MATP_GD;
        public string MATP_GD
        {
            get { return m_MATP_GD; }
            set { m_MATP_GD = value; }
        }
        private string m_MATP_BT;
        public string MATP_BT
        {
            get { return m_MATP_BT; }
            set { m_MATP_BT = value; }
        }
        private string m_NGAYNHAPNGU;
        public string NGAYNHAPNGU
        {
            get { return m_NGAYNHAPNGU; }
            set { m_NGAYNHAPNGU = value; }
        }
        private string m_MACHUCVUQD;
        public string MACHUCVUQD
        {
            get { return m_MACHUCVUQD; }
            set { m_MACHUCVUQD = value; }
        }
        private string m_NGAYXUATNGU;
        public string NGAYXUATNGU
        {
            get { return m_NGAYXUATNGU; }
            set { m_NGAYNHAPNGU = value; }
        }
        private string m_NGAYVAONGANH;
        public string NGAYVAONGANH
        {
            get { return m_NGAYVAONGANH; }
            set { m_NGAYVAONGANH = value; }
        }
        private string m_NGAYVAOCQ;
        public string NGAYVAOCQ
        {
            get { return m_NGAYVAOCQ; }
            set { m_NGAYVAOCQ = value; }
        }
        private string m_NGAYVAO_DOANTNCS;
        public string NGAYVAO_DOANTNCS
        {
            get { return m_NGAYVAO_DOANTNCS; }
            set { m_NGAYVAO_DOANTNCS = value; }
        }
        private string m_MACHUCVUDOAN;
        public string MACHUCVUDOAN
        {
            get { return m_MACHUCVUDOAN; }
            set { m_MACHUCVUDOAN = value; }
        }
        private string m_NGAYVAO_CD;
        public string NGAYVAO_CD
        {
            get { return m_NGAYVAO_CD; }
            set { m_NGAYVAO_CD = value; }
        }
        private string m_MACHUCVUCONGDOAN;
        public string MACHUCVUCONGDOAN
        {
            get { return m_MACHUCVUCONGDOAN; }
            set { m_MACHUCVUCONGDOAN = value; }
        }
        private string m_NGAYVAODANG;
        public string NGAYVAODANG
        {
            get { return m_NGAYVAODANG; }
            set { m_NGAYVAODANG = value; }
        }
        private string m_NGAYCHINHTHUC;
        public string NGAYCHINHTHUC
        {
            get { return m_NGAYCHINHTHUC; }
            set { m_NGAYCHINHTHUC = value; }
        }
        private string m_MACHUCVUDANG;
        public string MACHUCVUDANG
        {
            get { return m_MACHUCVUDANG; }
            set { m_MACHUCVUDANG = value; }
        }
        private string m_NOIVAODANG;
        public string NOIVAODANG
        {
            get { return m_NOIVAODANG; }
            set { m_NOIVAODANG = value; }
        }
        private string m_NGUOIGIOITHIEU1;
        public string NGUOIGIOITHIEU1
        {
            get { return m_NGUOIGIOITHIEU1; }
            set { m_NGUOIGIOITHIEU1 = value; }
        }
        private string m_NGUOIGIOITHIEU2;
        public string NGUOIGIOITHIEU2
        {
            get { return m_NGUOIGIOITHIEU2; }
            set { m_NGUOIGIOITHIEU2 = value; }
        }
        private string m_MATHUONGBINH;
        public string MATHUONGBINH
        {
            get { return m_MATHUONGBINH; }
            set { m_MATHUONGBINH = value; }
        }
        private string m_GIADINHLIETSI;
        public string GIADINHLIETSI
        {
            get { return m_GIADINHLIETSI; }
            set { m_GIADINHLIETSI = value; }
        }
        private string m_HUONGCDTBLS;
        public string HUONGCDTBLS
        {
            get { return m_HUONGCDTBLS; }
            set { m_HUONGCDTBLS = value; }
        }
        private string m_MATRINHDOHOCVAN;
        public string MATRINHDOHOCVAN
        {
            get { return m_MATRINHDOHOCVAN; }
            set { m_MATRINHDOHOCVAN = value; }
        }
        private string m_MATRINHDOCHUYENMON;
        public string MATRINHDOCHUYENMON
        {
            get { return m_MATRINHDOCHUYENMON; }
            set { m_MATRINHDOCHUYENMON = value; }
        }
        private string m_MAHTDAOTAO;
        public string MAHTDAOTAO
        {
            get { return m_MAHTDAOTAO; }
            set { m_MAHTDAOTAO = value; }
        }
        private string m_NAMTN;
        public string NAMTN
        {
            get { return m_NAMTN; }
            set { m_NAMTN = value; }
        }
        private string m_MACHUYENNGANH;
        public string MACHUYENNGANH
        {
            get { return m_MACHUYENNGANH; }
            set { m_MACHUYENNGANH = value; }
        }
        private string m_MATRINHDONGOAINGU;
        public string MATRINHDONGOAINGU
        {
            get { return m_MATRINHDONGOAINGU; }
            set { m_MATRINHDONGOAINGU = value; }
        }
        private string m_MACONGVIECDAMNHAN;
        public string MACONGVIECDAMNHAN
        {
            get { return m_MACONGVIECDAMNHAN; }
            set { m_MACONGVIECDAMNHAN = value; }
        }
        private string m_SOSOBHXH;
        public string SOSOBHXH
        {
            get { return m_SOSOBHXH; }
            set { m_SOSOBHXH = value; }
        }
        private string m_NGAYCAPSO;
        public string NGAYCAPSO
        {
            get { return m_NGAYCAPSO; }
            set { m_NGAYCAPSO = value; }
        }
        private string m_NOICAPSO;
        public string NOICAPSO
        {
            get { return m_NOICAPSO; }
            set { m_NOICAPSO = value; }
        }
        private string m_NGAYDONG;
        public string NGAYDONG
        {
            get { return m_NGAYDONG; }
            set { m_NGAYDONG = value; }
        }
        private string m_MUCDONG;
        public string MUCDONG
        {
            get { return m_MUCDONG; }
            set { m_MUCDONG = value; }
        }
        private string m_MASUCKHOE;
        public string MASUCKHOE
        {
            get { return m_MASUCKHOE; }
            set { m_MASUCKHOE = value; }
        }
        private string m_NHANXET_CQ;
        public string NHANXET_CQ
        {
            get { return m_NHANXET_CQ; }
            set { m_NHANXET_CQ = value; }
        }
        private string m_TUNHANXET;
        public string TUNHANXET
        {
            get { return m_TUNHANXET; }
            set { m_TUNHANXET = value; }
        }
        private string m_THONGTINKHAC;
        public string THONGTINKHAC
        {
            get { return m_THONGTINKHAC; }
            set { m_THONGTINKHAC = value; }
        }
        private string m_NGAYLUU;
        public string NGAYLUU
        {
            get { return m_NGAYLUU; }
            set { m_NGAYLUU = value; }
        }
        private string m_LYDOLUU;
        public string LYDOLUU
        {
            get { return m_LYDOLUU; }
            set { m_LYDOLUU = value; }
        }
    }
}
