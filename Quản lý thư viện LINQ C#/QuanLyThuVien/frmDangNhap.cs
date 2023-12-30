using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.Linq;
using System.Threading;
namespace QuanLyThuVien
{
    public partial class frmDangNhap : DevComponents.DotNetBar.Office2007Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        QLTVDataContext db = new QLTVDataContext();
        tbUser tbuser = new tbUser();

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtuser.Focus();
            
            
        }
        // Khai báo 1 hàm với 2 tham số đầu vào là vl1, và vl2 nó sẽ đưa dữ liệu vào 2 txt.
        public void GetValue(string vl1, string vl2)
        {
            txtuser.Text = vl1;
            txtpass.Text = vl2;
        }

        void Openform()
        {
            System.Windows.Forms.Application.Run(new frmMain_1());
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            var user = db.tbUsers.Where(u => u.TenDN == txtuser.Text&& u.pass == txtpass.Text).SingleOrDefault<tbUser>();
            
                if (user != null)
                {
           
                    //Thread thread = new Thread(new ThreadStart(Openform));
                    //thread.SetApartmentState(ApartmentState.STA);
                    //thread.Start();
                    //Application.Exit();
                    this.Hide();
                    frmMain_1 frm = new frmMain_1();
                    PassData pass = new PassData(frm.GetValue);
                    pass(this.txtuser.Text);
                    frm.Show();
                    if (user.Quyen == 1)
                    {
                        
                        frm.ribbonBar1.Visible = true;
                        frm.ribbonTabItem2.Visible = true;
                        frm.ribbonTabItem4.Visible = true;

                    }

                }
                else
                    MessageBox.Show("Tên Đăng Nhập Không Tồn Tại");
            
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            frmDangKi frm = new frmDangKi();
            frm.passSeconddata = new frmDangKi.PassSeconddata(GetValue);
            frm.Show();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmDangKi frm = new frmDangKi();
            frm.Close();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void frmDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

   

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        #region "Delegate From Main"
           public delegate void PassData(string value);

        #endregion
        private void buttonX1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            frmMain_1 frm = new frmMain_1();
            frm.Close();
        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDN_Click(sender, e);
            }
        }

    }
}
