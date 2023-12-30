using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class LoaiBaoCao_Data
    {
        DataService DT_SV = new DataService();
        //LoaiBaoCao_InFo INFO = new LoaiBaoCao_InFo();
        public DataTable Show_Ds_LoaiBaoCao()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiBaoCao");
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiBaoCao ORDER BY MaLoaiBaoCao DESC");
            return DT_SV.ExecuteScalar(cmd);
        }

    }
}
