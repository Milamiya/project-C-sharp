using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaoCaoThongKe.DataLayer
{
    public class Xa_Phuong_Data
    {
        DataService DT_SV = new DataService();
        
        public Xa_Phuong_Data() { }
        public DataTable DanhSach_Xa_Phuong()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Xa");
            DT_SV.Load(cmd);
            return DT_SV;
        }
        public DataTable ChiTietXa(int maHuyen)
        {
            SqlCommand s = new SqlCommand("select * from Xa where MaHuyen = @ma order by TenXa");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = maHuyen;
            DT_SV.Load(s);
            return DT_SV;
        }
        public void Update()
        {
            DT_SV.Update();
        }
        //
        public string LayMaHuyen(string maXa)
        {
            SqlCommand s = new SqlCommand("select distinct  MaHuyen from Xa  where MaXa = @ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = maXa;
            DT_SV.Load(s);
            return DT_SV.Rows[0][0].ToString();
        }
        //
        public object GetLastID()
        {
            if (this.DT_SV == null)
            {
                this.DT_SV = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM Xa ORDER BY MaXa DESC");
            return DT_SV.ExecuteScalar(cmd);
        }
     }
}
