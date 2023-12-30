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
    public partial class frmTimMH : Form
    {
        public frmTimMH()
        {
            InitializeComponent();
        }

        clsQLTTTH obj = new clsQLTTTH();

        #region load form
        private void frmTimcobanMH_Load(object sender, EventArgs e)
        {
            lblThongtincobanMH.Text = "";
        }
        #endregion

        #region tim mh

        void timmh()
        {
            DataSet dsMa = obj.GetDataSetTimcobanMHMa(txtTimcobanMH.Text.ToString());
            DataSet dsTen = obj.GetDataSetTimcobanMHTen(txtTimcobanMH.Text.ToString());
            int a = 0;
            if (btnTimcobanMH.Text == "Tìm")
            {
                if (txtTimcobanMH.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập từ khóa cần tìm kiếm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTimcobanMH.Focus();
                }
                else
                {
                    if (rbtMMHcoban.Checked == false && rbtTMHcoban.Checked == false)
                    {
                        MessageBox.Show("Vui lòng lựa chọn tìm kiếm theo mã môn học hoặc tên môn học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        btnTimcobanMH.Text = "Thử lại";
                        btnTimcobanMH.ImageIndex = 2;
                        txtTimcobanMH.Enabled = false;
                        if (rbtMMHcoban.Checked == true)
                        {
                            foreach (DataRow drw in dsMa.Tables[0].Rows)
                            {
                                ListViewItem lvwItem = new ListViewItem();
                                lvwItem.Text = drw["MaMH"].ToString();
                                lvwItem.SubItems.Add(drw["TenMH"].ToString());
                                lvwItem.SubItems.Add(drw["Sotiet"].ToString());
                                lvwItem.ImageIndex = 0;
                                lvwTimMH.Items.Add(lvwItem);
                                a++;
                            }
                        }
                        else if (rbtTMHcoban.Checked == true)
                        {
                            foreach (DataRow drw in dsTen.Tables[0].Rows)
                            {
                                ListViewItem lvwItem = new ListViewItem();
                                lvwItem.Text = drw["MaMH"].ToString();
                                lvwItem.SubItems.Add(drw["TenMH"].ToString());
                                lvwItem.SubItems.Add(drw["Sotiet"].ToString());
                                lvwItem.ImageIndex = 0;
                                lvwTimMH.Items.Add(lvwItem);
                                a++;
                            }
                        }
                        if (a != 0)
                        {
                            lblThongtincobanMH.Text = "Có " + a.ToString() + " kết quả được tìm thấy với từ khóa: " + txtTimcobanMH.Text.ToString();
                        }
                        else
                        {
                            lblThongtincobanMH.Text = "Không tìm thấy kết quả nào với từ khóa: " + txtTimcobanMH.Text;
                        }
                    }
                }
            }
            else
            {
                btnTimcobanMH.Text = "Tìm";
                btnTimcobanMH.ImageIndex = 1;
                txtTimcobanMH.Enabled = true;
                txtTimcobanMH.Text = "";
                txtTimcobanMH.Focus();
                lvwTimMH.Items.Clear();
                lblThongtincobanMH.Text = "";
                if (rbtMMHcoban.Checked == true)
                {
                    rbtMMHcoban.Checked = false;
                }
                else
                    rbtTMHcoban.Checked = false;
            }
        }

        #endregion

        #region nut tim
        private void btnTimcobanMH_Click(object sender, EventArgs e)
        {
            timmh();
        }

        private void txtTimcobanMH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                timmh();
        }
        #endregion

        #region nut thoat
        private void frmTimcobanMH_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn muốn đóng tìm kiếm môn học ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.No)
                e.Cancel = true;
        }

        private void btnDongcobanMH_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}