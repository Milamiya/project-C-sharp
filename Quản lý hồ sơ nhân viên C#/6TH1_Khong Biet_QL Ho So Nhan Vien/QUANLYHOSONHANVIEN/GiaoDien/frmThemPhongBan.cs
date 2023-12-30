using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYHOSONHANVIEN.DataLayer;

namespace QUANLYHOSONHANVIEN.GiaoDien
{
    public partial class frmThemPhongBan : DevComponents .DotNetBar .Office2007Form
    {
        public frmThemPhongBan()
        {
            InitializeComponent();
        }

        private void frmThemPhongBan_Load(object sender, EventArgs e)
        {
            
        }
        PhongBanData data = new PhongBanData();
        private bool kiemtra()
        {
            if (txtTenphong.Text == "")
            {
                txtTenphong.BackColor = Color.Yellow;
                txtTenphong.Focus();
                return false;
            }
            return true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                data.ThemPhongBan(txtTenphong.Text  ,txtMota.Text);
                this.Close();
            }
        }

        private void txtTenphong_TextChanged(object sender, EventArgs e)
        {
            txtTenphong.BackColor = Color.White;
        }
    }
}
