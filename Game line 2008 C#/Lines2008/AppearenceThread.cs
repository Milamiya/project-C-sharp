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
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace Lines2008
{
	class AppearenceThread
	{
		MyPanel panel;
		Point[] p;
		int len;
		Timer timer;
		int count;

		public AppearenceThread(MyPanel panel, int[,] a)
		{
			this.panel = panel;
			ArrayList list = new ArrayList();
			for (int i = 0; i < 9; i++)
				for (int j = 0; j < 9; j++)
					if (a[i, j] < 0)
					{
						list.Add(new Point(i, j));
					}

			p = new Point[list.Count];
			for (int i = 0; i < list.Count; i++)
				p[i] = (Point)list[i];
			len = p.Length;
			timer = new Timer();
			timer.Interval = SkinConstants.DelayAppearence;
			timer.Tick += new EventHandler(timer_Tick);
			count = 0;
			timer.Start();
		}

		void timer_Tick(object sender, EventArgs e)
		{
			for (int i = 0; i < len; i++)
			{
				panel.pieces[p[i].X, p[i].Y].setAppearenceAt(count);
			}
			count++;

			if (count == SkinConstants.BallAppearence.Length)
			{
				this.Stop();
				for (int i = 0; i < len; i++)
				{
					panel.gameShape.matrix[p[i].X, p[i].Y] = -panel.gameShape.matrix[p[i].X, p[i].Y];
					panel.pieces[p[i].X, p[i].Y].color = -panel.pieces[p[i].X, p[i].Y].color;
					panel.pieces[p[i].X, p[i].Y].setNormal();
				}
				
				ArrayList arr = new ArrayList();
				for (int i = 0; i < len; i++)
				{
					ArrayList a = Algorithms.checkLines(panel.gameShape.matrix, p[i].X, p[i].Y);
					if (a != null)
						arr = Algorithms.merge(arr, a);
				}
				if (arr.Count > 0)
				{
					panel.destructionThread = new DestructionThread(panel, arr);
					Algorithms.addNextColor(panel.gameShape.matrix);
					panel.repaintNextColor(panel.gameShape.matrix);
					panel.repaintPieces(panel.gameShape.matrix);
				}
				else if (Algorithms.countEmpty(panel.gameShape.matrix) < 3)
				{
					panel.setGameOver();
					panel.isLocking = false;
				}
				else
				{
					Algorithms.addNextColor(panel.gameShape.matrix);
					panel.repaintNextColor(panel.gameShape.matrix);
					panel.repaintPieces(panel.gameShape.matrix);
					panel.isLocking = false;
				}
			}
		}

		public void Stop()
		{
			timer.Stop();
		}
	}
}
