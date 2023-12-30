using System;

namespace IChess
{
	/// <summary>
	/// IChessItem ���������������ӵĽӿ�
	/// </summary>
	public interface IChessItem
	{
		/// <summary>
		/// Ϊ�������Ǻ췽
		/// </summary>
		Enums.ChessType type{get;set;}
		/// <summary>
		/// �Ƿ񱻰���
		/// </summary>
		bool IsChecked{get;set;}
		/// <summary>
		/// �ƶ��Ĳ���X
		/// </summary>
		int StepX{get;}
		/// <summary>
		/// �ƶ��Ĳ���Y
		/// </summary>
		int StepY{get;}
		/// <summary>
		/// �����������е�X����
		/// </summary>
		int GridX{get;set;}
		/// <summary>
		/// �����������е�Y����
		/// </summary>
		int GridY{get;set;}
		/// <summary>
		/// �ƶ�����
		/// </summary>
		/// <param name="ChessX">��Ҫ�ƶ�������X����</param>
		/// <param name="ChessY">��Ҫ�ƶ�������Y����</param>
		/// <returns>�Ƿ�ɹ��ƶ�</returns>
		bool MoveItem(int ChessX,int ChessY);
		/// <summary>
		/// ��ʼ������
		/// </summary>
		void InitItem();
		/// <summary>
		/// �Ƴ����ӣ���Ϊ���������ӳԵ�
		/// </summary>
		void Remove();
	}
}
