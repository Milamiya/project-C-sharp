using System;
using System.Drawing;
using System.Windows.Forms;
using IChess;
namespace ChessItem
{
	/// <summary>
	/// Class1 的摘要说明。
	/// </summary>
	public class ChessItemBing : ChessItemBase
	{
		public ChessItemBing()
		{

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
			if(type == Enums.ChessType.blue ) 
			{
				if(ChessY < this.GridY) return false;
				if(ChessY<=4 && ChessX!=GridX) return false;
			}
			else if(type == Enums.ChessType.red )
			{
				if( ChessY > this.GridY) return false;
				if(ChessY>=5 && ChessX!=GridX) return false;

			}
			return base.LimitPoint (ChessX, ChessY);
		}

		public override bool MoveItem(int ChessX, int ChessY)
		{
			if(!LimitPoint( ChessX ,ChessY)) return false;
			if( ((ChessX==GridX) &&(GetInt32(ChessY-GridY) == StepY))||
				((GetInt32(ChessX-GridX)==StepX) &&(ChessY==GridY))
				)
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
