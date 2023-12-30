using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CSharpFilters
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		private Bitmap m_Bitmap;
		private Bitmap m_Undo;
		private MainMenu mainMenu1;
		private MenuItem menuItem1;
		private MenuItem menuItem4;
		private MenuItem FileLoad;
		private MenuItem FileSave;
        private MenuItem FileExit;
        private MenuItem FilterGrayScale;
        private MenuItem FilterColor;
        private double Zoom = 1.0;
        private MenuItem menuItem3;
		private MenuItem EmbossLaplacian;
        private MenuItem EdgeDetectQuick;
        private IContainer components;

		public frmMain()
		{
			InitializeComponent();

			m_Bitmap= new Bitmap(2, 2);
		}
        //Download source code tại Sharecode.vn
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
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.FileLoad = new System.Windows.Forms.MenuItem();
            this.FileSave = new System.Windows.Forms.MenuItem();
            this.FileExit = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.FilterGrayScale = new System.Windows.Forms.MenuItem();
            this.FilterColor = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.EmbossLaplacian = new System.Windows.Forms.MenuItem();
            this.EdgeDetectQuick = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem4,
            this.menuItem3});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FileLoad,
            this.FileSave,
            this.FileExit});
            this.menuItem1.Text = "File";
            //this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // FileLoad
            // 
            this.FileLoad.Index = 0;
            this.FileLoad.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.FileLoad.Text = "Mở file";
            this.FileLoad.Click += new System.EventHandler(this.File_Load);
            // 
            // FileSave
            // 
            this.FileSave.Index = 1;
            this.FileSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.FileSave.Text = "Lưu file";
            this.FileSave.Click += new System.EventHandler(this.File_Save);
            // 
            // FileExit
            // 
            this.FileExit.Index = 2;
            this.FileExit.Text = "Thoát";
            this.FileExit.Click += new System.EventHandler(this.File_Exit);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FilterGrayScale,
            this.FilterColor});
            this.menuItem4.Text = "Biến đổi màu";
            // 
            // FilterGrayScale
            // 
            this.FilterGrayScale.Index = 0;
            this.FilterGrayScale.Text = "Xám";
            this.FilterGrayScale.Click += new System.EventHandler(this.Filter_GrayScale);
            // 
            // FilterColor
            // 
            this.FilterColor.Index = 1;
            this.FilterColor.Text = "Màu";
            this.FilterColor.Click += new System.EventHandler(this.Filter_Color);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.EmbossLaplacian,
            this.EdgeDetectQuick});
            this.menuItem3.Text = "Phát hiện biên";
            //this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // EmbossLaplacian
            // 
            this.EmbossLaplacian.Index = 0;
            this.EmbossLaplacian.Text = "Laplacian_Emboss";
            this.EmbossLaplacian.Click += new System.EventHandler(this.OnEmbossLaplacian);
            // 
            // EdgeDetectQuick
            // 
            this.EdgeDetectQuick.Index = 1;
            this.EdgeDetectQuick.Text = "EdgeDetectQuick";
            this.EdgeDetectQuick.Click += new System.EventHandler(this.OnEdgeDetectQuick);
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::CSharpFilters.Properties.Resources.Daewoo;
            this.ClientSize = new System.Drawing.Size(349, 237);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xu ly anh";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawImage(m_Bitmap, new Rectangle(this.AutoScrollPosition.X, this.AutoScrollPosition.Y, (int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom)));
        }

		private void File_Load(object sender, System.EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();

			openFileDialog.InitialDirectory = "c:\\" ;
			openFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All valid files (*.bmp/*.jpg)|*.bmp/*.jpg";
			openFileDialog.FilterIndex = 2 ;
			openFileDialog.RestoreDirectory = true ;

			if(DialogResult.OK == openFileDialog.ShowDialog())
			{
				m_Bitmap = (Bitmap)Bitmap.FromFile(openFileDialog.FileName, false);
				this.AutoScroll = true;
				this.AutoScrollMinSize = new Size ((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
				this.Invalidate();
			}
		}

		private void File_Save(object sender, System.EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();

			saveFileDialog.InitialDirectory = "c:\\" ;
			saveFileDialog.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg|All valid files (*.bmp/*.jpg)|*.bmp/*.jpg" ;
			saveFileDialog.FilterIndex = 1 ;
			saveFileDialog.RestoreDirectory = true ;

			if(DialogResult.OK == saveFileDialog.ShowDialog())
			{
				m_Bitmap.Save(saveFileDialog.FileName);
			}
		}

		private void File_Exit(object sender, System.EventArgs e)
		{
			this.Close();
		}


		private void Filter_GrayScale(object sender, System.EventArgs e)
		{
			m_Undo = (Bitmap)m_Bitmap.Clone();
			if(BitmapFilter.GrayScale(m_Bitmap))
				this.Invalidate();
		}
		private void Filter_Color(object sender, System.EventArgs e)
		{
			ColorInput dlg = new ColorInput();
			dlg.red = dlg.green = dlg.blue = 0;

			if (DialogResult.OK == dlg.ShowDialog())
			{
				m_Undo = (Bitmap)m_Bitmap.Clone();
				if(BitmapFilter.Color(m_Bitmap, dlg.red, dlg.green, dlg.blue))
					this.Invalidate();
			}
		
		}

        

		private void OnEmbossLaplacian(object sender, System.EventArgs e)
		{
			m_Undo = (Bitmap)m_Bitmap.Clone();
			if(BitmapFilter.EmbossLaplacian(m_Bitmap))
				this.Invalidate();
		}

		private void OnEdgeDetectQuick(object sender, System.EventArgs e)
		{
			m_Undo = (Bitmap)m_Bitmap.Clone();
			if(BitmapFilter.EdgeDetectQuick(m_Bitmap))
				this.Invalidate();
		}

		private void OnUndo(object sender, System.EventArgs e)
		{
			Bitmap temp = (Bitmap)m_Bitmap.Clone();
			m_Bitmap = (Bitmap)m_Undo.Clone();
			m_Undo = (Bitmap)temp.Clone();
			this.Invalidate();
		}

     

	}
}

