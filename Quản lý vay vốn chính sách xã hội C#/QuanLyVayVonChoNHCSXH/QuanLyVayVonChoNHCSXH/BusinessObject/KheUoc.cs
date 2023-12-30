using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class KheUoc
    {
       public KheUoc() { }

       public KheUoc(String masoku)
       {
           m_MaSoKU = masoku;
       }
       
       private String m_MaSoKU;

       public String MASOKU
       {
           get { return m_MaSoKU; }
           set { m_MaSoKU = value; }
       }

       private String m_MaDoiTac;
       public String MADOITAC
       {
           get { return m_MaDoiTac; }
           set { m_MaDoiTac = value; }
       }

       private String m_MaLoaiVay;
       public String MALOAIVAY
       {
           get { return m_MaLoaiVay; }
           set { m_MaLoaiVay = value; }
       }

       private String m_MaKVNV;
       public String MAKVNV
       {
           get { return m_MaKVNV; }
           set { m_MaKVNV = value; }
       }

       private String m_MaKieuTra;
       public String MAKIEUTRA
       {
           get { return m_MaKieuTra; }
           set { m_MaKieuTra = value; }
       }

       private String m_TenToTruong;
       public String TENTOTRUONG
       {
           get { return m_TenToTruong; }
           set { m_TenToTruong = value; }
       }

       private String m_MaChuongTrinh;
       public String MACHUONGTRINH
       {
           get { return m_MaChuongTrinh; }
           set { m_MaChuongTrinh = value; }
       }

       private long m_NhuCau;
       public long NHUCAU
       {
           get { return m_NhuCau; }
           set { m_NhuCau = value; }
       }

       private DateTime m_NgayDuyet;
       public DateTime NGAYDUYET
       {
           get { return m_NgayDuyet; }
           set { m_NgayDuyet = value; }
       }

       private long m_MucDuyet;
       public long MUCDUYET
       {
           get { return m_MucDuyet; }
           set { m_MucDuyet = value; }
       }

       private DateTime m_NgayVay;
       public DateTime NGAYVAY
       {
           get { return m_NgayVay; }
           set { m_NgayVay = value; }
       }

       private DateTime m_NgayTra;
       public DateTime NGAYTRA
       {
           get { return m_NgayTra; }
           set { m_NgayTra = value; }
       }

       private String m_MaLaiSuat;
       public String MALAISUAT
       {
           get { return m_MaLaiSuat; }
           set { m_MaLaiSuat = value; }
       }

       private String m_TKChoVay;
       public String TKCHOVAY
       {
           get { return m_TKChoVay; }
           set { m_TKChoVay = value; }
       }

       private String m_ThuLai;
       public String THULAI
       {
           get { return m_ThuLai; }
           set { m_ThuLai = value; }
       }

       private String m_TKNoQuaHan;
       public String TKNOQUAHAN
       {
           get { return m_TKNoQuaHan; }
           set { m_TKNoQuaHan = value; }
       }

       private String m_MaMucDichVay;
       public String MAMUCDICHVAY
       {
           get { return m_MaMucDichVay; }
           set { m_MaMucDichVay = value; }
       }

       private String m_MaHTDamBao;
       public String MAHTDAMBAO
       {
           get { return m_MaHTDamBao; }
           set { m_MaHTDamBao = value; }
       }

       private String m_MaNV;
       public String MANV
       {
           get { return m_MaNV; }
           set { m_MaNV = value; }
       }

       private String m_MaThoiHanVay;
       public String MATHOIHANVAY
       {
           get { return m_MaThoiHanVay; }
           set { m_MaThoiHanVay = value; }
       }

       private String m_MaHTVAy;
       public String MAHTVAY
       {
           get { return m_MaHTVAy; }
           set { m_MaHTVAy = value; }
       }

       private String m_MaDonViUyThac;
       public String MADONVIUYTHAC
       {
           get { return m_MaDonViUyThac; }
           set { m_MaDonViUyThac = value; }
       }

       private String m_MaVung;
       public String MAVUNG
       {
           get { return m_MaVung; }
           set { m_MaVung = value; }
       }

       private int m_TraNoDinhKy;
       public int TRANODINHKY
       {
           get { return m_TraNoDinhKy; }
           set { m_TraNoDinhKy = value; }
       }

       private String m_HoTenThuaKe;
       public String HOTENTHUAKE
       {
           get { return m_HoTenThuaKe; }
           set { m_HoTenThuaKe = value; }
       }


       

    }
}
