using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BaoCaoThongKe.BusinessObject;


namespace BaoCaoThongKe.DataLayer
{
    public class LoaiCongTrinh_Data
    {
        DataService DT_SV = new DataService();

        public DataTable Show_LoaiCongTrinh()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiCongTrinh");
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiCongTrinh ORDER BY MaLoaiCongTrinh DESC");
            return DT_SV.ExecuteScalar(cmd);
        }
        //
        public void Them(LoaiCongTrinh_InFo loaicongtrinh)
        {
            SqlCommand s = new SqlCommand("INSERT INTO LoaiCongTrinh(MaLoaiCongTrinh, TenLoaiCongTrinh) VALUES(@ma, @ten)");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = loaicongtrinh.MaLoaiCongTrinh;
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 200).Value = loaicongtrinh.TenLoaiCongTrinh;
            DT_SV.Load(s);
        }

        public void Xoa(LoaiCongTrinh_InFo loaicongtrinh)
        {
            SqlCommand s = new SqlCommand("Delete LoaiCongTrinh where MaLoaiCongTrinh = @ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = loaicongtrinh.MaLoaiCongTrinh;
            DT_SV.Load(s);
        }

        public void Sua(LoaiCongTrinh_InFo loaicongtrinh)
        {
            SqlCommand s = new SqlCommand("Update LoaiCongTrinh set TenLoaiCongTrinh = @ten where MaLoaiCongTrinh = @ma");
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 50).Value = loaicongtrinh.TenLoaiCongTrinh;
            s.Parameters.Add("@ma", SqlDbType.Int).Value = loaicongtrinh.MaLoaiCongTrinh;
            DT_SV.Load(s);
        }
    }
}
