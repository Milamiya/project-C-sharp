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
    public class ViTri_DaTa
    {
        public static void ThemViTri(ViTri_DTO vitri)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ThemViTri", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mavt", SqlDbType.NChar, 10);
                cmd.Parameters.Add("@tenvt", SqlDbType.NVarChar, 50);

                //add value to parameters
                cmd.Parameters["@mavt"].Value = vitri.MaViTri;
                cmd.Parameters["@tenvt"].Value = vitri.TenViTri;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void SuaViTri(DTO.ViTri_DTO vitri)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_SuaViTri", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mavt", SqlDbType.NChar, 10);
                cmd.Parameters.Add("@tenvt", SqlDbType.NVarChar, 50);

                //add value to parameters
                cmd.Parameters["@mavt"].Value = vitri.MaViTri;
                cmd.Parameters["@tenvt"].Value = vitri.TenViTri;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void XoaViTri(DTO.ViTri_DTO vitri)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_XoaViTri", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mavt", SqlDbType.NChar, 10);

                //add value to parameters
                cmd.Parameters["@mavt"].Value = vitri.MaViTri;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static DataTable ListViTri()
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_TatCaViTri", cnn);
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
