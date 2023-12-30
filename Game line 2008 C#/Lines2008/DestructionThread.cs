/**********************************/
/*                                */
/* Author: BUI VAN NGHIA          */
/* Email: katatunix@yahoo.com     */
/*                 [May, 2008]    */
/*                                */
/**********************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;

namespace Lines2008
{
	class DestructionThread
	{
		MyPanel panel;
		Timer timer;
		Point[] p;
		int len, count;

		public DestructionThread(MyPanel panel, ArrayList list)
		{
			if (panel.mainForm.isSound) LinesMediaPlayer.destroySound.Play();
			
			this.panel = panel;

			p = new Point[list.Count];
			len = list.Count;
			for (int i = 0; i < list.Count; i++)
				p[i] = (Point)list[i];

			timer = new Timer();
			timer.Interval = SkinConstants.DelayDestruction;
			timer.Tick += new EventHandler(timer_Tick);
			count = 0;
			timer.Start();
		}

		void timer_Tick(object sender, EventArgs e)
		{
			for (int i = 0; i < len; i++)
			{
				panel.pieces[p[i].X, p[i].Y].setDestructionAt(count);
			}
			count++;

			if (count == SkinConstants.BallDestruction.Length)
			{
				timer.Stop();
				for (int i = 0; i < len; i++)
				{
					panel.pieces[p[i].X, p[i].Y].color = 0;
					panel.pieces[p[i].X, p[i].Y].Visible = false;
					panel.gameShape.matrix[p[i].X, p[i].Y] = 0;
				}

				panel.gameShape.scores += p.Length + p.Length - 5;
				panel.repaintYScore(panel.gameShape.scores);
				panel.isLocking = false;
			}
		}

		public void Stop()
		{
			timer.Stop();
		}

	}
}
