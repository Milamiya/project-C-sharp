using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class MauBaoCaoTHTHCLDV_Data
    {
        DataService ds = new DataService();
        public DataTable ChiTietMauBaoCao()
        {
            SqlCommand cmd = new SqlCommand("Select MauBaoCaoTHTHCLDV.MaBCTHTHCLDV, MauBaoCaoTHTHCLDV.TenBCTHTHCLDV, LoaiBaoCao.TenLoaiBaoCao, MauBaoCaoTHTHCLDV.Nam "
                                    + " from MauBaoCaoTHTHCLDV, LoaiBaoCao where MauBaoCaoTHTHCLDV.MaLoaiBaoCao = LoaiBaoCao.MaLoaiBaoCao");
            ds.Load(cmd);
            return ds;
        }

        public DataTable LayMaMax()
        {
            SqlCommand cmd = new SqlCommand("select Max(MaBCTHTHCLDV) from MauBaoCaoTHTHCLDV");
            ds.Load(cmd);
            return ds;
        }

        public void Update()
        {
            ds.Update();
        }

        public void Them(MauBaoCaoTHTHCLDV_InFo maubaocao)
        {
            SqlCommand s = new SqlCommand("INSERT INTO MauBaoCaoTHTHCLDV(MaBCTHTHCLDV, TenBCTHTHCLDV, MaLoaiBaoCao, Nam) VALUES(@ma, @ten, @maloai, @nam)");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = maubaocao.Mamaubaocao;
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 200).Value = maubaocao.Tenbaocao;
            s.Parameters.Add("@maloai", SqlDbType.Int).Value = maubaocao.Loaibaocao.MaLoaiBaoCao ;
            s.Parameters.Add("@nam", SqlDbType.Int).Value = maubaocao.Nambaocao;

            ds.Execute(s);
        }

        public void Xoa(MauBaoCaoTHTHCLDV_InFo maubaocao)
        {
            SqlCommand s = new SqlCommand("Delete from MauBaoCaoTHTHCLDV where MaBCTHTHCLDV = @ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = maubaocao.Mamaubaocao;

            ds.Execute(s);
        }

        public void Sua(MauBaoCaoTHTHCLDV_InFo maubaocao)
        {
            SqlCommand s = new SqlCommand("Update MauBaoCaoTHTHCLDV set TenBCTHTHCLDV=@ten, MaLoaiBaoCao=@maloai, Nam=@nam where MaBCTHTHCLDV=@ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = maubaocao.Mamaubaocao;
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 200).Value = maubaocao.Tenbaocao;
            s.Parameters.Add("@maloai", SqlDbType.Int).Value = maubaocao.Loaibaocao.MaLoaiBaoCao;
            s.Parameters.Add("@nam", SqlDbType.Int).Value = maubaocao.Nambaocao;

            ds.Execute(s);
        }
    }
}
