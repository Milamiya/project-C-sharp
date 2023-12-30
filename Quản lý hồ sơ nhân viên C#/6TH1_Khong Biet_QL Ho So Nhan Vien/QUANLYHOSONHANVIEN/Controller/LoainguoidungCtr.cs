using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Data;
using System.Windows.Forms;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class LoainguoidungCtr
    {
        LoainguoidungData data = new LoainguoidungData();

        public void HienthiChucVuDataGridview(System.Windows.Forms.DataGridView dg, System.Windows.Forms.BindingNavigator bn)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachLOAINGUOIDUNG();
            bs.DataSource = tbl;
            bn.BindingSource = bs;
            dg.DataSource = bs;

        }

        public void HienthiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmd)
        {
            cmd.DataSource = data.DanhsachLOAINGUOIDUNG();
            cmd.ValueMember = "maloainguoidung";
            cmd.DisplayMember = "tenloainguoidung";
            cmd.DataPropertyName = "quyen";
            cmd.AutoComplete = true;
        }

        public void HienThiAutoCombobox(ComboBox cmb)
        {
            DataTable tbl = data.DanhsachLOAINGUOIDUNG();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "tenloainguoidung";
            cmb.ValueMember = "maloainguoidung";
        }
        public DataRow NewRow()
        {
            return data.NewRow();
        }
        public void Add(DataRow row)
        {
            data.Add(row);
        }
        public bool Save()
        {
            return data.Save();
        }
    }
}
