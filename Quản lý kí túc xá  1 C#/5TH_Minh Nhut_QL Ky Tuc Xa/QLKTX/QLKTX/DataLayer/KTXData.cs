using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace QLKTX.DataLayer
{
    public class KTXData
    {
        DataService ser = new DataService();
        
        public DataTable LayDSKTX()
        {
            SqlCommand com = new SqlCommand();    
            com.CommandText="Select * from KTX";
            ser.Load(com);
            return ser;
        }
        /// <summary>
        /// Lưu KTX Xuống CSDL
        /// </summary>
        /// <param name="ktx">KTX cần thêm</param>
        /// <returns>
        /// true --> Thành công
        /// false --> Thất bại        
        /// </returns>
        public bool Them(QLKTX.BusinessObject.KTXInfo ktx)
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "Insert Into KTX(KTX,TENKTX,SOLUONGDAY) values(@ma,@ten,@soday)";
            com.Parameters.Add("@ma", SqlDbType.VarChar, 4).Value = ktx.MaKTX;
            com.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = ktx.TenKTX;
            com.Parameters.Add("@soday", SqlDbType.Int).Value = ktx.SoDay;
            try
            {
                ser.Load(com);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;

            }
        }

        public bool Xoa(QLKTX.BusinessObject.KTXInfo ktx)
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "Delete KTX where KTX=@ma";
            com.Parameters.Add("@ma", SqlDbType.VarChar, 7).Value = ktx.MaKTX;            
            try
            {
                ser.Load(com);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;

            }
        }
        public bool Sua(QLKTX.BusinessObject.KTXInfo ktx)
        {
            SqlCommand com = new SqlCommand();
            com.CommandText = "Update KTX Set TenKTX =@ten, SOLUONGDAY=@soday where KTX=@ma";
            com.Parameters.Add("@ma", SqlDbType.VarChar, 7).Value = ktx.MaKTX;
            com.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = ktx.TenKTX;
            com.Parameters.Add("@soday", SqlDbType.Int).Value = ktx.SoDay;
            try
            {
                ser.Load(com);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;

            }
        }
    }
}
