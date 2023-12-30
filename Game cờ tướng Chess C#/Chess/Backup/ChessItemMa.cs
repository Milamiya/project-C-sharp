using System;
using System.Drawing;

namespace ChessItem
{
	/// <summary>
	/// ChessItemMa 的摘要说明。
	/// </summary>
	public class ChessItemMa : ChessItemBase
	{
		public ChessItemMa()
		{
			//
			// TODO: 在此处添加构造函数逻辑
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
			bool flag = false;
			if(ChessX-GridX==-1 && ChessY-GridY==-2) flag = HasChessItemOnPoint(GridX,GridY-1);
			else if(ChessX-GridX==1 && ChessY-GridY==-2) flag = HasChessItemOnPoint(GridX,GridY-1);
			else if(ChessX-GridX==-2 && ChessY-GridY==-1) flag = HasChessItemOnPoint(GridX-1,GridY);
			else if(ChessX-GridX==-2 && ChessY-GridY==1) flag = HasChessItemOnPoint(GridX-1,GridY);
			else if(ChessX-GridX==2 && ChessY-GridY==1) flag = HasChessItemOnPoint(GridX+1,GridY);
			else if(ChessX-GridX==2 && ChessY-GridY==1) flag = HasChessItemOnPoint(GridX+1,GridY);
			else if(ChessX-GridX==-1 && ChessY-GridY==2) flag = HasChessItemOnPoint(GridX,GridY+1);
			else if(ChessX-GridX==1 && ChessY-GridY==2) flag = HasChessItemOnPoint(GridX,GridY+1);

			if(flag) return false;

			return base.LimitPoint (ChessX, ChessY);
		}


		public override bool MoveItem(int ChessX, int ChessY)
		{
			if(!LimitPoint( ChessX ,ChessY)) return false;
			if( (GetInt32(ChessX-GridX)==1 &&(GetInt32(ChessY-GridY) == StepY))||
				((GetInt32(ChessX-GridX)==StepX) &&GetInt32(ChessY-GridY)==1))
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
