using System;
using System.Drawing;
using System.Windows.Forms;
namespace ChessItem
{
	/// <summary>
	/// ChessItemShuai ��ժҪ˵����
	/// </summary>
	public class ChessItemShuai : ChessItemBase
	{
		public ChessItemShuai()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}

		/// <summary>
		/// ʤ���¼���ί��
		/// </summary>
		public delegate void WinEventHandle(IChess.Enums.ChessType winer);
		/// <summary>
		/// ʤ���¼�
		/// </summary>
		public event WinEventHandle WinEvent;
		/// <summary>
		/// �¼������������
		/// </summary>
		/// <param name="winer">ʤ����</param>
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
		/// ˧��ɾ���������������ʤ���¼�
		/// </summary>
		public override void Remove()
		{
			base.Remove ();
			IChess.Enums.ChessType winer;
			if(type == IChess.Enums.ChessType.blue)
			{
				winer = IChess.Enums.ChessType.red;
				MessageBox.Show("��������");
			}
			else
			{
				winer = IChess.Enums.ChessType.blue;
				MessageBox.Show("�췽����");
			}

			OnWin( winer );
		}

	}
}
