using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class MauBaoCaoDaiLyBuuDienVHX_Data
    {
        DataService ds = new DataService();

        public DataTable LayMaMax()
        {
            SqlCommand cmd = new SqlCommand("select Max(MaBCDaiLyBuuDienVHX) from MauBaoCaoDaiLyBuuDienVHX");
            ds.Load(cmd);
            return ds;
        }
        //
        public DataTable ChiTietMauBaoCao_vhx()
        {
            SqlCommand cmd = new SqlCommand("Select MauBaoCaoDaiLyBuuDienVHX.MaBCDaiLyBuuDienVHX,MauBaoCaoDaiLyBuuDienVHX.TenBCDaiLyBuuDienVHX,LoaiBaoCao.TenLoaiBaoCao,MauBaoCaoDaiLyBuuDienVHX.Nam from MauBaoCaoDaiLyBuuDienVHX,LoaiBaoCao where MauBaoCaoDaiLyBuuDienVHX.MaLoaiBaoCao=LoaiBaoCao.MaLoaiBaoCao");
            ds.Load(cmd);
            return ds;
        }
        //
        public void Them_vhx(MauBaoCaoDaiLyBuuDienVHX_InFo maubaocao)
        {
            SqlCommand s = new SqlCommand("INSERT INTO MauBaoCaoDaiLyBuuDienVHX(MaBCDaiLyBuuDienVHX, TenBCDaiLyBuuDienVHX, MaLoaiBaoCao, Nam) VALUES(@ma, @ten, @maloai, @nam)");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = maubaocao.MaMauBaoCaoDaiLyBuuDien;
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 200).Value = maubaocao.Tenbaocao;
            s.Parameters.Add("@maloai", SqlDbType.Int).Value = maubaocao.Loaibaocao.MaLoaiBaoCao;
            s.Parameters.Add("@nam", SqlDbType.Int).Value = maubaocao.Nambaocao;

            ds.Execute(s);
        }

        public void Xoa_vhx(MauBaoCaoDaiLyBuuDienVHX_InFo maubaocao)
        {
            SqlCommand s = new SqlCommand("Delete from MauBaoCaoDaiLyBuuDienVHX where MaBCDaiLyBuuDienVHX = @ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = maubaocao.MaMauBaoCaoDaiLyBuuDien;

            ds.Execute(s);
        }
        //
        public void Update()
        {
            ds.Update();
        }
        //
        public void Sua_vhx(MauBaoCaoDaiLyBuuDienVHX_InFo maubaocao)
        {
            SqlCommand s = new SqlCommand("Update MauBaoCaoDaiLyBuuDienVHX set TenBCDaiLyBuuDienVHX=@ten, MaLoaiBaoCao=@maloai, Nam=@nam where MaBCDaiLyBuuDienVHX=@ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = maubaocao.MaMauBaoCaoDaiLyBuuDien;
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 200).Value = maubaocao.Tenbaocao;
            s.Parameters.Add("@maloai", SqlDbType.Int).Value = maubaocao.Loaibaocao.MaLoaiBaoCao;
            s.Parameters.Add("@nam", SqlDbType.Int).Value = maubaocao.Nambaocao;

            ds.Execute(s);
        }
    }
}
