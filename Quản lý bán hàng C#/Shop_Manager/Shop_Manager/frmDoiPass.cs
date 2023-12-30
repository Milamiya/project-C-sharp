using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shop_Manager
{
    public partial class frmDoiPass : Form
    {
        public frmDoiPass()
        {
            InitializeComponent();
        }

        private void btnDoiPass_Click(object sender, EventArgs e)
        {
            string tendn = txtTenDN.Text.Trim();
            string oldpass = txtOldPass.Text.Trim();
            string newpass = txtNewPass.Text.Trim();
            try
            {
                if (tendn == "")
                {
                    MessageBox.Show("Thiếu tên đăng nhập!","Chú ý!");
                    txtTenDN.Select();
                    return;
                }
                if (oldpass == "")
                {
                    MessageBox.Show("Hãy nhập mật khẩu cũ!", "Chú ý!");
                    txtOldPass.Select();
                    return;
                }
                if (newpass == "")
                {
                    MessageBox.Show("Hãy nhập mật khẩu mới!", "Chú ý!");
                    txtNewPass.Select();
                    return;
                }
                string select = "SELECT * FROM tblDangNhap";
                string update = "UPDATE tblDangNhap SET MatKhau=N'"+newpass+"' WHERE TaiKhoan=N'"+txtTenDN.Text+"'";
                Boolean kt = false;
                DataSet ds = DataConn.GrdSource(select);
                for (int i = 0; i < ds.Tables[0].Rows.Count; ++i)
                {
                    if ((tendn == ds.Tables[0].Rows[i][0].ToString()) && (oldpass == ds.Tables[0].Rows[i][1].ToString()))
                    {
                        kt = true;
                        DataConn.ThucHienCmd(update);
                        MessageBox.Show("Đổi mật khẩu thành công!");
                        this.Close();
                    }
                }

                if (kt == false)
                    MessageBox.Show("Bạn nhập sai tên đăng nhập hoặc mật khẩu!");
            }
            catch (NotEnoughInfoException)
            {
                MessageBox.Show("Bạn hãy nhập đủ tất cả các trường có dấu (*)");
            }
        }
    }
}