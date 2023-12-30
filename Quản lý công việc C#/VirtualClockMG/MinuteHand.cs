using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace VirtualClock
{
	/// <summary>
	/// Summary description for MinuteHand.
	/// </summary>
	public class MinuteHand : Hand
	{
		public MinuteHand(Form1 myForm) : base(myForm)
		{
			//
			// TODO: Add constructor logic here
			//
			gp.AddLine(midX, midY, midX, 45);
						Point[] arrow = new Point[4] {
														 new Point(midX, 45),
														 new Point(midX - 3, 50),
														 new Point(midX + 3, 50),
														 new Point(midX, 45)
													 };

			gp.AddPolygon(arrow);

			gpBase = (GraphicsPath)gp.Clone();
		}

		public override void Transform(DateTime d)
		{
			// turn the datetime minute component into an angle
			// remember: 60 seconds in 2 pi (1 circle)
			double minuteTime = (double)d.Minute + (double)(d.Second/60.0);
			double angle = ((double)minuteTime /60.0 ) * 360; // 2.0 * Math.PI;
			Rotate(angle);
		}


	}
}
