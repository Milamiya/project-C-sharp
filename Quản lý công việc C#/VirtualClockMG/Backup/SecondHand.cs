using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace VirtualClock
{
	/// <summary>
	/// Summary description for SecondHand.
	/// </summary>
	public class SecondHand : Hand
	{
		public SecondHand(Form1 myForm): base(myForm)
		{
			//
			// TODO: Add constructor logic here
			//
			gp.AddLine(midX, midY, midX, 45);
			Point[] arrow = new Point[4] {
											 new Point(midX, 45),
											 new Point(midX - 2, 50),
											 new Point(midX + 2, 50),
											 new Point(midX, 45)
										 };

			gp.AddPolygon(arrow);
			gpBase = (GraphicsPath)gp.Clone();
		}

		public override void  Draw(Graphics g)
		{
			g.DrawPath(new Pen(Brushes.Red, 2.0f), gp);
		}

		public override void Transform(DateTime d)
		{
		 
		  // turn it into an angle
		  // 60 seconds in 2 pi
			double angle = ((double)d.Second /60.0 ) * 360; // 2.0 * Math.PI;
			Rotate(angle);
		}


	}
}
