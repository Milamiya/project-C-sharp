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
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Drawing.Bitmap m_Bitmap;
		private System.Drawing.Bitmap m_Undo;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem FileLoad;
		private System.Windows.Forms.MenuItem FileSave;
		private System.Windows.Forms.MenuItem FileExit;
		private System.Windows.Forms.MenuItem FilterInvert;
		private System.Windows.Forms.MenuItem FilterGrayScale;
		private System.Windows.Forms.MenuItem FilterBrightness;
		private System.Windows.Forms.MenuItem FilterContrast;
		private System.Windows.Forms.MenuItem FilterGamma;
		private System.Windows.Forms.MenuItem FilterColor;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem Zoom25;
		private double Zoom = 1.0;
		private System.Windows.Forms.MenuItem Zoom50;
		private System.Windows.Forms.MenuItem Zoom100;
		private System.Windows.Forms.MenuItem Zoom150;
		private System.Windows.Forms.MenuItem Zoom200;
		private System.Windows.Forms.MenuItem Zoom300;
		private System.Windows.Forms.MenuItem Zoom500;
		private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem FilterSmooth;
		private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem Undo;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem EdgeKirsh;
		private System.Windows.Forms.MenuItem EdgePrewitt;
		private System.Windows.Forms.MenuItem EdgeSobell;
		private System.Windows.Forms.MenuItem EdgeDetectHorizontal;
        private System.Windows.Forms.MenuItem EdgeVertical;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem FlipHorz;
		private System.Windows.Forms.MenuItem flipVert;
        private System.Windows.Forms.MenuItem flipBoth;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem swirlNormal;
		private System.Windows.Forms.MenuItem swirlAntiAlias;
		private System.Windows.Forms.MenuItem Sphere;
		private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem sphereAntialias;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem waterNormal;
        private System.Windows.Forms.MenuItem waterAntialias;
        private IContainer components;

		public Form1()
		{
			InitializeComponent();

			m_Bitmap= new Bitmap(2, 2);
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.FileLoad = new System.Windows.Forms.MenuItem();
            this.FileSave = new System.Windows.Forms.MenuItem();
            this.FileExit = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.Undo = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.FilterInvert = new System.Windows.Forms.MenuItem();
            this.FilterGrayScale = new System.Windows.Forms.MenuItem();
            this.FilterBrightness = new System.Windows.Forms.MenuItem();
            this.FilterContrast = new System.Windows.Forms.MenuItem();
            this.FilterGamma = new System.Windows.Forms.MenuItem();
            this.FilterColor = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.FilterSmooth = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.EdgeKirsh = new System.Windows.Forms.MenuItem();
            this.EdgePrewitt = new System.Windows.Forms.MenuItem();
            this.EdgeSobell = new System.Windows.Forms.MenuItem();
            this.EdgeDetectHorizontal = new System.Windows.Forms.MenuItem();
            this.EdgeVertical = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.Zoom25 = new System.Windows.Forms.MenuItem();
            this.Zoom50 = new System.Windows.Forms.MenuItem();
            this.Zoom100 = new System.Windows.Forms.MenuItem();
            this.Zoom150 = new System.Windows.Forms.MenuItem();
            this.Zoom200 = new System.Windows.Forms.MenuItem();
            this.Zoom300 = new System.Windows.Forms.MenuItem();
            this.Zoom500 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.FlipHorz = new System.Windows.Forms.MenuItem();
            this.flipVert = new System.Windows.Forms.MenuItem();
            this.flipBoth = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.swirlNormal = new System.Windows.Forms.MenuItem();
            this.swirlAntiAlias = new System.Windows.Forms.MenuItem();
            this.Sphere = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.sphereAntialias = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.waterNormal = new System.Windows.Forms.MenuItem();
            this.waterAntialias = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem5,
            this.menuItem4,
            this.menuItem3,
            this.menuItem6,
            this.menuItem2,
            this.menuItem8});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FileLoad,
            this.FileSave,
            this.FileExit});
            this.menuItem1.Text = "File";
            // 
            // FileLoad
            // 
            this.FileLoad.Index = 0;
            this.FileLoad.Shortcut = System.Windows.Forms.Shortcut.CtrlL;
            this.FileLoad.Text = "Load";
            this.FileLoad.Click += new System.EventHandler(this.File_Load);
            // 
            // FileSave
            // 
            this.FileSave.Index = 1;
            this.FileSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.FileSave.Text = "Save";
            this.FileSave.Click += new System.EventHandler(this.File_Save);
            // 
            // FileExit
            // 
            this.FileExit.Index = 2;
            this.FileExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.FileExit.Text = "Exit";
            this.FileExit.Click += new System.EventHandler(this.File_Exit);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 1;
            this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Undo});
            this.menuItem5.Text = "Edit";
            // 
            // Undo
            // 
            this.Undo.Index = 0;
            this.Undo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.Undo.Text = "Undo";
            this.Undo.Click += new System.EventHandler(this.OnUndo);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FilterInvert,
            this.FilterGrayScale,
            this.FilterBrightness,
            this.FilterContrast,
            this.FilterGamma,
            this.FilterColor});
            this.menuItem4.Text = "Filter";
            // 
            // FilterInvert
            // 
            this.FilterInvert.Index = 0;
            this.FilterInvert.Text = "Invert";
            this.FilterInvert.Click += new System.EventHandler(this.Filter_Invert);
            // 
            // FilterGrayScale
            // 
            this.FilterGrayScale.Index = 1;
            this.FilterGrayScale.Text = "GrayScale";
            this.FilterGrayScale.Click += new System.EventHandler(this.Filter_GrayScale);
            // 
            // FilterBrightness
            // 
            this.FilterBrightness.Index = 2;
            this.FilterBrightness.Text = "Brightness";
            this.FilterBrightness.Click += new System.EventHandler(this.Filter_Brightness);
            // 
            // FilterContrast
            // 
            this.FilterContrast.Index = 3;
            this.FilterContrast.Text = "Contrast";
            this.FilterContrast.Click += new System.EventHandler(this.Filter_Contrast);
            // 
            // FilterGamma
            // 
            this.FilterGamma.Index = 4;
            this.FilterGamma.Text = "Gamma";
            // 
            // FilterColor
            // 
            this.FilterColor.Index = 5;
            this.FilterColor.Text = "Color";
            this.FilterColor.Click += new System.EventHandler(this.Filter_Color);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 3;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FilterSmooth});
            this.menuItem3.Text = "Convolution";
            // 
            // FilterSmooth
            // 
            this.FilterSmooth.Index = 0;
            this.FilterSmooth.Text = "Smooth";
            this.FilterSmooth.Click += new System.EventHandler(this.OnFilterSmooth);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 4;
            this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.EdgeKirsh,
            this.EdgePrewitt,
            this.EdgeSobell,
            this.EdgeDetectHorizontal,
            this.EdgeVertical});
            this.menuItem6.Text = "Edge Detection";
            // 
            // EdgeKirsh
            // 
            this.EdgeKirsh.Index = 0;
            this.EdgeKirsh.Text = "Kirsh";
            this.EdgeKirsh.Click += new System.EventHandler(this.OnEdgeKirsh);
            // 
            // EdgePrewitt
            // 
            this.EdgePrewitt.Index = 1;
            this.EdgePrewitt.Text = "Prewitt";
            this.EdgePrewitt.Click += new System.EventHandler(this.OnEdgePrewitt);
            // 
            // EdgeSobell
            // 
            this.EdgeSobell.Index = 2;
            this.EdgeSobell.Text = "Sobel";
            this.EdgeSobell.Click += new System.EventHandler(this.OnEdgeSobell);
            // 
            // EdgeDetectHorizontal
            // 
            this.EdgeDetectHorizontal.Index = 3;
            this.EdgeDetectHorizontal.Text = "Horizontal";
            this.EdgeDetectHorizontal.Click += new System.EventHandler(this.OnEdgeHorizontal);
            // 
            // EdgeVertical
            // 
            this.EdgeVertical.Index = 4;
            this.EdgeVertical.Text = "Vertical";
            this.EdgeVertical.Click += new System.EventHandler(this.OnEdgeVertical);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 5;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.Zoom25,
            this.Zoom50,
            this.Zoom100,
            this.Zoom150,
            this.Zoom200,
            this.Zoom300,
            this.Zoom500});
            this.menuItem2.Text = "Zoom";
            // 
            // Zoom25
            // 
            this.Zoom25.Index = 0;
            this.Zoom25.Text = "25%";
            this.Zoom25.Click += new System.EventHandler(this.OnZoom25);
            // 
            // Zoom50
            // 
            this.Zoom50.Index = 1;
            this.Zoom50.Text = "50%";
            this.Zoom50.Click += new System.EventHandler(this.OnZoom50);
            // 
            // Zoom100
            // 
            this.Zoom100.Index = 2;
            this.Zoom100.Text = "100%";
            this.Zoom100.Click += new System.EventHandler(this.OnZoom100);
            // 
            // Zoom150
            // 
            this.Zoom150.Index = 3;
            this.Zoom150.Text = "150%";
            this.Zoom150.Click += new System.EventHandler(this.OnZoom150);
            // 
            // Zoom200
            // 
            this.Zoom200.Index = 4;
            this.Zoom200.Text = "200%";
            this.Zoom200.Click += new System.EventHandler(this.OnZoom200);
            // 
            // Zoom300
            // 
            this.Zoom300.Index = 5;
            this.Zoom300.Text = "300%";
            this.Zoom300.Click += new System.EventHandler(this.OnZoom300);
            // 
            // Zoom500
            // 
            this.Zoom500.Index = 6;
            this.Zoom500.Text = "500%";
            this.Zoom500.Click += new System.EventHandler(this.OnZoom500);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 6;
            this.menuItem8.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem9,
            this.menuItem10,
            this.Sphere,
            this.menuItem13});
            this.menuItem8.Text = "Displacement Filters";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 0;
            this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.FlipHorz,
            this.flipVert,
            this.flipBoth});
            this.menuItem9.Text = "Flip";
            // 
            // FlipHorz
            // 
            this.FlipHorz.Index = 0;
            this.FlipHorz.Text = "Horz";
            this.FlipHorz.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // flipVert
            // 
            this.flipVert.Index = 1;
            this.flipVert.Text = "Vert";
            this.flipVert.Click += new System.EventHandler(this.flipVert_Click);
            // 
            // flipBoth
            // 
            this.flipBoth.Index = 2;
            this.flipBoth.Text = "Both";
            this.flipBoth.Click += new System.EventHandler(this.flipBoth_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 1;
            this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.swirlNormal,
            this.swirlAntiAlias});
            this.menuItem10.Text = "Swirl";
            // 
            // swirlNormal
            // 
            this.swirlNormal.Index = 0;
            this.swirlNormal.Text = "Normal";
            this.swirlNormal.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // swirlAntiAlias
            // 
            this.swirlAntiAlias.Index = 1;
            this.swirlAntiAlias.Text = "AntiAlias";
            this.swirlAntiAlias.Click += new System.EventHandler(this.swirlAntiAlias_Click);
            // 
            // Sphere
            // 
            this.Sphere.Index = 2;
            this.Sphere.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem11,
            this.sphereAntialias});
            this.Sphere.Text = "Sphere";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 0;
            this.menuItem11.Text = "Normal";
            this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click_1);
            // 
            // sphereAntialias
            // 
            this.sphereAntialias.Index = 1;
            this.sphereAntialias.Text = "Antialias";
            this.sphereAntialias.Click += new System.EventHandler(this.sphereAntialias_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 3;
            this.menuItem13.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.waterNormal,
            this.waterAntialias});
            this.menuItem13.Text = "Water";
            // 
            // waterNormal
            // 
            this.waterNormal.Index = 0;
            this.waterNormal.Text = "Normal";
            this.waterNormal.Click += new System.EventHandler(this.waterNormal_Click);
            // 
            // waterAntialias
            // 
            this.waterAntialias.Index = 1;
            this.waterAntialias.Text = "AntiAlias";
            this.waterAntialias.Click += new System.EventHandler(this.waterAntialias_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(512, 364);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Graphic Filters By C6Tin-EPU";
            this.Load += new System.EventHandler(this.Form1_Load);
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

		protected override void OnPaint (PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			g.DrawImage(m_Bitmap, new Rectangle(this.AutoScrollPosition.X, this.AutoScrollPosition.Y, (int)(m_Bitmap.Width*Zoom), (int)(m_Bitmap.Height * Zoom)));
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
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

		private void Filter_Invert(object sender, System.EventArgs e)
		{
			m_Undo = (Bitmap)m_Bitmap.Clone();
			if(BitmapFilter.Invert(m_Bitmap))
				this.Invalidate();
		}

		private void Filter_GrayScale(object sender, System.EventArgs e)
		{
			m_Undo = (Bitmap)m_Bitmap.Clone();
			if(BitmapFilter.GrayScale(m_Bitmap))
				this.Invalidate();
		}

		private void Filter_Brightness(object sender, System.EventArgs e)
		{
			Parameter dlg = new Parameter();
			dlg.nValue = 0;

			if (DialogResult.OK == dlg.ShowDialog())
			{
				m_Undo = (Bitmap)m_Bitmap.Clone();
				if(BitmapFilter.Brightness(m_Bitmap, dlg.nValue))
					this.Invalidate();
			}
		}

		private void Filter_Contrast(object sender, System.EventArgs e)
		{
			Parameter dlg = new Parameter();
			dlg.nValue = 0;

			if (DialogResult.OK == dlg.ShowDialog())
			{
				m_Undo = (Bitmap)m_Bitmap.Clone();
				if(BitmapFilter.Contrast(m_Bitmap, (sbyte)dlg.nValue))
					this.Invalidate();
			}
		
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

		private void OnZoom25(object sender, System.EventArgs e)
		{
			Zoom = .25;
			this.AutoScrollMinSize = new Size ((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
			this.Invalidate();
		}

		private void OnZoom50(object sender, System.EventArgs e)
		{
			Zoom = .5;
			this.AutoScrollMinSize = new Size ((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
			this.Invalidate();
		}

		private void OnZoom100(object sender, System.EventArgs e)
		{
			Zoom = 1.0;
			this.AutoScrollMinSize = new Size ((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
			this.Invalidate();
		}

		private void OnZoom150(object sender, System.EventArgs e)
		{
			Zoom = 1.5;
			this.AutoScrollMinSize = new Size ((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
			this.Invalidate();
		}

		private void OnZoom200(object sender, System.EventArgs e)
		{
			Zoom = 2.0;
			this.AutoScrollMinSize = new Size ((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
			this.Invalidate();
		}

		private void OnZoom300(object sender, System.EventArgs e)
		{
			Zoom = 3.0;
			this.AutoScrollMinSize = new Size ((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
			this.Invalidate();
		}

		private void OnZoom500(object sender, System.EventArgs e)
		{
			Zoom = 5;
			this.AutoScrollMinSize = new Size ((int)(m_Bitmap.Width * Zoom), (int)(m_Bitmap.Height * Zoom));
			this.Invalidate();
		}

		private void OnFilterSmooth(object sender, System.EventArgs e)
		{
			m_Undo = (Bitmap)m_Bitmap.Clone();
			if(BitmapFilter.Smooth(m_Bitmap, 1))
				this.Invalidate();
		}	

		private void OnUndo(object sender, System.EventArgs e)
		{
			Bitmap temp = (Bitmap)m_Bitmap.Clone();
			m_Bitmap = (Bitmap)m_Undo.Clone();
			m_Undo = (Bitmap)temp.Clone();
			this.Invalidate();
		}

		

		private void OnEdgeKirsh(object sender, System.EventArgs e)
		{
			Parameter dlg = new Parameter();
			dlg.nValue = 0;

			if (DialogResult.OK == dlg.ShowDialog())
			{
				m_Undo = (Bitmap)m_Bitmap.Clone();
				if(BitmapFilter.EdgeDetectConvolution(m_Bitmap, BitmapFilter.EDGE_DETECT_KIRSH,  (byte)dlg.nValue))
					this.Invalidate();
			}		
		}

		private void OnEdgePrewitt(object sender, System.EventArgs e)
		{
			Parameter dlg = new Parameter();
			dlg.nValue = 0;

			if (DialogResult.OK == dlg.ShowDialog())
			{
				m_Undo = (Bitmap)m_Bitmap.Clone();
				if(BitmapFilter.EdgeDetectConvolution(m_Bitmap, BitmapFilter.EDGE_DETECT_PREWITT,  (byte)dlg.nValue))
					this.Invalidate();
			}		
		}

		private void OnEdgeSobell(object sender, System.EventArgs e)
		{
			Parameter dlg = new Parameter();
			dlg.nValue = 0;

			if (DialogResult.OK == dlg.ShowDialog())
			{
				m_Undo = (Bitmap)m_Bitmap.Clone();
				if(BitmapFilter.EdgeDetectConvolution(m_Bitmap, BitmapFilter.EDGE_DETECT_SOBEL,  (byte)dlg.nValue))
					this.Invalidate();
			}		
		}

		private void OnEdgeHorizontal(object sender, System.EventArgs e)
		{
			m_Undo = (Bitmap)m_Bitmap.Clone();
			if(BitmapFilter.EdgeDetectHorizontal(m_Bitmap))
				this.Invalidate();
		}

		private void OnEdgeVertical(object sender, System.EventArgs e)
		{
			m_Undo = (Bitmap)m_Bitmap.Clone();
			if(BitmapFilter.EdgeDetectVertical(m_Bitmap))
				this.Invalidate();
		}

		
		
		
		
		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			m_Undo = (Bitmap)m_Bitmap.Clone();
			if (BitmapFilter.Flip(m_Bitmap, true, false))
				this.Invalidate();
		}

		private void flipVert_Click(object sender, System.EventArgs e)
		{
			m_Undo = (Bitmap)m_Bitmap.Clone();
			if (BitmapFilter.Flip(m_Bitmap, false, true))
				this.Invalidate();
		}

		private void flipBoth_Click(object sender, System.EventArgs e)
		{
			m_Undo = (Bitmap)m_Bitmap.Clone();
			if (BitmapFilter.Flip(m_Bitmap, true, true))
				this.Invalidate();		
		}

		

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			m_Undo = (Bitmap)m_Bitmap.Clone();
			if (BitmapFilter.Swirl(m_Bitmap, .04, false))
				this.Invalidate();					
		}

		private void swirlAntiAlias_Click(object sender, System.EventArgs e)
		{
			m_Undo = (Bitmap)m_Bitmap.Clone();
			if (BitmapFilter.Swirl(m_Bitmap, .04, true))
				this.Invalidate();							
		}

		private void menuItem11_Click_1(object sender, System.EventArgs e)
		{
			m_Undo = (Bitmap)m_Bitmap.Clone();
			if (BitmapFilter.Sphere(m_Bitmap, false))
				this.Invalidate();							
		}

		private void sphereAntialias_Click(object sender, System.EventArgs e)
		{
			m_Undo = (Bitmap)m_Bitmap.Clone();
			if (BitmapFilter.Sphere(m_Bitmap, true))
				this.Invalidate();							
		}

		
		private void waterNormal_Click(object sender, System.EventArgs e)
		{
			m_Undo = (Bitmap)m_Bitmap.Clone();
			if (BitmapFilter.Water(m_Bitmap, 15, false))
				this.Invalidate();							
		}

		private void waterAntialias_Click(object sender, System.EventArgs e)
		{
			m_Undo = (Bitmap)m_Bitmap.Clone();
			if (BitmapFilter.Water(m_Bitmap, 15, false))
				this.Invalidate();									
		}

		
	}
}

