using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace DAL
{
    public class NhaXuatBanDAL
    {
        #region khai báo biến cục bộ
            private OleDbConnection cnn;
            private DAconnect objDAconnect = new DAconnect();
        #endregion

         #region hàm khởi tạo
            public NhaXuatBanDAL()
            { }
        
        #endregion

        #region các hàm  xử lí trong câu lệnh SQL

        /// <summary>
        /// Truy xuất dữ liệu bảng NHAXUATBAN
        /// </summary>
        /// <returns>Datatable cua NHAXUATBAN</returns>
        public DataTable truyXuatDuLieuBang_NhaXuatBan()
        {
            string strTableName = "NHAXUATBAN";
            DataTable dtTemp = objDAconnect.HienThiThongTin(strTableName);
            return dtTemp;
        }


       /// <summary>
       /// thêm thông tin vào bảng NHAXUATBAN
       /// </summary>
       /// <param name="maNSX">mã nhà sản xuất</param>
       /// <param name="tenNSX">tên nhà xuất bản</param>
        /// <returns>0:không có lỗi; 1:có lỗi; 2:  có mã nhà sản xuất trong bảng NHAXUATBAN;</returns>
        public int Them(string maNSX, string tenNSX)
        {
            if (KiemTraMaNSX_BangNhaXuatBan(maNSX) == false)
            {

                //câu lệnh sql
                string strSQL = "insert into NHAXUATBAN (MaNSX,TenNSX) values('" + maNSX + "','" + tenNSX + "')";
                return objDAconnect.ExecuteQuery(strSQL);

            }
            else
                return 2;
        }


        /// <summary>
        /// thêm thông tin vào bảng NHAXUATBAN
        /// </summary>
        /// <param name="maNSX">mã nhà sản xuất</param>
        /// <param name="tenNSX">tên nhà xuất bản</param>
        /// <returns>0:không có lỗi; 1:có lỗi; 2: không có mã nhà sản xuất trong bảng NHAXUATBAN;3:  có  mã nhà sản xuất trong bảng DAUSACH</returns>
        public int CapNhat(string maNSX, string tenNSX)
        {

            if (KiemTraMaNSX_BangNhaXuatBan(maNSX) == true)
            {
                if (KiemTraMaNSX_BangDauSach(maNSX) == false)
                {

                    string strSQL = "update NHAXUATBAN set TenNSX='" + tenNSX + "' where MaNSX='" + maNSX + "'";
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
       /// xóa thông tin bảng NHAXUATBAN
       /// </summary>
       /// <param name="maNSX">mã nhà sản xuất</param>
        /// <returns>>0:không có lỗi; 1:có lỗi; 2: không có mã nhà sản xuất trong bảng NHAXUATBAN;3:có mã nhà sản xuất trong bảng DAUSACH</returns>
        public int Xoa(string maNSX)
        {
            if (KiemTraMaNSX_BangNhaXuatBan(maNSX) == true)
            {
                if (KiemTraMaNSX_BangDauSach(maNSX) == false)
                {
                    //câu lệnh sql
                    string strSQL = "delete from NHAXUATBAN where MaNSX='" + maNSX + "'";
                    return objDAconnect.ExecuteQuery(strSQL);
                }
                else
                    return 3;
            }
            else
                return 2;
        }


        /// <summary>
        /// kiểm tra xem mã nhà sản  xuất  có trong bảng NHAXUATBAN hay ko?
        /// </summary>
        /// <param name="maNSX">mã nhà sản xuất</param>
        /// <returns>nếu có trả về true,ko trả về false</returns>
  
        public bool KiemTraMaNSX_BangNhaXuatBan(string maNSX)
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


        /// <summary>
        /// kiểm tra xem mã nhà sản  xuất  có trong bảng DAUSACH hay ko?
        /// </summary>
        /// <param name="maNSX">mã nhà sản xuất</param>
        /// <returns>nếu có trả về true,ko trả về false</returns>
        public bool KiemTraMaNSX_BangDauSach(string maNSX)
        {
            //câu lệnh sql
            string strSQL = "select count (*) from DAUSACH where MaNSX='" + maNSX + "'";
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
