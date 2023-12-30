using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Windows.Forms;
using System.Data;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class TrinhDoTinHocCtr
    {
        TrinhDoTinHocData data = new TrinhDoTinHocData();
        ThongTinNhanSuData data_tt = new ThongTinNhanSuData();

        public void HienthiTRINHDOTINHOCDataGridview(System.Windows.Forms.DataGridView dg )
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachTRINHDOTINHOC();
            bs.DataSource = tbl;
            //bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public void HienthiDataGridViewComboBoxColumnNgheNgiep(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataSource = data.DanhsachTRINHDOTINHOC();
            cmb.DisplayMember = "TENTDTH";
            cmb.ValueMember = "MATDTH";
            //cmb.DataPropertyName = "MANGHE";
            cmb.AutoComplete = true;
        }

        public void HienThiAutoCombobox(ComboBox cmb)
        {
            DataTable tbl = data.DanhsachTRINHDOTINHOC();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENTDTH";
            cmb.ValueMember = "MATDTH";
        }
        public void HienthinvCombobox(DevComponents.DotNetBar.Controls.ComboBoxEx cmb)
        {
            DataTable tbl = data_tt.DanhsachNhanVien();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "HOTEN";
            cmb.ValueMember = "MANV";
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
