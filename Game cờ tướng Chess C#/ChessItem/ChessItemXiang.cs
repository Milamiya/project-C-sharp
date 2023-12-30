using System;
using System.Drawing;

namespace ChessItem
{
	/// <summary>
	/// ChessItemXiang µÄÕªÒªËµÃ÷¡£
	/// </summary>
	public class ChessItemXiang : ChessItemBase
	{
		public ChessItemXiang()
		{
			//
			// TODO: ÔÚ´Ë´¦Ìí¼Ó¹¹Ôìº¯ÊýÂß¼­
			//
		}

		public override int StepX
		{
			get
			{
				return 2;
			}

		}

		public override int StepY
		{
			get
			{
				return 2;
			}

		}

		public override bool LimitPoint(int ChessX, int ChessY)
		{
			if(this.type == IChess.Enums.ChessType.red && ChessY < 5) return false;
			else if(this.type == IChess.Enums.ChessType.blue && ChessY > 5)return false;

			bool flag = false;
			if(ChessX-GridX==-2 && ChessY-GridY==-2) flag=HasChessItemOnPoint(GridX-1,GridY-1);
			else if(ChessX-GridX==2 && ChessY-GridY==-2) flag=HasChessItemOnPoint(GridX+1,GridY-1);
			else if(ChessX-GridX==-2 && ChessY-GridY==2) flag=HasChessItemOnPoint(GridX-1,GridY+1);
			else if(ChessX-GridX==2 && ChessY-GridY==2) flag=HasChessItemOnPoint(GridX+1,GridY+1);
			if(flag) return false;

			return base.LimitPoint (ChessX, ChessY);
		}

        //Download source code tại Sharecode.vn
		public override bool MoveItem(int ChessX, int ChessY)
		{
			if(!LimitPoint( ChessX ,ChessY)) return false;

			if( (GetInt32(ChessY-GridY) == StepY)&&
				((GetInt32(ChessX-GridX) == StepX)))
			{
				
				this.Location = new Point(ChessX*50,ChessY*50);
				GridX = ChessX;
				GridY = ChessY;
				return true;
			}

			return false;
		}

	}
}
