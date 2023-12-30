using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DAL;
using BLL;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class FormXemDiemNhomHP : Form
    {
        public FormXemDiemNhomHP()
        {
            InitializeComponent();
        }
        ClassBLL business = new ClassBLL();
        ClassDAL dal = new ClassDAL();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void loadCmbMaNhomHP()
        {
            SqlConnection con = dal.GetConnect();
            con.Open();
            if(cmbMaHK.SelectedIndex!=-1)
            {
                SqlCommand cm = new SqlCommand("Select *from NhomHocPhan,KeHoachGiangDay where NhomHocPhan.MaKHGD=KeHoachGiangDay.MaKHGD and KeHoachGiangDay.MaHK='"+cmbMaHK.SelectedValue.ToString()+"'", con);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.cmbMaNhomHP.DisplayMember = "MaNhomHP";
                this.cmbMaNhomHP.ValueMember = "MaNhomHP";
                this.cmbMaNhomHP.DataSource = dt;
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
        private void FormXemDiemNhomHP_Load(object sender, EventArgs e)
        {
            loadCmbMaHK();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sql = "select MaSV,DiemQT,DiemThi,DiemXepLoai from KetQua where KetQua.MaNhomHP='"+cmbMaNhomHP.SelectedValue.ToString()+"'";
            dgvKetQua.DataSource = business.ShowData_where(sql);
        }

        private void cmbMaHK_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbMaNhomHP.Enabled = true;
            loadCmbMaNhomHP();
        }

    }
}
