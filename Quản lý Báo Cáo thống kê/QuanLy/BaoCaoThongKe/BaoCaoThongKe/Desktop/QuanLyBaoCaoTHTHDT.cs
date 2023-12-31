using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BaoCaoThongKe.BusinessObject;
using BaoCaoThongKe.Controller;

namespace BaoCaoThongKe.Desktop
{
    public partial class QuanLyBaoCaoTHTHDT : Office2007Form
    {

        public QuanLyBaoCaoTHTHDT()
        {
            InitializeComponent();
        }

        LoaiDuAn_Ctrl proloaiduan = new LoaiDuAn_Ctrl();
        LoaiBaoCao_Ctrl proloaibaocao = new LoaiBaoCao_Ctrl();
        MauBaoCaoTHTHDT_Ctrl promaubaocao = new MauBaoCaoTHTHDT_Ctrl();
        BaoCaoTHTHDT_Ctrl probaocao = new BaoCaoTHTHDT_Ctrl();
        QL_DoanhNghiep_Ctrl prodoanhnghiep = new QL_DoanhNghiep_Ctrl();
        MauBaoCaoTHTHDT_InFo maubaocao = new MauBaoCaoTHTHDT_InFo();
        BaoCaoTHTHDT_InFo baocao = new BaoCaoTHTHDT_InFo();
        DuAn_Ctrl produan = new DuAn_Ctrl();
        QL_DuAn_InFo duan = new QL_DuAn_InFo();
        bool adding = false;
        bool updating = false;

        private void QuanLyBaoCaoTHTHDT_Load(object sender, EventArgs e)
        {
            proloaiduan.Load_Combobox_Loaiduan(cmbLoaiduan);
            proloaibaocao.Combobox_Loaibaocao(cmbLoaibaocao);
            promaubaocao.ListMauBaoCao(dataGridViewX2, bindingNavigator1);
            probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);

            txtTenbaocao.ReadOnly = true;
            cmbNambaocao.Enabled = false;
            cmbLoaibaocao.Enabled = false;
            cmbQuibaocao.Enabled = false;

            txtTenduan.ReadOnly = true;
            txtDiadiem.ReadOnly = true;
            txtThoigian.ReadOnly = true;
            txtTongvon.ReadOnly = true;
            txtNanglucthietke.ReadOnly = true;
            cmbLoaiduan.Enabled = false;
            txtVondautu.ReadOnly = true;
            txtLuykevon.ReadOnly = true;
            txtGhichu.ReadOnly = true;

            tool_them.Enabled = true;
            tool_xoa.Enabled = true;
            tool_sua.Enabled = true;
            tool_luu.Enabled = false;
            tool_thoat.Visible = true;
            tool_xemlai.Visible = false;
            tool_sua1.Enabled = true;
            tool_luu1.Enabled = false;
            tool_xemlai1.Enabled = false;
            tool_them1.Enabled = true;
            tool_xoa1.Enabled = true;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;
        }

        private void tool_them_Click(object sender, EventArgs e)
        {
            LapBaoCaoTHTHDT frm = new LapBaoCaoTHTHDT();
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
            dataGridViewX2.Enabled = false;
            dataGridViewX1.Enabled = false;

            tool_them.Enabled = false;
            tool_xoa.Enabled = false;
            tool_sua.Enabled = false;
            tool_luu.Enabled = true;
            tool_thoat.Visible = false;
            tool_xemlai.Visible = true;
            tool_sua1.Enabled = false;
            tool_luu1.Enabled = false;
            tool_xemlai1.Enabled = false;
            tool_them1.Enabled = false;
            tool_xoa1.Enabled = false;

            txtTenbaocao.ReadOnly = false;
            cmbLoaibaocao.Enabled = true;
            cmbNambaocao.Enabled = true;
            cmbQuibaocao.Enabled = true;

            txtDiadiem.ReadOnly = true;
            txtNanglucthietke.ReadOnly = true;
            txtTenduan.ReadOnly = true;
            txtTongvon.ReadOnly = true;
            cmbLoaiduan.Enabled = false;
            txtVondautu.ReadOnly = true;
            txtLuykevon.ReadOnly = true;
            txtGhichu.ReadOnly = true;
        }

