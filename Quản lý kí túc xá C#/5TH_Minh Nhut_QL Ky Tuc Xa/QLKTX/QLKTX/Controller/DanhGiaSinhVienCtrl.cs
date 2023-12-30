using System;
using System.Collections.Generic;
using System.Text;
using QLKTX.DataLayer;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;

namespace QLKTX.Controller
{
    public class DanhGiaSinhVienCtrl
    {
        public void LayDSSVThuocKTX(ComboBoxEx com,ComboBoxEx comHocKi,DataGridViewX dgv)
        {
            if (com.SelectedIndex >= 0 && comHocKi.SelectedIndex >= 0)
            {
                DanhGiaSinhVienData data = new DanhGiaSinhVienData();
                dgv.DataSource = data.LayDSSVThuocKTX_HocKi(com.SelectedValue.ToString(), comHocKi.SelectedValue.ToString());
                dgv.Columns["MAKTX"].Visible = false;
                dgv.Columns["MAPHG"].Visible = false;
                dgv.Columns["GIOITINH"].Visible = false;                
            }
        }
        public void LayDSSVThuocPhong_HocKi(ComboBoxEx com, ComboBoxEx comHocKi, DataGridViewX dgv)
        {
            if (com.SelectedIndex >= 0 && comHocKi.SelectedIndex >= 0)
            {
                DanhGiaSinhVienData data = new DanhGiaSinhVienData();
                dgv.DataSource = data.LayDSSVThuocPhong_HocKi(com.SelectedValue.ToString(), comHocKi.SelectedValue.ToString());
                dgv.Columns["MAKTX"].Visible = false;
                dgv.Columns["MAPHG"].Visible = false;
                dgv.Columns["GIOITINH"].Visible = false;
            }
        }
        public void LayDSSVThuocDay_HocKi(ComboBoxEx com, ComboBoxEx comHocKi, DataGridViewX dgv)
        {
            if (com.SelectedIndex >= 0 && comHocKi.SelectedIndex >= 0)
            {
                DanhGiaSinhVienData data = new DanhGiaSinhVienData();
                dgv.DataSource = data.LayDSSVThuocDay_HocKi(com.SelectedValue.ToString(), comHocKi.SelectedValue.ToString());
                dgv.Columns["MAKTX"].Visible = false;
                dgv.Columns["MAPHG"].Visible = false;
                dgv.Columns["GIOITINH"].Visible = false;
            }
        }
        public void DanhGia(string MAKTX,string MAHOCKI,string MADANHGIA,string Tichcuc,string Tieucuc,string GhiChu)
        {
            DanhGiaSinhVienData data = new DanhGiaSinhVienData();
            data.DanhGia(MAKTX, MAHOCKI, MADANHGIA,Tichcuc,Tieucuc,GhiChu);
        }

        public void TimSinhVien_HocKi(ComboBoxEx comHocKi,TextBoxX ten, DataGridViewX dgv)
        {
            if (comHocKi.SelectedIndex >= 0)
            {
                DanhGiaSinhVienData data = new DanhGiaSinhVienData();
                dgv.DataSource = data.TimSinhVien_HocKi( comHocKi.SelectedValue.ToString(),ten.Text);
                dgv.Columns["MAKTX"].Visible = false;
                dgv.Columns["MAPHG"].Visible = false;
                dgv.Columns["GIOITINH"].Visible = false;
            }
        }
        public bool KiemTra(ComboBoxEx danhgia,TextBoxX tichcuc,TextBoxX tieucuc,TextBoxX ghichu)
        {
            if (danhgia.SelectedIndex < 0)
            {
                MessageBox.Show("Chưa chọn đánh giá","Loi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                danhgia.Focus();
                return false;
            }
            if (tichcuc.Text == "")
            {
                DialogResult re = MessageBox.Show("Bạn chưa nhập \"tích cực\" của sinh viên\nBạn có muốn nhập không?", "Danh gia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    tichcuc.Focus();
                    return false;
                }
            }
            if (tieucuc.Text == "")
            {
                DialogResult re = MessageBox.Show("Bạn chưa nhập \"tiêu cực\" của sinh viên\nBạn có muốn nhập không?", "Danh gia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    tieucuc.Focus();
                    return false;
                }
            }
            if (ghichu.Text == "")
            {
                DialogResult re = MessageBox.Show("Bạn chưa nhập \"Ghi chú\" của sinh viên\nBạn có muốn nhập không?", "Danh gia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (re == DialogResult.Yes)
                {
                    ghichu.Focus();
                    return false;
                }
            }
            return true;
        }
    }
}
