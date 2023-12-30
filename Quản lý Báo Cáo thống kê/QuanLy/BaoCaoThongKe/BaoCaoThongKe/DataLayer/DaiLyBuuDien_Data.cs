using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class DaiLyBuuDien_Data
    {
        DataService ds = new DataService();

        public DataTable ChiTietDaiLyBuuDien()
        {
            SqlCommand s = new SqlCommand("select * from DaiLyBuuDien");
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM DaiLyBuuDien ORDER BY MaDaiLyBuuDien DESC");
            return ds.ExecuteScalar(cmd);
        }
        //bao cao
        public DataTable ChitietDaiLy_Huyen(string huyen, string doanhnghiep)
        {
            SqlCommand cmd = new SqlCommand("Select DaiLyBuuDien.MaDaiLyBuuDien, DaiLyBuuDien.TenDaiLy, DaiLyBuuDien.DiaChi, DoanhNghiep.TenDoanhNghiep, DoanhNghiep.MaDoanhNghiep, Xa.TenXa, Huyen.TenHuyen "
                                    + " from DaiLyBuuDien, Xa, Huyen, DoanhNghiep where DaiLyBuuDien.MaXa = Xa.MaXa and Huyen.MaHuyen = Xa.MaHuyen and Huyen.MaHuyen = @huyen and DaiLyBuuDien.MaDoanhNghiep = DoanhNghiep.MaDoanhNghiep and DaiLyBuuDien.MaDoanhNghiep = @doanhnghiep");
            cmd.Parameters.Add("@huyen", SqlDbType.Int).Value = huyen;
            cmd.Parameters.Add("@doanhnghiep", SqlDbType.Int).Value = doanhnghiep;

            ds.Load(cmd);
            return ds;
        }
        //bao cao doanh nghiep
        public DataTable ChitietDaiLy_Doanhnghiep(string doanhnghiep)
        {
            SqlCommand cmd = new SqlCommand("Select DaiLyBuuDien.MaDaiLyBuuDien, DaiLyBuuDien.TenDaiLy, DaiLyBuuDien.DiaChi, DoanhNghiep.TenDoanhNghiep, DoanhNghiep.MaDoanhNghiep, Xa.TenXa, Huyen.TenHuyen"
                                            + " from DaiLyBuuDien, Xa, Huyen, DoanhNghiep where DaiLyBuuDien.MaXa = Xa.MaXa and Xa.MaHuyen = Huyen.MaHuyen and DaiLyBuuDien.MaDoanhNghiep = DoanhNghiep.MaDoanhNghiep and DaiLyBuuDien.MaDoanhNghiep = @doanhnghiep");
            cmd.Parameters.Add("@doanhnghiep", SqlDbType.Int).Value = doanhnghiep;

            ds.Load(cmd);
            return ds;
        }
        //
        public void Them(DaiLyBuuDien_InFo Buudien)
        {
            SqlCommand cmd = new SqlCommand("insert into DaiLyBuuDien (MaDaiLyBuuDien, TenDaiLy, DiaChi, MaXa, MaDoanhNghiep) "
                                            + " values (@ma, @tendaily, @diachi, @xa, @doanhnghiep)");
            cmd.Parameters.Add("@ma", SqlDbType.Int).Value = Buudien.MaDaiLyBuuDien;
            cmd.Parameters.Add("@tendaily", SqlDbType.NVarChar, 255).Value = Buudien.TenDaiLy;
            cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 50).Value = Buudien.DiaChi;
            //cmd.Parameters.Add("@dienthoai", SqlDbType.VarChar, 15).Value = Buudien.DienThoai;            
            //cmd.Parameters.Add("@ghichu", SqlDbType.NVarChar, 50).Value = Buudien.GhiChu;            
            cmd.Parameters.Add("@xa", SqlDbType.Int).Value = Buudien.xa.MaXa;
            cmd.Parameters.Add("@doanhnghiep", SqlDbType.Int).Value = Buudien.doanhnghiep.MaDoanhNghiep;
            ds.Load(cmd);
        }

    }
}
