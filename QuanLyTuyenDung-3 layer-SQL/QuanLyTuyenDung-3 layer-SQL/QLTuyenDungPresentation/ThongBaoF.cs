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
    public partial class ThongBaoF : Form
    {
        public ThongBaoF()
        {
            InitializeComponent();
        }

        private void ThongBaoF_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            dgv1.DataSource = ThongBao_BLL.DSThongBao();
        }

        private Boolean check()
        {
            if (txt1.TextLength < 1 || txt2.TextLength < 1 || txt1.TextLength > 10 || txt2.TextLength > 10
                || txt3.TextLength < 1 || txt3.TextLength > 50)
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
            txt3.Clear();
        }

        ThongBao_DTO tb = new ThongBao_DTO();
        private void btnthoat_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txt1.TextLength < 1 || txt1.TextLength > 10)
            {
                MessageBox.Show("Thông tin không hợp lệ, vui lòng nhập lại", "Lỗi");
                xoathongtin();
            }
            else
            {
                tb.MaTB = txt1.Text;                
                ThongBao_BLL.Xoa1ThongBao(tb);
                dgv1.DataSource = ThongBao_BLL.DSThongBao();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                tb.MaTB = txt1.Text;
                tb.LoaiTB = txt2.Text;
                tb.LyDo = txt3.Text;
                ThongBao_BLL.Sua1ThongBao(tb);
                dgv1.DataSource = ThongBao_BLL.DSThongBao();
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ, vui lòng nhập lại", "Lỗi");
                xoathongtin();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (check() == true)
            {
                tb.MaTB = txt1.Text;
                tb.LoaiTB = txt2.Text;
                tb.LyDo = txt3.Text;
                ThongBao_BLL.Them1ThongBao(tb);
                dgv1.DataSource = ThongBao_BLL.DSThongBao();
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ hoặc đã tồn tại, vui lòng nhập lại", "Lỗi");
                xoathongtin();
            }
        }
    }
}
