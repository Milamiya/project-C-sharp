using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYHOSONHANVIEN.GiaoDien;
using QUANLYHOSONHANVIEN.Controller;
using QUANLYHOSONHANVIEN.DataLayer;

namespace QUANLYHOSONHANVIEN.GiaoDien
{
    public partial class frmNguoiDung : DevComponents .DotNetBar .Office2007Form
    {
        public frmNguoiDung()
        {
            InitializeComponent();
        }
        string nguoidung;
        public frmNguoiDung(string str):this()
        {
            nguoidung = str;
        }
        LoainguoidungCtr ctr_loainuoidung = new LoainguoidungCtr();
        NguoiDungCtr ctr_nguoidung = new NguoiDungCtr();
        NguoiDungData data = new NguoiDungData();

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            loadNguoiDung();
        }
        private void loadNguoiDung()
        {
            MessageBox.Show(nguoidung);
            ctr_loainuoidung.HienthiDataGridViewComboBoxColumn(colQuyen);
            ctr_nguoidung.HienthiBnDataGridview(dataGridViewNguoiDung,nguoidung);
            if (dataGridViewNguoiDung.Rows.Count > 0)
            {
                btnCapnhat.Enabled = true;
                btnXoa.Enabled = true;
                btnDoimatkhau.Enabled = true;
            }
            else
            {
                btnCapnhat.Enabled = false;
                btnXoa.Enabled = false;
                btnDoimatkhau.Enabled = false;
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewNguoiDung.CurrentRow;
            string maso = row.Cells["colmaso"].Value.ToString();

            string username = row.Cells["colusername"].Value.ToString();
            string loaitaikhoancol = row.Cells["colquyen"].Value.ToString();
            data.UpdateNguoiDung(username, loaitaikhoancol,maso);
            loadNguoiDung();
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmTaoNguoiDungMoi ftao = new frmTaoNguoiDungMoi();
            ftao.ShowDialog();
            loadNguoiDung();
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewNguoiDung.CurrentRow;
            string user = row.Cells["colUsername"].Value.ToString();
            frmDoiMatKhau fdoimk = new frmDoiMatKhau(user);
            fdoimk.ShowDialog();
            loadNguoiDung();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewNguoiDung.CurrentRow;
            string maso = row.Cells["colmaso"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá tài khoản này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data.DeleteNguoiDung(maso);
                loadNguoiDung();
            }
        }
    }
}
