using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lop1_GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frm1LamMauMe f = new frm1LamMauMe();
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                Application.Run(new frm2HienThiChinh());
            }
        }
    }
}
