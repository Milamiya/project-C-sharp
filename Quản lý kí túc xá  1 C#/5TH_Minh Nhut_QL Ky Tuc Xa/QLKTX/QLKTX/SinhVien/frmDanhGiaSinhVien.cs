using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using QLKTX.Controller;
namespace QLKTX
{
    public partial class frmDanhGiaSinhVien : Form
    {
        PhongCtrl phgctrl = new PhongCtrl();
        DayCtrl dayctrl = new DayCtrl();
        KTXCtrl ktxctrl = new KTXCtrl();
        HocKiCtrl hockictrl = new HocKiCtrl();
        NamHocCtrl namhocctrl = new NamHocCtrl();
        DanhGiaCtrl danhgiactrl = new DanhGiaCtrl();
        DanhGiaSinhVienCtrl danhgiasinhvienctrl = new DanhGiaSinhVienCtrl();
        string maktx = "";
        string mahocki = "";
        int load = -1;//1 KTX 2 Day 3 Phong
        public frmDanhGiaSinhVien()
        {
            InitializeComponent();
        }

        private void frmDanhGiaSinhVien_Load(object sender, EventArgs e)
        {
            phgctrl.LayDuLieuLenComboBox(cmbPhong);
            dayctrl.LayDuLieuLenComboBox(cmbDay);
            ktxctrl.LayDSKTXLenComboBox(cmbKTX);
            namhocctrl.LayDSNamHoc(cmbNamHoc);
            danhgiactrl.LayComboboxDanhGia(cmbDanhGia);

        }

        private void dtDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtDanhSach.Rows.Count)
            {
                
            }
        }

        private void btnThemDanhGia_Click(object sender, EventArgs e)
        {            
            QLKTX.Dialog.DiaLog_ThemDanhGia danhgia = new QLKTX.Dialog.DiaLog_ThemDanhGia();
            danhgia.StartPosition = FormStartPosition.Manual;


            danhgia.Top = this.Location.Y + groupPanel1.Location.Y + btnThemDanhGia.Location.Y+45;
            danhgia.Left = this.Location.X + groupPanel1.Location.X + btnThemDanhGia.Location.X+5;
            danhgia.ShowDialog();
            danhgiactrl.LayComboboxDanhGia(cmbDanhGia);
        }

        private void btnThemHocKi_Click(object sender, EventArgs e)
        {
            frmHocKi hocki = new frmHocKi();
            hocki.ShowDialog();
            hockictrl.LayDSHocKiLenComboBox_DK_NamHoc(cmbHocKi,cmbNamHoc.SelectedValue.ToString());
        }

        private void cmbKTX_SelectionChangeCommitted(object sender, EventArgs e)
        {
            load = 1;
            dayctrl.LayDuLieuLenComboBox_DK_KTX(cmbDay, cmbKTX.SelectedValue.ToString());
            danhgiasinhvienctrl.LayDSSVThuocKTX(cmbKTX,cmbHocKi, dtDanhSach);
        }

        private void cmbDay_SelectionChangeCommitted(object sender, EventArgs e)
        {
            load = 2;
            phgctrl.LayDuLieuLenComboBox_DK_DAY(cmbPhong, cmbDay.SelectedValue.ToString());
            danhgiasinhvienctrl.LayDSSVThuocDay_HocKi(cmbDay, cmbHocKi, dtDanhSach);
        }

        private void cmbPhong_SelectionChangeCommitted(object sender, EventArgs e)
        {
            load = 3;
            danhgiasinhvienctrl.LayDSSVThuocPhong_HocKi(cmbPhong, cmbHocKi, dtDanhSach);
        }

        
        private void dtDanhSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dtDanhSach.SelectedRows.Count > 0)
            {                
                DataGridViewRow row= dtDanhSach.SelectedRows[0];
                lblHoTen.Text = row.Cells["colHoTen"].Value.ToString();
                maktx= lblMa.Text = row.Cells["MAKTX"].Value.ToString();
                lblPhong.Text = row.Cells["colPhong"].Value.ToString();
                lblDay.Text = row.Cells["colDay"].Value.ToString();
                lblKTX.Text = row.Cells["ColKTX"].Value.ToString();
                lblGioiTinh.Text = row.Cells["GIOITINH"].Value.ToString() == "True" ? "Nam" : "Nữ";
                mahocki = cmbHocKi.SelectedValue.ToString();
            }
        }

        private void cmbNamHoc_SelectionChangeCommitted(object sender, EventArgs e)
        {            
            hockictrl.LayDSHocKiLenComboBox_DK_NamHoc(cmbHocKi, cmbNamHoc.SelectedValue.ToString());
            
            danhgiasinhvienctrl.LayDSSVThuocPhong_HocKi(cmbPhong, cmbHocKi, dtDanhSach);
            load = 3;
        }

        private void cmbHocKi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            danhgiasinhvienctrl.LayDSSVThuocPhong_HocKi(cmbPhong, cmbHocKi, dtDanhSach);
            load = 3;
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            if (dtDanhSach.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chưa chọn Sinh viên!", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (danhgiasinhvienctrl.KiemTra(cmbDanhGia, txtTichCuc, txtTieuCuc, txtGhiChu))
            {
                if (dtDanhSach.SelectedRows.Count > 1)
                {
                    DialogResult re = MessageBox.Show("Bạn có muốn Đánh giá cho " + dtDanhSach.SelectedRows.Count + " Sinh viên này không?", "Danh gia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (re == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dtDanhSach.SelectedRows)
                        {
                            danhgiasinhvienctrl.DanhGia(row.Cells["MAKTX"].Value.ToString(), cmbHocKi.SelectedValue.ToString(), cmbDanhGia.SelectedValue.ToString(),txtTichCuc.Text,txtTieuCuc.Text,txtGhiChu.Text);
                        }
                    }
                }
                else
                {
                    if (dtDanhSach.SelectedRows.Count == 1)
                    {
                        danhgiasinhvienctrl.DanhGia(maktx, mahocki, cmbDanhGia.SelectedValue.ToString(), txtTichCuc.Text, txtTieuCuc.Text, txtGhiChu.Text);
                    }
                }
                switch (load)
                {
                    case 1:
                        danhgiasinhvienctrl.LayDSSVThuocKTX(cmbKTX, cmbHocKi, dtDanhSach);
                        break;
                    case 2:
                        danhgiasinhvienctrl.LayDSSVThuocDay_HocKi(cmbDay, cmbHocKi, dtDanhSach);
                        break;
                    case 3:
                        danhgiasinhvienctrl.LayDSSVThuocPhong_HocKi(cmbPhong, cmbHocKi, dtDanhSach);
                        break;
                }
                cmbDanhGia.SelectedIndex = 0;
                txtGhiChu.Text = txtTichCuc.Text = txtTieuCuc.Text = "";
            }
        }

        private void textBoxX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                danhgiasinhvienctrl.TimSinhVien_HocKi(cmbHocKi, txtTen, dtDanhSach);
        }

        
    }
}