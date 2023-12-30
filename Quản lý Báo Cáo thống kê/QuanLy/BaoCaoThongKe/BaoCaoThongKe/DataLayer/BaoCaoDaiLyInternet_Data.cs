using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class BaoCaoDaiLyInternet_Data
    {
        DataService ds = new DataService();
        public DataTable ChiTietBaoCao_Int(string maInt)
        {
            SqlCommand cmd = new SqlCommand("Select BaoCaoDaiLyInternet.MaBCDaiLyInternet,DaiLyInternet.TenChuDaiLy,DaiLyInternet.MaDaiLyInt, Huyen.MaHuyen, Huyen.TenHuyen, DoanhNghiep.TenDoanhNghiep, Xa.TenXa,Xa.MaXa, DoanhNghiep.MaDoanhNghiep, DaiLyInternet.DiaChi,BaoCaoDaiLyInternet.MaThueBao,NhomThueBao.TenThueBao,BaoCaoDaiLyInternet.DienThoai,DaiLyInternet.SoHieuDaiLy,BaoCaoDaiLyInternet.GhiChu from BaoCaoDaiLyInternet,DaiLyInternet,DoanhNghiep,Xa,Huyen, NhomThueBao where DoanhNghiep.MaDoanhNghiep=DaiLyInternet.MaDoanhNghiep and DaiLyInternet.MaDaiLyInt=BaoCaoDaiLyInternet.MaDaiLyInt and Xa.MaXa=DaiLyInternet.MaXa and Xa.MaHuyen=Huyen.MaHuyen and NhomThueBao.MaThueBao=BaoCaoDaiLyInternet.MaThueBao and BaoCaoDaiLyInternet.MaBCDaiLyInternet=@maInt");
            cmd.Parameters.Add("maInt", SqlDbType.Int).Value = maInt;
            ds.Load(cmd);
            return ds;
        }


        public void Update()
        {
            ds.Update();
        }

        public void Them_Int(BaoCaoDaiLyInternet_InFo baocaoInt)
        {
            SqlCommand cmd = new SqlCommand("insert into BaoCaoDaiLyInternet(MaBCDaiLyInternet,MaDaiLyInt,MaThueBao,DienThoai,GhiChu) values(@mabaocaoInt,@madailyInt,@thuebao,@dienthoaiInt,@ghichuInt)");
            cmd.Parameters.Add("mabaocaoInt", SqlDbType.Int).Value = baocaoInt.MaubaocaoInt.MaMauBaoCaoDaiLyInt;
            cmd.Parameters.Add("madailyInt", SqlDbType.Int).Value = baocaoInt.DaiLyInt.MaDaiLyInt;
            cmd.Parameters.Add("thuebao", SqlDbType.Int).Value = baocaoInt.ThueBao.MaThueBao;
            cmd.Parameters.Add("dienthoaiInt", SqlDbType.VarChar).Value = baocaoInt.DienThoaiInt;
            cmd.Parameters.Add("ghichuInt", SqlDbType.NVarChar, 200).Value = baocaoInt.GhichuInt;
            ds.Execute(cmd);
        }

        public void Xoa_Int(BaoCaoDaiLyInternet_InFo baocaoInt)
        {
            SqlCommand cmd = new SqlCommand("delete from BaoCaoDaiLyInternet where MaBCDaiLyInternet=@mabaocaoInt and MaDaiLyInt=@madailyInt");
            cmd.Parameters.Add("mabaocaoInt", SqlDbType.Int).Value = baocaoInt.MaubaocaoInt.MaMauBaoCaoDaiLyInt;
            cmd.Parameters.Add("madailyInt", SqlDbType.Int).Value = baocaoInt.DaiLyInt.MaDaiLyInt;
            ds.Execute(cmd);
        }

        public void Sua_Int(BaoCaoDaiLyInternet_InFo baocaoInt)
        {
            SqlCommand cmd = new SqlCommand("update BaoCaoDaiLyInternet set MaThueBao=@thuebao,DienThoai=@dienthoaiInt,GhiChu=@ghichuInt where MaBCDaiLyInternet=@mabaocaoInt and MaDaiLyInt=@madailyInt");
            cmd.Parameters.Add("mabaocaoInt", SqlDbType.Int).Value = baocaoInt.MaubaocaoInt.MaMauBaoCaoDaiLyInt;
            cmd.Parameters.Add("madailyInt", SqlDbType.Int).Value = baocaoInt.DaiLyInt.MaDaiLyInt;
            cmd.Parameters.Add("thuebao", SqlDbType.Int).Value = baocaoInt.ThueBao.MaThueBao;
            cmd.Parameters.Add("dienthoaiInt", SqlDbType.VarChar).Value = baocaoInt.DienThoaiInt;
            cmd.Parameters.Add("ghichuInt", SqlDbType.NVarChar, 200).Value = baocaoInt.GhichuInt;
            ds.Execute(cmd);
        }

        public void XoaToanBo_Int(string maInt)
        {
            SqlCommand cmd = new SqlCommand("delete from BaoCaoDaiLyInternet where MaBCDaiLyInternet=@mabaocaoInt");
            cmd.Parameters.Add("mabaocaoInt", SqlDbType.Int).Value = maInt;
            ds.Execute(cmd);
        }

        public DataTable Laybaocao_Internet(string doanhnghiep, string loaibaocao, string nambaocao)
        {
            SqlCommand cmd = new SqlCommand("Select MauBaoCaoDaiLyInternet.TenBCDaiLyInternet,BaoCaoDaiLyInternet.MaBCDaiLyInternet,DaiLyInternet.TenChuDaiLy,DaiLyInternet.MaDaiLyInt, Huyen.MaHuyen, Huyen.TenHuyen, DoanhNghiep.TenDoanhNghiep, Xa.TenXa,Xa.MaXa, DoanhNghiep.MaDoanhNghiep, DaiLyInternet.DiaChi,BaoCaoDaiLyInternet.MaThueBao,NhomThueBao.TenThueBao,BaoCaoDaiLyInternet.DienThoai,DaiLyInternet.SoHieuDaiLy,BaoCaoDaiLyInternet.GhiChu from MauBaoCaoDaiLyInternet,LoaiBaoCao,BaoCaoDaiLyInternet,DaiLyInternet,DoanhNghiep,Xa,Huyen, NhomThueBao where MauBaoCaoDaiLyInternet.MaBCDaiLyInternet=BaoCaoDaiLyInternet.MaBCDaiLyinternet and DoanhNghiep.MaDoanhNghiep=DaiLyInternet.MaDoanhNghiep and DaiLyInternet.MaDaiLyInt=BaoCaoDaiLyInternet.MaDaiLyInt and Xa.MaXa=DaiLyInternet.MaXa and Xa.MaHuyen=Huyen.MaHuyen and NhomThueBao.MaThueBao=BaoCaoDaiLyInternet.MaThueBao and DoanhNghiep.MaDoanhNghiep=@doanhnghiep and LoaiBaoCao.MaLoaiBaoCao=@loaibaocao and MauBaoCaoDaiLyInternet.Nam=@nam");
            cmd.Parameters.Add("doanhnghiep", SqlDbType.Int).Value = doanhnghiep;
            cmd.Parameters.Add("loaibaocao", SqlDbType.Int).Value = loaibaocao;
            cmd.Parameters.Add("nam", SqlDbType.Int).Value = nambaocao;
            ds.Load(cmd);
            return ds;
        }
    }
}
