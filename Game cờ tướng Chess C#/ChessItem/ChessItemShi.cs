using System;
using System.Drawing;
namespace ChessItem
{
	/// <summary>
	/// ChessItemShi 的摘要说明。
	/// </summary>
	public class ChessItemShi : ChessItemBase
	{
		public ChessItemShi()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		public override int StepX
		{
			get
			{
				return 1;
			}

		}

		public override int StepY
		{
			get
			{
				return 1;
			}

		}

		public override bool LimitPoint(int ChessX, int ChessY)
		{
			if(this.type == IChess.Enums.ChessType.red && 
				( ChessX < 3 ||
				ChessX > 5 ||
				ChessY < 7)
				)
				return false;
			else if(this.type == IChess.Enums.ChessType.blue &&
				( ChessX < 3 ||
				ChessX > 5 ||
				ChessY > 2)
				)
				return false;

			return base.LimitPoint (ChessX, ChessY);
		}


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
