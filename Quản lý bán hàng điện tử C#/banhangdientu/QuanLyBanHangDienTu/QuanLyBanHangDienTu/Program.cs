using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuanLyBanHangDienTu.Presentation;

namespace QuanLyBanHangDienTu
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
            Application.Run(new fr_Splash_Screen());
        }
    }
}
