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
using System.Drawing;

namespace Lines2008
{
	class SkinConstants
	{
		public static string BKG = "bkg.bmp";
		public static string BALLS = "balls.bmp";
		public static string NEXT = "next.bmp";
		public static string TIME = "time.bmp";
		public static string YSCORE = "digits.bmp";
		public static string HSCORE = "digits.bmp";

		public static Size BKGSize = new Size(410, 461);
		public static Size BallSize = new Size(40, 40);
		public static Size NextColorSize = new Size(25, 25);
		public static Size TimeDigitSize = new Size(7, 13);
		public static Size HScoreDigitSize = new Size(18, 35);
		public static Size YScoreDigitSize = new Size(18, 35);

		public static Point UpperLeftBall = new Point(5, 56);
		public static Size BetweenBalls = new Size(5, 5);

		public static Point YourScorePos = new Point(290, 7);
		public static int YourScoreBetweenX = 3;
		
		public static Point HighScorePos = new Point(19, 7);
		public static int HighScoreBetweenX = 3;

		public static Point TimePos = new Point(183, 34);
		public static int TimeBetween = 2;
		public static int TimeAndCommaBetween = 1;

		public static Point[] NextColor = { new Point(164, 9), new Point(193, 9), new Point(222, 9) };

		public static int[] BallSelected = { 1, 4, 3, 2, 3, 4, 1, 5, 6, 7, 6, 5 };
		public static int[] BallAppearence = { 22, 21, 20, 19, 18 };
		public static int[] BallDestruction = { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
		public static int BallHint = 21;

		public static int DelayJump = 60;
		public static int DelayAppearence = 60;
		public static int DelayDestruction = 30;
		public static int DelayMove = 20;

		public static Point getLocationOfPiece(int col, int row)
		{
			return new Point(
				UpperLeftBall.X + (BallSize.Width + BetweenBalls.Width) * col,
				UpperLeftBall.Y + (BallSize.Height + BetweenBalls.Height) * row);
		}

		public static Point getColRowIndex(int X, int Y)
		{
			if (X < UpperLeftBall.X) return new Point(-1, -1);
			if (Y < UpperLeftBall.Y) return new Point(-1, -1);
			return new Point(
				(X - UpperLeftBall.X) / (BallSize.Width + BetweenBalls.Width),
				(Y - UpperLeftBall.Y) / (BallSize.Height + BetweenBalls.Height));
		}

		public static Point getLocationOfYScore(int index)
		{
			return new Point(
				YourScorePos.X + (YScoreDigitSize.Width + YourScoreBetweenX) * index,
				YourScorePos.Y);
		}

		public static Point getLocationOfHScore(int index)
		{
			return new Point(
				HighScorePos.X + (HScoreDigitSize.Width + HighScoreBetweenX) * index,
				HighScorePos.Y);
		}
	}
}
