using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Windows.Forms;
using System.Data;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class NgoaiNguCtr
    {
        NgoaiNguData data = new NgoaiNguData();

        public void HienthiNGOAINGUDataGridview(System.Windows.Forms.DataGridView dg)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachNGOAINGU();
            bs.DataSource = tbl;
            //bn.BindingSource = bs;
            dg.DataSource = bs;

        }

        public void HienThiDataGridViewCombobox(DataGridViewComboBoxColumn cmd)
        {
            cmd.DataSource = data.DanhsachNGOAINGU();
            cmd.ValueMember = "MANN";
            cmd.DisplayMember = "TENNN";
            cmd.DataPropertyName = "TENNGOAINGU";
            //cmd.HeaderText = "Chức Vụ";
        }

        public void HienThiAutoCombobox(ComboBox cmb)
        {
            DataTable tbl = data.DanhsachNGOAINGU();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENNN";
            cmb.ValueMember = "MANN";
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
