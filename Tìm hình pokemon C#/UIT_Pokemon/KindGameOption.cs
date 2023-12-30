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
    public partial class KindGameOption : Form
    {
        public int kindgame = 1;
        public bool accept = false;
        public Form1 form;
        public KindGameOption(Form1 form)
        {
            this.form = form;
            InitializeComponent();
            if (form.KindGame == 1)
                EASY.Checked = true;
            else if (form.KindGame== 2)
                MEDIUM.Checked = true;
            else
                DIFFICULT.Checked = true;
            if (form.full == true)
                this.Location = new Point(440, 160);
            TopMost = true;
        }

        private void KindGameOption_Load(object sender, EventArgs e)
        {
            EASY.BackColor = Color.Transparent;
            MEDIUM.BackColor = Color.Transparent;
            DIFFICULT.BackColor = Color.Transparent;
            EASY.Text = Information.StringKindEasy;
            MEDIUM.Text = Information.StringKindMedium;
            DIFFICULT.Text = Information.StringKindDifficult;
            this.Text = Information.StringKindgameLabel1;
            OK.Text = Information.StringButtonOK;
            Cancel.Text = Information.StringButtonCancel;
        }
        private void KindGameOption_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighSpeed;
            LinearGradientBrush br = new LinearGradientBrush(new Point(0, 0), new Point(500, 400), Color.BurlyWood, Color.CornflowerBlue);
            LinearGradientBrush br1 = new LinearGradientBrush(new Point(0, 0), new Point(500, 400), Color.DarkMagenta, Color.DarkSeaGreen);
            g.FillRectangle(br, new Rectangle(0, 0, this.Width, this.Height));
            g.DrawRectangle(new Pen(br1, 6), new Rectangle(0, 0, this.Width - 1, this.Height - 1));
            Font font = new Font("", 12, FontStyle.Bold);
            SizeF m = g.MeasureString(Information.StringKindgameLabel1, font);
            g.DrawString(Information.StringKindgameLabel1, font, br1, new PointF((this.Width - m.Width) / 2, 5));
            m = m = g.MeasureString(Information.StringKindgameLabel2, font);
            g.DrawString(Information.StringKindgameLabel2, font, br1, new PointF((this.Width - m.Width) / 2-10, 120));

            font.Dispose();
            br.Dispose();
            br1.Dispose();
        }

        private void Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            accept = true;
            if (EASY.Checked == true)
            {
                kindgame = 1;
            }
            else if (MEDIUM.Checked == true)
            {
                kindgame = 2;
            }
            else
                kindgame = 3;
            //Information.PokemonNumber = 16 + (optionplay.kindgame - 1) * 6;
            Information.CurrentKindGame =Information.defaultPokemonNumber+ (kindgame - 1) * 6;
            form.KindGame = kindgame;
            form.Score = 0;
            form.Level = 1;
            form.argument.Level = 1;
            form.timeplay.Reset();
            form.lifetime.Life = 10 + (form.KindGame - 1) * 5;
            form.NewGame();
            Config config = OptionPlay.ReadConfig();
            int tmp = config.MaxLevel;
            config = new Config(form.effect, form.wayeffect.BackColor, form.English, form.KindGame,tmp);
            OptionPlay.WriteConfig(config);
            this.Close();
        }
    }
}
