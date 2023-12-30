using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;

namespace BLL
{
    public class TuaSachBLL
    {
        #region khai báo biến

        string maTuaSach;
        string tenTuaSach;
        string maTacGia;
        string maTheLoai;
        string noiDungTomTat;
        
        #endregion


        #region khai báo các thuộc tính

       public string NoiDungTomTat
        {
          get { return noiDungTomTat; }
          set { noiDungTomTat = value; }
        }
      
       public string MaTheLoai1
        {
          get { return maTheLoai; }
          set { maTheLoai = value; }
        }

        public string MaTacGia
        {
          get { return maTacGia; }
          set { maTacGia = value; }
        }
        
        
        public string TenTuaSach
        {
          get { return tenTuaSach; }
          set { tenTuaSach = value; }
        }

        public string MaTuaSach
        {
          get { return maTuaSach; }
          set { maTuaSach = value; }
        }
    
      #endregion


        #region hàm khởi tạo


  
       /// <summary>
       /// hàm khởi tạo có đầy đủ tham số
       /// </summary>
       /// <param name="matuasach">mã tựa sách</param>
       /// <param name="tentuasach">tên tụa sách</param>
       /// <param name="matacgia">mã tác giả</param>
       /// <param name="matheloai">mã thể laoi5</param>
       /// <param name="noidungtomtat">nội dug tóm tắt</param>
      public TuaSachBLL(string matuasach,string tentuasach,string matacgia,string matheloai,string noidungtomtat)
        {
            maTuaSach=matuasach;
            tenTuaSach=tentuasach;
            maTacGia=matacgia;
            maTheLoai=matheloai;
            noiDungTomTat=noidungtomtat;
            

           
        }

       /// <summary>
       /// hàm khởi tạo có 1 tham số_khoa chính
       /// </summary>
       /// <param name="matuasach">mã tựa sách</param>
      public TuaSachBLL(string matuasach)
      {
        maTuaSach=matuasach;
      }

      /// <summary>
      /// hàm khởi tạo không có tham số

      public TuaSachBLL()
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
             TuaSachDAL objTuaSach = new TuaSachDAL();
             int kq = objTuaSach.Them(maTuaSach,tenTuaSach,maTheLoai,maTacGia,noiDungTomTat);
             return kq;

         }
         /// <summary>
         /// gọi hàm xóa của DAL
         /// </summary>
         /// <returns>trả về kết quả số nguyên theo kq</returns>
         public int Xoa()
         {
             TuaSachDAL objTuaSach = new TuaSachDAL();
             int kq = objTuaSach.Xoa(maTuaSach);
             return kq;

         }

         /// <summary>
         /// gọi hàm cập nhật của DAL
         /// </summary>
         /// <returns>trả về kết quả số nguyên theo kq</returns>

         public int CapNhat()
         {
             TuaSachDAL objTuaSach = new TuaSachDAL();
             int kq = objTuaSach.CapNhat(maTuaSach, tenTuaSach, maTheLoai, maTacGia, noiDungTomTat);
             return kq;

         }

         /// <summary>
         /// hàm truy xuất dữ liệu bảng tựa sách
         /// </summary>
         /// <returns></returns>
         public DataTable truyXuatDuLieuBang_TuaSach()
         {
             TuaSachDAL objTuaSach = new TuaSachDAL();
             DataTable dtTemp = objTuaSach.truyXuatDuLieuBang_TuaSach();
             return dtTemp;
         }
      

        #endregion
    }
}
