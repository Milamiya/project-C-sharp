using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tetris
{
	/// <summary>
	/// Descripción breve de Form1.
	/// </summary>
	public class frmGUI : System.Windows.Forms.Form
	{

		private System.Windows.Forms.PictureBox pbPantallaJuego;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components;
		private Tetris t;
		private bool haciaAbajo;
		private bool haciaDerecha;
		private bool rotaDerecha;
		private bool rotaIzquierda;
		private bool enPausa;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Label lblNumLineas;
		private System.Windows.Forms.Label lblNivel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pbPiezaSiguiente;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblPuntuacion;
		private bool haciaIzquierda;

		public frmGUI()
		{
			//
			// Necesario para admitir el Diseñador de Windows Forms
			//
			InitializeComponent();

			//
			// TODO: agregar código de constructor después de llamar a InitializeComponent
			//
		}

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
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

		#region Código generado por el Diseñador de Windows Forms
		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.pbPantallaJuego = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.lblNumLineas = new System.Windows.Forms.Label();
			this.lblNivel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.pbPiezaSiguiente = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblPuntuacion = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pbPantallaJuego
			// 
			this.pbPantallaJuego.BackColor = System.Drawing.Color.Black;
			this.pbPantallaJuego.Location = new System.Drawing.Point(168, 24);
			this.pbPantallaJuego.Name = "pbPantallaJuego";
			this.pbPantallaJuego.Size = new System.Drawing.Size(260, 420);
			this.pbPantallaJuego.TabIndex = 0;
			this.pbPantallaJuego.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Interval = 800;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// lblNumLineas
			// 
			this.lblNumLineas.BackColor = System.Drawing.Color.Black;
			this.lblNumLineas.ForeColor = System.Drawing.Color.White;
			this.lblNumLineas.Location = new System.Drawing.Point(16, 152);
			this.lblNumLineas.Name = "lblNumLineas";
			this.lblNumLineas.TabIndex = 1;
			this.lblNumLineas.Text = "0";
			this.lblNumLineas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblNivel
			// 
			this.lblNivel.BackColor = System.Drawing.Color.Black;
			this.lblNivel.ForeColor = System.Drawing.Color.White;
			this.lblNivel.Location = new System.Drawing.Point(16, 208);
			this.lblNivel.Name = "lblNivel";
			this.lblNivel.TabIndex = 2;
			this.lblNivel.Text = "1";
			this.lblNivel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 192);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Nivel:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 136);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Lineas:";
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem2});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem3,
																					  this.menuItem6,
																					  this.menuItem4});
			this.menuItem1.Text = "Juego";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 0;
			this.menuItem3.Text = "Nuevo";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 1;
			this.menuItem6.Text = "Pausa";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.Text = "Salir";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem5});
			this.menuItem2.Text = "?";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 0;
			this.menuItem5.Text = "Acerca de...";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// pbPiezaSiguiente
			// 
			this.pbPiezaSiguiente.BackColor = System.Drawing.Color.Black;
			this.pbPiezaSiguiente.Location = new System.Drawing.Point(16, 40);
			this.pbPiezaSiguiente.Name = "pbPiezaSiguiente";
			this.pbPiezaSiguiente.Size = new System.Drawing.Size(80, 80);
			this.pbPiezaSiguiente.TabIndex = 7;
			this.pbPiezaSiguiente.TabStop = false;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "Próxima pieza:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 304);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 16);
			this.label4.TabIndex = 9;
			this.label4.Text = "Flecha Arriba -> Rotar";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 320);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(144, 16);
			this.label5.TabIndex = 10;
			this.label5.Text = "Flecha Abajo -> Bajar";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 336);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(144, 16);
			this.label6.TabIndex = 11;
			this.label6.Text = "Flecha Izq     -> Mover Izq";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(8, 352);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(152, 16);
			this.label7.TabIndex = 12;
			this.label7.Text = "Flecha Dcha -> Mover Dcha";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(8, 368);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(132, 12);
			this.label8.TabIndex = 13;
			this.label8.Text = "P                   -> Pausa";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(16, 240);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 16);
			this.label9.TabIndex = 15;
			this.label9.Text = "Puntuación:";
			// 
			// lblPuntuacion
			// 
			this.lblPuntuacion.BackColor = System.Drawing.Color.Black;
			this.lblPuntuacion.ForeColor = System.Drawing.Color.White;
			this.lblPuntuacion.Location = new System.Drawing.Point(16, 256);
			this.lblPuntuacion.Name = "lblPuntuacion";
			this.lblPuntuacion.TabIndex = 14;
			this.lblPuntuacion.Text = "0";
			this.lblPuntuacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// frmGUI
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 473);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.lblPuntuacion);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pbPiezaSiguiente);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblNivel);
			this.Controls.Add(this.lblNumLineas);
			this.Controls.Add(this.pbPantallaJuego);
			this.Menu = this.mainMenu1;
			this.Name = "frmGUI";
			this.Text = "eTetris";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGUI_KeyDown);
			this.Load += new System.EventHandler(this.frmGUI_Load);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmGUI_KeyUp);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Punto de entrada principal de la aplicación.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmGUI());
		}

		private void frmGUI_Load(object sender, System.EventArgs e)
		{
			t = new Tetris();
		}

		private void frmGUI_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			string strKeyPress = null;
			strKeyPress = e.KeyCode.ToString();
			if (!t.juegoTerminado)
			{
				switch(strKeyPress.ToUpper())
				{
					case "LEFT":
						haciaIzquierda = true;
						//t.muevePiezaIzquierda();
						//pintaPantalla(t.matrizPantalla);
						break;
					case "RIGHT":
						haciaDerecha = true;
						//t.muevePiezaDerecha();
						//pintaPantalla(t.matrizPantalla);
						break;
					case "UP":
						rotaDerecha = true;
						//t.rotaPiezaDerecha();
						//pintaPantalla(t.matrizPantalla);
						break;
					case "A":
						rotaIzquierda = true;
						//t.rotaPiezaIzquierda();
						//pintaPantalla(t.matrizPantalla);
						break;
					case "DOWN":
						haciaAbajo = true;
						//t.muevePiezaAbajo();
						//pintaPantalla(t.matrizPantalla);
						break;
					case "P":
						pausaJuego();
						break;
					default:
						//MessageBox.Show(strKeyPress.ToUpper());
						break;
				}
			}
			else
			{
				switch(strKeyPress.ToUpper())
				{
					case "ENTER":

						break;
					default:
						break;
				}
			}
		}

		private void frmGUI_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			string strKeyPress = null;
			strKeyPress = e.KeyCode.ToString();
			if (!t.juegoTerminado)
			{
				switch(strKeyPress.ToUpper())
				{
					case "LEFT":
						haciaIzquierda = false;
						break;
					case "RIGHT":
						haciaDerecha = false;
						break;
					case "DOWN":
						haciaAbajo = false;
						break;
					case "UP":
						rotaDerecha = false;
						break;
					case "A":
						rotaIzquierda = false;
						break;
					default:
						//MessageBox.Show(strKeyPress.ToUpper());
						break;
				}
			}
		}

		public void pintaPantalla(int [, ] matrizPantalla)
		{
			Bitmap B = new Bitmap(pbPantallaJuego.Width, pbPantallaJuego.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
			Graphics G = Graphics.FromImage(B);
			G.Clear(Color.Black);
			for (int x = 0; x < Constantes.COLUMNAS_PANTALLA; x++)
			{
				for (int y = 0; y < Constantes.FILAS_PANTALLA; y++)
				{
					int elemento = matrizPantalla[y, x];
					if (elemento != 0)
					{
						dibujaCuadro(G, y, x, Constantes.COLORES(elemento - 1));
					}
				}
			}
			pbPantallaJuego.Image = B;
		}
		
		public void pintaPiezaSiguiente(Pieza p)
		{
			Bitmap B = new Bitmap(pbPiezaSiguiente.Width, pbPiezaSiguiente.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
			Graphics G = Graphics.FromImage(B);
			G.Clear(Color.Black);
			for (int x = 0; x < Constantes.COLUMNAS_PIEZAS; x++)
			{
				for (int y = 0; y < Constantes.FILAS_PIEZAS; y++)
				{
					int elemento = t.piezaSiguiente[y, x];
					if (elemento != 0)
					{
						dibujaCuadro(G, y, x, Constantes.COLORES(t.piezaSiguiente.color - 1));
					}
				}
			}
			pbPiezaSiguiente.Image = B;
		}

		private void dibujaCuadro(Graphics G, int Y,int X, Color C)
		{
			int x = (X * Constantes.ANCHO_CELDA) + 1;
			int y = (Y * Constantes.ALTO_CELDA) + 1;
			SolidBrush Br = new SolidBrush(C);
			G.FillRectangle(Br, x, y, Constantes.ANCHO_CELDA - 2, Constantes.ALTO_CELDA - 2);
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if (t.numLineas < Constantes.NUM_LINEAS_POR_NIVEL)
			{
				lblNumLineas.Text = t.numLineas.ToString();
				lblPuntuacion.Text = t.puntuacion.ToString();
				if (haciaAbajo)
					actualizaPantalla();
				else
				{
					haciaAbajo = true;
					actualizaPantalla();
					haciaAbajo = false;
				}
				pintaPiezaSiguiente(t.piezaSiguiente);
				if (t.juegoTerminado)
				{
					timer1.Stop();
					MessageBox.Show("Se terminó el juego");
				}
			}
		}

		private void timer2_Tick(object sender, System.EventArgs e)
		{
			if (t.numLineas < Constantes.NUM_LINEAS_POR_NIVEL)
			{
				actualizaPantalla();
			}
			else
			{
				timer2.Stop();
				timer1.Stop();
				lblNumLineas.Text = t.numLineas.ToString();
				lblPuntuacion.Text = t.puntuacion.ToString();
				inicializaTeclas();
				t.nuevoNivel();
				MessageBox.Show("¡¡Enhorabuena!! Has pasado al nivel " + (t.nivel + 1));
				lblNivel.Text = ((int)t.nivel + 1).ToString();
				timer1.Interval = Constantes.NIVELES(t.nivel);
				timer2.Start();
				timer1.Start();		
			}
			if (t.juegoTerminado)
			{
				timer2.Stop();
			}
		}

		private void actualizaPantalla()
		{
			if (haciaAbajo)
			{
				t.muevePiezaAbajo();
			}
			if (haciaDerecha)
			{
				t.muevePiezaDerecha();
			}
			if (haciaIzquierda)
			{
				t.muevePiezaIzquierda();
			}
			if (rotaDerecha)
			{
				t.rotaPiezaDerecha();
				rotaDerecha = false;
			}	
			if (rotaIzquierda)
			{
				t.rotaPiezaIzquierda();
				rotaIzquierda = false;
			}
			
			pintaPantalla(t.matrizPantalla);		
		}

		private void inicializaTeclas()
		{
			haciaDerecha = false;
			haciaIzquierda = false;
			rotaDerecha = false;
			rotaIzquierda = false;
			haciaAbajo = false;
			enPausa = false;
		}

		private void nuevoJuego()
		{
			inicializaTeclas();
			t.nuevoJuego();
			lblPuntuacion.Text = "0";
			lblNivel.Text = "1";
			timer1.Interval = Constantes.NIVELES(t.nivel);
			pintaPantalla(t.matrizPantalla);
			timer1.Start();
			timer2.Start();
		}

		private void pausaJuego()
		{
			if (!t.juegoTerminado)
			{
				if (!enPausa)
				{
					timer1.Stop();
					timer2.Stop();
				}
				else
				{
					timer1.Start();
					timer2.Start();
				}
				enPausa = !enPausa;
			}
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			nuevoJuego();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			enPausa = false;
			pausaJuego();
			AcercaDe a = new AcercaDe();
			a.ShowDialog();
			a.Dispose();
			enPausa = true;
			pausaJuego();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			pausaJuego();
		}

	}
}
