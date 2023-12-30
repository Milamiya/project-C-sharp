using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class MauBaoCaoDaiLyBuuDien_Data
    {
        DataService ds = new DataService();
        public DataTable ChiTietMauBaoCao()
        {
            SqlCommand cmd = new SqlCommand("Select MauBaoCaoDaiLyBuuDien.MaBCDaiLyBuuDien,MauBaoCaoDaiLyBuuDien.TenBCDaiLyBuuDien,LoaiBaoCao.TenLoaiBaoCao,MauBaoCaoDaiLyBuuDien.Nam from MauBaoCaoDaiLyBuuDien,LoaiBaoCao where MauBaoCaoDaiLyBuuDien.MaLoaiBaoCao=LoaiBaoCao.MaLoaiBaoCao");
            ds.Load(cmd);
            return ds;
        }

        public DataTable LayMaMax()
        {
            SqlCommand cmd = new SqlCommand("select Max(MaBCDaiLyBuuDien) from MauBaoCaoDaiLyBuuDien");
            ds.Load(cmd);
            return ds;
        }

        public void Update()
        {
            ds.Update();
        }

        public void Them(MauBaoCaoDaiLyBuuDien_InFo maubaocao)
        {
            SqlCommand s = new SqlCommand("INSERT INTO MauBaoCaoDaiLyBuuDien(MaBCDaiLyBuuDien, TenBCDaiLyBuuDien, MaLoaiBaoCao, Nam) VALUES(@ma, @ten, @maloai, @nam)");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = maubaocao.MaMauBaoCaoDaiLyBuuDien;
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 200).Value = maubaocao.Tenbaocao;
            s.Parameters.Add("@maloai", SqlDbType.Int).Value = maubaocao.Loaibaocao.MaLoaiBaoCao;
            s.Parameters.Add("@nam", SqlDbType.Int).Value = maubaocao.Nambaocao;

            ds.Execute(s);
        }

        public void Xoa(MauBaoCaoDaiLyBuuDien_InFo maubaocao)
        {
            SqlCommand s = new SqlCommand("Delete from MauBaoCaoDaiLyBuuDien where MaBCDaiLyBuuDien = @ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = maubaocao.MaMauBaoCaoDaiLyBuuDien;

            ds.Execute(s);
        }

        public void Sua(MauBaoCaoDaiLyBuuDien_InFo maubaocao)
        {
            SqlCommand s = new SqlCommand("Update MauBaoCaoDaiLyBuuDien set TenBCDaiLyBuuDien=@ten, MaLoaiBaoCao=@maloai, Nam=@nam where MaBCDaiLyBuuDien=@ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = maubaocao.MaMauBaoCaoDaiLyBuuDien;
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 200).Value = maubaocao.Tenbaocao;
            s.Parameters.Add("@maloai", SqlDbType.Int).Value = maubaocao.Loaibaocao.MaLoaiBaoCao;
            s.Parameters.Add("@nam", SqlDbType.Int).Value = maubaocao.Nambaocao;

            ds.Execute(s);
        }
    }
}
