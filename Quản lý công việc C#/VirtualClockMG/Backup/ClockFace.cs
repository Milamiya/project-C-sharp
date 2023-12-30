using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace VirtualClock
{
	/// <summary>
	/// Summary description for ClockFace.
	/// </summary>
	public class ClockFace
	{
		private Rectangle ClockRectangle;
		private Font ClockFont = new Font("Arial", 12);
		private Point midPoint;
		private Bitmap ClockImage;
		private const int IMAGEX = 50;
		private const int IMAGEY = 50;

		public ClockFace(Rectangle aRect)
		{
			//
			// TODO: Add constructor logic here
			//
			ClockRectangle = aRect;
			midPoint = new Point((aRect.Right + aRect.Left)/2,
								(aRect.Top + aRect.Bottom)/2);

			ClockImage = (Bitmap)Bitmap.FromFile("mickey.jpg");
								
		}

		public void Draw(Graphics g)
		{

 			// draw blank face of clock
			DrawClockFace(g);

			// Draw clock Image
			DrawImage(g);

			// draw numbers around the face
			DrawNumbers(g);
			
			// draw clock pin
			DrawPin(g);

		}

		private void DrawImage(Graphics g)
		{
		  int nWidth = ClockImage.Width;
		  int nHeight = ClockImage.Height;
//		  Rectangle destRect = new Rectangle(midPoint.X - nWidth/2, 
//			  midPoint.Y - nHeight/2,
//			  nWidth,
//			  nHeight);
			Rectangle destRect = new Rectangle(midPoint.X - IMAGEX/2, 
				midPoint.Y - IMAGEY/2,
				IMAGEX,
				IMAGEY);

		  g.DrawImage(ClockImage, destRect, 0, 0, nWidth, nHeight, GraphicsUnit.Pixel);
		}

		private void DrawClockFace(Graphics g)
		{
			g.FillEllipse(Brushes.White, ClockRectangle.Left + 10,
				ClockRectangle.Top + 10, ClockRectangle.Width - 20,
				ClockRectangle.Height - 20);
			g.DrawEllipse(Pens.Black, ClockRectangle.Left + 10,
				ClockRectangle.Top + 10, ClockRectangle.Width - 20,
				ClockRectangle.Height - 20);
		}


		private void DrawNumbers(Graphics g)
		{
			int count = 1;
			for (double a = 0; a < 2 * Math.PI; a += (2.0* Math.PI/12))
			{
				double x = (ClockRectangle.Width - 70)/2 * Math.Cos(a - Math.PI/3) + (ClockRectangle.Width - 70)/2 + 25;
				double y = (ClockRectangle.Width - 70)/2 * Math.Sin(a - Math.PI/3)+ (ClockRectangle.Width - 70)/2 + 20;
				g.DrawString(Convert.ToString(count), ClockFont, Brushes.Black, (float)x,(float)y, new StringFormat());
				count++;
			}
		}

		public void UpdateRectangle(Rectangle aRectangle)
		{
		  ClockRectangle = aRectangle;
		}

		public void DrawPin(Graphics g)
		{
			g.FillEllipse(Brushes.Black, midPoint.X - 3, midPoint.Y - 3, 6, 6);
		}
	}
}
