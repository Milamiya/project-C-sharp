using System.Data;

namespace QLHS.BUS
{
    public class HocKyBUS
    {
        /// <summary>
        /// Lấy DataTable Học kỳ
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable LayDT_HocKy()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("MaHocKy");
            dataTable.Columns.Add("TenHocKy");
            for (int hk = 1; hk <= 2; hk++)
            {
                DataRow dr = dataTable.NewRow();
                dr["MaHocKy"] = hk;
                dr["TenHocKy"] = "Học kỳ " + hk;
                dataTable.Rows.Add(dr);
            }
            return dataTable;
        }
    }
}