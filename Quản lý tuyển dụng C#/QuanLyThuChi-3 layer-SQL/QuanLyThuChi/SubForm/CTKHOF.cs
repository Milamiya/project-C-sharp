using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QuanLyThuChi.SubForm
{
    public partial class CTKHOF : Form
    {
        public CTKHOF()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
            CTKHO_DTO ctkho = new CTKHO_DTO();
            ctkho.MaHang = cbo2.SelectedValue.ToString();
            ctkho.MaKho = cbo1.Text;
            ctkho.SoLuong = Convert.ToInt16(txt1.Text);
            CTKHO_BUS.Them1CTKho(ctkho);
            dgv1.DataSource = CTKHO_BUS.DSCTKHO();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                CTKHO_DTO ctkho = new CTKHO_DTO();
                ctkho.MaHang = cbo2.SelectedValue.ToString();
                ctkho.MaKho = cbo1.Text;
                ctkho.SoLuong = Convert.ToInt16(txt1.Text);
                CTKHO_BUS.Sua1CTKho(ctkho);
                dgv1.DataSource = CTKHO_BUS.DSCTKHO();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            CTKHO_DTO ctkho=new CTKHO_DTO();
            ctkho.MaHang=cbo2.SelectedValue.ToString();
            ctkho.MaKho=cbo1.Text;
            CTKHO_BUS.Xoa1CTKho(ctkho);
            dgv1.DataSource = CTKHO_BUS.DSCTKHO();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void loadcbo()
        {
            cbo1.ValueMember = "MaKho";
            cbo1.DisplayMember = "MaKho";
            cbo1.DataSource = KHO_BUS.DSKHO();
            cbo2.DisplayMember = "TenHang";
            cbo2.ValueMember = "MaHang";
            cbo2.DataSource = HANGHOA_BUS.DSHANGHOA();
        }
        private void CTKHOF_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            dgv1.DataSource = CTKHO_BUS.DSCTKHO();
            loadcbo();
        }
    }
}
