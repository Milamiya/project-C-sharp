using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using QUANLYHOSONHANVIEN.DataLayer;
using System.Windows.Forms;
using System.Data;
namespace QUANLYHOSONHANVIEN.Controller
{
    public class ChuyenMonCtr
    {
        ChuyenMonData data = new ChuyenMonData();
        ChuyenNganhData data_chuyennganh = new ChuyenNganhData();

        public void HienthiCHUYENMONDataGridview(System.Windows.Forms.DataGridView dg, string manv)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachCHUYENMON(manv);
            bs.DataSource = tbl;
            //bn.BindingSource = bs;
            dg.DataSource = bs;
        }
        public void HienthiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataSource = data_chuyennganh.DanhsachChuyenNganh();
            cmb.DisplayMember = "hedaotao";
            cmb.ValueMember = "MACHUYENNGANH";
            cmb.DataPropertyName = "chuyenmon";
            cmb.AutoComplete = true;
        }

        public void HienThiAutoCombobox(ComboBox cmb)
        {
            DataTable tbl = data_chuyennganh.DanhsachChuyenNganh();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "NGANHDAOTAO";
            cmb.ValueMember = "MACHUYENNGANH";
        }
    }
}
