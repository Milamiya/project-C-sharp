using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Windows.Forms;
using System.Data;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class DotDaoTaoCtr
    {
        DotDaoTaoData data = new DotDaoTaoData();

        public void HienthiDOTDaoTaoDataGridview(System.Windows.Forms.DataGridView dg)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachDOTDAOTAO();
            bs.DataSource = tbl;
            dg.DataSource = bs;

        }
        public void HienthiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataSource = data.DanhsachDOTDAOTAO();
            cmb.DisplayMember = "TENDDT";
            cmb.ValueMember = "MADDT";
            cmb.DataPropertyName = "dotdaotao";
            cmb.AutoComplete = true;
        }

        public void HienThiAutoCombobox(ComboBox cmb)
        {
            DataTable tbl = data.DanhsachDOTDAOTAO();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENDDT";
            cmb.ValueMember = "MADDT";
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
