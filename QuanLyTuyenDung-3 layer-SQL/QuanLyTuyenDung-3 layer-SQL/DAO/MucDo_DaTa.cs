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
    public class MucDo_DaTa
    {
        public static void ThemMucDo(DTO.MucDo_DTO mucdo)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ThemMucDo", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mamucdo", SqlDbType.NChar, 3);
                cmd.Parameters.Add("@mucdo", SqlDbType.NVarChar, 10);

                //add value to parameters
                cmd.Parameters["@mamucdo"].Value = mucdo.MaMucDo;
                cmd.Parameters["@mucdo"].Value = mucdo.MucDo;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void SuaMucDo(DTO.MucDo_DTO mucdo)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_SuaMucDo", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mamucdo", SqlDbType.NChar, 3);
                cmd.Parameters.Add("@mucdo", SqlDbType.NVarChar, 10);

                //add value to parameters
                cmd.Parameters["@mamucdo"].Value = mucdo.MaMucDo;
                cmd.Parameters["@mucdo"].Value = mucdo.MucDo;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void XoaMucDo(DTO.MucDo_DTO mucdo)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_XoaMucDo", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mamucdo", SqlDbType.NChar, 3);
               
                //add value to parameters
                cmd.Parameters["@mamucdo"].Value = mucdo.MaMucDo;
                
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static DataTable ListMucDo()
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_TatCaMucDo", cnn);
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
