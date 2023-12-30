using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CSharpFilters
{
	/// <summary>
	/// Summary description for ColorInput.
	/// </summary>
	public class ColorInput : Form
	{
		private TextBox Blue;
		private Label label4;
		private TextBox Green;
		private Label label3;
		private TextBox Red;
		private Label label2;
		private Label label1;
		private Button OK;
		private Button Cancel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        //Download source code tại Sharecode.vn
		public ColorInput()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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

		public int red
		{
			get 
			{
				return (Convert.ToInt32(Red.Text, 10));
			}
			set{Red.Text = value.ToString();}
		}

		public int green
		{
			get 
			{
				return (Convert.ToInt32(Green.Text, 10));
			}
			set{Green.Text = value.ToString();}
		}

		public int blue
		{
			get 
			{
				return (Convert.ToInt32(Blue.Text, 10));
			}
			set{Blue.Text = value.ToString();}
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorInput));
            this.Blue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Green = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Red = new System.Windows.Forms.TextBox();
           this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Blue
            // 
            this.Blue.Location = new System.Drawing.Point(103, 112);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(100, 20);
            this.Blue.TabIndex = 17;
            //// 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(32, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Blue";
           // // 
           // // Green
           // // 
            this.Green.Location = new System.Drawing.Point(103, 80);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(100, 20);
            this.Green.TabIndex = 15;
            // 
           // // label3
           // // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(32, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Green";
            // 
           // // Red
           // // 
            this.Red.Location = new System.Drawing.Point(103, 48);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(100, 20);
            this.Red.TabIndex = 13;
           // // 
           // // label2
           // // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(32, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Red";
            // 
           // // label1
           // // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nhập các giá trị màu từ -255 đến 255";
            // this.label1.Click += new System.EventHandler(this.label1_Click);
           // // 
           // // Cancel
           // // 
            this.Cancel.Location = new System.Drawing.Point(176, 178);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Bỏ qua";
            // 
           // // OK
           // // 
            this.OK.Location = new System.Drawing.Point(19, 178);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 10;
            this.OK.Text = "Đồng ý";
           // this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ColorInput
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(309, 226);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ColorInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CHON MAU";
            //this.Load += new System.EventHandler(this.ColorInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		
	}
}
