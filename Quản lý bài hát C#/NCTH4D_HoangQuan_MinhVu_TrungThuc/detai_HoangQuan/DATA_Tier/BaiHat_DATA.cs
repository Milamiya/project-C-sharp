/*
 * sv thực hiện: Lê Hữu Hoàng Quân - 10258441
 * ngày bắt đầu đề tài : 26/10/2012
 * lần cuối update ngày: 2/11/2012
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace DATA_Tier
{
    public class BaiHat_DATA
    {
        ConnectDB objCon = new ConnectDB();

        #region các hàm lấy dử liệu table

        /// <summary>
        /// hàm lấy tất cả bảng bài hát
        /// </summary>
        /// <returns>trả về bảng bài hát</returns>
        public DataTable getBaiHat()
        {
            return objCon.getAllTable("BAIHAT").Tables["BAIHAT"];
        }

        /// <summary>
        /// hàm lấy bà hát có tên thể loại, tên album,... (dùng cho tab home)
        /// </summary>
        /// <returns>trả về bảng có tên album, tên thể loại,... </returns>
        public DataTable getBaiHat_Home()
        {
            return objCon.getBaiHat_home().Tables["baihat_home"];
        }

        /// <summary>
        /// hàm lấy bài hát theo mã album
        /// </summary>
        /// <param name="maalbum">mã album cần lấy bài hát</param>
        /// <returns>trả về bảng gồm các bài hát của album đc truyền vào</returns>
        public DataTable getBaiHat_by_Album(string maalbum)
        {
            
            OleDbCommand cmd = new OleDbCommand("select * from BAIHAT where maalbum=@malbum", objCon.con);
            cmd.Parameters.Add("@maalbum", OleDbType.BSTR).Value = maalbum;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "chitietbaihat");
            
            return ds.Tables["chitietbaihat"];
        }


        /// <summary>
        /// hàm lấy bài hát theo mã bài hát
        /// </summary>
        /// <param name="mabaihat">mã bài hát cần lấy thông tin</param>
        /// <returns>bảng thông tin bài hát đc truyền vào</returns>
        public DataTable getBaiHat_by_mabaihat(string mabaihat)
        {
            OleDbCommand cmd = new OleDbCommand("select * from BAIHAT where mabaihat=@mabaihat", objCon.con);
            cmd.Parameters.Add("@mabaihat", OleDbType.BSTR).Value = mabaihat;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "baihat");

            return ds.Tables["baihat"];
        }

        /// <summary>
        /// hàm lấy bài hát theo mã thể loại
        /// </summary>
        /// <param name="matheloai">mã thể loại cần lấy các bài hát</param>
        /// <returns>trả về bảng bài hát theo thể loại đc truyền vào</returns>
        public DataTable getBaiHat_by_TheLoai(string matheloai)
        {
            OleDbCommand cmd = new OleDbCommand("select * from BAIHAT where matheloai=@matheloai", objCon.con);
            cmd.Parameters.Add("@matheloai", OleDbType.BSTR).Value = matheloai;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "chitietbaihat");

            
            return ds.Tables["chitietbaihat"];
        }
        public DataTable getBaiHat_by_cbo(string matheloai, string maalbum, string macasi, string matacgia, string mahangsanxuat)
        {
            
            OleDbCommand cmd = new OleDbCommand("select * from BAIHAT where matheloai=@matheloai,maalbum=@maalbum,macasi=@macasi,matacgia=@matacgia,mahangsanxuat=@mahangsanxuat", objCon.con);
            cmd.Parameters.Add("@matheloai", OleDbType.BSTR).Value = matheloai;
            cmd.Parameters.Add("@maalbum", OleDbType.BSTR).Value = maalbum;
            cmd.Parameters.Add("@macasi", OleDbType.BSTR).Value = macasi;
            cmd.Parameters.Add("@matacgia", OleDbType.BSTR).Value = matacgia;
            cmd.Parameters.Add("@mahangsanxuat", OleDbType.BSTR).Value = mahangsanxuat;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds= new DataSet();
            da.Fill(ds, "baihat_cbo");
            
            return ds.Tables["baihat_cbo"];
        }
        public DataTable getBaiHat_by_cbo(string matheloai, string maalbum)
        {
           
            OleDbCommand cmd = new OleDbCommand("select * from BAIHAT where matheloai=@matheloai,maalbum=@maalbum", objCon.con);
            cmd.Parameters.Add("@matheloai", OleDbType.BSTR).Value = matheloai;
            cmd.Parameters.Add("@maalbum", OleDbType.BSTR).Value = maalbum;
            
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "baihat_cbo");
            
            return ds.Tables["baihat_cbo"];
        }
        #endregion

        #region các phương thức xử lý

        // thêm bài hát
        public int themBaiHat(string mabaihat, string tenbaihat, string matheloai, string maalbum, string macasi, string matacgia, string manhasanxuat, string loibaihat)
        {
            objCon.executeNonQuery("Insert into BAIHAT values('" + mabaihat + "','" + tenbaihat + "','" + matheloai + "','" + maalbum + "','" + macasi + "','" + matacgia + "','" + manhasanxuat + "','" + loibaihat + "')");
            return objCon.executeNonQuery("Insert into CASI_BAIHAT values('" + macasi + "','" + mabaihat + "')");
            
        }

        /// <summary>
        /// xóa bài hát
        /// </summary>
        /// <param name="mabaihat">mã bài hát cần xóa</param>
        /// <returns>trả về 0 nếu xóa thành công</returns>
        public int xoaBaiHat(string mabaihat)
        {
            return objCon.executeNonQuery("DELETE FROM BAIHAT WHERE mabaihat ='" + mabaihat + "'");
        }

        // câph nhật bài hát, trả về 0 nếu thành công
        public int capnhatBaiHat(string mabaihat, string tenbaihat, string matheloai,string maalbum,string macasi,string matacgia,string mahangsanxuat,string loibaihat)
        {
            return objCon.executeNonQuery("UPDATE BAIHAT SET tenbaihat ='" + tenbaihat + "', matheloai = '" + matheloai + "',maalbum = '" + maalbum + "',macasi = '" + macasi + "',matacgia = '" + matacgia + "',mahangsanxuat = '" + mahangsanxuat + "',loibaihat = '" + loibaihat + "' WHERE mabaihat ='" + mabaihat + "'");
        }
        #endregion
    }
}
