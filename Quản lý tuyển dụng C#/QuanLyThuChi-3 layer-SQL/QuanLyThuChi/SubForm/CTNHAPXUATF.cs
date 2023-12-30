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
    public partial class CTNHAPXUATF : Form
    {
        public CTNHAPXUATF()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                CTNHAPXUAT_DTO ct = new CTNHAPXUAT_DTO();
                ct.MaHang = cbo2.SelectedValue.ToString();
                ct.SoPhieu = cbo1.Text;
                ct.SoLuong = Convert.ToInt16(txt1.Text);
                CTNHAPXUAT_BUS.Them1CTNhapXuat(ct);
                dgv1.DataSource = CTNHAPXUAT_BUS.DSCTNHAPXUAT();
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
                CTNHAPXUAT_DTO ct = new CTNHAPXUAT_DTO();
                ct.MaHang = cbo2.SelectedValue.ToString();
                ct.SoPhieu = cbo1.Text;
                ct.SoLuong = Convert.ToInt16(txt1.Text);
                CTNHAPXUAT_BUS.Sua1CTNhapXuat(ct);
                dgv1.DataSource = CTNHAPXUAT_BUS.DSCTNHAPXUAT();
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
                CTNHAPXUAT_DTO ct = new CTNHAPXUAT_DTO();
                ct.MaHang = cbo2.SelectedValue.ToString();
                ct.SoPhieu = cbo1.Text;
                
                CTNHAPXUAT_BUS.Xoa1CTNhapXuat(ct);
                dgv1.DataSource = CTNHAPXUAT_BUS.DSCTNHAPXUAT();
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
        private void loadcbo()
        {
            cbo1.ValueMember = "SoPhieu";
            cbo1.DisplayMember = "SoPhieu";
            cbo1.DataSource = PHIEUNHAPXUAT_BUS.DSPHIEUNHAPXUAT();
            cbo2.DisplayMember = "TenHang";
            cbo2.ValueMember = "MaHang";
            cbo2.DataSource = HANGHOA_BUS.DSHANGHOA();
        }
        private void CTNHAPXUATF_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            dgv1.DataSource = CTNHAPXUAT_BUS.DSCTNHAPXUAT();
            loadcbo();
        }
    }
}
