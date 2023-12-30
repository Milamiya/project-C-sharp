using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BaoCaoThongKe.Controller;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.Desktop
{
    public partial class frmDoimatkhau : Form
    {
        public frmDoimatkhau()
        {
            InitializeComponent();
        }

        private void frmDoimatkhau_Load(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass_old.Text = "";
            txtPass_new.Text = "";
            txtPass_prenew.Text = "";
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            NguoiDung_Ctrl nd = new NguoiDung_Ctrl();
            Doimatkhau_Ctrl doiMK = new Doimatkhau_Ctrl();
            if (doiMK.KiemTra(txtUser.Text, nd.Md5(txtPass_old.Text), nd.Md5(txtPass_new.Text), nd.Md5(txtPass_prenew.Text)))
            {
                NguoiDung_InFo ndinfo = new NguoiDung_InFo();
                ndinfo.MaNguoiDung = doiMK.LayMaND(txtUser.Text, nd.Md5(txtPass_old.Text));
                ndinfo.MatKhau = nd.Md5(txtPass_new.Text);
                doiMK.DoiMatKhau(ndinfo);
            }
            frmDoimatkhau_Load(sender, e);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}