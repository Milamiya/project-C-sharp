using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using BLL;
using System.Linq;
using System.Text;
using DAL;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }
        ClassDAL dal = new ClassDAL();
        ClassBLL business = new ClassBLL();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void loadCmbLop()
        {
            SqlConnection con = dal.GetConnect();
            con.Open();
            SqlCommand cm = new SqlCommand("Select *from Lop", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.cmbMa.DisplayMember = "MaLop";
            this.cmbMa.ValueMember = "MaLop";
            this.cmbMa.DataSource = dt;
        }
        public void loadCmbKhoiLop()
        {
            SqlConnection con = dal.GetConnect();
            con.Open();
            SqlCommand cm = new SqlCommand("Select *from KhoiLop", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);           
            this.cmbMa.DisplayMember = "MaKhoiLop";
            this.cmbMa.ValueMember = "MaKhoiLop";
            this.cmbMa.DataSource = dt;
        }
        private void cmbThongKeTheo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbThongKeTheo.SelectedIndex == 0)
            {
                loadCmbLop();
                lblMa.Text = "Mã Lớp";
                cmbMa.Visible = true;
                lblMa.Visible = true;
            }
            if (cmbThongKeTheo.SelectedIndex == 1)
            {
                loadCmbKhoiLop();
                lblMa.Text = "Mã Khối Lớp";
                cmbMa.Visible = true;
                lblMa.Visible = true;
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            
            if (cmbThongKeTheo.SelectedIndex != -1)
            {
                if (cmbThongKeTheo.SelectedIndex == 0)
                {
                    if (Convert.ToInt32(cmbMa.SelectedIndex) != -1)
                    {
                        dgvThongKe.DataSource= business.ThongKeLop(cmbMaHK.SelectedValue.ToString(),cmbMa.SelectedValue.ToString(),Convert.ToInt32(cmbXepLoai.SelectedIndex));
                    }
                }
                else
                {
                    if (Convert.ToInt32(cmbMa.SelectedIndex) != -1)
                    {
                        dgvThongKe.DataSource = business.ThongKeKhoiLop(cmbMaHK.SelectedValue.ToString(), cmbMa.SelectedValue.ToString(), Convert.ToInt32(cmbXepLoai.SelectedIndex));
                    }
                }
            }
        }
        public void loadCmbMaHK()
        {
            SqlConnection con = dal.GetConnect();
            con.Open();
            SqlCommand cm = new SqlCommand("Select *from HocKy", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.cmbMaHK.DisplayMember = "MaHK";
            this.cmbMaHK.ValueMember = "MaHK";
            this.cmbMaHK.DataSource = dt;
        }
        private void FormThongKe_Load(object sender, EventArgs e)
        {
            loadCmbMaHK();
        }
    }
}