        private void tool_luu_Click(object sender, EventArgs e)
        {
            if (promaubaocao.CheckInput(txtTenbaocao))
            {
                if (cmbLoaibaocao.SelectedValue.ToString() == "2" || cmbLoaibaocao.SelectedValue.ToString() == "4")
                {
                    maubaocao.Mamaubaocao = Convert.ToInt32(txtMamaubaocao.Text);
                    maubaocao.Loaibaocao.MaLoaiBaoCao = Convert.ToInt32(cmbLoaibaocao.SelectedValue);
                    maubaocao.Tenbaocao = txtTenbaocao.Text;
                    maubaocao.Nambaocao = Convert.ToInt32(cmbNambaocao.Text);
                    maubaocao.Quibaocao = Convert.ToInt32(cmbQuibaocao.Text);

                    promaubaocao.Sua(maubaocao);
                    promaubaocao.ListMauBaoCao(dataGridViewX2, bindingNavigator1);

                    tool_them.Enabled = true;
                    tool_xoa.Enabled = true;
                    tool_sua.Enabled = true;
                    tool_luu.Enabled = false;
                    tool_thoat.Visible = true;
                    tool_xemlai.Visible = false;
                    tool_sua1.Enabled = true;
                    tool_luu1.Enabled = true;
                    tool_xemlai1.Enabled = false;
                    tool_xoa1.Enabled = true;
                    tool_them1.Enabled = true;

                    txtTenbaocao.ReadOnly = false;
                    cmbLoaibaocao.Enabled = false;
                    cmbNambaocao.Enabled = false;
                    cmbQuibaocao.Enabled = false;

                    txtTenduan.ReadOnly = true;
                    txtDiadiem.ReadOnly = true;
                    txtTongvon.ReadOnly = true;
                    txtNanglucthietke.ReadOnly = true;
                    cmbLoaiduan.Enabled = false;
                    txtVondautu.ReadOnly = true;
                    txtLuykevon.ReadOnly = true;
                    txtGhichu.ReadOnly = true;

                    dataGridViewX1.Enabled = true;
                    dataGridViewX2.Enabled = true;
                }
                else
                    MessageBox.Show("Báo cáo Tình Hình Thực Hiện Đầu Tư không có loại báo cáo này");
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
            tool_xoa1.Enabled = true;
            tool_them1.Enabled = true;

            txtTenbaocao.ReadOnly = true;
            cmbLoaibaocao.Enabled = false;
            cmbNambaocao.Enabled = false;
            cmbQuibaocao.Enabled = false;

            txtTenduan.ReadOnly = true;
            txtDiadiem.ReadOnly = true;
            txtTongvon.ReadOnly = true;
            txtNanglucthietke.ReadOnly = true;
            cmbLoaiduan.Enabled = false;
            txtVondautu.ReadOnly = true;
            txtLuykevon.ReadOnly = true;
            txtGhichu.ReadOnly = true;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;
        }

        private void tool_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tool_them1_Click(object sender, EventArgs e)
        {
            adding = true;
            updating = false;

            txtTenbaocao.ReadOnly = true;
            cmbNambaocao.Enabled = false;
            cmbLoaibaocao.Enabled = false;
            cmbQuibaocao.Enabled = false;

            txtTenduan.ReadOnly = false;
            txtVondautu.ReadOnly = false;
            txtLuykevon.ReadOnly = false;
            txtGhichu.ReadOnly = false;
            txtDiadiem.ReadOnly = false;
            txtThoigian.ReadOnly = false;
            txtNanglucthietke.ReadOnly = false;
            txtTongvon.ReadOnly = false;
            cmbLoaiduan.Enabled = true;

            dataGridViewX1.Enabled = false;
            dataGridViewX2.Enabled = false;

            txtTenduan.Text = "";
            txtVondautu.Text = "";
            txtLuykevon.Text = "";
            txtGhichu.Text = "";
            txtDiadiem.Text = "";
            txtThoigian.Text = "";
            txtNanglucthietke.Text = "";
            txtTongvon.Text = "";


            tool_them.Enabled = false;
            tool_xoa.Enabled = false;
            tool_sua.Enabled = false;
            tool_luu.Enabled = false;
            tool_thoat.Visible = true;
            tool_xemlai.Visible = false;
            tool_sua1.Enabled = false;
            tool_luu1.Enabled = true;
            tool_xemlai1.Enabled = true;
            tool_them1.Enabled = false;
            tool_xoa1.Enabled = false;

            txtMaduan.Text = produan.LayMaMax().ToString();
        }

        private void tool_xoa1_Click(object sender, EventArgs e)
        {
            if (txtMaduan.Text == "")
                MessageBox.Show("Không có dự án để xóa!");
            else
            {
                if (MessageBox.Show("bạn có xóa dự án\" " + txtTenduan.Text + " \" này ra khỏi báo cáo không?", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    baocao.Maubaocao.Mamaubaocao = Convert.ToInt32(txtMamaubaocao.Text);
                    baocao.Duan.MaDuAn = Convert.ToInt32(txtMaduan.Text);
                    probaocao.Xoa(baocao);
                    probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);
                }

                if (dataGridViewX1.RowCount == 0)
                {
                    txtTenduan.Text = "";
                    txtVondautu.Text = "";
                    txtLuykevon.Text = "";
                    txtGhichu.Text = "";
                    txtDiadiem.Text = "";
                    txtThoigian.Text = "";
                    txtNanglucthietke.Text = "";
                    txtTongvon.Text = "";

                    tool_sua1.Enabled = false;
                    tool_xoa1.Enabled = false;
                }
                else
                {
                    tool_sua1.Enabled = true;
                    tool_xoa1.Enabled = true;
                }
            }
        }

        private void tool_sua1_Click(object sender, EventArgs e)
        {
            adding = false;
            updating = true;

            dataGridViewX1.Enabled = false;
            dataGridViewX2.Enabled = false;

            tool_them.Enabled = false;
            tool_xoa.Enabled = false;
            tool_sua.Enabled = false;
            tool_luu.Enabled = false;
            tool_thoat.Visible = false;
            tool_xemlai.Visible = false;
            tool_sua1.Enabled = false;
            tool_luu1.Enabled = true;
            tool_xemlai1.Enabled = true;
            tool_xoa1.Enabled = false;
            tool_them1.Enabled = false;



            txtTenbaocao.ReadOnly = true;
            cmbLoaibaocao.Enabled = false;
            cmbNambaocao.Enabled = false;
            cmbQuibaocao.Enabled = false;

            txtTenduan.ReadOnly = true;
            txtDiadiem.ReadOnly = true;
            txtTongvon.ReadOnly = true;
            txtNanglucthietke.ReadOnly = true;
            cmbLoaiduan.Enabled = false;
            txtVondautu.ReadOnly = false;
            txtLuykevon.ReadOnly = false;
            txtGhichu.ReadOnly = false;
        }

        private void tool_luu1_Click(object sender, EventArgs e)
        {
            if (produan.CheckInput(txtTenduan, txtDiadiem, txtThoigian, txtNanglucthietke, txtTongvon))
            {
                if (probaocao.CheckInput(txtVondautu, txtLuykevon))
                {
                    if (adding)
                    {
                        duan.DiaDiemXayDung = txtDiadiem.Text;
                        duan.Doanhnghiep.MaDoanhNghiep = Convert.ToInt32(txtMadoanhnghiep.Text);
                        duan.Loaiduan.MaLoaiDuAn = Convert.ToInt32(cmbLoaiduan.SelectedValue);
                        duan.MaDuAn = Convert.ToInt32(txtMaduan.Text);
                        duan.NangLucThietKe = txtNanglucthietke.Text;
                        duan.TenDuAn = txtTenduan.Text;
                        duan.ThoiGian = txtThoigian.Text;
                        duan.TongVon = Convert.ToInt32(txtTongvon.Text);
                        produan.Them(duan);

                        baocao.Maubaocao.Mamaubaocao = Convert.ToInt32(txtMamaubaocao.Text);
                        baocao.Duan.MaDuAn = Convert.ToInt32(txtMaduan.Text);
                        baocao.Vondautu = Convert.ToInt32(txtVondautu.Text);
                        baocao.Luykevon = Convert.ToInt32(txtLuykevon.Text);
                        baocao.Ghichu = txtGhichu.Text;

                        probaocao.Them(baocao);
                        probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);
                    }
                    else
                        if (updating)
                        {
                            baocao.Maubaocao.Mamaubaocao = Convert.ToInt32(txtMamaubaocao.Text);
                            baocao.Duan.MaDuAn = Convert.ToInt32(txtMaduan.Text);
                            baocao.Vondautu = Convert.ToInt32(txtVondautu.Text);
                            baocao.Luykevon = Convert.ToInt32(txtLuykevon.Text);
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
                    tool_xoa1.Enabled = true;
                    tool_them1.Enabled = true;

                    txtTenbaocao.ReadOnly = true;
                    cmbLoaibaocao.Enabled = false;
                    cmbNambaocao.Enabled = false;
                    cmbQuibaocao.Enabled = false;

                    txtTenduan.ReadOnly = true;
                    txtTongvon.ReadOnly = true;
                    txtDiadiem.ReadOnly = true;
                    txtThoigian.ReadOnly = true;
                    txtNanglucthietke.ReadOnly = true;
                    cmbLoaiduan.Enabled = false;
                    txtVondautu.ReadOnly = true;
                    txtLuykevon.ReadOnly = true;
                    txtGhichu.ReadOnly = true;

                    dataGridViewX1.Enabled = true;
                    dataGridViewX2.Enabled = true;
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
            tool_xemlai.Visible = false;
            tool_sua1.Enabled = true;
            tool_luu1.Enabled = false;
            tool_xemlai1.Enabled = false;
            tool_xoa1.Enabled = true;
            tool_them1.Enabled = true;

            txtTenbaocao.ReadOnly = true;
            cmbLoaibaocao.Enabled = false;
            cmbNambaocao.Enabled = false;
            cmbQuibaocao.Enabled = false;

            txtTenduan.ReadOnly = true;
            txtTongvon.ReadOnly = true;
            txtDiadiem.ReadOnly = true;
            txtNanglucthietke.ReadOnly = true;
            cmbLoaiduan.Enabled = false;
            txtVondautu.ReadOnly = true;
            txtLuykevon.ReadOnly = true;
            txtGhichu.ReadOnly = true;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;
        }

        private void tool_thoat1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewX2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewX2.Rows[e.RowIndex];
            txtMamaubaocao.Text = row.Cells[0].Value.ToString();
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
                tool_them1.Enabled = false;
                tool_xoa1.Enabled = false;

            }
            else
            {
                txtTenbaocao.Text = row.Cells[1].Value.ToString();
                cmbLoaibaocao.Text = row.Cells[2].Value.ToString();
                cmbNambaocao.Text = row.Cells[4].Value.ToString();
                cmbQuibaocao.Text = row.Cells[3].Value.ToString();

                tool_them.Enabled = true;
                tool_xoa.Enabled = true;
                tool_sua.Enabled = true;
                tool_luu.Enabled = false;
                tool_thoat.Visible = true;
                tool_xemlai.Visible = false;
                if (dataGridViewX1.RowCount == 0)
                {
                    txtTenduan.Text = "";
                    txtVondautu.Text = "";
                    txtLuykevon.Text = "";
                    txtGhichu.Text = "";
                    txtDiadiem.Text = "";
                    txtThoigian.Text = "";
                    txtNanglucthietke.Text = "";
                    txtTongvon.Text = "";

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
                tool_them1.Enabled = true;
            }
        }

        private void dataGridViewX1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewX1.Rows[e.RowIndex];
            if (row.Cells["maduan"].Value.ToString() == "")
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
                tool_them1.Enabled = false;
                tool_xoa1.Enabled = false;
            }
            else
            {
                txtMaduan.Text = row.Cells["maduan"].Value.ToString();
                txtTenduan.Text = row.Cells["tenduan"].Value.ToString();
                txtDiadiem.Text = row.Cells["diadiem"].Value.ToString();
                txtMadoanhnghiep.Text = row.Cells["madoanhnghiep"].Value.ToString();

                lbDoanhnghiep.Text = row.Cells["tendoanhnghiep"].Value.ToString();
                QL_DoanhNghiep_InFo dn = prodoanhnghiep.timdoanhnghiep_baocao(lbDoanhnghiep.Text);
                lbDiachi.Text = dn.DiaChi;
                lbDienthoai.Text = dn.DienThoai;
                lbEmail.Text = dn.Email;
                lbFax.Text = dn.Fax;
                lbTrangweb.Text = dn.TrangWeb;

                txtThoigian.Text = row.Cells["thoigian"].Value.ToString();
                txtNanglucthietke.Text = row.Cells["nangluc"].Value.ToString();
                txtTongvon.Text = row.Cells["tongvon"].Value.ToString();
                txtVondautu.Text = row.Cells["vondautu"].Value.ToString();
                txtLuykevon.Text = row.Cells["luykevon"].Value.ToString();
                txtGhichu.Text = row.Cells["ghichu"].Value.ToString();
                cmbLoaiduan.Text = row.Cells["loaiduan"].Value.ToString();

                tool_them.Enabled = true;
                tool_xoa.Enabled = true;
                tool_sua.Enabled = true;
                tool_luu.Enabled = false;
                tool_thoat.Visible = true;
                tool_xemlai.Visible = false;
                tool_sua1.Enabled = true;
                tool_luu1.Enabled = false;
                tool_xemlai1.Enabled = false;
                tool_them1.Enabled = true;
                tool_xoa1.Enabled = true;
            }
        }

