using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class NhanVien_DaTa
    {
        public static void ThemNhanVien(DTO.NhanVien_DTO nhanvien)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ThemNhanVien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@manv", SqlDbType.NChar, 10);                
                cmd.Parameters.Add("@tennv", SqlDbType.NVarChar, 50);                              
                cmd.Parameters.Add("@ngaysinh", SqlDbType.Date);
                cmd.Parameters.Add("@chucvu", SqlDbType.NVarChar, 30);
                cmd.Parameters.Add("@mahuyen", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@maqg", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@matinh", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@matt", SqlDbType.NChar, 10);
                cmd.Parameters.Add("@mapb", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@matb", SqlDbType.NChar, 10);

                //add value to parameters
                cmd.Parameters["@manv"].Value = nhanvien.MaNV;
                cmd.Parameters["@tennv"].Value = nhanvien.TenNV;                
                cmd.Parameters["@ngaysinh"].Value = nhanvien.NgaySinh;
                cmd.Parameters["@chucvu"].Value = nhanvien.ChucVu;
                cmd.Parameters["@mahuyen"].Value = nhanvien.MaHuyen;
                cmd.Parameters["@maqg"].Value = nhanvien.MaQG;
                cmd.Parameters["@matinh"].Value = nhanvien.MaTinh;
                cmd.Parameters["@matt"].Value = nhanvien.MaTT;
                cmd.Parameters["@mapb"].Value = nhanvien.MaPB;
                cmd.Parameters["@matb"].Value = nhanvien.MaTB;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void SuaNhanVien(DTO.NhanVien_DTO nhanvien)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_SuaNhanVien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@manv", SqlDbType.NChar, 10);
                cmd.Parameters.Add("@tennv", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@ngaysinh", SqlDbType.Date);
                cmd.Parameters.Add("@chucvu", SqlDbType.NVarChar, 30);
                cmd.Parameters.Add("@mahuyen", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@maqg", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@matinh", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@matt", SqlDbType.NChar, 10);
                cmd.Parameters.Add("@mapb", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@matb", SqlDbType.NChar, 10);

                //add value to parameters
                cmd.Parameters["@manv"].Value = nhanvien.MaNV;
                cmd.Parameters["@tennv"].Value = nhanvien.TenNV;
                cmd.Parameters["@ngaysinh"].Value = nhanvien.NgaySinh;
                cmd.Parameters["@chucvu"].Value = nhanvien.ChucVu;
                cmd.Parameters["@mahuyen"].Value = nhanvien.MaHuyen;
                cmd.Parameters["@maqg"].Value = nhanvien.MaQG;
                cmd.Parameters["@matinh"].Value = nhanvien.MaTinh;
                cmd.Parameters["@matt"].Value = nhanvien.MaTT;
                cmd.Parameters["@mapb"].Value = nhanvien.MaPB;
                cmd.Parameters["@matb"].Value = nhanvien.MaTB;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void XoaNhanVien(DTO.NhanVien_DTO nhanvien)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_XoaNhanVien", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@manv", SqlDbType.NChar, 10);

                //add value to parameters
                cmd.Parameters["@manv"].Value = nhanvien.MaNV;

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
