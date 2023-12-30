using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Doan
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //public void taomoi()
        //{
        //    frmSua fSua = new frmSua();
        //    fSua.MdiParent = this;
        //    fSua.Show();
        //}
        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không  ", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin fMain = new frmLogin();
            fMain.Show();
            fMain.Close();
        }

        private void thêmCâuHỏiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCapNhat fCapNhat = new frmCapNhat();
            fCapNhat.Show();
        }

        private void frmLogin_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btReg_Click(object sender, EventArgs e)
        {
            frmReg fReg = new frmReg();
            fReg.Focus();
            fReg.ShowDialog(this);
           
        }

        private void btLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtdangnhap.Text == "" || txtmatkhau.Text == "")
                {
                    MessageBox.Show("Bạn chưa điền đầy đủ thông tin", "Có lỗi xảy ra!");
                    txtdangnhap.Focus();
                    return;
                }
                    if(txtdangnhap.Text=="admin" && txtmatkhau.Text=="admin")
                    {
                        if (MessageBox.Show("Chào mừng bạn đã đến với mục quản lý dành cho giáo viên", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            this.Hide();
                            frmQuanLy_Admin admin = new frmQuanLy_Admin();
                            admin.ShowDialog();
                            
                        }

                    }
                else
                {
                    SqlConnection con = new SqlConnection("server=.\\SQLEXPRESS;database=QL_Thitracnghiem;integrated security=true");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select MatKhau from THISINH where TenDangNhap ='" + txtdangnhap.Text + "'", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (txtmatkhau.Text == reader.GetValue(0).ToString())
                    {
                        MessageBox.Show("Bạn đã đăng nhập thành công!", "Thành công");
                        reader.Close();
                        con.Close();
                        this.Close();
                        frmLuaChon frmChon = new frmLuaChon();
                        frmChon.ShowDialog();
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Sai Mật Khẩu");
                        txtmatkhau.Focus();
                    }
                    reader.Close();
                    con.Close();
                }

            }

            catch (Exception)
            {

                MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ","Có lỗi xảy ra");
                txtdangnhap.Focus();

            }
        }

        private void txtmatkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btLog_Click(null, null);
            }
        }
    }
}



       