using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Windows.Forms;
using System.Data;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class NganhDaoTaoCtr
    {
        NganhDaoTaoData data = new NganhDaoTaoData();

        public void HienthiNganhDaoTaoDataGridview(System.Windows.Forms.DataGridView dg)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachNganhDaoTao();
            bs.DataSource = tbl;
            dg.DataSource = bs;

        }
        public void HienthiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataSource = data.DanhsachNganhDaoTao();
            cmb.DisplayMember = "TENNGANH";
            cmb.ValueMember = "MANGANH";
            cmb.DataPropertyName = "CHUCVUCAONHAT";
            cmb.AutoComplete = true;
        }

        public void HienThiAutoCombobox(ComboBox cmb)
        {
            DataTable tbl = data.DanhsachNganhDaoTao();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENNGANH";
            cmb.ValueMember = "MANGANH";
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
