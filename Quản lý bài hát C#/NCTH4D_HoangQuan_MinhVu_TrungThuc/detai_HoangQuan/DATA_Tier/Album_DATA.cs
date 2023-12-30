/*
 * sv thực hiện: Lê Hữu Hoàng Quân - 10258441
 * ngày bắt đầu đề tài : 26/10/2012
 * lần cuối update ngày: 27/10/2012
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace DATA_Tier
{
    public class Album_DATA
    {
        ConnectDB objCon = new ConnectDB();
        public Album_DATA() { }

        #region hàm lấy bảng album
        /// <summary>
        /// hàm lấy hết bảng ALBUM
        /// </summary>
        /// <returns>trả về bảng album</returns>
        public DataTable getAlbum()
        {
            return objCon.getAllTable("ALBUM").Tables["ALBUM"];
        }

        /// <summary>
        /// hàm lấy thông tin album theo mã
        /// </summary>
        /// <param name="maalbum">mã album cần lấy thông tin</param>
        /// <returns>trả về bảng thông tin của album đc truyền vào</returns>
        public DataTable getAlbum_by_ma(string maalbum)
        {
            OleDbCommand cmd = new OleDbCommand("select * from ALBUM where maalbum = @ma", objCon.con);
            cmd.Parameters.Add("@ma", OleDbType.BSTR).Value = maalbum;
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand=cmd;
            da.Fill(ds, "album");
            return ds.Tables["album"];
        }
        #endregion

        #region các phương thức xử lý
        public int themAlbum(string maalbum,string tenalbum, string namphathanh)
        {
            return objCon.executeNonQuery("Insert into ALBUM values('" + maalbum + "','" + tenalbum + "','" + namphathanh + "')");
        }

        public int xoaAlbum(string maalbum)
        {
            objCon.executeNonQuery("DELETE FROM BAIHAT WHERE maalbum ='" + maalbum + "'");
            return objCon.executeNonQuery("DELETE FROM ALBUM WHERE maalbum ='" + maalbum + "'");
        }

        public int capnhatAlbum(string maalbum,string tenalbum,string namphathanh)
        {
            return objCon.executeNonQuery("UPDATE ALBUM SET tenalbum ='" + tenalbum + "', namphathanh = '" + namphathanh +  "' WHERE maalbum ='" + maalbum + "'");
        }
        public int xoaBaiHatKhoiAlBum(string maalbum)
        {
            return objCon.executeNonQuery("DELETE FROM BAIHAT WHERE maalbum ='" + maalbum + "'");
        }
        #endregion
    }
}
