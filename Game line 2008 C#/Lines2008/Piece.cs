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
using System.Drawing;

namespace Lines2008
{
	class Piece : PictureBox
	{
		public int col, row;
		public int color;

		public Piece(int i, int j)
		{
			this.col = i;
			this.row = j;
			this.Location = SkinConstants.getLocationOfPiece(i, j);
			this.Size = new Size(
				SkinConstants.BallSize.Width, SkinConstants.BallSize.Height);
		}

		public void setNormal()
		{
			this.Image = ClippingImage.bitmapPiece[0, color - 1];
		}

		public void setHint()
		{
			this.Image = ClippingImage.bitmapPiece[SkinConstants.BallHint, -color - 1];
		}

		public void setJumpAt(int frame)
		{
			this.Image = ClippingImage.bitmapPiece[SkinConstants.BallSelected[frame] - 1, color - 1];
		}

		public void setAppearenceAt(int frame)
		{
			this.Image = ClippingImage.bitmapPiece[SkinConstants.BallAppearence[frame] - 1, -color - 1];
		}

		public void setDestructionAt(int frame)
		{
			this.Image = ClippingImage.bitmapPiece[SkinConstants.BallDestruction[frame] - 1, color - 1];
		}
	}
}
