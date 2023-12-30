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
    public class Tinh_DaTa
    {
        public static void ThemTinh(DTO.Tinh_DTO tinh)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ThemTinh", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mat", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@tent", SqlDbType.NVarChar, 15);

                //add value to parameters
                cmd.Parameters["@mat"].Value = tinh.MaTinh;
                cmd.Parameters["@tent"].Value = tinh.TenTinh;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void SuaTinh(DTO.Tinh_DTO tinh)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_SuaTinh", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mat", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@tent", SqlDbType.NVarChar, 15);

                //add value to parameters
                cmd.Parameters["@mat"].Value = tinh.MaTinh;
                cmd.Parameters["@tent"].Value = tinh.TenTinh;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void XoaTinh(DTO.Tinh_DTO tinh)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_XoaTinh", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mat", SqlDbType.NChar, 5);
                
                //add value to parameters
                cmd.Parameters["@mat"].Value = tinh.MaTinh;
                
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static DataTable ListTinh()
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_TatCaTinh", cnn);
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
