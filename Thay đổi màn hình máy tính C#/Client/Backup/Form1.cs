using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace Remotting_Client
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		ScreenCapture obj;
		TcpChannel chan;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		string URI;
		bool connected = false;
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();	
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		[DllImport("user32.dll")]
		private static extern uint MapVirtualKey(
			uint uCode,     // virtual-key code or scan code
			uint uMapType   // translation to perform
			);
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem5});
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem3,
																					  this.menuItem4});
			this.menuItem2.Text = "Monitoring";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 0;
			this.menuItem3.Text = "Start";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.Text = "Stop";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Enabled = false;
			this.menuItem5.Index = 1;
			this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem6,
																					  this.menuItem7});
			this.menuItem5.Text = "Screen Size";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 0;
			this.menuItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlF;
			this.menuItem6.Text = "Full Screen";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 1;
			this.menuItem7.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
			this.menuItem7.Text = "Normal Screen";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(578, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "127.0.0.1";
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(578, 367);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
			this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 20);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(578, 367);
			this.panel1.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(578, 387);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Remotting Client";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.None;
			this.WindowState = FormWindowState.Maximized;
			textBox1.Visible = false;

		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.Sizable;
			this.WindowState = FormWindowState.Normal;
			textBox1.Visible = true;
			this.Width = 584;
			this.Height = 440;
		}
		
		void start()
		{
			try
			{

				URI = "Tcp://"+textBox1.Text+":6600/MyCaptureScreenServer";
				chan = new TcpChannel();
				ChannelServices.RegisterChannel(chan);
				obj = (ScreenCapture)Activator.GetObject(typeof(ScreenCapture), URI);
		
				connected = true;
				timer1.Enabled = true;
				textBox1.ReadOnly = true;

				this.FormBorderStyle = FormBorderStyle.None;// Full Size Mode
				this.WindowState = FormWindowState.Maximized;
				textBox1.Visible = false;
				menuItem5.Enabled = true;
			}
			catch (Exception){stop();};
		}
		void stop()
		{
			try
			{
				timer1.Enabled = false;
				textBox1.ReadOnly = false;
				connected = false;

				this.FormBorderStyle = FormBorderStyle.Sizable; // Normal Size Mode
				this.WindowState = FormWindowState.Normal;
				textBox1.Visible = true;
				this.Width = 584;
				this.Height = 440;

				ChannelServices.UnregisterChannel(chan);//to Un Register chan Channel 

			}
			catch(Exception){}
			}
	
 	private void menuItem3_Click(object sender, System.EventArgs e)
		{
			start();
		}

	private void timer1_Tick_1(object sender, System.EventArgs e)
	{
		try
		{
			URI = "Tcp://"+textBox1.Text+":6600/MyCaptureScreenServer";
			byte[] buffer = obj.GetDesktopBitmapBytes();
			MemoryStream ms = new MemoryStream(buffer);
			pictureBox1.Image = Image.FromStream(ms);
		}
		catch (Exception){stop();};

	}

		private void pictureBox1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (connected == true)
			{
				obj.MoveMouse(e.X, e.Y);
			}
		}

		private void pictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (connected == true)
			{
				obj.PressOrReleaseMouseButton(true, e.Button == MouseButtons.Left, e.X, e.Y);
			}
			}

		private void pictureBox1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (connected == true)
			{
				obj.PressOrReleaseMouseButton(false, e.Button == MouseButtons.Left, e.X, e.Y);
			}
			}

		private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (connected == true)
			{
				e.Handled = true;
				obj.SendKeystroke((byte) e.KeyCode, (byte) MapVirtualKey((uint) e.KeyCode, 0), true, false);
			}
		}

		private void textBox1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (connected == true)
			{
				e.Handled = true;
				obj.SendKeystroke((byte) e.KeyCode, (byte) MapVirtualKey((uint) e.KeyCode, 0), false, false);
			}
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			stop();

		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			stop();
		}



	}
}
