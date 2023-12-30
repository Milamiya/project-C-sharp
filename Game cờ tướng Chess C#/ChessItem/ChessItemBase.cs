using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using IChess;

namespace ChessItem
{
	/// <summary>
	/// ChessItemBase ��ժҪ˵����
	/// </summary>
	public class ChessItemBase : System.Windows.Forms.Label,IChess.IChessItem
	{
		public ChessItemBase()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}

		#region override 
		protected override void OnClick(EventArgs e)
		{
			if(!IsChecked) 
			{
				IsChecked = true;
				this.BorderStyle = BorderStyle.FixedSingle;
			}
			base.OnClick (e);
		}

		public override ContentAlignment TextAlign
		{
			get
			{
				return ContentAlignment.MiddleCenter;
			}
			set
			{
			}
		}

		public override Color BackColor
		{
			get
			{
			//	SetStyle(ControlStyles.SupportsTransparentBackColor,true);  
				return Color.Transparent;
			}
			set
			{}

		}

		public override Font Font
		{
			get
			{
				return new Font("����",20);
			}
			set
			{

			}
		}

		private Image _bmp;
		public override Image BackgroundImage
		{
			get
			{
				if(_bmp==null)
				{
					Bitmap bmp = new Bitmap(50,50);
					Graphics g = Graphics.FromImage( bmp );
					Brush brush = new SolidBrush(Color.Tomato);
					g.FillEllipse(brush,new Rectangle(new Point(0,0),new Size(50,50)));;
					g.Flush();
					g.Dispose();
					_bmp= bmp;
				}
				return _bmp;
			}
			set
			{

			}
		}

	

		#endregion

		/// <summary>
		/// ������ת��Ϊ������
		/// </summary>
		/// <param name="values"></param>
		/// <returns></returns>
		public virtual int GetInt32(int values)
		{
			if(values<0) return 0-values;

			return values;
		}

		/// <summary>
		/// ����������ƶ�
		/// </summary>
		/// <param name="ChessX">������X����</param>
		/// <param name="ChessY">������Y����</param>
		/// <returns></returns>
		public virtual bool LimitPoint(int ChessX,int ChessY)
		{
			Form form = (Form)this.Parent;//��ȡ�˿ؼ��ĸ�ϵ����form
			int count = 0;

			if(GridX == ChessX && GridY > ChessY)
				GetChildOnPoint(form,ChessX,ChessY,GridX,GridY,out count);
			else if(GridX == ChessX && GridY < ChessY)
				GetChildOnPoint(form,GridX,GridY,ChessX,ChessY,out count);
			else if(GridX > ChessX && GridY == ChessY)
				GetChildOnPoint(form,ChessX,ChessY,GridX,GridY,out count);
			else if(GridX < ChessX && GridY == ChessY)
				GetChildOnPoint(form,GridX,GridY,ChessX,ChessY,out count);

			if(count>0) return false;//����������ϻ����������ӣ��������ƶ�

			if(ChessX>Definition.ChessGirdX || ChessX<0) return false;
			if(ChessY>Definition.ChessGirdY || ChessY<0) return false;

			return true;
		}

		/// <summary>
		/// ��ȡ���ڿ�ʼ������֮������ӣ�������ж�������򲻷��أ�����ӿ�ʼ������λ�ù��ж��ٸ�����
		/// </summary>
		/// <param name="form">����</param>
		/// <param name="startX">��ʼX</param>
		/// <param name="startY">��ʼY</param>
		/// <param name="endX">����X</param>
		/// <param name="endY">����Y</param>
		/// <param name="count">�����ڴ��������ж��ٸ�����</param>
		/// <returns></returns>
		protected IChessItem GetChildOnPoint(Form form,int startX,int startY,int endX,int endY,out int count)
		{
			count = 0;
			if((startX != endX) &&(startY!=endY)) return null;
			ArrayList al = new ArrayList();
			for(int i=0;i<form.Controls.Count;i++)
			{
				if(form.Controls[i] is IChessItem)
				{
					IChessItem ic = (IChessItem)form.Controls[i];
					if(startX == endX && startX == ic.GridX)
					{
						if(ic.GridY > startY && ic.GridY<endY) 
							al.Add(ic);
					}
					else if(startY==endY &&startY== ic.GridY)
					{
						if(ic.GridX > startX && ic.GridX<endX) 
							al.Add(ic);
					}
				}
			}
			count = al.Count;

			if(al.Count == 1)return (IChessItem)al[0];

			return null;
		}

		protected bool HasChessItemOnPoint(int ChessX,int ChessY)
		{
			Form form = (Form)this.Parent;
			for(int i=0;i<form.Controls.Count;i++)
			{
				if(form.Controls[i] is IChessItem)
				{
					IChessItem ic = (IChessItem)form.Controls[i];
					if(ic.GridX == ChessX && ic.GridY == ChessY) return true;

				}
			}

			return false;
		}

		#region IChessItem ��Աʵ��

		private int _gridX;
		public virtual int GridX
		{
			get
			{
				// TODO:  ��� ChessItemBase.GridX getter ʵ��
				return _gridX;
			}
			set
			{
				// TODO:  ��� ChessItemBase.GridX setter ʵ��
				_gridX = value;
			}
		}

		private int _gridY;
		public virtual int GridY
		{
			get
			{
				// TODO:  ��� ChessItemBase.GridY getter ʵ��
				return _gridY;
			}
			set
			{
				// TODO:  ��� ChessItemBase.GridY setter ʵ��
				_gridY = value;
			}
		}

		public virtual int StepY
		{
			get
			{
				// TODO:  ��� ChessItemBase.StepY getter ʵ��
				return 0;
			}
		}

		public virtual int StepX
		{
			get
			{
				// TODO:  ��� ChessItemBase.StepX getter ʵ��
				return 0;
			}
		}

		private IChess.Enums.ChessType _type;
		public virtual IChess.Enums.ChessType type
		{
			get
			{
				// TODO:  ��� ChessItem.type getter ʵ��
				return _type;
			}
			set
			{
				// TODO:  ��� ChessItem.type setter ʵ��
				_type = value;
				if(_type == IChess.Enums.ChessType.blue) this.ForeColor = Color.Blue;
				else this.ForeColor = Color.Red;
			}
		}

		private bool _isChecked = false;
		public virtual bool IsChecked
		{
			get
			{
				// TODO:  ��� ChessItem.IsChecked getter ʵ��
				return _isChecked;
			}
			set
			{
				// TODO:  ��� ChessItem.IsChecked setter ʵ��
				_isChecked = value;
				if(_isChecked)
					this.BorderStyle = BorderStyle.FixedSingle;
				else
					this.BorderStyle = BorderStyle.None;
			}
		}

		public virtual bool MoveItem(int ChessX, int ChessY)
		{
			// TODO:  ��� ChessItemBase.MoveItem ʵ��
			if(((ChessX-GridX) == StepX) &&((ChessY-GridY) == StepY))
			{
				this.Location = new Point(ChessX*50,ChessY*50);
				GridX = ChessX;
				GridY = ChessY;
				return true;
			}

			return false;
		}

		public virtual void InitItem()
		{
			// TODO:  ��� ChessItemBase.MoveItem ʵ��

			this.Location = new Point(GridX*50,GridY*50);
		
		}

		public virtual void Remove()
		{
			// TODO:  ��� ChessItemBase.MoveItem ʵ��

			this.Dispose();
		
		}

		#endregion
	}
}
