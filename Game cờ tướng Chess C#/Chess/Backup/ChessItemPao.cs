using System;
using System.Drawing;
using System.Windows.Forms;

using IChess;

namespace ChessItem
{
	/// <summary>
	/// ChessItemPao 的摘要说明。
	/// </summary>
	public class ChessItemPao : ChessItemBase
	{
		public ChessItemPao()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		public override int StepX
		{
			get
			{
				return Definition.ChessGirdX;
			}

		}

		public override int StepY
		{
			get
			{
				return Definition.ChessGirdY;
			}

		}

		public override bool LimitPoint(int ChessX, int ChessY)
		{
			if(ChessX>Definition.ChessGirdX || ChessX<0) return false;
			if(ChessY>Definition.ChessGirdY || ChessY<0) return false;

			return true;
		}


		public override bool MoveItem(int ChessX, int ChessY)
		{
			if(!LimitPoint( ChessX ,ChessY)) return false;

			Form form = (Form)this.Parent;
			int count =0;
			IChessItem ici = null;
			if(GridX == ChessX && GridY > ChessY)
				ici = GetChildOnPoint(form,ChessX,ChessY,GridX,GridY,out count);
			else if(GridX == ChessX && GridY < ChessY)
				ici = GetChildOnPoint(form,GridX,GridY,ChessX,ChessY,out count);
			else if(GridX > ChessX && GridY == ChessY)
				ici = GetChildOnPoint(form,ChessX,ChessY,GridX,GridY,out count);
			else if(GridX < ChessX && GridY == ChessY)
				ici = GetChildOnPoint(form,GridX,GridY,ChessX,ChessY,out count);


			if( ((ChessX==GridX) &&(GetInt32(ChessY-GridY) <= StepY))||
				((GetInt32(ChessX-GridX)<=StepX) &&(ChessY==GridY)))
			{
				if(HasChessItemOnPoint(ChessX,ChessY))
				{
					if(count==1) 
					{
						if(ici!=null)
						{
							return MoveItem(ChessX ,ChessY,ici);
						}
					}
				}
				else
				{
					if(count>0) return false;

					this.Location = new Point(ChessX*50,ChessY*50);
					GridX = ChessX;
					GridY = ChessY;
					return true;
				}
			}

			return false;
		}

		

		public bool MoveItem(int ChessX,int ChessY,IChessItem ic)
		{
			if(!LimitPoint( ChessX ,ChessY)) return false;

			if( ((ChessX==GridX) &&(GetInt32(ChessY-GridY) <= StepY) && ChessX == ic.GridX)||
				((GetInt32(ChessX-GridX)<=StepX) &&(ChessY==GridY) && ChessY == ic.GridY))
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
