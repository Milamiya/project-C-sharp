using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace UIT_Pokemon
{
    public class SpecilButton:Button
    {
        public int tmp;
        public SpecilButton(int i)
        {
            tmp = i;
            if (tmp == 0)
            {
                ControlRegion.CreateControl(this, global::UIT_Pokemon.Properties.Resources.nextbutton);
                this.Image = global::UIT_Pokemon.Properties.Resources.nextbutton;
                this.Font = new Font("", 16, FontStyle.Bold);
            }
            else
            {
                this.Size = new Size(120, 110);
                this.Font = new Font("", 10, FontStyle.Bold);
            }
            this.MouseEnter+=new EventHandler(SpecilButton_MouseEnter);
            this.MouseLeave+=new EventHandler(SpecilButton_MouseLeave);
            this.MouseDown+=new MouseEventHandler(SpecilButton_MouseDown);
            this.MouseUp+=new MouseEventHandler(SpecilButton_MouseUp);
            this.ForeColor = Color.Chocolate;
            this.Paint+=new PaintEventHandler(SpecilButton_Paint);
        }
        private void SpecilButton_MouseEnter(Object obj, EventArgs e)
        {
            if (tmp == 0)
            {
                this.Image = global::UIT_Pokemon.Properties.Resources.nextbuttonlight;
                this.Font = new Font("", 16, FontStyle.Bold);
            }
            else
            {
                this.Font = new Font("", 10, FontStyle.Bold);
                active = 1;
                this.Invalidate();
            }
            
            this.ForeColor = Color.LemonChiffon;
        }
        private void SpecilButton_MouseLeave(Object obj, EventArgs e)
        {
            if(tmp==0)
            {
                this.Image = global::UIT_Pokemon.Properties.Resources.nextbutton;
                this.Font = new Font("", 16, FontStyle.Bold);
            }
            else
            {
                //this.Image = global::UIT_Pokemon.Properties.Resources.menubutton1;
                this.Font = new Font("", 10, FontStyle.Bold);
                active = 0;
                this.Invalidate();
            }
            this.ForeColor = Color.Chocolate;
        }
        private void SpecilButton_MouseDown(Object obj, EventArgs e)
        {
            if (tmp == 0)
            {
                this.Image = global::UIT_Pokemon.Properties.Resources.nextbuttonred;
                this.Font = new Font("", 17, FontStyle.Bold);
            }
            else
            {
                this.Font = new Font("", 11, FontStyle.Bold);
                active = 2;
                this.Invalidate();
            }
            
            this.ForeColor = Color.Brown;
        }
        private void SpecilButton_MouseUp(Object obj, EventArgs e)
        {
            SpecilButton_MouseEnter(obj, e);
        }
        int active = 0;
        private void SpecilButton_Paint(Object obj, PaintEventArgs e)
        {
            if (tmp == 0)
                return;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            LinearGradientBrush br1=new LinearGradientBrush(new Point(0, 0), new Point(200, 200), Color.Tomato, Color.DarkGreen);
            LinearGradientBrush br2 = new LinearGradientBrush(new Point(0, 0), new Point(200, 200), Color.MintCream, Color.RoyalBlue);
            LinearGradientBrush br3 = new LinearGradientBrush(new Point(0, 0), new Point(200, 200), Color.Green, Color.Azure);
            LinearGradientBrush br4 = new LinearGradientBrush(new Point(0, 0), new Point(200, 200), Color.Blue, Color.DarkGreen);
            LinearGradientBrush br5 = new LinearGradientBrush(new Point(-10, -10), new Point(200, 200), Color.Blue, Color.Azure);
            g.FillRectangle(Brushes.Black,new Rectangle(0,0,this.Width,this.Height));
            g.FillPie(br1, new Rectangle(9, 15, 80, 80), 0, 360);
            if (active == 0)
            {
                g.FillPie(br5, new Rectangle(9+5, 20, 70, 70), 0, 360);
            }
            else if (active == 1)
            {
                g.FillPie(br3, new Rectangle(9 + 5, 20, 70, 70), 0, 360);
            }
            else if (active == 2)
            {
                g.FillPie(br4, new Rectangle(9 + 5, 20, 70, 70), 0, 360);
            }
            SizeF m = g.MeasureString(Information.StringPause,this.Font);
            if (m.Width < 70)
            {
                if(this.Font.Size>11)
                    g.DrawString(Information.StringPause, this.Font, br2, new Rectangle(15, 49, 70, 70));
                else
                    g.DrawString(Information.StringPause, this.Font, br2, new Rectangle(18, 50, 70, 70));
            }
            else
                g.DrawString(" " + Information.StringPause, this.Font, br2, new Rectangle(20, 40, 70, 70));
            br1.Dispose();
            br2.Dispose();
            br3.Dispose();
            br4.Dispose();
            br5.Dispose();
        }
    }
}
