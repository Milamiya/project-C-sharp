using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace VirtualClock
{
	/// <summary>
	/// Summary description for HourHand.
	/// </summary>
	public class HourHand : Hand
	{
		public HourHand(Form1 myForm) : base(myForm)
		{
			//
			// TODO: Add constructor logic here
			//
			gp.AddLine(midX, midY, midX, 80);
			Point[] arrow = new Point[4] {
											 new Point(midX, 80),
											 new Point(midX - 3, 85),
											 new Point(midX + 3, 85),
											 new Point(midX, 80)
										 };
			gp.AddPolygon(arrow);
			gpBase = (GraphicsPath)gp.Clone();
		}

		public override void Transform(DateTime d)
		{
		 
			// turn it into an angle
			// 60 seconds in 2 pi
			double hourTime = (double)d.Hour + (double)(d.Minute/60.0);
			double angle =  (hourTime/12.0) * 360; // 2.0 * Math.PI;
			Rotate(angle);
		}

	}
}
