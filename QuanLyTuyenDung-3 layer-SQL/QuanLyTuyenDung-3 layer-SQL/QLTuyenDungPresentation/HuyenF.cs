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
    public partial class HuyenF : Form
    {
        public HuyenF()
        {
            InitializeComponent();
        }

        private void HuyenF_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            dgv1.DataSource = Huyen_BLL.DSHuyen();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private Boolean check()
        {
            if (txt1.TextLength < 1 || txt2.TextLength < 1 || txt1.TextLength > 5 || txt2.TextLength > 15 )
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
        Huyen_DTO huyen = new Huyen_DTO();
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                huyen.MaHuyen = txt1.Text;
                huyen.TenHuyen = txt2.Text;
                Huyen_BLL.Them1Huyen(huyen);
                dgv1.DataSource = Huyen_BLL.DSHuyen();
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ hoặc đã tồn tại, vui lòng nhập lại", "Lỗi");
                xoathongtin();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                huyen.MaHuyen = txt1.Text;
                huyen.TenHuyen = txt2.Text;
                Huyen_BLL.Sua1Huyen(huyen);
                dgv1.DataSource = Huyen_BLL.DSHuyen();
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ hoặc đã không tồn tại, vui lòng nhập lại", "Lỗi");
                xoathongtin();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txt1.TextLength < 1 || txt1.TextLength > 5)
            {
                MessageBox.Show("Thông tin không hợp lệ hoặc không tồn tại, vui lòng nhập lại", "Lỗi");
                xoathongtin();
            }
            else
            {
                
                huyen.MaHuyen = txt1.Text;
                huyen.TenHuyen = txt2.Text;
                Huyen_BLL.Xoa1Huyen(huyen);
                dgv1.DataSource = Huyen_BLL.DSHuyen();
            }
        }
    }
}
