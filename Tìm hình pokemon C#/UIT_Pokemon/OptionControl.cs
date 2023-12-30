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
    public partial class OptionControl : Form
    {
        private Form1 form;
        int color = 0;
        int language = 0;
        public OptionControl(Form1 form)
        {
            this.form = form;
            InitializeComponent();
            if (form.LockSound == false)
                checkBox1.Checked = true;
            if (form.effect == true)
                checkBox2.Checked = true;
            if (form.full == true)
            {
                this.Location = new Point(410, 145);
                checkBox3.Checked = true;
            }

            TopMost = true;
        }

        private void OptionControl_Load(object sender, EventArgs e)
        {
            Loading();
        }
        public void Loading()
        {
            checkBox1.Text = Information.StringSound;
            checkBox2.Text = Information.StringEffect;
            checkBox3.Text = Information.StringFull;
            OK.Text = Information.StringButtonOK;
            Cancel.Text = Information.StringButtonCancel;
            label1.Text = Information.StringChangeColor;
            label2.Text = Information.StringChaneLanguage;
            comboBox1.Text = (String)comboBox1.Items[0];
            if (form.English == true)
            {
                comboBox2.Text = (String)comboBox2.Items[0];
                language = 0;
            }
            else
            {
                comboBox2.Text = (String)comboBox2.Items[1];
                language = 1;
            }
            this.Invalidate();
        }
        private void OptionControl_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighSpeed;
            LinearGradientBrush br = new LinearGradientBrush(new Point(0, 0), new Point(500, 400), Color.BurlyWood, Color.CornflowerBlue);
            LinearGradientBrush br1 = new LinearGradientBrush(new Point(0, 0), new Point(500, 400), Color.DarkMagenta, Color.DarkSeaGreen);
            g.FillRectangle(br, new Rectangle(0, 0, this.Width, this.Height));
            g.DrawRectangle(new Pen(br1, 6), new Rectangle(0, 0, this.Width - 1, this.Height - 1));
            Font font = new Font("", 13, FontStyle.Bold);
            SizeF m = g.MeasureString(Information.StringOptionLabel, font);
            g.DrawString(Information.StringOptionLabel, font, br1, new PointF((this.Width - m.Width) / 2, 5));
            //m = m = g.MeasureString(Information.StringKindgameLabel2, font);
            //g.DrawString(Information.StringKindgameLabel2, font, br1, new PointF((this.Width - m.Width) / 2, 120));

            font.Dispose();
            br.Dispose();
            br1.Dispose();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                form.LockSound = false;
            else
                form.LockSound = true;
            if (checkBox2.Checked == true)
                form.effect = true;
            else
                form.effect = false;
            if (language == 0)
                form.English = true;
            else
                form.English = false;
            if (checkBox3.Checked == true)
            {
                form.full = false;
            }
            else
            {
                form.full = true;
            }
            form.TurnOnScreen();
            if (color == 0)
                form.wayeffect.BackColor = Color.DarkGreen;
            else if(color==1)
                form.wayeffect.BackColor = Color.Blue;
            else if (color == 2)
                form.wayeffect.BackColor = Color.Red;
            else if (color == 3)
                form.wayeffect.BackColor = Color.Orange;
            else if (color == 4)
                form.wayeffect.BackColor = Color.Yellow;
            /*else if (color == 5)
                form.wayeffect.BackColor = Color.Blue;*/
            if (language == 0)
            {
                Information.English();
                form.English = true;
            }
            else
            {
                Information.Vietnamese();
                form.English = false;
            }
            form.ChoosingLanguage();
            this.Close();
            Config config = OptionPlay.ReadConfig();
            int tmp = config.MaxLevel;
            config = new Config(form.effect, form.wayeffect.BackColor, form.English, form.KindGame, tmp);
            OptionPlay.WriteConfig(config);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            color = comboBox1.SelectedIndex;  
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < comboBox1.Items.Count; i++)
                if (comboBox1.Text.CompareTo((String)comboBox1.Items[i])==0)
                {
                    color = i;
                    return;
                }
            comboBox1.Text = (String)comboBox1.Items[0];
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            language = comboBox2.SelectedIndex;
            
        }
    }
}
