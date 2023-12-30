using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CoCaNgua.TheHien
{
	#region Form XuLyChinh
	public class FormXuLyChinh : System.Windows.Forms.Form
	{
		#region	Variables
		private System.Windows.Forms.Panel panelBC;
		private System.Windows.Forms.Button btnDoXiNgau;
		private System.Windows.Forms.Button btnSapBanCo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox picLuotQC;
		private CoCaNgua.TheHien.TheHienXiNgau TheHienXN;
		private XuLy.XiNgau XN= new CoCaNgua.XuLy.XiNgau();
		private System.Windows.Forms.Button btnTuyChon;
		private System.Windows.Forms.Button btnThoat;
		private System.ComponentModel.Container components = null;
		private XuLy.BanCo BC=new CoCaNgua.XuLy.BanCo();
		private TheHien.TuyChon TuyChonThamSo=new CoCaNgua.TheHien.TuyChon();
		private bool bEnter=false;
		#endregion
		#region Contractors
		public FormXuLyChinh()
		{
			InitializeComponent();
			
		}
		#endregion
		#region Dispose
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
		#endregion
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panelBC = new System.Windows.Forms.Panel();
			this.btnDoXiNgau = new System.Windows.Forms.Button();
			this.btnSapBanCo = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.picLuotQC = new System.Windows.Forms.PictureBox();
			this.TheHienXN = new CoCaNgua.TheHien.TheHienXiNgau();
			this.btnTuyChon = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// panelBC
			// 
			this.panelBC.Location = new System.Drawing.Point(4, 4);
			this.panelBC.Name = "panelBC";
			this.panelBC.Size = new System.Drawing.Size(476, 468);
			this.panelBC.TabIndex = 0;
			// 
			// btnDoXiNgau
			// 
			this.btnDoXiNgau.Location = new System.Drawing.Point(496, 88);
			this.btnDoXiNgau.Name = "btnDoXiNgau";
			this.btnDoXiNgau.TabIndex = 1;
			this.btnDoXiNgau.Text = "Do xi ngau";
			this.btnDoXiNgau.Click += new System.EventHandler(this.btnDoXiNgau_Click);
			// 
			// btnSapBanCo
			// 
			this.btnSapBanCo.Location = new System.Drawing.Point(496, 136);
			this.btnSapBanCo.Name = "btnSapBanCo";
			this.btnSapBanCo.TabIndex = 4;
			this.btnSapBanCo.Text = "Sap Ban Co";
			this.btnSapBanCo.Click += new System.EventHandler(this.btnSapBanCo_Click);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(504, 328);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Luot di";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// picLuotQC
			// 
			this.picLuotQC.BackColor = System.Drawing.Color.Transparent;
			this.picLuotQC.Location = new System.Drawing.Point(520, 368);
			this.picLuotQC.Name = "picLuotQC";
			this.picLuotQC.Size = new System.Drawing.Size(24, 24);
			this.picLuotQC.TabIndex = 7;
			this.picLuotQC.TabStop = false;
			// 
			// TheHienXN
			// 
			this.TheHienXN.Location = new System.Drawing.Point(480, 16);
			this.TheHienXN.Name = "TheHienXN";
			this.TheHienXN.Size = new System.Drawing.Size(104, 56);
			this.TheHienXN.SoXiNgauTheHien = 1;
			this.TheHienXN.TabIndex = 8;
			// 
			// btnTuyChon
			// 
			this.btnTuyChon.Location = new System.Drawing.Point(496, 160);
			this.btnTuyChon.Name = "btnTuyChon";
			this.btnTuyChon.TabIndex = 9;
			this.btnTuyChon.Text = "Tuy Chon";
			this.btnTuyChon.Click += new System.EventHandler(this.btnTuyChon_Click);
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(496, 184);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.TabIndex = 10;
			this.btnThoat.Text = "Thoat";
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// FormXuLyChinh
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(592, 478);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnTuyChon);
			this.Controls.Add(this.TheHienXN);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSapBanCo);
			this.Controls.Add(this.btnDoXiNgau);
			this.Controls.Add(this.panelBC);
			this.Controls.Add(this.picLuotQC);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormXuLyChinh";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Co Ca Ngua (Hai Dang - 02HC319)";
			this.Load += new System.EventHandler(this.XuLyChinh_Load);
			this.ResumeLayout(false);

		}
		#endregion
		[STAThread]
		#region Main
		static void Main() 
		{
			Application.Run(new FormXuLyChinh());
			
		}
		#endregion
		#region Function
		private void XuLyChinh_Load(object sender, System.EventArgs e)
		{
			this.LoadHinhBC();
			this.XN.SoXN=this.TuyChonThamSo.tc.SoHotXiNgau;
			this.btnDoXiNgau.Enabled=false;
			
		}
		public void LoadHinhBC()
		{
			//String  strFileNameBC=Application.StartupPath+"/hinhbanco/logo.bmp";
			this.panelBC.BackgroundImage= new System.Drawing.Bitmap(this.TuyChonThamSo.tc.HinhBanCo);
		}
		public String GetStrImage()
		{
			String s=Application.StartupPath+"/hinhngua/";
			switch(BC.DLBC.UserHienTai)
			{	
				case 1: s+="duong.gif"; break;
				case 2: s+="do.gif"; break;
				case 3: s+="vang.gif"; break;
				case 4: s+="xanh.gif";break;
			}
			return s;
		}
		public void ResetManHinh()
		{
			this.panelBC.BackgroundImage=new System.Drawing.Bitmap(this.TuyChonThamSo.tc.HinhBanCo);
			this.TheHienXN.SoXiNgauTheHien=this.TuyChonThamSo.tc.SoHotXiNgau;
			this.TheHienXN.DinhViXiNgau();
			this.BC.DLBC.CapNhatDL(this.TuyChonThamSo.tc);
		}
		public bool KiemTraRaQuan()
		{
			if(XN.SoXN==1)
			{
				if( (XN.gt1==BC.DLBC.gtRQ1)||(XN.gt1==BC.DLBC.gtRQ2) )
					return true;
			}
			else
			{
				if( (XN.gt1==BC.DLBC.gtRQ1)&&(XN.gt2==BC.DLBC.gtRQ1) ||
					(XN.gt1==BC.DLBC.gtRQ2)&&(XN.gt2==BC.DLBC.gtRQ2) )
					return true;
			}
			return false;
		}
		/*
		public void KhoiTaoBac()
		{
			int SoNguoiChoi=BC.DLBC.SoNguoichoi;
			for(int i=0;i<SoNguoiChoi;i++)
			{
				DuLieu.DuLieuUser User=(DuLieu.DuLieuUser)BC.DLBC.arrUsers[i];
				for(int j=0;j<User.SoQuanCo;j++)
				{
					XuLy.QuanCo qc=(XuLy.QuanCo) User.arrQC[j];
					qc.QCDL.Bac=6-SoNguoiChoi+1;
				}
			}
		}*/
		#endregion
		#region Click
		private void btnDoXiNgau_Click(object sender, System.EventArgs e)
		{
			XN.DoXingau(TheHienXN);
			this.picLuotQC.Image=new System.Drawing.Bitmap(GetStrImage());
			this.BC.DLBC.CapNhatGTXN(XN);
			bEnter=(KiemTraRaQuan()==true)?true:false;
			BC.XuLyBanCo();
			if(bEnter==false)
				this.BC.DLBC.UserHienTai=(this.BC.DLBC.UserHienTai)%(this.BC.DLBC.SoNguoichoi)+1;

		}
		private void btnTuyChon_Click(object sender, System.EventArgs e)
		{
			TuyChonThamSo.ShowDialog(this);
			this.btnSapBanCo.Enabled=true;
		}

		private void btnThoat_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		
		private void btnSapBanCo_Click(object sender, System.EventArgs e)
		{
			ResetManHinh();
			BC.SapBanCo(this.panelBC,this.TuyChonThamSo.tc);// moi
			this.btnSapBanCo.Enabled=false;
			this.btnDoXiNgau.Enabled=true;
		}
		#endregion
	}
	#endregion
}
