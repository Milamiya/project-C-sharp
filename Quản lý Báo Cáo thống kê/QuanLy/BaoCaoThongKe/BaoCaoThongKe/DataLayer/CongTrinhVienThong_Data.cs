using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraGrid;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Controls;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class CongTrinhVienThong_Data
    {
        DataService DT_SV = new DataService();
        public DataTable Show_DS_CacCongTrinh()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM CongTrinhVienThong");
            DT_SV.Load(cmd);
            return DT_SV;
        }
        public void Update()
        {
            DT_SV.Update();
        }
        //
        public DataTable ChitietCongTrinh_Doanhnghiep(string doanhnghiep, string loaicongtrinh)
        {
            SqlCommand cmd = new SqlCommand("Select CongTrinhVienThong.MaCongTrinh,CongTrinhVienThong.TenCongTrinh,LoaiCongTrinh.TenLoaiCongTrinh,DoanhNghiep.TenDoanhNghiep from DoanhNghiep,CongTrinhVienThong,LoaiCongTrinh where CongTrinhVienThong.MaLoaiCongTrinh=LoaiCongTrinh.MaLoaiCongTrinh and CongTrinhVienThong.MaDoanhNghiep=DoanhNghiep.MaDoanhNghiep and DoanhNghiep.MaDoanhNghiep=@doanhnghiep and LoaiCongTrinh.MaLoaiCongTrinh=@loaicongtrinh");
            cmd.Parameters.Add("loaicongtrinh", SqlDbType.VarChar).Value = loaicongtrinh;
            cmd.Parameters.Add("doanhnghiep", SqlDbType.VarChar).Value = doanhnghiep;

            DT_SV.Load(cmd);
            return DT_SV;
        }
        public DataTable LayMaMax()
        {
            SqlCommand cmd = new SqlCommand("select Max(MaCongTrinh) from CongTrinhVienThong");
            DT_SV.Load(cmd);
            return DT_SV;
        }
        public object GetLastID()
        {
            if (this.DT_SV == null)
            {
                this.DT_SV = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM CongTrinhVienThong ORDER BY MaCongTrinh DESC");
            return DT_SV.ExecuteScalar(cmd);
        }
        public void Them(CongTrinhVienThong_InFo congtrinh)
        {
            SqlCommand cmd = new SqlCommand("insert into CongTrinhVienThong(MaCongTrinh,TenCongTrinh,MaLoaiCongTrinh,MaDoanhNghiep) values(@ma,@ten,@loai,@doanhnghiep)");
            cmd.Parameters.Add("ma", SqlDbType.Int).Value = congtrinh.MaCongTrinh;
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = congtrinh.TenCongTrinh;
            cmd.Parameters.Add("loai", SqlDbType.Int).Value = congtrinh.MaLoaiCongTrinh.MaLoaiCongTrinh;
            cmd.Parameters.Add("doanhnghiep", SqlDbType.Int).Value = congtrinh.MaDoanhNghiep.MaDoanhNghiep;
            DT_SV.Execute(cmd);
        }

        public void Xoa(CongTrinhVienThong_InFo congtrinh)
        {
            SqlCommand cmd = new SqlCommand("delete from CongTrinhVienThong where MaCongTrinh=@ma");
            cmd.Parameters.Add("ma", SqlDbType.Int).Value = congtrinh.MaCongTrinh;

            DT_SV.Execute(cmd);
        }

        public void Sua(CongTrinhVienThong_InFo congtrinh)
        {
            SqlCommand cmd = new SqlCommand("update CongTrinhVienThong set TenCongTrinh=@ten,MaLoaiCongTrinh=@loai,MaDoanhNghiep=@doanhnghiep where MaCongTrinh=@ma");
            cmd.Parameters.Add("ma", SqlDbType.Int).Value = congtrinh.MaCongTrinh;
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = congtrinh.TenCongTrinh;
            cmd.Parameters.Add("loai", SqlDbType.Int).Value = congtrinh.MaLoaiCongTrinh.MaLoaiCongTrinh;
            cmd.Parameters.Add("doanhnghiep", SqlDbType.Int).Value = congtrinh.MaDoanhNghiep.MaDoanhNghiep;

            DT_SV.Execute(cmd);
        }
    }
}
