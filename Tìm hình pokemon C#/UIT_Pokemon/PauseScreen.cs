using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace UIT_Pokemon
{
   
    public class PauseScreen : PictureBox
    {
        private Timer time = new Timer();
        private Form1 form;
        private String str = "";
        bool set = false;
        public PauseScreen(Form1 form)
        {
            this.form = form;
            this.Location = new Point(100, 130);
            this.Size = new Size(1060, 600);
            this.BackColor = Color.Black;
            this.Size = new Size(500, 200);
            this.Location = new Point((form.Width - this.Width) / 2, (form.Height - this.Height) / 2);
            str = Information.StringGameover;
            this.Hide();
            this.Paint += new PaintEventHandler(PauseScreen_Paint);
            this.Click+=new EventHandler(PauseScreen_Click);
            str = Information.StringPause;
            time.Interval = 1500;
            time.Tick+=new EventHandler(time_Tick);
        }
        private void PauseScreen_Click(Object obj,EventArgs e)
        {
            if (form.gameover == true)
            {
                return;
            }
            this.HideScreen();
            if (set == true)
            {
                time.Stop();
                form.SetRecord();
            }
            set = false;
            form.fause = false;
        }
        private void PauseScreen_Paint(Object obj, PaintEventArgs e)
        {
            set = false;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            LinearGradientBrush br=new LinearGradientBrush(new Point(-5,-5),new Point(this.Width+10,this.Height+10),Color.Blue,Color.Brown);
            LinearGradientBrush br1 = new LinearGradientBrush(new Point(-15, -5), new Point(this.Width + 10, this.Height + 10), Color.Silver,Color.Snow);
            
            LinearGradientBrush br2=new LinearGradientBrush(new Point(this.Width/2-140,this.Height/2-120),new Point(this.Width/2+130,this.Height/2+120),Color.Chocolate,Color.DarkMagenta);
            g.DrawRectangle(new Pen(br,14),new Rectangle(0, 0, this.Width, this.Height));
            Font font=new Font("",35,FontStyle.Bold);
            SizeF m = g.MeasureString(str, font);
            g.DrawString(str, font, br1, new Point((this.Width - (int)m.Width - 3) / 2, (this.Height - (int)m.Height-3) / 2));
            g.DrawString(str, font, br2, new Point((this.Width - (int)m.Width) / 2, (this.Height - (int)m.Height) / 2));

        }
        public void ShowScreenPause()
        {
            this.Location = new Point(100, 130);
            this.Size = new Size(1060, 600);
            str = Information.StringPause;
            this.Show();
        }
        public void ShowScreenFinish()
        {
            this.Location = new Point(100, 130);
            this.Size = new Size(1060, 600);
            str = Information.StringFinish;
            this.Show();
            time.Start();
        }
        public void ShowScreenGameOver()
        {
            this.Size = new Size(550, 300);
            this.Location = new Point((form.Width - this.Width) / 2, (form.Height - this.Height) / 2);
            str = Information.StringGameover;
            this.Show();
            time.Start();
        }
        public void time_Tick(Object obj, EventArgs e)
        {
            time.Stop();
            form.SetRecord();
            set = false;
        }
        public void HideScreen()
        {
            form.LockGame = false;
            if (form.gameover == false)
                form.time.Start();
            this.Hide();
        }
    }
}