        private void txtMamaubaocao_TextChanged(object sender, EventArgs e)
        {
            probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);

        }

        private void txtTongvon_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < txtTongvon.Text.Length; i++)
                if (!char.IsNumber(txtTongvon.Text[i]))
                {
                    MessageBox.Show("Tổng mức vốn đầu tư phải là số !", "Chú ý", MessageBoxButtons.OK);
                    txtTongvon.Clear();
                    txtTongvon.Focus();
                    break;
                }
        }

        private void txtVondautu_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < txtVondautu.Text.Length; i++)
                if (!char.IsNumber(txtVondautu.Text[i]))
                {
                    MessageBox.Show("Vốn đầu tư phải là số !", "Chú ý", MessageBoxButtons.OK);
                    txtVondautu.Clear();
                    txtVondautu.Focus();
                    break;
                }
        }

        private void txtLuykevon_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < txtLuykevon.Text.Length; i++)
                if (!char.IsNumber(txtLuykevon.Text[i]))
                {
                    MessageBox.Show(" Lũy kế vốn phải là số !", "Chú ý", MessageBoxButtons.OK);
                    txtLuykevon.Clear();
                    txtLuykevon.Focus();
                    break;
                }
        }

        private void cmbLoaibaocao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaibaocao.SelectedValue.ToString() == "2")
                cmbQuibaocao.Enabled = true;
            else
                cmbQuibaocao.Enabled = false;
        }

        private void dựÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_DuAn duan = new QL_DuAn();
            duan.ShowDialog();
        }
    }
}