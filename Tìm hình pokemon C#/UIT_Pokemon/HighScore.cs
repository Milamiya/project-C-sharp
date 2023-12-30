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
    public partial class HighScore : Form
    {

        public HighScore(int a)
        {
            InitializeComponent();
            button1.Text = Information.StringButtonCancel;
            UIT_PokemonHighScore.List_highscore high_score = UIT_PokemonHighScore.HighScoreGame.ReadHighScore();
            ListViewItem[] list_easy = new ListViewItem[10];
            ListViewItem[] list_mid = new ListViewItem[10];
            ListViewItem[] list_hard = new ListViewItem[10];
            for (int i = 0; i < 10; i++)
            {
                list_easy[i] = new ListViewItem(high_score.player_easy.Getplayer(i).Convert(i + 1), -1);
                list_mid[i] = new ListViewItem(high_score.player_mid.Getplayer(i).Convert(i + 1), -1);
                list_hard[i] = new ListViewItem(high_score.player_hard.Getplayer(i).Convert(i + 1), -1);
            }
            //MessageBox.Show(high_score.player_hard[0].Convert(1 + 1)[1].ToString());
            listView1.Items.AddRange(list_easy);
            listView2.Items.AddRange(list_mid);
            listView3.Items.AddRange(list_hard);
            tabControl1.SelectedTab = (TabPage)tabControl1.Controls[a];
            TopMost = true;
        }

        private void HighScore_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighSpeed;
            LinearGradientBrush br = new LinearGradientBrush(new Point(0, 0), new Point(800, 500), Color.BurlyWood, Color.CornflowerBlue);
            LinearGradientBrush br1 = new LinearGradientBrush(new Point(0, 0), new Point(800, 500), Color.Chocolate, Color.RosyBrown);
            g.FillRectangle(br, new Rectangle(0, 0, this.Width, this.Height));
            g.DrawRectangle(new Pen(br1, 6), new Rectangle(0, 0, this.Width - 1, this.Height - 1));
            br.Dispose();
            br1.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
