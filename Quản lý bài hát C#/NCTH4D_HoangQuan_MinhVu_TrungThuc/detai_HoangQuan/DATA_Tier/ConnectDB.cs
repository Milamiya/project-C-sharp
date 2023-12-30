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
    public class ConnectDB
    {
        // khai báo public biến connection con
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB\\dbBAIHAT.accdb;Persist Security Info=True");

        // khởi tạo
        public ConnectDB() { }


        #region các phương thức lấy toàn bộ bảng, và thực hiện câu sql (dùng chung )

        /// <summary>
        /// hàm lấy bảng theo tên bảng truyền vào
        /// </summary>
        /// <param name="tableName">tên bảng cần lấy</param>
        /// <returns>trả về 1 dataset chứa 1 bảng và có tên là bảng được truyền vào</returns>
        public DataSet getAllTable(string tableName)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from " + tableName, con);
            //khai bao dataset
            DataSet ds = new DataSet();
            // do du lieu vao ds
            da.Fill(ds, tableName);
            return ds;
        }

        /// <summary>
        /// hàm lấy bài hát, tên thể loại, tên album ... (iên kết bảng bằng câu sql)
        /// </summary>
        /// <returns>trả về 1 dataset chứa 1 bảng gồm các cột là tên bài hát, tên thể loại, tên album ...</returns>
        public DataSet getBaiHat_home()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select mabaihat,tenbaihat,BAIHAT.maalbum,tenalbum,ALBUM.maalbum,BAIHAT.matheloai,THELOAI.matheloai,tentheloai,loibaihat from BAIHAT,ALBUM,THELOAI where BAIHAT.maalbum=ALBUM.maalbum and BAIHAT.matheloai=THELOAI.matheloai", con);
            //select mabaihat,tenbaihat,THELOAI.matheloai,tentheloai,ALBUM.maalbum,tenalbum,TACGIA.matacgia,tentacgia,CASI.macasi,tencasi,macasi_baihat,CASI_BAIHAT.macasi,CASI_BAIHAT.tencasi,loibaihat from BAIHAT,ALBUM,CASI,THELOAI,CASI_BAIHAT where BAIHAT.matheloai=THELOAI.matheloai and BAIHAT.maalbum = ALBUM.maalbum and BAIHAT.macasi = CASI.macasi and BAIHAT.matacgia=TACGIA.matacgia
            DataSet ds=new DataSet();
            da.Fill(ds, "baihat_home");
           
            return ds;
        }

        /// <summary>
        /// hàm thực hiện câu sql đc truyền vào
        /// </summary>
        /// <param name="sql">câu sql (kiểu chuổi)</param>
        /// <returns>trả về 0 nếu thực hiện thành công, ngược lại trả về 1</returns>
        public int executeNonQuery(string sql)
        {
            try
            {
                con.Open();
                OleDbCommand cmd=new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return 0;
            }
            catch (Exception)
            {
                return 1;
            }
        }
        #endregion
    }
}
