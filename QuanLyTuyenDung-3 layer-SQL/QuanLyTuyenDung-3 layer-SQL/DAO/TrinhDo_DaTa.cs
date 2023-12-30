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
    public class TrinhDo_DaTa
    {
        public static void ThemTrinhDo(TrinhDo_DTO trinhdo)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ThemTrinhDo", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@matd", SqlDbType.NChar, 10);
                cmd.Parameters.Add("@tentd", SqlDbType.NVarChar, 50);

                //add value to parameters
                cmd.Parameters["@matd"].Value = trinhdo.MaTrinhDo;
                cmd.Parameters["@tentd"].Value = trinhdo.TenTrinhDo;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void SuaTrinhDo(TrinhDo_DTO trinhdo)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_SuaTrinhDo", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@matd", SqlDbType.NChar, 10);
                cmd.Parameters.Add("@tentd", SqlDbType.NVarChar, 50);

                //add value to parameters
                cmd.Parameters["@matd"].Value = trinhdo.MaTrinhDo;
                cmd.Parameters["@tentd"].Value = trinhdo.TenTrinhDo;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void XoaTrinhDo(TrinhDo_DTO trinhdo)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_XoaTrinhDo", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@matd", SqlDbType.NChar, 10);

                //add value to parameters
                cmd.Parameters["@matd"].Value = trinhdo.MaTrinhDo;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static DataTable ListTrinhDo()
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_TatCaTrinhDo", cnn);
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
