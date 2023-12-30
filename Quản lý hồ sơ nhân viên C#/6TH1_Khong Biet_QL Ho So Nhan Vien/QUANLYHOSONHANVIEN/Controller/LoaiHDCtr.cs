using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Windows.Forms;
using System.Data;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class LoaiHDCtr
    {
        LoaiHDdata data = new LoaiHDdata();
        public void HienthiLOAIHDDataGridview(System.Windows.Forms.DataGridView dg)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachLOAIHD();
            bs.DataSource = tbl;
            dg.DataSource = bs;

        }
        public void HienThiAutoCombobox(ComboBox cmb)
        {
            DataTable tbl = data.DanhsachLOAIHD();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "tenloaihd";
            cmb.ValueMember = "maloaihd";
        }
    }
}
