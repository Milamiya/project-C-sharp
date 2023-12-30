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
    public partial class frmDSKQ : Form
    {
        public frmDSKQ()
        {
            InitializeComponent();
        }
        #region Nut thoat
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmDSHVDau_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn muốn đóng thống kê kết quả học tập ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.No)
                e.Cancel = true;
        }
        #endregion

        clsQLTTTH obj = new clsQLTTTH();

        #region Su kien form load
        private void frmDSHVDau_Load(object sender, EventArgs e)
        {
            cboLopHV.DisplayMember = "TenLop";
            cboLopHV.ValueMember = "MaLop";
            cboLopHV.DataSource = obj.GetDataTable("Lop");
            lblSoHV.Text = "";
        }
        #endregion

        #region Su kien chon combobox lop

        private void cboLopHV_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = obj.GetdatasetKQ(cboLopHV.SelectedValue.ToString());
            #region chon xem hv dau
            if (rbtDau.Checked == true)
            {
                gbxDanhsach.Text = "Danh Sách Kết Quả Học Tập Của Học Viên Đậu";
                lvwDanhsachKQHV.Items.Clear();
                int number = 0;
                foreach (DataRow drw in ds.Tables[0].Rows)
                {
                    if (Convert.ToDouble(drw["Diem"]) >= 5)
                    {
                        number++;
                        ListViewItem Item = new ListViewItem();
                        Item.Text = drw["MaHV"].ToString();
                        Item.SubItems.Add(drw["TenHV"].ToString());
                        if ((Boolean)drw["Phai"] == true)
                            Item.SubItems.Add("Nam");
                        else
                            Item.SubItems.Add("Nữ");
                        string ngaysinh = Convert.ToDateTime(drw["NgaySinh"].ToString()).ToShortDateString();
                        Item.SubItems.Add(ngaysinh);
                        Item.SubItems.Add(drw["MaMH"].ToString());
                        Item.SubItems.Add(drw["TenMH"].ToString());
                        Item.SubItems.Add(drw["LanThi"].ToString());
                        Item.SubItems.Add(drw["Diem"].ToString());
                        Item.ImageIndex = 0;
                        lvwDanhsachKQHV.Items.Add(Item);
                    }
                    txtTKHVGV.Text = drw["GVCN"].ToString();
                }
                if (number == 0)
                {
                    lblSoHV.Text = "Lớp này không có học viên nào đậu";
                }
                else
                {
                    lblSoHV.Text = "Tìm được " + number.ToString() + " kết quả học viên đậu";
                }
            }
            #endregion

            #region chon xem hv rot
            if (rbtRot.Checked == true)
            {
                gbxDanhsach.Text = "Danh Sách Kết Quả Học Tập Của Học Viên Rớt";
                lvwDanhsachKQHV.Items.Clear();
                int flag = 0;
                foreach (DataRow drw in ds.Tables[0].Rows)
                {
                    if (Convert.ToDouble(drw["Diem"]) < 5)
                    {
                        flag++;
                        ListViewItem Item = new ListViewItem();
                        Item.Text = drw["MaHV"].ToString();
                        Item.SubItems.Add(drw["TenHV"].ToString());
                        if ((Boolean)drw["Phai"] == true)
                            Item.SubItems.Add("Nam");
                        else
                            Item.SubItems.Add("Nữ");
                        string ngaysinh = Convert.ToDateTime(drw["NgaySinh"].ToString()).ToShortDateString();
                        Item.SubItems.Add(ngaysinh);
                        Item.SubItems.Add(drw["MaMH"].ToString());
                        Item.SubItems.Add(drw["TenMH"].ToString());
                        Item.SubItems.Add(drw["LanThi"].ToString());
                        Item.SubItems.Add(drw["Diem"].ToString());
                        Item.ImageIndex = 0;
                        lvwDanhsachKQHV.Items.Add(Item);
                    }
                    txtTKHVGV.Text = drw["GVCN"].ToString();
                }
                if (flag == 0)
                {
                    lblSoHV.Text = "Lớp này không có học viên nào rớt";
                }
                else
                {
                    lblSoHV.Text = "Tìm được " + flag.ToString() + " kết quả học viên rớt";
                }
            }
                #endregion

        }
        #endregion
    }
}