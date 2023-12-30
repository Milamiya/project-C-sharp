using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class BaoCaoBuuDienVanHoaXa_Data
    {
        DataService ds = new DataService();
        public DataTable ChiTietBaoCao_vhx(string ma)
        {
            SqlCommand cmd = new SqlCommand("Select BaoCaoDaiLyBuuDienVHX.MaBCDaiLyBuuDienVHX,DaiLyBuuDienVHX.TenDaiLyBuuDienVHX,DaiLyBuuDienVHX.MaDaiLyBuuDienVHX, Huyen.MaHuyen, Huyen.TenHuyen, DoanhNghiep.TenDoanhNghiep, Xa.TenXa,Xa.MaXa, DoanhNghiep.MaDoanhNghiep, DaiLyBuuDienVHX.DiaChi,BaoCaoDaiLyBuuDienVHX.DienThoai,BaoCaoDaiLyBuuDienVHX.GhiChu from BaoCaoDaiLyBuuDienVHX,DaiLyBuuDienVHX,DoanhNghiep,Xa,Huyen where DoanhNghiep.MaDoanhNghiep=DaiLyBuuDienVHX.MaDoanhNghiep and DaiLyBuuDienVHX.MaDaiLyBuuDienVHX=BaoCaoDaiLyBuuDienVHX.MaDaiLyBuuDienVHX and Xa.MaXa=DaiLyBuuDienVHX.MaXa and Xa.MaHuyen=Huyen.MaHuyen and BaoCaoDaiLyBuuDienVHX.MaBCDaiLyBuuDienVHX=@ma");
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

        public void Them(BaoCaoDaiLyBuuDienVHX_InFo baocao)
        {
            SqlCommand cmd = new SqlCommand("insert into BaoCaoDaiLyBuuDienVHX(MaBCDaiLyBuuDienVHX,MaDaiLyBuuDienVHX,DienThoai,GhiChu) values(@mabaocao,@madaily,@dienthoai,@ghichu)");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = baocao.Maubaocao.MaMauBaoCaoDaiLyBuuDien;
            cmd.Parameters.Add("madaily", SqlDbType.Int).Value = baocao.DaiLyBuuDien.MaDaiLyBuuDien;
            cmd.Parameters.Add("dienthoai", SqlDbType.NVarChar, 15).Value = baocao.DienThoai;
            cmd.Parameters.Add("ghichu", SqlDbType.NVarChar, 200).Value = baocao.Ghichu;
            ds.Execute(cmd);
        }

        public void Xoa(BaoCaoDaiLyBuuDienVHX_InFo baocao)
        {
            SqlCommand cmd = new SqlCommand("delete from BaoCaoDaiLyBuuDienVHX where MaBCDaiLyBuuDienVHX=@mabaocao and MaDaiLyBuuDienVHX=@madaily");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = baocao.Maubaocao.MaMauBaoCaoDaiLyBuuDien;
            cmd.Parameters.Add("madaily", SqlDbType.Int).Value = baocao.DaiLyBuuDien.MaDaiLyBuuDien;
            ds.Execute(cmd);
        }

        public void Sua(BaoCaoDaiLyBuuDienVHX_InFo baocao)
        {
            SqlCommand cmd = new SqlCommand("update BaoCaoDaiLyBuuDienVHX set DienThoai=@dienthoai,GhiChu=@ghichu where MaBCDaiLyBuuDienVHX=@mabaocao and MaDaiLyBuuDienVHX=@madaily");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = baocao.Maubaocao.MaMauBaoCaoDaiLyBuuDien;
            cmd.Parameters.Add("madaily", SqlDbType.Int).Value = baocao.DaiLyBuuDien.MaDaiLyBuuDien;
            cmd.Parameters.Add("dienthoai", SqlDbType.VarChar, 15).Value = baocao.DienThoai;
            cmd.Parameters.Add("ghichu", SqlDbType.NVarChar, 200).Value = baocao.Ghichu;
            ds.Execute(cmd);
        }

        public void XoaToanBo(string ma)
        {
            SqlCommand cmd = new SqlCommand("delete from BaoCaoDaiLyBuuDienVHX where MaBCDaiLyBuuDienVHX=@mabaocao");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = ma;
            ds.Execute(cmd);
        }

        public DataTable Laybaocao_BuudienVHX(string doanhnghiep, string loaibaocao, string nambaocao)
        {
            SqlCommand cmd = new SqlCommand("Select MauBaoCaoDaiLyBuuDienVHX.TenBCDaiLyBuuDienVHX,BaoCaoDaiLyBuuDienVHX.MaBCDaiLyBuuDienVHX,DaiLyBuuDienVHX.TenDaiLyBuuDienVHX,DaiLyBuuDienVHX.MaDaiLyBuuDienVHX, Huyen.MaHuyen, Huyen.TenHuyen, DoanhNghiep.TenDoanhNghiep, Xa.TenXa,Xa.MaXa, DoanhNghiep.MaDoanhNghiep, DaiLyBuuDienVHX.DiaChi,BaoCaoDaiLyBuuDienVHX.DienThoai,BaoCaoDaiLyBuuDienVHX.GhiChu from LoaiBaoCao,MauBaoCaoDaiLyBuuDienVHX,BaoCaoDaiLyBuuDienVHX,DaiLyBuuDienVHX,DoanhNghiep,Xa,Huyen where MauBaoCaoDaiLyBuuDienVHX.MaBCDaiLyBuuDienVHX=BaoCaoDaiLyBuuDienVHX.MaBCDaiLyBuuDienVHX and DoanhNghiep.MaDoanhNghiep=DaiLyBuuDienVHX.MaDoanhNghiep and DaiLyBuuDienVHX.MaDaiLyBuuDienVHX=BaoCaoDaiLyBuuDienVHX.MaDaiLyBuuDienVHX and Xa.MaXa=DaiLyBuuDienVHX.MaXa and Xa.MaHuyen=Huyen.MaHuyen and DoanhNghiep.MaDoanhNghiep=@doanhnghiep and LoaiBaoCao.MaLoaiBaoCao=@loaibaocao and MauBaoCaoDaiLyBuuDienVHX.Nam=@nam");
            cmd.Parameters.Add("doanhnghiep", SqlDbType.Int).Value = doanhnghiep;
            cmd.Parameters.Add("loaibaocao", SqlDbType.Int).Value = loaibaocao;
            cmd.Parameters.Add("nam", SqlDbType.Int).Value = nambaocao;
            ds.Load(cmd);
            return ds;
        }
    }
}
