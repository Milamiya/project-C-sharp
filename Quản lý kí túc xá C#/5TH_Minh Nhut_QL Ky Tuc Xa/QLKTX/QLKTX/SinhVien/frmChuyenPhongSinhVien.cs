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
    public partial class frmChuyenPhongSinhVien : Form
    {
        PhongCtrl phong = new PhongCtrl();
        DayCtrl day = new DayCtrl();
        KTXCtrl ktx = new KTXCtrl();
        ChuyenPhongCtrl chuyenphong = new ChuyenPhongCtrl();

        public frmChuyenPhongSinhVien()
        {
            InitializeComponent();
        }

        private void frmChuyenPhongSinhVien_Load(object sender, EventArgs e)
        {
            phong.LayDuLieuLenComboBox(cmbPhongDi);
            phong.LayDuLieuLenComboBox(cmbPhongDen);
            day.LayDuLieuLenComboBox(cmbDayDi);
            day.LayDuLieuLenComboBox(cmbDayDen);
            ktx.LayDSKTXLenComboBox(cmbKTXDi);
            ktx.LayDSKTXLenComboBox(cmbKTXDen);            
        }

        private void cmbKTXDi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            chuyenphong.LayDSSVThuocKTX(cmbKTXDi, dtPhongDi);
            day.LayDuLieuLenComboBox_DK_KTX(cmbDayDi, cmbKTXDi.SelectedValue.ToString());
        }

        private void cmbKTXDen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //chuyenphong.LayDSSVThuocKTX(cmbKTXDen, dtPhongDen);
            day.LayDuLieuLenComboBox_DK_KTX(cmbDayDen, cmbKTXDen.SelectedValue.ToString());
        }

        private void cmbDayDen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            phong.LayDuLieuLenComboBox_DK_DAY(cmbPhongDen, cmbDayDen.SelectedValue.ToString());
        }

        private void cmbDayDi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            phong.LayDuLieuLenComboBox_DK_DAY(cmbPhongDi, cmbDayDi.SelectedValue.ToString());
            chuyenphong.LayDSSVThuocDay(cmbDayDi,dtPhongDi);
        }

        private void cmbPhongDi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            chuyenphong.LayDSSVThuocPhong(cmbPhongDi,dtPhongDi);
        }

        private void cmbPhongDen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            chuyenphong.LayDSSVThuocPhong(cmbPhongDen, dtPhongDen);
        }

        private void btnQua_Click(object sender, EventArgs e)
        {
            if (dtPhongDi.SelectedRows.Count > 0)
            {
                chuyenphong.ChuyenPhong(dtPhongDi.SelectedRows[0].Cells["colMaKTX"].Value.ToString(),
                    dtPhongDi.SelectedRows[0].Cells["MaPHG"].Value.ToString(), cmbPhongDen.SelectedValue.ToString());
                chuyenphong.LayDSSVThuocPhong(cmbPhongDen, dtPhongDen);
                chuyenphong.LayDSSVThuocPhong(cmbPhongDi, dtPhongDi);
            }
            else
                MessageBox.Show("Chưa chọn Sinh viên cần Chuyển phòng", "Chuyển Phòng");
        }

        private void btnLai_Click(object sender, EventArgs e)
        {
            if (dtPhongDen.SelectedRows.Count > 0)
            {
                chuyenphong.ChuyenPhong(dtPhongDen.SelectedRows[0].Cells["colMaKTX1"].Value.ToString(),
                    dtPhongDen.SelectedRows[0].Cells["MaPHG"].Value.ToString(), cmbPhongDi.SelectedValue.ToString());
                chuyenphong.LayDSSVThuocPhong(cmbPhongDen, dtPhongDen);
                chuyenphong.LayDSSVThuocPhong(cmbPhongDi, dtPhongDi);
            }
            else
                MessageBox.Show("Chưa chọn Sinh viên cần Chuyển phòng", "Chuyển Phòng");
        }

        private void dtPhongDi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnQua_Click(sender, e);
        }

        private void dtPhongDen_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnLai_Click(sender, e);
        }

       
    }
}