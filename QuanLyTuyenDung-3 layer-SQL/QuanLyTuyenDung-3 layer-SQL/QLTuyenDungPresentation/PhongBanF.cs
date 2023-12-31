﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QLTuyenDungPresentation
{
    public partial class PhongBanF : Form
    {
        public PhongBanF()
        {
            InitializeComponent();
        }

        private void PhongBanF_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            dgv1.DataSource = PhongBan_BLL.DSPhongBan();
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private Boolean check()
        {
            if (txt1.TextLength < 1 || txt2.TextLength < 1 || txt1.TextLength > 5 || txt2.TextLength > 15)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void xoathongtin()
        {
            txt1.Clear();
            txt2.Clear();

        }
        PhongBan_DTO huyen = new PhongBan_DTO();
        private void btnthem_Click_1(object sender, EventArgs e)
        {
            if (check() == true)
            {
                huyen.MaPB = txt1.Text;
                huyen.TenPB = txt2.Text;
                PhongBan_BLL.Them1PhongBan(huyen);
                dgv1.DataSource = PhongBan_BLL.DSPhongBan();
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ hoặc đã tồn tại, vui lòng nhập lại", "Lỗi");
                xoathongtin();
            }
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            if (check() == true)
            {
                huyen.MaPB = txt1.Text;
                huyen.TenPB = txt2.Text;
                PhongBan_BLL.Sua1PhongBan(huyen);
                dgv1.DataSource = PhongBan_BLL.DSPhongBan();
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ hoặc đã không tồn tại, vui lòng nhập lại", "Lỗi");
                xoathongtin();
            }
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            if (txt1.TextLength < 1 || txt1.TextLength > 5)
            {
                MessageBox.Show("Thông tin không hợp lệ hoặc không tồn tại, vui lòng nhập lại", "Lỗi");
                xoathongtin();
            }
            else
            {
                huyen.MaPB = txt1.Text;
                PhongBan_BLL.Xoa1PhongBan(huyen);
                dgv1.DataSource = PhongBan_BLL.DSPhongBan();
            }
        }
    }
}
