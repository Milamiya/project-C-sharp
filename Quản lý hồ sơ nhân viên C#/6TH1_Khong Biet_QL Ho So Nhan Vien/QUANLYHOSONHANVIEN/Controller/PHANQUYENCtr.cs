using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Windows.Forms;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class PHANQUYENCtr
    {
        PhanQuyenData data = new PhanQuyenData();
        public void HienthiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataSource = data.DanhsachPHANQUYEN();
            cmb.DisplayMember = "TENPQ";
            cmb.ValueMember = "MAPQ";
            cmb.DataPropertyName = "MAPQ";
            cmb.AutoComplete = true;
        }
    }
}
