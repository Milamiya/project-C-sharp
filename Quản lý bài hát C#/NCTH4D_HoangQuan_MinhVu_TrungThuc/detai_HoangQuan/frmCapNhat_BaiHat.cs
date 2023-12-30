using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_Tier;

namespace detai_HoangQuan
{
    public partial class frmCapNhat_BaiHat : Form
    {
        public frmCapNhat_BaiHat()
        {
            InitializeComponent();
        }
        private DataTable dtTheLoai;
        private DataTable dtAlbum;
        private DataTable dtCasi;
        private DataTable dtTacGia;
        private DataTable dtNhaSanXuat;

        public string ma, ten, loibaihat;
        public string matheloai, maalbum, macasi, matacgia, mahangsanxuat;
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenBaiHat.Text = txtLoiBaiHat.Text = "";
            txtTenBaiHat.Focus();

            cboTheLoai.SelectedIndex = 0;
            cboAlbum.SelectedIndex = 0;
            cboCasi.SelectedIndex = 0;
            cbotacGia.SelectedIndex = 0;
            cboHangsanxuat.SelectedIndex = 0;
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmCapNhat_BaiHat_Load(object sender, EventArgs e)
        {
            txtMaBaiHat.Text = ma; txtTenBaiHat.Text = ten; txtLoiBaiHat.Text = loibaihat;
            txtTenBaiHat.SelectAll(); txtTenBaiHat.Focus();
            this.Text = "Cập nhật bài hát [" + ten + "]";

            dtTheLoai = new TheLoai_BUS().getTheLoai();
            cboTheLoai.DataSource = dtTheLoai;
            cboTheLoai.DisplayMember = "tentheloai";
            cboTheLoai.ValueMember = "matheloai";

            dtAlbum = new Album_BUS().getAlbum();
            cboAlbum.DataSource = dtAlbum;
            cboAlbum.DisplayMember = "tenalbum";
            cboAlbum.ValueMember = "maalbum";

            dtCasi = new CaSi_BUS().getCaSi();
            cboCasi.DataSource = dtCasi;
            cboCasi.DisplayMember = "tencasi";
            cboCasi.ValueMember = "macasi";

            dtTacGia = new TacGia_BUS().getTacGia();
            cbotacGia.DataSource = dtTacGia;
            cbotacGia.DisplayMember = "tentacgia";
            cbotacGia.ValueMember = "matacgia";

            dtNhaSanXuat = new NhaSanXuat_BUS().getNhaSanXuat();
            cboHangsanxuat.DataSource = dtNhaSanXuat;
            cboHangsanxuat.DisplayMember = "tenhangsanxuat";
            cboHangsanxuat.ValueMember = "mahangsanxuat";

            cboTheLoai.SelectedValue = matheloai;
            cboAlbum.SelectedValue = maalbum;
            cboCasi.SelectedValue = macasi;
            cbotacGia.SelectedValue = matacgia;
            cboHangsanxuat.SelectedValue = mahangsanxuat;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            BaiHat_BUS objBaiHat;
            try
            {
                objBaiHat = new BaiHat_BUS(txtMaBaiHat.Text, txtTenBaiHat.Text, cboTheLoai.SelectedValue.ToString(), cboAlbum.SelectedValue.ToString(), cboCasi.SelectedValue.ToString(), cbotacGia.SelectedValue.ToString(), cboHangsanxuat.SelectedValue.ToString(), txtLoiBaiHat.Text);

            }
            catch (Exception ex)
            {
                string loi = ex.Message;
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (loi.Contains("mã"))
                {
                    txtMaBaiHat.Focus();
                    return;
                }
                else if (loi.Contains("tên"))
                {
                    txtTenBaiHat.Focus();
                    return;
                }
                else
                    txtLoiBaiHat.Text = "Chưa có lời cho bài hát !! == > bấm [Đồng ý] lần nữa để lưu bài hát này !";
                return;
            }
            BaiHat_BUS a = new BaiHat_BUS(txtMaBaiHat.Text, txtTenBaiHat.Text, cboTheLoai.SelectedValue.ToString(), cboAlbum.SelectedValue.ToString(), cboCasi.SelectedValue.ToString(), cbotacGia.SelectedValue.ToString(), cboHangsanxuat.SelectedValue.ToString(), txtLoiBaiHat.Text);
            int resutl = a.capnhatBaiHat();
            if (resutl == 0)
                MessageBox.Show("Cập nhật thành công tác giả [" + txtTenBaiHat.Text + "] với mã tác giả là [" + txtMaBaiHat.Text + "]");
            else
                MessageBox.Show("That bai");

            this.DialogResult = DialogResult.OK;
        }
    }
}
