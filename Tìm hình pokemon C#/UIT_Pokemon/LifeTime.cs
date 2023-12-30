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
    public class LifeTime:PictureBox
    {
        private Form1 form;
        private Timer time;
        int dem = -1;
        public int Life = 0;
        public LifeTime(Form1 form)
        {
            this.form = form;

            
            this.Size = new Size(200, 200);
            this.Paint+=new PaintEventHandler(LifeTime_Paint);
            time = new Timer();
            time.Interval = 120;
            time.Tick+=new EventHandler(time_Tick);
            this.DoubleBuffered = true;
            this.Image = CollectionImage.PokemonLevel[17];
            this.BackColor = Color.Transparent;
        }
        private bool add = false;
        private void time_Tick(Object obj,EventArgs e)
        {
            dem++;
            this.Image = CollectionImage.PokemonLevel[dem];
            if (dem == 8)
            {
                if(add==false)
                    Life -= 1;
                else
                    Life += 1;
            }
            if (dem == 17)
            {
                time.Stop();
                dem = -1;
                if (Life == 0)
                {
                    form.time.Stop();
                    form.gameLocking();
                    form.gameover = true;
                    form.PScreen.ShowScreenGameOver();
                }
                this.Invalidate();
            }
            this.Invalidate();
        }
        public void UpdateLife(bool f)
        {
            time.Stop();
            add = f;
            time.Start();
        }
        private void LifeTime_Paint(Object obj, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            LinearGradientBrush br = new LinearGradientBrush(new Point(0, 0), new Point(300, 200), Color.IndianRed, Color.Tomato);
            
            LinearGradientBrush br1 = new LinearGradientBrush(new Point(0, 0), new Point(200, 210), Color.Blue, Color.LemonChiffon);
            LinearGradientBrush br2 = new LinearGradientBrush(new Point(100, 100), new Point(200, 210), Color.Brown, Color.BurlyWood);
            g.FillRectangle(Brushes.Transparent,new Rectangle(0,0,200,200));
            g.FillPie(br2, new Rectangle(100, 100, 80, 80), 0, 360);
            g.FillPie(br1, new Rectangle(105,105,70,70),0,360);
            Font font = new Font("", 26, FontStyle.Bold);
            SizeF m = g.MeasureString(Life.ToString(), font);
            g.DrawString(Life.ToString(), font, br, new Point(100 + (80 - (int)m.Width) / 2, 120));
            if (dem != -1)
            {
                g.DrawImage(this.Image, new Rectangle(90, 85, 110, 115));
                
            }
        }

    }
}
