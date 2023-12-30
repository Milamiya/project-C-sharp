using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Data;
using System.Windows.Forms;
namespace QUANLYHOSONHANVIEN.Controller
{
    public class HinhThucKyLuatCtr
    {
        HinhThucKyLuatData data = new HinhThucKyLuatData();
        ThongTinNhanSuData data_thongtinnhansu = new ThongTinNhanSuData();
        public void HienthiKYLUATDataGridview(System.Windows.Forms.DataGridView dg)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachHINHTHUCKYLUAT();
            bs.DataSource = tbl;
            dg.DataSource = bs;

        }

        public void HienthiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataSource = data.DanhsachHINHTHUCKYLUAT();
            cmb.DisplayMember = "TENKL";
            cmb.ValueMember = "MAKL";
            cmb.DataPropertyName = "";
            cmb.AutoComplete = true;
            cmb.HeaderText = "";
        }

        public void HienThiAutoCombobox(ComboBox cmb)
        {
            DataTable tbl = data.DanhsachHINHTHUCKYLUAT();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENKL";
            cmb.ValueMember = "MAKL";
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
