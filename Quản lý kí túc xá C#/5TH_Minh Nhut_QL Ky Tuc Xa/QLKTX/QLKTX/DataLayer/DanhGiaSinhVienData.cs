using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLKTX.DataLayer
{
    public class DanhGiaSinhVienData
    {
        DataService ser = new DataService();             
        public DataTable LayDSSVThuocKTX_HocKi(string MaKTX,string MaHocKi)
        {
            SqlCommand com =new SqlCommand();
            string sql = "SELECT sv.GioiTinh,sv.HOTEN,sv.MAKTX,p.MAPHG, k.TENKTX,p.TENPHG,d.TENDAY "+
                "from KTX k,PHONG p,[DAY] d,DSSINHVIEN_PHONG ds , SINHVIEN sv "+
                "where k.KTX=d.KTX and d.MADAY =  p.MADAY and ds.MAPHG=p.MAPHG and ds.MAKTX=sv.MAKTX AND k.KTX=@maktx AND SV.MAKTX NOT IN (SELECT MAKTX FROM DANHGIASV WHERE DANHGIASV.MAHOCKI=@mahocki)";
            com.CommandText=sql;
            com.Parameters.Add("@maktx", SqlDbType.VarChar, 4).Value = MaKTX;
            com.Parameters.Add("@mahocki", SqlDbType.Int).Value = MaHocKi;
            ser.Load(com);
            return ser;
        }
        public DataTable LayDSSVThuocPhong_HocKi(string MaPHG, string MaHocKi)
        {
            SqlCommand com = new SqlCommand();
            string sql = "SELECT sv.GioiTinh,sv.HOTEN,sv.MAKTX,p.MAPHG, k.TENKTX,p.TENPHG,d.TENDAY " +
                "from KTX k,PHONG p,[DAY] d,DSSINHVIEN_PHONG ds , SINHVIEN sv " +
                "where k.KTX=d.KTX and d.MADAY =  p.MADAY and ds.MAPHG=p.MAPHG and ds.MAKTX=sv.MAKTX AND  p.MAPHG=@maphg AND SV.MAKTX NOT IN (SELECT MAKTX FROM DANHGIASV WHERE DANHGIASV.MAHOCKI=@mahocki)";
            com.CommandText = sql;
            com.Parameters.Add("@maphg", SqlDbType.VarChar, 4).Value = MaPHG;
            com.Parameters.Add("@mahocki", SqlDbType.Int).Value = MaHocKi;
            ser.Load(com);
            return ser;
        }
        public DataTable LayDSSVThuocDay_HocKi(string MaDay, string MaHocKi)
        {
            SqlCommand com = new SqlCommand();
            string sql = "SELECT sv.GioiTinh,sv.HOTEN,sv.MAKTX,p.MAPHG, k.TENKTX,p.TENPHG,d.TENDAY " +
                "from KTX k,PHONG p,[DAY] d,DSSINHVIEN_PHONG ds , SINHVIEN sv " +
                "where k.KTX=d.KTX and d.MADAY =  p.MADAY and ds.MAPHG=p.MAPHG and ds.MAKTX=sv.MAKTX AND  d.MADAY=@maday AND SV.MAKTX NOT IN (SELECT MAKTX FROM DANHGIASV WHERE DANHGIASV.MAHOCKI=@mahocki)";
            com.CommandText = sql;
            com.Parameters.Add("@maday", SqlDbType.VarChar, 4).Value = MaDay;
            com.Parameters.Add("@mahocki", SqlDbType.Int).Value = MaHocKi;
            ser.Load(com);
            return ser;
        }
        public void DanhGia(string MAKTX, string MAHOCKI, string MADANHGIA, string Tichcuc, string Tieucuc, string GhiChu)
        {
            SqlCommand com = new SqlCommand();
            string sql = "insert into DANHGIASV(MAKTX,MAHOCKI,MADANHGIA,TICHCUC,TIEUCUC,GHICHU) values(@maktx,@mahocki,@madanhgia,@tichcuc,@tieucuc,@ghichu)";
            com.CommandText = sql;
            com.Parameters.Add("@maktx", SqlDbType.VarChar, 7).Value = MAKTX;
            com.Parameters.Add("@mahocki", SqlDbType.Int).Value = MAHOCKI;
            com.Parameters.Add("@madanhgia", SqlDbType.Int).Value = MADANHGIA;
            com.Parameters.Add("@tichcuc", SqlDbType.NText).Value = Tichcuc;
            com.Parameters.Add("@tieucuc", SqlDbType.NText).Value = Tieucuc;
            com.Parameters.Add("@ghichu", SqlDbType.NText).Value = GhiChu;

            ser.Load(com);
        }
        public DataTable TimSinhVien_HocKi(string MaHocKi, string ten)
        {
            SqlCommand com = new SqlCommand();
            string sql = "SELECT sv.GioiTinh,sv.HOTEN,sv.MAKTX,p.MAPHG, k.TENKTX,p.TENPHG,d.TENDAY " +
                "from KTX k,PHONG p,[DAY] d,DSSINHVIEN_PHONG ds , SINHVIEN sv " +
                "where k.KTX=d.KTX and d.MADAY =  p.MADAY and ds.MAPHG=p.MAPHG and ds.MAKTX=sv.MAKTX AND sv.HOTEN LIKE '%"+ten+"%' AND SV.MAKTX NOT IN (SELECT MAKTX FROM DANHGIASV WHERE DANHGIASV.MAHOCKI=@mahocki)";
            com.CommandText = sql;            
            com.Parameters.Add("@mahocki", SqlDbType.Int).Value = MaHocKi;
            ser.Load(com);
            return ser;
        }
    }
}
