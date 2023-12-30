using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKTX.Controller;

namespace QLKTX.SinhVien
{
    public partial class frmXepPhongSinhVien : Form
    {
        XepPhongSinhVienCtrl ctrl = new XepPhongSinhVienCtrl();
        QLKTX.Controller.PhongCtrl phgCtrl = new PhongCtrl();
        QLKTX.Controller.DayCtrl dayCtrl = new DayCtrl();
        QLKTX.Controller.KTXCtrl ktxCtrl = new KTXCtrl();

        public frmXepPhongSinhVien()
        {
            InitializeComponent();
        }

        private void frmXepPhongSinhVien_Load(object sender, EventArgs e)
        {
            ctrl.LayDSSinhVien_ChuaXepPhong(dataDSSinhVien);

            
            phgCtrl.LayDuLieuLenComboBox(cmbPhong_Den);
            dayCtrl.LayDuLieuLenComboBox(cmbDay_Den);
            ktxCtrl.LayDSKTXLenComboBox(cmbKTX_Den);
            


            ctrl.LayDSSinhVien_ThuocPhong(dataDSSinhVienThuocPhong, cmbPhong_Den);

        }

        private void cmbPhong_Den_SelectionChangeCommitted(object sender, EventArgs e)
        {           
            ctrl.LayDSSinhVien_ThuocPhong(dataDSSinhVienThuocPhong, cmbPhong_Den);
        }

        private void btnXepPhong_Click(object sender, EventArgs e)
        {
            ctrl.LayDSSinhVien_XepPhong(dataDSSinhVien, cmbPhong_Den);
            ctrl.LayDSSinhVien_ThuocPhong(dataDSSinhVienThuocPhong, cmbPhong_Den);
            ctrl.LayDSSinhVien_ChuaXepPhong(dataDSSinhVien);
        }

        private void dataDSSinhVien_MouseDown(object sender, MouseEventArgs e)
        {
            if(dataDSSinhVien.SelectedRows.Count>0)
            {
                DataGridViewSelectedRowCollection row = dataDSSinhVien.SelectedRows;
                dataDSSinhVien.DoDragDrop(row, DragDropEffects.Move);
            }
        }

        private void dataDSSinhVienThuocPhong_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;            
        }

        private void dataDSSinhVienThuocPhong_DragDrop(object sender, DragEventArgs e)
        {
            DataGridViewSelectedRowCollection row=(DataGridViewSelectedRowCollection)e.Data.GetData(typeof(DataGridViewSelectedRowCollection));
            
            if (MessageBox.Show("Bạn muốn " + row.Count + " Sinh viên vừa chọn vào phòng " + cmbPhong_Den.Text + " không?\nSau khi chọn, Bạn chỉ có thể chuyển phòng cho sinh viên mà thôi", "Chọn phòng cho Sinh viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ctrl.LayDSSinhVien_XepPhong(row, cmbPhong_Den);
                ctrl.LayDSSinhVien_ThuocPhong(dataDSSinhVienThuocPhong, cmbPhong_Den);
                ctrl.LayDSSinhVien_ChuaXepPhong(dataDSSinhVien);
            }
        }

        private void cmbKTX_Den_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dayCtrl.LayDuLieuLenComboBox_DK_KTX(cmbDay_Den, cmbKTX_Den.SelectedValue.ToString());
          //  ctrl.LayDSSinhVien_ThuocKTX(dataDSSinhVienThuocPhong, cmbKTX_Den);
            if (cmbDay_Den.Items.Count == 0)
            {
                cmbDay_Den.Text = "";
            }
            else
            {
                cmbDay_Den.SelectedIndex = 0;
            }

        }

        private void cmbDay_Den_SelectionChangeCommitted(object sender, EventArgs e)
        {
            phgCtrl.LayDuLieuLenComboBox_DK_DAY(cmbPhong_Den, cmbDay_Den.SelectedValue.ToString());
            //ctrl.LayDSSinhVien_ThuocDay(dataDSSinhVienThuocPhong, cmbDay_Den);
            if (cmbPhong_Den.Items.Count == 0)
            {
                cmbPhong_Den.Text = "";
            }
            else
            {
                cmbPhong_Den.SelectedIndex = 0;
            }
        }

        private void btnBoXep_Click(object sender, EventArgs e)
        {
            if (dataDSSinhVienThuocPhong.SelectedRows.Count > 0)
            {
                ctrl.LayDSSinhVien_XoaPhong(dataDSSinhVienThuocPhong, cmbPhong_Den);
                ctrl.LayDSSinhVien_ThuocPhong(dataDSSinhVienThuocPhong, cmbPhong_Den);
                ctrl.LayDSSinhVien_ChuaXepPhong(dataDSSinhVien);
            }
        }

       
    }
}