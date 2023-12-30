using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Doan
{
    public partial class frmLuaChon : Form
    {
        public  string strcapdo, strsoluongcauhoi, strthoigian,tenthisinh;
        private void showformthi()
        {
            tenthisinh = txtTenThiSinh.Text;
            strcapdo = cbcapdo.Text;
            strsoluongcauhoi = dmupdownsoluong.Text;
            strthoigian = dmupdownthoigian.Text;
            frmThi frmformthi = new frmThi();
            frmformthi.frmluachon = this;
            frmformthi.ShowDialog();
        }
        public frmLuaChon()
        {
            InitializeComponent();   
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbluachon.Text = lbluachon.Text.Substring(lbluachon.Text.Length - 1, 1) + lbluachon.Text.Substring(0, lbluachon.Text.Length - 1);
        }
        private void btBatDau_Click(object sender, EventArgs e)
        {
            if (cbcapdo.Text == "" || dmupdownsoluong.Text == "0" || dmupdownthoigian.Text == "0")
                MessageBox.Show("Bạn cần chọn đầy đủ thông tin");
            else
                //this.Close();
                showformthi();
            
           
        }
        private void frmLuaChon_Load(object sender, EventArgs e)
        {
            txtTenThiSinh.Text = "Không tên";
            cbcapdo.Text = "A";
            dmupdownsoluong.Text = "0";
            dmupdownthoigian.Text = "0";
        }
    }
}
