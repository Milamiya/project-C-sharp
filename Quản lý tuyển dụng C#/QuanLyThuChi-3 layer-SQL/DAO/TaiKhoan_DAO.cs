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
    public class TaiKhoan_DAO
    {
        public static void ThemTaiKhoan(DTO.TaiKhoan_DTO tk)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_ThemTaiKhoan", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@uid", SqlDbType.NChar, 16);
                cmd.Parameters.Add("@upss", SqlDbType.NChar, 16);
                cmd.Parameters.Add("@upss2", SqlDbType.NChar, 16);
                cmd.Parameters.Add("@utype", SqlDbType.Int);
                cmd.Parameters.Add("@uques", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@uans", SqlDbType.NVarChar, 50);

                //add value to parameters
                cmd.Parameters["@uid"].Value = tk.UID;
                cmd.Parameters["@upss"].Value = tk.UPSS;
                cmd.Parameters["@upss2"].Value = tk.UPSS2;
                cmd.Parameters["@utype"].Value = tk.UTYPE;
                cmd.Parameters["@uques"].Value = tk.UQUES;
                cmd.Parameters["@uans"].Value = tk.UANS;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void SuaTaiKhoan(DTO.TaiKhoan_DTO tk)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_SuaTaiKhoan", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@uid", SqlDbType.NChar, 16);
                cmd.Parameters.Add("@upss", SqlDbType.NChar, 16);
                cmd.Parameters.Add("@upss2", SqlDbType.NChar, 16);
                cmd.Parameters.Add("@utype", SqlDbType.Int);
                cmd.Parameters.Add("@uques", SqlDbType.NVarChar, 50);
                cmd.Parameters.Add("@uans", SqlDbType.NVarChar, 50);

                //add value to parameters
                cmd.Parameters["@uid"].Value = tk.UID;
                cmd.Parameters["@upss"].Value = tk.UPSS;
                cmd.Parameters["@upss2"].Value = tk.UPSS2;
                cmd.Parameters["@utype"].Value = tk.UTYPE;
                cmd.Parameters["@uques"].Value = tk.UQUES;
                cmd.Parameters["@uans"].Value = tk.UANS;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

        public static void XoaTaiKhoan(DTO.TaiKhoan_DTO tk)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_XoaTaiKhoan", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@uid", SqlDbType.NChar, 16);

                //add value to parameters
                cmd.Parameters["@uid"].Value = tk.UID;

                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }
        public static int KiemTraTaiKhoan(DTO.TaiKhoan_DTO tk)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_checktk", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@uid", SqlDbType.NChar, 16);
                cmd.Parameters.Add("@upss", SqlDbType.NChar, 16);
                //add value to parameters
                cmd.Parameters["@uid"].Value = tk.UID;
                cmd.Parameters["@upss"].Value = tk.UPSS;

                try
                {
                    cnn.Open();
                    return (int)cmd.ExecuteScalar();
                }
                catch (Exception err)
                {
                    return 0;
                }
                finally
                {
                    cnn.Close();
                }
            }
            else
            {
                return 0;
            }
        }
        public static int KiemTraTaiKhoanRS(DTO.TaiKhoan_DTO tk)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_checktk", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@uid", SqlDbType.NChar, 16);
                cmd.Parameters.Add("@upss", SqlDbType.NChar, 16);
                //add value to parameters
                cmd.Parameters["@uid"].Value = tk.UID;
                cmd.Parameters["@upss"].Value = tk.UPSS;

                try
                {
                    cnn.Open();
                    return (int)cmd.ExecuteScalar();
                }
                catch (Exception err)
                {
                    return 0;
                }
                finally
                {
                    cnn.Close();
                }
            }
            else
            {
                return 0;
            }
        }
        public static int CheckQuyenTK(DTO.TaiKhoan_DTO tk)
        {
            if (DataServices.testketnoi() == true)
            {
                SqlConnection cnn = DataServices.ketnoi();
                SqlCommand cmd = new SqlCommand("sp_checkquyentk", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@uid", SqlDbType.NChar, 16);

                //add value to parameters
                cmd.Parameters["@uid"].Value = tk.UID;

                try
                {
                    cnn.Open();
                    return (int)cmd.ExecuteScalar();
                }
                catch (Exception err)
                {
                    return 0;
                }
                finally
                {
                    cnn.Close();
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
