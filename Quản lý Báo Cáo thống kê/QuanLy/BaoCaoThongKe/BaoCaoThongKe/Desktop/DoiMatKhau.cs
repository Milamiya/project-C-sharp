using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Controls;
using System.Security.Cryptography;
using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.Controller;

namespace BaoCaoThongKe.Desktop
{
    public partial class DoiMatKhau : Office2007RibbonForm
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Chắc Là Muốn Thoát?", "THAY DOI MAT KHAU", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            this.Close();
        }
        void Reset()
        {
            TXT_CFPass.Text = "";
            TXT_CNPass.Text = "";
            TXT_NPass.Text = "";
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (TXT_NPass.Text.Trim() == TXT_CNPass.Text.Trim())
            {
                if (TestPass())
                {
                    ChangePassword();
                    MessageBox.Show("Bạn Đã Thay Đổi Mật Khẩu Thành Công");
                    Reset();
                    this.Close();
                }
                else
                    MessageBox.Show("Vui Lòng Xác Nhận Lại!", "DOI MAT KHAU", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Reset();
                TXT_CFPass.Text = "";
                TXT_CFPass.Focus();
            }
            else
                MessageBox.Show("Đổi Mật Khẩu Không Thành Công!");
            //Reset();
            TXT_CNPass.Text = "";
            TXT_CNPass.Focus();
            //TXT_CFPass.Focus();
        }        
        byte[] pass;
        DataService DT_SV = new DataService();
        public DataTable TestLogin()
        {
            MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();
            UTF8Encoding UTF = new UTF8Encoding();

            pass = MD5.ComputeHash(UTF.GetBytes(TXT_CFPass.Text.Trim()));

            SqlCommand cmd = new SqlCommand("SELECT * FROM USERS WHERE PASSWORD = '"+BitConverter.ToString(pass)+"'");
            DT_SV.Load(cmd);
            return DT_SV;
        }
        private bool TestPass()
        {
            DataTable DTT = TestLogin();
            if (DTT.Rows.Count == 0)
                return false;
            return true;
        }
        private void ChangePassword()
        {
            MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();
            UTF8Encoding UTF = new UTF8Encoding();

            pass = MD5.ComputeHash(UTF.GetBytes(TXT_NPass.Text));

            SqlCommand cmd = new SqlCommand("UPDATE USERS SET PASSWORD='"+BitConverter.ToString(pass)+"' ");
            DT_SV.ExecuteNoneQuery(cmd);
        }


    }
}