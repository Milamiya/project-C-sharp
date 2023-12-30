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
    public class HoSo_DaTa
    {
        public static void ThemHoSo(HoSo_DTO hoso)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ThemHoSo", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahs", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@ngaynop", SqlDbType.Date);
                cmd.Parameters.Add("@mavitri", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@cmnd", SqlDbType.NChar, 9);
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar, 30);
                cmd.Parameters.Add("@ngaysinh", SqlDbType.Date);
                cmd.Parameters.Add("@maloaihs", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@mahuyen", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@maqg", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@matinh", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@manv", SqlDbType.NChar, 10);

                //add value to parameters
                cmd.Parameters["@mahs"].Value = hoso.MaHS;
                cmd.Parameters["@ngaynop"].Value = hoso.NgayNop;
                cmd.Parameters["@mavitri"].Value = hoso.MaViTri;
                cmd.Parameters["@cmnd"].Value = hoso.CMND;
                cmd.Parameters["@hoten"].Value = hoso.HoTen;
                cmd.Parameters["@ngaysinh"].Value = hoso.NgaySinh;
                cmd.Parameters["@maloaihs"].Value = hoso.MaLoaiHS;
                cmd.Parameters["@mahuyen"].Value = hoso.MaHuyen;
                cmd.Parameters["@maqg"].Value = hoso.MaQG;
                cmd.Parameters["@matinh"].Value = hoso.MaTinh;
                cmd.Parameters["@manv"].Value = hoso.MaNV;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }            
        }

        public static void SuaHoSo(HoSo_DTO hoso)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_SuaHoSo", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahs", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@ngaynop", SqlDbType.Date);
                cmd.Parameters.Add("@mavitri", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@cmnd", SqlDbType.NChar, 9);
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar, 30);
                cmd.Parameters.Add("@ngaysinh", SqlDbType.Date);
                cmd.Parameters.Add("@maloaihs", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@mahuyen", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@maqg", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@matinh", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@manv", SqlDbType.NChar, 10);

                //add value to parameters
                cmd.Parameters["@mahs"].Value = hoso.MaHS;
                cmd.Parameters["@ngaynop"].Value = hoso.NgayNop;
                cmd.Parameters["@mavitri"].Value = hoso.MaViTri;
                cmd.Parameters["@cmnd"].Value = hoso.CMND;
                cmd.Parameters["@hoten"].Value = hoso.HoTen;
                cmd.Parameters["@ngaysinh"].Value = hoso.NgaySinh;
                cmd.Parameters["@maloaihs"].Value = hoso.MaLoaiHS;
                cmd.Parameters["@mahuyen"].Value = hoso.MaHuyen;
                cmd.Parameters["@maqg"].Value = hoso.MaQG;
                cmd.Parameters["@matinh"].Value = hoso.MaTinh;
                cmd.Parameters["@manv"].Value = hoso.MaNV;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void XoaHoSo(HoSo_DTO hoso)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_XoaHoSo", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahs", SqlDbType.NChar, 5);

                //add value to parameters
                cmd.Parameters["@mahs"].Value = hoso.MaHS;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static DataTable ListHoSo()
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_TatCaHoSo", cnn);
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
        public static DataTable ListHoSoTheoTen(string hoten)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_HoSoTheoTen", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@hoten", SqlDbType.NChar, 5);

                //add value to parameters
                cmd.Parameters["@hoten"].Value = hoten;

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
        public static DataTable ListHoSoTheoTinTuyenDung(string hoten)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_HoSoTheoTinTuyenDung", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@matt", SqlDbType.NChar, 5);

                //add value to parameters
                cmd.Parameters["@matt"].Value = hoten;

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
