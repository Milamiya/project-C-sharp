using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Windows.Forms;
using System.Data;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class HinhThucKhenThuongCtr
    {
        HinhThucKhenThuongData data = new HinhThucKhenThuongData();
        public void HienthiHINHTHUCKTHUONGDataGridview(System.Windows.Forms.DataGridView dg)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachHINHTHUCKHETHUONG();
            bs.DataSource = tbl;
            dg.DataSource = bs;

        }
        public void HienThiAutoCombobox(ComboBox cmb)
        {
            DataTable tbl = data.DanhsachHINHTHUCKHETHUONG();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENHTKT";
            cmb.ValueMember = "MAHTKT";
        }
    }
}
