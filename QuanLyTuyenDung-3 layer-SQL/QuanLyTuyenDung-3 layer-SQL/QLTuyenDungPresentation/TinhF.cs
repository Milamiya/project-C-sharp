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
    public partial class TinhF : Form
    {
        public TinhF()
        {
            InitializeComponent();
        }

        private void TinhF_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            dgv1.DataSource = Tinh_BLL.DSTinh();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

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
        Tinh_DTO huyen = new Tinh_DTO();
        private void btnthem_Click_1(object sender, EventArgs e)
        {
            if (check() == true)
            {
                huyen.MaTinh = txt1.Text;
                huyen.TenTinh = txt2.Text;
                Tinh_BLL.Them1Tinh(huyen);
                dgv1.DataSource = Tinh_BLL.DSTinh();
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
                huyen.MaTinh = txt1.Text;
                huyen.TenTinh = txt2.Text;
                Tinh_BLL.Sua1Tinh(huyen);
                dgv1.DataSource = Tinh_BLL.DSTinh();
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
                huyen.MaTinh = txt1.Text;
           
                Tinh_BLL.Xoa1Tinh(huyen);
                dgv1.DataSource = Tinh_BLL.DSTinh();
            }
        }
        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            Close();
        }

    }
}
