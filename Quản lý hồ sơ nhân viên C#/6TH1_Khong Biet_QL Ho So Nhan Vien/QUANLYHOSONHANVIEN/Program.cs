using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QUANLYHOSONHANVIEN.GiaoDien;
using QUANLYHOSONHANVIEN.Report;

namespace QUANLYHOSONHANVIEN
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
            Application.Run(new frmWellcom());
            Application.Run(new frmMainChinh());
            //////Application.Run(new frmNguoiDung());
           // Application.Run(new frmThongTinNhanSu());
            //Application.Run(new frmThemCongViec());
            //Application.Run(new frmBaoCao());
            //Application.Run(new frmDanhSachDanhMuc());
        }
    }
}
