using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;

namespace BLL
{
   public class DocGiaBLL
    {

        #region khai báo biến
        string maDocGia;
        string hoDocGia;
        string tenlotDocGia;
        string tenDocGia;
        bool gioiTinh;
        DateTime ngaySinh;
        string soNha;
        string duong;
        string quan;
        string soDienThoai;
        DateTime ngayDangKi;
        DateTime ngayHetHanDK;

       
        #endregion


        #region khai báo các thuộc tính

       public string MaDocGia
        {
          get { return maDocGia; }
          set { maDocGia = value; }
        }
 
       public string HoDocGia
        {
          get { return hoDocGia; }
          set { hoDocGia = value; }
        }
       public string TenlotDocGia
        {
          get { return tenlotDocGia; }
          set { tenlotDocGia = value; }
        }
               public string TenDocGia
        {
          get { return tenDocGia; }
          set { tenDocGia = value; }
        }
          public bool GioiTinh
        {
          get { return gioiTinh; }
          set { gioiTinh = value; }
        }
       public DateTime NgaySinh
        {
          get { return ngaySinh; }
          set { ngaySinh = value; }
        }
        public string SoNha
        {
          get { return soNha; }
          set { soNha = value; }
        }
       public string Duong
        {
          get { return duong; }
          set { duong = value; }
        }
       public string Quan
        {
          get { return quan; }
          set { quan = value; }
        }

       public string SoDienThoai
       {
           get { return soDienThoai; }
           set { soDienThoai = value; }
       }

       public DateTime NgayDangKi
       {
           get { return ngayDangKi; }
           set { ngayDangKi = value; }
       }
       public DateTime NgayHetHanDK
       {
           get { return ngayHetHanDK; }
           set { ngayHetHanDK = value; }
       }

      #endregion


        #region hàm khởi tạo


       /// <summary>
       /// hàm khởi tạo với đầy đủ tham số
       /// </summary>
       /// <param name="madocgia">mã đọc giả</param>
       /// <param name="hodocgia">họ đọc giả</param>
       /// <param name="tenlotdocgia">tên lót đọc giả</param>
       /// <param name="tendocgia">tên đọc giả</param>
       /// <param name="gioitinh">giới tính </param>
       /// <param name="ngaysinh">ngày sinh</param>
       /// <param name="sonha">số nhà</param>
       /// <param name="duong">đường</param>
       /// <param name="quan">quận</param>
       /// <param name="sodienthoai">sô điện thoại</param>
       /// <param name="ngaydangki">ngày đăng kí</param>
       /// <param name="ngayhethandk">ngày hết hạn đăng kí</param>
      public DocGiaBLL(string madocgia, string hodocgia, string tenlotdocgia, string tendocgia,bool gioitinh,DateTime ngaysinh,
          string sonha,string duong,string quan,string sodienthoai,DateTime ngaydangki,DateTime ngayhethandk)
        {
            maDocGia = madocgia;
            hoDocGia = hodocgia;
            tenlotDocGia = tenlotdocgia;
            tenDocGia = tendocgia;
            gioiTinh = gioitinh;
            ngaySinh = ngaysinh;
            soNha = sonha;
            this.duong = duong;
            this.quan = quan;
            soDienThoai = sodienthoai;
            ngayDangKi = ngaydangki;
            ngayHetHanDK = ngayhethandk;


        }

       /// <summary>
       /// hàm khởi tạo có 1 tham số_khoa chính
       /// </summary>
       /// <param name="madocgia">mã đọc giả</param>
      public DocGiaBLL(string madocgia)
      {
          maDocGia = madocgia;
      }

      /// <summary>
      /// hàm khởi tạo không có tham số
      
      public DocGiaBLL()
      {
          
      }


        #endregion

        #region  các hàm xử lí


         /// <summary>
         /// gọi hàm thêm của DAL
         /// </summary>
         /// <returns>trả về kết quả số nguyên theo kq</returns>
         public int Them()
         {
             DocGiaDAL objDocGia =new DocGiaDAL();
             int kq = objDocGia.Them(maDocGia,hoDocGia,tenlotDocGia,tenDocGia,gioiTinh,ngaySinh,soNha,duong,quan,soDienThoai,ngayDangKi,ngayHetHanDK);
             return kq;

         }
         /// <summary>
         /// gọi hàm xóa của DAL
         /// </summary>
         /// <returns>trả về kết quả số nguyên theo kq</returns>
         public int Xoa()
         {
             DocGiaDAL objDocGia = new DocGiaDAL();
             int kq = objDocGia.Xoa(maDocGia);
             return kq;

         }

         /// <summary>
         /// gọi hàm cập nhật của DAL
         /// </summary>
         /// <returns>trả về kết quả số nguyên theo kq</returns>

         public int CapNhat()
         {
             DocGiaDAL objDocGia = new DocGiaDAL();
             int kq = objDocGia.CapNhat(maDocGia, hoDocGia, tenlotDocGia, tenDocGia, gioiTinh, ngaySinh, soNha, duong, quan, soDienThoai, ngayDangKi, ngayHetHanDK);
             return kq;

         }

         /// <summary>
         /// hàm truy xuất dữ liệu bảng đọc giả
         /// </summary>
         /// <returns></returns>
         public DataTable truyXuatDuLieuBang_DocGia()
         {
             DocGiaDAL objDocGia = new DocGiaDAL();
             DataTable dtTemp = objDocGia.truyXuatDuLieuBang_DocGia();
             return dtTemp;
         }
      

        #endregion
    }
}
