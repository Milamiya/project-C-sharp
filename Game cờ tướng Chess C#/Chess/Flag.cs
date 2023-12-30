using System;
using IChess;
namespace Chess
{
	/// <summary>
	/// Flag µÄÕªÒªËµÃ÷¡£
	/// </summary>
	public class Flag
	{
		public Flag()
		{
			//
            // TODO: //Download source code tại Sharecode.vn
			//
		}

		private static Enums.ChessType _turns;
		/// <summary>
		/// ²Ù×÷Æå×ÓµÄÂ×´Î
		/// </summary>
		public static Enums.ChessType Turns
		{
			get{return _turns;}
			set{_turns=value;}
		}

		private static int _redWinCount;
		/// <summary>
        /// //Download source code tại Sharecode.vn
		/// </summary>
		public static int RedWinCount
		{
			get{return _redWinCount;}
			set{_redWinCount=value;}
		}

		private static int _blueWinCount;
		/// <summary>
		/// À¶·½Ê¤Àû´ÎÊý
		/// </summary>
		public static int BlueWinCount
		{
			get{return _blueWinCount;}
			set{_blueWinCount=value;}
		}
	}
}
