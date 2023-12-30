using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;


namespace BaoCaoThongKe.DataLayer
{
    public class Dangnhap_Data
    {
        DataService ds = new DataService();
        public DataTable DangNhap(string ten)
        {
            SqlCommand com = new SqlCommand("Select MatKhau, Quyen from NguoiDung where TenDangNhap = @ten");
            com.Parameters.Add("@ten", SqlDbType.VarChar, 32).Value = ten;
            ds.Load(com);
            return ds;
        }
    }
}
