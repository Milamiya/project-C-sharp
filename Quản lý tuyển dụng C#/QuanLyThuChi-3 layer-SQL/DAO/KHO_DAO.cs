using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class KHO_DAO
    {
        public static void ThemKho(KHO_DTO kho)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ThemKho", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@makho", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@tenkho", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@diadiem", SqlDbType.NVarChar, 100);
              
                //add value to parameters
                cmd.Parameters["@makho"].Value = kho.MaKho;
                cmd.Parameters["@tenkho"].Value = kho.TenKho;
                cmd.Parameters["@diadiem"].Value = kho.DiaDiem;
                
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static void SuaKho(KHO_DTO kho)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_SuaKho", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@makho", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@tenkho", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@diadiem", SqlDbType.NVarChar, 100);

                //add value to parameters
                cmd.Parameters["@makho"].Value = kho.MaKho;
                cmd.Parameters["@tenkho"].Value = kho.TenKho;
                cmd.Parameters["@diadiem"].Value = kho.DiaDiem;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static void XoaKho(KHO_DTO kho)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_XoaKho", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@makho", SqlDbType.NChar, 5);
                
                //add value to parameters
                cmd.Parameters["@makho"].Value = kho.MaKho;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static DataTable ListKho()
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_TatCaKho", cnn);
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
