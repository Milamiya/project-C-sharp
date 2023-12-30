using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class TieuChuanChatLuong_Data
    {
        DataService DT_SV = new DataService();

        public DataTable HienThi_DS_TieuChuan()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TieuChuanChatLuong");
            DT_SV.Load(cmd);
            return DT_SV;
        }
        public void Update()
        {
            DT_SV.Update();
        }
        
        public object GetLastID()
        {
            if (this.DT_SV == null)
            {
                this.DT_SV = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM TieuChuanChatLuong ORDER BY MaTieuChuanCL DESC");
            return DT_SV.ExecuteScalar(cmd);
        }

    }
}
