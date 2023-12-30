using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Windows.Forms;
using System.Data;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class DotDanhGiaCtr
    {
        DotDanhGiaData data = new DotDanhGiaData();

        public void HienthiDOTDANHGIADataGridview(System.Windows.Forms.DataGridView dg)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachDOTDANHGIA();
            bs.DataSource = tbl;
            dg.DataSource = bs;

        }
        public void HienthiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataSource = data.DanhsachDOTDANHGIA();
            cmb.DisplayMember = "TENDDG";
            cmb.ValueMember = "MADDG";
            cmb.DataPropertyName = "DOTDANHGIA";
            cmb.AutoComplete = true;
        }

        public void HienThiAutoCombobox(ComboBox cmb)
        {
            DataTable tbl = data.DanhsachDOTDANHGIA();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENDDG";
            cmb.ValueMember = "MADDG";
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
