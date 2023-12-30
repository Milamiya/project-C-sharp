using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class DaiLyInternet_Data
    {
        DataService ds = new DataService();

        public DataTable ChiTietDaiLyInternet()
        {
            SqlCommand s = new SqlCommand("select * from DaiLyInternet");
            ds.Load(s);
            return ds;
        }
        public void Update()
        {
            ds.Update();
        }
        public object GetLastID()
        {
            if (this.ds == null)
            {
                this.ds = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM DaiLyInternet ORDER BY MaDaiLyInt DESC");
            return ds.ExecuteScalar(cmd);
        }
        //bao cao

        public DataTable ChitietInt_Huyen(string huyen, string doanhnghiep)
        {
            SqlCommand cmd = new SqlCommand("Select DaiLyInternet.MaDaiLyInt, DaiLyInternet.TenChuDaiLy, DaiLyInternet.DiaChi, DaiLyInternet.SoHieuDaiLy, DoanhNghiep.TenDoanhNghiep, DoanhNghiep.MaDoanhNghiep, Xa.TenXa, Huyen.TenHuyen "
                                        + " from DaiLyInternet, Xa, Huyen, DoanhNghiep "
                                        + " where DaiLyInternet.MaXa = Xa.MaXa and Huyen.MaHuyen = @huyen and DaiLyInternet.MaDoanhNghiep = DoanhNghiep.MaDoanhNghiep and DaiLyInternet.MaDoanhNghiep = @doanhnghiep order by TenHuyen");
            cmd.Parameters.Add("huyen", SqlDbType.Int).Value = huyen;
            cmd.Parameters.Add("doanhnghiep", SqlDbType.Int).Value = doanhnghiep;

            ds.Load(cmd);
            return ds;
        }

        public DataTable ChitietInt_Doanhnghiep(string doanhnghiep)
        {
            SqlCommand cmd = new SqlCommand("Select DISTINCT DaiLyInternet.MaDaiLyInt, DaiLyInternet.TenChuDaiLy, DaiLyInternet.DiaChi, DaiLyInternet.SoHieuDaiLy, DoanhNghiep.TenDoanhNghiep, DoanhNghiep.MaDoanhNghiep, Xa.TenXa, Huyen.TenHuyen "
                                        + " from DaiLyInternet, Xa, Huyen, DoanhNghiep "
                                        + " where DaiLyInternet.MaXa = Xa.MaXa and Huyen.MaHuyen = Xa.MaHuyen and DaiLyInternet.MaDoanhNghiep = DoanhNghiep.MaDoanhNghiep and DaiLyInternet.MaDoanhNghiep = @doanhnghiep order by TenHuyen");
            cmd.Parameters.Add("doanhnghiep", SqlDbType.Int).Value = doanhnghiep;

            ds.Load(cmd);
            return ds;
        }
        //
        public void Them_Int(DaiLyInternet_InFo Int)
        {
            SqlCommand cmd = new SqlCommand("insert into DaiLyInternet (MaDaiLyInt, TenChuDaiLy, MaXa, DiaChi, SoHieuDaiLy, MaDoanhNghiep) "
                                            + " values (@maInt, @tendailyInt, @xaInt, @diachiInt, @sohieu, @doanhnghiepInt)");
            cmd.Parameters.Add("@maInt", SqlDbType.Int).Value = Int.MaDaiLyInt;
            cmd.Parameters.Add("@tendailyInt", SqlDbType.NVarChar, 255).Value = Int.TenDaiLyInt;
            cmd.Parameters.Add("@diachiInt", SqlDbType.NVarChar, 50).Value = Int.DiaChiInt;
            cmd.Parameters.Add("@sohieu", SqlDbType.VarChar, 5).Value = Int.SoHieu;
            //cmd.Parameters.Add("@huyenInt", SqlDbType.Int).Value = Int.huyenInt.MaHuyen;
            cmd.Parameters.Add("@xaInt", SqlDbType.Int).Value = Int.xaInt.MaXa;
            cmd.Parameters.Add("@doanhnghiepInt", SqlDbType.Int).Value = Int.doanhnghiepInt.MaDoanhNghiep;
            ds.Load(cmd);
        }

        public void Xoa_Int(DaiLyInternet_InFo Int)
        {
            SqlCommand cmd = new SqlCommand("Delete DaiLyInternet where MaDaiLyInt = @maInt");
            cmd.Parameters.Add("@maInt", SqlDbType.Int).Value = Int.MaDaiLyInt;
            ds.Load(cmd);
        }

        public void Sua_Int(DaiLyInternet_InFo Int)
        {
            SqlCommand cmd = new SqlCommand("update DaiLyInternet set TenChuDaiLy = @tendailyInt, DiaChi = @diachiInt, SoHieuDaiLy=@sohieu "
                            + " MaXa = @xaInt, MaDoanhNghiep = @doanhnghiepInt where MaDaiLyInt = @maInt");
            cmd.Parameters.Add("@maInt", SqlDbType.Int).Value = Int.MaDaiLyInt;
            cmd.Parameters.Add("@tendailyInt", SqlDbType.NVarChar, 255).Value = Int.TenDaiLyInt;
            cmd.Parameters.Add("@diachiInt", SqlDbType.NVarChar, 50).Value = Int.DiaChiInt;
            cmd.Parameters.Add("@sohieu", SqlDbType.VarChar, 5).Value = Int.SoHieu;
            //cmd.Parameters.Add("@huyenInt", SqlDbType.Int).Value = Int.huyenInt.MaHuyen;
            cmd.Parameters.Add("@xaInt", SqlDbType.Int).Value = Int.xaInt.MaXa;
            cmd.Parameters.Add("@doanhnghiepInt", SqlDbType.Int).Value = Int.doanhnghiepInt.MaDoanhNghiep;

            ds.Load(cmd);
        }
        public DataTable LayMaMax()
        {
            SqlCommand cmd = new SqlCommand("select MAX(MaDaiLyInt) from DaiLyInternet");
            ds.Load(cmd);
            return ds;
        }
    }
}
