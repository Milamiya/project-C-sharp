using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Windows.Forms;
using System.Data;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class PhongBanCtr
    {
        PhongBanData data = new PhongBanData();

        public void HienthiPhongBnDataGridview(System.Windows.Forms.DataGridView dg)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachPhongBan();
            bs.DataSource = tbl;
            //bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public void HienthiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataSource = data.DanhsachPhongBan();
            cmb.DisplayMember = "TENPB";
            cmb.ValueMember = "MAPB";
            cmb.AutoComplete = true;
        }

        public void HienThiAutoCombobox(ComboBox cmb)
        {
            DataTable tbl = data.DanhsachPhongBan();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENPB";
            cmb.ValueMember = "MAPB";
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

        public  void HienThiPhongBanComBoBox(DevComponents.DotNetBar.Controls.ComboBoxEx cmb)
        {
            string[] Fisrt = { "%", "Tất Cả" };
            DataTable tbl = data.DanhsachPhongBan();
            tbl.Rows.Add(Fisrt);
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENPB";
            cmb.ValueMember = "MAPB";
        }
    }
}
