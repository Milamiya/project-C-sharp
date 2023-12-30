using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

using System.Windows.Forms;
using DevComponents.DotNetBar;
namespace QuanLyThuVien
{
    public partial class frmDangKi : DevComponents.DotNetBar.Office2007Form
    {
        public frmDangKi()
        {
            InitializeComponent();
        }

        QLTVDataContext db = new QLTVDataContext();

        private void frmDangKi_Load(object sender, EventArgs e)
        {
            textBoxX1.Focus();
            this.KeyPreview = true;
        }

        // Khai báo 1 hàm delegate

        public delegate void PassSeconddata(string vl1,string vl2);
       
        // Khai báo 1 kiểu hàm delegate
        public PassSeconddata passSeconddata;
        void Openform()
        {
            System.Windows.Forms.Application.Run(new frmDangNhap());
        }


        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (textBoxX3.Text == "")
            {
                MessageBox.Show("Phải Nhập Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var user = db.tbUsers.Where(u => u.TenDN == textBoxX1.Text.Trim()).SingleOrDefault<tbUser>();
                if(user !=null)
                {
                    MessageBox.Show("Tên Đăng Kí Đã Tồn Tại", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                if (db.CRUDUser('t', textBoxX1.Text, textBoxX2.Text) == 1)
                {
                    MessageBox.Show("Đăng Kí Thàng Công", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                   // frmDangNhap frm = new frmDangNhap();
                    if (passSeconddata!=null)
                    {
                        passSeconddata(textBoxX1.Text, textBoxX2.Text);
                    }

                    this.Hide();
                    //Thread thread = new Thread(new ThreadStart(Openform));
                    //thread.SetApartmentState(ApartmentState.STA);
                    //thread.Start();
                    //System.Windows.Forms.Application.Exit();

                }
                else
                    MessageBox.Show("Đăng Kí Thất Bại", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Quản Lý Thư Viên");
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmDangKi_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
                
                buttonX1_Click(sender, e);
            }
        }

        private void frmDangKi_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void buttonX1_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void frmDangKi_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void frmDangKi_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.CausesValidation = false;
            this.AutoValidate = AutoValidate.Disable;
           
        }

        private void frmDangKi_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CausesValidation = false;
            this.AutoValidate = AutoValidate.Disable;
        }

      
    }
}
