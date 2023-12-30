using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QuanLyHoSoCongChuc.DataLayer;
using QuanLyHoSoCongChuc.BusinessObject;

namespace QuanLyHoSoCongChuc.Controller
{
    public class Huong85Control
    {
        Huong85Data m_Huong85Data = new Huong85Data();


        public void HienThiComboBox(ComboBox cmb)
        {
            cmb.DataSource = m_Huong85Data.LayGiaTri();
            cmb.DisplayMember = "GiaTriHuong";
            cmb.ValueMember = "MaHuong";
        }
    }
}
