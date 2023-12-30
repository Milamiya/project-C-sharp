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
	public partial class WhatsYourName : Form
	{
		GameShape g;
		
		public WhatsYourName(GameShape g)
		{
			this.g = g;
			InitializeComponent();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (this.textBox1.Text == "")
				MessageBox.Show(this, "Your name must not be blank!", "Error", MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			else
			{
				Player p = new Player(this.textBox1.Text, g.scores, g.hours, g.minutes, g.seconds);
				HighScoresFunctions.insert(p);
				this.Close();
				new HighScoresForm().ShowDialog();
			}
		}
	}
}