using System;
using IChess;
namespace Chess
{
	/// <summary>
	/// Flag 的摘要说明。
	/// </summary>
	public class Flag
	{
		public Flag()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		private static Enums.ChessType _turns;
		/// <summary>
		/// 操作棋子的伦次
		/// </summary>
		public static Enums.ChessType Turns
		{
			get{return _turns;}
			set{_turns=value;}
		}

		private static int _redWinCount;
		/// <summary>
		/// 红方胜利次数
		/// </summary>
		public static int RedWinCount
		{
			get{return _redWinCount;}
			set{_redWinCount=value;}
		}

		private static int _blueWinCount;
		/// <summary>
		/// 蓝方胜利次数
		/// </summary>
		public static int BlueWinCount
		{
			get{return _blueWinCount;}
			set{_blueWinCount=value;}
		}
	}
}
