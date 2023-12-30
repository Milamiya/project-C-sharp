using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace VirtualClock
{
	/// <summary>
	/// Summary description for AlarmDialog.
	/// </summary>
	public class AlarmDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox SetAlarmGroup;
		private System.Windows.Forms.RadioButton OffRadio;
		private System.Windows.Forms.RadioButton OnRadio;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.Button CancelButton;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private AlarmControl AlarmReference = null;
		public AlarmDialog(AlarmControl anAlarm)
		{

			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			AlarmReference = anAlarm;
			this.OnRadio.Checked = anAlarm.AlarmSet;
			this.OffRadio.Checked = (anAlarm.AlarmSet == false);
			this.dateTimePicker1.Text = anAlarm.TimeSet.ToShortTimeString();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			this.SetAlarmGroup = new System.Windows.Forms.GroupBox();
			this.OffRadio = new System.Windows.Forms.RadioButton();
			this.OnRadio = new System.Windows.Forms.RadioButton();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.OKButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.SetAlarmGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// SetAlarmGroup
			// 
			this.SetAlarmGroup.Controls.AddRange(new System.Windows.Forms.Control[] {
																						this.OffRadio,
																						this.OnRadio});
			this.SetAlarmGroup.Location = new System.Drawing.Point(16, 16);
			this.SetAlarmGroup.Name = "SetAlarmGroup";
			this.SetAlarmGroup.Size = new System.Drawing.Size(240, 72);
			this.SetAlarmGroup.TabIndex = 1;
			this.SetAlarmGroup.TabStop = false;
			this.SetAlarmGroup.Text = "Set Alarm";
			// 
			// OffRadio
			// 
			this.OffRadio.Checked = true;
			this.OffRadio.Location = new System.Drawing.Point(24, 16);
			this.OffRadio.Name = "OffRadio";
			this.OffRadio.Size = new System.Drawing.Size(48, 24);
			this.OffRadio.TabIndex = 0;
			this.OffRadio.TabStop = true;
			this.OffRadio.Text = "Off";
			this.OffRadio.CheckedChanged += new System.EventHandler(this.OffRadio_CheckedChanged);
			// 
			// OnRadio
			// 
			this.OnRadio.Location = new System.Drawing.Point(24, 40);
			this.OnRadio.Name = "OnRadio";
			this.OnRadio.Size = new System.Drawing.Size(48, 24);
			this.OnRadio.TabIndex = 2;
			this.OnRadio.Text = "On";
			this.OnRadio.CheckedChanged += new System.EventHandler(this.OnRadio_CheckedChanged);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePicker1.Location = new System.Drawing.Point(104, 40);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(128, 20);
			this.dateTimePicker1.TabIndex = 2;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// OKButton
			// 
			this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OKButton.Location = new System.Drawing.Point(56, 104);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(64, 24);
			this.OKButton.TabIndex = 3;
			this.OKButton.Text = "OK";
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Location = new System.Drawing.Point(152, 104);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(64, 24);
			this.CancelButton.TabIndex = 4;
			this.CancelButton.Text = "Cancel";
			// 
			// AlarmDialog
			// 
			this.AcceptButton = this.OKButton;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(272, 133);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.CancelButton,
																		  this.OKButton,
																		  this.dateTimePicker1,
																		  this.SetAlarmGroup});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "AlarmDialog";
			this.Text = "Set the Alarm";
			this.SetAlarmGroup.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void OnRadio_CheckedChanged(object sender, System.EventArgs e)
		{
		}

		private void OffRadio_CheckedChanged(object sender, System.EventArgs e)
		{
	
		}

		private void OKButton_Click(object sender, System.EventArgs e)
		{
			AlarmReference.AlarmSet = OnRadio.Checked;		
			
			if (OnRadio.Checked)
			{
				try
				{
					AlarmReference.TimeSet = DateTime.Parse(this.dateTimePicker1.Text);
				}
				catch
				{
					AlarmReference.TimeSet = DateTime.Now;
				}
			}

		
		}

		private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
		{
			// assume setting time means change radios
			OnRadio.Checked = true;
			OffRadio.Checked = false;
		}

	}
}
