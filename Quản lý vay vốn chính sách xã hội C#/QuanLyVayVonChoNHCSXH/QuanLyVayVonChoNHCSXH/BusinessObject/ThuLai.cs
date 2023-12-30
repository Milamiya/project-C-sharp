using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class ThuLai
    {
         public ThuLai() { }

       public ThuLai(String sobuttoan)
       {
           m_SoButToan = sobuttoan;
       }
       private String m_SoButToan;

       public String sobuttoan
       {
           get { return m_SoButToan; }
           set { m_SoButToan = value; }
       }

       private DateTime m_NgayTL;

       public DateTime ngaytl
       {
           get { return m_NgayTL; }
           set { m_NgayTL = value; }
       }

       private DateTime m_NgayTinhLai;

       public DateTime ngaytinhlai
       {
           get { return m_NgayTinhLai; }
           set { m_NgayTinhLai = value; }
       }

       private String m_MaSoKU;

       public String masoku
       {
           get { return m_MaSoKU; }
           set { m_MaSoKU = value; }
       }

       private Double m_SoTienLaiTH;

       public Double sotienlaith
       {
           get { return m_SoTienLaiTH; }
           set { m_SoTienLaiTH = value; }
       }

       private Double m_SoTienGoc;

       public Double sotiengoc
       {
           get { return m_SoTienGoc; }
           set { m_SoTienGoc = value; }
       }

       private Double m_SoTienLaiQH;

       public Double sotienlaiqh
       {
           get { return m_SoTienLaiQH; }
           set { m_SoTienLaiQH = value; }
       }

       private String m_MaLoaiChungTu;

       public String maloaichungtu
       {
           get { return m_MaLoaiChungTu; }
           set { m_MaLoaiChungTu = value; }
       }

       private String m_TaiKhoanNo;

       public String taikhoanno
       {
           get { return m_TaiKhoanNo; }
           set { m_TaiKhoanNo = value; }
       }

       private String m_TaiKhoanCo;

       public String taikhoanco
       {
           get { return m_TaiKhoanCo; }
           set { m_TaiKhoanCo = value; }
       }
    }
}
