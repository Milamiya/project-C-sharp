using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Doan
{
    public partial class frmReg : Form
    {
        SqlConnection ObjCon;
        public frmReg()
        {
            string strCon ="server=.\\SQLEXPRESS;database=QL_Thitracnghiem;integrated security=true";
            ObjCon = new SqlConnection(strCon);
            ObjCon.Open();
            InitializeComponent();
        }

        private void txt6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txt6_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt6.Text))
            {
                errorProvider1.SetError(txt6, "Bạn phải nhập giá trị vào ô này");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" || txt2.Text == "" || txt6.Text == "")
            {
                MessageBox.Show("Bạn phải nhập giá trị vào các ô có dấu *");
            }
            else
            {
                string TenDangNhap = txt1.Text;
                string MatKhau = txt2.Text;
                string HoVaTen = txt3.Text;
                string NgaySinh = txt4.Text;
                string NoiSinh = txt5.Text;
                string SoDienThoai = txt6.Text;

                string strSQL = "insert THISINH values('" + TenDangNhap + "','" + MatKhau + "','" + HoVaTen + "','" + NgaySinh + "','" + NoiSinh + "','" + SoDienThoai + "')";
                SqlCommand ObjCmd = new SqlCommand(strSQL, ObjCon);
                ObjCmd.ExecuteNonQuery();
                MessageBox.Show("Bạn đã đăng ký thành công");
                this.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txt4.Clear();
            txt5.Clear();
            txt6.Clear();
        }

        //private void frmReg_Activated(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Maximized;
        //}

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
