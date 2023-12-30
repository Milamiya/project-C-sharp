using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace CoCaNgua.TheHien
{
	#region Class The Hien Xi Ngau
	public class TheHienXiNgau : System.Windows.Forms.UserControl
	{
		#region Required variables
		private System.Windows.Forms.PictureBox picXN1;
		private System.Windows.Forms.PictureBox picXN2;
		private int soXNTH;
		private System.ComponentModel.Container components = null;
		#endregion
		#region Contractors
		public TheHienXiNgau()
		{
			InitializeComponent();
			SoXiNgauTheHien=1;
			LoadImageXN(1,6);
			DinhViXiNgau();
		}
		public TheHienXiNgau(int So)
		{
			InitializeComponent();
			LoadImageXN(1,6);
			SoXiNgauTheHien=So;
			DinhViXiNgau();
		}
		#endregion
		#region Properties
		public int SoXiNgauTheHien
		{
			get{return soXNTH;}
			set{soXNTH=value;}
		}
		#endregion
		#region Fuction
		public void DinhViXiNgau()
		{	
			if(SoXiNgauTheHien==1)
			{
				this.picXN1.Location= new Point(32,8);
				if(picXN2.Visible==true) picXN2.Visible=false;
			}
			else
			{
				this.picXN1.Location= new Point(8,8);
				if(picXN2.Visible==false) picXN2.Visible=true;
			}
		}
		
		public void LoadImageXiNgau1(String strFileName)
		{
			this.picXN1.Image=new System.Drawing.Bitmap(strFileName);
		}
		public void LoadImageXiNgau2(String strFileName)
		{
			this.picXN2.Image=new System.Drawing.Bitmap(strFileName);
		}
		public void LoadImageXN(int gt1,int gt2)
		{
			this.picXN1.Image=new System.Drawing.Bitmap(Application.StartupPath+"/HinhXiNgau/"+gt1+".jpg");
			this.picXN2.Image=new System.Drawing.Bitmap(Application.StartupPath+"/HinhXiNgau/"+gt2+".jpg");
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
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TheHienXiNgau));
			this.picXN1 = new System.Windows.Forms.PictureBox();
			this.picXN2 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// picXN1
			// 
			//this.picXN1.Image = ((System.Drawing.Image)(resources.GetObject("picXN1.Image")));
			this.picXN1.Location = new System.Drawing.Point(8, 8);
			this.picXN1.Name = "picXN1";
			this.picXN1.Size = new System.Drawing.Size(40, 40);
			this.picXN1.TabIndex = 0;
			this.picXN1.TabStop = false;
			// 
			// picXN2
			// 
			//this.picXN2.Image = ((System.Drawing.Image)(resources.GetObject("picXN2.Image")));
			this.picXN2.Location = new System.Drawing.Point(56, 8);
			this.picXN2.Name = "picXN2";
			this.picXN2.Size = new System.Drawing.Size(40, 40);
			this.picXN2.TabIndex = 1;
			this.picXN2.TabStop = false;
			// 
			// TheHienXiNgau
			// 
			this.Controls.Add(this.picXN2);
			this.Controls.Add(this.picXN1);
			this.Name = "TheHienXiNgau";
			this.Size = new System.Drawing.Size(104, 56);
			this.ResumeLayout(false);

		}
		#endregion
	}
	#endregion
}
