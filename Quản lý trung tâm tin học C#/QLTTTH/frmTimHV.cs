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
    public partial class frmTimHV : Form
    {
        public frmTimHV()
        {
            InitializeComponent();
        }

        #region Xu ly nut Dong
        private void frmTimcobanHV_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn muốn đóng tìm kiếm học viên ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.No)
                e.Cancel = true;
        }
        private void btnDongcobanHV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        clsQLTTTH obj = new clsQLTTTH();

        #region tim hv

        void Timhv()
        {
            DataSet dsMa = obj.GetDataSetTimcobanHVMa(txtTimcobanHV.Text.ToString());
            DataSet dsTen = obj.GetDataSetTimcobanHVTen(txtTimcobanHV.Text.ToString());
            int a = 0;

            #region Kiem tra khi click nut Tim
            if (btnTimcobanHV.Text == "Tìm")
            {
                if (txtTimcobanHV.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập từ khóa cần tìm kiếm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTimcobanHV.Focus();
                }
                else
                {
                    if (rbtMHVcoban.Checked == false && rbtTHVcoban.Checked == false)
                    {
                        MessageBox.Show("Vui lòng lựa chọn tìm kiếm theo mã học viên hoặc tên học viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        btnTimcobanHV.Text = "Thử lại";
                        btnTimcobanHV.ImageIndex = 2;
                        txtTimcobanHV.Enabled = false;

                        #region Xu ly khi check tim ma
                        if (rbtMHVcoban.Checked == true)
                        {
                            foreach (DataRow drw in dsMa.Tables[0].Rows)
                            {
                                ListViewItem lvwItem = new ListViewItem();
                                lvwItem.Text = drw["MaHV"].ToString();
                                lvwItem.SubItems.Add(drw["TenHV"].ToString());
                                if ((Boolean)drw["Phai"] == true)
                                    lvwItem.SubItems.Add("Nam");
                                else
                                    lvwItem.SubItems.Add("Nữ");
                                string ngaysinh = Convert.ToDateTime(drw["NgaySinh"].ToString()).ToShortDateString();
                                lvwItem.SubItems.Add(ngaysinh);
                                lvwItem.SubItems.Add(drw["DiaChi"].ToString());
                                lvwItem.SubItems.Add(drw["DienThoai"].ToString());
                                lvwItem.SubItems.Add(drw["MaLop"].ToString());
                                lvwItem.ImageIndex = 0;
                                lvwTimHV.Items.Add(lvwItem);
                                a++;
                            }
                        }
                        #endregion

                        #region Xu ly khi check tim ten
                        else if (rbtTHVcoban.Checked == true)
                        {
                            foreach (DataRow drw in dsTen.Tables[0].Rows)
                            {
                                ListViewItem lvwItem = new ListViewItem();
                                lvwItem.Text = drw["MaHV"].ToString();
                                lvwItem.SubItems.Add(drw["TenHV"].ToString());
                                if ((Boolean)drw["Phai"] == true)
                                    lvwItem.SubItems.Add("Nam");
                                else
                                    lvwItem.SubItems.Add("Nữ");
                                string ngaysinh = Convert.ToDateTime(drw["NgaySinh"].ToString()).ToShortDateString();
                                lvwItem.SubItems.Add(ngaysinh);
                                lvwItem.SubItems.Add(drw["DiaChi"].ToString());
                                lvwItem.SubItems.Add(drw["DienThoai"].ToString());
                                lvwItem.SubItems.Add(drw["MaLop"].ToString());
                                lvwItem.ImageIndex = 0;
                                lvwTimHV.Items.Add(lvwItem);
                                a++;
                            }
                        }
                        #endregion

                        #region Dem ket qua tim duoc
                        if (a != 0)
                        {
                            lblThongtincobanHV.Text = "Có " + a.ToString() + " kết quả được tìm thấy với từ khóa: " + txtTimcobanHV.Text.ToString();
                        }
                        else
                        {
                            lblThongtincobanHV.Text = "Không tìm thấy kết quả nào với từ khóa: " + txtTimcobanHV.Text;
                        }
                        #endregion
                    }
                }
            }
            #endregion

            #region Kiem tra khi click nut Thu lai
            else
            {
                btnTimcobanHV.Text = "Tìm";
                btnTimcobanHV.ImageIndex = 1;
                txtTimcobanHV.Enabled = true;
                txtTimcobanHV.Text = "";
                txtTimcobanHV.Focus();
                lvwTimHV.Items.Clear();
                lblThongtincobanHV.Text = "";
                if (rbtMHVcoban.Checked == true)
                {
                    rbtMHVcoban.Checked = false;
                }
                else
                    rbtTHVcoban.Checked = false;
            }
            #endregion
        }

        #endregion

        #region Xu ly nut tim
        private void btnTimcobanHV_Click(object sender, EventArgs e)
        {
            Timhv();
        }

        private void txtTimcobanHV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Timhv();
        }

        #endregion

        #region Su kien form load
        private void frmTimcobanHV_Load(object sender, EventArgs e)
        {
            lblThongtincobanHV.Text = "";
        }
        #endregion

    }
}