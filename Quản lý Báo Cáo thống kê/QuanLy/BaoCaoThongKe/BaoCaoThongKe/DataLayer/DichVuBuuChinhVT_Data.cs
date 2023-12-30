using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class DichVuBuuChinhVT_Data
    {

        DataService DT_SV = new DataService();
        public DataTable Show_CacDichVu()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DichVuBuuChinhVT");
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM DichVuBuuChinhVT ORDER BY MaDichVuBuuChinhVT DESC");
            return DT_SV.ExecuteScalar(cmd);
        }
        //bao cao
        public DataTable ChitietDichVu_Doanhnghiep(string doanhnghiep)
        {
            SqlCommand cmd = new SqlCommand("Select DichVuBuuChinhVT.MaDichVuBuuChinhVT,DichVuBuuChinhVT.TenDichVuBuuChinhVT,DoanhNghiep.TenDoanhNghiep from DichVuBuuChinhVT,DoanhNghiep where DichVuBuuChinhVT.MaDoanhNghiep = DoanhNghiep.MaDoanhNghiep and DichVuBuuChinhVT.MaDoanhNghiep = @doanhnghiep");
            cmd.Parameters.Add("@doanhnghiep", SqlDbType.Int).Value = doanhnghiep;
            DT_SV.Load(cmd);
            return DT_SV;
        }
        public DataTable LayMaMax()
        {
            SqlCommand cmd = new SqlCommand("select Max(MaDichVuBuuChinhVT) from DichVuBuuChinhVT");
            DT_SV.Load(cmd);
            return DT_SV;
        }
        //
        public void Them(DichVuBuuChinh_VienThong_InFo dichvubcvt)
        {
            SqlCommand s = new SqlCommand("INSERT INTO DichVuBuuChinhVT(MaDichVuBuuChinhVT, TenDichVuBuuChinhVT, MaDoanhNghiep) VALUES(@ma, @ten, @doanhnghiep)");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = dichvubcvt.MaDichVuBuuChinhVT;
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 200).Value = dichvubcvt.TenDichVuBuuChinhVT;
            s.Parameters.Add("@doanhnghiep", SqlDbType.Int).Value = dichvubcvt.Doanhnghiep.MaDoanhNghiep;

            DT_SV.Load(s);
        }

        public void Xoa(DichVuBuuChinh_VienThong_InFo dichvubcvt)
        {
            SqlCommand s = new SqlCommand("Delete from DichVuBuuChinhVT where MaDichVuBuuChinhVT=@ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = dichvubcvt.MaDichVuBuuChinhVT;

            DT_SV.Load(s);
        }

        public void Sua(DichVuBuuChinh_VienThong_InFo dichvubcvt)
        {
            SqlCommand s = new SqlCommand("Update DichVuBuuChinhVT set TenDichVuBuuChinhVT=@ten, MaDoanhNghiep=@doanhnghiep where MaDichVuBuuChinhVT=@ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = dichvubcvt.MaDichVuBuuChinhVT;
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 200).Value = dichvubcvt.TenDichVuBuuChinhVT;
            s.Parameters.Add("@doanhnghiep", SqlDbType.Int).Value = dichvubcvt.Doanhnghiep.MaDoanhNghiep;

            DT_SV.Load(s);
        }
    }
}
