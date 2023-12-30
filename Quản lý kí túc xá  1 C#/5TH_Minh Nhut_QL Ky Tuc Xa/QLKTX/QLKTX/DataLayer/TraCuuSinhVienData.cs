using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKTX.Controller;
namespace QLKTX.DataLayer
{
    public class TraCuuSinhVienData
    {
        DataService data = new DataService();
        public DataTable TraCuu(string HoTen,string dkDiaChi ,string DiaChi,
                                string dkGioiTinh,string GioiTinh,
                                string dkMSSV,string MSSV,
                                string dkQuocTich,string QuocTich,
                                string dkDanToc,string DanToc,
                                string dkTonGiao,string TonGiao,
                                string dkCMND,string CMND)
        {
            SqlCommand com = new SqlCommand();
            string strWhere = "Where s.MAKTX=ds.MAKTX and ds.MAPHG=p.MAPHG and k.KTX=d.KTX and p.MaDay=d.MaDay and ( HoTen LIKE @hoten  ";
            com.Parameters.Add("@hoten", SqlDbType.NVarChar, 30).Value = "%"+HoTen+"%";

            if (dkDiaChi != "None")
            {
                strWhere += dkDiaChi + " DiaChi LIKE @DiaChi ";
                com.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 100).Value = "%" + DiaChi + "%";
            }
            if (dkGioiTinh != "None")
            {
                strWhere += dkGioiTinh + " GioiTinh = @GioiTinh ";
                com.Parameters.Add("@GioiTinh", SqlDbType.Bit, 1).Value = GioiTinh;
            }
            if (dkMSSV != "None")
            {
                strWhere += dkMSSV + " MSSV LIKE @MSSV ";
                com.Parameters.Add("@MSSV", SqlDbType.NVarChar, 100).Value = "%" + MSSV + "%";
            }
            if (dkQuocTich != "None")
            {
                strWhere += dkQuocTich + " MAQT = @QuocTich ";
                com.Parameters.Add("@QuocTich", SqlDbType.Int).Value = QuocTich;
            }
            if (dkTonGiao != "None")
            {
                strWhere += dkTonGiao + " MATG = @TonGiao ";
                com.Parameters.Add("@TonGiao", SqlDbType.Int).Value = TonGiao;
            }
            if (dkDanToc != "None")
            {
                strWhere += dkDanToc + " MADT = @DanToc ";
                com.Parameters.Add("@DanToc", SqlDbType.Int).Value = DanToc;
            }
            if (dkCMND != "None")
            {
                strWhere += dkCMND + " CMND LIKE @CMND ";
                com.Parameters.Add("@CMND", SqlDbType.NVarChar, 100).Value = "%" + CMND + "%";
            }
            com.CommandText = "Select s.MAKTX,s.HoTen,s.GioiTinh,p.TenPHG,k.TenKTX, d.TenDay  from SinhVien s,DSSINHVIEN_PHONG ds,Phong p, KTX k, [DAY] d " + strWhere+" )";
            data.Load(com);
            return data;
        }
        public DataTable TraCuuTheoPhong(string TenPhong)
        {
            DataService ser = new DataService();

            SqlCommand com = new SqlCommand();
            string strWhere = "Where s.MAKTX=ds.MAKTX and ds.MAPHG=p.MAPHG and k.KTX=d.KTX and p.MaDay=d.MaDay and ( TENPHG  = @tenphong ";
            com.Parameters.Add("@tenphong", SqlDbType.NVarChar, 30).Value = TenPhong;


            com.CommandText = "Select s.MAKTX,s.HoTen,s.GioiTinh,p.TenPHG,k.TenKTX, d.TenDay from SinhVien s,DSSINHVIEN_PHONG ds,Phong p, KTX k, [DAY] d " + strWhere + " )";
            data.Load(com);
            return data;
        }
        public DataTable TraCuuTheoDay(string TenDay)
        {
            DataService ser = new DataService();

            SqlCommand com = new SqlCommand();
            string strWhere = "Where s.MAKTX=ds.MAKTX and ds.MAPHG=p.MAPHG and k.KTX=d.KTX and p.MaDay=d.MaDay and ( TENDay  = @tenday  ";
            com.Parameters.Add("@tenday", SqlDbType.NVarChar, 30).Value = TenDay;


            com.CommandText = "Select s.MAKTX,s.HoTen,s.GioiTinh,p.TenPHG,k.TenKTX, d.TenDay  from SinhVien s,DSSINHVIEN_PHONG ds,Phong p, KTX k, [DAY] d " + strWhere + " )";
            data.Load(com);
            return data;
        }
    }
}
