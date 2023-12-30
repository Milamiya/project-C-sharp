using System;
using System.Drawing;

namespace Tetris
{
	/// <summary>
	/// Descripción breve de Constantes.
	/// </summary>
	public class Constantes
	{
		public const int FILAS_PIEZAS = 4;
		public const int COLUMNAS_PIEZAS = 4;
		public const int NUM_PIEZAS = 7;
		public const int NUM_ROTACIONES = 4;
		public const int FILAS_PANTALLA = 21;
		public const int COLUMNAS_PANTALLA = 13;
		public const int ANCHO_CELDA = 20;
		public const int ALTO_CELDA = 20;
		public const int NUM_LINEAS_POR_NIVEL = 20;

		private static Color [] m_COLORES = new Color[7]{Color.Red, Color.Blue, Color.DarkOrange, Color.DeepPink, Color.Violet, Color.Beige, Color.DarkMagenta};

		private static int [] m_NIVELES = new int[10]{1000, 800, 640, 512, 410, 328, 262, 210, 168, 134};


		public static Color COLORES(int color)
		{
			return m_COLORES[color];
		}

		public static int NIVELES(int nivel)
		{
			return m_NIVELES[nivel];
		}
	}
}
