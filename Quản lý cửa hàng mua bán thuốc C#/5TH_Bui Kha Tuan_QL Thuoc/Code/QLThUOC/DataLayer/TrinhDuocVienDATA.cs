using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class TrinhDuocVienDATA
    {
        DataService dl = new DataService();
        public DataTable LayDLTDVien()
        {
            SqlCommand cmd = new SqlCommand("select * from TDVIEN");
            dl.Load(cmd);
            return dl;
        }
        public DataTable TimKiemTDV(String MaTDV, String ChonTenTDV, String TenTDV,String ChonDiaChi,String DiaChi)
        {
            SqlCommand cmd = new SqlCommand();
            String sql = "SELECT * FROM TDVIEN WHERE MATDV LIKE '%'+@matdv+'%'";
            cmd.Parameters.Add("matdv", SqlDbType.NVarChar).Value = MaTDV;
            if (ChonTenTDV != "NONE")
            {
                sql += ChonTenTDV + " HOTENTDV LIKE '%' + @tentdv + '%'";
                cmd.Parameters.Add("tentdv", SqlDbType.NVarChar).Value = TenTDV;
            }
            if (ChonDiaChi != "NONE")
            {
                sql += ChonDiaChi + " DIACHI LIKE '%' + @diachi + '%'";
                cmd.Parameters.Add("diachi", SqlDbType.NVarChar).Value = DiaChi;
            }
            cmd.CommandText = sql;

            dl.Load(cmd);

            return dl;

        }
        public void Update()
        {
            dl.Update();
        }
    }
}
