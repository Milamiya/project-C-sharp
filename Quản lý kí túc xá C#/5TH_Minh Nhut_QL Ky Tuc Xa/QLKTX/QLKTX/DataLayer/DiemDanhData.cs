using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLKTX.BusinessObject;

namespace QLKTX.DataLayer
{
    public class DiemDanhData
    {
        public DataTable Tim_DiemDanh_DK_KTX(string KTX)
        {
            DataService ser = new DataService();
            SqlCommand command = new SqlCommand("SELECT sv.HOTEN,sv.MAKTX,p.MAPHG, k.TENKTX,p.TENPHG,d.TENDAY from KTX k,PHONG p,[DAY] d,DSSINHVIEN_PHONG ds , SINHVIEN sv where k.KTX=d.KTX and d.MADAY =  p.MADAY and ds.MAPHG=p.MAPHG and ds.MAKTX=sv.MAKTX and k.KTX=@maktx");
            command.Parameters.Add("@maktx", SqlDbType.VarChar, 4).Value = KTX;
            ser.Load(command);
            return ser;
        }
        public DataTable Tim_DiemDanh_DK_Day(string day)
        {
            DataService ser = new DataService();
            SqlCommand command = new SqlCommand("SELECT sv.HOTEN,sv.MAKTX,p.MAPHG, k.TENKTX,p.TENPHG,d.TENDAY from KTX k,PHONG p,[DAY] d,DSSINHVIEN_PHONG ds , SINHVIEN sv where k.KTX=d.KTX and d.MADAY =  p.MADAY and ds.MAPHG=p.MAPHG and ds.MAKTX=sv.MAKTX and d.MaDAY=@day");
            command.Parameters.Add("@day", SqlDbType.VarChar, 4).Value = day;
            ser.Load(command);
            return ser;
        }
        public DataTable Tim_DiemDanh_DK_Phong(string Phong)
        {
            DataService ser = new DataService();
            SqlCommand command = new SqlCommand("SELECT sv.HOTEN,sv.MAKTX,p.MAPHG, k.TENKTX,p.TENPHG,d.TENDAY from KTX k,PHONG p,[DAY] d,DSSINHVIEN_PHONG ds , SINHVIEN sv where k.KTX=d.KTX and d.MADAY =  p.MADAY and ds.MAPHG=p.MAPHG and ds.MAKTX=sv.MAKTX and p.MaPHG=@phong");
            command.Parameters.Add("@phong", SqlDbType.VarChar, 4).Value = Phong;
            ser.Load(command);
            return ser;
        }
        public DataTable Tim_DiemDanh_DK_MAKTX(string MAKTX)
        {
            DataService ser = new DataService();
            SqlCommand command = new SqlCommand("SELECT sv.HOTEN,sv.MAKTX,p.MAPHG, k.TENKTX,p.TENPHG,d.TENDAY from KTX k,PHONG p,[DAY] d,DSSINHVIEN_PHONG ds , SINHVIEN sv where k.KTX=d.KTX and d.MADAY =  p.MADAY and ds.MAPHG=p.MAPHG and ds.MAKTX=sv.MAKTX and sv.MAKTX=@maktx");
            command.Parameters.Add("@maktx", SqlDbType.VarChar, 7).Value = MAKTX;
            ser.Load(command);
            return ser;
        }        
        public DataTable Them(DiemDanhInfo dd)
        {
            DataService ser = new DataService();
            SqlCommand command = new SqlCommand("INSERT INTO DIEMDANH(MAKTX,MAPHG,COPHEP,NGAYVANG) values(@maktx,@maphg,@cophep,@ngayvang)");
            command.Parameters.Add("@maktx", SqlDbType.VarChar, 7).Value = dd.SinhVien.MaKTX;
            command.Parameters.Add("@maphg", SqlDbType.VarChar, 4).Value = dd.Phong.MaPhong;
            command.Parameters.Add("@cophep", SqlDbType.Bit).Value = dd.CoPhep;
            command.Parameters.Add("@ngayvang", SqlDbType.DateTime).Value = dd.NgayVang;
            try
            {
                ser.Load(command);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hôm nay sinh viên "+dd.SinhVien.HoTen+" Điểm danh rồi");
            }
            return ser;
        }
    }
}
