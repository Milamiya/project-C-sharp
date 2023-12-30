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
    public class PhongBan_DaTa
    {
        public static void ThemPhongBan(DTO.PhongBan_DTO phongban)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ThemPhongBan", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mapb", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@tenpb", SqlDbType.NVarChar, 20);

                //add value to parameters
                cmd.Parameters["@mapb"].Value = phongban.MaPB;
                cmd.Parameters["@tenpb"].Value = phongban.TenPB;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void SuaPhongBan(DTO.PhongBan_DTO phongban)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_SuaPhongBan", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mapb", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@tenpb", SqlDbType.NVarChar, 20);

                //add value to parameters
                cmd.Parameters["@mapb"].Value = phongban.MaPB;
                cmd.Parameters["@tenpb"].Value = phongban.TenPB;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void XoaPhongBan(DTO.PhongBan_DTO phongban)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_XoaPhongBan", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mapb", SqlDbType.NChar, 10);

                //add value to parameters
                cmd.Parameters["@mapb"].Value = phongban.MaPB;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static DataTable ListPhongBan()
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_TatCaPhongBan", cnn);
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
