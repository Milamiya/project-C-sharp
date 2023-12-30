using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYHOSONHANVIEN.DataLayer;

namespace QUANLYHOSONHANVIEN.GiaoDien
{
    public partial class frmCongTy : DevComponents .DotNetBar .Office2007Form
    {
        public frmCongTy()
        {
            InitializeComponent();
        }
        String tenLogo = "";
        int capNhatHinh = -1;
        //int tmp = 4;
        ThongTinCongTyData data = new ThongTinCongTyData();

        private void frmCongTy_Load(object sender, EventArgs e)
        {
            DataTable dtl = data.DanhsachTHONGTINCONGTY();
            txtTenct.Text = dtl.Rows[0]["TENCT"].ToString();
            txtDiachi.Text = dtl.Rows[0]["DIACHI"].ToString();
            txtDienthoai.Text = dtl.Rows[0]["DIENTHOAI"].ToString();
            txtThudientu.Text = dtl.Rows[0]["THUDIENTU"].ToString();
            txtWebsite.Text = dtl.Rows[0]["WEBSITE"].ToString();
            

            //
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            if (dtl.Rows[0]["logo"].ToString() == "")
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "/HinhLogo/NoLogo.jpg");
            else
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "/HinhLogo/" + dtl.Rows[0]["logo"].ToString() + ".jpg");
                tenLogo = dtl.Rows[0]["logo"].ToString();
            }
            //
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {            
            if (kiemtra())
            {
                if (capNhatHinh == 1)
                {
                    try
                    {
                        int tmp = Convert.ToInt32(tenLogo.Substring(4));
                        tmp++;
                        tenLogo = tenLogo.Substring(0, 4) + tmp.ToString();
                    }
                    catch
                    {
                        tenLogo = "Hinh1";
                    }
                    //MessageBox.Show(tenLogo);                    
                    pictureBox1.Image.Save(Application.StartupPath + "/HinhLogo/" + tenLogo + ".jpg");
                    capNhatHinh = -1;
                }              
                ThamSo tso = new ThamSo();
                tso.LuuThongTinCongTy(txtTenct.Text.ToString(), txtDiachi.Text.ToString(), txtDienthoai.Text.ToString(), txtThudientu.Text.ToString(), txtWebsite.Text.ToString(), tenLogo);                
            }
        }

        private bool kiemtra()
        {
            if (txtTenct.Text == "")
            {
                txtTenct.BackColor = Color.Yellow;
                txtTenct.Focus();
                return false;
            }
            if (txtDiachi.Text == "")
            {
                txtDiachi.BackColor = Color.Yellow;
                txtDiachi.Focus();
                return false;
            }
            return true;
        }

        private void txtTenct_TextChanged(object sender, EventArgs e)
        {
            txtDiachi.BackColor = Color.White;
            txtTenct.BackColor = Color.White;
        }

        private void btnHinhmoi_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Title = "Chon Logo";
            openDlg.RestoreDirectory = true;
            openDlg.Filter = "All images (*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png";
            openDlg.Multiselect = false;
            if (openDlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openDlg.FileName);
                capNhatHinh = 1;
            }
        }

    }
}
