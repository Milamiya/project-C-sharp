using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;


namespace FirstConnectDB
{
    [RunInstaller(true)]
    public partial class Installer : System.Configuration.Install.Installer 
    {
        public Installer()
        {
            InitializeComponent();
        }
        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]
        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);
            
        }

        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]
        protected override void OnAfterInstall(IDictionary savedState)
        {
            base.OnAfterInstall(savedState);
           // var t = new Thread(ShowFirstConnection);
           //t.SetApartmentState(ApartmentState.STA);
           // t.Start();
           // ShowFirstConnection();


           // Directory.SetCurrentDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
           // Process.Start(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\QLHS.exe");

        }

        private void ShowFirstConnection()
        {
            var frm = new FrmAddConnection {TopMost = true, AllowDrop = true};
            frm.ShowDialog();
        }


        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]
        public override void Commit(IDictionary savedState)
        {
            base.Commit(savedState);
        }

        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]
        public override void Rollback(IDictionary savedState)
        {
            base.Rollback(savedState);
        }

        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]
        public override void Uninstall(IDictionary savedState)
        {
            base.Uninstall(savedState);
        }
    }

}
