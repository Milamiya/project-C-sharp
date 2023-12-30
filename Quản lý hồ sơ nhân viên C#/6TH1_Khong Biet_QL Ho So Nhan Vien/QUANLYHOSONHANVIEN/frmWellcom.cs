using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYHOSONHANVIEN.DataLayer;
using QUANLYHOSONHANVIEN.BusinessObject;
namespace QUANLYHOSONHANVIEN
{
    public partial class frmWellcom : Form
    {
        public frmWellcom()
        {
            InitializeComponent();
        }

        //public DangNhapInfo thongtindn;

        ThongTinCongTyData data_thongtinct = new ThongTinCongTyData();
        private void frmLoad_Load(object sender, EventArgs e)
        {
            DataTable dtl = data_thongtinct.DanhsachTHONGTINCONGTY();
            if (dtl.Rows.Count > 0)
            {
                //labDonvisudung.Text = dtl.Rows[0]["TENCT"].ToString();
                panelDonViSD.Text += dtl.Rows[0]["TENCT"].ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.Opacity -= 0.01;
            progressBarX1.Minimum = 0;
            progressBarX1.Maximum = 200;
            progressBarX1.Value++;
            //if (this.Opacity == 0) this.Dispose();
            if (progressBarX1.Value == progressBarX1.Maximum)
            {
                //this.Dispose(); 
                timer1.Enabled = false;
                frmDangNhap dangnhap = new frmDangNhap();
                dangnhap.ShowDialog();
                //MessageBox.Show(thongtindn .username);
                frmMainChinh fmain = new frmMainChinh();
                this.Hide(); 
                fmain.ShowDialog();
    
            }
        }

    }
}
