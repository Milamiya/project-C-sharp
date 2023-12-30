using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.DataAccess;
using System.Linq;
using QuanLyDaoTao.Business;
using QuanLyDaoTao.Properties;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmDangNhap : XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        public bool KiemTra()
        {
            try
            {
                if (txtTenDangNhap.Text.Trim().Length == 0)
                {
                    MsgboxUtil.Exclamation("Bạn chưa nhập Tên người dùng");
                    txtTenDangNhap.Focus();
                    return false;
                }
                if (txtMatKhau.Text.Trim().Length == 0)
                {
                    MsgboxUtil.Exclamation("Bạn chưa nhập Mật khẩu");
                    txtMatKhau.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (NguoiDungBUS.KiemTraTenDangNhap(txtTenDangNhap.Text.Trim()))
                {
                    NguoiDung user = NguoiDungBUS.LayThongTin(txtTenDangNhap.Text.Trim());
                    if (user.MatKhau == UtilitiesClass.MaHoaMD5(txtMatKhau.Text))
                    {
                        StaticClass.User = user;
                        StaticClass.DangNhap = true;
                        Settings.Default.TenDangNhap = user.TenDangNhap;
                        if (ckbNhoMatKhau.Checked)
                            Settings.Default.MatKhau = txtMatKhau.Text;
                        else
                            Settings.Default.MatKhau = "";
                        Settings.Default.Save();
                        DialogResult = DialogResult.OK;
                        StaticClass.Log.GhiFile("Đăng nhập hệ thống");
                        this.Close();
                    }
                    else
                    {
                        MsgboxUtil.Exclamation("Mật khẩu không đúng.");
                        txtMatKhau.Focus();
                        txtMatKhau.SelectAll();
                        return;
                    }      
                }
                else
                {
                    MsgboxUtil.Exclamation("Người dùng không tồn tại");
                    txtTenDangNhap.Focus();
                    txtTenDangNhap.SelectAll();
                    return;
                }
            }
            catch (Exception ex)
            {
                MsgboxUtil.Error(ex.Message);
            }
        }

        private void textEdit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                    simpleButton1_Click(null, null);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(Settings.Default.TenDangNhap))
                    txtTenDangNhap.Text = Settings.Default.TenDangNhap;
                if (!string.IsNullOrEmpty(Settings.Default.MatKhau))
                {
                    txtMatKhau.Text = Settings.Default.MatKhau;
                    ckbNhoMatKhau.Checked = true;
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}