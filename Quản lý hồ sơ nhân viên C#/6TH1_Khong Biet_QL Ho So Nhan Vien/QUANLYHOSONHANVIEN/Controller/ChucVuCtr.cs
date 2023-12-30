using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Windows.Forms;
using System.Data;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class ChucVuCtr
    {
        ChucVuData data = new ChucVuData();

        public void HienthiChucVuDataGridview(System.Windows.Forms.DataGridView dg)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachChucVu();
            bs.DataSource = tbl;
            //bn.BindingSource = bs;
            dg.DataSource = bs;

        }

        public void HienThiDataGridViewCombobox(DataGridViewComboBoxColumn cmd)
        {
            cmd.DataSource = data.DanhsachChucVu();
            cmd.ValueMember = "MACV";
            cmd.DisplayMember = "TENCV";
            cmd.DataPropertyName = "MACV";
            //cmd.HeaderText = "Chức Vụ";
        }

        public void HienThiAutoCombobox(ComboBox cmb)
        {
            DataTable tbl = data.DanhsachChucVu();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENCV";
            cmb.ValueMember = "MACV";
        }
        public void HienThiAutoCombobox1(ComboBox cmb)
        {
            DataTable tbl = data.DanhsachChucVu();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENCV";
            cmb.ValueMember = "MACV";
            //cmb.DataPropertyName = "MACHUCVU";
        }
        public void HienThiAutoCombobox2(ComboBox cmb)
        {
            DataTable tbl = data.DanhsachChucVu();
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
