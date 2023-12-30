using System;
using System.Windows.Forms;

namespace Tetris
{
	/// <summary>
	/// Descripción breve de Juego.
	/// </summary>
	public class Juego
	{
		public static void Main()
		{
			if ( !Utiles.ResolucionCorrecta(800, 600) )
			{
				MessageBox.Show("Para ejecutar el juego, debe tener como mínimo una resolución de 800 x 600");
			}
			else
			{
				frmGUI f = new frmGUI();
				f.ShowDialog();
				f.Dispose();
			}

		}
	}
}
