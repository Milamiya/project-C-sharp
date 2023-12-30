using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace DAL
{
    public class TacGiaDAL
    {
          #region khai báo biến cục bộ
            private OleDbConnection cnn;
            private DAconnect objDAconnect = new DAconnect();
        #endregion

         #region hàm khởi tạo
            public TacGiaDAL()
            { }
        
        #endregion

        #region các hàm  xử lí trong câu lệnh SQL

        /// <summary>
        /// Truy xuất dữ liệu bảng TACGIA
        /// </summary>
        /// <returns>Datatable cua TACGIA</returns>
        public DataTable truyXuatDuLieuBang_TacGia()
        {
            string strTableName = "TACGIA";
            DataTable dtTemp = objDAconnect.HienThiThongTin(strTableName);
            return dtTemp;
        }


        /// <summary>
        /// thêm thông tin bảng TACGIA
        /// </summary>
        /// <param name="maTacGia">mã tác giả</param>
        /// <param name="tenTacGia">tên tác giả</param>
        /// <returns>0:không có lỗi; 1:có lỗi; 2:  có mã tác giả trong bảng TACGIA;</returns>
        public int Them(string maTacGia, string tenTacGia)
        {
            if (KiemTraMaTacGia_BangTacGia(maTacGia) == false)
            {

                //câu lệnh sql
                string strSQL = "insert into TACGIA (MaTacGia,TenTacGia) values('" + maTacGia + "','" + tenTacGia + "')";
                return objDAconnect.ExecuteQuery(strSQL);

            }
            else
                return 2;
        }


        /// <summary>
        /// cập nhật thông tin của bảng TACGIA
        /// </summary>
        /// <param name="maTacGia">mã tác giả</param>
        /// <param name="tenTacGia">tên tác giả</param>
        /// <returns>0:không có lỗi; 1:có lỗi; 2: không có mã tác giả trong bảng TACGIA;3:  có  mã tác giả trong bảng TUASACH</returns>
        public int CapNhat(string maTacGia, string tenTacGia)
        {

            if (KiemTraMaTacGia_BangTacGia(maTacGia) == true)
            {
                if (KiemTraMaTacGia_BangTuaSach(maTacGia) == false)
                {

                    string strSQL = "update TACGIA set TenTacGia='" + tenTacGia + "' where MaTacGia='" + maTacGia + "'";
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
        /// xóa thông tin bảng TACGIA
        /// </summary>
        /// <param name="maTacGia">mã tác giả</param>
        /// <returns>0:không có lỗi; 1:có lỗi; 2: không có mã tác giả trong bảng TACGIA;3:mã tác giả trong bảng TUASACH</returns>
        public int Xoa(string maTacGia)
        {
            if (KiemTraMaTacGia_BangTacGia(maTacGia) == true)
            {
                if (KiemTraMaTacGia_BangTuaSach(maTacGia) == false)
                {
                    //câu lệnh sql
                    string strSQL = "delete from TACGIA where MaTacGia='" + maTacGia + "'";
                    return objDAconnect.ExecuteQuery(strSQL);
                }
                else
                    return 3;
            }
            else
                return 2;
        }


          /// <summary>
          /// kiểm tra mã tác  giả có trong bảng TACGIA hay ko? 
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


        /// <summary>
        /// kiểm tra xem mã tác giả có trong bảng TUASACH hay ko?
        /// </summary>
        /// <param name="maTacGia">mã tác giả</param>
        /// <returns>nếu có trả về true,ko trả về false</returns>
        public bool KiemTraMaTacGia_BangTuaSach(string maTacGia)
        {
            //câu lệnh sql
            string strSQL = "select count (*) from TUASACH where MaTacGia='" + maTacGia + "'";
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
