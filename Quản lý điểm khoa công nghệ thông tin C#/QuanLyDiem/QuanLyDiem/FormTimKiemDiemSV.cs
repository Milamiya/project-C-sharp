using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using DAL;
using System.Linq;
using System.Text;
using BLL;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class FormTimKiemDiemSV : Form
    {
        public FormTimKiemDiemSV()
        {
            InitializeComponent();
        }
        ClassDAL dal = new ClassDAL();
        ClassBLL business = new ClassBLL();
        private void btnTim_Click(object sender, EventArgs e)
        {
            string sql = "select HocPhan.TenHP,SinhVien.TenSV,KetQua.DiemQT,KetQua.DiemThi,KetQua.DiemXepLoai from SinhVien,HocPhan,KetQua,NhomHocPhan where SinhVien.MaSV = KetQua.MaSV And		HocPhan.MaHP=NhomHocPhan.MaHP And		HocPhan.MaHP='"+cmbMaHP.SelectedValue.ToString()+"' And		KetQua.MaNhomHP=NhomHocPhan.MaNhomHP And		KetQua.MaSV='"+txtMaSV.Text+"'";
            dgvKetQua.DataSource = business.ShowData_where(sql);
        }

        private void txtMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        private void txtMaHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }
        public void loadCmbMaHP()
        {
            SqlConnection con = dal.GetConnect();
            con.Open();
            SqlCommand cm = new SqlCommand("Select *from HocPhan", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.cmbMaHP.DisplayMember = "TenHP";
            this.cmbMaHP.ValueMember = "MaHP";
            this.cmbMaHP.DataSource = dt;
        }
        private void FormTimKiemDiemSV_Load(object sender, EventArgs e)
        {
            loadCmbMaHP();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
