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
 
    public partial class frmCanBo : Form
    {
        CanBoCtrl ctrl = new CanBoCtrl();
        bool Adding = false;
        bool Updating = false;
        public frmCanBo()
        {            
            InitializeComponent();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void frmCanBo_Load(object sender, EventArgs e)
        {
            ctrl.LayDSCanBoQuanLy(dataDSCanBoQuanLy);
        }

        
        private void binNavCanBo_RefreshItems(object sender, EventArgs e)
        {

        }

        private void dataCanBo_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc Xóa Không?", "Cán bộ Quản lý", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Adding = true;
            txtMa.Enabled = false;
            txtTen.Enabled = true;
            txtDiaChi.Enabled = true;
            
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnBoQua.Visible = true;

            txtTen.Focus();

            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtMa.Text = ctrl.LayMaMax().ToString();

            dataDSCanBoQuanLy.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Updating = true;

            txtMa.Enabled = false;
            txtTen.Enabled = true;
            txtDiaChi.Enabled = true;

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            btnBoQua.Visible = true;

            txtTen.Focus();

            dataDSCanBoQuanLy.Enabled = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            
            if (ctrl.KiemTra(txtMa, txtTen, txtDiaChi))
            {
                QLKTX.BusinessObject.CanBoInfo cb = new QLKTX.BusinessObject.CanBoInfo();
                cb.MaSo = Convert.ToInt32(txtMa.Text);
                cb.Ten = txtTen.Text;
                cb.DiaChi = txtDiaChi.Text;

                if (Adding)
                {
                    ctrl.Them(cb);
                }
                else
                {
                    if (Updating)
                        ctrl.Sua(cb);
                }
                ctrl.LayDSCanBoQuanLy(dataDSCanBoQuanLy);

                Updating = Adding = false;
                txtMa.Enabled = false;
                txtTen.Enabled = false;
                txtDiaChi.Enabled = false;

                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnCapNhat.Enabled = false;
                btnBoQua.Visible = false;

                dataDSCanBoQuanLy.Enabled = true;
            }
            
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            Updating = Adding = false; 
            
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtDiaChi.Enabled = false;

            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnCapNhat.Enabled = false;
            btnBoQua.Visible = false;

            dataDSCanBoQuanLy.Enabled = true;
            if (dataDSCanBoQuanLy.SelectedRows.Count > 0)
            {
                txtMa.Text = dataDSCanBoQuanLy.SelectedRows[0].Cells[0].Value.ToString();
                txtTen.Text = dataDSCanBoQuanLy.SelectedRows[0].Cells[1].Value.ToString();
                txtDiaChi.Text = dataDSCanBoQuanLy.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void txtDiaChi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btnCapNhat_Click(sender, e);
            }
            else
                if (e.KeyCode.Equals(Keys.Escape))
                {
                    btnBoQua_Click(sender, e);
                }
        }

        private void dataDSCanBoQuanLy_SelectionChanged(object sender, EventArgs e)
        {
            if(dataDSCanBoQuanLy.SelectedRows.Count>0)
            {
                txtMa.Text = dataDSCanBoQuanLy.SelectedRows[0].Cells[0].Value.ToString();
                txtTen.Text = dataDSCanBoQuanLy.SelectedRows[0].Cells[1].Value.ToString();
                txtDiaChi.Text = dataDSCanBoQuanLy.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataDSCanBoQuanLy.SelectedRows.Count > 0)
            {
                txtMa.Text = dataDSCanBoQuanLy.SelectedRows[0].Cells[0].Value.ToString();
                txtTen.Text = dataDSCanBoQuanLy.SelectedRows[0].Cells[1].Value.ToString();
                txtDiaChi.Text = dataDSCanBoQuanLy.SelectedRows[0].Cells[2].Value.ToString();
                if (MessageBox.Show("Bạn có muốn xóa cán bộ: \"" + txtTen.Text + "\" Không?", "Cán bộ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    QLKTX.BusinessObject.CanBoInfo info = new QLKTX.BusinessObject.CanBoInfo();
                    info.MaSo = Convert.ToInt32(txtMa.Text);
                    info.Ten = txtTen.Text;
                    info.DiaChi = txtDiaChi.Text;
                    ctrl.Xoa(info);
                    ctrl.LayDSCanBoQuanLy(dataDSCanBoQuanLy);
                }

            }
        }

        private void txtTen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
            {
                btnBoQua_Click(sender, e);
            }

        }

        
        

       
        
        
    }
}