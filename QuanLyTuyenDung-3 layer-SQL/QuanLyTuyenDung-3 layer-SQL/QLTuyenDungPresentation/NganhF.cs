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
    public partial class NganhF : Form
    {
        public NganhF()
        {
            InitializeComponent();
        }

        private void NganhF_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            dgv1.DataSource = Nganh_BLL.DSNganh();
        }

        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private Boolean check()
        {
            if (txt1.TextLength < 1 || txt2.TextLength < 1 || txt1.TextLength > 5 || txt2.TextLength > 100)
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
        Nganh_DTO huyen = new Nganh_DTO();
        private void btnthem_Click_1(object sender, EventArgs e)
        {
            if (check() == true)
            {
                huyen.MaNganh = txt1.Text;
                huyen.TenNganh = txt2.Text;
                Nganh_BLL.Them1Nganh(huyen);
                dgv1.DataSource = Nganh_BLL.DSNganh();
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
                huyen.MaNganh = txt1.Text;
                huyen.TenNganh = txt2.Text;
                Nganh_BLL.Sua1Nganh(huyen);
                dgv1.DataSource = Nganh_BLL.DSNganh();
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

                huyen.MaNganh = txt1.Text;
                Nganh_BLL.Xoa1Nganh(huyen);
                dgv1.DataSource = Nganh_BLL.DSNganh();
            }
        }
    }
}
