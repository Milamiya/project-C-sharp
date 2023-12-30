using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.Remoting; // gọi phương thức hỗ trợ Runtime.Remoting
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Server
{
 

	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
	
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
        // Code trên để khoanh vùng tạo giao diện cho form
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenu = this.contextMenu1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Chương trình quản lý màn hình PC";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Thoát chương trình";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(96, 32);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Remotting Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}
		#endregion

// Chương trình chính 
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{

			TcpChannel chan = new TcpChannel(6600);
			ChannelServices.RegisterChannel(chan);
			RemotingConfiguration.RegisterWellKnownServiceType(Type.GetType("ScreenCapture, ScreenCapture"), "MyCaptureScreenServer",WellKnownObjectMode.Singleton);
       
        //Kênh được sử dụng để vận chuyển những thông báo tới bằng đối tượng triệu gọi từ xa.Khi một Client gọi phương thức trên đối tượng từ xa,
        //các thông số, giống như chi tiết khác cái có liên quan tới tất cả thì truyền qua kênh tới đối tượng từ xa.
        //Một vài kết quả trả từ về theo con đường mà client đã gọi.
        }

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			this.FormBorderStyle = FormBorderStyle.None;
			this.WindowState = FormWindowState.Maximized;
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			this.Hide();
			timer1.Enabled = false;
		}


        // Thoát chương trình ( có mật khẩu bảo vệ )
		private void menuItem1_Click(object sender, System.EventArgs e)
		{
            String pass = Microsoft.VisualBasic.Interaction.InputBox("Nhập mật khẩu bảo vệ ", "Mật khẩu", "", -1, -1);
            if (pass == "doanthephong") // Mật khẩu thoát chương trình 
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Bạn đã nhập mật khẩu sai ! "," Lỗi");
            }


		}

	}
}
