using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using BaoCaoThongKe.Controller;
using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.Controller
{
    public class Doimatkhau_Ctrl
    {
        NguoiDung_Ctrl nd = new NguoiDung_Ctrl();
        Doimatkhau_Data doiMK = new Doimatkhau_Data();
        public bool KiemTra(string user, string pass_old, string pass_new, string pass_prenew)
        {
            if (user == "")
            {
                System.Windows.Forms.MessageBox.Show("Chưa nhập tên đăng nhập !", "Chú ý", System.Windows.Forms.MessageBoxButtons.YesNo);
                return false;
            }
            if (pass_old == "")
            {
                System.Windows.Forms.MessageBox.Show("Chưa nhập mật khẩu cũ !", "Chú ý", System.Windows.Forms.MessageBoxButtons.YesNo);
                return false;
            }
            if (pass_new == "")
            {
                System.Windows.Forms.MessageBox.Show("Chưa nhập mật khẩu mới !", "Chú ý", System.Windows.Forms.MessageBoxButtons.YesNo);
                return false;
            }
            if (pass_prenew == "")
            {
                System.Windows.Forms.MessageBox.Show("Nhập lại mật khẩu mới !", "Chú ý", System.Windows.Forms.MessageBoxButtons.YesNo);
                return false;
            }

            if (doiMK.LayNguoiDung(user, pass_old))
            {
                if (!(pass_new == pass_prenew))
                {
                    System.Windows.Forms.MessageBox.Show("Mật khẩu không trùng nhau !", "Chú ý", System.Windows.Forms.MessageBoxButtons.YesNo);
                    return false;
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Tên đăng nhập và mật khẩu cũ không đúng !", "Chú ý", System.Windows.Forms.MessageBoxButtons.YesNo);
                return false;
            }
            return true;

        }
        //
        public int LayMaND(string user, string pass)
        {
            return Convert.ToInt32(doiMK.LayMaNguoiDung(user, pass));
        }
        //
        public void DoiMatKhau(NguoiDung_InFo info)
        {
            doiMK.Sua(info);
        }
    }
}
