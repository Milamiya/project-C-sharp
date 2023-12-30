using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyDaoTao.Utilities;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmMatKhau : XtraForm
    {
        public frmMatKhau()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Delegate truyền mật khẩu qua form khác
        /// </summary>
        public delegate void TruyenMatKhau(string matKhau);
        public TruyenMatKhau truyen;


        /// <summary>
        /// Return true nếu dữ liệu nhập OK. Ngược lại False
        /// </summary>
        /// <returns></returns>
        public bool KTTruocOK()
        {
            try
            {
                if (txtMatKhau.Text.Trim().Length == 0)
                {
                    MsgboxUtil.Exclamation("Bạn chưa nhập mật khẩu");
                    txtMatKhau.Focus();
                    return false;
                }
                if (txtNhapLai.Text.Trim().Length == 0)
                {

                    MsgboxUtil.Exclamation("Bạn chưa nhập xác minh lại mật khẩu");
                    txtNhapLai.Focus();
                    return false;
                }
                if (txtNhapLai.Text.Trim() != txtMatKhau.Text.Trim())
                {
                    MsgboxUtil.Exclamation("Mật khẩu không khớp. Vui lòng xác minh lại");
                    txtNhapLai.Focus();
                    txtNhapLai.SelectAll();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                ExceptionUtil.Throw(ex.Message);
                return false;
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    btnOK_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.Throw(ex.Message);
                return;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.KTTruocOK())
                {
                    if (truyen != null)
                    {
                        truyen(txtNhapLai.Text);
                        this.DialogResult = DialogResult.OK;
                    }
                    Close();
                }
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
                Close();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void frmThietLapMatKhau_Load(object sender, EventArgs e)
        {
            txtMatKhau.Focus();
        }
    }
}