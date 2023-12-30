using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UIT_Pokemon
{
    public partial class InputName : Form
    {
        public Form1 form;
        public InputName(Form1 form, int i)
        {
            InitializeComponent();
            this.form = form;
            if (i != 0)
                label2.Text = "New Record !";
            if (form.full == true)
                this.Location = new Point(this.Location.X, this.Location.Y - 20);
            TopMost = true;
            textBox1.Focus();
            textBox1.Select();

        }
        private void OK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                return;
            if (form.KindGame==1)
            {
                UIT_PokemonHighScore.Player p = new UIT_PokemonHighScore.Player(textBox1.Text, "Medium", form.Level, form.Score, form.timeplay.hour, form.timeplay.minute, form.timeplay.second);
                UIT_PokemonHighScore.HighScoreGame.WriteNewScore(p, form.KindGame);
            }
            else if (form.KindGame==2)
            {
                UIT_PokemonHighScore.Player p = new UIT_PokemonHighScore.Player(textBox1.Text, "Hard", form.Level, form.Score, form.timeplay.hour, form.timeplay.minute, form.timeplay.second);
                UIT_PokemonHighScore.HighScoreGame.WriteNewScore(p, form.KindGame);
            }
            else
            {
                UIT_PokemonHighScore.Player p = new UIT_PokemonHighScore.Player(textBox1.Text, "hardest", form.Level, form.Score, form.timeplay.hour, form.timeplay.minute, form.timeplay.second);
                UIT_PokemonHighScore.HighScoreGame.WriteNewScore(p, form.KindGame);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}