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
    public class CTKHO_DAO
    {
        public static void ThemCTKHO(CTKHO_DTO ctkho)
        {
            if (DataServices.testketnoi()==true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ThemCTKho", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@makho", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@mahang", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@soluong", SqlDbType.Int);
              
                //add value to parameters
                cmd.Parameters["@makho"].Value = ctkho.MaKho;
                cmd.Parameters["@mahang"].Value = ctkho.MaHang;
                cmd.Parameters["@soluong"].Value = ctkho.SoLuong;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }            
        }

        public static void SuaCTKHO(CTKHO_DTO ctkho)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_SuaCTKho", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@makho", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@mahang", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@soluong", SqlDbType.Int);

                //add value to parameters
                cmd.Parameters["@makho"].Value = ctkho.MaKho;
                cmd.Parameters["@mahang"].Value = ctkho.MaHang;
                cmd.Parameters["@soluong"].Value = ctkho.SoLuong;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static void XoaCTKHO(CTKHO_DTO ctkho)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_SuaCTKho", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@makho", SqlDbType.NChar, 5);
                cmd.Parameters.Add("@mahang", SqlDbType.NChar, 5);
                
                //add value to parameters
                cmd.Parameters["@makho"].Value = ctkho.MaKho;
                cmd.Parameters["@mahang"].Value = ctkho.MaHang;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static DataTable ListCTKho()
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_TatCaCTKho", cnn);
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
