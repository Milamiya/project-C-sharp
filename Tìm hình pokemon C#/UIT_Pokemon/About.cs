using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace UIT_Pokemon
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            button1.Text = Information.StringButtonCancel;
            TopMost = true;
        }

        private void About_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighSpeed;
            LinearGradientBrush br = new LinearGradientBrush(new Point(0, 0), new Point(500, 400), Color.BurlyWood, Color.CornflowerBlue);
            LinearGradientBrush br1 = new LinearGradientBrush(new Point(0, 0), new Point(500, 400), Color.DarkMagenta, Color.RosyBrown);
            g.FillRectangle(br, new Rectangle(0, 0, this.Width, this.Height));
            g.DrawRectangle(new Pen(br1, 6), new Rectangle(0, 0, this.Width-1, this.Height-1));
            br.Dispose();
            br1.Dispose();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
