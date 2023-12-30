using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Data;
using System.Windows.Forms;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class CongViecCtr
    {
        CongViecData data = new CongViecData();

        public void HienthiCONGVIECDataGridview(System.Windows.Forms.DataGridView dg)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachCONGVIEC();
            bs.DataSource = tbl;
            //bn.BindingSource = bs;
            dg.DataSource = bs;

        }

        public void HienThiDataGridViewCombobox(DataGridViewComboBoxColumn cmd)
        {
            cmd.DataSource = data.DanhsachCONGVIEC();
            cmd.ValueMember = "MACV";
            cmd.DisplayMember = "TENCV";
            cmd.DataPropertyName = "TENCONGVIEC";
            //cmd.HeaderText = "Chức Vụ";
        }

        public void HienThiAutoCombobox(ComboBox cmb)
        {
            DataTable tbl = data.DanhsachCONGVIEC();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENCV";
            cmb.ValueMember = "MACV";
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
