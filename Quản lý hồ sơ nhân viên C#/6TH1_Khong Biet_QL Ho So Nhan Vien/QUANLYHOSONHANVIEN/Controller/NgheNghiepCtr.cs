using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Windows.Forms;
using System.Data;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class NgheNghiepCtr
    {
        NgheNghiepData data = new NgheNghiepData();

        public void HienthiNgheNghiepDataGridview(System.Windows.Forms.DataGridView dg)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachNGHENGHIEP();
            bs.DataSource = tbl;
            //bn.BindingSource = bs;
            dg.DataSource = bs;

        }

        public void HienThiDataGridViewCombobox(DataGridViewComboBoxColumn cmd)
        {
            cmd.DataSource = data.DanhsachNGHENGHIEP();
            cmd.ValueMember = "MANN";
            cmd.DisplayMember = "TENNN";
            cmd.DataPropertyName = "TENNGHENGHIEP";
            //cmd.HeaderText = "Chức Vụ";
        }

        public void HienThiAutoCombobox(ComboBox cmb)
        {
            DataTable tbl = data.DanhsachNGHENGHIEP();
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
