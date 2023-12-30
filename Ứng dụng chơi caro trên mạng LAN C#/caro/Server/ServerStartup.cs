using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Server
{
    static class ServerStartup
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static ServerForm sf;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            sf = new ServerForm();
            Application.Run(sf);
        }
    }
}
