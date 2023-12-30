using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKTX.Controller;
using QLKTX.SinhVien;
namespace QLKTX
{
    public partial class frmDiemDanhSinhVien : Form
    {
        public frmDiemDanhSinhVien()
        {
            InitializeComponent();
        }

        private void frmDiemDanhSinhVien_Load(object sender, EventArgs e)
        {
            KTXCtrl ctrlKTX = new KTXCtrl();
            ctrlKTX.LayDSKTXLenComboBox(cmbKTX);

            PhongCtrl ctrlPhong = new PhongCtrl();
            ctrlPhong.LayDuLieuLenComboBox(cmbPhong);

            DayCtrl ctrlDay = new DayCtrl();
            ctrlDay.LayDuLieuLenComboBox(cmbDay);
        }

        private void chkNgayHienTai_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNgayHienTai.Checked)
            {
                dateNgayHienTai.Enabled = false;
            }
            else
            {
                dateNgayHienTai.Enabled = true;
            }

        }

        private void cmbKTX_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DayCtrl dayCtrl = new DayCtrl();
            dayCtrl.LayDuLieuLenComboBox_DK_KTX(cmbDay, cmbKTX.SelectedValue.ToString());
            
            DiemDanhCtrl diemdanhCtrl = new DiemDanhCtrl();
            diemdanhCtrl.Tim_DiemDanh_Dk_KTX(dtDanhSach, cmbKTX);
        }

        private void cmbDay_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PhongCtrl phongCtrl = new PhongCtrl();
            phongCtrl.LayDuLieuLenComboBox_DK_DAY(cmbPhong, cmbDay.SelectedValue.ToString());
            
            DiemDanhCtrl diemdanhCtrl = new DiemDanhCtrl();
            diemdanhCtrl.Tim_DiemDanh_Dk_Day(dtDanhSach, cmbDay);   
            
        }

        private void cmbPhong_SelectionChangeCommitted(object sender, EventArgs e)
        {            
            DiemDanhCtrl diemdanhCtrl = new DiemDanhCtrl();
            diemdanhCtrl.Tim_DiemDanh_Dk_Phong(dtDanhSach, cmbPhong);
        }

        private void btnCoPhep_Click(object sender, EventArgs e)
        {
            if (dtDanhSach.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in dtDanhSach.SelectedRows)
                {
                    DiemDanhCtrl ctrl = new DiemDanhCtrl();
                    if(chkNgayHienTai.Checked==true)
                        ctrl.Them(ctrl.DataToInfo(r,DateTime.Now,true));
                    else ctrl.Them(ctrl.DataToInfo(r, dateNgayHienTai.Value, true));
                }
            }
        }

        private void btnKhongPhep_Click(object sender, EventArgs e)
        {
            if (dtDanhSach.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in dtDanhSach.SelectedRows)
                {
                    DiemDanhCtrl ctrl = new DiemDanhCtrl();
                    ctrl.Them(ctrl.DataToInfo(r, DateTime.Now, false));
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            frmTraCuuSinhVien tracuu = new frmTraCuuSinhVien();
            //tracuu.MdiParent = this.MdiParent;
            tracuu.ShowDialog();
            //tracuu.Show();
            if (tracuu.DialogResult == DialogResult.OK)
            {
                DiemDanhCtrl ctrl = new DiemDanhCtrl();
                ctrl.Tim_DiemDanh_Dk_MaKTX(dtDanhSach, tracuu.Masinhvien);
                
            }
        }

              
    }
}