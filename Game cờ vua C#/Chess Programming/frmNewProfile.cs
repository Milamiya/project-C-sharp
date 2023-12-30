using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Chess_Programming
{
    public partial class frmNewProfile : DevComponents.DotNetBar.Office2007Form
    {
        public frmNewProfile()
        {
            InitializeComponent();
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {

        }

        private void frmNewProfile_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            clsProfile profile;
            if (txtUserName.Text != "")
            {
                profile = new clsProfile(txtUserName.Text);
                profile.TotalGames = 0;
                profile.TotalWin = 0;
                profile.TotalLose = 0;
                profile.TotalDraw = 0;
                profile.Rating = 1200;

                
                clsImage img = new clsImage(picAvatar .Image ,picAvatar .Width  ,picAvatar .Height  );
                profile.Avatar = img;
                profile.SaveProfile();
                
                MessageBox.Show("Tạo Profile Thành Công !!!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn Chưa Nhập Tên !!!");
            }

        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.ShowDialog();
                if (dlg.FileName != "")
                {
                    picAvatar.Image = Image.FromFile (dlg.FileName);                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}