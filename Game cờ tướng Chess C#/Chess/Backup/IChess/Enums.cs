using System;

namespace IChess
{
	/// <summary>
	/// Enums ��ժҪ˵����
	/// </summary>
	public class Enums
	{
		public Enums()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}

		/// <summary>
		/// ö���������췽
		/// </summary>
		public enum ChessType
		{
			blue,
			red
		}

		/// <summary>
		/// ��ȡ��һ��
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
