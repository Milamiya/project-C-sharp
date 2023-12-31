using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using DevComponents.DotNetBar;


namespace BaoCaoThongKe.Desktop
{
    public partial class QL_NguoiDung : Office2007RibbonForm
    {
        public QL_NguoiDung()
        {
            InitializeComponent();
        }
        DataService DT_SV = new DataService();
        private void Reset()
        {
            TXT_USERNAME.Text = "";
            TXT_PASS.Text = "";
            TXT_RE_PASS.Text = "";
        }
        public DataTable TestUser()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM USERS WHERE USENAME = '" + TXT_USERNAME.Text.Trim() + "'");
            DT_SV.Load(cmd);
            return DT_SV;
        }
        private bool Test()
        {
            DataTable DTT = TestUser();
            if (DTT.Rows.Count == 0)
                return true;
            return false;
        }
        private void Adduser()
        {
            byte[] pass;
            MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();
            UTF8Encoding UTF = new UTF8Encoding();

            pass = MD5.ComputeHash(UTF.GetBytes(TXT_PASS.Text));
            SqlCommand cmd = new SqlCommand("INSERT INTO USERS VALUES('" + TXT_USERNAME.Text.Trim() + "','" + BitConverter.ToString(pass) + "','" + CMB_QUYEN.SelectedItem.ToString() + "')");
            DT_SV.ExecuteNoneQuery(cmd);
        }

        private void BT_DK_Click(object sender, EventArgs e)
        {
            if (TXT_USERNAME.Text == "")
            {
                MessageBox.Show("");
                TXT_USERNAME.Focus();
            }
            else
            {
                if (Test())
                {
                    if (TXT_PASS.Text.Trim() == TXT_RE_PASS.Text.Trim())
                    {
                        Adduser();
                        Reset();
                        MessageBox.Show("Chấp Nhận Thành Viên Mới", "USER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Mật Khẩu Không Khớp!");
                        TXT_RE_PASS.Text = "";
                        TXT_RE_PASS.Focus();
                    }
                }
                else
                    MessageBox.Show("Tài Khoản Đã Có Thành Viên Sử Dụng!");
            }
        }

        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}