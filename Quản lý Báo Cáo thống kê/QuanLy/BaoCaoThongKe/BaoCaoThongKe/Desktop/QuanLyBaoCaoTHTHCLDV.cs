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
    public partial class QuanLyBaoCaoTHTHCLDV : Office2007Form
    {
        bool adding = false;
        bool updating = false;
        TieuChuanChatLuong_Ctrl protieuchuan = new TieuChuanChatLuong_Ctrl();
        LoaiBaoCao_Ctrl proloaibaocao = new LoaiBaoCao_Ctrl();
        MauBaoCaoTHTHCLDV_Ctrl promaubaocao = new MauBaoCaoTHTHCLDV_Ctrl();
        BaoCaoTHTHCLDV_Ctrl probaocao = new BaoCaoTHTHCLDV_Ctrl();
        MauBaoCaoTHTHCLDV_InFo maubaocao = new MauBaoCaoTHTHCLDV_InFo();
        DichVuBuuChinhVT_Ctrl prodichvu = new DichVuBuuChinhVT_Ctrl();
        DichVuBuuChinh_VienThong_InFo dichvu = new DichVuBuuChinh_VienThong_InFo();
        QL_DoanhNghiep_Ctrl prodoanhnghiep = new QL_DoanhNghiep_Ctrl();

        BaoCaoTHTHCLDV_InFo baocao = new BaoCaoTHTHCLDV_InFo();

        public QuanLyBaoCaoTHTHCLDV()
        {
            InitializeComponent();
        }

        private void QuanLyBaoCaoTHTHCLDV_Load(object sender, EventArgs e)
        {
            protieuchuan.Load_ComboBox_TieuchuanCL(cmbTieuchuan);
            proloaibaocao.Combobox_Loaibaocao(cmbLoaibaocao);
            promaubaocao.ListMauBaoCao(dataGridViewX2, bindingNavigator1);
            probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);

            txtTenbaocao.ReadOnly = true;
            cmbNambaocao.Enabled = false;
            cmbLoaibaocao.Enabled = false;

            txtTendichvu.ReadOnly = true;
            txtTendoanhnghiep.ReadOnly = true;
            txtVanban.ReadOnly = true;
            cmbTieuchuan.Enabled = false;

            chkCo.Enabled = false;
            chkKhong.Enabled = false;
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
            LapBaoCaoTHTHCLDV frm = new LapBaoCaoTHTHCLDV();
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

            txtTendichvu.ReadOnly = true;
            txtTendoanhnghiep.ReadOnly = true;
            txtVanban.ReadOnly = true;
            cmbTieuchuan.Enabled = false;

            chkCo.Enabled = false;
            chkKhong.Enabled = false;
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
                    tool_luu1.Enabled = true;
                    tool_xemlai1.Enabled = false;
                    tool_xoa1.Enabled = true;
                    tool_them1.Enabled = true;

                    txtTenbaocao.ReadOnly = true;
                    cmbLoaibaocao.Enabled = false;
                    cmbNambaocao.Enabled = false;

                    txtTendichvu.ReadOnly = true;
                    txtVanban.ReadOnly = true;
                    txtTendoanhnghiep.ReadOnly = true;
                    cmbTieuchuan.Enabled = false;
                    txtGhichu.ReadOnly = true;

                    chkCo.Enabled = false;
                    chkKhong.Enabled = false;

                    dataGridViewX1.Enabled = true;
                    dataGridViewX2.Enabled = true;
                }
                else
                    MessageBox.Show("Báo cáo Tình Hình Thực Hiện Chất Lượng Dịch Vụ không có loại báo cáo này");
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

            txtTendichvu.ReadOnly = true;
            txtVanban.ReadOnly = true;
            txtTendoanhnghiep.ReadOnly = true;
            cmbTieuchuan.Enabled = false;

            chkCo.Enabled = false;
            chkKhong.Enabled = false;
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

            txtTendichvu.ReadOnly = false;
            txtVanban.ReadOnly = false;
            txtTendoanhnghiep.ReadOnly = false;
            cmbTieuchuan.Enabled = true;

            chkCo.Enabled = true;
            chkKhong.Enabled = true;
            txtGhichu.ReadOnly = false;

            dataGridViewX1.Enabled = false;
            dataGridViewX2.Enabled = false;

            txtTendichvu.Text = "";
            txtTendoanhnghiep.Text = "";
            txtVanban.Text = "";
            cmbTieuchuan.Enabled = true;
            txtGhichu.Text = "";

            chkCo.Checked = true;
            chkKhong.Checked = false;

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

            txtMadichvu.Text = prodichvu.LayMaMax().ToString();
        }

        private void tool_xoa1_Click(object sender, EventArgs e)
        {
            if (txtMadichvu.Text == "")
                MessageBox.Show("Không có dịch vụ để xóa !", "Thông Báo");
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa dịch vụ\" " + txtTendichvu.Text + " \" này ra khỏi báo cáo không?", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    baocao.Maubaocao.Mamaubaocao = Convert.ToInt32(txtMamaubaocao.Text);
                    baocao.Dichvubuuchinh.MaDichVuBuuChinhVT = Convert.ToInt32(txtMadichvu.Text);
                    probaocao.Xoa(baocao);
                    probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);
                }
            }
            if (dataGridViewX1.RowCount == 0)
            {
                txtGhichu.Text = "";
                txtTendichvu.Text = "";
                txtVanban.Text = "";
                txtTendoanhnghiep.Text = "";

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

            txtTendichvu.ReadOnly = true;
            txtVanban.ReadOnly = false;
            txtTendoanhnghiep.ReadOnly = false;
            cmbTieuchuan.Enabled = true;

            chkCo.Enabled = true;
            chkKhong.Enabled = true;
            txtGhichu.ReadOnly = false;
        }

        private void tool_luu1_Click(object sender, EventArgs e)
        {
            if (prodichvu.CheckInput(txtTendichvu))
            {
                if (probaocao.CheckInput(txtVanban, txtTendoanhnghiep))
                {
                    if (adding)
                    {
                        dichvu.MaDichVuBuuChinhVT = Convert.ToInt32(txtMadichvu.Text);
                        dichvu.TenDichVuBuuChinhVT = txtTendichvu.Text;
                        dichvu.Doanhnghiep.MaDoanhNghiep = Convert.ToInt32(txtMadoanhnghiep.Text);
                        prodichvu.Them(dichvu);

                        baocao.Maubaocao.Mamaubaocao = Convert.ToInt32(txtMamaubaocao.Text);
                        baocao.Dichvubuuchinh.MaDichVuBuuChinhVT = Convert.ToInt32(txtMadichvu.Text);
                        baocao.Tieuchuanchatluong.MaTieuChuanCL = Convert.ToInt32(cmbTieuchuan.SelectedValue.ToString());
                        baocao.Vanbancongbo = txtVanban.Text;

                        if (chkCo.Checked == true)
                            baocao.Thuocdanhmucbuuchinh = "Có";
                        else
                            baocao.Thuocdanhmucbuuchinh = "Không";

                        baocao.Doanhnghiepcongbo = txtTendoanhnghiep.Text;
                        baocao.Ghichu = txtGhichu.Text;

                        probaocao.Them(baocao);
                        probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);
                    }
                    else
                        if (updating)
                        {
                            baocao.Maubaocao.Mamaubaocao = Convert.ToInt32(txtMamaubaocao.Text);
                            baocao.Dichvubuuchinh.MaDichVuBuuChinhVT = Convert.ToInt32(txtMadichvu.Text);
                            baocao.Tieuchuanchatluong.MaTieuChuanCL = Convert.ToInt32(cmbTieuchuan.SelectedValue.ToString());
                            baocao.Vanbancongbo = txtVanban.Text;

                            if (chkCo.Checked == true)
                                baocao.Thuocdanhmucbuuchinh = "Có";
                            else
                                baocao.Thuocdanhmucbuuchinh = "Không";

                            baocao.Doanhnghiepcongbo = txtTendoanhnghiep.Text;
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

                    txtTendichvu.ReadOnly = true;
                    txtVanban.ReadOnly = true;
                    txtTendoanhnghiep.ReadOnly = true;
                    cmbTieuchuan.Enabled = false;

                    chkCo.Enabled = false;
                    chkKhong.Enabled = false;
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

            txtTendichvu.ReadOnly = true;
            txtVanban.ReadOnly = true;
            txtTendoanhnghiep.ReadOnly = true;
            cmbTieuchuan.Enabled = false;

            chkCo.Enabled = false;
            chkKhong.Enabled = false;
            txtGhichu.ReadOnly = true;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;
        }

        private void tool_thoat1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTieuChuan_Click(object sender, EventArgs e)
        {
            QL_TieuChuan_CL TieuChuan = new QL_TieuChuan_CL();
            TieuChuan.ShowDialog();
            protieuchuan.Load_ComboBox_TieuchuanCL(cmbTieuchuan);
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewX1.Rows[e.RowIndex];
            txtMadichvu.Text = row.Cells["madichvu"].Value.ToString();
            txtTendichvu.Text = row.Cells["tendichvu"].Value.ToString();
            txtVanban.Text = row.Cells["vanbancongbo"].Value.ToString();
            txtTendoanhnghiep.Text = row.Cells["doanhnghiep"].Value.ToString();
            txtMadoanhnghiep.Text = row.Cells["madoanhnghiep"].Value.ToString();
            cmbTieuchuan.Text = row.Cells["tieuchuanchatluong"].Value.ToString();

            if (row.Cells["thuocdanhmuc"].Value.ToString() == "Có")
                chkCo.Checked = true;
            else
                chkKhong.Checked = true;

            lbDoanhnghiep.Text = row.Cells["tendoanhnghiep"].Value.ToString();
            QL_DoanhNghiep_InFo dn = prodoanhnghiep.timdoanhnghiep_baocao(lbDoanhnghiep.Text);
            lbDiachi.Text = dn.DiaChi;
            lbDienthoai.Text = dn.DienThoai;
            lbEmail.Text = dn.Email;
            lbFax.Text = dn.Fax;
            lbTrangweb.Text = dn.TrangWeb;

            txtGhichu.Text = row.Cells["ghichu"].Value.ToString();
        }

        private void dataGridViewX2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewX2.Rows[e.RowIndex];
            txtMamaubaocao.Text = row.Cells["mamaubaocao"].Value.ToString();
            txtTenbaocao.Text = row.Cells["tenbaocao"].Value.ToString();
            cmbLoaibaocao.Text = row.Cells["loaibaocao"].Value.ToString();
            cmbNambaocao.Text = row.Cells["nambaocao"].Value.ToString();

            if (dataGridViewX1.RowCount == 0)
            {
                txtTendichvu.Text = "";
                txtTendoanhnghiep.Text = "";
                txtVanban.Text = "";
                cmbTieuchuan.Enabled = true;
                txtGhichu.Text = "";

                chkCo.Checked = true;
                chkKhong.Checked = false;
                tool_sua1.Enabled = false;
                tool_xoa1.Enabled = false;
            }
        }

        private void txtMamaubaocao_TextChanged(object sender, EventArgs e)
        {
            probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);
        }
    }
}