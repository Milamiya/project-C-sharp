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
    public partial class PHIEUNHAPXUATF : Form
    {
        public PHIEUNHAPXUATF()
        {
            InitializeComponent();
        }

        private void btnthemct_Click(object sender, EventArgs e)
        {
            CTNHAPXUATF ct = new CTNHAPXUATF();
            ct.Show();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                PHIEUNHAPXUAT_DTO p = new PHIEUNHAPXUAT_DTO();
                p.SoPhieu = txt1.Text;
                p.MaNV = cbo1.SelectedValue.ToString();
                p.Ngay = dtp1.Value;
                p.LyDo = txt2.Text;
                if (cbo2.Text == "Thu")
                {
                    p.NhapXuat = true;
                }
                else
                {
                    p.NhapXuat = false;
                }
                PHIEUNHAPXUAT_BUS.Them1PhieuNhapXuat(p);
                dgv1.DataSource = PHIEUNHAPXUAT_BUS.DSPHIEUNHAPXUAT();
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
                PHIEUNHAPXUAT_DTO p = new PHIEUNHAPXUAT_DTO();
                p.SoPhieu = txt1.Text;
                p.MaNV = cbo1.SelectedValue.ToString();
                p.Ngay = dtp1.Value;
                p.LyDo = txt2.Text;
                if (cbo2.Text == "Thu")
                {
                    p.NhapXuat = true;
                }
                else
                {
                    p.NhapXuat = false;
                }
                PHIEUNHAPXUAT_BUS.Sua1PhieuNhapXuat(p);
                dgv1.DataSource = PHIEUNHAPXUAT_BUS.DSPHIEUNHAPXUAT();
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
                PHIEUNHAPXUAT_DTO p = new PHIEUNHAPXUAT_DTO();
                p.SoPhieu = txt1.Text;
                p.MaNV = cbo1.SelectedValue.ToString();
                p.Ngay = dtp1.Value;
                p.LyDo = txt2.Text;
                if (cbo2.Text == "Thu")
                {
                    p.NhapXuat = true;
                }
                else
                {
                    p.NhapXuat = false;
                }
                PHIEUNHAPXUAT_BUS.Xoa1PhieuNhapXuat(p);
                dgv1.DataSource = PHIEUNHAPXUAT_BUS.DSPHIEUNHAPXUAT();
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
            cbo1.ValueMember = "MaNV";
            cbo1.DisplayMember = "HoTen";
            cbo1.DataSource = NHANVIEN_BUS.DSNHANVIEN();
        }
        private void PHIEUNHAPXUATF_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            dgv1.DataSource = PHIEUNHAPXUAT_BUS.DSPHIEUNHAPXUAT();
            loadcbo();
        }
    }
}
