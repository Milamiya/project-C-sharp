/**********************************/
/*                                */
/* Author: BUI VAN NGHIA          */
/* Email: katatunix@yahoo.com     */
/*                 [May, 2008]    */
/*                                */
/**********************************/

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lines2008
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}