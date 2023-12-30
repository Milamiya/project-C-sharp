using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class DaiLyBuuDienVHX_Data
    {
        DataService ds = new DataService();

        public DataTable ChitietBDVanHoaXa()
        {
            SqlCommand cmd = new SqlCommand("select * from DaiLyBuuDienVHX");
            ds.Load(cmd);
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM DaiLyBuuDienVHX ORDER BY MaDaiLyBuuDienVHX DESC");
            return ds.ExecuteScalar(cmd);
        }
        //bao cao
        public DataTable ChitietDaiLy_Huyen(string huyen, string doanhnghiep)
        {
            SqlCommand cmd = new SqlCommand("Select DaiLyBuuDienVHX.MaDaiLyBuuDienVHX, DaiLyBuuDienVHX.TenDaiLyBuuDienVHX, DaiLyBuuDienVHX.DiaChi, DoanhNghiep.TenDoanhNghiep, DoanhNghiep.MaDoanhNghiep, "
                                    + " Xa.TenXa, Huyen.TenHuyen from DaiLyBuuDienVHX, Xa, Huyen, DoanhNghiep "
                                    + " where DaiLyBuuDienVHX.MaXa = Xa.MaXa and Xa.MaHuyen = Huyen.MaHuyen and Huyen.MaHuyen = @huyen and DaiLyBuuDienVHX.MaDoanhNghiep = DoanhNghiep.MaDoanhNghiep and DaiLyBuuDienVHX.MaDoanhNghiep = @doanhnghiep");
            cmd.Parameters.Add("@huyen", SqlDbType.Int).Value = huyen;
            cmd.Parameters.Add("@doanhnghiep", SqlDbType.Int).Value = doanhnghiep;

            ds.Load(cmd);
            return ds;
        }
        public DataTable ChitietDaiLy_Doanhnghiep(string doanhnghiep)
        {
            SqlCommand cmd = new SqlCommand("Select DISTINCT DaiLyBuuDienVHX.MaDaiLyBuuDienVHX, DaiLyBuuDienVHX.TenDaiLyBuuDienVHX, DaiLyBuuDienVHX.DiaChi, DoanhNghiep.TenDoanhNghiep, DoanhNghiep.MaDoanhNghiep, "
                                    + " Xa.TenXa, Huyen.TenHuyen from DaiLyBuuDienVHX, Xa, Huyen, DoanhNghiep"
                                    + " where DaiLyBuuDienVHX.MaXa = Xa.MaXa and Xa.MaHuyen = Huyen.MaHuyen and DaiLyBuuDienVHX.MaDoanhNghiep = DoanhNghiep.MaDoanhNghiep and DaiLyBuuDienVHX.MaDoanhNghiep = @doanhnghiep");
            cmd.Parameters.Add("@doanhnghiep", SqlDbType.Int).Value = doanhnghiep;

            ds.Load(cmd);
            return ds;
        }
        public DataTable LayMaMax()
        {
            SqlCommand cmd = new SqlCommand("select MAX(MaDaiLyBuuDienVHX) from DaiLyBuuDienVHX");
            ds.Load(cmd);
            return ds;
        }
        public void Them_vhx(DaiLyBuuDienVHX_InFo Buudien)
        {
            SqlCommand cmd = new SqlCommand("insert into DaiLyBuuDienVHX (MaDaiLyBuuDienVHX, TenDaiLyBuuDienVHX, MaHuyen, MaXa,DiaChi,MaDoanhNghiep) "
                                            + " values (@ma, @tendaily, @huyen, @xa, @diachi,@doanhnghiep)");
            cmd.Parameters.Add("@ma", SqlDbType.Int).Value = Buudien.MaDaiLyBuuDien;
            cmd.Parameters.Add("@tendaily", SqlDbType.NVarChar, 50).Value = Buudien.TenDaiLy;
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 50).Value = Buudien.DiaChi;
            //cmd.Parameters.Add("@dienthoai", SqlDbType.VarChar, 15).Value = Buudien.DienThoai;
            //cmd.Parameters.Add("@ghichu", SqlDbType.NVarChar, 50).Value = Buudien.GhiChu;
            cmd.Parameters.Add("@huyen", SqlDbType.Int).Value = Buudien.huyen.MaHuyen;
            cmd.Parameters.Add("@xa", SqlDbType.Int).Value = Buudien.xa.MaXa;
            cmd.Parameters.Add("@doanhnghiep", SqlDbType.Int).Value = Buudien.doanhnghiep.MaDoanhNghiep;
            ds.Load(cmd);
        }

        public void Xoa_vhx(DaiLyBuuDienVHX_InFo Buudien)
        {
            SqlCommand cmd = new SqlCommand("Delete DaiLyBuuDienVHX where MaDaiLyBuuDien = @ma");
            cmd.Parameters.Add("@ma", SqlDbType.Int).Value = Buudien.MaDaiLyBuuDien;
            ds.Load(cmd);
        }

        public void Sua_vhx(DaiLyBuuDienVHX_InFo Buudien)
        {
            SqlCommand cmd = new SqlCommand("update DaiLyBuuDienVHX set TenDaiLyBuuDienVHX = @tendaily, DiaChi = @diachi, "
                            + "MaHuyen=@huyen MaXa = @xa, MaDoanhNghiep=@doanhnghiep where MaDaiLyBuuDienVHX = @ma");
            cmd.Parameters.Add("@ma", SqlDbType.Int).Value = Buudien.MaDaiLyBuuDien;
            cmd.Parameters.Add("@tendaily", SqlDbType.NVarChar, 50).Value = Buudien.TenDaiLy;
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 50).Value = Buudien.DiaChi;
            // cmd.Parameters.Add("@dienthoai", SqlDbType.VarChar, 15).Value = Buudien.DienThoai;
            // cmd.Parameters.Add("@ghichu", SqlDbType.NVarChar, 50).Value = Buudien.GhiChu;
            cmd.Parameters.Add("@huyen", SqlDbType.Int).Value = Buudien.huyen.MaHuyen;
            cmd.Parameters.Add("@xa", SqlDbType.Int).Value = Buudien.xa.MaXa;
            cmd.Parameters.Add("@doanhnghiep", SqlDbType.Int).Value = Buudien.doanhnghiep.MaDoanhNghiep;

            ds.Load(cmd);
        }
    }
}
