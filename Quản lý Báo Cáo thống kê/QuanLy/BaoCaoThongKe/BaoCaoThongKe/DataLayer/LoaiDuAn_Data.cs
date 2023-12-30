using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BaoCaoThongKe.BusinessObject;


namespace BaoCaoThongKe.DataLayer
{
    public class LoaiDuAn_Data
    {
        DataService DT_SV = new DataService();
        public DataTable Show_DS_LoaiDuAn()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiDuAn");
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiDuAn ORDER BY MaLoaiDuAn DESC");
            return DT_SV.ExecuteScalar(cmd);
        }
        public void Xoa(LoaiDuAn_InFo loaiduan)
        {
            SqlCommand s = new SqlCommand("Delete LoaiDuAn where MaLoaiDuAn = @ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = loaiduan.MaLoaiDuAn;
            DT_SV.Load(s);
        }

        public void Them(LoaiDuAn_InFo loaiduan)
        {
            SqlCommand s = new SqlCommand("INSERT INTO LoaiDuAn(MaLoaiDuAn, TenLoaiDuAn) VALUES(@ma, @ten)");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = loaiduan.MaLoaiDuAn;
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 50).Value = loaiduan.TenLoaiDuAn;
            DT_SV.Load(s);
        }

        public void Sua(LoaiDuAn_InFo loaiduan)
        {
            SqlCommand s = new SqlCommand("Update LoaiDuAn set TenLoaiDuAn = @ten where MaLoaiDuAn = @ma");
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 50).Value = loaiduan.TenLoaiDuAn;
            s.Parameters.Add("@ma", SqlDbType.Int).Value = loaiduan.MaLoaiDuAn;
            DT_SV.Load(s);
        }
        public DataTable LayMaMax()
        {
            SqlCommand cmd = new SqlCommand("select Max(MaLoaiDuAn) from LoaiDuAn");
            DT_SV.Load(cmd);
            return DT_SV;
        }
            
    }
}
