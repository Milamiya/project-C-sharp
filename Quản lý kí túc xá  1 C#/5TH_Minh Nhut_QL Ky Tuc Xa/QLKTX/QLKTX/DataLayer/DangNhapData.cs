using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKTX.BusinessObject;

namespace QLKTX.DataLayer
{
    
    public class DangNhapData
    {
        DataService ser = new DataService();
        public DataTable DangNhap(NguoiDungInfo nguoidung)
        {
            SqlCommand com = new SqlCommand("select * from nguoidung where [USER]=@user");
            com.Parameters.Add("@user", SqlDbType.Char, 32).Value = nguoidung.Username;
            ser.Load(com);
            return ser;
        }
    }
}
