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
	class ClippingImage
	{
		public static Bitmap[,] bitmapPiece = clip(SkinConstants.BALLS, 22, 7);
		public static Bitmap[] bitmapYScoreDigit = clip(SkinConstants.YSCORE, 10);
		public static Bitmap[] bitmapHScoreDigit = clip(SkinConstants.HSCORE, 10);

		public static Bitmap[] bitmapNextColor = clip(SkinConstants.NEXT, 7);
		public static Bitmap[] bitmapTimeDigit = clip(SkinConstants.TIME, 10);

		public static Bitmap[,] clip(Bitmap bigImage, int cols, int rows)
		{
			Bitmap[,] images = new Bitmap[cols, rows];

			int pieceWidth = bigImage.Width / cols;
			int pieceHeight = bigImage.Height / rows;

			for (int i = 0; i < cols; i++)
				for (int j = 0; j < rows; j++)
				{
					images[i, j] = bigImage.Clone(
						new Rectangle(i * pieceWidth, j * pieceHeight, pieceWidth, pieceHeight),
						System.Drawing.Imaging.PixelFormat.DontCare);
				}
			return images;
		}

		public static Bitmap[,] clip(string fileName, int cols, int rows)
		{
			return ClippingImage.clip(new Bitmap(fileName), cols, rows);
		}

		public static Bitmap[] clip(Bitmap bigImage, int cols)
		{
			Bitmap[] images = new Bitmap[cols];

			int pieceWidth = bigImage.Width / cols;
			int pieceHeight = bigImage.Height;

			for (int i = 0; i < cols; i++)
			{
				images[i] = bigImage.Clone(
					new Rectangle(i * pieceWidth, 0, pieceWidth, pieceHeight),
					System.Drawing.Imaging.PixelFormat.DontCare);
			}
			return images;
		}

		public static Bitmap[] clip(string fileName, int cols)
		{
			return ClippingImage.clip(new Bitmap(fileName), cols);
		}
	}
}
