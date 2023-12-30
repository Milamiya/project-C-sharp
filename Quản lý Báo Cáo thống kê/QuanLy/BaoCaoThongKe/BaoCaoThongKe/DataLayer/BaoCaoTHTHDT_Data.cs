using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class BaoCaoTHTHDT_Data
    {
        DataService ds = new DataService();
        public DataTable ChiTietBaoCao(string ma)
        {
            SqlCommand cmd = new SqlCommand("Select BaoCaoTHTHDT.MaBCTHTHDT,DuAn.TenDuAn,DuAn.MaDuAn, DuAn.ThoiGian, DoanhNghiep.TenDoanhNghiep, DoanhNghiep.MaDoanhNghiep, DuAn.DiaDiemXayDung,DuAn.NangLucThietKe,DuAn.TongVon,BaoCaoTHTHDT.VonDauTu,BaoCaoTHTHDT.LuyKeVonDauTu,BaoCaoTHTHDT.GhiChu,LoaiDuAn.TenLoaiDuAn from BaoCaoTHTHDT,DuAn,LoaiDuAn,DoanhNghiep where DoanhNghiep.MaDoanhNghiep=DuAn.MaDoanhNghiep and DuAn.MaDuAn=BaoCaoTHTHDT.MaDuAn and DuAn.MaLoaiDuAn=LoaiDuAn.MaLoaiDuAn and BaoCaoTHTHDT.MaBCTHTHDT=@ma");
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

        public void Them(BaoCaoTHTHDT_InFo baocao)
        {
            SqlCommand cmd = new SqlCommand("insert into BaoCaoTHTHDT(MaBCTHTHDT,MaDuAn,VonDauTu,LuyKeVonDauTu,GhiChu) values(@mabaocao,@maduan,@vondautu,@luykevon,@ghichu)");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = baocao.Maubaocao.Mamaubaocao;
            cmd.Parameters.Add("maduan", SqlDbType.Int).Value = baocao.Duan.MaDuAn;
            cmd.Parameters.Add("vondautu", SqlDbType.Int).Value = baocao.Vondautu;
            cmd.Parameters.Add("luykevon", SqlDbType.Int).Value = baocao.Luykevon;
            cmd.Parameters.Add("ghichu", SqlDbType.NVarChar, 200).Value = baocao.Ghichu;
            ds.Execute(cmd);
        }

        public void Xoa(BaoCaoTHTHDT_InFo baocao)
        {
            SqlCommand cmd = new SqlCommand("delete from BaoCaoTHTHDT where MaBCTHTHDT=@mabaocao and MaDuAn=@maduan");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = baocao.Maubaocao.Mamaubaocao;
            cmd.Parameters.Add("maduan", SqlDbType.Int).Value = baocao.Duan.MaDuAn;
            ds.Execute(cmd);
        }

        public void Sua(BaoCaoTHTHDT_InFo baocao)
        {
            SqlCommand cmd = new SqlCommand("update BaoCaoTHTHDT set VonDauTu=@vondautu,LuyKeVonDauTu=@luykevon,GhiChu=@ghichu where MaBCTHTHDT=@mabaocao and MaDuAn=@maduan");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = baocao.Maubaocao.Mamaubaocao;
            cmd.Parameters.Add("maduan", SqlDbType.Int).Value = baocao.Duan.MaDuAn;
            cmd.Parameters.Add("vondautu", SqlDbType.Int).Value = baocao.Vondautu;
            cmd.Parameters.Add("luykevon", SqlDbType.Int).Value = baocao.Luykevon;
            cmd.Parameters.Add("ghichu", SqlDbType.NVarChar, 200).Value = baocao.Ghichu;
            ds.Execute(cmd);
        }

        public void XoaToanBo(string ma)
        {
            SqlCommand cmd = new SqlCommand("delete from BaoCaoTHTHDT where MaBCTHTHDT = @mabaocao");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = ma;
            ds.Execute(cmd);
        }

        public DataTable Laybaocao_Duan_Nam(string doanhnghiep, string nambaocao)
        {
            SqlCommand cmd = new SqlCommand("Select BaoCaoTHTHDT.MaBCTHTHDT, DuAn.TenDuAn, DuAn.MaDuAn, LoaiBaoCao.TenLoaiBaoCao, DuAn.ThoiGian, DoanhNghiep.TenDoanhNghiep, DoanhNghiep.MaDoanhNghiep, DuAn.DiaDiemXayDung, "
                                + " DuAn.NangLucThietKe, DuAn.TongVon, BaoCaoTHTHDT.VonDauTu, BaoCaoTHTHDT.LuyKeVonDauTu, BaoCaoTHTHDT.GhiChu, LoaiDuAn.TenLoaiDuAn "
                                + " from LoaiBaoCao, BaoCaoTHTHDT, DuAn, LoaiDuAn, DoanhNghiep, MauBaoCaoTHTHDT "
                                + " where MauBaoCaoTHTHDT.MaBCTHTHDT = BaoCaoTHTHDT.MaBCTHTHDT and DoanhNghiep.MaDoanhNghiep = DuAn.MaDoanhNghiep and DuAn.MaDuAn = BaoCaoTHTHDT.MaDuAn and "
                                + " DuAn.MaLoaiDuAn = LoaiDuAn.MaLoaiDuAn and DoanhNghiep.MaDoanhNghiep = @doanhnghiep and MauBaoCaoTHTHDT.Nam = @nam and LoaiBaoCao.MaLoaiBaoCao = MauBaoCaoTHTHDT.MaLoaiBaoCao and LoaiBaoCao.MaLoaiBaoCao = @loaibaocao");
            cmd.Parameters.Add("doanhnghiep", SqlDbType.Int).Value = doanhnghiep;
            cmd.Parameters.Add("loaibaocao", SqlDbType.Int).Value = 4;
            cmd.Parameters.Add("nam", SqlDbType.Int).Value = nambaocao;
            ds.Load(cmd);
            return ds;
        }

        public DataTable Laybaocao_Duan_Qui(string doanhnghiep, string nambaocao, string quibaocao)
        {
            SqlCommand cmd = new SqlCommand("Select BaoCaoTHTHDT.MaBCTHTHDT, DuAn.TenDuAn, DuAn.MaDuAn, LoaiBaoCao.TenLoaiBaoCao, DuAn.ThoiGian, DoanhNghiep.TenDoanhNghiep, DoanhNghiep.MaDoanhNghiep, DuAn.DiaDiemXayDung, DuAn.NangLucThietKe, DuAn.TongVon, "
                            + " BaoCaoTHTHDT.VonDauTu, BaoCaoTHTHDT.LuyKeVonDauTu, BaoCaoTHTHDT.GhiChu, LoaiDuAn.TenLoaiDuAn "
                            + " from LoaiBaoCao, BaoCaoTHTHDT, DuAn, LoaiDuAn, DoanhNghiep, MauBaoCaoTHTHDT "
                            + " where MauBaoCaoTHTHDT.MaBCTHTHDT = BaoCaoTHTHDT.MaBCTHTHDT and DoanhNghiep.MaDoanhNghiep = DuAn.MaDoanhNghiep and DuAn.MaDuAn = BaoCaoTHTHDT.MaDuAn and DuAn.MaLoaiDuAn = LoaiDuAn.MaLoaiDuAn"
                            + " and DoanhNghiep.MaDoanhNghiep = @doanhnghiep and MauBaoCaoTHTHDT.Nam = @nam and LoaiBaoCao.MaLoaiBaoCao = MauBaoCaoTHTHDT.MaLoaiBaoCao and LoaiBaoCao.MaLoaiBaoCao = @loaibaocao and MauBaoCaoTHTHDT.Qui = @qui");
            cmd.Parameters.Add("doanhnghiep", SqlDbType.Int).Value = doanhnghiep;
            cmd.Parameters.Add("loaibaocao", SqlDbType.Int).Value = 2;
            cmd.Parameters.Add("nam", SqlDbType.Int).Value = nambaocao;
            cmd.Parameters.Add("qui", SqlDbType.Int).Value = quibaocao;
            ds.Load(cmd);
            return ds;
        }
    }
}
