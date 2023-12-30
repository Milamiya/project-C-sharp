using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class DonViTinh_Data
    {
        DataService DT_SV = new DataService();

        public DataTable Show_DVTinh()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DonViTinh");
            DT_SV.Load(cmd);
            return DT_SV;
        }
        public void Update()
        {
            DT_SV.Update();
        }
        //
        public object GetLastID()
        {
            if (this.DT_SV == null)
            {
                this.DT_SV = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM DonViTinh ORDER BY MaDonViTinh DESC");
            return DT_SV.ExecuteScalar(cmd);
        }
    }
}
