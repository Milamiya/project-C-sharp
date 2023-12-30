using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKTX.BusinessObject;
using System.Windows.Forms;

namespace QLKTX.DataLayer
{
    public class KyLuatSinhVienData
    {
        DataService ser = new DataService();             
        public DataTable LayDSSVThuocKTX(string MaKTX)
        {
            SqlCommand com =new SqlCommand();
            string sql = "SELECT sv.GioiTinh,sv.HOTEN,sv.MAKTX,p.MAPHG, k.TENKTX,p.TENPHG,d.TENDAY "+
                "from KTX k,PHONG p,[DAY] d,DSSINHVIEN_PHONG ds , SINHVIEN sv "+
                "where k.KTX=d.KTX and d.MADAY =  p.MADAY and ds.MAPHG=p.MAPHG and ds.MAKTX=sv.MAKTX AND k.KTX=@maktx";
            com.CommandText=sql;
            com.Parameters.Add("@maktx", SqlDbType.VarChar, 4).Value = MaKTX;            
            ser.Load(com);
            return ser;
        }
        public DataTable LayDSSVThuocPhong(string MaPHG)
        {
            SqlCommand com = new SqlCommand();
            string sql = "SELECT sv.GioiTinh,sv.HOTEN,sv.MAKTX,p.MAPHG, k.TENKTX,p.TENPHG,d.TENDAY " +
                "from KTX k,PHONG p,[DAY] d,DSSINHVIEN_PHONG ds , SINHVIEN sv " +
                "where k.KTX=d.KTX and d.MADAY =  p.MADAY and ds.MAPHG=p.MAPHG and ds.MAKTX=sv.MAKTX AND  p.MAPHG=@maphg";
            com.CommandText = sql;
            com.Parameters.Add("@maphg", SqlDbType.VarChar, 4).Value = MaPHG;            
            ser.Load(com);
            return ser;
        }
        public DataTable LayDSSVThuocDay(string MaDay)
        {
            SqlCommand com = new SqlCommand();
            string sql = "SELECT sv.GioiTinh,sv.HOTEN,sv.MAKTX,p.MAPHG, k.TENKTX,p.TENPHG,d.TENDAY " +
                "from KTX k,PHONG p,[DAY] d,DSSINHVIEN_PHONG ds , SINHVIEN sv " +
                "where k.KTX=d.KTX and d.MADAY =  p.MADAY and ds.MAPHG=p.MAPHG and ds.MAKTX=sv.MAKTX AND  d.MADAY=@maday";
            com.CommandText = sql;
            com.Parameters.Add("@maday", SqlDbType.VarChar, 4).Value = MaDay;            
            ser.Load(com);
            return ser;
        }
      /*  public void DanhGia(string MAKTX, string MAHOCKI, string MADANHGIA, string Tichcuc, string Tieucuc, string GhiChu)
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
        }*/
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
        public void KyLuat(KyLuatSVInfo info)
        {
            string sql = "Insert into KYLUATSV(MAKTX,MAKYLUAT,LYDO,MACAP,MACBQL,NGAY,QDSO) " +
                 " VALUES(@maktx,@makyluat,@lydo,@macap,@macbql,@ngay,@qdso)";
            SqlCommand com = new SqlCommand(sql);
            com.Parameters.Add("@maktx",SqlDbType.VarChar,7).Value=info.SinhVien.MaKTX;
            com.Parameters.Add("@makyluat",SqlDbType.Int).Value=info.MaKyLuat;
            com.Parameters.Add("@lydo",SqlDbType.NText).Value=info.LyDo;
            com.Parameters.Add("@macap",SqlDbType.Int).Value=info.Cap.MaCap;
            com.Parameters.Add("@macbql",SqlDbType.Int).Value=info.CanBo.MaSo;
            com.Parameters.Add("@ngay",SqlDbType.DateTime).Value=info.Ngay;
            com.Parameters.Add("@qdso",SqlDbType.VarChar,20).Value=info.QuyetDinhSo;
            try
            {
                ser.Load(com);
                MessageBox.Show("Thêm thành công!", "Ky Luat");
            }
            catch (Exception e)
            {
                MessageBox.Show("Không hoàn thành dược vì trùng khóa!", "Ky Luat");
            }
        }
        public void SuaKyLuat(KyLuatSVInfo info,string maktxcu,int makyluatcu,DateTime ngaycu)
        {
            string sql = "update KYLUATSV set MAKTX=@maktx,MAKYLUAT=@makyluat,LYDO=@lydo,MACAP=@macap,MACBQL=@macbql,NGAY=@ngay,QDSO=@qdso " +
                 " where MAKTX=@maktxcu and MAKYLUAT=@makyluatcu and NGAY=@ngaycu";
            SqlCommand com = new SqlCommand(sql);
            com.Parameters.Add("@maktx", SqlDbType.VarChar, 7).Value = info.SinhVien.MaKTX;
            com.Parameters.Add("@makyluat", SqlDbType.Int).Value = info.MaKyLuat;
            com.Parameters.Add("@lydo", SqlDbType.NVarChar,100).Value = info.LyDo;
            com.Parameters.Add("@macap", SqlDbType.Int).Value = info.Cap.MaCap;
            com.Parameters.Add("@macbql", SqlDbType.Int).Value = info.CanBo.MaSo;
            com.Parameters.Add("@ngay", SqlDbType.DateTime).Value = info.Ngay;
            com.Parameters.Add("@qdso", SqlDbType.VarChar, 20).Value = info.QuyetDinhSo;

            com.Parameters.Add("@maktxcu", SqlDbType.NVarChar, 7).Value = maktxcu;
            com.Parameters.Add("@makyluatcu", SqlDbType.Int).Value = makyluatcu;
            com.Parameters.Add("@ngaycu", SqlDbType.DateTime).Value = ngaycu;
            try
            {
                ser.Load(com);
                MessageBox.Show("Cập nhật thành công!", "Ky Luat");
            }
           catch (Exception e)
           {
                MessageBox.Show("Không hoàn thành dược vì trùng khóa!", "Ky Luat");
           }
        }
        public void XoaKyLuat(string maktxcu, int makyluatcu, DateTime ngaycu)
        {
            string sql = "delete KYLUATSV where MAKTX=@maktxcu and MAKYLUAT=@makyluatcu and NGAY=@ngaycu";
            SqlCommand com = new SqlCommand(sql);            
            com.Parameters.Add("@maktxcu", SqlDbType.VarChar, 7).Value = maktxcu;
            com.Parameters.Add("@makyluatcu", SqlDbType.Int).Value = makyluatcu;
            com.Parameters.Add("@ngaycu", SqlDbType.DateTime).Value = ngaycu;
            ser.Load(com);
            MessageBox.Show("Xóa thành công!", "Ky Luat");
        }
            
            public DataTable LayKyLuatSinhVien_Theo_MAKTX(string maktx)
            {
                SqlCommand com = new SqlCommand("Select * from KYLUATSV where MAKTX=@maktx");
                com.Parameters.Add("@maktx", SqlDbType.VarChar, 7).Value = maktx;
                ser.Load(com);
                return ser;
               
            }
             
    }
}
