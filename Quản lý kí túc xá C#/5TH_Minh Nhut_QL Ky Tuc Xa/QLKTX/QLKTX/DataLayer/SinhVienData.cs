using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QLKTX.BusinessObject;
using System.Data.SqlClient;
namespace QLKTX.DataLayer
{
    public class SinhVienData
    {
        SqlCommand command;
        DataService ser = new DataService();
        /// <summary>
        /// Cập nhật Sinh Viên vào CSDL
        /// </summary>
        /// <param name="sv">Sinh Viên cần cập nhật</param>
        /// <returns>
        /// true khi cập nhật thành công
        /// false khi cập nhật thất bại
        /// </returns>
        public bool ThemVaoCSDL(SinhVienInfo sv)
        {

            string s = "insert into SINHVIEN(MAKTX,NAMSINH,HOTEN,CMND,DIENTHOAI,MSSV," +
                                            "GIOITINH,DIACHI,MAQT,MADT,MATG,DOANVIEN,DANGVIEN," +
                                            "CAMTINHDANG,NGAYVAOKTX,HINH) values("+
                                            "@maktx,@namsinh,@hoten,@cmnd,@dienthoai,@mssv,"+
                                            "@gioitinh,@diachi,@maqt,@madt,@matg,@doanvien,@dangvien," +
                                            "@camtinhdang,@ngayvaoktx,@hinh)";

            SqlCommand command = new SqlCommand(s);
            command.Parameters.Add("@maktx",SqlDbType.VarChar,7).Value = sv.MaKTX;
            command.Parameters.Add("@namsinh", SqlDbType.DateTime).Value = sv.Namsinh;
            command.Parameters.Add("@hoten", SqlDbType.NVarChar, 30).Value = sv.HoTen;
            command.Parameters.Add("@cmnd", SqlDbType.VarChar, 9).Value = sv.SoCMDN;
            command.Parameters.Add("@dienthoai", SqlDbType.VarChar, 10).Value = sv.DienThoai;
            command.Parameters.Add("@mssv", SqlDbType.VarChar, 9).Value = sv.MSSV;
            command.Parameters.Add("@gioitinh", SqlDbType.Bit).Value = sv.GioiTinh;
            command.Parameters.Add("@diachi", SqlDbType.NVarChar, 100).Value = sv.DiaChi;
            command.Parameters.Add("@maqt", SqlDbType.Int).Value = sv.QuocTich.MaQuocTich;
            command.Parameters.Add("@madt", SqlDbType.Int).Value = sv.DanToc.MaDanToc;
            command.Parameters.Add("@matg", SqlDbType.Int).Value = sv.TonGiao.MaTonGiao;
            command.Parameters.Add("@doanvien", SqlDbType.Bit).Value = sv.DoanVien;
            command.Parameters.Add("@dangvien", SqlDbType.Bit).Value = sv.DangVien;
            command.Parameters.Add("@camtinhdang", SqlDbType.Bit).Value = sv.CamTinhDang;
            command.Parameters.Add("@ngayvaoktx", SqlDbType.DateTime).Value = DateTime.Now;
            command.Parameters.Add("@hinh", SqlDbType.NText).Value = sv.HinhAnh;
           // try
            {                
                ser.Load(command);
                return true;
            }
         //   catch(Exception e)
            {
               // e.ToString();
                return false;
            }           

        }
        public bool XoaRaKhoiCSDL(SinhVienInfo sv)
        {
            string s = "DELETE SINHVIEN where MAKTX ='"+ sv.HoTen +"'";
            command = new SqlCommand(s);
            try
            {
                ser.Load(command);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }  
        }
        public DataTable LayMaKTXMax(string str1,string str2)
        {
            command = new SqlCommand();
            command.CommandText="select  MAX(MAKTX) as MA from SINHVIEN where MAKTX > '"+str1+"_%' and MAKTX < '"+str2+"_%'";
            //command.Parameters.Add("@Nho",SqlDbType.NVarChar,7).Value = (str1+"_%");
            //command.Parameters.Add("@Lon",SqlDbType.NVarChar,7).Value = (str2+"_%");
            
            ser.Load(command);
            return ser;
        }
        // Lấy Danh sach Sinh viên
        public DataTable LayDSSinhVien()
        {
            command = new SqlCommand();
            command.CommandText = "select * from SINHVIEN";
            ser.Load(command);
            return ser;
        }

    }
}
