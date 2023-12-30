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
    public partial class TrinhDoF : Form
    {
        public TrinhDoF()
        {
            InitializeComponent();
        }

        private void TrinhDoF_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            dgv1.DataSource = TrinhDo_BLL.DSTrinhDo();
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
        TrinhDo_DTO huyen = new TrinhDo_DTO();
        private void btnthem_Click_1(object sender, EventArgs e)
        {
            if (check() == true)
            {
                huyen.MaTrinhDo = txt1.Text;
                huyen.TenTrinhDo = txt2.Text;
                TrinhDo_BLL.Them1TrinhDo(huyen);
                dgv1.DataSource = TrinhDo_BLL.DSTrinhDo();
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
                huyen.MaTrinhDo = txt1.Text;
                huyen.TenTrinhDo = txt2.Text;
                TrinhDo_BLL.Sua1TrinhDo(huyen);
                dgv1.DataSource = TrinhDo_BLL.DSTrinhDo();
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

                huyen.MaTrinhDo = txt1.Text;
         
                TrinhDo_BLL.Xoa1TrinhDo(huyen);
                dgv1.DataSource = TrinhDo_BLL.DSTrinhDo();
            }
        }

    }
}
