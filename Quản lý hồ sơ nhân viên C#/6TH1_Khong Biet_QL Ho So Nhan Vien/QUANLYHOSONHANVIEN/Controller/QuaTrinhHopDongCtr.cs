using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Data;
using System.Windows.Forms;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class QuaTrinhHopDongCtr
    {
        QuaTrinhHopDongData data = new QuaTrinhHopDongData();
        ChucVuData data_CV = new ChucVuData();
        ThongTinNhanSuData data_nv = new ThongTinNhanSuData();
        public void HienthiQuaTrinhHOPDONGGridview(System.Windows.Forms.DataGridView dg, string manv)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachQuaTrinhHOPDONG(manv);
            bs.DataSource = tbl;
            //bn.BindingSource = bs;
            dg.DataSource = bs;
        }
        public void HienThiDataGridViewCombobox(DataGridViewComboBoxColumn cmd)
        {
            cmd.DataSource = data_CV.DanhsachChucVu();
            cmd.ValueMember = "MACV";
            cmd.DisplayMember = "TENCV";
            cmd.DataPropertyName = "chucvu";
            //cmd.HeaderText = "Chức Vụ";
        }

        public void HienThiAutoCombobox(ComboBox cmb)
        {
            DataTable tbl = data_CV.DanhsachChucVu();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENCV";
            cmb.ValueMember = "MACV";
        }
        public void HienthinvCombobox(DevComponents.DotNetBar.Controls.ComboBoxEx cmb)
        {
            DataTable tbl = data_nv.DanhsachNhanVien();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "HOTEN";
            cmb.ValueMember = "MANV";
        }
    }
}
