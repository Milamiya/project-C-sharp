using System;
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
    public partial class QuocGiaF : Form
    {
        public QuocGiaF()
        {
            InitializeComponent();
        }

        private void QuocGiaF_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            dgv1.DataSource = QuocGia_BLL.DSQuocGia();
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
        QuocGia_DTO huyen = new QuocGia_DTO();
        private void btnthem_Click_1(object sender, EventArgs e)
        {
            if (check() == true)
            {
                huyen.MaQG = txt1.Text;
                huyen.TenQG = txt2.Text;
                QuocGia_BLL.Them1QuocGia(huyen);
                dgv1.DataSource = QuocGia_BLL.DSQuocGia();
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ, vui lòng nhập lại", "Lỗi");
                xoathongtin();
            }
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            if (check() == true)
            {
                huyen.MaQG = txt1.Text;
                huyen.TenQG = txt2.Text;
                QuocGia_BLL.Sua1QuocGia(huyen);
                dgv1.DataSource = QuocGia_BLL.DSQuocGia();
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ, vui lòng nhập lại", "Lỗi");
                xoathongtin();
            }
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            if (txt1.TextLength < 1 || txt1.TextLength > 5)
            {
                MessageBox.Show("Thông tin không hợp lệ, vui lòng nhập lại", "Lỗi");
                xoathongtin();
            }
            else
            {
                huyen.MaQG = txt1.Text;
                QuocGia_BLL.Xoa1QuocGia(huyen);
                dgv1.DataSource = QuocGia_BLL.DSQuocGia();
            }
        }

    }
}
