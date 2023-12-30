using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace CoCaNgua.TheHien
{
	public class TheHienQuanCo : System.Windows.Forms.UserControl
	{
		#region Variables
		public System.Windows.Forms.PictureBox picQC;
		private Point vtTheHien;
		private String strFileName;
		private bool StateClick;
		public DuLieu.DuLieuBanCo dlbc;
		public DuLieu.DuLieuUser User;//moi
		public DuLieu.DuLieuQuanCo dlqc;
		//public XuLy.BanCo BC;
		private System.ComponentModel.Container components = null;
		#endregion
		#region Contractors
		public TheHienQuanCo()
		{
			InitializeComponent();
            TrangThaiClick=false;
		}
		public TheHienQuanCo(Point p,int Mau)
		{
			InitializeComponent();
			LayHinhQuanCo(Mau);;
			this.picQC.Location=new Point (p.X,p.Y);
			try
			{
				this.picQC.Image=new System.Drawing.Bitmap(Application.StartupPath+"/hinhngua/"+strFileName+".gif");
			}
			catch
			{
				MessageBox.Show("File Image khong tim thay");
			}
			TrangThaiClick=false;
		}
#endregion
		#region Dispose
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
		#endregion
		#region Component Designer generated code
		
		private void InitializeComponent()
		{
			this.picQC = new System.Windows.Forms.PictureBox();
			// 
			// picQC
			// 
			this.picQC.BackColor = System.Drawing.Color.Transparent;
			this.picQC.Location = new System.Drawing.Point(8, 8);
			this.picQC.Name = "picQC";
			this.picQC.Size = new System.Drawing.Size(24, 24);
			this.picQC.TabIndex = 0;
			this.picQC.TabStop = false;
			this.picQC.Click += new System.EventHandler(this.picQC_Click);
			// 
			// TheHienQuanCo
			// 
			this.Name = "TheHienQuanCo";
			this.Size = new System.Drawing.Size(72, 72);

		}
		#endregion
		#region Click
		public void picQC_Click(object sender, System.EventArgs e)
		{
			if(TrangThaiClick==true)
			{
				
				
				if( ThucHienNuocDi()==1)
				{
						TrangThaiClick=false;
					for(int i=0;i<User.SoQuanCo;i++)
					{
						XuLy.QuanCo qc=(XuLy.QuanCo)User.arrQC[i];
						if(qc.QCTH.TrangThaiClick==true)
							qc.QCTH.TrangThaiClick=false;
					
					}
				}
				

			}
		}
		#endregion
		#region properties
		public bool TrangThaiClick
		{
			get{ return StateClick;}
			set{ StateClick=value;}
		}
		public Point VitriTheHien
		{
			get{ return vtTheHien;}
			set{vtTheHien=value;}
		}
		
		#endregion
		#region Function
		public String LayHinhQuanCo(int m)
		{
			switch(m)
			{
				case 1:strFileName="Duong.gif";break;
				case 2:strFileName="Do.gif";break;
				case 3:strFileName="Vang.gif";break;
				case 4:strFileName="Xanh.gif";break;
			}
			return strFileName;
		}
		public void HienThi(int m)
		{
			LayHinhQuanCo(m);
			picQC.Image=new System.Drawing.Bitmap(Application.StartupPath+"/HinhNgua/"+strFileName);
		}
		public void LoadImageQuanCo(System.Drawing.Bitmap bmp)
		{
			this.picQC.Image=bmp;
		}
		
		#endregion
		public int ThucHienNuocDi()
		{
			if(dlqc.ViTriTrenBanCo==-1)
			{
				if(this.KiemTraRaQuan()==true)
				
					if( dlbc.arrBC[dlqc.ViTriRaQuan]!=dlqc.MauCo)
					{
						if(dlbc.arrBC[dlqc.ViTriRaQuan]!=0)
							DaQuan(dlqc.ViTriRaQuan);
						dlqc.ViTriTrenBanCo=dlqc.ViTriRaQuan;
						dlbc.arrBC[dlqc.ViTriTrenBanCo]=dlqc.MauCo;
						dlqc.Count++;
						XuLy.BanCo bc=new CoCaNgua.XuLy.BanCo();
						Point p=bc.LayVT(dlqc.ViTriTrenBanCo);
						this.picQC.Location=new Point(p.X,p.Y);
						
						return 1;
					}

			}
			else
			{
				int gt=dlbc.LayGiaTriXN();
				
				if(dlqc.ViTriTrenBanCo==dlqc.ViTriVeDich)
				{ 
					if(KiemTraVeDich()==true && dlqc.Bac==0)
					{
						int n=LaySoQuanVeDich();
						DuLieu.DuLieuUser User=(DuLieu.DuLieuUser) dlbc.arrUsers[dlqc.MauCo-1];
						Point p=(Point)User.arrVtDich[5-n];
						this.picQC.Location=new Point(p.X,p.Y);
						dlbc.arrBC[dlqc.ViTriTrenBanCo]=0;
						User.SoQuanVeDich++;
						dlqc.Bac=5-n;
						return 1;
					}
					else return 0;
				}
				else
					if(dlqc.Count+gt>dlbc.SoOBc) return 0;
				if(this.KiemTraDiDuoc(gt,dlqc.ViTriTrenBanCo)==true)
				
					if ( dlbc.arrBC[(dlqc.ViTriTrenBanCo+gt)%56]!=dlqc.MauCo)
					{
						if(dlbc.arrBC[(dlqc.ViTriTrenBanCo+gt)%56]!=0)
							DaQuan((dlqc.ViTriTrenBanCo+gt)%56);
						dlbc.arrBC[dlqc.ViTriTrenBanCo]=0;
						dlqc.ViTriTrenBanCo+=gt;
						dlqc.ViTriTrenBanCo%=56;
						dlbc.arrBC[dlqc.ViTriTrenBanCo]=dlqc.MauCo;
						dlqc.Count+=dlbc.LayGiaTriXN();
						XuLy.BanCo bc=new CoCaNgua.XuLy.BanCo();
						Point p=bc.LayVT(dlqc.ViTriTrenBanCo);
						this.picQC.Location=new Point(p.X,p.Y);
						return 1;
					}
				
			}
			return 0;
		}
		//kiem tra raquan
		public bool KiemTraRaQuan()
		{
			if(dlbc.SoXN==1)
			{	
				if(dlbc.gtXN1==dlbc.gtRQ1||dlbc.gtXN1==dlbc.gtRQ2)
					return true;
			}
			else
			{
				if( (dlbc.gtXN1==dlbc.gtRQ1&&dlbc.gtXN2==dlbc.gtRQ1)||(dlbc.gtXN1==dlbc.gtRQ2&&dlbc.gtXN2==dlbc.gtRQ2))
					return true;
			}
			return false;
		}
		//Kiem tra ve dich
		public bool KiemTraVeDich()
		{
			if(dlbc.SoXN==1)
			{	
				if(dlbc.gtXN1==dlbc.gtVD1||dlbc.gtXN1==dlbc.gtVD2)
					return true;
			}
			else
			{
				if( (dlbc.gtXN1==dlbc.gtVD1&&dlbc.gtXN2==dlbc.gtVD1)||(dlbc.gtXN1==dlbc.gtVD2&&dlbc.gtXN2==dlbc.gtVD2))
					return true;
			}
			return false;
		}
		//Da Quan
		public void DaQuan(int vtTrenBC)
		{
			int QuanMau=dlbc.arrBC[vtTrenBC];
			DuLieu.DuLieuUser User=(DuLieu.DuLieuUser) dlbc.arrUsers[QuanMau-1];
			for(int i=0;i<User.SoQuanCo;i++)
			{
				XuLy.QuanCo qc=(XuLy.QuanCo)User.arrQC[i];
				if(qc.QCDL.ViTriTrenBanCo==vtTrenBC)
				{
					qc.QCTH.picQC.Location=new Point(qc.QCDL.ViTriTrongChuong.X,qc.QCDL.ViTriTrongChuong.Y);
					qc.QCDL.ViTriTrenBanCo=-1;
					return;
				}
			}
		}
		// kiem tra co di duoc
		public bool KiemTraDiDuoc(int gtXN,int vtBC)
		{
			//int n=qc.QCDL.ViTriTrenBanCo+gtXN;
			for(int i=1;i<gtXN;i++)
				if(dlbc.arrBC[(vtBC+i)%56]!=0)
					return false;//khong di duoc
			return true;
		}
		public int LaySoQuanVeDich()
		{
			DuLieu.DuLieuUser User=(DuLieu.DuLieuUser) this.dlbc.arrUsers[dlqc.MauCo-1];
			return User.SoQuanVeDich;
			
		}
	}
}
