using System;
using IChess;
namespace Chess
{
	/// <summary>
	/// Flag ��ժҪ˵����
	/// </summary>
	public class Flag
	{
		public Flag()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}

		private static Enums.ChessType _turns;
		/// <summary>
		/// �������ӵ��״�
		/// </summary>
		public static Enums.ChessType Turns
		{
			get{return _turns;}
			set{_turns=value;}
		}

		private static int _redWinCount;
		/// <summary>
		/// �췽ʤ������
		/// </summary>
		public static int RedWinCount
		{
			get{return _redWinCount;}
			set{_redWinCount=value;}
		}

		private static int _blueWinCount;
		/// <summary>
		/// ����ʤ������
		/// </summary>
		public static int BlueWinCount
		{
			get{return _blueWinCount;}
			set{_blueWinCount=value;}
		}
	}
}
