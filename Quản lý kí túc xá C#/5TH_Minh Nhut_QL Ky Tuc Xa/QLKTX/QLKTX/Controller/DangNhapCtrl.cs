using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;

namespace QLKTX.Controller
{
    public class DangNhapCtrl
    {
        public bool DangNhap(TextBoxX user,TextBoxX pass)
        {
            NguoiDungCtrl nguoidungctrl = new NguoiDungCtrl();
                QLKTX.BusinessObject.NguoiDungInfo nguoidung = new QLKTX.BusinessObject.NguoiDungInfo();
                nguoidung.Password = nguoidungctrl.Md5(pass.Text);
                nguoidung.Username = user.Text;
                QLKTX.DataLayer.DangNhapData dangnhap = new QLKTX.DataLayer.DangNhapData();
                DataTable table = dangnhap.DangNhap(nguoidung);
                if (table.Rows.Count == 1)
                {
                    //System.Windows.Forms.MessageBox.Show(table.Rows[0][0] + " " + table.Rows[0][1]);
                    string s = table.Rows[0]["PASS"].ToString();
                    if(s==nguoidungctrl.Md5(pass.Text))
                        return true;
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            
        }
        public bool KiemTra(TextBoxX user,TextBoxX pass)
        {
            if (user.Text != "")
            {
                if (user.Text.Contains("'"))
                {
                    MessageBox.Show("Tên không hợp lệ","Dang Nhap",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    user.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tên", "Dang Nhap", MessageBoxButtons.OK, MessageBoxIcon.Information);
                user.Focus();
                return false;
            }

            if (pass.Text != "")
            {
                if (pass.Text.Contains("'"))
                {
                    MessageBox.Show("Mật khẩu không hợp lệ", "Dang Nhap", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pass.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mật khẩu", "Dang Nhap", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pass.Focus();
                return false;
            }
            return true;
        }
    }
}
