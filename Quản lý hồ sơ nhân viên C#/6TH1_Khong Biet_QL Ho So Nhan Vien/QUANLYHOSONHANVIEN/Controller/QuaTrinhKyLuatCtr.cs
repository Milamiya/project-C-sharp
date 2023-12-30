using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Data;
using System.Windows.Forms;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class QuaTrinhKyLuatCtr
    {
        QuaTrinhKyLuatData data = new QuaTrinhKyLuatData();
        ThongTinNhanSuData data_thongtinnhansu = new ThongTinNhanSuData();

        public void HienthiQuaTrinhKYLUATGGridview(System.Windows.Forms.DataGridView dg, string manv)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachQuaTrinhKYLUAT(manv);
            bs.DataSource = tbl;
            //bn.BindingSource = bs;
            dg.DataSource = bs;
        }
        public void HienthinvCombobox(DevComponents.DotNetBar.Controls.ComboBoxEx cmb)
        {
            DataTable tbl = data_thongtinnhansu.DanhsachNhanVien();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "HOTEN";
            cmb.ValueMember = "MANV";
        }
        public void HienthiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataSource = data_thongtinnhansu.DanhsachNhanVien();
            cmb.DisplayMember = "HOTEN";
            cmb.ValueMember = "MANV";
            cmb.DataPropertyName = "NGUOIKY";
            cmb.AutoComplete = true;
        }
    }
}
