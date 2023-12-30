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

namespace QuanLyThuChi
{
    public partial class KHOF : Form
    {
        public KHOF()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                KHO_DTO k = new KHO_DTO();
                k.MaKho = txt1.Text;
                k.TenKho = txt2.Text;
                k.DiaDiem = txt3.Text;
                KHO_BUS.Them1Kho(k);
                dgv1.DataSource = KHO_BUS.DSKHO();
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
                KHO_DTO k = new KHO_DTO();
                k.MaKho = txt1.Text;
                k.TenKho = txt2.Text;
                k.DiaDiem = txt3.Text;
                KHO_BUS.Sua1Kho(k);
                dgv1.DataSource = KHO_BUS.DSKHO();
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
                KHO_DTO k = new KHO_DTO();
                k.MaKho = txt1.Text;
                KHO_BUS.Xoa1Kho(k);
                dgv1.DataSource = KHO_BUS.DSKHO();
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

        private void KHOF_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            dgv1.DataSource = KHO_BUS.DSKHO();
        }
    }
}
