using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LichCongTac
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        Modules.Global global = new LichCongTac.Modules.Global();
        Modules.ConnectionString sqlConn = new LichCongTac.Modules.ConnectionString();
        Modules.StringMessage strMess = new LichCongTac.Modules.StringMessage();

        private int intQuyenTruyCap = 0;

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConn.getConnectionString();
            }
            catch
            {
                MessageBox.Show(strMess.strChuaKetNoiCSDL,strMess.strTieuDe,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            if (frmMain.intQuyenTruyCap == 0)
            {
                radioButton1.Enabled = false;
                btnXoa.Enabled = false;
            }
            if (frmMain.intQuyenTruyCap == 1)
            {
                radioButton1.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            intQuyenTruyCap = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            intQuyenTruyCap = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string strTenDangNhap = txtTenTaiKhoan.Text.Trim();
            string strMatKhau = txtMatKhau.Text.Trim();
            string strSQL = "insert into Account values(N'" + strTenDangNhap + "',N'" + strMatKhau + "',"+intQuyenTruyCap+")";
            string strChuoiDieuKien = "TenDangNhap='" + strTenDangNhap + "'";
            string strTableName = "Account";
            if (!(strTenDangNhap == ""))
            {
                if (global.Test_Record_Database(strChuoiDieuKien, strTableName, sqlConn.sqlCNN) == false)
                {
                    global.SQL_Database(strSQL, sqlConn.sqlCNN);
                }
                else
                {
                    MessageBox.Show("Tên Truy Cập Này Đã Tồn Tại", strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show(strMess.strChuaDienTaiKhoan, strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string strTenDangNhap = txtTenTaiKhoan.Text.Trim();
            string strSQL = "delete from Account where TenDangNhap='" + strTenDangNhap + "'";
            string strChuoiDieuKien = "TenDangNhap='" + strTenDangNhap + "'";
            string strTableName = "Account";
            if (global.Test_Record_Database(strChuoiDieuKien, strTableName, sqlConn.sqlCNN) == true)
            {
                global.SQL_Database(strSQL, sqlConn.sqlCNN);
            }
            else
            {
                MessageBox.Show("Tên Truy Cập Này Không Tồn Tại", strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}