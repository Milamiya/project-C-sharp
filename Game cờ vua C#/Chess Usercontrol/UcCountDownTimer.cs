using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace DigitalClock
{
	/// <summary>
    /// Summary description for UcCountDownTimer.
	/// </summary>
	public class UcCountDownTimer : System.Windows.Forms.UserControl
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		CCifre cc = new CCifre() ;
		private System.Timers.Timer timer1;
		short min =10, sec =10; 
		Color foreColor = Color.Lime ;
		private System.ComponentModel.Container components = null;

		public UcCountDownTimer()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
					components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.timer1 = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // UcCountDownTimer
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Name = "UcCountDownTimer";
            this.Size = new System.Drawing.Size(178, 63);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControl1_Paint);
            this.Resize += new System.EventHandler(this.UserControl1_Resize);
            this.ForeColorChanged += new System.EventHandler(this.UserControl1_ForeColorChanged);
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void UserControl1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			cc.Set_Time( min , sec ,e.ClipRectangle ,e.Graphics, foreColor );
		}

		private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			RefreshTime( ref min ,ref sec);
			Invalidate() ;	
		}

        public void TimeBonus(short s)
        {
            sec += s;
            while (sec >= 60)
            {
                min++;
                sec -= 60;
            }
            UserControl1_Paint(this, new PaintEventArgs(this.CreateGraphics(),new Rectangle (0,0,Width ,Height )));
        }

        public void StopTimer()
        {
            timer1.Stop();
        }
        public void StartTimer()
        {
            timer1.Start();
        }

        public Color DigitColor
        {
            get { return this.foreColor ; }
            set { this.foreColor = value; }
        }
        public short  Minute
        {
            get { return this.min ; }
            set { this.min  = value; }
        }
        public short  Second
        {
            get { return this.sec  ; }
            set { this.sec = value; }
        }

		private void RefreshTime(ref short m , ref short s )
		{
            s--;
            if (s < 0)
            {
                m--;
                s = 59;
            }            
            if (min == 0 && sec == 0)
            {
                timer1.Stop();
                UserControl1_Paint(this, new PaintEventArgs(this.CreateGraphics(), new Rectangle (0,0,this.Width ,this.Height )));
                OnTimeOut(EventArgs.Empty);
            }
            //m = (short)DateTime.Now.Minute;
            //s = (short)DateTime.Now.Second;
		}

        public delegate void TimeOutHandler(object sender, EventArgs e);
        public event TimeOutHandler  TimeOut;
        protected virtual void OnTimeOut(EventArgs e)
        {
            if (TimeOut  != null)
                TimeOut (this, e);
        }
		private void UserControl1_Load(object sender, System.EventArgs e)
		{
			timer1.Interval = 1000 ;
			RefreshTime( ref min , ref sec);
		}

		private void UserControl1_Resize(object sender, System.EventArgs e)
		{	
			Invalidate() ;	
		}

		private void UserControl1_ForeColorChanged(object sender, System.EventArgs e)
		{
			foreColor= this.ForeColor;
		}
	}
}
