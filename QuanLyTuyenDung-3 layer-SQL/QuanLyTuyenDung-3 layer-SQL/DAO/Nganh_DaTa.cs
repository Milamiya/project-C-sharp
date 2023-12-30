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
    public class Nganh_DaTa
    {
        public static void ThemNganh(DTO.Nganh_DTO nganh)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ThemNganh", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@manganh", SqlDbType.NChar, 10);
                cmd.Parameters.Add("@tennganh", SqlDbType.NVarChar, 100);

                //add value to parameters
                cmd.Parameters["@manganh"].Value = nganh.MaNganh;
                cmd.Parameters["@tennganh"].Value = nganh.TenNganh;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void SuaNganh(DTO.Nganh_DTO nganh)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_SuaNganh", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@manganh", SqlDbType.NChar, 10);
                cmd.Parameters.Add("@tennganh", SqlDbType.NVarChar, 100);

                //add value to parameters
                cmd.Parameters["@manganh"].Value = nganh.MaNganh;
                cmd.Parameters["@tennganh"].Value = nganh.TenNganh;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void XoaNganh(DTO.Nganh_DTO nganh)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_XoaNganh", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@manganh", SqlDbType.NChar, 10);

                //add value to parameters
                cmd.Parameters["@manganh"].Value = nganh.MaNganh;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static DataTable ListNganh()
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_TatCaNganh", cnn);
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
