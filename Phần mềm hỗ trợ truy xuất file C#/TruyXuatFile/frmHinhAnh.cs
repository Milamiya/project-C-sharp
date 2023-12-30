using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TruyXuatFile
{
    
    public partial class frmHinhAnh : Form
    {
        public string PathNameHA;
        Bitmap bmp;
         
        public frmHinhAnh()
        {
            InitializeComponent();
        }

        private void frmHinhAnh_Load(object sender, EventArgs e)
        {
            if (PathNameHA != null)
            {
                bmp = (Bitmap)Bitmap.FromFile(PathNameHA);
                ptbHinhHienThi.Image = bmp;
                //ptbHinhHienThi.Image = Image.FromFile(PathNameHA);
                ptbHinhHienThi.SizeMode = PictureBoxSizeMode.Zoom;
            }
           

     
        }
        public string GetPathHA(string a)
        {
            PathNameHA = a;
            return PathNameHA;
        }

        public  void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Picture File (*. jpg)| *.jpg | AllFile(*.*) | *.*";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string PathNameHA = openFileDialog1.FileName;


                bmp = (Bitmap)Bitmap.FromFile(PathNameHA);
                ptbHinhHienThi.Image = bmp;
                ptbHinhHienThi.SizeMode = PictureBoxSizeMode.Zoom;
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

       
        private void ptbHinhHienThi_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {               
                string Query = "Bạn có chắc chắn muốn xóa tập tin không ? \n" + PathNameHA  + "?";
                if (MessageBox.Show(Query, "THÔNG BÁO", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                  

                    File.Delete(PathNameHA);         

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xóa file này vì :"
                    + " xảy ra:\n" + ex.Message, "Thất bại!");
            }
        }
        
        private void Rotate90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bmp  != null)
            {
                bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                ptbHinhHienThi.Image = bmp;
            }
        }

        private void Rotate270ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
                ptbHinhHienThi.Image = bmp;
            }
        }

        private int h = 50;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.panel2.Size = new Size(this.panel2.Width + h, this.panel2.Height + h);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.panel2.Size = new Size(this.panel2.Width - h, this.panel2.Height - h);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Rotate90ToolStripMenuItem_Click(sender, e);
        }

        private void Rotate180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                ptbHinhHienThi.Image = bmp;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Rotate180ToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Rotate270ToolStripMenuItem_Click(sender, e);
        }

 

    }
}