using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Drawing2D ;
using System.Drawing.Imaging;

namespace VirtualClock
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		private MinuteHand MyMinuteHand;
		private HourHand MyHourHand;
		private System.Windows.Forms.Timer timer1;
		private SecondHand MySecondHand;
		private ClockFace TheClockFace;
		private VirtualClock.AlarmControl alarmControl1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private bool FirstTick = false;

		public Form1()
		{
			 MyMinuteHand = new MinuteHand(this);
			 MyHourHand = new HourHand(this);
			 MySecondHand = new SecondHand(this);
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			TheClockFace = new ClockFace(ClientRectangle);

			timer1.Start();

			
			// draw minute hand
			
			// draw hour hand

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			// set up double-buffering
			SetStyle(ControlStyles.UserPaint, true);
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.DoubleBuffer, true);
		}

		/// <summary>
		/// Clean up any resources being used.
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

			timer1.Stop();
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.alarmControl1 = new VirtualClock.AlarmControl();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "time";
            this.notifyIcon1.Visible = true;
            // 
            // alarmControl1
            // 
            this.alarmControl1.AlarmSet = false;
            this.alarmControl1.Location = new System.Drawing.Point(256, 0);
            this.alarmControl1.Name = "alarmControl1";
            this.alarmControl1.Size = new System.Drawing.Size(40, 32);
            this.alarmControl1.TabIndex = 0;
            this.alarmControl1.TimeSet = new System.DateTime(2003, 6, 26, 22, 11, 20, 128);
            this.alarmControl1.Load += new System.EventHandler(this.alarmControl1_Load);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.alarmControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtual Clock";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
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

		private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			if (FirstTick == false)
				return;

			Graphics g = e.Graphics;
			TheClockFace.Draw(g);					
			MyHourHand.Draw(g);
			MyMinuteHand.Draw(g);
			MySecondHand.Draw(g);
			TheClockFace.DrawPin(g); // redraw the pin to cover the hands
		}

		private void Form1_Resize(object sender, System.EventArgs e)
		{
			TheClockFace.UpdateRectangle(ClientRectangle);
			Invalidate();
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			MySecondHand.Transform(DateTime.Now);
			MyHourHand.Transform(DateTime.Now);
			MyMinuteHand.Transform(DateTime.Now);
			if (alarmControl1.AlarmSet)
				alarmControl1.CheckAlarm();
			FirstTick = true;
			notifyIcon1.Text = DateTime.Now.ToShortTimeString();
			Invalidate();
		}

		private void alarmControl1_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
