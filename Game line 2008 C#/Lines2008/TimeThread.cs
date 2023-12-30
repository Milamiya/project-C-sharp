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

namespace Lines2008
{
	class TimeThread
	{
		MyPanel panel;
		Timer timer;

		public TimeThread(MyPanel panel)
		{
			this.panel = panel;
			timer = new Timer();
			timer.Interval = 1000;
			timer.Tick += new EventHandler(timer_Tick);
			timer.Start();
		}

		void timer_Tick(object sender, EventArgs e)
		{
			panel.gameShape.seconds++;
			if (panel.gameShape.seconds == 60)
			{
				panel.gameShape.seconds = 0;
				panel.gameShape.minutes++;
				if (panel.gameShape.minutes == 60)
				{
					panel.gameShape.minutes = 0;
					panel.gameShape.hours++;
				}
			}
			panel.repaintHour(panel.gameShape.hours);
			panel.repaintMinutes(panel.gameShape.minutes);
			panel.repaintSeconds(panel.gameShape.seconds);
		}

		public void Stop()
		{
			timer.Stop();
		}
	}
}
