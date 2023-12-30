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
    public partial class PHIEUTHUCHIF : Form
    {
        public PHIEUTHUCHIF()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                PHIEUTHUCHI_DTO p = new PHIEUTHUCHI_DTO();
                p.SoPhieu = txt1.Text;
                p.MaNV = cbo1.SelectedValue.ToString();
                p.Ngay = dtp1.Value;
                if (cbo2.Text == "Thu")
                {
                    p.ThuChi = true;
                }
                else
                {
                    p.ThuChi = false;
                }
                p.LyDo = txt2.Text;
                p.SoTien = Convert.ToDecimal(txt3.Text);
                PHIEUTHUCHI_BUS.Them1PhieuThuChi(p);
                dgv1.DataSource = PHIEUTHUCHI_BUS.DSPHIEUTHUCHI();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                PHIEUTHUCHI_DTO p = new PHIEUTHUCHI_DTO();
                p.SoPhieu = txt1.Text;
                p.MaNV = cbo1.SelectedValue.ToString();
                p.Ngay = dtp1.Value;
                if (cbo2.Text == "Thu")
                {
                    p.ThuChi = true;
                }
                else
                {
                    p.ThuChi = false;
                }
                p.LyDo = txt2.Text;
                p.SoTien = Convert.ToDecimal(txt3.Text);
                PHIEUTHUCHI_BUS.Sua1PhieuThuChi(p);
                dgv1.DataSource = PHIEUTHUCHI_BUS.DSPHIEUTHUCHI();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                PHIEUTHUCHI_DTO p = new PHIEUTHUCHI_DTO();
                p.SoPhieu = txt1.Text;
                PHIEUTHUCHI_BUS.Xoa1PhieuThuChi(p);
                dgv1.DataSource = PHIEUTHUCHI_BUS.DSPHIEUTHUCHI();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            InPhieuThuChiF ip = new InPhieuThuChiF();
            ip.Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void loadcbo()
        {
            cbo1.ValueMember = "MaNV";
            cbo1.DisplayMember = "HoTen";
            cbo1.DataSource = NHANVIEN_BUS.DSNHANVIEN();
        }
        private void PHIEUTHUCHIF_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            dgv1.DataSource = PHIEUTHUCHI_BUS.DSPHIEUTHUCHI();
            loadcbo();
        }
    }
}
