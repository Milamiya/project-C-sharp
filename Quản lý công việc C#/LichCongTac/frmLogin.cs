using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LichCongTac
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        Modules.ConnectionString sqlConn = new LichCongTac.Modules.ConnectionString();
        Modules.StringMessage strMess = new LichCongTac.Modules.StringMessage();
        Modules.Global global = new LichCongTac.Modules.Global();

        public static int intQuyenTruyCap = 2;
        private string strTenDangNhap;
        public static bool boolDangNhapThanhCong = false;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConn.getConnectionString();
            }
            catch
            {
                MessageBox.Show(strMess.strChuaKetNoiCSDL, strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public int getNumberAccount()
        {
            return intQuyenTruyCap;
        }

        public string getAccountName()
        { 
            return strTenDangNhap;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            intQuyenTruyCap = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            intQuyenTruyCap = 0;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            strTenDangNhap = txtTenDangNhap.Text.Trim();
            string strMatKhau = txtMatKhau.Text.Trim();
            string strDieuKien = "TenDangNhap=N'" + strTenDangNhap + "'and MatKhau=N'" + strMatKhau + "'and QuyenTruyCap=" + intQuyenTruyCap + "";
            string strTableName = "Account";
            if (!(strTenDangNhap == "" ))
            {
                if (intQuyenTruyCap != 2)
                {
                    if (global.Test_Record_Database(strDieuKien, strTableName, sqlConn.sqlCNN))
                    {
                        MessageBox.Show(strMess.strDangNhapThanhCong, strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        boolDangNhapThanhCong = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(strMess.strDangNhapThatBai, strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show(strMess.strChuaChonQTC, strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show(strMess.strChuaDienTaiKhoan, strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
            intQuyenTruyCap = 2;
        }
    }
}