using System;
using System.Windows.Forms;
using QLHocSinhTHPT.Reports;
using QLHocSinhTHPT.Component;

namespace QLHocSinhTHPT
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
            Application.Run(new frmMain());
        }
    }
}