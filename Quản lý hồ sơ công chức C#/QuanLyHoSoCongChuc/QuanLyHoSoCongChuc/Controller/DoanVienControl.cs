using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class DoanVienControl
    {
        DoanVienData m_DoanVienData = new DoanVienData();

        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_DoanVienData.LayGiaTriDoanVien();
            cmb.DisplayMember = "GiaTri";
            cmb.ValueMember = "MaDoanVien";
        }
    }
}
