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

namespace Client
{

	public class Form1 : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
        
		ScreenCapture obj;
        TcpChannel chan;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
        string URI;
        private Button button4;
        private Button button3;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Panel panel2;
		bool connected = false;
		public Form1()
		{
			
			// Yêu cầu cho windown hỗi trợ
			
			InitializeComponent();	
			
		}




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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.pictureBox1.Size = new System.Drawing.Size(589, 453);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 453);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 30);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP :";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(465, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Thu nhỏ màn hình";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "127.0.0.1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(332, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Xem toàn màn hình";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(147, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kết Nối";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(228, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Tắt kết nối";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(589, 453);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theo Dõi Máy Tính";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

// Chương trình chính 
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
		

        // Hàm tạo kết nối với server
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

				this.FormBorderStyle = FormBorderStyle.None;// Xem full màn hình
				this.WindowState = FormWindowState.Maximized;
				textBox1.Visible = false;
				
			}
			catch (Exception){stop();};
		}


        // Hàm hủy kết nối với server
		void stop()
		{
			try
			{
				timer1.Enabled = false;
				textBox1.ReadOnly = false;
				connected = false;

				this.FormBorderStyle = FormBorderStyle.Sizable; // Kích thước màn hình bt ( mặc định)
				this.WindowState = FormWindowState.Normal;
				textBox1.Visible = true;
				this.Width = 584;
				this.Height = 440;

				ChannelServices.UnregisterChannel(chan);// Xóa kênh kết nối  

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

            //  Nhận ảnh chụp màn hình từ phía server
			URI = "Tcp://"+textBox1.Text+":6600/MyCaptureScreenServer";
			byte[] buffer = obj.GetDesktopBitmapBytes();
			MemoryStream ms = new MemoryStream(buffer);
			pictureBox1.Image = Image.FromStream(ms);
		}
		catch (Exception){stop();};

	}




        // form xem dữ liệu truyền về 
		private void Form1_Load(object sender, System.EventArgs e)
		{
		}

       

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			stop();
		}

 
        // button kết nối
        private void button1_Click(object sender, EventArgs e)
        {
            start();
        }

        // button Tắt kết nối
        private void button2_Click(object sender, EventArgs e)
        {
            stop();
        }

        // button Thu nhỏ màn hình 
        private void button4_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
            textBox1.Visible = true;
            this.Width = 584;
            this.Height = 440;
        }

        // button Xem full màn hình 
        private void button3_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            textBox1.Visible = false;
        }



	}
}
