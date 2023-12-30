using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;
using QuanLyThuVien.Properties;
namespace QuanLyThuVien
{
    public partial class frmThongTin : Form
    {
        public frmThongTin()
        {
            InitializeComponent();
        }
        string name = "";
        #region  "Delegate nhận thông tin từ form main"
        public void GetValue(string vl)
        {
            name = vl.Trim();
        }
        #endregion

        QLTVDataContext db = new QLTVDataContext();

       
        private void frmThongTin_Load(object sender, EventArgs e)
        {
            frmMain_1 frm=new frmMain_1();
           
            tbUser user = db.tbUsers.Where(u => u.TenDN == name).SingleOrDefault<tbUser>();
            if (user != null)
            {
                txtten.Text = user.TenDN.Trim();
                txtpass.Text = user.pass.Trim();
               
            }
            else
            {
                this.Close();
                frmDangNhap dn = new frmDangNhap();
                dn.Show();
            }
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            txtpass.ReadOnly = false;
            btnupdate.Image = Resources.Cancel;
            buttonX3.Enabled = true;
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {

                try
                {
                    tbUser user = db.tbUsers.Where(u => u.TenDN ==txtten.Text).SingleOrDefault<tbUser>();
                    user.pass = txtpass.Text;
                    db.SubmitChanges();
                    MessageBox.Show("Sửa Thành Công","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Quản Lý Thư Viện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    btnupdate.Image = Resources.edit;
                    buttonX3.Enabled = false;
                    txtpass.ReadOnly = true;
                }
            
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
           
            btnupdate.Image = Resources.edit;
            buttonX3.Enabled = false;
        }

        private void frmThongTin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
        }
    }
}
