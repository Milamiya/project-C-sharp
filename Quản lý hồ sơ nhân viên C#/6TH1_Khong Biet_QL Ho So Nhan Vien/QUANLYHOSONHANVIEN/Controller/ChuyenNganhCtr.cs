using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Windows.Forms;
using System.Data;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class ChuyenNganhCtr
    {
        ChuyenNganhData data = new ChuyenNganhData();

        public void HienthiNganhDaoTaoDataGridview(System.Windows.Forms.DataGridView dg)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachChuyenNganh();
            bs.DataSource = tbl;
            dg.DataSource = bs;

        }
        public void HienthiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataSource = data.DanhsachChuyenNganh();
            cmb.DisplayMember = "NGANHDAOTAO";
            cmb.ValueMember = "MACHUYENNGANH";
            cmb.DataPropertyName = "chuyennganh";
            cmb.AutoComplete = true;
        }

        public void HienThiAutoCombobox(ComboBox cmb)
        {
            DataTable tbl = data.DanhsachChuyenNganh();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "NGANHDAOTAO";
            cmb.ValueMember = "MACHUYENNGANH";
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
