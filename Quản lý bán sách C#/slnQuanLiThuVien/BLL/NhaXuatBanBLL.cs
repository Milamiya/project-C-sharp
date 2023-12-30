using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;


namespace BLL
{
    public class NhaXuatBanBLL
    {
        
        
        #region khai báo biến
        string maNSX;
        string tenNSX;


        #endregion


        #region khai báo các thuộc tính

        public string TenNSX
        {
          get { return tenNSX; }
          set { tenNSX = value; }
        }
      
       public string MaNSX
        {
          get { return maNSX; }
          set { maNSX = value; }
        }
    
      #endregion


        #region hàm khởi tạo


       /// <summary>
       /// hàm khởi tạo với đầy đủ tham số
       /// </summary>
       /// <param name="mansx">mã nhà sản xuất</param>
       /// <param name="tennsx">tên nhà sản xuất</param>
      public NhaXuatBanBLL(string mansx, string tennsx)
        {
          maNSX=mansx;
          tenNSX=tennsx;
           
        }

       /// <summary>
       /// hàm khởi tạo có 1 tham số_khoa chính
       /// </summary>
      /// <param name="mansx">mã nhà sản xuất</param>
      public NhaXuatBanBLL(string mansx)
      {
         maNSX=mansx;
      }

      /// <summary>
      /// hàm khởi tạo không có tham số

      public NhaXuatBanBLL()
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
             NhaXuatBanDAL objNhaSanXuat = new NhaXuatBanDAL();
             int kq = objNhaSanXuat.Them(maNSX,tenNSX);
             return kq;

         }
         /// <summary>
         /// gọi hàm xóa của DAL
         /// </summary>
         /// <returns>trả về kết quả số nguyên theo kq</returns>
         public int Xoa()
         {
             NhaXuatBanDAL objNhaSanXuat = new NhaXuatBanDAL();
             int kq = objNhaSanXuat.Xoa(maNSX);
             return kq;

         }

         /// <summary>
         /// gọi hàm cập nhật của DAL
         /// </summary>
         /// <returns>trả về kết quả số nguyên theo kq</returns>

         public int CapNhat()
         {
             NhaXuatBanDAL objNhaSanXuat = new NhaXuatBanDAL();
             int kq = objNhaSanXuat.CapNhat(maNSX, tenNSX);
             return kq;

         }

         /// <summary>
         /// hàm truy xuất dữ liệu bảng nhà xuất bản
         /// </summary>
         /// <returns></returns>
         public DataTable truyXuatDuLieuBang_NhaXuatBan()
         {
             NhaXuatBanDAL objNhaSanXuat = new NhaXuatBanDAL();
             DataTable dtTemp = objNhaSanXuat.truyXuatDuLieuBang_NhaXuatBan();
             return dtTemp;
         }
      

        #endregion
    }
}
