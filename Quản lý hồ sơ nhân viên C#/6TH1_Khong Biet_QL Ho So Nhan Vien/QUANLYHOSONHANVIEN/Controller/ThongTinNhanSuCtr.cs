using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Data;
using System.Windows.Forms;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class ThongTinNhanSuCtr
    {
        ThongTinNhanSuData data = new ThongTinNhanSuData();
        PhongBanData data_phongban = new PhongBanData();
        public void HienthiDataGridviewNhanVienTheoPhong(DevComponents.DotNetBar.Controls.DataGridViewX dg, string maphong,string trangthai)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachNhanVienTheoPhong(maphong,trangthai);
            bs.DataSource = tbl;
            //bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public void HienThiPhongBanComBoBox(ComboBox cmb)
        {
            string[] Fisrt = { "%", "Tất Cả" };
            DataTable tbl = data_phongban.DanhsachPhongBan();
            tbl.Rows.Add(Fisrt);
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENPB";
            cmb.ValueMember = "MAPB";
        }

        public void HienthinvCombobox(DevComponents.DotNetBar.Controls.ComboBoxEx cmb)
        {
            DataTable tbl = data.DanhsachNhanVien();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "HOTEN";
            cmb.ValueMember = "MANV";
        }
    }
}
