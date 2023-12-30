using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using IChess;

namespace ChessItem
{
	/// <summary>
	/// ChessItemBase 的摘要说明。
	/// </summary>
	public class ChessItemBase : System.Windows.Forms.Label,IChess.IChessItem
	{
		public ChessItemBase()
		{
			//
			// TODO: 在此处添加构造函数逻辑
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
				return new Font("隶书",20);
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
		/// 将负数转换为正整数
		/// </summary>
		/// <param name="values"></param>
		/// <returns></returns>
		public virtual int GetInt32(int values)
		{
			if(values<0) return 0-values;

			return values;
		}

		/// <summary>
		/// 限制坐标点移动
		/// </summary>
		/// <param name="ChessX">棋盘上X坐标</param>
		/// <param name="ChessY">棋盘上Y坐标</param>
		/// <returns></returns>
		public virtual bool LimitPoint(int ChessX,int ChessY)
		{
			Form form = (Form)this.Parent;//获取此控件的父系，即form
			int count = 0;

			if(GridX == ChessX && GridY > ChessY)
				GetChildOnPoint(form,ChessX,ChessY,GridX,GridY,out count);
			else if(GridX == ChessX && GridY < ChessY)
				GetChildOnPoint(form,GridX,GridY,ChessX,ChessY,out count);
			else if(GridX > ChessX && GridY == ChessY)
				GetChildOnPoint(form,ChessX,ChessY,GridX,GridY,out count);
			else if(GridX < ChessX && GridY == ChessY)
				GetChildOnPoint(form,GridX,GridY,ChessX,ChessY,out count);

			if(count>0) return false;//如果此条线上还有其他棋子，将不能移动

			if(ChessX>Definition.ChessGirdX || ChessX<0) return false;
			if(ChessY>Definition.ChessGirdY || ChessY<0) return false;

			return true;
		}

		/// <summary>
		/// 获取处于开始结束点之间的棋子，如果含有多个棋子则不返回，输出从开始到结束位置共有多少个棋子
		/// </summary>
		/// <param name="form">棋盘</param>
		/// <param name="startX">开始X</param>
		/// <param name="startY">开始Y</param>
		/// <param name="endX">结束X</param>
		/// <param name="endY">结束Y</param>
		/// <param name="count">返回在此条线上有多少个棋子</param>
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

		#region IChessItem 成员实现

		private int _gridX;
		public virtual int GridX
		{
			get
			{
				// TODO:  添加 ChessItemBase.GridX getter 实现
				return _gridX;
			}
			set
			{
				// TODO:  添加 ChessItemBase.GridX setter 实现
				_gridX = value;
			}
		}

		private int _gridY;
		public virtual int GridY
		{
			get
			{
				// TODO:  添加 ChessItemBase.GridY getter 实现
				return _gridY;
			}
			set
			{
				// TODO:  添加 ChessItemBase.GridY setter 实现
				_gridY = value;
			}
		}

		public virtual int StepY
		{
			get
			{
				// TODO:  添加 ChessItemBase.StepY getter 实现
				return 0;
			}
		}

		public virtual int StepX
		{
			get
			{
				// TODO:  添加 ChessItemBase.StepX getter 实现
				return 0;
			}
		}

		private IChess.Enums.ChessType _type;
		public virtual IChess.Enums.ChessType type
		{
			get
			{
				// TODO:  添加 ChessItem.type getter 实现
				return _type;
			}
			set
			{
				// TODO:  添加 ChessItem.type setter 实现
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
				// TODO:  添加 ChessItem.IsChecked getter 实现
				return _isChecked;
			}
			set
			{
				// TODO:  添加 ChessItem.IsChecked setter 实现
				_isChecked = value;
				if(_isChecked)
					this.BorderStyle = BorderStyle.FixedSingle;
				else
					this.BorderStyle = BorderStyle.None;
			}
		}

		public virtual bool MoveItem(int ChessX, int ChessY)
		{
			// TODO:  添加 ChessItemBase.MoveItem 实现
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
			// TODO:  添加 ChessItemBase.MoveItem 实现

			this.Location = new Point(GridX*50,GridY*50);
		
		}

		public virtual void Remove()
		{
			// TODO:  添加 ChessItemBase.MoveItem 实现

			this.Dispose();
		
		}

		#endregion
	}
}
