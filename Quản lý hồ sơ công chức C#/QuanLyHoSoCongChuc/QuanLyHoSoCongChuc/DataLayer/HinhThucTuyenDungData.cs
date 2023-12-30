using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace QuanLyHoSoCongChuc.DataLayer
{
    public class HinhThucTuyenDungData
    {
        DataService m_HinhThucTuyenDungData = new DataService();
        // DataService ds = new DataService();
        public DataTable LayDsHinhThucTuyenDung()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HinhThucTuyenDung");
            m_HinhThucTuyenDungData.Load(cmd);
            return m_HinhThucTuyenDungData;
        }

        public DataRow ThemDongMoi()
        {
            return m_HinhThucTuyenDungData.NewRow();
        }

        public void ThemHinhThucTuyenDung(DataRow m_Row)
        {
            m_HinhThucTuyenDungData.Rows.Add(m_Row);
        }

        public bool LuuHinhThucTuyenDung()
        {
            return m_HinhThucTuyenDungData.ExecuteNoneQuery() > 0;
        }

    }
}
