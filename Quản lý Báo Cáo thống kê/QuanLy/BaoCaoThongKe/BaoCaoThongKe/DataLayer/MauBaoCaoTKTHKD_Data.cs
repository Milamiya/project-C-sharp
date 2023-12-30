using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class MauBaoCaoTKTHKD_Data
    {
        DataService ds = new DataService();
        public DataTable ChiTietMauBaoCao()
        {
            SqlCommand cmd = new SqlCommand("Select MauBaoCaoTKTHKD.MaBCTKTHKD,MauBaoCaoTKTHKD.TenBCTKTHKD,LoaiBaoCao.TenLoaiBaoCao,MauBaoCaoTKTHKD.Nam from MauBaoCaoTKTHKD,LoaiBaoCao where MauBaoCaoTKTHKD.MaLoaiBaoCao=LoaiBaoCao.MaLoaiBaoCao");
            ds.Load(cmd);
            return ds;
        }

        public DataTable LayMaMax()
        {
            SqlCommand cmd = new SqlCommand("select Max(MaBCTKTHKD) from MauBaoCaoTKTHKD");
            ds.Load(cmd);
            return ds;
        }

        public void Update()
        {
            ds.Update();
        }

        public void Them(MauBaoCaoTKTHKD_InFo maubaocao)
        {
            SqlCommand s = new SqlCommand("INSERT INTO MauBaoCaoTKTHKD(MaBCTKTHKD, TenBCTKTHKD, MaLoaiBaoCao, Nam) VALUES(@ma, @ten, @maloai, @nam)");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = maubaocao.Mamaubaocao;
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 200).Value = maubaocao.Tenbaocao;
            s.Parameters.Add("@maloai", SqlDbType.Int).Value = maubaocao.Loaibaocao.MaLoaiBaoCao;
            s.Parameters.Add("@nam", SqlDbType.Int).Value = maubaocao.Nambaocao;

            ds.Execute(s);
        }

        public void Xoa(MauBaoCaoTKTHKD_InFo maubaocao)
        {
            SqlCommand s = new SqlCommand("Delete from MauBaoCaoTKTHKD where MaBCTKTHKD = @ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = maubaocao.Mamaubaocao;

            ds.Execute(s);
        }

        public void Sua(MauBaoCaoTKTHKD_InFo maubaocao)
        {
            SqlCommand s = new SqlCommand("Update MauBaoCaoTKTHKD set TenBCTKTHKD=@ten, MaLoaiBaoCao=@maloai, Nam=@nam where MaBCTKTHKD=@ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = maubaocao.Mamaubaocao;
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 200).Value = maubaocao.Tenbaocao;
            s.Parameters.Add("@maloai", SqlDbType.Int).Value = maubaocao.Loaibaocao.MaLoaiBaoCao;
            s.Parameters.Add("@nam", SqlDbType.Int).Value = maubaocao.Nambaocao;

            ds.Execute(s);
        }
    }
}
