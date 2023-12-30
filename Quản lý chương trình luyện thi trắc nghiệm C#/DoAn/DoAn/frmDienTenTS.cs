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
    public partial class frmDienTenTS : Form
    {
        public string hoten, mats;
        SqlConnection ObjCon;
        public frmDienTenTS()
        {
            string strCon = "server=.\\SQLEXPRESS;database=QL_Thitracnghiem;integrated security=true";
            ObjCon = new SqlConnection(strCon);
            ObjCon.Open();
            InitializeComponent();
            
        }

        private void frmDienTenTS_Load(object sender, EventArgs e)
        {
           
        }

        private void btbatdauthi_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbten.Text == "" || tbmathisinh.Text == "")
                {
                    MessageBox.Show("Bạn phải điền đầy đủ thông tin");
                }
                else
                {
                    string TenThSinh = tbten.Text;
                    string MaThiSinh = tbmathisinh.Text;
                    string strSQL = "insert THISINHTHI values('" + MaThiSinh + "','" + TenThSinh + "')";
                    SqlCommand ObjCmd = new SqlCommand(strSQL, ObjCon);
                    ObjCmd.ExecuteNonQuery();
                    if (MessageBox.Show("Bạn có chắc chắn thi không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        string dienten = this.tbten.Text;//chuyen thong tin sang form thithat
                        string dienma = this.tbmathisinh.Text;
                        frmThiThat thithat = new frmThiThat(dienten, dienma);
                        thithat.ShowDialog();
                        this.Close();


                    }

                }
            }
            catch
            {
                MessageBox.Show("Mã thí sinh trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
    }

        private void tbmathisinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar==Keys.Enter)
            {
                btbatdauthi_Click(null, null);
            }
        }
    }
}