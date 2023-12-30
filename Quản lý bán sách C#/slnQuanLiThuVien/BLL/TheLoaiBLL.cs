using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;

namespace BLL
{
    public class TheLoaiBLL
    {
         #region khai báo biến
        string maTheLoai;
        string tenTheLoai;

        #endregion


        #region khai báo các thuộc tính

       public string MaTheLoai
        {
          get { return maTheLoai; }
          set { maTheLoai = value; }
        }
        public string TenTheLoai
        {
          get { return tenTheLoai; }
          set { tenTheLoai = value; }
        }
    
      #endregion


        #region hàm khởi tạo


  
       /// <summary>
       /// hàm khởi tạo có đầy đủ tham số
       /// </summary>
       /// <param name="matheloai">mã thể loại</param>
       /// <param name="tentheloai">tên thể loại</param>
      public TheLoaiBLL(string matheloai, string tentheloai)
        {
            maTheLoai=matheloai;
            tenTheLoai=tentheloai;
           
        }

       /// <summary>
       /// hàm khởi tạo có 1 tham số_khoa chính
       /// </summary>
       /// <param name="matheloai">mã thể loại</param>
      public TheLoaiBLL(string matheloai)
      {
        maTheLoai=matheloai;
      }

      /// <summary>
      /// hàm khởi tạo không có tham số

      public TheLoaiBLL()
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
             TheLoaiDAL objTheLoai = new TheLoaiDAL();
             int kq = objTheLoai.Them(maTheLoai,tenTheLoai);
             return kq;

         }
         /// <summary>
         /// gọi hàm xóa của DAL
         /// </summary>
         /// <returns>trả về kết quả số nguyên theo kq</returns>
         public int Xoa()
         {
             TheLoaiDAL objTheLoai = new TheLoaiDAL();
             int kq = objTheLoai.Xoa(maTheLoai);
             return kq;

         }

         /// <summary>
         /// gọi hàm cập nhật của DAL
         /// </summary>
         /// <returns>trả về kết quả số nguyên theo kq</returns>

         public int CapNhat()
         {
             TheLoaiDAL objTheLoai = new TheLoaiDAL();
             int kq = objTheLoai.CapNhat(maTheLoai, tenTheLoai);
             return kq;

         }

         /// <summary>
         /// hàm truy xuất dữ liệu bảng thể loại
         /// </summary>
         /// <returns></returns>
         public DataTable truyXuatDuLieuBang_TheLoai()
         {
             TheLoaiDAL objTheLoai = new TheLoaiDAL();
             DataTable dtTemp = objTheLoai.truyXuatDuLieuBang_TheLoai();
             return dtTemp;
         }
      

        #endregion
    }
}
