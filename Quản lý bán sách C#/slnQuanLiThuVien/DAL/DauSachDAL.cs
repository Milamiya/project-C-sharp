using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace DAL
{
    public class DauSachDAL
    {
         #region khai báo biến cục bộ
            private OleDbConnection cnn;
            private DAconnect objDAconnect = new DAconnect();
        #endregion

         #region hàm khởi tạo
            public DauSachDAL()
            { }
        
        #endregion

        #region các hàm  xử lí trong câu lệnh SQL

        /// <summary>
        /// Truy xuất dữ liệu bảng DAUSACH
        /// </summary>
            /// <returns>Datatable cua DAUSACH</returns>
            public DataTable truyXuatDuLieuBang_DauSach()
            {
                string strTableName = "DAUSACH";
                DataTable dtTemp = objDAconnect.HienThiThongTin(strTableName);
                return dtTemp;
            }

            
            /// <summary>
            /// thêm vào bảng DAUSACH
            /// </summary>
            /// <param name="maDauSach">mã đầu sách</param>
            /// <param name="maTuaSach">mã tựa sách</param>
            /// <param name="ngonNgu">ngôn ngữ</param>
            /// <param name="maNXB">mã NXB</param>
            /// <returns>0:không có lỗi; 1:có lỗi; 2:  có mã đầu sách trong bảng DAUSACH;3: không có mã tựa sách(mã NSX) trong bảng TUASACH(NHAXUATBAN)</returns>
            public int Them(string maDauSach, string maTuaSach,string ngonNgu,string maNSX)
            {
                if (KiemTraMaDauSach_BangDauSach(maDauSach) == false)
                {
                    if ((KiemTraMaTuaSach_BangTuaSach(maTuaSach) == true)&&(KiemTraMaNhaNSX_BangNXB(maNSX)==true))
                    {
                       //câu lệnh sql
                        string strSQL = "insert into DAUSACH (MaDauSach,MaTuaSach,NgonNgu,MaNSX) values('" + maDauSach + "','" + maTuaSach + "','" + ngonNgu + "','" + maNSX + "')";
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
            /// cập nhật bảng DAUSACH
            /// </summary>
            /// <param name="maDauSach">mã đầu sách</param>
           /// <param name="maTuaSach">mã tựa sách</param>
            /// <param name="ngonNgu">ngôn ngữ</param>
            /// <param name="maNXB">mã NXB</param>
            /// <returns>0:không có lỗi; 1:có lỗi; 2:  không có mã đầu sách trong bảng DAUSACH;3: không có mã tựa sách trong bảng TUASACH</returns>
            public int CapNhat(string maDauSach, string maTuaSach, string ngonNgu, string maNSX)
            {

                if (KiemTraMaDauSach_BangDauSach(maDauSach) == true)
                {
                    if ((KiemTraMaTuaSach_BangTuaSach(maTuaSach) == true) && (KiemTraMaNhaNSX_BangNXB(maNSX) == true))
                    {

                        string strSQL = "update DAUSACH set MaTuaSach=" + maTuaSach + "',NgonNgu='" + ngonNgu + "',MaNXB='" + maNSX + "' where MaDauSach='" + maDauSach + "'";
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
           /// xóa thông tin bảng ĐAUSACH
           /// </summary>
           /// <param name="maDauSach">mã đầu sách</param>
            /// <returns>0:không có lỗi; 1:có lỗi; 2: không có mã Đầu sách trong bảng DAUSACH</returns>
            public int Xoa(string maDauSach)
            {
                if (KiemTraMaDauSach_BangDauSach(maDauSach) == true)
                {
                    //câu lệnh sql
                    string strSQL = "delete from DAUSACH where MaDauSach='" + maDauSach + "'";
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
                string strSQL = "select count (*) from TUASACH where MaTuaSSach='" + maTuaSach + "'";
                objDAconnect.KetNoi();
                OleDbCommand command = new OleDbCommand(strSQL, objDAconnect.connect);
                int sodong = (int)command.ExecuteScalar();
                if (sodong > 0)
                    return true;
                else
                    return false;
            }

            /// <summary>
            /// kiểm tra mã đầu sách có trong bảng DAUSACH hay ko?
            /// </summary>
            /// <param name="maDauSach">mã đầu sách</param>
            /// <returns>nếu có trả về true,ko trả về false</returns>
            public bool KiemTraMaDauSach_BangDauSach(string maDauSach)
            {
                //câu lệnh sql
                string strSQL = "select count (*) from DAUSACH where MaDauSach='" + maDauSach + "'";
                objDAconnect.KetNoi();
                OleDbCommand command = new OleDbCommand(strSQL, objDAconnect.connect);
                int sodong = (int)command.ExecuteScalar();
                if (sodong > 0)
                    return true;
                else
                    return false;
            }

            /// <summary>
            /// kiểm tra  mã nhả sx trong bảng NXB
            /// </summary>
            /// <param name="maNSX">mã nhả sản xuất</param>
            /// <returns>nếu có trả về true,ko trả về false</returns>
            public bool KiemTraMaNhaNSX_BangNXB(string maNSX)
            {
                //câu lệnh sql
                string strSQL = "select count (*) from NHAXUATBAN where MaNSX='" + maNSX + "'";
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
