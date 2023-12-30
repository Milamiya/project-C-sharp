using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using QuanLyHoSoCongChuc.BusinessObject;
using QuanLyHoSoCongChuc.Controller;
using System.Data.SqlClient;
using DevComponents.DotNetBar;

namespace QuanLyHoSoCongChuc
{
    public partial class FrmDangNhap : Office2007Form
    {

        public FrmDangNhap()
        {
            InitializeComponent();
        }

        //Click dang nhap
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            if (staticClass.reLogin)
            {
                staticClass.reLogin = true;
            }
        }

        //Click thoat
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void DangNhap_Key(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            DataService.OpenConnection();
        }


    }
}