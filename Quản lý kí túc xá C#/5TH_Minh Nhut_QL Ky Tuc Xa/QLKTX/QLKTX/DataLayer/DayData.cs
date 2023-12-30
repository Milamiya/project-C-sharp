using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using QLKTX.BusinessObject;
namespace QLKTX.DataLayer
{
    
    public class DayData
    {
        DataService ser = new DataService();
        public DataTable LayDSDay()
        {
            SqlCommand com = new SqlCommand("Select * from [Day]");
            ser.Load(com);
            return ser;
        }
        public DataTable LayDSDay_DK_KTX(string maktx)
        {
            SqlCommand com = new SqlCommand("Select * from [Day] where KTX=@maktx");
            com.Parameters.Add("@maktx", SqlDbType.NVarChar, 4).Value = maktx;
            ser.Load(com);
            return ser;
        }
        public bool Sua(DayInfo day)
        {
            SqlCommand com = new SqlCommand("Update [Day] Set TENDAY =@ten, SOLUONGPHG=@soluong, KTX=@maktx, MACODO=@macodo where MADAY=@maday");
            com.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = day.TenDay;
            com.Parameters.Add("@soluong", SqlDbType.SmallInt).Value = day.SoLuongPhong;
            com.Parameters.Add("@maktx", SqlDbType.VarChar, 4).Value = day.KTX.MaKTX;
            com.Parameters.Add("@macodo", SqlDbType.VarChar, 7).Value = day.CoDo.MaKTX;
            com.Parameters.Add("@maday", SqlDbType.VarChar, 4).Value = day.MaDay;
            try
            {
                ser.Load(com);
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Không Sửa dược:\n Lỗi " + e.Message, "Dãy", System.Windows.Forms.MessageBoxButtons.OK);
                return false;
            }            
        }
        public bool Xoa(DayInfo day)
        {
            SqlCommand com = new SqlCommand("Delete [Day] where MADAY=@maday");
            com.Parameters.Add("@maday", SqlDbType.VarChar, 4).Value = day.MaDay;
            try
            {
                ser.Load(com);
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Không xóa dược:\n Lỗi " + e.Message, "Dãy", System.Windows.Forms.MessageBoxButtons.OK);
                return false;
            }
        }
        public bool Them(DayInfo day)
        {
            SqlCommand com = new SqlCommand("Insert into [Day](MADAY,TENDAY,SOLUONGPHG,MACODO,KTX) values (@maday,@ten,@soluong,@macodo,@maktx)");
            com.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = day.TenDay;
            com.Parameters.Add("@soluong", SqlDbType.SmallInt).Value = day.SoLuongPhong;
            com.Parameters.Add("@maktx", SqlDbType.VarChar, 4).Value = day.KTX.MaKTX;
            com.Parameters.Add("@macodo", SqlDbType.VarChar, 7).Value = day.CoDo.MaKTX;
            com.Parameters.Add("@maday", SqlDbType.VarChar, 4).Value = day.MaDay;
            try
            {
                ser.Load(com);
                return true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Không Thêm dược:\n Lỗi " + e.Message, "Dãy", System.Windows.Forms.MessageBoxButtons.OK);
                return false;
            }
        }
    }
}
