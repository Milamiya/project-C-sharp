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
    public partial class frmHoatDongSinhVien : Form
    {
        PhongCtrl phgctrl = new PhongCtrl();
        DayCtrl dayctrl = new DayCtrl();
        KTXCtrl ktxctrl = new KTXCtrl();
        HoatDongSinhVienCtrl HoatDongsinhvien = new HoatDongSinhVienCtrl();
        CapCtrl capctrl=new CapCtrl();
        CanBoCtrl canboctrl = new CanBoCtrl();
        HoatDongCtrl klctrl=new HoatDongCtrl();
        string maktx;
        int maHoatDong;
        DateTime ngay;

        public frmHoatDongSinhVien()
        {
            InitializeComponent();
        }

        private void frmHoatDongSinhVien_Load(object sender, EventArgs e)
        {
            phgctrl.LayDuLieuLenComboBox(cmbPhong);
            dayctrl.LayDuLieuLenComboBox(cmbDay);
            ktxctrl.LayDSKTXLenComboBox(cmbKTX);
            
            klctrl.LayDuLieuLenComboBox(cmbHoatDong);
        }

        private void cmbKTX_SelectionChangeCommitted(object sender, EventArgs e)
        {
            phgctrl.LayDuLieuLenComboBox_DK_DAY(cmbPhong, cmbKTX.SelectedValue.ToString());
            HoatDongsinhvien.LayDSSVThuocKTX(cmbKTX, dtDanhSach);
        }

        private void cmbPhong_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HoatDongsinhvien.LayDSSVThuocPhong(cmbPhong, dtDanhSach);
        }

        private void cmbDay_SelectionChangeCommitted(object sender, EventArgs e)
        {
            phgctrl.LayDuLieuLenComboBox_DK_DAY(cmbPhong, cmbDay.SelectedValue.ToString());
            HoatDongsinhvien.LayDSSVThuocDay(cmbDay, dtDanhSach);
        }

        

        private void buttonX5_Click(object sender, EventArgs e)
        {
            Dialog.DiaLog_HoatDong kl = new QLKTX.Dialog.DiaLog_HoatDong();
            kl.ShowDialog();
            klctrl.LayDuLieuLenComboBox(cmbHoatDong);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HoatDongsinhvien.HoatDong(lblMAKTX, dateNgay, cmbHoatDong, txtGhiChu);
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
                HoatDongsinhvien.LayHoatDongSinhVien_Theo_MAKTX(lblMAKTX.Text, dataChiTiet);
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
                maHoatDong = Convert.ToInt32(row.Cells["colMAHoatDong"].Value.ToString());
                ngay = Convert.ToDateTime(row.Cells["colNGAY"].Value);

                
                
                cmbHoatDong.SelectedValue = row.Cells["colMAHoatDong"].Value.ToString();
                txtGhiChu.Text = row.Cells["colGhiChu"].Value.ToString();
                
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dataChiTiet.SelectedRows.Count > 0)
            {
                HoatDongsinhvien.SuaHoatDong(lblMAKTX, dateNgay, cmbHoatDong, txtGhiChu, maktx, maHoatDong);
                dtDanhSach_MouseClick(sender, (MouseEventArgs)(e));
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dataChiTiet.SelectedRows.Count > 0)
            {
                HoatDongsinhvien.XoaHoatDong(maktx, maHoatDong);
                dtDanhSach_MouseClick(sender, (MouseEventArgs)(e));
            }
        }

        
    }
}