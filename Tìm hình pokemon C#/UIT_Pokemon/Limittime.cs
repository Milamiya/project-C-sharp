using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.Windows.Forms;
namespace UIT_Pokemon
{
    class Limittime:PictureBox
    {
        Form1 form;
        public int percent = 100;
        private int limit = 0;
        PictureBox BG = new PictureBox();
        //int Score = 0;
        public Limittime(Form1 form )
        {
            this.form = form;
            this.Location = new Point(75, 10);
            this.BackgroundImage= global::UIT_Pokemon.Properties.Resources.PokemonTime;
            ControlRegion.CreateControl(this, global::UIT_Pokemon.Properties.Resources.PokemonTime);
            BG.Location = new Point(80, 0);
         
            //Score = form.Score;
            this.Controls.Add(BG);
            //BG.BackgroundImage = global::UIT_Pokemon.Properties.Resources.PokemonTime;
            ControlRegion.CreateControl(BG,UIT_Pokemon.Properties.Resources.PokemonTime.Clone(new Rectangle(80,0,1000,47),System.Drawing.Imaging.PixelFormat.DontCare));
            BG.Image = UIT_Pokemon.Properties.Resources.PokemonTime.Clone(new Rectangle(80, 0, 1000, 47), System.Drawing.Imaging.PixelFormat.DontCare);
            BG.Paint+=new PaintEventHandler(BG_Paint);
            this.DoubleBuffered = true;
        }
        public void reset()
        {
            limit = 0;
            percent = 100;
            form.percent = 100;
            this.Invalidate();
        }
        void BG_Paint(Object obj, PaintEventArgs e)
        {
            Graphics gp = e.Graphics;
            //gp.FillRectangle(Brushes.Azure, new Rectangle(0, 0, 600, 600));
            LinearGradientBrush brush = new LinearGradientBrush(new Point(0, 0), new Point(300, 300), Color.BlueViolet, Color.Chocolate);
            SizeF m = gp.MeasureString(form.Score.ToString(), new Font("", 22, FontStyle.Bold));
            try
            {
                gp.DrawString(form.Score.ToString(), new Font("", 22, FontStyle.Bold), Brushes.Azure, new Point(1000-(int)m.Width, 10));
            }
            catch
            {
                gp.DrawString("0", new Font("", 22, FontStyle.Bold), Brushes.Azure, new Point(1000 - (int)m.Width, 10));
            }
            try
            {
                gp.DrawString(form.timeplay.showtime, new Font("VfFree08", 20, FontStyle.Bold), Brushes.Azure, new Point(42, 10));
            }
            catch
            {
                gp.DrawString(form.timeplay.showtime, new Font("", 20, FontStyle.Bold), Brushes.Azure, new Point(42, 10));
            }
            
            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            LinearGradientBrush br = new LinearGradientBrush(new Point(70, 59), new Point(1100, 60), Color.DarkSeaGreen, Color.Azure);
            g.DrawRectangle(new Pen(Brushes.ForestGreen, 2), new Rectangle(70, 50, 1003, 22));
            g.FillRectangle(br, new Rectangle(72, 50, 1000, 19));
            OnDraw(g);
        }
        private void OnDraw(Graphics g)
        {
            LinearGradientBrush br ;
            if(percent>80)
                 br = new LinearGradientBrush(new Point(70, 39), new Point(1200, 60), Color.Green, Color.ForestGreen);
            else if (percent > 60)
                br = new LinearGradientBrush(new Point(70, 39), new Point(1100, 60), Color.Green, Color.DarkSeaGreen);
               
            else if (percent > 40)
                br = new LinearGradientBrush(new Point(70, 39), new Point(1000, 60), Color.GreenYellow, Color.Azure);
            else if (percent > 20)
                br = new LinearGradientBrush(new Point(70, 39), new Point(500, 60), Color.Yellow, Color.Azure);
            else if(percent>10)
                br = new LinearGradientBrush(new Point(70, 39), new Point(400, 60), Color.Tomato, Color.Azure);
            else
                br = new LinearGradientBrush(new Point(70, 39), new Point(200, 60), Color.Red, Color.Azure);
            g.FillRectangle(br, new Rectangle(72, 52, 10*percent, 19));
            g.DrawString(percent.ToString() + " %", new Font("", 14, FontStyle.Bold), Brushes.Tan, new Point(550, 50));
        }
        public void UpdateScore()
        {
            BG.Invalidate();
        }
        public void UpdatePercent()
        {
            form.percent = percent;
            if (percent < 0)
            {
                return;
            }
            Graphics g = CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality;
            LinearGradientBrush br = new LinearGradientBrush(new Point(70, 39), new Point(1100, 60), Color.BlueViolet,Color.Blue);
            //g.DrawRectangle(new Pen(Brushes.ForestGreen, 2), new Rectangle(70, 50, 1003, 22));
            g.FillRectangle(br, new Rectangle(72, 52, 1000, 19));
            
            OnDraw(g);
        }
        public void updateTime()
        {
            BG.Invalidate();
            limit++;
            if (limit >= 5)
            {
                limit = 0;
                if (percent > 0)
                {
                    percent--;
                    UpdatePercent();
                }
                if(percent==0)
                {
                    form.time.Stop();
                    form.gameLocking();
                    form.gameover = true;

                    form.PScreen.ShowScreenGameOver();
                }
                
            }
        }
    }
}
