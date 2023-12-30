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
    public class NhaSanXuat_DATA
    {
        // khai báo đối tượng
        ConnectDB objCon = new ConnectDB();

        #region hàm lấy bảng NHASANXUAT

        /// <summary>
        /// hàm lấy hết bảng HANGSANXUAT
        /// </summary>
        /// <returns>trả về 1 bảng sản xuất</returns>
        public DataTable getNhaSanXuat()
        {
            return objCon.getAllTable("HANGSANXUAT").Tables["HANGSANXUAT"];
        }
        #endregion

        #region các phương thức xử lý

        /// <summary>
        /// thêm hãng sản xuất
        /// </summary>
        /// <param name="mahangsx">mã hãng sản xuất</param>
        /// <param name="tenhangsx">tên hãng sản xuất</param>
        /// <param name="thongtinhangsx">thông tin nhà sản xuất</param>
        /// <returns>trả về 0 nếu k có lỗi ( thêm thành công)</returns>
        public int themHangSX(string mahangsx, string tenhangsx, string thongtinhangsx)
        {
            return objCon.executeNonQuery("Insert into HANGSANXUAT values('" + mahangsx + "','" + tenhangsx + "','" + thongtinhangsx + "')");
        }

        /// <summary>
        /// hàm xóa hãng sản xuất theo mã hãng sản xuất
        /// </summary>
        /// <param name="mahangsx">mã hãng sản xuất cần xóa</param>
        /// <returns>trả về 0 nếu k có lỗi ( thêm thành công)</returns>
        public int xoaHangSanXuat(string mahangsx)
        {
            objCon.executeNonQuery("DELETE FROM BAIHAT WHERE mahangsanxuat ='" + mahangsx + "'");
            return objCon.executeNonQuery("DELETE FROM HANGSANXUAT WHERE mahangsanxuat ='" + mahangsx + "'");
        }

        /// <summary>
        /// hàm cập nhật hãng sản xuất
        /// </summary>
        /// <param name="mahangsx">mã hãng sản xuất cần cập nhật</param>
        /// <param name="tenhangsx">tên mới của hãng sản xuất</param>
        /// <param name="thongtinhangsx">thông tin mới của hãng sản xuất</param>
        /// <returns>trả về 0 nếu k có lỗi ( cập nhật thành công)</returns>
        public int capnhatHangSX(string mahangsx, string tenhangsx, string thongtinhangsx)
        {
            return objCon.executeNonQuery("UPDATE HANGSANXUAT SET tenhangsanxuat ='" + tenhangsx + "', thongtinnhasanxuat = '" + thongtinhangsx + "' WHERE mahangsanxuat ='" + mahangsx + "'");
        }
        #endregion
    }
}
