using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace VirtualClock
{
	/// <summary>
	/// Summary description for AlarmControl.
	/// </summary>
	public class AlarmControl : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ImageList imageList1;
		private System.ComponentModel.IContainer components;

		private const int ALARM_OFF = 0;
		private const int ALARM_ON =  1;

		public AlarmControl()
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
				if(components != null)
				{
					components.Dispose();
				}
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AlarmControl));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 40);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(0)));
			// 
			// AlarmControl
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.pictureBox1});
			this.Name = "AlarmControl";
			this.Size = new System.Drawing.Size(48, 40);
			this.SizeChanged += new System.EventHandler(this.AlarmControl_SizeChanged);
			this.ResumeLayout(false);

		}
		#endregion

		private void AlarmControl_SizeChanged(object sender, System.EventArgs e)
		{
			pictureBox1.SetBounds(0, 0, ClientRectangle.Width, ClientRectangle.Height);
		}

		private DateTime m_TimeSet = DateTime.Now;
		public  DateTime TimeSet
		{
			get { return m_TimeSet;}
			set { m_TimeSet = value;}
		}


		private bool m_Set = false;
		public  bool AlarmSet
		{
			get { return m_Set;}
			set { m_Set = value;}
		}

		[DllImport("winmm.dll")]
		public static extern long PlaySound(String lpszName, IntPtr hModule, Int32 dwFlags);

		private string m_strCurrentSoundFile = "mickey2.wav";
		public void PlayASound()
		{
			lock (m_strCurrentSoundFile)
			{
				if (m_strCurrentSoundFile.Length > 0)
				{
					string startupPath = Application.StartupPath;
					PlaySound(startupPath + "\\" + m_strCurrentSoundFile, (IntPtr)0, 0);
				}
				m_strCurrentSoundFile = "";
				if (oThread != null)
				{
					oThread.Abort();
					oThread = null;
				}
			}
		}

		Thread oThread = null;
		public void PlaySoundInThread(string wavefile)
		{
			m_strCurrentSoundFile = wavefile;
			oThread = new Thread(new ThreadStart(PlayASound));
			oThread.Start();
		}




		public string StartupPath = "";


		void PlayAlarm()
		{
			PlaySoundInThread("mickey2.wav");
		}


		DateTime timeNow = DateTime.Now;
		public void CheckAlarm()
		{
			if (m_TimeSet.Ticks < DateTime.Now.Ticks)
				PlayAlarm();
		}

		AlarmDialog TheAlarmDialog = null;
		public void OpenAlarmDialog()
		{
			 TheAlarmDialog = new AlarmDialog(this);

			if (TheAlarmDialog.ShowDialog() == DialogResult.OK)
			{
				if (m_Set)
					pictureBox1.Image = imageList1.Images[ALARM_ON];
				else
					pictureBox1.Image = imageList1.Images[ALARM_OFF];

				Invalidate();
			}
		}

		private void pictureBox1_Click(object sender, System.EventArgs e)
		{
			if (m_Set == false)
				OpenAlarmDialog();
			else
			{
				m_Set = false;
				pictureBox1.Image = imageList1.Images[ALARM_OFF];
				Invalidate();
				if (oThread != null)
				{
					oThread.Abort();
					oThread = null;
//					PlaySound((string)null, (IntPtr)null, 0); // stop current sound;
				}
			}
		}
	}
}
