using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class ThuVon
    {
       public ThuVon() { }

       public ThuVon(String sobuttoan)
       {
           m_SoButToan = sobuttoan;
       }
       private String m_SoButToan;

       public String sobuttoan
       {
           get { return m_SoButToan; }
           set { m_SoButToan = value; }
       }

       private DateTime m_NgayTV;

       public DateTime ngaytv
       {
           get { return m_NgayTV; }
           set { m_NgayTV = value; }
       }

       private String m_MaSoKU;

       public String masoku
       {
           get { return m_MaSoKU; }
           set { m_MaSoKU = value; }
       }

       private Double m_SoTienThu;

       public Double sotienthu
       {
           get { return m_SoTienThu; }
           set { m_SoTienThu = value; }
       }

       private Double m_SoTienGoc;

       public Double sotiengoc
       {
           get { return m_SoTienGoc; }
           set { m_SoTienGoc = value; }
       }

       private Double m_SoTienConLai;

       public Double sotienconlai
       {
           get { return m_SoTienConLai; }
           set { m_SoTienConLai = value; }
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
