using System;
using System.Drawing;

namespace ChessItem
{
	/// <summary>
	/// ChessItemJu ��ժҪ˵����
	/// </summary>
	public class ChessItemJu : ChessItemBase
	{
		public ChessItemJu()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}

		public override int StepX
		{
			get
			{
				return 9;
			}

		}

		public override int StepY
		{
			get
			{
				return 9;
			}

		}

		public override bool MoveItem(int ChessX, int ChessY)
		{
			if(!LimitPoint( ChessX ,ChessY)) return false;
			if( ((ChessX==GridX) &&(GetInt32(ChessY-GridY) <= StepY))||
				((GetInt32(ChessX-GridX)<=StepX) &&(ChessY==GridY)))
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
