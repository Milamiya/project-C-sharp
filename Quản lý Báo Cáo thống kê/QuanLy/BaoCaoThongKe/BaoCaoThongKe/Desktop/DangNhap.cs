using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevComponents.DotNetBar;
using System.Security.Cryptography;
using BaoCaoThongKe.Controller;
using BaoCaoThongKe.DataLayer;
namespace BaoCaoThongKe.Desktop
{
    public partial class DangNhap : Office2007RibbonForm
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        MainForm mc = new MainForm();
        public bool status = false;
        byte[] pass;
        DataService DT_SV = new DataService();

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DangNhapHeThong();
        }


        private void buttonX2_Click(object sender, EventArgs e)
        {
            status = false;
            this.Close();
        }
        private DataTable MaHoa()
        {
            UTF8Encoding UTF = new UTF8Encoding();
            MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();
            pass = MD5.ComputeHash(UTF.GetBytes(TXT_PASS.Text));

            SqlCommand cmd = new SqlCommand("SELECT * FROM USERS WHERE USERNAME='" + TXT_USER.Text.Trim()+"' AND PASSWORD = '" + BitConverter.ToString(pass) + "'");
            DT_SV.Select(cmd);
            return DT_SV;

        }
        private void ThongBaoLoi()
        {
            if (TXT_USER.Text == "")
                MessageBox.Show("Bạn Chưa Nhập Tên Đăng Nhập!");
            TXT_USER.Focus();
            if (TXT_PASS.Text == "")
                MessageBox.Show("Bạn Chưa Nhập Mật Khẩu!");
            TXT_PASS.Focus();
            
            //if ( TXT_USER.Text == "" || TXT_PASS.Text == "")
            //{
            //    MessageBox.Show("Bạn Chưa Nhập Tên Hoặc Mật Khẩu!");
            //}
            //TXT_USER.Text = "";
            //TXT_PASS.Text = "";
            //TXT_USER.Focus();   

        }
        #region DangNhapVao Chuong Trinh
        private void DangNhapHeThong()
        {
            ThongBaoLoi();
            DataTable DTT = MaHoa();
            if (DTT.Rows.Count == 0)
            {
                MessageBox.Show("Sang!!!");
                TXT_USER.Text = "";
                TXT_PASS.Text = "";
                TXT_USER.Focus();   
            }
            else
            {
                ThamSo.Admin = Convert.ToByte(DTT.Rows[0]["ADMIN"]);
                ThamSo.USERNAME = Convert.ToString(DTT.Rows[0]["USERNAME"]);
                ThamSo.PASSWORD = Convert.ToString(DTT.Rows[0]["PASSWORD"]);
                MessageBox.Show("Đăng Nhập Thành Công");
                MessageBox.Show("SELECT * FROM USERS WHERE USENAME ='" + TXT_USER.Text.Trim() + "' AND PASSWORD = '" + BitConverter.ToString(pass) + "'");
                this.Close();
                status = true;

            }

        }
        #endregion

        void Reset()
        {
            TXT_SeverName.Text = "";
            TXT_UserSV.Text = "";
            TXT_PassSV.Text = "";
        }
        void ChonLaiServer()
        {
            TXT_SeverName.Text = "localhost";
            TXT_UserSV.Text = "sa";
            TXT_PassSV.Text="";
        }
        private void _ChonSV_(object sender, EventArgs e)
        {
            if (CHECKED_CHON.Checked == true)
            {
                Reset();
                TXT_SeverName.Enabled = true;
                TXT_UserSV.Enabled = true;
                TXT_PassSV.Enabled = true;
            }
            else
            {
                ChonLaiServer();
            }

        }
    }
}