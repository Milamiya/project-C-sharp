using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
     public class GiaiNgan
    {
         public GiaiNgan() { }
         private String m_SoButToan;

         public String SOBUTOAN
         {
             get { return m_SoButToan; }
             set { m_SoButToan = value; }
         }


         private DateTime m_NgayGiaiNgan;

         public DateTime NGAYGIAINGAN
         {
             get { return m_NgayGiaiNgan; }
             set { m_NgayGiaiNgan = value; }
         }

         private String m_MaSoKU;

         public String MASOKU
         {
             get { return m_MaSoKU; }
             set { m_MaSoKU = value; }
         }

         private String m_SoTaiKhoan;

         public String SOTAIKHOAN
         {
             get { return m_SoTaiKhoan; }
             set { m_SoTaiKhoan = value; }
         }

         private Double m_SoTienGiaiNgan;

         public Double SOTIENGIAINGAN
         {
             get { return m_SoTienGiaiNgan; }
             set { m_SoTienGiaiNgan = value; }
         }

         private Double m_DuocPhep;

         public Double DUOCPHEP
         {
             get { return m_DuocPhep; }
             set { m_DuocPhep = value; }
         }
         private Double m_ConLai;

         public Double CONLAI
         {
             get { return m_ConLai; }
             set { m_ConLai = value; }
         }

         private String m_MaLoaiChungTu;

         public String MALOAICHUNGTU
         {
             get { return m_MaLoaiChungTu; }
             set { m_MaLoaiChungTu = value; }
         }
         private String m_TaiKhoanNo;

         public String TAIKHOANO
         {
             get { return m_TaiKhoanNo; }
             set { m_TaiKhoanNo = value; }
         }

         private String m_TaiKhoanCo;

         public String TAIKHOANCO
         {
             get { return m_TaiKhoanCo; }
             set { m_TaiKhoanCo = value; }
         }
	

	
	
	
	
	


    }
}
