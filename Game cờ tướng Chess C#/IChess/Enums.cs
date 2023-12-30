using System;

namespace IChess
{
	/// <summary>
	/// Enums 的摘要说明。
	/// </summary>
	public class Enums
	{
		public Enums()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		/// <summary>
		/// 枚举蓝方，红方
		/// </summary>
		public enum ChessType
		{
			blue,
			red
		}

		/// <summary>
		/// 获取另一方
		/// </summary>
		/// <param name="ct"></param>
		/// <returns></returns>
		public static ChessType GetOtherType(ChessType ct)
		{
			if(ct == ChessType.blue) return ChessType.red;
			return ChessType.blue;
		}
	}
}
