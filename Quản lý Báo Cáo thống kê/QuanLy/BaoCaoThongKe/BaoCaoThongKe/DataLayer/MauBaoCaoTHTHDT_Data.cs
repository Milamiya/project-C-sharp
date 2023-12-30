using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class MauBaoCaoTHTHDT_Data
    {
        DataService ds = new DataService();
        public DataTable ChiTietMauBaoCao()
        {
            SqlCommand cmd = new SqlCommand("Select MauBaoCaoTHTHDT.MaBCTHTHDT,MauBaoCaoTHTHDT.TenBCTHTHDT,LoaiBaoCao.TenLoaiBaoCao,MauBaoCaoTHTHDT.Qui,MauBaoCaoTHTHDT.Nam from MauBaoCaoTHTHDT,LoaiBaoCao where MauBaoCaoTHTHDT.MaLoaiBaoCao=LoaiBaoCao.MaLoaiBaoCao");
            ds.Load(cmd);
            return ds;
        }

        public DataTable LayMaMax()
        {
            SqlCommand cmd = new SqlCommand("select Max(MaBCTHTHDT) from MauBaoCaoTHTHDT");
            ds.Load(cmd);
            return ds;
        }

        public void Update()
        {
            ds.Update();
        }

        public void Them(MauBaoCaoTHTHDT_InFo maubaocao)
        {
            SqlCommand s = new SqlCommand("INSERT INTO MauBaoCaoTHTHDT(MaBCTHTHDT, TenBCTHTHDT, MaLoaiBaoCao, Qui, Nam) VALUES(@ma, @ten, @maloai, @qui, @nam)");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = maubaocao.Mamaubaocao;
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 200).Value = maubaocao.Tenbaocao;
            s.Parameters.Add("@maloai", SqlDbType.Int).Value = maubaocao.Loaibaocao.MaLoaiBaoCao;
            s.Parameters.Add("@qui", SqlDbType.Int).Value = maubaocao.Quibaocao;
            s.Parameters.Add("@nam", SqlDbType.Int).Value = maubaocao.Nambaocao;

            ds.Execute(s);
        }

        public void Xoa(MauBaoCaoTHTHDT_InFo maubaocao)
        {
            SqlCommand s = new SqlCommand("Delete from MauBaoCaoTHTHDT where MaBCTHTHDT = @ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = maubaocao.Mamaubaocao;

            ds.Execute(s);
        }

        public void Sua(MauBaoCaoTHTHDT_InFo maubaocao)
        {
            SqlCommand s = new SqlCommand("Update MauBaoCaoTHTHDT set TenBCTHTHDT=@ten, MaLoaiBaoCao=@maloai, Qui=@qui, Nam=@nam where MaBCTHTHDT=@ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = maubaocao.Mamaubaocao;
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 200).Value = maubaocao.Tenbaocao;
            s.Parameters.Add("@maloai", SqlDbType.Int).Value = maubaocao.Loaibaocao.MaLoaiBaoCao;
            s.Parameters.Add("@qui", SqlDbType.Int).Value = maubaocao.Quibaocao;
            s.Parameters.Add("@nam", SqlDbType.Int).Value = maubaocao.Nambaocao;

            ds.Execute(s);
        }
    }
}
