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
    public partial class HelpIntroduction : Form
    {
        private Form1 form;
        private int Level;
        public HelpIntroduction(Form1 form)
        {
            this.form = form;
            Level = form.Level;
            InitializeComponent();
            if (form.full == true)
                this.Location = new Point(this.Location.X, this.Location.Y - 20);
            this.TopMost = true;
            button1.Text = Information.StringButtonCancel;
            tabPage1.Text = Information.StringRulePlay;
            tabPage2.Text = Information.StringIntroducegame;
        }

        private void HelpIntroduction_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            LinearGradientBrush br = new LinearGradientBrush(new Point(0, 0), new Point(1060, 800), Color.BurlyWood, Color.CornflowerBlue);
            g.FillRectangle(br, 0, 0, this.Width, this.Height);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            HelpIntroduction_Paint(sender, e);
            Graphics g = e.Graphics;
            LinearGradientBrush br = new LinearGradientBrush(new Point(100, 0), new Point(800, 600), Color.Blue, Color.CornflowerBlue);
            LinearGradientBrush br0 = new LinearGradientBrush(new Point(100, 100), new Point(800, 600), Color.Tomato, Color.YellowGreen);
            LinearGradientBrush br1 = new LinearGradientBrush(new Point(0, 0), new Point(1060, 800), Color.Brown, Color.BlueViolet);
            Font font=new Font("",22,FontStyle.Bold);
            SizeF m=g.MeasureString(Information.Stringruleplay+Level.ToString()+")",font);
            g.DrawString(Information.Stringruleplay+ Level.ToString() + ")", font, br1, new Point((tabControl1.Width - (int)m.Width) / 2, 20));
            g.FillRectangle(br,new Rectangle(235, 95, tabPage1.Width - 470, 260));
            g.FillRectangle(br0,new Rectangle(240, 100, (tabPage1.Width - 480), 250));
            Point p=new Point((tabControl1.Width-global::UIT_Pokemon.Properties.Resources.up.Width)/2,120);
            if (Level == 2)
            {
                g.DrawImage(global::UIT_Pokemon.Properties.Resources.down,new Rectangle(tabControl1.Width/2-200,120,100,230));
                g.DrawImage(global::UIT_Pokemon.Properties.Resources.down, new Rectangle(tabControl1.Width/2-50 , 120, 100, 230));
                g.DrawImage(global::UIT_Pokemon.Properties.Resources.down, new Rectangle(tabControl1.Width/2+100 , 120, 100, 230));
            }
            else if(Level==3)
            {
                g.DrawImage(global::UIT_Pokemon.Properties.Resources.up, new Rectangle(tabControl1.Width / 2 - 200, 120, 100, 230));
                g.DrawImage(global::UIT_Pokemon.Properties.Resources.up, new Rectangle(tabControl1.Width / 2 - 50, 120, 100, 230));
                g.DrawImage(global::UIT_Pokemon.Properties.Resources.up, new Rectangle(tabControl1.Width / 2 + 100, 120, 100, 230));
            
            }
            else if(Level==4)
            {
                g.DrawImage(global::UIT_Pokemon.Properties.Resources.left, new Rectangle(260,140,460,40));
                g.DrawImage(global::UIT_Pokemon.Properties.Resources.left, new Rectangle(260, 270, 460, 40));
            }
            else  if(Level==5)
            {
                 g.DrawImage(global::UIT_Pokemon.Properties.Resources.right, new Rectangle(260, 140, 460, 40));
                 g.DrawImage(global::UIT_Pokemon.Properties.Resources.right, new Rectangle(260, 270, 460, 40));
            }
            else if(Level==6)
            {
                g.FillRectangle(br, new Rectangle((235*2+tabControl1.Width-470-5)/2, 95, 5, 260));
                g.DrawImage(global::UIT_Pokemon.Properties.Resources.left, new Rectangle(260, 170, 460/2-10, 80));
                g.DrawImage(global::UIT_Pokemon.Properties.Resources.right, new Rectangle(260+247, 174, 460 / 2 - 10, 80));
            }
            else if(Level==7)
            {
                g.FillRectangle(br,new Rectangle(240, 222, 500, 5));
                g.DrawImage(global::UIT_Pokemon.Properties.Resources.up, new Rectangle((235*2+tabControl1.Width-470-100)/2, 110, 80,120));
                g.DrawImage(global::UIT_Pokemon.Properties.Resources.down, new Rectangle((235 * 2 + tabControl1.Width - 470 - 100) / 2, 232, 80, 120));
            }
             else if(Level==8)
            {
                g.FillRectangle(br, new Rectangle((235*2+tabControl1.Width-470-5)/2, 95, 5, 260));
                g.DrawImage(global::UIT_Pokemon.Properties.Resources.right, new Rectangle(260, 170, 460/2-10, 80));
                g.DrawImage(global::UIT_Pokemon.Properties.Resources.left, new Rectangle(260+247, 174, 460 / 2 - 10, 80));
            }
            else if(Level==9)
            {
                g.FillRectangle(br,new Rectangle(240, 222, 500, 5));
                g.DrawImage(global::UIT_Pokemon.Properties.Resources.down, new Rectangle((235*2+tabControl1.Width-470-100)/2, 110, 80,120));
                g.DrawImage(global::UIT_Pokemon.Properties.Resources.up, new Rectangle((235 * 2 + tabControl1.Width - 470 - 100) / 2, 232, 80, 120));
            }
            else if(Level==10)
            {
                g.FillRectangle(br, new Rectangle((235 * 2 + tabControl1.Width - 470 - 5) / 2, 95, 5, 260));
                g.DrawImage(global::UIT_Pokemon.Properties.Resources.down, new Rectangle(tabControl1.Width / 2 - 200, 120, 100, 230));
                g.DrawImage(global::UIT_Pokemon.Properties.Resources.up, new Rectangle(tabControl1.Width / 2 + 100, 120, 100, 230));
            }
            else if(Level==11)
            {
                g.FillRectangle(br, new Rectangle((235 * 2 + tabControl1.Width - 470 - 5) / 2, 95, 5, 260));
                g.DrawImage(global::UIT_Pokemon.Properties.Resources.up, new Rectangle(tabControl1.Width / 2 - 200, 120, 100, 230));
                 g.DrawImage(global::UIT_Pokemon.Properties.Resources.down, new Rectangle(tabControl1.Width / 2 + 100, 120, 100, 230));
            }
            else if(Level==12)
            {
                 g.FillRectangle(br, new Rectangle(240, 222, 500, 5));
                 g.DrawImage(global::UIT_Pokemon.Properties.Resources.left, new Rectangle(260, 140, 460, 40));
                 g.DrawImage(global::UIT_Pokemon.Properties.Resources.right, new Rectangle(260, 270, 460, 40));
            }
            else if(Level==13)
            {
                 g.FillRectangle(br, new Rectangle(240, 222, 500, 5));
                 g.DrawImage(global::UIT_Pokemon.Properties.Resources.right, new Rectangle(260, 140, 460, 40));
                 g.DrawImage(global::UIT_Pokemon.Properties.Resources.left, new Rectangle(260, 270, 460, 40));
            }
            else if(Level==14)
            {
                  g.DrawLine(new Pen(br, 5), new Point(237, 97), new Point(237+ 505, 95 + 255));
                  g.DrawImage(global::UIT_Pokemon.Properties.Resources.right, new Rectangle(320, 100, 400, 40));
                  g.DrawImage(global::UIT_Pokemon.Properties.Resources.left, new Rectangle(265, 310, 400, 40));
            }
            else if(Level==15)
            {
                g.DrawLine(new Pen(br, 5), new Point(237, 95 + 255), new Point(237+ 505, 97));
                g.DrawImage(global::UIT_Pokemon.Properties.Resources.left, new Rectangle(265, 100, 400, 40));
                g.DrawImage(global::UIT_Pokemon.Properties.Resources.right, new Rectangle(320, 310, 400, 40));
            }

            font.Dispose();
            
            br1.Dispose();
        }

        private void HelpIntroduction_Load(object sender, EventArgs e)
        {
           
        }

        private void tabPage2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            LinearGradientBrush br = new LinearGradientBrush(new Point(0, 0), new Point(1060, 800), Color.BurlyWood, Color.CornflowerBlue);
            LinearGradientBrush br1 = new LinearGradientBrush(new Point(0, 0), new Point(1060, 800), Color.Brown, Color.BlueViolet);
            g.FillRectangle(br, 0, 0, this.Width, this.Height);
            Font font = new Font("", 22, FontStyle.Bold);
            SizeF m = g.MeasureString(Information.StringIntroduce, font);
            g.DrawString(Information.StringIntroduce, font, br1, new Point((tabControl1.Width - (int)m.Width) / 2, 20));
            Font font1 = new Font("", 15, FontStyle.Regular);
            g.DrawString(Information.StringIntroduce1, font1, br1, new Rectangle(10, 60, tabPage2.Width - 20, 140), StringFormat.GenericTypographic);
            g.DrawString(Information.StringIntroduce2, new Font("",15,FontStyle.Regular), br1, new Rectangle(30, 180, tabPage2.Width - 40, 160));
            m = g.MeasureString(Information.StringIntroduceEnd,font);
            g.DrawString(Information.StringIntroduceEnd, font, br1, new Point((tabControl1.Width - (int)m.Width) / 2, 360));
             
            font.Dispose();
            br.Dispose();
            br1.Dispose();
        }
    }
}
