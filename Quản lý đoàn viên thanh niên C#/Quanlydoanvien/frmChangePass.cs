using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Quanlydoanvien
{
    public partial class frmChangePass : DevComponents.DotNetBar.Office2007Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {

        }

        private void btnthaydoi_Click(object sender, EventArgs e)
        {
            try
            {
                ClassNoiCSDL db = new ClassNoiCSDL();
                if (txtusercu.Text == "")
                {
                    MessageBoxEx.Show(" Bạn chưa nhập tên đăng nhập cũ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusercu.Focus();
                }
                else
                    if (txtpasscu.Text == "")
                    {
                        MessageBoxEx.Show(" Bạn chưa nhập mật khẩu cũ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtpasscu.Focus();
                    }
                    else
                        if (txtusermoi.Text == "")
                        {
                            MessageBoxEx.Show(" Bạn chưa nhập tên đăng nhập mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtusermoi.Focus();
                        }
                        else
                            if (txtpassmoi.Text == "")
                            {
                                MessageBoxEx.Show(" Bạn chưa nhập mật khẩu mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtpassmoi.Focus();
                            }

                            else
                            {
                                if (db.Checklogin2(txtusercu.Text, txtpasscu.Text))
                                {
                                    db.update(txtusercu.Text, txtpasscu.Text, txtusermoi.Text, txtpassmoi.Text);
                                    MessageBoxEx.Show(" Chúc mừng!(^~^), bạn đã đổi mật khẩu thành công!Hãy nhớ để đăng nhập lại lần sau nhé!(^~^)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Close();
                                }
                                else
                                {
                                    MessageBoxEx.Show(" Tên đăng nhập hoặc mật khẩu cũ không đúng!(@~@). Xin vui lòng kiểm tra lại! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
            }
            catch (Exception)
            {
                MessageBoxEx.Show("Không thể cập nhật được User này đã tồn tại!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            txtusercu.Text = "";
            txtusercu.Focus();
            txtpasscu.Text = "";
            txtusermoi.Text = "";
            txtpassmoi.Text = "";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
