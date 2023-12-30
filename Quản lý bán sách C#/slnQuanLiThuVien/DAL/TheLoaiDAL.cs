using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;



namespace DAL
{
    public class TheLoaiDAL
    {
        
           #region khai báo biến cục bộ
            private OleDbConnection cnn;
            private DAconnect objDAconnect = new DAconnect();
        #endregion

         #region hàm khởi tạo
            public TheLoaiDAL()
            { }
        
        #endregion

        #region các hàm  xử lí trong câu lệnh SQL

        /// <summary>
        /// Truy xuất dữ liệu bảng THELOAI
        /// </summary>
            /// <returns>Datatable cua THELOAI</returns>
            public DataTable truyXuatDuLieuBang_TheLoai()
            {
                string strTableName = "THELOAI";
                DataTable dtTemp = objDAconnect.HienThiThongTin(strTableName);
                return dtTemp;
            }

            
          /// <summary>
          /// thêm thông tin vào bảng THELOAI
          /// </summary>
          /// <param name="maTheLoai">mã thể loại</param>
          /// <param name="tenTheLoai">tên thể loại</param>
            /// <returns>0:không có lỗi; 1:có lỗi; 2:  có mã thể loại trong bảng THELOAI;</returns>
            public int Them(string maTheLoai, string tenTheLoai)
            {
                if (KiemTraMaLoaiSach_BangTheLoai(maTheLoai) == false)
                {
                    
                    //câu lệnh sql
                    string strSQL = "insert into THELOAI (MaLoaiSach,TenLoaiSach) values('" + maTheLoai + "','" + tenTheLoai + "')";
                         return objDAconnect.ExecuteQuery(strSQL);
                    
               }
            else
                return 2;
            }


            /// <summary>
            /// cập nhật thông tin của bảng THELOAI
            /// </summary>
            /// <param name="maTheLoai">mã thể loại</param>
            /// <param name="tenTheLoai">tên thể loại</param>
            /// <returns>0:không có lỗi; 1:có lỗi; 2: không có mã thể loại trong bảng THELOAI;3:  có mã thể loại trong bảng TUASACH</returns>
            public int CapNhat(string maTheLoai, string tenTheLoai)
            {

                if (KiemTraMaLoaiSach_BangTheLoai(maTheLoai) == true)
                {
                    if (KiemTraMaLoaiSach_BangTuaSach(maTheLoai) == false)
                    {

                        string strSQL = "update THELOAI set TenLoaiSach='" + tenTheLoai + "' where MaLoaiSach='" + maTheLoai + "'";
                        return objDAconnect.ExecuteQuery(strSQL);

                    }
                    else
                    {
                        return 3;
                    }

                }
                else
                    return 2;

            }

           /// <summary>
           /// xóa thông tin bảng THELOAI
           /// </summary>
            /// <param name="maTheLoai">mã thể loại</param>
            /// <returns>0:không có lỗi; 1:có lỗi; 2: không có mã thể loại trong bảng THELOAI;3:mã thể loại trong bảng TUASACH</returns>
            public int Xoa(string maTheLoai)
            {
                if (KiemTraMaLoaiSach_BangTheLoai(maTheLoai) == true)
                {
                    if (KiemTraMaLoaiSach_BangTuaSach(maTheLoai) == false)
                    {
                        //câu lệnh sql
                        string strSQL = "delete from THELOAI where MaLoaiSach='" + maTheLoai + "'";
                        return objDAconnect.ExecuteQuery(strSQL);
                    }
                    else
                        return 3;
                }
                else
                    return 2;
            }
            
            
            /// <summary>
            /// kiểm tra mã loại sách có trong bảng THELOAI hay ko?
            /// </summary>
            /// <param name="maTheLoai">mã thể loại</param>
            /// <returns>nếu có trả về true,ko trả về false</returns>
            public bool KiemTraMaLoaiSach_BangTheLoai(string maTheLoai)
            {
                //câu lệnh sql
                string strSQL = "select count (*) from THELOAI where MaLoaiSach='" + maTheLoai + "'";
                objDAconnect.KetNoi();
                OleDbCommand command = new OleDbCommand(strSQL, objDAconnect.connect);
                int sodong = (int)command.ExecuteScalar();
                if (sodong > 0)
                    return true;
                else
                    return false;
            }
            
            
            /// <summary>
            /// kiểm tra mã loại sách có trong bảng TUASACH hay ko?
            /// </summary>
            /// <param name="maTheLoai">mã thể loại</param>
            /// <returns>nếu có trả về true,ko trả về false</returns>
            public bool KiemTraMaLoaiSach_BangTuaSach(string maTheLoai)
            {
                //câu lệnh sql
                string strSQL = "select count (*) from TUASACH where MaTheLoai='" + maTheLoai + "'";
                objDAconnect.KetNoi();
                OleDbCommand command = new OleDbCommand(strSQL, objDAconnect.connect);
                int sodong = (int)command.ExecuteScalar();
                if (sodong > 0)
                    return true;
                else
                    return false;
            }

          
        #endregion
    }
}
