using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using BaoCaoThongKe.DataLayer;

namespace BaoCaoThongKe.Controller
{
    public class Dangnhap_Ctrl
    {
        public string quyen = "";
        Dangnhap_Data data = new Dangnhap_Data();
        public bool KiemTra(TextBoxX user, TextBoxX pass)
        {
            if (user.Text != "")
            {
                if (user.Text.Contains("'"))
                {
                    MessageBox.Show("Tên đăng nhập không hợp lệ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    user.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tên người dùng !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                user.Focus();
                return false;
            }

            if (pass.Text != "")
            {
                if (pass.Text.Contains("'"))
                {
                    MessageBox.Show("Mật khẩu không hợp lệ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pass.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mật khẩu !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pass.Focus();
                return false;
            }
            return true;
        }

        //Dang nhap

        public bool DangNhap(TextBox tendangnhap, TextBox matkhau)
        {
            DataTable table = data.DangNhap(tendangnhap.Text);
            if (table.Rows.Count == 1)
            {
                NguoiDung_Ctrl nguoidung = new NguoiDung_Ctrl();
                matkhau.Text = nguoidung.Md5(matkhau.Text);
                if (table.Rows[0]["MatKhau"].ToString() == matkhau.Text)
                {
                    quyen = table.Rows[0]["Quyen"].ToString(); ;
                    //MessageBox.Show("Bạn đăng nhập thành công !");
                    return true;
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công .Yêu cầu bạn nhập lại !");
                    return false;
                }
            }
            return false;
        }

    }
}
