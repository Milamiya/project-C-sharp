using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ShutdownManager.Modules
{
    public class LockComputer
    {
        //Import Windows API library
        [DllImport("user32.dll")]
        public static extern void LockWorkStation();

        [DllImport("user32.dll")]
        public static extern int ExitWindowsEx(int uFlags, int dwReason);

        //Khoá Máy
        public void Lock()
        {
            LockWorkStation();
        }

        //Lof Off
        public void LogOff()
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn Có Muốn Log Off Máy Không ?", "Log Off", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                ExitWindowsEx(0, 0);
            }
        }
        
        //Reboot
        public void Reboot()
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn Có Muốn Khởi Động Lại Máy Không ?", "Reboot", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                ExitWindowsEx(2, 0);
            }
        }

        //ShutDown
        public void Shutdown()
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn Có Muốn Tắt Máy Không ?", "Shutdown", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                ExitWindowsEx(1, 0);
            }
        }

        //Force LogOff
        public void ForceLogOff()
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn Có Muốn Ép Buộc Máy Log Off Không ?", "ForceLogOff", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                ExitWindowsEx(4, 0);
            }
        }

        //Hibernate
        public void Hibernate()
        {
            Application.SetSuspendState(PowerState.Hibernate, true, true);
        }

        //Stand By
        public void StandBy()
        {
            Application.SetSuspendState(PowerState.Suspend, true, true);
        }
    }
}
