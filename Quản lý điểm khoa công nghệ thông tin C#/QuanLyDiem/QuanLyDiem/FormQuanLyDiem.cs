using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BLL;
using DAL;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class FormQuanLyDiem : Form
    {
        public FormQuanLyDiem()
        {
            InitializeComponent();
        }
        ClassBLL business = new ClassBLL();
        ClassDAL dal = new ClassDAL();
        private void FormQuanLyDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cNPM_1DataSet4.HocKy' table. You can move, or remove it, as needed.
            this.hocKyTableAdapter.Fill(this.cNPM_1DataSet4.HocKy);

        }
        public void loadCmbMaNhomHP(string MaHK)
        {
            SqlConnection con = dal.GetConnect();
            con.Open();
            SqlCommand cm = new SqlCommand("Select MaNhomHP from NhomHocPhan,KeHoachGiangDay where NhomHocPhan.MaKHGD=KeHoachGiangDay.MaKHGD and KeHoachGiangDay.MaHK='"+MaHK+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.cmbMaNhomHP.DisplayMember = "MaNhomHP";
            this.cmbMaNhomHP.ValueMember = "MaNhomHP";
            this.cmbMaNhomHP.DataSource = dt;
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            string sql = "select KetQua.MaSV,KetQua.DiemQT,KetQua.DiemThi,KetQua.DiemXepLoai from KetQua,NhomHocPhan,KeHoachGiangDay,HocKy,HocPhan where KetQua.MaNhomHP=NhomHocPhan.MaNhomHP and NhomHocPhan.MaNhomHP='"+cmbMaNhomHP.SelectedValue.ToString()+"' and NhomHocPhan.MaKHGD=KeHoachGiangDay.MaKHGD and KeHoachGiangDay.MaHK=HocKy.MaHK and HocKy.MaHK='"+cmbMaHK.SelectedValue.ToString()+"' and NhomHocPhan.MaHP=HocPhan.MaHP ";
            dgvKetQua.DataSource = business.ShowData_where(sql);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int dong;
        private void dgvKetQua_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtMaSV.Text = dgvKetQua.Rows[dong].Cells[0].Value.ToString();
            txtDiemQuaTrinh.Text = dgvKetQua.Rows[dong].Cells[1].Value.ToString();
            txtDiemThi.Text = dgvKetQua.Rows[dong].Cells[2].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaSV = txtMaSV.Text;
            string MaNhomHP = cmbMaNhomHP.SelectedValue.ToString();
            double DiemThi = Convert.ToDouble(txtDiemThi.Text);
            double DiemQT = Convert.ToDouble(txtDiemQuaTrinh.Text);
            string sql = "MaSV='" + MaSV + "'";
            business.Delete("KetQua", sql);
            sql = "'"+MaSV+"','"+MaNhomHP+"',"+DiemQT+","+DiemThi+",'','',''";
            business.Insert("KetQua", sql);
            btnLoc_Click(sender, e);
        }

        private void txtMaNhomHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        private void cmbMaHK_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmbMaHK.SelectedIndex!=-1)
                loadCmbMaNhomHP(cmbMaHK.SelectedValue.ToString());
        }
    }
}
