using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace QuanLyHoSoCongChuc.DataLayer
{
    public class DoanVienData
    {
        DataService m_GiaTriDoanVienData = new DataService();
        public DataTable LayGiaTriDoanVien()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DoanVien");
            m_GiaTriDoanVienData.Load(cmd);
            return m_GiaTriDoanVienData;
        }
    }
}
