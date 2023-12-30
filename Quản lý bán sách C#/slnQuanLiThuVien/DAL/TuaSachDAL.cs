using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace DAL
{
    public class TuaSachDAL
    {
           #region khai báo biến cục bộ
            private OleDbConnection cnn;
            private DAconnect objDAconnect = new DAconnect();
        #endregion

         #region hàm khởi tạo
            public TuaSachDAL()
            { }
        
        #endregion

        #region các hàm  xử lí trong câu lệnh SQL

        /// <summary>
        /// Truy xuất dữ liệu bảng TUASACH
        /// </summary>
            /// <returns>Datatable cua TUASACH</returns>
            public DataTable truyXuatDuLieuBang_TuaSach()
            {
                string strTableName = "TUASACH";
                DataTable dtTemp = objDAconnect.HienThiThongTin(strTableName);
                return dtTemp;
            }

            
           /// <summary>
           /// thêm thông tin vào bảng TUASACH
           /// </summary>
           /// <param name="maTuaSach">mã tụa sách</param>
           /// <param name="tenTuaSach">tên tựa sách</param>
           /// <param name="maTheLoai">mã thể loại</param>
           /// <param name="maTacGia">mã tác giả</param>
           /// <param name="nDTomTat">nội dung tóm tắt</param>
            /// <returns>0:không có lỗi; 1:có lỗi; 2:  có mã tựa sách trong bảng TUASACH;3: không có mã thể loại(hoặc mã tác giả) trong bảng THELOAi(TACGIA)</returns>
            public int Them(string maTuaSach, string tenTuaSach, string maTheLoai,string maTacGia,string nDTomTat)
            {
                if (KiemTraMaTuaSach_BangTuaSach(maTuaSach) == false)
                {
                    if ((KiemTraMaLoaiSach_BangTheLoai(maTheLoai) == true ) )
                    {
                        if ((KiemTraMaTacGia_BangTacGia(maTacGia) == true))
                        {
                            //câu lệnh sql
                            string strSQL = "insert into TUASACH (MaTuaSach,TenTuaSach,MaTheLoai,MaTacGia,NDTomTat) values('" + maTuaSach + "','" + tenTuaSach + "','" + maTheLoai + "','" + maTacGia + "','" + nDTomTat + "')";
                            return objDAconnect.ExecuteQuery(strSQL);
                        }
                        else
                            return 4;
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
            /// cập nhật thông tin bảng TUASACH
            /// <param name="maTuaSach">mã tụa sách</param>
            /// <param name="tenTuaSach">tên tựa sách</param>
            /// <param name="maTheLoai">mã thể loại</param>
            /// <param name="maTacGia">mã tác giả</param>
            /// <param name="nDTomTat">nội dung tóm tắt</param>
            /// <returns>0:không có lỗi; 1:có lỗi; 2: không có mã tựa sách trong bảng TUASACH;3: không có mã thể loại(hoặc mã tác giả) trong bảng THELOAi(TACGIA)</returns>
            public int CapNhat(string maTuaSach, string tenTuaSach, string maTheLoai, string maTacGia, string nDTomTat)
            {

                if (KiemTraMaTuaSach_BangTuaSach(maTuaSach) == true)
                {
                    if ((KiemTraMaLoaiSach_BangTheLoai(maTheLoai) == true) )
                    {
                        if ((KiemTraMaTacGia_BangTacGia(maTacGia) == true))
                        {

                            string strSQL = "update TUASACH set TenTuaSach='" + tenTuaSach + "',MaTheLoai='" + maTheLoai + "',MaTacGia='" + maTacGia + "',NDTomTat='" + nDTomTat + "' where MaTuaSach='" + maTuaSach + "'";
                            return objDAconnect.ExecuteQuery(strSQL);
                        }
                        else
                            return 4;

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
           /// xóa thông tin bảng TUASACH
           /// </summary>
            /// <param name="maTuaSach">mã tựa sách</param>
            /// <returns>0:không có lỗi; 1:có lỗi; 2: không có mã tựa sách trong bảng TUASACH</returns>
            public int Xoa(string maTuaSach)
            {
                if (KiemTraMaTuaSach_BangTuaSach(maTuaSach) == true)
                {
                    //câu lệnh sql
                    string strSQL = "delete from TUASACH where MaTuaSach='" + maTuaSach + "'";
                    return objDAconnect.ExecuteQuery(strSQL);
                }
                else
                    return 2;
            }
            
            /// <summary>
            /// kiểm tra mã tựa sách có trong bảng TUASACH hay ko?
            /// </summary>
            /// <param name="maTuaSach">mã tựa sách</param>
            /// <returns>nếu có trả về true,ko trả về false</returns>
            public bool KiemTraMaTuaSach_BangTuaSach(string maTuaSach)
            {
                //câu lệnh sql
                string strSQL = "select count (*) from TUASACH where MaTuaSach='" + maTuaSach + "'";
                objDAconnect.KetNoi();
                OleDbCommand command = new OleDbCommand(strSQL, objDAconnect.connect);
                int sodong = (int)command.ExecuteScalar();
                if (sodong > 0)
                    return true;
                else
                    return false;
            }

            /// <summary>
            /// kiểm tra mã loại sách có trong bảng THELOAI hay ko?
            /// </summary>
            /// <param name="maLoaiSach">mã loại sách</param>
            /// <returns>nếu có trả về true,ko trả về false</returns>
            public bool KiemTraMaLoaiSach_BangTheLoai(string maLoaiSach)
            {
                //câu lệnh sql
                string strSQL = "select count (*) from THELOAI where MaLoaiSach='" + maLoaiSach + "'";
                objDAconnect.KetNoi();
                OleDbCommand command = new OleDbCommand(strSQL, objDAconnect.connect);
                int sodong = (int)command.ExecuteScalar();
                if (sodong > 0)
                    return true;
                else
                    return false;
            }


            /// <summary>
            /// kiểm tra mã tác giả có trong bảng TACGIA hay ko?
            /// </summary>
            /// <param name="maTacGia">mã tác giả</param>
           /// <returns>nếu có trả về true,ko trả về false</returns>
        public bool KiemTraMaTacGia_BangTacGia(string maTacGia)
            {
                //câu lệnh sql
                string strSQL = "select count (*) from TACGIA where MaTacGia='" + maTacGia + "'";
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
