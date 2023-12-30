using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using clsDATABASE;

namespace QLTTTH
{
    public partial class frmTimKQ : Form
    {
        public frmTimKQ()
        {
            InitializeComponent();
        }

        private void frmTimKQ_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn muốn đóng xem kết quả học tập ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.No)
                e.Cancel = true;
        }

        private void btnDongXKQ_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        clsQLTTTH obj = new clsQLTTTH();

        #region ham xem kq
        void Xemdiem()
        {
            int a = 0;
            DataSet ds = obj.GetdatasetXemKQ(txtXemKQ.Text.ToString());
            lvwXemKQHT.Items.Clear();
            if (btnXemKQ.Text == "Xem")
            {
                if (txtXemKQ.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã học viên cần xem", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtXemKQ.Focus();
                }
                else
                {
                    btnXemKQ.Text = "Thử lại";
                    btnXemKQ.ImageIndex = 2;
                    txtXemKQ.Enabled = false;
                    foreach (DataRow drw in ds.Tables[0].Rows)
                    {
                        a++;
                        ListViewItem item = new ListViewItem();
                        item.Text = drw["TenMH"].ToString();
                        item.SubItems.Add(drw["LanThi"].ToString());
                        item.SubItems.Add(drw["Diem"].ToString());
                        txtXemMHVKQ.Text = drw["TenHV"].ToString();
                        txtLopKQ.Text = drw["TenLop"].ToString();
                        item.ImageIndex = 0;
                        lvwXemKQHT.Items.Add(item);
                    }
                    if (a != 0)
                    {
                        lblThongtinKQ.Text = "Học viên " + txtXemMHVKQ.Text + " có " + a.ToString() + " kết quả học tập";
                    }
                    else
                    {
                        lblThongtinKQ.Text = "Không tìm thấy học viên này trong kết quả học tập";
                        txtXemKQ.Focus();
                    }
                }
            }
            else
            {
                btnXemKQ.Text = "Xem";
                btnXemKQ.ImageIndex = 1;
                txtXemKQ.Enabled = true;
                txtXemKQ.Text = "";
                txtXemMHVKQ.Text = "";
                txtLopKQ.Text = "";
                lblThongtinKQ.Text = "";
                txtXemKQ.Focus();
                lvwXemKQHT.Items.Clear();
            }
        }

        #endregion

        #region nut xem, enter text, load form
        private void btnXemKQ_Click(object sender, EventArgs e)
        {
            Xemdiem();
        }

        private void frmTimKQ_Load(object sender, EventArgs e)
        {
            lblThongtinKQ.Text = "";
            txtXemKQ.Focus();
        }

        private void txtXemKQ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Xemdiem();
        }
        #endregion
    }
}