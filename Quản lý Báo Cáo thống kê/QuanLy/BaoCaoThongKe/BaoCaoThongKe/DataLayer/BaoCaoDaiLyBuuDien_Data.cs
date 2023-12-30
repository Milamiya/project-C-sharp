using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class BaoCaoDaiLyBuuDien_Data
    {
        DataService ds = new DataService();
        public DataTable ChiTietBaoCao(string ma)
        {
            SqlCommand cmd = new SqlCommand("Select BaoCaoDaiLyBuuDien.MaBCDaiLyBuuDien,DaiLyBuuDien.TenDaiLy,DaiLyBuuDien.MaDaiLyBuuDien, Huyen.MaHuyen, Huyen.TenHuyen, DoanhNghiep.TenDoanhNghiep, Xa.TenXa,Xa.MaXa, DoanhNghiep.MaDoanhNghiep, DaiLyBuuDien.DiaChi,BaoCaoDaiLyBuuDien.DienThoai,BaoCaoDaiLyBuuDien.GhiChu from BaoCaoDaiLyBuuDien,DaiLyBuuDien,DoanhNghiep,Xa,Huyen where DoanhNghiep.MaDoanhNghiep=DaiLyBuuDien.MaDoanhNghiep and DaiLyBuuDien.MaDaiLyBuuDien=BaoCaoDaiLyBuuDien.MaDaiLyBuuDien and Xa.MaXa=DaiLyBuuDien.MaXa and Xa.MaHuyen=Huyen.MaHuyen and BaoCaoDaiLyBuuDien.MaBCDaiLyBuuDien=@ma");
            cmd.Parameters.Add("ma", SqlDbType.Int).Value = ma;
            ds.Load(cmd);
            return ds;
        }
        //public DataTable LayMaMax()
        //{
        //    SqlCommand cmd = new SqlCommand("select Max(MaBCTHTHDT) from BaoCaoTHTHDT");
        //    ds.Load(cmd);
        //    return ds;
        //}

        public void Update()
        {
            ds.Update();
        }

        public void Them(BaoCaoDaiLyBuuDien_InFo baocao)
        {
            SqlCommand cmd = new SqlCommand("insert into BaoCaoDaiLyBuuDien(MaBCDaiLyBuuDien,MaDaiLyBuuDien,DienThoai,GhiChu) values(@mabaocao,@madaily,@dienthoai,@ghichu)");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = baocao.Maubaocao.MaMauBaoCaoDaiLyBuuDien;
            cmd.Parameters.Add("madaily", SqlDbType.Int).Value = baocao.DaiLyBuuDien.MaDaiLyBuuDien;
            cmd.Parameters.Add("dienthoai", SqlDbType.Int).Value = baocao.DienThoai;
            cmd.Parameters.Add("ghichu", SqlDbType.NVarChar, 200).Value = baocao.Ghichu;
            ds.Execute(cmd);
        }

        public void Xoa(BaoCaoDaiLyBuuDien_InFo baocao)
        {
            SqlCommand cmd = new SqlCommand("delete from BaoCaoDaiLyBuuDien where MaBCDaiLyBuuDien=@mabaocao and MaDaiLyBuuDien=@madaily");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = baocao.Maubaocao.MaMauBaoCaoDaiLyBuuDien;
            cmd.Parameters.Add("madaily", SqlDbType.Int).Value = baocao.DaiLyBuuDien.MaDaiLyBuuDien;
            ds.Execute(cmd);
        }

        public void Sua(BaoCaoDaiLyBuuDien_InFo baocao)
        {
            SqlCommand cmd = new SqlCommand("update BaoCaoDaiLyBuuDien set DienThoai=@dienthoai,GhiChu=@ghichu where MaBCDaiLyBuuDien=@mabaocao and MaDaiLyBuuDien=@madaily");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = baocao.Maubaocao.MaMauBaoCaoDaiLyBuuDien;
            cmd.Parameters.Add("madaily", SqlDbType.Int).Value = baocao.DaiLyBuuDien.MaDaiLyBuuDien;
            cmd.Parameters.Add("dienthoai", SqlDbType.Int).Value = baocao.DienThoai;
            cmd.Parameters.Add("ghichu", SqlDbType.NVarChar, 200).Value = baocao.Ghichu;
            ds.Execute(cmd);
        }

        public void XoaToanBo(string ma)
        {
            SqlCommand cmd = new SqlCommand("delete from BaoCaoDaiLyBuuDien where MaBCDaiLyBuuDien=@mabaocao");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = ma;
            ds.Execute(cmd);
        }

        public DataTable Laybaocao_Buudien(string doanhnghiep, string loaibaocao, string nambaocao)
        {
            SqlCommand cmd = new SqlCommand("Select DaiLyBuuDien.TenDaiLy,DaiLyBuuDien.MaDaiLyBuuDien, Huyen.MaHuyen, Huyen.TenHuyen, DoanhNghiep.TenDoanhNghiep, Xa.TenXa,Xa.MaXa, DoanhNghiep.MaDoanhNghiep, DaiLyBuuDien.DiaChi,BaoCaoDaiLyBuuDien.DienThoai,BaoCaoDaiLyBuuDien.GhiChu from MauBaoCaoDaiLyBuuDien,BaoCaoDaiLyBuuDien,DaiLyBuuDien,DoanhNghiep,Xa,Huyen where DoanhNghiep.MaDoanhNghiep=DaiLyBuuDien.MaDoanhNghiep and DaiLyBuuDien.MaDaiLyBuuDien=BaoCaoDaiLyBuuDien.MaDaiLyBuuDien and Xa.MaXa=DaiLyBuuDien.MaXa and Xa.MaHuyen=Huyen.MaHuyen and MauBaoCaoDaiLyBuuDien.MaBCDaiLYBuuDien=BaoCaoDaiLyBuuDien.MaBCDaiLyBuuDien and DaiLyBuuDien.MaDoanhnghiep=@doanhnghiep and MauBaoCaoDaiLyBuuDien.MaLoaiBaoCao=@loaibaocao and MauBaoCaoDaiLyBuuDien.Nam=@nam ");
            cmd.Parameters.Add("doanhnghiep", SqlDbType.Int).Value = doanhnghiep;
            cmd.Parameters.Add("loaibaocao", SqlDbType.Int).Value = loaibaocao;
            cmd.Parameters.Add("nam", SqlDbType.Int).Value = nambaocao;
            ds.Load(cmd);
            return ds;
        }
    }
}
