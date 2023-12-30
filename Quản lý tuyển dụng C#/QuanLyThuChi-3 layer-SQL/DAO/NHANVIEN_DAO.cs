using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class NHANVIEN_DAO
    {
        public static void ThemNhanVien(NHANVIEN_DTO nv)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ThemNhanVien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@manv", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@ngaysinh", SqlDbType.Date);
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@sodienthoai", SqlDbType.NVarChar, 11);

                //add value to parameters
                cmd.Parameters["@manv"].Value = nv.MaNV;
                cmd.Parameters["@hoten"].Value = nv.HoTen;
                cmd.Parameters["@ngaysinh"].Value = nv.NgaySinh;
                cmd.Parameters["@diachi"].Value = nv.DiaChi;
                cmd.Parameters["@sodienthoai"].Value = nv.SoDienThoai;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static void SuaNhanVien(NHANVIEN_DTO nv)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_SuaNhanVien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@manv", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@ngaysinh", SqlDbType.Date);
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@sodienthoai", SqlDbType.NVarChar, 11);

                //add value to parameters
                cmd.Parameters["@manv"].Value = nv.MaNV;
                cmd.Parameters["@hoten"].Value = nv.HoTen;
                cmd.Parameters["@ngaysinh"].Value = nv.NgaySinh;
                cmd.Parameters["@diachi"].Value = nv.DiaChi;
                cmd.Parameters["@sodienthoai"].Value = nv.SoDienThoai;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static void XoaNhanVien(NHANVIEN_DTO nv)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_XoaNhanVien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@manv", SqlDbType.NChar, 5);
                
                //add value to parameters
                cmd.Parameters["@manv"].Value = nv.MaNV;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static DataTable ListNhanVien()
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_TatCaNhanVien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            else
            {
                DataTable dt = new DataTable();
                return dt;
            }
        }
    }
}
