using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Windows.Forms;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class DangNhapCtr
    {
        DangNhapData data = new DangNhapData();

        public void HienThiUserComBoBox(ComboBox cmbSp)
        {
            cmbSp.DataSource = data.DanhSachUser();
            cmbSp.DisplayMember = "username";
            cmbSp.ValueMember = "manhom";
        }


        public bool isExitUser(string p, TextBox txtpassold)
        {
            return data.isExitUser(p, txtpassold);
        }

        public void SetPassWord(string user, string pass)
        {
            data.SetPassWord(user, pass);
        }

        public void DelUser(string p)
        {
            data.DelUser(p);
        }
    }
}
