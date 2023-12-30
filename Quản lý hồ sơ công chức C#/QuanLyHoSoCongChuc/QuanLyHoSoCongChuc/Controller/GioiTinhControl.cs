using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;


namespace QuanLyHoSoCongChuc.Controller
{
    public class GioiTinhCotrol
    {
        GioiTinhData m_GioiTinhData = new GioiTinhData();


        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_GioiTinhData.LayDsGioiTinh();
            cmb.DisplayMember = "TenGioiTinh";
            cmb.ValueMember = "MaGioiTinh";
        }
    }
}
