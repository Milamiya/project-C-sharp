using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Data;
using System.Windows.Forms;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class NganhHocCtr
    {
        NganhHocData data = new NganhHocData();

        public void HienthiNganhHocDataGridview(System.Windows.Forms.DataGridView dg)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachNganhHoc();
            bs.DataSource = tbl;
            dg.DataSource = bs;

        }
        public void HienThiAutoCombobox(ComboBox cmb)
        {
            DataTable tbl = data.DanhsachNganhHoc();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "tennh";
            cmb.ValueMember = "manh";
        }
    }
}
