using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using System.Data.SqlClient;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class BaoCaoTKTHKD_Data
    {
        DataService ds = new DataService();
        public DataTable ChiTietBaoCao(string ma)
        {
            SqlCommand cmd = new SqlCommand("Select BaoCaoTKTHKD.MaBCTKTHKD,CongTrinhVienThong.TenCongTrinh,CongTrinhVienThong.MaCongTrinh, DoanhNghiep.TenDoanhNghiep,DoanhNghiep.MaDoanhNghiep, BaoCaoTKTHKD.SoLuong, BaoCaoTKTHKD.GhiChu ,LoaiCongTrinh.TenLoaiCongTrinh from BaoCaoTKTHKD,CongTrinhVienThong,LoaiCongTrinh,DoanhNghiep where DoanhNghiep.MaDoanhNghiep=CongTrinhVienThong.MaDoanhNghiep and CongTrinhVienthong.MaCongTrinh=BaoCaoTKTHKD.MaCongTrinh and CongTrinhVienThong.MaLoaiCongTrinh=LoaiCongTrinh.MaLoaiCongTrinh and BaoCaoTKTHKD.MaBCTKTHKD=@ma");
            cmd.Parameters.Add("ma", SqlDbType.Int).Value = ma;
            ds.Load(cmd);
            return ds;
        }

        public void Update()
        {
            ds.Update();
        }
       
        public void Them(BaoCaoTKTHKD_InFo baocao)
        {
            SqlCommand cmd = new SqlCommand("insert into BaoCaoTKTHKD(MaBCTKTHKD,MaCongTrinh,SoLuong,GhiChu) values(@mabaocao,@macongtrinh,@soluong,@ghichu)");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = baocao.Maubaocao.Mamaubaocao;
            cmd.Parameters.Add("macongtrinh", SqlDbType.Int).Value = baocao.Congtrinh.MaCongTrinh;
            cmd.Parameters.Add("soluong", SqlDbType.Int).Value = baocao.Soluong;
            cmd.Parameters.Add("ghichu", SqlDbType.NVarChar, 200).Value = baocao.Ghichu;
            ds.Execute(cmd);
        }

        public void Xoa(BaoCaoTKTHKD_InFo baocao)
        {
            SqlCommand cmd = new SqlCommand("delete from BaoCaoTKTHKD where MaBCTKTHKD=@mabaocao and MaCongTrinh=@macongtrinh");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = baocao.Maubaocao.Mamaubaocao;
            cmd.Parameters.Add("macongtrinh", SqlDbType.Int).Value = baocao.Congtrinh.MaCongTrinh;
            ds.Execute(cmd);
        }

        public void Sua(BaoCaoTKTHKD_InFo baocao)
        {
            SqlCommand cmd = new SqlCommand("Update BaoCaoTKTHKD set SoLuong=@soluong,GhiChu=@ghichu where MaBCTKTHKD=@mabaocao and MaCongTrinh=@macongtrinh");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = baocao.Maubaocao.Mamaubaocao;
            cmd.Parameters.Add("macongtrinh", SqlDbType.Int).Value = baocao.Congtrinh.MaCongTrinh;
            cmd.Parameters.Add("soluong", SqlDbType.Int).Value = baocao.Soluong;
            cmd.Parameters.Add("ghichu", SqlDbType.NVarChar, 200).Value = baocao.Ghichu;
            ds.Execute(cmd);
        }

        public void XoaToanBo(string ma)
        {
            SqlCommand cmd = new SqlCommand("delete from BaoCaoTKTHKD where MaBCTKTHKD=@mabaocao");
            cmd.Parameters.Add("mabaocao", SqlDbType.Int).Value = ma;
            ds.Execute(cmd);
        }

        public DataTable Laybaocao_CTVT(string doanhnghiep, string loaibaocao, string nambaocao, string loaicongtrinh)
        {
            SqlCommand cmd = new SqlCommand("Select MauBaoCaoTKTHKD.TenBCTKTHKD,BaoCaoTKTHKD.MaBCTKTHKD,CongTrinhVienThong.TenCongTrinh,CongTrinhVienThong.MaCongTrinh, DoanhNghiep.TenDoanhNghiep,DoanhNghiep.MaDoanhNghiep, BaoCaoTKTHKD.SoLuong, BaoCaoTKTHKD.GhiChu ,LoaiCongTrinh.TenLoaiCongTrinh from MauBaoCaoTKTHKD,BaoCaoTKTHKD,CongTrinhVienThong,LoaiCongTrinh,DoanhNghiep where DoanhNghiep.MaDoanhNghiep=CongTrinhVienThong.MaDoanhNghiep and CongTrinhVienthong.MaCongTrinh=BaoCaoTKTHKD.MaCongTrinh and CongTrinhVienThong.MaLoaiCongTrinh=LoaiCongTrinh.MaLoaiCongTrinh and MauBaoCaoTKTHKD.MaBCTKTHKD=BaoCaoTKTHKD.MaBCTKTHKD and DoanhNghiep.MaDoanhNghiep=@doanhnghiep and MauBaoCaoTKTHKD.MaLoaiBaoCao=@loaibaocao and MauBaoCaoTKTHKD.Nam=@nam and LoaiCongTrinh.MaLoaiCongTrinh=@loaicongtrinh");
            cmd.Parameters.Add("doanhnghiep", SqlDbType.Int).Value = doanhnghiep;
            cmd.Parameters.Add("loaibaocao", SqlDbType.Int).Value = loaibaocao;
            cmd.Parameters.Add("nam", SqlDbType.Int).Value = nambaocao;
            cmd.Parameters.Add("loaicongtrinh", SqlDbType.Int).Value = loaicongtrinh;
            ds.Load(cmd);
            return ds;
        }

    }
}
