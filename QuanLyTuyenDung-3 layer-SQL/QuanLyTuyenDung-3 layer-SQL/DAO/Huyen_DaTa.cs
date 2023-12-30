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
    public class Huyen_DaTa
    {
        public static void ThemHuyen(DTO.Huyen_DTO huyen)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ThemHuyen", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahuyen", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@tenhuyen", SqlDbType.NVarChar,15);
                

                //add value to parameters
                cmd.Parameters["@mahuyen"].Value = huyen.MaHuyen;
                cmd.Parameters["@tenhuyen"].Value = huyen.TenHuyen;
                
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void SuaHuyen(DTO.Huyen_DTO huyen)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_SuaHuyen", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahuyen", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@tenhuyen", SqlDbType.NVarChar, 15);

                //add value to parameters
                cmd.Parameters["@mahuyen"].Value = huyen.MaHuyen;
                cmd.Parameters["@tenhuyen"].Value = huyen.TenHuyen;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void XoaHuyen(DTO.Huyen_DTO huyen)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_XoaHoSo", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahuyen", SqlDbType.NChar, 5);

                //add value to parameters
                cmd.Parameters["@mahuyen"].Value = huyen.MaHuyen;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static DataTable ListHuyen()
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_TatCaHuyen", cnn);
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
