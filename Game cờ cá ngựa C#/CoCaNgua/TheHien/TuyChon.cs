using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CoCaNgua.TheHien
{
	/// <summary>
	/// Summary description for TuyChonXiNgau.
	/// </summary>
	public class TuyChon : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage XiNgau;
		private System.Windows.Forms.TabPage RaQuanVeDich;
		private System.Windows.Forms.TabPage NguoiChoi;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnApDung;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TabPage BanCo;
		private System.Windows.Forms.Button btnThayDoi;
		private System.Windows.Forms.OpenFileDialog openFileDlg;
		private System.Windows.Forms.PictureBox picBC;
		private System.Windows.Forms.ComboBox cmbRQ2;
		private System.Windows.Forms.ComboBox cmbRQ1;
		private System.Windows.Forms.ComboBox cmbVD2;
		private System.Windows.Forms.ComboBox cmbVD1;
		//bien luu
		public DuLieu.DuLieuTuyChon tc =new CoCaNgua.DuLieu.DuLieuTuyChon();
		private CoCaNgua.TheHien.TheHienXiNgau theHienXN;
		private System.Windows.Forms.ComboBox cmbQuan4;
		private System.Windows.Forms.ComboBox cmbQuan3;
		private System.Windows.Forms.ComboBox cmbQuan2;
		private System.Windows.Forms.ComboBox cmbQuan1;
		private System.Windows.Forms.ComboBox cmbSoNguoiChoi;
		private System.Windows.Forms.RadioButton Quan4;
		private System.Windows.Forms.RadioButton Quan3;
		private System.Windows.Forms.RadioButton Quan2;
		private System.Windows.Forms.RadioButton Quan1;
		public System.Windows.Forms.RadioButton MotXN;
		public System.Windows.Forms.RadioButton HaiXN;
		private System.Windows.Forms.PictureBox picQuan4;
		private System.Windows.Forms.PictureBox picQuan3;
		private System.Windows.Forms.PictureBox picQuan2;
		private System.Windows.Forms.PictureBox picQuan1;
		private System.Windows.Forms.TextBox txtUser4;
		private System.Windows.Forms.TextBox txtUser3;
		private System.Windows.Forms.TextBox txtUser2;
		private System.Windows.Forms.TextBox txtUser1;
		private System.Windows.Forms.Label lblUser4;
		private System.Windows.Forms.Label lblUser3;
		private System.Windows.Forms.Label lblUser2;
		private System.Windows.Forms.Label lblUser1;
		//public DuLieu.DuLieuBanCo dlbc=new CoCaNgua.DuLieu.DuLieuBanCo();
		public TheHien.TheHienQuanCo qc=new TheHienQuanCo();
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public TuyChon()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.NguoiChoi = new System.Windows.Forms.TabPage();
			this.cmbQuan4 = new System.Windows.Forms.ComboBox();
			this.cmbQuan3 = new System.Windows.Forms.ComboBox();
			this.cmbQuan2 = new System.Windows.Forms.ComboBox();
			this.cmbQuan1 = new System.Windows.Forms.ComboBox();
			this.cmbSoNguoiChoi = new System.Windows.Forms.ComboBox();
			this.picQuan4 = new System.Windows.Forms.PictureBox();
			this.picQuan3 = new System.Windows.Forms.PictureBox();
			this.picQuan2 = new System.Windows.Forms.PictureBox();
			this.picQuan1 = new System.Windows.Forms.PictureBox();
			this.Quan4 = new System.Windows.Forms.RadioButton();
			this.Quan3 = new System.Windows.Forms.RadioButton();
			this.Quan2 = new System.Windows.Forms.RadioButton();
			this.Quan1 = new System.Windows.Forms.RadioButton();
			this.txtUser4 = new System.Windows.Forms.TextBox();
			this.txtUser3 = new System.Windows.Forms.TextBox();
			this.txtUser2 = new System.Windows.Forms.TextBox();
			this.txtUser1 = new System.Windows.Forms.TextBox();
			this.lblUser4 = new System.Windows.Forms.Label();
			this.lblUser3 = new System.Windows.Forms.Label();
			this.lblUser2 = new System.Windows.Forms.Label();
			this.lblUser1 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.XiNgau = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.theHienXN = new CoCaNgua.TheHien.TheHienXiNgau();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.MotXN = new System.Windows.Forms.RadioButton();
			this.HaiXN = new System.Windows.Forms.RadioButton();
			this.RaQuanVeDich = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cmbRQ2 = new System.Windows.Forms.ComboBox();
			this.cmbRQ1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.cmbVD2 = new System.Windows.Forms.ComboBox();
			this.cmbVD1 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.BanCo = new System.Windows.Forms.TabPage();
			this.btnThayDoi = new System.Windows.Forms.Button();
			this.picBC = new System.Windows.Forms.PictureBox();
			this.btnApDung = new System.Windows.Forms.Button();
			this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
			this.tabControl1.SuspendLayout();
			this.NguoiChoi.SuspendLayout();
			this.XiNgau.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.RaQuanVeDich.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.BanCo.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.NguoiChoi);
			this.tabControl1.Controls.Add(this.XiNgau);
			this.tabControl1.Controls.Add(this.RaQuanVeDich);
			this.tabControl1.Controls.Add(this.BanCo);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(320, 272);
			this.tabControl1.TabIndex = 0;
			// 
			// NguoiChoi
			// 
			this.NguoiChoi.BackColor = System.Drawing.SystemColors.Control;
			this.NguoiChoi.Controls.Add(this.cmbQuan4);
			this.NguoiChoi.Controls.Add(this.cmbQuan3);
			this.NguoiChoi.Controls.Add(this.cmbQuan2);
			this.NguoiChoi.Controls.Add(this.cmbQuan1);
			this.NguoiChoi.Controls.Add(this.cmbSoNguoiChoi);
			this.NguoiChoi.Controls.Add(this.picQuan4);
			this.NguoiChoi.Controls.Add(this.picQuan3);
			this.NguoiChoi.Controls.Add(this.picQuan2);
			this.NguoiChoi.Controls.Add(this.picQuan1);
			this.NguoiChoi.Controls.Add(this.Quan4);
			this.NguoiChoi.Controls.Add(this.Quan3);
			this.NguoiChoi.Controls.Add(this.Quan2);
			this.NguoiChoi.Controls.Add(this.Quan1);
			this.NguoiChoi.Controls.Add(this.txtUser4);
			this.NguoiChoi.Controls.Add(this.txtUser3);
			this.NguoiChoi.Controls.Add(this.txtUser2);
			this.NguoiChoi.Controls.Add(this.txtUser1);
			this.NguoiChoi.Controls.Add(this.lblUser4);
			this.NguoiChoi.Controls.Add(this.lblUser3);
			this.NguoiChoi.Controls.Add(this.lblUser2);
			this.NguoiChoi.Controls.Add(this.lblUser1);
			this.NguoiChoi.Controls.Add(this.label10);
			this.NguoiChoi.Controls.Add(this.label9);
			this.NguoiChoi.Controls.Add(this.label8);
			this.NguoiChoi.Controls.Add(this.label7);
			this.NguoiChoi.Controls.Add(this.label6);
			this.NguoiChoi.Controls.Add(this.label5);
			this.NguoiChoi.Location = new System.Drawing.Point(4, 22);
			this.NguoiChoi.Name = "NguoiChoi";
			this.NguoiChoi.Size = new System.Drawing.Size(312, 246);
			this.NguoiChoi.TabIndex = 2;
			this.NguoiChoi.Text = "Nguoi Choi";
			// 
			// cmbQuan4
			// 
			this.cmbQuan4.Location = new System.Drawing.Point(192, 176);
			this.cmbQuan4.Name = "cmbQuan4";
			this.cmbQuan4.Size = new System.Drawing.Size(48, 21);
			this.cmbQuan4.TabIndex = 31;
			// 
			// cmbQuan3
			// 
			this.cmbQuan3.Location = new System.Drawing.Point(192, 144);
			this.cmbQuan3.Name = "cmbQuan3";
			this.cmbQuan3.Size = new System.Drawing.Size(48, 21);
			this.cmbQuan3.TabIndex = 30;
			// 
			// cmbQuan2
			// 
			this.cmbQuan2.Location = new System.Drawing.Point(192, 112);
			this.cmbQuan2.Name = "cmbQuan2";
			this.cmbQuan2.Size = new System.Drawing.Size(48, 21);
			this.cmbQuan2.TabIndex = 29;
			// 
			// cmbQuan1
			// 
			this.cmbQuan1.Location = new System.Drawing.Point(192, 80);
			this.cmbQuan1.Name = "cmbQuan1";
			this.cmbQuan1.Size = new System.Drawing.Size(48, 21);
			this.cmbQuan1.TabIndex = 28;
			// 
			// cmbSoNguoiChoi
			// 
			this.cmbSoNguoiChoi.Location = new System.Drawing.Point(152, 16);
			this.cmbSoNguoiChoi.Name = "cmbSoNguoiChoi";
			this.cmbSoNguoiChoi.Size = new System.Drawing.Size(48, 21);
			this.cmbSoNguoiChoi.TabIndex = 27;
			this.cmbSoNguoiChoi.SelectedIndexChanged += new System.EventHandler(this.cmbSoNguoiChoi_SelectedIndexChanged);
			// 
			// picQuan4
			// 
			this.picQuan4.Location = new System.Drawing.Point(144, 176);
			this.picQuan4.Name = "picQuan4";
			this.picQuan4.Size = new System.Drawing.Size(20, 20);
			this.picQuan4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picQuan4.TabIndex = 26;
			this.picQuan4.TabStop = false;
			// 
			// picQuan3
			// 
			this.picQuan3.Location = new System.Drawing.Point(144, 144);
			this.picQuan3.Name = "picQuan3";
			this.picQuan3.Size = new System.Drawing.Size(20, 20);
			this.picQuan3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picQuan3.TabIndex = 25;
			this.picQuan3.TabStop = false;
			// 
			// picQuan2
			// 
			this.picQuan2.Location = new System.Drawing.Point(144, 112);
			this.picQuan2.Name = "picQuan2";
			this.picQuan2.Size = new System.Drawing.Size(20, 20);
			this.picQuan2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picQuan2.TabIndex = 24;
			this.picQuan2.TabStop = false;
			// 
			// picQuan1
			// 
			this.picQuan1.Location = new System.Drawing.Point(144, 80);
			this.picQuan1.Name = "picQuan1";
			this.picQuan1.Size = new System.Drawing.Size(20, 20);
			this.picQuan1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picQuan1.TabIndex = 23;
			this.picQuan1.TabStop = false;
			// 
			// Quan4
			// 
			this.Quan4.Location = new System.Drawing.Point(272, 184);
			this.Quan4.Name = "Quan4";
			this.Quan4.Size = new System.Drawing.Size(10, 10);
			this.Quan4.TabIndex = 18;
			// 
			// Quan3
			// 
			this.Quan3.Location = new System.Drawing.Point(272, 152);
			this.Quan3.Name = "Quan3";
			this.Quan3.Size = new System.Drawing.Size(10, 10);
			this.Quan3.TabIndex = 17;
			// 
			// Quan2
			// 
			this.Quan2.Location = new System.Drawing.Point(272, 120);
			this.Quan2.Name = "Quan2";
			this.Quan2.Size = new System.Drawing.Size(10, 10);
			this.Quan2.TabIndex = 16;
			// 
			// Quan1
			// 
			this.Quan1.Checked = true;
			this.Quan1.Location = new System.Drawing.Point(272, 88);
			this.Quan1.Name = "Quan1";
			this.Quan1.Size = new System.Drawing.Size(10, 10);
			this.Quan1.TabIndex = 15;
			this.Quan1.TabStop = true;
			// 
			// txtUser4
			// 
			this.txtUser4.Location = new System.Drawing.Point(40, 176);
			this.txtUser4.Name = "txtUser4";
			this.txtUser4.Size = new System.Drawing.Size(80, 20);
			this.txtUser4.TabIndex = 14;
			this.txtUser4.Text = "User4";
			// 
			// txtUser3
			// 
			this.txtUser3.Location = new System.Drawing.Point(40, 144);
			this.txtUser3.Name = "txtUser3";
			this.txtUser3.Size = new System.Drawing.Size(80, 20);
			this.txtUser3.TabIndex = 13;
			this.txtUser3.Text = "User3";
			// 
			// txtUser2
			// 
			this.txtUser2.Location = new System.Drawing.Point(40, 112);
			this.txtUser2.Name = "txtUser2";
			this.txtUser2.Size = new System.Drawing.Size(80, 20);
			this.txtUser2.TabIndex = 12;
			this.txtUser2.Text = "User2";
			// 
			// txtUser1
			// 
			this.txtUser1.Location = new System.Drawing.Point(40, 80);
			this.txtUser1.Name = "txtUser1";
			this.txtUser1.Size = new System.Drawing.Size(80, 20);
			this.txtUser1.TabIndex = 11;
			this.txtUser1.Text = "User1";
			// 
			// lblUser4
			// 
			this.lblUser4.Location = new System.Drawing.Point(8, 176);
			this.lblUser4.Name = "lblUser4";
			this.lblUser4.Size = new System.Drawing.Size(16, 16);
			this.lblUser4.TabIndex = 10;
			this.lblUser4.Text = "4";
			this.lblUser4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblUser3
			// 
			this.lblUser3.Location = new System.Drawing.Point(8, 144);
			this.lblUser3.Name = "lblUser3";
			this.lblUser3.Size = new System.Drawing.Size(16, 16);
			this.lblUser3.TabIndex = 9;
			this.lblUser3.Text = "3";
			this.lblUser3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblUser2
			// 
			this.lblUser2.Location = new System.Drawing.Point(8, 112);
			this.lblUser2.Name = "lblUser2";
			this.lblUser2.Size = new System.Drawing.Size(16, 16);
			this.lblUser2.TabIndex = 8;
			this.lblUser2.Text = "2";
			this.lblUser2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblUser1
			// 
			this.lblUser1.Location = new System.Drawing.Point(8, 80);
			this.lblUser1.Name = "lblUser1";
			this.lblUser1.Size = new System.Drawing.Size(16, 16);
			this.lblUser1.TabIndex = 7;
			this.lblUser1.Text = "1";
			this.lblUser1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(264, 56);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(40, 16);
			this.label10.TabIndex = 6;
			this.label10.Text = "Uu tien";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(184, 56);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(64, 16);
			this.label9.TabIndex = 5;
			this.label9.Text = "So Quan";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(144, 56);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(32, 16);
			this.label8.TabIndex = 4;
			this.label8.Text = "Mau";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(48, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 16);
			this.label7.TabIndex = 3;
			this.label7.Text = "Ten";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(0, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 16);
			this.label6.TabIndex = 2;
			this.label6.Text = "STT";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(80, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "So Nguoi";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// XiNgau
			// 
			this.XiNgau.Controls.Add(this.groupBox2);
			this.XiNgau.Controls.Add(this.groupBox1);
			this.XiNgau.Location = new System.Drawing.Point(4, 22);
			this.XiNgau.Name = "XiNgau";
			this.XiNgau.Size = new System.Drawing.Size(312, 246);
			this.XiNgau.TabIndex = 0;
			this.XiNgau.Text = "Xi Ngau";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.theHienXN);
			this.groupBox2.Location = new System.Drawing.Point(160, 64);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(136, 100);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Minh Hoa";
			// 
			// theHienXN
			// 
			this.theHienXN.Location = new System.Drawing.Point(16, 24);
			this.theHienXN.Name = "theHienXN";
			this.theHienXN.Size = new System.Drawing.Size(104, 56);
			this.theHienXN.SoXiNgauTheHien = 1;
			this.theHienXN.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.MotXN);
			this.groupBox1.Controls.Add(this.HaiXN);
			this.groupBox1.Location = new System.Drawing.Point(16, 64);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(128, 100);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chon Xi Ngau";
			// 
			// MotXN
			// 
			this.MotXN.Checked = true;
			this.MotXN.Location = new System.Drawing.Point(24, 24);
			this.MotXN.Name = "MotXN";
			this.MotXN.Size = new System.Drawing.Size(88, 24);
			this.MotXN.TabIndex = 1;
			this.MotXN.TabStop = true;
			this.MotXN.Text = "Mot xi ngau";
			this.MotXN.Click += new System.EventHandler(this.MotXN_Click);
			// 
			// HaiXN
			// 
			this.HaiXN.Location = new System.Drawing.Point(24, 56);
			this.HaiXN.Name = "HaiXN";
			this.HaiXN.Size = new System.Drawing.Size(88, 24);
			this.HaiXN.TabIndex = 2;
			this.HaiXN.Text = "Hai xi ngau";
			this.HaiXN.Click += new System.EventHandler(this.HaiXN_Click);
			// 
			// RaQuanVeDich
			// 
			this.RaQuanVeDich.Controls.Add(this.groupBox3);
			this.RaQuanVeDich.Controls.Add(this.groupBox4);
			this.RaQuanVeDich.Location = new System.Drawing.Point(4, 22);
			this.RaQuanVeDich.Name = "RaQuanVeDich";
			this.RaQuanVeDich.Size = new System.Drawing.Size(312, 246);
			this.RaQuanVeDich.TabIndex = 1;
			this.RaQuanVeDich.Text = "Ra Quan-Ve Dich";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cmbRQ2);
			this.groupBox3.Controls.Add(this.cmbRQ1);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Location = new System.Drawing.Point(16, 48);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(128, 112);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Gia tri Ra Quan";
			// 
			// cmbRQ2
			// 
			this.cmbRQ2.Location = new System.Drawing.Point(64, 72);
			this.cmbRQ2.Name = "cmbRQ2";
			this.cmbRQ2.Size = new System.Drawing.Size(48, 21);
			this.cmbRQ2.TabIndex = 2;
			// 
			// cmbRQ1
			// 
			this.cmbRQ1.Location = new System.Drawing.Point(64, 24);
			this.cmbRQ1.Name = "cmbRQ1";
			this.cmbRQ1.Size = new System.Drawing.Size(48, 21);
			this.cmbRQ1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Gia tri 2";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Gia tri 1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.cmbVD2);
			this.groupBox4.Controls.Add(this.cmbVD1);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Location = new System.Drawing.Point(168, 48);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(128, 112);
			this.groupBox4.TabIndex = 1;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Gia tri Ve Dich";
			// 
			// cmbVD2
			// 
			this.cmbVD2.Location = new System.Drawing.Point(64, 72);
			this.cmbVD2.Name = "cmbVD2";
			this.cmbVD2.Size = new System.Drawing.Size(48, 21);
			this.cmbVD2.TabIndex = 2;
			// 
			// cmbVD1
			// 
			this.cmbVD1.Location = new System.Drawing.Point(64, 24);
			this.cmbVD1.Name = "cmbVD1";
			this.cmbVD1.Size = new System.Drawing.Size(48, 21);
			this.cmbVD1.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Gia tri 2";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "Gia tri 1";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BanCo
			// 
			this.BanCo.Controls.Add(this.btnThayDoi);
			this.BanCo.Controls.Add(this.picBC);
			this.BanCo.Location = new System.Drawing.Point(4, 22);
			this.BanCo.Name = "BanCo";
			this.BanCo.Size = new System.Drawing.Size(312, 246);
			this.BanCo.TabIndex = 3;
			this.BanCo.Text = "Ban Co";
			// 
			// btnThayDoi
			// 
			this.btnThayDoi.Location = new System.Drawing.Point(216, 104);
			this.btnThayDoi.Name = "btnThayDoi";
			this.btnThayDoi.TabIndex = 1;
			this.btnThayDoi.Text = "Thay Doi";
			this.btnThayDoi.Click += new System.EventHandler(this.btnThayDoi_Click);
			// 
			// picBC
			// 
			this.picBC.Location = new System.Drawing.Point(16, 24);
			this.picBC.Name = "picBC";
			this.picBC.Size = new System.Drawing.Size(170, 170);
			this.picBC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBC.TabIndex = 0;
			this.picBC.TabStop = false;
			// 
			// btnApDung
			// 
			this.btnApDung.Location = new System.Drawing.Point(128, 232);
			this.btnApDung.Name = "btnApDung";
			this.btnApDung.Size = new System.Drawing.Size(64, 23);
			this.btnApDung.TabIndex = 1;
			this.btnApDung.Text = "Ap Dung";
			this.btnApDung.Click += new System.EventHandler(this.btnApDung_Click);
			// 
			// TuyChon
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(320, 270);
			this.Controls.Add(this.btnApDung);
			this.Controls.Add(this.tabControl1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TuyChon";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tuy Chon";
			this.Load += new System.EventHandler(this.TuyChon_Load);
			this.tabControl1.ResumeLayout(false);
			this.NguoiChoi.ResumeLayout(false);
			this.XiNgau.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.RaQuanVeDich.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.BanCo.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		private void TuyChon_Load(object sender, EventArgs e)
		{
			RemoveItemsControls();
			this.theHienXN.LoadImageXiNgau1(Application.StartupPath+"/HinhXiNgau/1.jpg");
			this.theHienXN.LoadImageXiNgau2(Application.StartupPath+"/HinhXiNgau/6.jpg");
			this.theHienXN.DinhViXiNgau();
			for(int i=0;i<4;i++)
				cmbSoNguoiChoi.Items.Add(i+1);
			for(int i=0;i<6;i++)
			{
				cmbQuan1.Items.Add(i+1);
				cmbQuan2.Items.Add(i+1);
				cmbQuan3.Items.Add(i+1);
				cmbQuan4.Items.Add(i+1);
				cmbRQ1.Items.Add(i+1);
				cmbRQ2.Items.Add(i+1);
				cmbVD1.Items.Add(i+1);
				cmbVD2.Items.Add(i+1);
			}
			this.cmbRQ1.Text=this.cmbRQ1.GetItemText(1);
			this.cmbRQ2.Text=this.cmbRQ2.GetItemText(6);
			this.cmbVD1.Text=this.cmbVD1.GetItemText(1);
			this.cmbVD2.Text=this.cmbVD2.GetItemText(6);
			this.cmbSoNguoiChoi.Text=this.cmbSoNguoiChoi.GetItemText(4);
			this.cmbQuan1.Text=this.cmbQuan1.GetItemText(4);
			this.cmbQuan2.Text=this.cmbQuan2.GetItemText(4);
			this.cmbQuan3.Text=this.cmbQuan3.GetItemText(4);
			this.cmbQuan4.Text=this.cmbQuan4.GetItemText(4);
			this.picQuan1.Image= new System.Drawing.Bitmap(Application.StartupPath+"/HinhNgua/"+qc.LayHinhQuanCo(1));
			this.picQuan2.Image= new System.Drawing.Bitmap(Application.StartupPath+"/HinhNgua/"+qc.LayHinhQuanCo(2));
			this.picQuan3.Image= new System.Drawing.Bitmap(Application.StartupPath+"/HinhNgua/"+qc.LayHinhQuanCo(3));
			this.picQuan4.Image= new System.Drawing.Bitmap(Application.StartupPath+"/HinhNgua/"+qc.LayHinhQuanCo(4));
			this.picBC.Image=new System.Drawing.Bitmap(Application.StartupPath+"/HinhBanCo/banco1.bmp");
		}
		private void RemoveItemsControls()
		{
			cmbSoNguoiChoi.Items.Clear();
			cmbQuan1.Items.Clear();
			cmbQuan2.Items.Clear();
			cmbQuan3.Items.Clear();
			cmbQuan4.Items.Clear();
			cmbRQ1.Items.Clear();
			cmbRQ2.Items.Clear();
			cmbVD1.Items.Clear();
			cmbVD2.Items.Clear();
		}
		private void AnHienQuan(int n,bool TrangThai)
		{	
			if(n==1)
			{
				if(this.txtUser1.Visible!=TrangThai)
				{
					this.lblUser1.Visible=TrangThai;
					this.txtUser1.Visible=TrangThai;
					this.picQuan1.Visible=TrangThai;
					this.cmbQuan1.Visible=TrangThai;
					this.Quan1.Visible=TrangThai;
				}
			}
			if(n==2)
			{
				if(this.txtUser2.Visible!=TrangThai)
				{
					this.lblUser2.Visible=TrangThai;
					this.txtUser2.Visible=TrangThai;
					this.picQuan2.Visible=TrangThai;
					this.cmbQuan2.Visible=TrangThai;
					this.Quan2.Visible=TrangThai;
				}
			}
			if(n==3)
			{
				if(this.txtUser3.Visible!=TrangThai)
				{
					this.lblUser3.Visible=TrangThai;
					this.txtUser3.Visible=TrangThai;
					this.picQuan3.Visible=TrangThai;
					this.cmbQuan3.Visible=TrangThai;
					this.Quan3.Visible=TrangThai;
				}
			}
			if(n==4)
			{
				if(this.txtUser4.Visible!=TrangThai)
				{
					this.lblUser4.Visible=TrangThai;
					this.txtUser4.Visible=TrangThai;
					this.picQuan4.Visible=TrangThai;
					this.cmbQuan4.Visible=TrangThai;
					this.Quan4.Visible=TrangThai;
				}
			}
			
		}
		
		private void cmbSoNguoiChoi_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.tc.SoNguoiChoi=this.cmbSoNguoiChoi.SelectedIndex+1;
			switch  (this.tc.SoNguoiChoi)
			{
				case 4:	AnHienQuan(1,true);AnHienQuan(2,true);AnHienQuan(3,true);AnHienQuan(4,true);break;	
				case 3: AnHienQuan(1,true);AnHienQuan(2,true);AnHienQuan(3,true);AnHienQuan(4,false);break;	
				case 2: AnHienQuan(1,true);AnHienQuan(2,true);AnHienQuan(3,false);AnHienQuan(4,false);break;	
				case 1: AnHienQuan(1,true);AnHienQuan(2,false);AnHienQuan(3,false);AnHienQuan(4,false);break;	

			}
		}

		private void btnThayDoi_Click(object sender, System.EventArgs e)
		{   
			this.openFileDlg.ShowDialog();
			String tam=this.openFileDlg.FileName;
			if(tam!="")
			
			try
			{
				this.picBC.Image=new System.Drawing.Bitmap(tam);
				this.tc.HinhBanCo=tam;
			}
			catch
			{
				MessageBox.Show("You must chose fileimage");
			}
			
		}

		private void btnApDung_Click(object sender, System.EventArgs e)
		{
			tc.SoHotXiNgau=(this.MotXN.Checked==true)?1:2;
			this.tc.gtRaQuan1=this.cmbRQ1.SelectedIndex+1;
			this.tc.gtRaQuan2=this.cmbRQ2.SelectedIndex+1;
			this.tc.gtVeDich1=this.cmbVD1.SelectedIndex+1;
			this.tc.gtVeDich2=this.cmbVD2.SelectedIndex+1;
			this.tc.SoNguoiChoi=this.cmbSoNguoiChoi.SelectedIndex+1;
			this.tc.PlayerNames[0]=this.txtUser1.Text;
			this.tc.PlayerNames[1]=this.txtUser2.Text;
			this.tc.PlayerNames[2]=this.txtUser3.Text;
			this.tc.PlayerNames[3]=this.txtUser4.Text;
			if(this.Quan1.Checked==true) tc.NguoiUuTien=1;
			if(this.Quan2.Checked==true) tc.NguoiUuTien=2;
			if(this.Quan3.Checked==true) tc.NguoiUuTien=3;
			if(this.Quan4.Checked==true) tc.NguoiUuTien=4;
			this.tc.SoNguaQuan[0]=this.cmbQuan1.SelectedIndex+1;
			this.tc.SoNguaQuan[1]=this.cmbQuan2.SelectedIndex+1;
			this.tc.SoNguaQuan[2]=this.cmbQuan3.SelectedIndex+1;
			this.tc.SoNguaQuan[3]=this.cmbQuan4.SelectedIndex+1;
			//this.tc.SoHotXiNgau=this.MotXN.Checked?1:2;
			this.Close();
		}

		private void MotXN_Click(object sender, System.EventArgs e)
		{
			this.theHienXN.SoXiNgauTheHien=1;
			this.theHienXN.DinhViXiNgau();
		}
		
		private void HaiXN_Click(object sender, System.EventArgs e)
		{
			this.theHienXN.SoXiNgauTheHien=2;
			this.theHienXN.DinhViXiNgau();
		}
				
	
	}
}
