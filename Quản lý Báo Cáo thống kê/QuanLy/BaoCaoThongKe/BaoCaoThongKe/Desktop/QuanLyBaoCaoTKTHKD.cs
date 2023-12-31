using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BaoCaoThongKe.Controller;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.Desktop
{
    public partial class QuanLyBaoCaoTKTHKD : Office2007Form
    {
        bool adding = false;
        bool updating = false;

        LoaiCongTrinh_Ctrl proloaicongtrinh = new LoaiCongTrinh_Ctrl();
        MauBaoCaoTKTHKD_InFo maubaocao = new MauBaoCaoTKTHKD_InFo();
        BaoCaoTKTHKD_InFo baocao = new BaoCaoTKTHKD_InFo();
        CongTrinhVienThong_Ctrl procongtrinh = new CongTrinhVienThong_Ctrl();
        LoaiBaoCao_Ctrl proloaibaocao = new LoaiBaoCao_Ctrl();
        MauBaoCaoTKTHKD_Ctrl promaubaocao = new MauBaoCaoTKTHKD_Ctrl();
        BaoCaoTKTHKD_Ctrl probaocao = new BaoCaoTKTHKD_Ctrl();
        QL_DoanhNghiep_Ctrl prodoanhnghiep = new QL_DoanhNghiep_Ctrl();
        CongTrinhVienThong_InFo congtrinh = new CongTrinhVienThong_InFo();


        public QuanLyBaoCaoTKTHKD()
        {
            InitializeComponent();
        }

        private void QuanLyBaoCaoTKTHKD_Load(object sender, EventArgs e)
        {
            proloaicongtrinh.ComboBoxLoaiCongTrinh(cmbLoaicongtrinh);
            proloaibaocao.Combobox_Loaibaocao(cmbLoaibaocao);
            promaubaocao.ListMauBaoCao(dataGridViewX2, bindingNavigator1);
            probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);

            tool_them.Enabled = true;
            tool_xoa.Enabled = true;
            tool_sua.Enabled = true;
            tool_luu.Enabled = false;
            tool_thoat.Visible = true;
            tool_xemlai.Visible = false;
            tool_sua1.Enabled = true;
            tool_luu1.Enabled = false;
            tool_xemlai1.Enabled = false;
            tool_LBCCTCTVT.Enabled = true;
            tool_xoa1.Enabled = true;
            tool_them1.Enabled = true;

            txtTenbaocao.ReadOnly = true;
            cmbLoaibaocao.Enabled = false;
            cmbNambaocao.Enabled = false;

            txtTencongtrinh.ReadOnly = true;
            cmbLoaicongtrinh.Enabled = false;
            txtSoluong.ReadOnly = true;
            txtGhichu.ReadOnly = true;

            dataGridViewX1.Enabled = true;
            bindingNavigator1.Enabled = true;

            dataGridViewX2.Enabled = true;
            bindingNavigator2.Enabled = true;
        }

        private void tool_them_Click(object sender, EventArgs e)
        {
            LapBaoCaoTKTHKD frm = new LapBaoCaoTKTHKD();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                promaubaocao.ListMauBaoCao(dataGridViewX2, bindingNavigator1);
                probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);
            }
        }

        private void tool_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có xóa báo cáo\" " + txtTenbaocao.Text + " \" này không", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                maubaocao.Mamaubaocao = Convert.ToInt32(txtMamaubaocao.Text);
                probaocao.XoaToanBo(txtMamaubaocao.Text);
                promaubaocao.Xoa(maubaocao);
                promaubaocao.ListMauBaoCao(dataGridViewX2, bindingNavigator1);
            }
        }

        private void tool_sua_Click(object sender, EventArgs e)
        {
            dataGridViewX1.Enabled = false;
            bindingNavigator1.Enabled = false;

            dataGridViewX2.Enabled = false;
            bindingNavigator2.Enabled = false;

            tool_them.Enabled = false;
            tool_xoa.Enabled = false;
            tool_sua.Enabled = false;
            tool_luu.Enabled = true;
            tool_thoat.Visible = false;
            tool_xemlai.Visible = true;
            tool_sua1.Enabled = false;
            tool_luu1.Enabled = false;
            tool_xemlai1.Enabled = false;
            tool_LBCCTCTVT.Enabled = false;
            tool_xoa1.Enabled = false;
            tool_them1.Enabled = false;

            txtTenbaocao.ReadOnly = false;
            cmbLoaibaocao.Enabled = true;
            cmbNambaocao.Enabled = true;

            txtTencongtrinh.ReadOnly = true;
            cmbLoaicongtrinh.Enabled = false;
            txtSoluong.ReadOnly = true;
            txtGhichu.ReadOnly = true; 
        }

        private void tool_luu_Click(object sender, EventArgs e)
        {
            if (promaubaocao.CheckInput(txtTenbaocao))
            {
                if (cmbLoaibaocao.SelectedValue.ToString() == "3" || cmbLoaibaocao.SelectedValue.ToString() == "4")
                {
                    maubaocao.Mamaubaocao = Convert.ToInt32(txtMamaubaocao.Text);
                    maubaocao.Loaibaocao.MaLoaiBaoCao = Convert.ToInt32(cmbLoaibaocao.SelectedValue);
                    maubaocao.Tenbaocao = txtTenbaocao.Text;
                    maubaocao.Nambaocao = Convert.ToInt32(cmbNambaocao.Text);

                    promaubaocao.Sua(maubaocao);
                    promaubaocao.ListMauBaoCao(dataGridViewX2, bindingNavigator1);

                    tool_them.Enabled = true;
                    tool_xoa.Enabled = true;
                    tool_sua.Enabled = true;
                    tool_luu.Enabled = false;
                    tool_thoat.Visible = true;
                    tool_xemlai.Visible = false;
                    tool_sua1.Enabled = true;
                    tool_luu1.Enabled = false;
                    tool_xemlai1.Enabled = true;
                    tool_LBCCTCTVT.Enabled = true;
                    tool_xoa1.Enabled = true;
                    tool_them1.Enabled = true;

                    txtTenbaocao.ReadOnly = false;
                    cmbLoaibaocao.Enabled = false;
                    cmbNambaocao.Enabled = false;

                    txtTencongtrinh.ReadOnly = true;
                    cmbLoaicongtrinh.Enabled = false;
                    txtSoluong.ReadOnly = true;
                    txtGhichu.ReadOnly = true;

                    dataGridViewX1.Enabled = true;
                    bindingNavigator1.Enabled = true;

                    dataGridViewX2.Enabled = true;
                    bindingNavigator2.Enabled = true;
                }
                else
                    MessageBox.Show("Báo cáo Thống Kê Các Công Trình Viễn Thông không có loại báo cáo này!");
            }
        }

        private void tool_xemlai_Click(object sender, EventArgs e)
        {
            tool_them.Enabled = true;
            tool_xoa.Enabled = true;
            tool_sua.Enabled = true;
            tool_luu.Enabled = false;
            tool_thoat.Visible = true;
            tool_xemlai.Visible = false;
            tool_sua1.Enabled = true;
            tool_luu1.Enabled = false;
            tool_xemlai1.Enabled = false;
            tool_LBCCTCTVT.Enabled = true;
            tool_xoa1.Enabled = true;
            tool_them1.Enabled = true;

            txtTenbaocao.ReadOnly = true;
            cmbLoaibaocao.Enabled = false;
            cmbNambaocao.Enabled = false;

            txtTencongtrinh.ReadOnly = true;
            cmbLoaicongtrinh.Enabled = false;
            txtSoluong.ReadOnly = true;
            txtGhichu.ReadOnly = true;

            dataGridViewX1.Enabled = true;
            bindingNavigator1.Enabled = true;

            dataGridViewX2.Enabled = true;
            bindingNavigator2.Enabled = true;
        }

        private void tool_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tool_them1_Click(object sender, EventArgs e)
        {
            adding = true;
            updating = false;

            dataGridViewX1.Enabled = false;
            bindingNavigator1.Enabled = false;

            dataGridViewX2.Enabled = false;
            bindingNavigator2.Enabled = false;

            tool_them.Enabled = false;
            tool_xoa.Enabled = false;
            tool_sua.Enabled = false;
            tool_luu.Enabled = false;
            tool_thoat.Visible = true;
            tool_xemlai.Visible = false;
            tool_sua1.Enabled = false;
            tool_luu1.Enabled = true;
            tool_xemlai1.Enabled = true;
            tool_xoa1.Enabled = false;
            tool_LBCCTCTVT.Enabled = false;
            tool_them1.Enabled = false;

            txtTenbaocao.ReadOnly = true;
            cmbLoaibaocao.Enabled = false;
            cmbNambaocao.Enabled = false;

            txtTencongtrinh.ReadOnly = false;
            cmbLoaicongtrinh.Enabled = false;
            txtSoluong.ReadOnly = false;
            txtGhichu.ReadOnly = false;

            txtTencongtrinh.Clear();
            txtSoluong.Clear();
            txtGhichu.Clear();

            txtMacongtrinh.Text = procongtrinh.LayMaMax().ToString();
        }

        private void tool_xoa1_Click(object sender, EventArgs e)
        {
            if (txtMacongtrinh.Text == "")
                MessageBox.Show("Không có công trình để xóa!");
            else
            {
                if (MessageBox.Show("bạn có xóa công trình\" " + txtTencongtrinh.Text + " \" này ra khỏi báo cáo không?", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    baocao.Maubaocao.Mamaubaocao = Convert.ToInt32(txtMamaubaocao.Text);
                    baocao.Congtrinh.MaCongTrinh = Convert.ToInt32(txtMacongtrinh.Text);
                    probaocao.Xoa(baocao);
                    probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);
                }
            }
            if (dataGridViewX1.RowCount == 0)
            {
                txtTencongtrinh.Text = "";
                txtSoluong.Text = "";
                txtGhichu.Text = "";

                tool_sua1.Enabled = false;
                tool_xoa1.Enabled = false;
            }
            else
            {
                tool_sua1.Enabled = true;
                tool_xoa1.Enabled = true;
            }
        }

        private void tool_sua1_Click(object sender, EventArgs e)
        {
            adding = false;
            updating = true;

            dataGridViewX1.Enabled = false;
            bindingNavigator1.Enabled = false;

            dataGridViewX2.Enabled = false;
            bindingNavigator2.Enabled = false;

            tool_them.Enabled = false;
            tool_xoa.Enabled = false;
            tool_sua.Enabled = false;
            tool_luu.Enabled = false;
            tool_thoat.Enabled = false;
            tool_xemlai.Visible = false;
            tool_sua1.Enabled = false;
            tool_luu1.Enabled = true;
            tool_xemlai1.Enabled = true;
            tool_LBCCTCTVT.Enabled = false;
            tool_xoa1.Enabled = false;
            tool_them1.Enabled = false;

            txtTenbaocao.ReadOnly = true;
            cmbLoaibaocao.Enabled = false;
            cmbNambaocao.Enabled = false;

            txtTencongtrinh.ReadOnly = true;
            cmbLoaicongtrinh.Enabled = false;
            txtSoluong.ReadOnly = false;
            txtGhichu.ReadOnly = false;  
        }

        private void tool_luu1_Click(object sender, EventArgs e)
        {
            if (procongtrinh.CheckInput(txtTencongtrinh))
            {
                if (probaocao.CheckInput(txtSoluong))
                {
                    if (adding)
                    {
                        congtrinh.MaCongTrinh = Convert.ToInt32(txtMacongtrinh.Text);
                        congtrinh.TenCongTrinh = txtTencongtrinh.Text;
                        congtrinh.MaLoaiCongTrinh.MaLoaiCongTrinh = Convert.ToInt32(cmbLoaicongtrinh.SelectedValue);
                        congtrinh.MaDoanhNghiep.MaDoanhNghiep = Convert.ToInt32(txtMadoanhnghiep.Text);
                        procongtrinh.Them(congtrinh);

                        baocao.Maubaocao.Mamaubaocao = Convert.ToInt32(txtMamaubaocao.Text);
                        baocao.Congtrinh.MaCongTrinh = Convert.ToInt32(txtMacongtrinh.Text);
                        baocao.Soluong = Convert.ToInt32(txtSoluong.Text);
                        baocao.Ghichu = txtGhichu.Text;

                        probaocao.Them(baocao);
                        probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);
                    }
                    else
                        if (updating)
                        {
                            baocao.Maubaocao.Mamaubaocao = Convert.ToInt32(txtMamaubaocao.Text);
                            baocao.Congtrinh.MaCongTrinh = Convert.ToInt32(txtMacongtrinh.Text);
                            baocao.Soluong = Convert.ToInt32(txtSoluong.Text);
                            baocao.Ghichu = txtGhichu.Text;

                            probaocao.Sua(baocao);
                            probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);
                        }

                    tool_them.Enabled = true;
                    tool_xoa.Enabled = true;
                    tool_sua.Enabled = true;
                    tool_luu.Enabled = false;
                    tool_thoat.Visible = true;
                    tool_xemlai.Visible = false;
                    tool_sua1.Enabled = true;
                    tool_luu1.Enabled = false;
                    tool_xemlai1.Enabled = false;
                    tool_LBCCTCTVT.Enabled = true;
                    tool_xoa1.Enabled = true;
                    tool_them1.Enabled = true;

                    txtTenbaocao.ReadOnly = true;
                    cmbLoaibaocao.Enabled = false;
                    cmbNambaocao.Enabled = false;

                    txtTencongtrinh.ReadOnly = true;
                    cmbLoaicongtrinh.Enabled = false;
                    txtSoluong.ReadOnly = true;
                    txtGhichu.ReadOnly = true;

                    dataGridViewX1.Enabled = true;
                    bindingNavigator1.Enabled = true;

                    dataGridViewX2.Enabled = true;
                    bindingNavigator2.Enabled = true;
                }
            }
        }

        private void tool_xemlai1_Click(object sender, EventArgs e)
        {
            tool_them.Enabled = true;
            tool_xoa.Enabled = true;
            tool_sua.Enabled = true;
            tool_luu.Enabled = false;
            tool_thoat.Visible = true;
            tool_thoat.Enabled = true;
            tool_xemlai.Visible = false;
            tool_sua1.Enabled = true;
            tool_luu1.Enabled = false;
            tool_xemlai1.Enabled = false;
            tool_xoa1.Enabled = true;
            tool_LBCCTCTVT.Enabled = true;
            tool_them1.Enabled = true;

            txtTenbaocao.ReadOnly = true;
            cmbLoaibaocao.Enabled = false;
            cmbNambaocao.Enabled = false;

            txtTencongtrinh.ReadOnly = true;
            cmbLoaicongtrinh.Enabled = false;
            txtSoluong.ReadOnly = true;
            txtGhichu.ReadOnly = true;

            dataGridViewX1.Enabled = true;
            bindingNavigator1.Enabled = true;

            dataGridViewX2.Enabled = true;
            bindingNavigator2.Enabled = true;
        }

        private void tool_LBCCTCTVT_Click(object sender, EventArgs e)
        {
            if (dataGridViewX1.RowCount == 0)
            {
                MessageBox.Show("Không có công trình để lập chi tiết !", "Chú ý");
            }
            else
            {
                LapBaoCaoChiTietTKTHKD frm = new LapBaoCaoChiTietTKTHKD(txtMamaubaocao.Text);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    promaubaocao.ListMauBaoCao(dataGridViewX2, bindingNavigator1);
                }
            }
        }

        private void tool_thoat1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewX2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewX2.Rows[e.RowIndex];
            txtMamaubaocao.Text = row.Cells["mabaocao"].Value.ToString();
            if (txtMamaubaocao.Text == "")
            {
                tool_them.Enabled = true;
                tool_xoa.Enabled = false;
                tool_sua.Enabled = false;
                tool_luu.Enabled = false;
                tool_thoat.Visible = true;
                tool_xemlai.Visible = false;
                tool_sua1.Enabled = false;
                tool_luu1.Enabled = false;
                tool_xemlai1.Enabled = false;
                tool_LBCCTCTVT.Enabled = false;
                tool_xoa1.Enabled = false;
                tool_them1.Enabled = false;
            }
            else
            {
                txtTenbaocao.Text = row.Cells["tenbaocao"].Value.ToString();
                cmbLoaibaocao.Text = row.Cells["tenloaibaocao"].Value.ToString();
                cmbNambaocao.Text = row.Cells["nambaocao"].Value.ToString();

                tool_them.Enabled = true;
                tool_xoa.Enabled = true;
                tool_sua.Enabled = true;
                tool_luu.Enabled = false;
                tool_thoat.Visible = true;
                tool_xemlai.Visible = false;
                if (dataGridViewX1.RowCount == 0)
                {
                    txtTencongtrinh.Text = "";
                    txtSoluong.Text = "";
                    txtGhichu.Text = "";

                    tool_sua1.Enabled = false;
                    tool_xoa1.Enabled = false;
                }
                else
                {
                    tool_sua1.Enabled = true;
                    tool_xoa1.Enabled = true;
                }
                tool_luu1.Enabled = false;
                tool_xemlai1.Enabled = false;
                tool_LBCCTCTVT.Enabled = true;
                tool_them1.Enabled = true;
            }
        }

        private void dataGridViewX1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewX1.Rows[e.RowIndex];
            txtMacongtrinh.Text = row.Cells["macongtrinh"].Value.ToString();
            if (txtMacongtrinh.Text == "")
            {
                tool_them.Enabled = true;
                tool_xoa.Enabled = true;
                tool_sua.Enabled = true;
                tool_luu.Enabled = false;
                tool_thoat.Visible = true;
                tool_xemlai.Visible = false;
                tool_sua1.Enabled = false;
                tool_luu1.Enabled = false;
                tool_xemlai1.Enabled = false;
                tool_LBCCTCTVT.Enabled = false;
                tool_xoa1.Enabled = false;
                tool_them1.Enabled = true;
            }
            else
            {
                txtTencongtrinh.Text = row.Cells["tencongtrinh"].Value.ToString();
                txtSoluong.Text = row.Cells["soluong"].Value.ToString();
                txtMadoanhnghiep.Text = row.Cells["madoanhnghiep"].Value.ToString();
                cmbLoaicongtrinh.Text = row.Cells["loaicongtrinh"].Value.ToString();
                txtGhichu.Text = row.Cells["ghichu"].Value.ToString();
                lbDoanhnghiep.Text = row.Cells["doanhnghiep"].Value.ToString();

                QL_DoanhNghiep_InFo dn = prodoanhnghiep.timdoanhnghiep_baocao(lbDoanhnghiep.Text);
                lbDiachi.Text = dn.DiaChi;
                lbDienthoai.Text = dn.DienThoai;
                lbEmail.Text = dn.Email;
                lbFax.Text = dn.Fax;
                lbTrangweb.Text = dn.TrangWeb;

                tool_them.Enabled = true;
                tool_xoa.Enabled = true;
                tool_sua.Enabled = true;
                tool_luu.Enabled = false;
                tool_thoat.Visible = true;
                tool_xemlai.Visible = false;
                tool_sua1.Enabled = true;
                tool_luu1.Enabled = false;
                tool_xemlai1.Enabled = false;
                tool_LBCCTCTVT.Enabled = true;
                tool_xoa1.Enabled = true;
                tool_them1.Enabled = true;
            }
        }

        private void txtMamaubaocao_TextChanged(object sender, EventArgs e)
        {
            probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);

        }

        private void txtSoluong_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < txtSoluong.Text.Length; i++)
                if (!char.IsNumber(txtSoluong.Text[i]))
                {
                    MessageBox.Show("Số lượng cộng trình phải là số !", "Chú ý", MessageBoxButtons.OK);
                    txtSoluong.Clear();
                    txtSoluong.Focus();
                    break;
                }
        }
    }
}