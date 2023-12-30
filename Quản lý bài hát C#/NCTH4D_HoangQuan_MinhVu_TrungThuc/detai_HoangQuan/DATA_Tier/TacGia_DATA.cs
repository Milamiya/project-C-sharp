/*
 * sv thực hiện: Lê Hữu Hoàng Quân - 10258441
 * ngày bắt đầu đề tài : 26/10/2012
 * lần cuối update ngày: 31/10/2012
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace DATA_Tier
{
    public class TacGia_DATA
    {
        // khai báo
        ConnectDB objCon = new ConnectDB();
        #region các hàm lấy bảng, lấy hết bảng, lấy theo điều kiện

        /// <summary>
        /// lấy hết bảng TACGIA
        /// </summary>
        /// <returns>trả về bảng TACGIA</returns>
        public DataTable getTacGia()
        {
            return objCon.getAllTable("TACGIA").Tables["TACGIA"];
        }
        #endregion

        #region các phương thức xử lý thêm xóa sữa (sql)
        /// <summary>
        /// hàm thêm 1 tác giả mới
        /// </summary>
        /// <param name="matacgia">mã tác giả</param>
        /// <param name="tentacgia">tên tác giả</param>
        /// <param name="thongtintacgia">thông tin tác giả</param>
        /// <returns>trả về 0 nếu không có lổi (thành công)!</returns>
        public int themTacGia(string matacgia, string tentacgia, string thongtintacgia)
        {
            return objCon.executeNonQuery("Insert into TACGIA values('" + matacgia + "','" + tentacgia + "','" + thongtintacgia + "')");
        }

        /// <summary>
        /// hàm xóa tác giả theo mã tác giả
        /// </summary>
        /// <param name="matacgia">mã tác giả cần xóa</param>
        /// <returns>trả về 0 nếu không có lổi (thành công)!</returns>
        public int xoaTacGia(string matacgia)
        {
            objCon.executeNonQuery("DELETE FROM BAIHAT WHERE matacgia ='" + matacgia + "'");
            return objCon.executeNonQuery("DELETE FROM TACGIA WHERE matacgia ='" + matacgia + "'");
        }

        /// <summary>
        /// hàm cập nhật tác giả (update)
        /// </summary>
        /// <param name="matacgia">mã tác giả cần cập nhật (không cập nhật mã)</param>
        /// <param name="tentacgia">tên mới của tác giả</param>
        /// <param name="thongtintacgia">thông tin mới của tácgiả</param>
        /// <returns>trả về 0 nếu không có lổi (thành công)!</returns>
        public int capnhatTacGia(string matacgia, string tentacgia, string thongtintacgia)
        {
            return objCon.executeNonQuery("UPDATE TACGIA SET tentacgia ='" + tentacgia + "', thongtintacgia = '" + thongtintacgia + "' WHERE matacgia ='" + matacgia + "'");
        }
        #endregion
    }
}
