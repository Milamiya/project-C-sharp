using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace UIT_Pokemon
{
    public partial class LevelCharacter : Form
    {
        PictureBox p;
        int tmp;
        PictureBox[] character = new PictureBox[15];
        private Timer time = new Timer();
        private Form1 form;
        public LevelCharacter(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            p = new PictureBox();
            p.Location = new Point(0, 0);
            p.Size = new Size(7500, 520);
            this.Controls.Add(p);
            if (form.full == true)
                this.Location = new Point(this.Location.X, this.Location.Y - 20);
            Config config = OptionPlay.ReadConfig();
            for (int i = 0; i < 15; i++)
            {
                character[i] = new PictureBox();
                character[i].Location = new Point(i * 500, 20);
                character[i].Size = new Size(500, 500);
                character[i].SizeMode = PictureBoxSizeMode.Zoom;
                p.Controls.Add(character [i]);
                character[i].BackColor = Color.Transparent;
                character[i].Paint += new PaintEventHandler(Character_Paint);
                character[i].Name = Information.StringLevel+" "+ (i + 1).ToString();
            }
            for (int i = 1; i <= config.MaxLevel; i++)
            {
                String Filename = Information.directories + "\\Collection\\";
                Filename += "Level" + (i).ToString() + ".UIT";
                if (File.Exists(Filename))
                {
                    try
                    {
                        ImageFile imagefile = ReadfileImage.ReadFile(Filename);
                        if (imagefile.ImageLevel!=null&&imagefile.level == i)
                            character[i - 1].Image = imagefile.ImageLevel;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            p.BackColor = Color.Transparent;
            time.Interval = 30;
            time.Tick += new EventHandler(time_Tick);
            this.TopMost = true;
            tmp = 0;
            button1.Text = Information.StringButtonCancel;
            label1.Text = Information.StringCollectionPikemon;
        }
        private void Character_Paint(Object obj, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            PictureBox p = (PictureBox)obj;
            LinearGradientBrush br = new LinearGradientBrush(new Point(0, 0), new Point(1000, 1000), Color.Blue, Color.YellowGreen);
            LinearGradientBrush br1 = new LinearGradientBrush(new Point(0, 0), new Point(300, 300), Color.Brown, Color.Crimson);

            if (p.Image == null)
            {
                g.DrawImage(global::UIT_Pokemon.Properties.Resources._lock,new Rectangle(50,50,400,400));
            }
            g.DrawString(p.Name, new Font("", 30, FontStyle.Bold), br1, new PointF(170, 460));
        }
        private void time_Tick(Object obj,EventArgs e)
        {
            if (next == true)
            {
                tmp++;
                p.Location = new Point(p.Location.X - 50, p.Location.Y);
                if (tmp % 10 == 0 || tmp >= 10 * 14)
                {
                    time.Stop();
                    if(tmp<140)
                    button2.Enabled = true;
                }
            }
            else
            {
                tmp--;
                p.Location = new Point(p.Location.X + 50, p.Location.Y);
                if (tmp %10==0 || tmp < 0)
                {
                    time.Stop();
                    if(tmp>0)
                    button3.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LevelCharacter_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            LinearGradientBrush br = new LinearGradientBrush(new Point(0, 0), new Point(1060, 800), Color.BurlyWood, Color.CornflowerBlue);
            g.FillRectangle(br, 0, 0, this.Width, this.Height);
           
        }
        bool next = true;
        private void button2_Click(object sender, EventArgs e)
        {
            next=true;
            button3.Enabled = true;
            button2.Enabled = false;
            time.Start();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            next = false;
            button2.Enabled = true;
            button3.Enabled = false;
            time.Start();
        }
    }
}
