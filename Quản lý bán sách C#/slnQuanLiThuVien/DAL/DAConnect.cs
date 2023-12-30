/*
 * Author: Đặng Thị Diễm Trinh
 * create:4/10/2012
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;


namespace DAL
{
    public class DAconnect
    {
        /// <summary>
        /// khai báo biến
        /// </summary>
        public OleDbConnection connect;
        string connectionString;



        /// <summary>
        /// hàm khởi tạo
        /// </summary>
        public DAconnect()
        {

        }
        /// <summary>
        /// hàm mở kết nối
        /// </summary>
        public void KetNoi()
        {
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database/dbQUANLITHUVIEN.accdb;Persist Security Info=False;";
            connect = new OleDbConnection(connectionString);
            try
            {
                connect.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Không thể kết nối được với Server\n" + ex.Message, "Lỗi chương trình");
            }

        }

        /// <summary>
        /// hàm đóng kết nối
        /// </summary>
        public void DongKetNoi()
        {
            try
            {
                connect.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// hàm thực thi câu lệnh sql
        /// </summary>
        /// <param name="strSQL">câu lệnh sql</param>
        /// <returns>0: không có lỗi; 1: có lỗi</returns>
        public int ExecuteQuery(string strSQL)
        {
            try
            {
            //mở kết nối
            KetNoi();

          

            //truyền câu lệnh sql
            OleDbCommand command = new OleDbCommand(strSQL, connect);
            //thực hiện câu sql
            command.ExecuteNonQuery();
            //đóng kết nối
            DongKetNoi();
            return 0;//không có lỗi
            }
            catch (Exception)
            {

                return 1;//co lỗi 
            }
        }

        /// <summary>
        /// lấy toàn bộ thông tin của bảng cho trước (vd: tên sách)
        /// </summary>
        /// <param name="strTable">Tên bảng cần lấy thông tin</param>
        /// <returns>Datatable chứa bảng cho trước</returns>
        public DataTable HienThiThongTin(string strTable)
        {


            DataSet ds = null;
            try
            {
                //câu lệnh sql
                string strSQL = "select * from " + strTable;
                //kiểm tra kết nối
                connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database/dbQUANLITHUVIEN.accdb;Persist Security Info=False;";
                connect = new OleDbConnection(connectionString);

            

                //khai báo,tao đối tương cầu nối (data adapter)
                OleDbDataAdapter da = new OleDbDataAdapter(strSQL, connect);
                //tạo dataset
                ds = new DataSet();
                //4. Nạp dữ liệu vào dataset thông qua phương thức Fill
                da.Fill(ds, strTable);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Lỗi trong khi load DL");

            }
            return ds.Tables[0];

        }





        public DataTable HienThiThongTin1()
        {


            DataSet ds = null;
            try
            {
                //câu lệnh sql
                string strSQL = "SELECT TACGIA.*, TUASACH.*, THELOAI.*, DAUSACH.*, CUONSACH.*"+
"FROM (THELOAI INNER JOIN (TACGIA INNER JOIN TUASACH ON TACGIA.MaTacGia = TUASACH.MaTacGia) ON THELOAI.MaLoaiSach = TUASACH.MaTheLoai) INNER JOIN (DAUSACH INNER JOIN CUONSACH ON DAUSACH.MaDauSach = CUONSACH.MaDauSach) ON TUASACH.MaTuaSach = DAUSACH.MaTuaSach";
                //kiểm tr kết nối
                connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database/dbQUANLITHUVIEN.accdb;Persist Security Info=False;";
                connect = new OleDbConnection(connectionString);

                //khai báo,tao đối tương cầu nối (data adapter)
                OleDbDataAdapter da = new OleDbDataAdapter(strSQL, connect);
                //tạo dataset
                ds = new DataSet();
                //4. Nạp dữ liệu vào dataset thông qua phương thức Fill
                da.Fill(ds);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Lỗi trong khi load DL");

            }
            return ds.Tables[0];

        }


    }
}
