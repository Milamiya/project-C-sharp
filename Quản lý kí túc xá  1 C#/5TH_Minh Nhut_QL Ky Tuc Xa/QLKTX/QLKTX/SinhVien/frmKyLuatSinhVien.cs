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
    public partial class frmKyLuatSinhVien : Form
    {
        PhongCtrl phgctrl = new PhongCtrl();
        DayCtrl dayctrl = new DayCtrl();
        KTXCtrl ktxctrl = new KTXCtrl();
        KyLuatSinhVienCtrl kyluatsinhvien = new KyLuatSinhVienCtrl();
        CapCtrl capctrl=new CapCtrl();
        CanBoCtrl canboctrl = new CanBoCtrl();
        KyLuatCtrl klctrl=new KyLuatCtrl();
        string maktx;
        int makyluat;
        DateTime ngay;

        public frmKyLuatSinhVien()
        {
            InitializeComponent();
        }

        private void frmKyLuatSinhVien_Load(object sender, EventArgs e)
        {
            phgctrl.LayDuLieuLenComboBox(cmbPhong);
            dayctrl.LayDuLieuLenComboBox(cmbDay);
            ktxctrl.LayDSKTXLenComboBox(cmbKTX);
            capctrl.LayDuLieuLenComboBox(cmbCap);
            canboctrl.LayDuLieuLenComboBox(cmbCanBo);
            klctrl.LayComboboxKyLuat(cmbKyLuat);
        }

        private void cmbKTX_SelectionChangeCommitted(object sender, EventArgs e)
        {
            phgctrl.LayDuLieuLenComboBox_DK_DAY(cmbPhong, cmbKTX.SelectedValue.ToString());
            kyluatsinhvien.LayDSSVThuocKTX(cmbKTX, dtDanhSach);
        }

        private void cmbPhong_SelectionChangeCommitted(object sender, EventArgs e)
        {
            kyluatsinhvien.LayDSSVThuocPhong(cmbPhong, dtDanhSach);
        }

        private void cmbDay_SelectionChangeCommitted(object sender, EventArgs e)
        {
            phgctrl.LayDuLieuLenComboBox_DK_DAY(cmbPhong, cmbDay.SelectedValue.ToString());
            kyluatsinhvien.LayDSSVThuocDay(cmbDay, dtDanhSach);
        }

        private void btnCap_Click(object sender, EventArgs e)
        {
            Dialog.DiaLog_Them_Sua_Cap cap = new QLKTX.Dialog.DiaLog_Them_Sua_Cap();
            cap.ShowDialog();
            capctrl.LayDuLieuLenComboBox(cmbCap);            
        }

        private void btnCanBo_Click(object sender, EventArgs e)
        {
            QLKTX.frmCanBo canbo = new frmCanBo();
            canbo.ShowDialog();
            canboctrl.LayDuLieuLenComboBox(cmbCanBo);
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            Dialog.DiaLog_ThemKyLuat kl = new QLKTX.Dialog.DiaLog_ThemKyLuat();
            kl.ShowDialog();
            klctrl.LayComboboxKyLuat(cmbKyLuat);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            kyluatsinhvien.KyLuat(lblMAKTX, dateNgay, txtQDS, cmbKyLuat, cmbCap, cmbCanBo, txtLyDo);
            dtDanhSach_MouseClick(sender, (MouseEventArgs)(e));

        }


        private void dtDanhSach_MouseClick(object sender, MouseEventArgs e)
        {
            if (dtDanhSach.SelectedRows.Count > 0)
            {
                btnLuu.Enabled = true;
                btnCapNhat.Enabled = false;
                btnHuy.Enabled = false;

                DataGridViewRow row = dtDanhSach.SelectedRows[0];
                lblHoTen.Text = row.Cells["colHoTen"].Value.ToString();
                maktx = lblMAKTX.Text = row.Cells["MAKTX"].Value.ToString();
                lblPhong.Text = row.Cells["colPhong"].Value.ToString();
                lblDay.Text = row.Cells["colDay"].Value.ToString();
                lblKTX.Text = row.Cells["ColKTX"].Value.ToString();
                // lblGioiTinh.Text = row.Cells["GIOITINH"].Value.ToString() == "True" ? "Nam" : "Nữ";
                kyluatsinhvien.LayKyLuatSinhVien_Theo_MAKTX(lblMAKTX.Text, dataChiTiet);
            }

        }

        private void dataChiTiet_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataChiTiet.SelectedRows.Count > 0)
            {
                btnLuu.Enabled = false;
                btnCapNhat.Enabled = true;
                btnHuy.Enabled = true;

                DataGridViewRow row = dataChiTiet.SelectedRows[0];
                maktx = row.Cells["colMAKTX"].Value.ToString();
                makyluat = Convert.ToInt32(row.Cells["colMAKYLUAT"].Value.ToString());
                ngay = Convert.ToDateTime(row.Cells["colNGAY"].Value);

                cmbCanBo.SelectedValue = row.Cells["colMACBQL"].Value.ToString();
                cmbCap.SelectedValue = row.Cells["colMACap"].Value.ToString();
                cmbKyLuat.SelectedValue = row.Cells["colMAKYLUAT"].Value.ToString();
                txtLyDo.Text = row.Cells["colLYDO"].Value.ToString();
                txtQDS.Text = row.Cells["colQDS"].Value.ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dataChiTiet.SelectedRows.Count > 0)
            {
                kyluatsinhvien.SuaKyLuat(lblMAKTX, dateNgay, txtQDS, cmbKyLuat, cmbCap, cmbCanBo, txtLyDo, maktx, makyluat, ngay);
                dtDanhSach_MouseClick(sender, (MouseEventArgs)(e));
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dataChiTiet.SelectedRows.Count > 0)
            {
                kyluatsinhvien.XoaKyLuat(maktx, makyluat, ngay);
                dtDanhSach_MouseClick(sender, (MouseEventArgs)(e));
            }
        }

        
    }
}