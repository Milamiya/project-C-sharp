using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Data;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class QuaTrinhKhenThuongCtr
    {
        QuaTrinhKhenThuongData data = new QuaTrinhKhenThuongData();
        ThongTinNhanSuData data_thongtinnhansu = new ThongTinNhanSuData();
        public void HienthiQuaTrinhKHENTHUONGGridview(System.Windows.Forms.DataGridView dg, string manv)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachQuaTrinhKT(manv);
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
    }
}
