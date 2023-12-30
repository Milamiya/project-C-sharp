using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TruyXuatFile
{
    public partial class frmNhac : Form
    {
        public string PathNameMedia;
        public frmNhac()
        {
            InitializeComponent();
        }

        private void frmNhac_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = PathNameMedia;

        }
        public string GetPathMedia(string a)
        {
            PathNameMedia = a;
            return PathNameMedia;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = " Media File *.mp3*)|*.mp3*|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FileName = openFileDialog1.FileName;

                axWindowsMediaPlayer1.URL = FileName;
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTin FormThongTin = new frmThongTin();
            FormThongTin.Show();
        }

      
    }
}