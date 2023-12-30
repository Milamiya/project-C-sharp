using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using BLL;
using DAL;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class FormTimKiemThongTin : Form
    {
        public FormTimKiemThongTin()
        {
            InitializeComponent();
        }
        ClassBLL business = new ClassBLL();
        ClassDAL dal = new ClassDAL();
        private void btnTim_Click(object sender, EventArgs e)
        {
            string sql = "select TenHP,MaNhomHP,SoTC,SoTietTH,SoTietLT,PhanTramDQT,PhanTramDT,TenGV  "
                + "from HocPhan,NhomHocPhan,GiangVien "
                + "where HocPhan.MaHP=NhomHocPhan.MaHP "
                + "and HocPhan.MaHP='" + cmbMaHP.SelectedValue.ToString()
                +"' and NhomHocPhan.MaGV=GiangVien.MaGV";
            dgvKetQua.DataSource = business.ShowData_where(sql);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void FormTimKiemThongTin_Load(object sender, EventArgs e)
        {
            loadCmbMaHP();
        }
    }
}
