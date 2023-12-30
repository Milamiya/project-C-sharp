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
    public class TheLoai_DATA
    {
        // khai báo
        ConnectDB objCon = new ConnectDB();
        #region các hàm lấy table, lấy hết table và lấy theo điều kiện

        /// <summary>
        /// hàm lấy toàn bộ bảng THELOAI
        /// </summary>
        /// <returns>trả về bảng THELOAI</returns>
        public DataTable getTheLoai()
        {
            return objCon.getAllTable("THELOAI").Tables["THELOAI"];
        }

        /// <summary>
        /// hàm lấy bảng thể loại theo mã thể loại
        /// </summary>
        /// <param name="matheloai">mã thể loại cần lấy</param>
        /// <returns>trả về bảng theloai với 1 dòng (theo mã vừa chuyền vào)</returns>
        public DataTable getTheLoai_by_ma(string matheloai)
        {
            OleDbCommand cmd = new OleDbCommand("select * from THELOAI where matheloai = @ma", objCon.con);
            cmd.Parameters.Add("@ma", OleDbType.BSTR).Value = matheloai;
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds, "theloai");
            return ds.Tables["theloai"];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mabaihat"></param>
        /// <returns></returns>
        public DataTable getTheLoai_by_mabaihat(string mabaihat)
        {
            OleDbCommand cmd = new OleDbCommand("select * from THELOAI where mabaihat = @ma", objCon.con);
            cmd.Parameters.Add("@ma", OleDbType.BSTR).Value = mabaihat;
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds, "theloai");
            return ds.Tables["theloai"];
        }
        #endregion

        #region các phương thức xử lý (câu sql) thêm xóa sửa

        /// <summary>
        /// thêm 1 thể loại mới
        /// </summary>
        /// <param name="matheloai">mã thể loại</param>
        /// <param name="tentheloai">tên thể loại</param>
        /// <returns>trả về 0 nếu không có lổi (thành công)!</returns>
        public int themTheLoai(string matheloai, string tentheloai)
        {
            return objCon.executeNonQuery("Insert into THELOAI values('" + matheloai + "','" + tentheloai + "')");
        }
        
        /// <summary>
        /// xóa thể loại theo mã
        /// </summary>
        /// <param name="matheloai">mã thể loại cần xóa</param>
        /// <returns>trả về 0 nếu không có lổi (thành công)!</returns>
        public int xoaTheLoai(string matheloai)
        {
            objCon.executeNonQuery("DELETE FROM BAIHAT WHERE matheloai ='" + matheloai + "'");
            return objCon.executeNonQuery("DELETE FROM THELOAI WHERE matheloai ='" + matheloai + "'");
        }

        /// <summary>
        /// cập nhật thể loại (update)
        /// </summary>
        /// <param name="matheloai">mã thể loại cần cập nhật</param>
        /// <param name="tentheloai">tên mới của thể loại</param>
        /// <returns>trả về 0 nếu không có lổi (thành công)!</returns>
        public int capnhatTheLoai(string matheloai, string tentheloai)
        {
            return objCon.executeNonQuery("UPDATE THELOAI SET tentheloai ='" + tentheloai +  "' WHERE matheloai ='" + matheloai + "'");
        }
        #endregion
    }
}
