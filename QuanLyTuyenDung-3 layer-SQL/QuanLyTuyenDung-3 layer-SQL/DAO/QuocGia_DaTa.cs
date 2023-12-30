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
    public class QuocGia_DaTa
    {
        public static void ThemQuocGia(DTO.QuocGia_DTO quocgia)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ThemQuocGia", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maqg", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@tenqg", SqlDbType.NVarChar, 15);

                //add value to parameters
                cmd.Parameters["@maqg"].Value = quocgia.MaQG;
                cmd.Parameters["@tenqg"].Value = quocgia.TenQG;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void SuaQuocGia(DTO.QuocGia_DTO quocgia)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_SuaQuocGia", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maqg", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@tenqg", SqlDbType.NVarChar, 15);

                //add value to parameters
                cmd.Parameters["@maqg"].Value = quocgia.MaQG;
                cmd.Parameters["@tenqg"].Value = quocgia.TenQG;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void XoaQuocGia(DTO.QuocGia_DTO quocgia)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_XoaQuocGia", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maqg", SqlDbType.NChar, 5);

                //add value to parameters
                cmd.Parameters["@maqg"].Value = quocgia.MaQG;
               
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static DataTable ListQuocGia()
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_TatCaQuocGia", cnn);
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
