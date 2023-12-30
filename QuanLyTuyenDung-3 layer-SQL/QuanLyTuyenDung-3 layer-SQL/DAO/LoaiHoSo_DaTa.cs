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
    public class LoaiHoSo_DaTa
    {
        public static void ThemLoaiHoSo(DTO.LoaiHoSo_DTO loaihs)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ThemLoaiHS", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maloaihs", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@tenhs", SqlDbType.NVarChar, 15);


                //add value to parameters
                cmd.Parameters["@maloaihs"].Value = loaihs.MaLoaiHS;
                cmd.Parameters["@tenhs"].Value = loaihs.TenHS;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void SuaLoaiHoSo(DTO.LoaiHoSo_DTO loaihs)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_SuaLoaiHS", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maloaihs", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@tenhs", SqlDbType.NVarChar, 15);

                //add value to parameters
                cmd.Parameters["@maloaihs"].Value = loaihs.MaLoaiHS;
                cmd.Parameters["@tenhs"].Value = loaihs.TenHS;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void XoaLoaiHoSo(DTO.LoaiHoSo_DTO loaihs)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_XoaLoaiHS", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maloaihs", SqlDbType.NChar, 5);

                //add value to parameters
                cmd.Parameters["@maloaihs"].Value = loaihs.MaLoaiHS;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static DataTable ListMaLoaiHS()
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ListLoaiHS", cnn);
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
        public static DataTable ListLoaiHS()
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ToanBoLoaiHoSo", cnn);
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
