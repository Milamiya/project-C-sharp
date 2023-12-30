using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Windows.Forms;
using System.Data;

namespace QUANLYHOSONHANVIEN.Controller
{
    class TrinhDoCtr
    {
        TrinhDoData data = new TrinhDoData();

        public void HienthiTRINHDODataGridview(System.Windows.Forms.DataGridView dg)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachTRINHDO();
            bs.DataSource = tbl;
            dg.DataSource = bs;

        }
        public void HienThiAutoCombobox(ComboBox cmb)
        {
            DataTable tbl = data.DanhsachTRINHDO();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENTD";
            cmb.ValueMember = "MATD";
        }
    }
}
