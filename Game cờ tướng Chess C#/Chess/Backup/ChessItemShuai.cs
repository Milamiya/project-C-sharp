using System;
using System.Drawing;
using System.Windows.Forms;
namespace ChessItem
{
	/// <summary>
	/// ChessItemShuai 的摘要说明。
	/// </summary>
	public class ChessItemShuai : ChessItemBase
	{
		public ChessItemShuai()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		/// <summary>
		/// 胜利事件的委托
		/// </summary>
		public delegate void WinEventHandle(IChess.Enums.ChessType winer);
		/// <summary>
		/// 胜利事件
		/// </summary>
		public event WinEventHandle WinEvent;
		/// <summary>
		/// 事件激活的主函数
		/// </summary>
		/// <param name="winer">胜利方</param>
		private void OnWin(IChess.Enums.ChessType winer)
		{
			if(WinEvent!=null)
				WinEvent( winer );
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

			if( ((ChessX==GridX) &&(GetInt32(ChessY-GridY) == StepY))||
				((GetInt32(ChessX-GridX)==StepX) &&(ChessY==GridY)))
			{
				this.Location = new Point(ChessX*50,ChessY*50);
				GridX = ChessX;
				GridY = ChessY;
				return true;
			}

			return false;
		}

		/// <summary>
		/// 帅被删除，即输掉，激活胜利事件
		/// </summary>
		public override void Remove()
		{
			base.Remove ();
			IChess.Enums.ChessType winer;
			if(type == IChess.Enums.ChessType.blue)
			{
				winer = IChess.Enums.ChessType.red;
				MessageBox.Show("蓝方输了");
			}
			else
			{
				winer = IChess.Enums.ChessType.blue;
				MessageBox.Show("红方输了");
			}

			OnWin( winer );
		}

	}
}
