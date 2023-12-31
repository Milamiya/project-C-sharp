using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.BusinessObject;
using DevExpress.XtraGrid;
using DevComponents.DotNetBar.Controls;

namespace BaoCaoThongKe.Controller
{
    public class NguoiDung_Ctrl
    {
        NguoiDung_Data data = new NguoiDung_Data();
        public void DataNguoiDung(DataGridViewX dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.ListNguoiDung();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public bool CheckInput(TextBoxX ten, TextBoxX user, TextBoxX pass, TextBoxX repass, ComboBoxEx cmbquyen)
        {
            if (ten.Text == "")
            {
                MessageBox.Show("Chưa nhập họ tên người đăng nhập !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ten.Focus();
                return false;
            }
            else
            {
                if (ten.Text.Length > 50)
                {
                    MessageBox.Show("Họ tên không thể lớn hơn 50 ký tự !", "Chú ý", MessageBoxButtons.OK);
                    ten.Focus();
                    return false;
                }
            }

            if (pass.Text != "")
            {
                if (pass.Text != repass.Text)
                {
                    MessageBox.Show("Mật khẩu không trùng nhau !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pass.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mật khẩu !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pass.Focus();
                return false;
            }

            if (cmbquyen.SelectedIndex < 0)
            {
                cmbquyen.Focus();
                MessageBox.Show("Chưa chọn quyền đăng nhập !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool Them(NguoiDung_InFo nguoidung)
        {
            NguoiDung_Data data = new NguoiDung_Data();
            return data.Them(nguoidung);
        }
        public bool Xoa(NguoiDung_InFo nguoidung)
        {
            NguoiDung_Data data = new NguoiDung_Data();
            return data.Xoa(nguoidung);
        }
        public bool Sua(NguoiDung_InFo nguoidung)
        {
            NguoiDung_Data data = new NguoiDung_Data();
            return data.Sua(nguoidung);
        }

        public int LayMaMax()
        {
            NguoiDung_Data data = new NguoiDung_Data();
            DataTable table = data.LayMaMax();

            try
            {
                int i = Convert.ToInt32(table.Rows[0][0].ToString());
                return ++i;
            }
            catch (Exception e)
            {
                e.ToString();
                return 1;
            }
        }

        public string Md5(string str)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            string pass = "";
            byte[] m_byte = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            foreach (byte b in m_byte)
            {
                pass = pass + b.ToString("X");
            }
            return pass;
        }

        public NguoiDung_InFo DuLieu(TextBoxX ma, TextBoxX ten, TextBoxX user, TextBoxX pass, ComboBoxEx quyen)
        {
            NguoiDung_InFo nguoidung = new NguoiDung_InFo();
            nguoidung.MaNguoiDung = Convert.ToInt32(ma.Text);
            nguoidung.HoTen = ten.Text;
            nguoidung.TenDangNhap = user.Text;
            nguoidung.MatKhau = Md5(pass.Text);
            //nguoidung.MatKhau = Md5(repass.Text);
            nguoidung.Quyen = quyen.Text.ToString();
            //quyen.Text.ToCharArray()[0];

            return nguoidung;
        }
    }
}
