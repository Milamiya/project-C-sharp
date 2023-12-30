using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DAL;

namespace BLL
{
    public class CuonSachBLL
    {
        #region khai báo biến
           private string maCuonSach;
           private string tenCuonSach;
           private string maDauSach;
           private string tinhTrang;

           
         
        
        #endregion

        
         
        #region khai báo các thuộc tính
        public string MaCuonSach
        {
            get { return maCuonSach; }
            set { maCuonSach = value; }
        }
       
        public string TenCuonSach
        {
            get { return tenCuonSach; }
            set { tenCuonSach = value; }
        }
        
        public string MaDauSach
        {
            get { return maDauSach; }
            set { maDauSach = value; }
        }
        public string TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }

        

        #endregion


        #region hàm khởi tạo

        /// <summary>
        /// hàm khởi tạo với đầy đủ tham số
        /// </summary>
        /// <param name="macuonsach">mã cuốn sách</param>
        /// <param name="tencuonsach">tên cuốn sách</param>
        /// <param name="madausach">mã đầu sách</param>
        /// <param name="tinhtrang">tình trạng</param>
        public CuonSachBLL(string macuonsach, string tencuonsach, string madausach, string tinhtrang)
        {
            maCuonSach = macuonsach;
            tenCuonSach = tencuonsach;
            maDauSach = madausach;
            tinhTrang = tinhtrang;
        }


        /// <summary>
        /// hàm khởi tạo với 1 tham số_khóa chính
        /// </summary>
        /// <param name="macuonsach">mã cuốn sách</param>
         public CuonSachBLL(string macuonsach)
        {
            maCuonSach = macuonsach;
            
         }

         /// <summary>
         /// hàm khởi tạo không có tham số
         /// </summary>
         public CuonSachBLL()
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
             CuonSachDAL objCuonSach = new CuonSachDAL();
             int kq =objCuonSach.Them(maCuonSach,tenCuonSach,maDauSach,tinhTrang);
             return kq;

         }
         /// <summary>
         /// gọi hàm xóa của DAL
         /// </summary>
         /// <returns>trả về kết quả số nguyên theo kq</returns>
         public int Xoa()
         {
             CuonSachDAL objCuonSach = new CuonSachDAL();
             int kq = objCuonSach.Xoa(maCuonSach);
             return kq;

         }

         /// <summary>
         /// gọi hàm cập nhật của DAL
         /// </summary>
         /// <returns>trả về kết quả số nguyên theo kq</returns>

         public int CapNhat()
         {
             CuonSachDAL objCuonSach = new CuonSachDAL();
             int kq = objCuonSach.CapNhat(maCuonSach, tenCuonSach, MaDauSach, tinhTrang);
             return kq;
         }

         /// <summary>
         /// hàm truy xuất dữ liệu bảng cuốn sách
         /// </summary>
         /// <returns></returns>
         public DataTable truyXuatDuLieuBang_CuonSach()
         {
             CuonSachDAL objCuonSach = new CuonSachDAL();
             DataTable dtTemp = objCuonSach.truyXuatDuLieuBang_CuonSach();
             return dtTemp;
         }


         public DataTable truyXuatDuLieuBang_CuonSach1()
         {
             CuonSachDAL objCuonSach = new CuonSachDAL();
             DataTable dtTemp = objCuonSach.truyXuatDuLieuBang_CuonSach1();
             return dtTemp;
         }

        #endregion

    }
}
