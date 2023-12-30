using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaoCaoThongKe.DataLayer
{
    public class DoanhNghiepData
    {
        DataService data = new DataService();

        public DataTable HienThiDoanhNghiep()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DoanhNghiep");
            data.Load(cmd);
            return data;
        }

        public void Update()
        {
            data.Update();
        }
    }
}
