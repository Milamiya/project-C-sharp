using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyHoSoCongChuc.BusinessObject;
using QuanLyHoSoCongChuc.Controller;
using QuanLyHoSoCongChuc.DataLayer;

namespace QuanLyHoSoCongChuc.DataLayer
{
    public class LoaiDonViData
    {
        DataService m_LoaiDonViData = new DataService();
        public DataTable LayDanhSachLoaiDonVi()
        {
             SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiDonVi");
            m_LoaiDonViData.Load(cmd);
            return m_LoaiDonViData;
        }
    }
}
