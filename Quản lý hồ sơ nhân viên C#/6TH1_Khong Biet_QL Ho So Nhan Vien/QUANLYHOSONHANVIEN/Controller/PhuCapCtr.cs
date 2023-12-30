using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Data;
using System.Windows.Forms;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class PhuCapCtr
    {
        PhuCapData data = new PhuCapData();
        public void HienthiHINHTHUCKTHUONGDataGridview(System.Windows.Forms.DataGridView dg)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachPHUCAP();
            bs.DataSource = tbl;
            dg.DataSource = bs;

        }
        public void HienThiAutoCombobox(ComboBox cmb)
        {
            DataTable tbl = data.DanhsachPHUCAP();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "tenpc";
            cmb.ValueMember = "mapc";
        }
    }
}
