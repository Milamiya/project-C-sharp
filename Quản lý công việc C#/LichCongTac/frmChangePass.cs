using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LichCongTac
{
    public partial class frmChangePass : Form
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

        Modules.ConnectionString sqlConn = new LichCongTac.Modules.ConnectionString();
        Modules.StringMessage strMess = new LichCongTac.Modules.StringMessage();
        Modules.Global global = new LichCongTac.Modules.Global();

        private void frmChangePass_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string strDangNhap = frmMain.strDangNhap;
            string strMatKhauCu = txtMatKhauCu.Text.Trim();
            string strChuoiDieuKien = "TenDangNhap='" + strDangNhap + "'and MatKhau='" + strMatKhauCu + "'";
            string strTableName = "Account";
            if (global.Test_Record_Database(strChuoiDieuKien, strTableName, sqlConn.sqlCNN))
            {
                string strMatKhauMoi = txtMatKhauMoi.Text.Trim();
                string strLapLaiMK = txtLapLaiMKM.Text.Trim();
                if (!((strLapLaiMK.Length == 0) && (strMatKhauMoi.Length == 0)))
                {
                    if (!(strMatKhauCu == strMatKhauMoi))
                    {
                        if (strLapLaiMK == strMatKhauMoi)
                        {
                            string strSQL = "update Account set MatKhau='" + strMatKhauMoi + "' where TenDangNhap='" + strDangNhap + "'";
                            global.SQL_Database(strSQL, sqlConn.sqlCNN);
                        }
                        else
                        {
                            MessageBox.Show("Mật Khẩu Mới Phải Giống Nhau", strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật Khẩu Mới và Cũ Trùng Nhau,Bạn Vui Lòng kiểm Tra Lại", strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Mật Khẩu Mới Của Bạn Không Được Rỗng", strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(strMess.strMatKhauCuSai,strMess.strTieuDe,MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }
    }
}