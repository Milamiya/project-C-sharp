using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace QuanLyHoSoCongChuc.DataLayer
{
    public class LoaiNghiBaoHiemXaHoiData
    {
        DataService m_LoaiNghiBaoHiemXaHoiData = new DataService();
        // DataService ds = new DataService();
        public DataTable LayDanhSachLoaiNghiBaoHiemXaHoi()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiNghiBaoHiemXaHoi");
            m_LoaiNghiBaoHiemXaHoiData.Load(cmd);
            return m_LoaiNghiBaoHiemXaHoiData;
        }

        public DataRow ThemDongMoi()
        {
            return m_LoaiNghiBaoHiemXaHoiData.NewRow();
        }

        public void ThemLoaiNghiBaoHiemXaHoi(DataRow m_Row)
        {
            m_LoaiNghiBaoHiemXaHoiData.Rows.Add(m_Row);
        }

        public bool LuuLoaiNghiBaoHiemXaHoi()
        {
            return m_LoaiNghiBaoHiemXaHoiData.ExecuteNoneQuery() > 0;
        }

    }
}
