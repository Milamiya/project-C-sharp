using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;

namespace BLL
{
    public class TacGiaBLL
    {
         #region khai báo biến
        string maTacGia;
        string tenTacGia;

        #endregion


        #region khai báo các thuộc tính

        public string MaTacGia
        {
          get { return maTacGia; }
          set { maTacGia = value; }
        }
        public string TenTacGia
        {
          get { return tenTacGia; }
          set { tenTacGia = value; }
        }

    
      #endregion


        #region hàm khởi tạo


  
        /// <summary>
        /// hàm khởi tạo có đầy đủ tham số
        /// </summary>
        /// <param name="matacgia">mã tác giả</param>
        /// <param name="tentacgia">tên tac giả</param>
      public TacGiaBLL(string matacgia, string tentacgia)
        {
            maTacGia=matacgia;
            tenTacGia=tentacgia;
           
        }

       /// <summary>
       /// hàm khởi tạo có 1 tham số_khoa chính
       /// </summary>
      //// <param name="matacgia">mã tác giả</param>
      public TacGiaBLL(string matacgia)
      {
         maTacGia=matacgia;
      }

      /// <summary>
      /// hàm khởi tạo không có tham số

      public TacGiaBLL()
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
             TacGiaDAL objTacGia=new TacGiaDAL();
             int kq = objTacGia.Them(maTacGia,tenTacGia);
             return kq;

         }
         /// <summary>
         /// gọi hàm xóa của DAL
         /// </summary>
         /// <returns>trả về kết quả số nguyên theo kq</returns>
         public int Xoa()
         {
             TacGiaDAL objTacGia = new TacGiaDAL();
             int kq = objTacGia.Xoa(maTacGia);
             return kq;

         }

         /// <summary>
         /// gọi hàm cập nhật của DAL
         /// </summary>
         /// <returns>trả về kết quả số nguyên theo kq</returns>

         public int CapNhat()
         {
             TacGiaDAL objTacGia = new TacGiaDAL();
             int kq = objTacGia.CapNhat(maTacGia, tenTacGia);
             return kq;

         }

         /// <summary>
         /// hàm truy xuất dữ liệu bảng tác giả
         /// </summary>
         /// <returns></returns>
         public DataTable truyXuatDuLieuBang_TacGia()
         {
             TacGiaDAL objTacGia = new TacGiaDAL();
             DataTable dtTemp = objTacGia.truyXuatDuLieuBang_TacGia();
             return dtTemp;
         }
      

        #endregion
    }
}
