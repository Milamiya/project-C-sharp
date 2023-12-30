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
using System.Drawing;
using System.Windows.Forms;

namespace Lines2008
{
	class MoveThread
	{
		MyPanel panel;
		ArrayList list;
		int count;
		Timer timer;
		Point point;
		int color;

		public MoveThread(MyPanel panel, ArrayList list)
		{
			if (panel.mainForm.isSound) LinesMediaPlayer.moveSound.Play();
			panel.backUp();

			this.panel = panel;
			this.list = list;

			timer = new Timer();
			timer.Interval = SkinConstants.DelayMove;
			timer.Tick += new EventHandler(timer_Tick);

			point = (Point)list[0];
			color = panel.gameShape.matrix[point.X, point.Y];

			panel.gameShape.matrix[point.X, point.Y] = 0;
			panel.pieces[point.X, point.Y].color = 0;

			count = 0;
			panel.isLocking = true;

			timer.Start();
		}

		public void timer_Tick(object Sender, EventArgs e)
		{
			count++;

			if (panel.pieces[point.X, point.Y].color >= 0)
				panel.pieces[point.X, point.Y].Visible = false;
			else
				panel.pieces[point.X, point.Y].setHint();

			point = (Point)list[count];
			panel.pieces[point.X, point.Y].Image = ClippingImage.bitmapPiece[0, color - 1];
			panel.pieces[point.X, point.Y].Visible = true;

			if (count == list.Count - 1)
			{
				timer.Stop();
				panel.gameShape.matrix[point.X, point.Y] = color;
				panel.pieces[point.X, point.Y].color = color;
				ArrayList arr = Algorithms.checkLines(panel.gameShape.matrix, point.X, point.Y);
				if (arr == null)
					panel.appearenceThread = new AppearenceThread(panel, panel.gameShape.matrix);
				else
					panel.destructionThread = new DestructionThread(panel, arr);
			}
		}

		public void Stop()
		{
			timer.Stop();
		}
	}
}
