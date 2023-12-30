using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LichCongTac
{
    public partial class frmNoiDungCongViec : Form
    {
        public frmNoiDungCongViec()
        {
            InitializeComponent();
        }

        private void lblXemChiTiet_Click(object sender, EventArgs e)
        {
            
        }

        private void frmNoiDungCongViec_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = frmLichCongTac.strNoiDungSauCung;
        }
        public void CallEventLoadFrom()
        {
            object sender=null;
            EventArgs e=null;
            frmNoiDungCongViec_Load(sender,e);
        }

        private void frmNoiDungCongViec_SizeChanged(object sender, EventArgs e)
        {
            int intWidthOfForm = this.Width;
            if (intWidthOfForm>300)
            {
                int intWidth = Screen.PrimaryScreen.WorkingArea.Width;
                int intHeight = Screen.PrimaryScreen.WorkingArea.Height;
                groupBox1.Width = intWidth - 17;
                groupBox1.Height = intHeight - 9;
                richTextBox1.Width = intWidth - 40;
                richTextBox1.Height = intHeight - 60;
            }
            else
            {
                groupBox1.Width = 201;
                groupBox1.Height = 131;
                richTextBox1.Width = 188;
                richTextBox1.Height = 122;
            }
        }

        private void frmNoiDungCongViec_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLichCongTac.intTest = 0;
        }
    }
}