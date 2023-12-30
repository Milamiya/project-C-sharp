using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;

namespace BLL
{
    public class DauSachBLL
    {
        #region khai báo biến
        string maDauSach;
        string maTuaSach;
        string ngonNgu;
        string maNSX;
        
        #endregion


        #region khai báo các thuộc tính
        public string MaNSX
        {
          get { return maNSX; }
          set { maNSX = value; }
        }

        public string NgonNgu
        {
          get { return ngonNgu; }
          set { ngonNgu = value; }
        }

        public string MaTuaSach
        {
          get { return maTuaSach; }
          set { maTuaSach = value; }
        }

        public string MaDausach
        {
          get { return maDauSach; }
          set { maDauSach = value; }
        }
      #endregion


        #region hàm khởi tạo

        /// <summary>
        /// hàm khởi tạo với đầy đủ tham số
        /// </summary>
        /// <param name="madausach">mã đầu sách</param>
        /// <param name="matuasach">mã tựa sách</param>
        /// <param name="ngonngu">ngôn ngữ</param>
        /// <param name="mansx">mã nhà sản xuất</param>
        public DauSachBLL(string madausach, string matuasach, string ngonngu, string mansx)
        {
            maDauSach = madausach;
            maTuaSach = matuasach;
            ngonNgu = ngonngu;
            maNSX = mansx;
        }

        /// <summary>
        /// hàm khởi tạo với 1 tham số_khóa chính
        /// </summary>
        /// <param name="madausach">mã đầu sách</param>
        
        public DauSachBLL(string madausach)
        {
            maDauSach = madausach;
            
        }

        /// <summary>
        /// hàm khởi tạo không tham số
        /// </summary>
       
        public DauSachBLL()
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
             DauSachDAL objDauSach = new DauSachDAL();
             int kq = objDauSach.Them(maDauSach,maTuaSach,ngonNgu,maNSX);
             return kq;

         }
         /// <summary>
         /// gọi hàm xóa của DAL
         /// </summary>
         /// <returns>trả về kết quả số nguyên theo kq</returns>
         public int Xoa()
         {
             DauSachDAL objDauSach = new DauSachDAL();
             int kq = objDauSach.Xoa(maDauSach);
             return kq;

         }

         /// <summary>
         /// gọi hàm cập nhật của DAL
         /// </summary>
         /// <returns>trả về kết quả số nguyên theo kq</returns>

         public int CapNhat()
         {
             DauSachDAL objDauSach = new DauSachDAL();
             int kq = objDauSach.CapNhat(maDauSach, maTuaSach, ngonNgu, maNSX);
             return kq;
         }

         /// <summary>
         /// hàm truy xuất dữ liệu bảng đầu sách
         /// </summary>
         /// <returns></returns>
         public DataTable truyXuatDuLieuBang_DauSach()
         {
             DauSachDAL objDauSach = new DauSachDAL();
             DataTable dtTemp = objDauSach.truyXuatDuLieuBang_DauSach();
             return dtTemp;
         }
      

        #endregion

    }
}
