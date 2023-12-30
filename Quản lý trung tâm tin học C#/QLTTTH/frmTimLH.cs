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
    public partial class frmTimLH : Form
    {
        public frmTimLH()
        {
            InitializeComponent();
        }

        #region load form, nut dong
        private void frmTimcobanLH_Load(object sender, EventArgs e)
        {
            lblThongtincobanLH.Text = "";
        }

        private void frmTimcobanLH_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn muốn đóng tìm kiếm lớp học ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.No)
                e.Cancel = true;
        }

        private void btnDongcobanLH_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region nut tim
        clsQLTTTH obj = new clsQLTTTH();

        #region tim lh

        void timlh()
        {
            DataSet dsMa = obj.GetDataSetTimcobanLHMa(txtTimcobanLH.Text.ToString());
            DataSet dsTen = obj.GetDataSetTimcobanLHTen(txtTimcobanLH.Text.ToString());
            int a = 0;
            if (btnTimcobanLH.Text == "Tìm")
            {
                if (txtTimcobanLH.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập từ khóa cần tìm kiếm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTimcobanLH.Focus();
                }
                else
                {
                    if (rbtMLHcoban.Checked == false && rbtTLHcoban.Checked == false)
                    {
                        MessageBox.Show("Vui lòng lựa chọn tìm kiếm theo mã lớp học hoặc tên lớp học", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        btnTimcobanLH.Text = "Thử lại";
                        btnTimcobanLH.ImageIndex = 2;
                        txtTimcobanLH.Enabled = false;
                        if (rbtMLHcoban.Checked == true)
                        {
                            foreach (DataRow drw in dsMa.Tables[0].Rows)
                            {
                                ListViewItem lvwItem = new ListViewItem();
                                lvwItem.Text = drw["MaLop"].ToString();
                                lvwItem.SubItems.Add(drw["TenLop"].ToString());
                                lvwItem.SubItems.Add(drw["KhoaHoc"].ToString());
                                lvwItem.SubItems.Add(drw["GVCN"].ToString());
                                string NgayKG = Convert.ToDateTime(drw["NgayKG"].ToString()).ToShortDateString();
                                lvwItem.SubItems.Add(NgayKG);
                                lvwItem.ImageIndex = 0;
                                lvwTimLH.Items.Add(lvwItem);
                                a++;
                            }
                        }
                        else if (rbtTLHcoban.Checked == true)
                        {
                            foreach (DataRow drw in dsTen.Tables[0].Rows)
                            {
                                ListViewItem lvwItem = new ListViewItem();
                                lvwItem.Text = drw["MaLop"].ToString();
                                lvwItem.SubItems.Add(drw["TenLop"].ToString());
                                lvwItem.SubItems.Add(drw["KhoaHoc"].ToString());
                                lvwItem.SubItems.Add(drw["GVCN"].ToString());
                                string NgayKG = Convert.ToDateTime(drw["NgayKG"].ToString()).ToShortDateString();
                                lvwItem.SubItems.Add(NgayKG);
                                lvwItem.ImageIndex = 0;
                                lvwTimLH.Items.Add(lvwItem);
                                a++;
                            }
                        }
                        if (a != 0)
                        {
                            lblThongtincobanLH.Text = "Có " + a.ToString() + " kết quả được tìm thấy với từ khóa: " + txtTimcobanLH.Text.ToString();
                        }
                        else
                        {
                            lblThongtincobanLH.Text = "Không tìm thấy kết quả nào với từ khóa: " + txtTimcobanLH.Text;
                        }
                    }
                }
            }
            else
            {
                btnTimcobanLH.Text = "Tìm";
                btnTimcobanLH.ImageIndex = 1;
                txtTimcobanLH.Enabled = true;
                txtTimcobanLH.Text = "";
                txtTimcobanLH.Focus();
                lvwTimLH.Items.Clear();
                lblThongtincobanLH.Text = "";
                if (rbtMLHcoban.Checked == true)
                {
                    rbtMLHcoban.Checked = false;
                }
                else
                    rbtTLHcoban.Checked = false;
            }
        }

        #endregion

        private void btnTimcobanLH_Click(object sender, EventArgs e)
        {
            timlh();
        }

        private void txtTimcobanLH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                timlh();
        }

        #endregion

    }
}