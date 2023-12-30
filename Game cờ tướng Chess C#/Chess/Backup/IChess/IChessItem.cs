using System;

namespace IChess
{
	/// <summary>
	/// IChessItem 用来定义象棋棋子的接口
	/// </summary>
	public interface IChessItem
	{
		/// <summary>
		/// 为蓝方还是红方
		/// </summary>
		Enums.ChessType type{get;set;}
		/// <summary>
		/// 是否被按下
		/// </summary>
		bool IsChecked{get;set;}
		/// <summary>
		/// 移动的步长X
		/// </summary>
		int StepX{get;}
		/// <summary>
		/// 移动的步长Y
		/// </summary>
		int StepY{get;}
		/// <summary>
		/// 在棋盘网格中的X坐标
		/// </summary>
		int GridX{get;set;}
		/// <summary>
		/// 在棋盘网格中的Y坐标
		/// </summary>
		int GridY{get;set;}
		/// <summary>
		/// 移动棋子
		/// </summary>
		/// <param name="ChessX">将要移动的网格X坐标</param>
		/// <param name="ChessY">将要移动的网格Y坐标</param>
		/// <returns>是否成功移动</returns>
		bool MoveItem(int ChessX,int ChessY);
		/// <summary>
		/// 初始化棋子
		/// </summary>
		void InitItem();
		/// <summary>
		/// 移除棋子，作为被其他棋子吃掉
		/// </summary>
		void Remove();
	}
}
