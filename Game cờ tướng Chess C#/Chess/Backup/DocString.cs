using System;

namespace Chess
{
	/// <summary>
	/// DocString 的摘要说明。
	/// </summary>
	public class DocString
	{
		public DocString()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}

		public static string RedWinCountString
		{
			get
			{
				return "红方胜利{0}次";
			}
		}

		public static string BlueWinCountString
		{
			get
			{
				return "蓝方胜利{0}次";
			}
		}

		public static string TurnsString
		{
			get
			{
				return "现在是{0}";
			}
		}
	}
}
