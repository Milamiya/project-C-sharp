using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class MauBaoCaoDaiLyInternet_Data
    {
        DataService ds = new DataService();
        public DataTable ChiTietMauBaoCao_Int()
        {
            SqlCommand cmd = new SqlCommand("Select MauBaoCaoDaiLyInternet.MaBCDaiLyInternet,MauBaoCaoDaiLyInternet.TenBCDaiLyInternet,LoaiBaoCao.TenLoaiBaoCao,MauBaoCaoDaiLyInternet.Nam from MauBaoCaoDaiLyInternet,LoaiBaoCao where MauBaoCaoDaiLyInternet.MaLoaiBaoCao=LoaiBaoCao.MaLoaiBaoCao");
            ds.Load(cmd);
            return ds;
        }

        public DataTable LayMaMax()
        {
            SqlCommand cmd = new SqlCommand("select Max(MaBCDaiLyInternet) from MauBaoCaoDaiLyInternet");
            ds.Load(cmd);
            return ds;
        }

        public void Update()
        {
            ds.Update();
        }

        public void Them_Int(MauBaoCaoDaiLyInternet_InFo maubaocaoInt)
        {
            SqlCommand s = new SqlCommand("INSERT INTO MauBaoCaoDaiLyInternet(MaBCDaiLyInternet, TenBCDaiLyInternet, MaLoaiBaoCao, Nam) VALUES(@maInt, @tenInt, @maloaiInt, @namInt)");
            s.Parameters.Add("@maInt", SqlDbType.Int).Value = maubaocaoInt.MaMauBaoCaoDaiLyInt;
            s.Parameters.Add("@tenInt", SqlDbType.NVarChar, 200).Value = maubaocaoInt.TenbaocaoInt;
            s.Parameters.Add("@maloaiInt", SqlDbType.Int).Value = maubaocaoInt.LoaibaocaoInt.MaLoaiBaoCao;
            s.Parameters.Add("@namInt", SqlDbType.Int).Value = maubaocaoInt.NambaocaoInt;

            ds.Execute(s);
        }

        public void Xoa_Int(MauBaoCaoDaiLyInternet_InFo maubaocaoInt)
        {
            SqlCommand s = new SqlCommand("Delete from MauBaoCaoDaiLyInternet where MaBCDaiLyInternet = @maInt");
            s.Parameters.Add("@maInt", SqlDbType.Int).Value = maubaocaoInt.MaMauBaoCaoDaiLyInt;

            ds.Execute(s);
        }

        public void Sua_Int(MauBaoCaoDaiLyInternet_InFo maubaocaoInt)
        {
            SqlCommand s = new SqlCommand("Update MauBaoCaoDaiLyInternet set TenBCDaiLyInternet=@tenInt, MaLoaiBaoCao=@maloaiInt, Nam=@namInt where MaBCDaiLyInternet=@maInt");
            s.Parameters.Add("@maInt", SqlDbType.Int).Value = maubaocaoInt.MaMauBaoCaoDaiLyInt;
            s.Parameters.Add("@tenInt", SqlDbType.NVarChar, 200).Value = maubaocaoInt.TenbaocaoInt;
            s.Parameters.Add("@maloaiInt", SqlDbType.Int).Value = maubaocaoInt.LoaibaocaoInt.MaLoaiBaoCao;
            s.Parameters.Add("@namInt", SqlDbType.Int).Value = maubaocaoInt.NambaocaoInt;
            ds.Execute(s);
        }
    }
}
