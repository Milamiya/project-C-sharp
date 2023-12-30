/**********************************/
/*                                */
/* Author: BUI VAN NGHIA          */
/* Email: katatunix@yahoo.com     */
/*                 [May, 2008]    */
/*                                */
/**********************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lines2008
{
	public partial class MainForm : Form
	{
		MyPanel panel;
		public bool isSound = true;

		string currentFileName = "";

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			panel = new MyPanel(this);
			this.Controls.Add(panel);
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			panel.newGame();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		private void soundToolStripMenuItem_Click(object sender, EventArgs e)
		{
			isSound = !isSound;
		}

		private void endGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			panel.setGameOver();
		}

		public void setStepBack(bool b)
		{
			this.stepBackToolStripMenuItem.Enabled = b;
		}

		private void stepBackToolStripMenuItem_Click(object sender, EventArgs e)
		{
			panel.stepBack();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			save();
		}

		private void save()
		{
			if (this.saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
			currentFileName = this.saveFileDialog1.FileName;
			SaveAndLoad.saveGame(panel.gameShape, this.saveFileDialog1.FileName);
		}

		private void loadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			load();
		}

		private void load()
		{
			if (this.openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
			currentFileName = this.openFileDialog1.FileName;
			GameShape g = SaveAndLoad.loadGame(this.openFileDialog1.FileName);
			panel.applyGameShape(g);
		}

		private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (currentFileName == "")
				save();
			else
				SaveAndLoad.saveGame(panel.gameShape, currentFileName);
		}

		private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (currentFileName == "")
				load();
			else
				panel.applyGameShape(SaveAndLoad.loadGame(currentFileName));
		}

		private void highScoresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new HighScoresForm().ShowDialog(this);
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new AboutMe().ShowDialog(this);
		}

		private void rulesOfTheGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new HowToPlay().ShowDialog();
		}
	}
}