using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class DTBDControl
    {
        DTBDData m_DTBD = new DTBDData();

        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_DTBD.LayGiaTriDTBD();
            cmb.DisplayMember = "GiaTriDTBD";
            cmb.ValueMember = "MaDTBD";
        }
    }
}
