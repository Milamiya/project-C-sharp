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
    public partial class NHANVIENF : Form
    {
        public NHANVIENF()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                NHANVIEN_DTO nv = new NHANVIEN_DTO();
                nv.MaNV = txt1.Text;
                nv.HoTen = txt2.Text;
                nv.NgaySinh = dtp1.Value;
                nv.SoDienThoai = txt3.Text;
                nv.DiaChi = txt4.Text;
                NHANVIEN_BUS.Them1NhanVien(nv);
                dgv1.DataSource = NHANVIEN_BUS.DSNHANVIEN();
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
                NHANVIEN_DTO nv = new NHANVIEN_DTO();
                nv.MaNV = txt1.Text;
                nv.HoTen = txt2.Text;
                nv.NgaySinh = dtp1.Value;
                nv.SoDienThoai = txt3.Text;
                nv.DiaChi = txt4.Text;
                NHANVIEN_BUS.Sua1NhanVien(nv);
                dgv1.DataSource = NHANVIEN_BUS.DSNHANVIEN();
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
                NHANVIEN_DTO nv = new NHANVIEN_DTO();
                nv.MaNV = txt1.Text;                
                NHANVIEN_BUS.Xoa1NhanVien(nv);
                dgv1.DataSource = NHANVIEN_BUS.DSNHANVIEN();
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

        private void NHANVIENF_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Text = String.Empty;
            dgv1.DataSource = NHANVIEN_BUS.DSNHANVIEN();
        }
    }
}
