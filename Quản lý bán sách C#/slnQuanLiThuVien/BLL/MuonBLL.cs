using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL;

namespace BLL
{
    public class MuonBLL
    {
        
        #region khai báo biến
        string maMuon;
        string maDocGia;
        string maCuonSach;
        int soLuong;
        DateTime ngayMuon;
        DateTime ngayHenTra;
        DateTime ngayTra;
        string ghiChu;
       
        #endregion


        #region khai báo các thuộc tính

        public string MaMuon
        {
          get { return maMuon; }
          set { maMuon = value; }
        }
       public string MaDocGia
        {
          get { return maDocGia; }
          set { maDocGia = value; }
        }
 
      public string GhiChu
        {
          get { return ghiChu; }
          set { ghiChu = value; }
        }
        public DateTime NgayTra
        {
          get { return ngayTra; }
          set { ngayTra = value; }
        }
        public DateTime NgayHenTra
        {
          get { return ngayHenTra; }
          set { ngayHenTra = value; }
        }
      
        public DateTime NgayMuon
        {
          get { return ngayMuon; }
          set { ngayMuon = value; }
        }

        public int SoLuong
        {
          get { return soLuong; }
          set { soLuong = value; }
        }
  
        public string MaCuonSach
        {
          get { return maCuonSach; }
          set { maCuonSach = value; }
        }
      #endregion


        #region hàm khởi tạo


       /// <summary>
       /// hàm khởi tạo với đầy đủ tham số
       /// </summary>
       /// <param name="mamuon">mã mượn</param>
       /// <param name="madocgia">mã đọc giả</param>
       /// <param name="macuonsach">mã cuốn sách</param>
       /// <param name="soluong">số lượng</param>
       /// <param name="ngaymuon">ngày mượn</param>
       /// <param name="ngayhentra">ngày hẹn trả</param>
       /// <param name="ngaytra">ngày trả</param>
       /// <param name="ghichu">ghi chú</param>
      public MuonBLL(string mamuon, string madocgia, string macuonsach, int soluong,DateTime ngaymuon,DateTime ngayhentra,DateTime ngaytra,string ghichu)
        {
            maMuon=mamuon;
            maDocGia = madocgia;
            maCuonSach=macuonsach;
            soLuong=soluong;
            ngayMuon=ngaymuon;
            ngayHenTra=ngayhentra;
            ngayTra=ngaytra;
            ghiChu=ghichu;

        }

      public MuonBLL(string mamuon, string madocgia, string macuonsach, int soluong, DateTime ngaymuon, DateTime ngayhentra, string ghichu)
      {
          maMuon = mamuon;
          maDocGia = madocgia;
          maCuonSach = macuonsach;
          soLuong = soluong;
          ngayMuon = ngaymuon;
          ngayHenTra = ngayhentra;
           ghiChu = ghichu;

      }

      /// <summary>
   

       /// <summary>
       /// hàm khởi tạo có 1 tham số_khoa chính
       /// </summary>
       /// <param name="mamuon">mã mượn</param>
      public MuonBLL(string mamuon)
      {
          maMuon = mamuon;
      }

      /// <summary>
      /// hàm khởi tạo không có tham số

      public MuonBLL()
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
             MuonDAL objMuon = new MuonDAL();
             int kq = objMuon.Them(maMuon, maDocGia, maCuonSach, soLuong, ngayMuon, ngayHenTra, ngayTra, ghiChu);
             return kq;

         }
         
         /// <summary>
         /// gọi hàm xóa của DAL
         /// </summary>
         /// <returns>trả về kết quả số nguyên theo kq</returns>
         public int Xoa()
         {
             MuonDAL objMuon = new MuonDAL();
             int kq = objMuon.Xoa(maMuon);
             return kq;

         }

         /// <summary>
         /// gọi hàm cập nhật của DAL
         /// </summary>
         /// <returns>trả về kết quả số nguyên theo kq</returns>

         public int CapNhat()
         {
             MuonDAL objMuon = new MuonDAL();
             int kq = objMuon.CapNhat(maMuon, maDocGia, maCuonSach, soLuong, ngayMuon, ngayHenTra, ngayTra, ghiChu);
             return kq;

         }

         /// <summary>
         /// hàm truy xuất dữ liệu bảng mượn
         /// </summary>
         /// <returns></returns>
         public DataTable truyXuatDuLieuBang_Muon()
         {
             MuonDAL objMuon = new MuonDAL();
             DataTable dtTemp = objMuon.truyXuatDuLieuBang_Muon();
             return dtTemp;
         }
      

        #endregion
    }
}
