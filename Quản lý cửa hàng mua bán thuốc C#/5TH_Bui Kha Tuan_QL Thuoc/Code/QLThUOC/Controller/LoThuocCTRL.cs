using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class LoThuocCTRL
    {
        LoThuocDATA data = new LoThuocDATA();
        public void HienThiLoThuoc(TextBox txtMaLo, TextBox txtTenLo, DateTimePicker timeNgaySanXuat, DateTimePicker timeNgayHetHan, TextBox txtSoLuong, ComboBox ctxMaThuoc, TextBox txtThanhTien, DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.LayDSLoThuoc();
            dg.DataSource = bs;
            bn.BindingSource = bs;
            txtMaLo.DataBindings.Add("Text", bs, "MALO");
            txtTenLo.DataBindings.Add("Text", bs, "TENLO");
            timeNgaySanXuat.DataBindings.Add("Text", bs, "NGAYSX");
            timeNgayHetHan.DataBindings.Add("Text", bs, "NGAYHH");
            txtSoLuong.DataBindings.Add("Text", bs, "SOLUONG");
            ctxMaThuoc.DataBindings.Add("SelectedValue", bs, "MATHUOC");
            txtThanhTien.DataBindings.Add("Text", bs, "THANHTIEN");
            //Load ComboBoxMaThuoc
            ThuocCTRL ctrlThuoc = new ThuocCTRL();
            ctrlThuoc.HienThiComboBoxMaThuoc(ctxMaThuoc);
            dg.Columns.Add(ctrlThuoc.LoadComboBoxMaThuoc());
            dg.Columns.Remove("MATHUOC");
        }
        public void TimKiemLoThuoc(TextBox txtMaLo, ComboBox ctxChonTenLo, TextBox txtTenLo, ComboBox ctxChonMaThuoc, TextBox txtMaThuoc, DataGridView dg)
        {
            DataTable table = data.TimKiemLoThuoc(txtMaLo.Text, ctxChonTenLo.Text, txtTenLo.Text, ctxChonMaThuoc.Text, txtMaThuoc.Text);
            dg.DataSource = table;
        }
        public void Update()
        {
            data.Update();
        }
    }
}
