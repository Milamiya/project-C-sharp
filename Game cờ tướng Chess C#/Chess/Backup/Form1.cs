

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using ChessItem;
using IChess;

namespace Chess
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem mi1;
		private System.Windows.Forms.MenuItem miStart;
		private System.Windows.Forms.MenuItem miOut;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.Label lTurns;
		private System.Windows.Forms.Label lBlueWin;
		private System.Windows.Forms.Label lRedWin;
		
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.mi1 = new System.Windows.Forms.MenuItem();
			this.miStart = new System.Windows.Forms.MenuItem();
			this.miOut = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mi1,
																					  this.menuItem4});
			// 
			// mi1
			// 
			this.mi1.Index = 0;
			this.mi1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				this.miStart,
																				this.miOut});
			this.mi1.Text = "��Ϸ";
			// 
			// miStart
			// 
			this.miStart.Index = 0;
			this.miStart.Text = "��ʼ";
			// 
			// miOut
			// 
			this.miOut.Index = 1;
			this.miOut.Text = "�˳�";
			this.miOut.Click += new System.EventHandler(this.miOut_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.Text = "����";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(542, 496);
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "�й������ѧ����";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.Load += new System.EventHandler(this.Form1_Load);

		}
		#endregion

		#region override
		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		/// <summary>
		/// ��������
		/// </summary>
		/// <param name="e"></param>
		protected override void OnPaint(PaintEventArgs e)
		{
			Pen pen = new Pen(Color.Black,1);
			for(int i=0;i<10;i++)
			{
				e.Graphics.DrawLine(pen,new Point(25,25+(i*50)),new Point(425,25+(i*50)));
			}
			for(int i=0;i<9;i++)
			{
				e.Graphics.DrawLine(pen,new Point(25+(i*50),25),new Point(25+(i*50),225));
				e.Graphics.DrawLine(pen,new Point(25+(i*50),275),new Point(25+(i*50),475));
			}

			Brush brush = pen.Brush;
			e.Graphics.DrawString("����",new Font("����",30),brush,50,230);
			e.Graphics.DrawString("����",new Font("����",30),brush,275,230);

			e.Graphics.DrawLine(pen,new Point(175,25),new Point(275,125));
			e.Graphics.DrawLine(pen,new Point(275,25),new Point(175,125));
			e.Graphics.DrawLine(pen,new Point(175,375),new Point(275,475));
			e.Graphics.DrawLine(pen,new Point(175,475),new Point(275,375));

		}
		#endregion

		#region ��ʼ������
		private void InitChess()
		{
			this.Controls.Clear();	

			lTurns = new System.Windows.Forms.Label();
			lTurns.Location = new System.Drawing.Point(464, 48);
			lTurns.Name = "lTurns";
			ChangeFlag( Flag.Turns);
			this.Controls.Add(this.lTurns);

			lRedWin = new System.Windows.Forms.Label();
			lRedWin.Location = new System.Drawing.Point(464, 100);
			lRedWin.Name = "lRedWin";
			lRedWin.Text = String.Format(DocString.RedWinCountString, Flag.RedWinCount.ToString());
			this.Controls.Add(this.lRedWin);

			lBlueWin = new System.Windows.Forms.Label();
			lBlueWin.Location = new System.Drawing.Point(464, 150);
			lBlueWin.Name = "lBlueWin";
			lBlueWin.Text = String.Format(DocString.BlueWinCountString, Flag.BlueWinCount.ToString());
			this.Controls.Add(this.lBlueWin);


			InitBlueChess();
			InitRedChess();
		}

		public void InitBlueChess()
		{
			
	
//			PictureBox pb = new PictureBox();
//			pb.Location = new Point(100,114);
//			pb.Image = bmp;
//			this.Controls.Add(pb);


			ChessItemBing cib;
			cib = new ChessItemBing();
			cib.type = IChess.Enums.ChessType.blue;
			cib.Width = 50;
			cib.Height = 50;
			cib.Text = "��";
			cib.GridX = 0;
			cib.GridY = 3;
			cib.InitItem();
//			cib.BackgroundImage = bmp;
			cib.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cib);

			cib = new ChessItemBing();
			cib.type = IChess.Enums.ChessType.blue;
			cib.Width = 50;
			cib.Height = 50;
			cib.Text = "��";
			cib.GridX = 2;
			cib.GridY = 3;
			cib.InitItem();
			cib.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cib);

			cib = new ChessItemBing();
			cib.type = IChess.Enums.ChessType.blue;
			cib.Width = 50;
			cib.Height = 50;
			cib.Text = "��";
			cib.GridX = 4;
			cib.GridY = 3;
			cib.InitItem();
			cib.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cib);

			cib = new ChessItemBing();
			cib.type = IChess.Enums.ChessType.blue;
			cib.Width = 50;
			cib.Height = 50;
			cib.Text = "��";
			cib.GridX = 6;
			cib.GridY = 3;
			cib.InitItem();
			cib.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cib);

			cib = new ChessItemBing();
			cib.type = IChess.Enums.ChessType.blue;
			cib.Width = 50;
			cib.Height = 50;
			cib.Text = "��";
			cib.GridX = 8;
			cib.GridY = 3;
			cib.InitItem();
			cib.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cib);

			ChessItemJu cij;
			cij = new ChessItemJu();
			cij.type = IChess.Enums.ChessType.blue;
			cij.Width = 50;
			cij.Height = 50;
			cij.Text = "��";
			cij.GridX = 0;
			cij.GridY = 0;
			cij.InitItem();
			cij.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cij);

			cij = new ChessItemJu();
			cij.type = IChess.Enums.ChessType.blue;
			cij.Width = 50;
			cij.Height = 50;
			cij.Text = "��";
			cij.GridX = 8;
			cij.GridY = 0;
			cij.InitItem();
			cij.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cij);

			ChessItemXiang cix;
			cix = new ChessItemXiang();
			cix.type = IChess.Enums.ChessType.blue;
			cix.Width = 50;
			cix.Height = 50;
			cix.Text = "��";
			cix.GridX = 2;
			cix.GridY = 0;
			cix.InitItem();
			cix.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cix);

			cix = new ChessItemXiang();
			cix.type = IChess.Enums.ChessType.blue;
			cix.Width = 50;
			cix.Height = 50;
			cix.Text = "��";
			cix.GridX = 6;
			cix.GridY = 0;
			cix.InitItem();
			cix.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cix);

			ChessItemPao cip;
			cip = new ChessItemPao();
			cip.type = IChess.Enums.ChessType.blue;
			cip.Width = 50;
			cip.Height = 50;
			cip.Text = "��";
			cip.GridX = 1;
			cip.GridY = 2;
			cip.InitItem();
			cip.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cip);

			cip = new ChessItemPao();
			cip.type = IChess.Enums.ChessType.blue;
			cip.Width = 50;
			cip.Height = 50;
			cip.Text = "��";
			cip.GridX = 7;
			cip.GridY = 2;
			cip.InitItem();
			cip.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cip);

			ChessItemMa cim;
			cim = new ChessItemMa();
			cim.type = IChess.Enums.ChessType.blue;
			cim.Width = 50;
			cim.Height = 50;
			cim.Text = "��";
			cim.GridX = 1;
			cim.GridY = 0;
			cim.InitItem();
			cim.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cim);

			cim = new ChessItemMa();
			cim.type = IChess.Enums.ChessType.blue;
			cim.Width = 50;
			cim.Height = 50;
			cim.Text = "��";
			cim.GridX = 7;
			cim.GridY = 0;
			cim.InitItem();
			cim.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cim);

			ChessItemShi cishi;
			cishi = new ChessItemShi();
			cishi.type = IChess.Enums.ChessType.blue;
			cishi.Width = 50;
			cishi.Height = 50;
			cishi.Text = "ʿ";
			cishi.GridX = 3;
			cishi.GridY = 0;
			cishi.InitItem();
			cishi.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cishi);

			cishi = new ChessItemShi();
			cishi.type = IChess.Enums.ChessType.blue;
			cishi.Width = 50;
			cishi.Height = 50;
			cishi.Text = "ʿ";
			cishi.GridX = 5;
			cishi.GridY = 0;
			cishi.InitItem();
			cishi.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cishi);

			ChessItemShuai cishuai;
			cishuai = new ChessItemShuai();
			cishuai.type = IChess.Enums.ChessType.blue;
			cishuai.Width = 50;
			cishuai.Height = 50;
			cishuai.Text = "��";
			cishuai.GridX = 4;
			cishuai.GridY = 0;
			cishuai.InitItem();
			cishuai.Click+=new EventHandler(cib_Click);
			cishuai.WinEvent+=new ChessItem.ChessItemShuai.WinEventHandle(cishuai_WinEvent);
			this.Controls.Add(cishuai);
		}


		public void InitRedChess()
		{
			ChessItemBing cib;
			cib = new ChessItemBing();
			cib.type = IChess.Enums.ChessType.red;
			cib.Width = 50;
			cib.Height = 50;
			cib.Text = "��";
			cib.GridX = 0;
			cib.GridY = 6;
			cib.InitItem();
			cib.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cib);

			cib = new ChessItemBing();
			cib.type = IChess.Enums.ChessType.red;
			cib.Width = 50;
			cib.Height = 50;
			cib.Text = "��";
			cib.GridX = 2;
			cib.GridY = 6;
			cib.InitItem();
			cib.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cib);

			cib = new ChessItemBing();
			cib.type = IChess.Enums.ChessType.red;
			cib.Width = 50;
			cib.Height = 50;
			cib.Text = "��";
			cib.GridX = 4;
			cib.GridY = 6;
			cib.InitItem();
			cib.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cib);

			cib = new ChessItemBing();
			cib.type = IChess.Enums.ChessType.red;
			cib.Width = 50;
			cib.Height = 50;
			cib.Text = "��";
			cib.GridX = 6;
			cib.GridY = 6;
			cib.InitItem();
			cib.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cib);

			cib = new ChessItemBing();
			cib.type = IChess.Enums.ChessType.red;
			cib.Width = 50;
			cib.Height = 50;
			cib.Text = "��";
			cib.GridX = 8;
			cib.GridY = 6;
			cib.InitItem();
			cib.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cib);

			ChessItemJu cij;
			cij = new ChessItemJu();
			cij.type = IChess.Enums.ChessType.red;
			cij.Width = 50;
			cij.Height = 50;
			cij.Text = "��";
			cij.GridX = 0;
			cij.GridY = 9;
			cij.InitItem();
			cij.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cij);

			cij = new ChessItemJu();
			cij.type = IChess.Enums.ChessType.red;
			cij.Width = 50;
			cij.Height = 50;
			cij.Text = "��";
			cij.GridX = 8;
			cij.GridY = 9;
			cij.InitItem();
			cij.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cij);

			ChessItemXiang cix;
			cix = new ChessItemXiang();
			cix.type = IChess.Enums.ChessType.red;
			cix.Width = 50;
			cix.Height = 50;
			cix.Text = "��";
			cix.GridX = 2;
			cix.GridY = 9;
			cix.InitItem();
			cix.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cix);

			cix = new ChessItemXiang();
			cix.type = IChess.Enums.ChessType.red;
			cix.Width = 50;
			cix.Height = 50;
			cix.Text = "��";
			cix.GridX = 6;
			cix.GridY = 9;
			cix.InitItem();
			cix.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cix);

			ChessItemPao cip;
			cip = new ChessItemPao();
			cip.type = IChess.Enums.ChessType.red;
			cip.Width = 50;
			cip.Height = 50;
			cip.Text = "��";
			cip.GridX = 1;
			cip.GridY = 7;
			cip.InitItem();
			cip.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cip);

			cip = new ChessItemPao();
			cip.type = IChess.Enums.ChessType.red;
			cip.Width = 50;
			cip.Height = 50;
			cip.Text = "��";
			cip.GridX = 7;
			cip.GridY = 7;
			cip.InitItem();
			cip.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cip);

			ChessItemMa cim;
			cim = new ChessItemMa();
			cim.type = IChess.Enums.ChessType.red;
			cim.Width = 50;
			cim.Height = 50;
			cim.Text = "��";
			cim.GridX = 1;
			cim.GridY = 9;
			cim.InitItem();
			cim.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cim);

			cim = new ChessItemMa();
			cim.type = IChess.Enums.ChessType.red;
			cim.Width = 50;
			cim.Height = 50;
			cim.Text = "��";
			cim.GridX = 7;
			cim.GridY = 9;
			cim.InitItem();
			cim.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cim);

			ChessItemShi cishi;
			cishi = new ChessItemShi();
			cishi.type = IChess.Enums.ChessType.red;
			cishi.Width = 50;
			cishi.Height = 50;
			cishi.Text = "ʿ";
			cishi.GridX = 3;
			cishi.GridY = 9;
			cishi.InitItem();
			cishi.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cishi);

			cishi = new ChessItemShi();
			cishi.type = IChess.Enums.ChessType.red;
			cishi.Width = 50;
			cishi.Height = 50;
			cishi.Text = "ʿ";
			cishi.GridX = 5;
			cishi.GridY = 9;
			cishi.InitItem();
			cishi.Click+=new EventHandler(cib_Click);
			this.Controls.Add(cishi);

			ChessItemShuai cishuai;
			cishuai = new ChessItemShuai();
			cishuai.type = IChess.Enums.ChessType.red;
			cishuai.Width = 50;
			cishuai.Height = 50;
			cishuai.Text = "˧";
			cishuai.GridX = 4;
			cishuai.GridY = 9;
			cishuai.InitItem();
			cishuai.Click+=new EventHandler(cib_Click);
			cishuai.WinEvent+=new ChessItem.ChessItemShuai.WinEventHandle(cishuai_WinEvent);
			this.Controls.Add(cishuai);
			
		}


		#endregion

		#region private Method
		/// <summary>
		/// ��ȡ��ѡ�ֵ�����
		/// </summary>
		/// <returns></returns>
		private IChessItem GetCheckedChild()
		{
			for(int i=0;i<this.Controls.Count;i++)
			{
				if(this.Controls[i] is IChessItem)
				{
					IChessItem ic = (IChessItem)this.Controls[i];
					if(ic.IsChecked) 
						return ic;
				}
			}

			return null;
		}

		/// <summary>
		/// ��ȡָ������ѡ�ֵ�����
		/// </summary>
		/// <param name="type">�������Ǻ췽</param>
		/// <returns>ѡ�ֵ�����</returns>
		private IChessItem GetCheckedChild(Enums.ChessType type)
		{
			for(int i=0;i<this.Controls.Count;i++)
			{
				if(this.Controls[i] is IChessItem)
				{
					IChessItem ic = (IChessItem)this.Controls[i];
					if(ic.type == type && ic.IsChecked) 
						return ic;
				}
			}

			return null;
		}

		/// <summary>
		/// �������ѡ��
		/// </summary>
		private void UncheckChild()
		{
			for(int i=0;i<this.Controls.Count;i++)
			{
				if(this.Controls[i] is IChessItem)
				{
					IChessItem ic = (IChessItem)this.Controls[i];
					if(ic.IsChecked) 
						ic.IsChecked = false;
				}
			}

		}

		/// <summary>
		/// ��ʵ�������ת��Ϊ������������
		/// </summary>
		/// <param name="point">ʵ�������</param>
		/// <returns>������������</returns>
		private int GetGird(int point)
		{	
			return  point/50;
		}

		/// <summary>
		/// ת�������״�
		/// </summary>
		/// <param name="type">��һ�ֲ�����</param>
		public void ChangeFlag(Enums.ChessType type)
		{
			if(type == Enums.ChessType.red)
			{
				Flag.Turns = Enums.ChessType.blue;
				lTurns.Text = String.Format(DocString.TurnsString, "����");
			}
			else
			{
				Flag.Turns = Enums.ChessType.red;
				lTurns.Text = String.Format(DocString.TurnsString,"�췽");
			}

		}

		#endregion 

		#region event
		private void Form1_Load(object sender, System.EventArgs e)
		{
			InitChess();
		}

		private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			IChessItem ic = GetCheckedChild();
			
			if(ic!=null)
			{
				if(ic.type!=Flag.Turns) return;

				int gridX = GetGird(e.X);
				int gridY = GetGird(e.Y);

				if( ic.MoveItem(gridX,gridY))
				{
					ChangeFlag(ic.type);
					ic.IsChecked = false;
				}
			}
		}

		private void cib_Click(object sender, EventArgs e)
		{

			IChessItem ic = (IChessItem)sender;
			IChessItem icold = GetCheckedChild(Enums.GetOtherType(ic.type));

			bool ischeck = true;
			if(icold!=null ) 
			{
				if(icold.type!=Flag.Turns) 
				{
					ic.IsChecked = false;
					return;
				}

				if( icold.MoveItem(ic.GridX,ic.GridY))
				{
					ChangeFlag(icold.type);
					ic.Remove();
					icold.IsChecked = false;
					ischeck = false;
				}
				
			}

			UncheckChild();
			if(ischeck && ic.type == Flag.Turns)ic.IsChecked = true;
			

		}

		private void miOut_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		/// <summary>
		/// ˧���Ƴ������ʤ������
		/// </summary>
		/// <param name="winer"></param>
		private void cishuai_WinEvent(IChess.Enums.ChessType winer)
		{
			if(winer == Enums.ChessType.blue) Flag.BlueWinCount++;
			else Flag.RedWinCount++;

			InitChess();
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Copyright Keith Dan 2006");
		}

		#endregion

		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
	}
}
