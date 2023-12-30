using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace VirtualClock
{
	/// <summary>
	/// Summary description for Hand.
	/// </summary>
	public class Hand
	{
		protected GraphicsPath gp = new GraphicsPath();
		protected GraphicsPath gpBase = null;
		protected int midX = 150;
		protected int midY = 150;

		public Hand(Form1 theForm)
		{
			//
			// TODO: Add constructor logic here
			midX = (theForm.ClientRectangle.Left + theForm.ClientRectangle.Right)/2;
			midY =(theForm.ClientRectangle.Top + theForm.ClientRectangle.Bottom)/2;
			//
		}

		public virtual void Transform(DateTime d)
		{
		}

		public virtual void Draw(Graphics g)
		{
			Pen aPen = new Pen(Brushes.Black, 4.0f);
			g.DrawPath(aPen, gp);
			g.FillPath(Brushes.Black, gp);
			aPen.Dispose();
		}

		public void Rotate(double angle)
		{
			gp = (GraphicsPath)gpBase.Clone();
			Matrix mTransform = new Matrix();
			mTransform.RotateAt((float)angle, new PointF(midX, midY));
			gp.Transform(mTransform);
		}

	}
}
