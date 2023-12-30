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
namespace QuanLyThuChi.SubForm
{
    public partial class HANGHOAF : Form
    {
        public HANGHOAF()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                HANGHOA_DTO h = new HANGHOA_DTO();
                h.MaHang = txt1.Text;
                h.TenHang = txt2.Text;
                h.DonViTinh = txt3.Text;
                h.DonGia = Convert.ToDecimal(txt4.Text);
                HANGHOA_BUS.Them1HangHoa(h);
                dgv1.DataSource = HANGHOA_BUS.DSHANGHOA();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                HANGHOA_DTO h = new HANGHOA_DTO();
                h.MaHang = txt1.Text;
                h.TenHang = txt2.Text;
                h.DonViTinh = txt3.Text;
                h.DonGia = Convert.ToDecimal(txt4.Text);
                HANGHOA_BUS.Sua1HangHoa(h);
                dgv1.DataSource = HANGHOA_BUS.DSHANGHOA();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                HANGHOA_DTO h = new HANGHOA_DTO();
                h.MaHang = txt1.Text;
                HANGHOA_BUS.Xoa1HangHoa(h);
                dgv1.DataSource = HANGHOA_BUS.DSHANGHOA();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HANGHOAF_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            dgv1.DataSource = HANGHOA_BUS.DSHANGHOA();
        }
    }
}
