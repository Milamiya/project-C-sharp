using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class DuAn_Data
    {
        DataService ds = new DataService();
        public DataTable ChitietDuAn()
        {
            SqlCommand cmd = new SqlCommand("select * from DuAn");
            ds.Load(cmd);
            return ds;
        }
        public void Update()
        {
            ds.Update();
        }
        //
        public DataTable ChitietDuAn_Doanhnghiep(string doanhnghiep)
        {
            SqlCommand cmd = new SqlCommand("Select DuAn.MaDuAn,DuAn.TenDuAn,DuAn.DiaDiemXayDung,DuAn.ThoiGian,DuAn.NangLucThietKe,DuAn.TongVon,LoaiDuAn.TenLoaiDuAn,DoanhNghiep.TenDoanhNghiep from DuAn,LoaiDuAn,DoanhNghiep where DuAn.MaLoaiDuAn=LoaiDuAn.MaLoaiDuAn and DuAn.MaDoanhNghiep=DoanhNghiep.MaDoanhNghiep and DuAn.MaDoanhNghiep=@doanhnghiep");
            cmd.Parameters.Add("doanhnghiep", SqlDbType.Int).Value = doanhnghiep;
            ds.Load(cmd);
            return ds;
        }
        public DataTable LayMaMax()
        {
            SqlCommand cmd = new SqlCommand("select Max(MaDuAn) from DuAn");
            ds.Load(cmd);
            return ds;
        }
        public object GetLastID()
        {
            if (this.ds == null)
            {
                this.ds = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM DuAn ORDER BY MaDuAn DESC");
            return ds.ExecuteScalar(cmd);
        }
        public void Xoa(QL_DuAn_InFo duan)
        {
            SqlCommand s = new SqlCommand("Delete from DuAn where MaDuAn = @ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = duan.MaDuAn;
            //ds.Load(s);
            //return ds;
            ds.Execute(s);
        }

        public void Them(QL_DuAn_InFo duan)
        {
            SqlCommand s = new SqlCommand("INSERT INTO DuAn(MaDuAn, TenDuAn, MaLoaiDuAn, DiaDiemXayDung, ThoiGian, NangLucThietKe, TongVon, MaDoanhNghiep) "
                                                        + "VALUES(@ma, @ten, @loai, @diadiem, @thoigian, @nangluc, @tongvon, @madoanhnghiep)");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = duan.MaDuAn;
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 255).Value = duan.TenDuAn;
            s.Parameters.Add("@loai", SqlDbType.Int).Value = duan.Loaiduan.MaLoaiDuAn;
            s.Parameters.Add("@diadiem", SqlDbType.NVarChar, 200).Value = duan.DiaDiemXayDung;
            s.Parameters.Add("@thoigian", SqlDbType.NVarChar, 50).Value = duan.ThoiGian;
            s.Parameters.Add("@nangluc", SqlDbType.NVarChar, 200).Value = duan.NangLucThietKe;
            s.Parameters.Add("@tongvon", SqlDbType.Int).Value = duan.TongVon;
            s.Parameters.Add("@madoanhnghiep", SqlDbType.Int).Value = duan.Doanhnghiep.MaDoanhNghiep;
            //ds.Load(s);
            //return ds;
            ds.Execute(s);
        }

        public void Sua(QL_DuAn_InFo duan)
        {
            SqlCommand s = new SqlCommand("Update DuAn set TenDuAn = @ten, MaLoaiDuAn = @loai, DiaDiemXayDung = @diadiem, ThoiGian = @thoigian, NanglucThietKe = @nangluc, TongVon = @tongvon, MaDoanhNghiep = @madoanhnghiep where MaDuAn = @ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = duan.MaDuAn;
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 255).Value = duan.TenDuAn;
            s.Parameters.Add("@loai", SqlDbType.Int).Value = duan.Loaiduan.MaLoaiDuAn;
            s.Parameters.Add("@diadiem", SqlDbType.NVarChar, 200).Value = duan.DiaDiemXayDung;
            s.Parameters.Add("@thoigian", SqlDbType.NVarChar, 50).Value = duan.ThoiGian;
            s.Parameters.Add("@nangluc", SqlDbType.NVarChar, 200).Value = duan.NangLucThietKe;
            s.Parameters.Add("@tongvon", SqlDbType.Int).Value = duan.TongVon;
            s.Parameters.Add("@madoanhnghiep", SqlDbType.Int).Value = duan.Doanhnghiep.MaDoanhNghiep;
            //ds.Load(s);
            //return ds;
            ds.Execute(s);
        }

    }
}
