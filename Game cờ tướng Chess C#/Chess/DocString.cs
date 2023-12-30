using System;

namespace Chess
{
	/// <summary>
	/// DocString µÄÕªÒªËµÃ÷¡£
	/// </summary>
	public class DocString
	{
		public DocString()
		{
			//
			// TODO: ÔÚ´Ë´¦Ìí¼Ó¹¹Ôìº¯ÊýÂß¼­
			//
		}

		public static string RedWinCountString
		{
			get
			{
				return "Màu đỏ đi {0} lượt";
			}
		}

		public static string BlueWinCountString
		{
			get
			{
                return "Màu xanh đi {0} lượt";
			}
		}

		public static string TurnsString
		{
			get
			{
				return "Đến lượt {0}";
			}
		}
	}
}
