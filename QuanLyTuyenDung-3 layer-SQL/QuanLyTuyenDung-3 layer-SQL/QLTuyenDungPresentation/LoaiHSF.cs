using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTuyenDungPresentation;
using DTO;
using BUS;
namespace QLTuyenDungPresentation
{
    public partial class LoaiHSF : Form
    {
        public LoaiHSF()
        {
            InitializeComponent();
        }

        private void LoaiHSF_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            dgv1.DataSource = LoaiHoSo_BLL.DSLoaiHS();
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
        LoaiHoSo_DTO huyen = new LoaiHoSo_DTO();
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                huyen.MaLoaiHS = txt1.Text;
                huyen.TenHS = txt2.Text;
                LoaiHoSo_BLL.Them1LoaiHS(huyen);
                dgv1.DataSource = LoaiHoSo_BLL.DSLoaiHS();
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
                huyen.MaLoaiHS = txt1.Text;
                huyen.TenHS = txt2.Text;
                LoaiHoSo_BLL.Sua1LoaiHS(huyen);
                dgv1.DataSource = LoaiHoSo_BLL.DSLoaiHS();
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

                huyen.MaLoaiHS = txt1.Text;
                LoaiHoSo_BLL.Xoa1LoaiHS(huyen);
                dgv1.DataSource = LoaiHoSo_BLL.DSLoaiHS();
            }
        }


    }
}
