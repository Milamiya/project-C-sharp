using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
namespace Chess_Programming
{
    public partial class frmManageProfile : DevComponents.DotNetBar.Office2007Form
    {
        public frmManageProfile()
        {
            InitializeComponent();
        }

        private void frmManageProfile_Load(object sender, EventArgs e)
        {
            LoadListBox();
        }

        private void lstPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPlayer.SelectedIndex != -1)
            {
                clsProfile profile = new clsProfile(lstPlayer.SelectedItem.ToString());
                profile.LoadProfile();
                pictureBox1.Image = profile.Avatar.Avatar;
            }
        }
        void LoadListBox()
        {
            lstPlayer.Items.Clear();
            if (Directory.Exists(Application.StartupPath + "\\Profiles"))
            {
                DirectoryInfo dr = new DirectoryInfo(Application.StartupPath + "\\Profiles");
                foreach (FileInfo f in dr.GetFiles("*.xml"))
                {
                    string strPlayerName = Path.GetFileNameWithoutExtension(f.Name);
                    strPlayerName = clsEncoding.Decode(strPlayerName);
                    lstPlayer.Items.Add(strPlayerName);

                }
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmNewProfile frm = new frmNewProfile();
            frm.ShowDialog();
            LoadListBox();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (lstPlayer.SelectedIndex != -1)
            {
                frmViewProfile frm = new frmViewProfile(lstPlayer.SelectedItem.ToString());
                frm.ShowDialog();
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (lstPlayer.SelectedIndex != -1)
            {
                string strPlayerName = lstPlayer.SelectedItem.ToString();
                strPlayerName = clsEncoding.Encode(strPlayerName) + ".xml";
                File.Delete(Application.StartupPath + "\\Profiles\\" + strPlayerName);
                pictureBox1.Image = null;
                LoadListBox();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstPlayer.SelectedIndex != -1)
            {
                string strPlayerName = lstPlayer.SelectedItem.ToString();
                frmMain.localpc.Profile = strPlayerName;
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn Profile !!");
            }
        }
    }
}