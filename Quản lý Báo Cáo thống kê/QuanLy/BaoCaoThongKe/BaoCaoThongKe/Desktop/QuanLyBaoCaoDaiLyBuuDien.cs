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
    public partial class QuanLyBaoCaoDaiLyBuuDien : Office2007Form
    {
        Huyen_Thi_Ctrl prohuyen = new Huyen_Thi_Ctrl();
        Xa_Phuong_CTrl proxa = new Xa_Phuong_CTrl();
        LoaiBaoCao_Ctrl proloaibaocao = new LoaiBaoCao_Ctrl();
        BaoCaoDaiLyBuuDien_Ctrl probaocao = new BaoCaoDaiLyBuuDien_Ctrl();
        MauBaoCaoDaiLyBuuDien_InFo maubaocao = new MauBaoCaoDaiLyBuuDien_InFo();
        MauBaoCaoDaiLyBuuDien_Ctrl promaubaocao = new MauBaoCaoDaiLyBuuDien_Ctrl();
        DaiLyBuuDien_Ctrl prodaily = new DaiLyBuuDien_Ctrl();
        BaoCaoDaiLyBuuDien_InFo baocao = new BaoCaoDaiLyBuuDien_InFo();
        DaiLyBuuDien_InFo dailybuudien = new DaiLyBuuDien_InFo();
        QL_DoanhNghiep_Ctrl prodoanhnghiep = new QL_DoanhNghiep_Ctrl();

        public QuanLyBaoCaoDaiLyBuuDien()
        {
            InitializeComponent();
        }

        private void QuanLyBaoCaoDaiLyBuuDien_Load(object sender, EventArgs e)
        {
            prohuyen.ComboBoxHuyen(cmbHuyen);
            proxa.ComboBoxXa(cmbXa);
            proloaibaocao.Combobox_Loaibaocao(cmbLoaibaocao);
            promaubaocao.ListMauBaoCao(dataGridViewX2, bindingNavigator1);
            probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);

            txtTenbaocao.ReadOnly = true;
            cmbNambaocao.Enabled = false;
            cmbLoaibaocao.Enabled = false;
            txtdienthoai.ReadOnly = true;
            txtGhichu.ReadOnly = true;

            tool_them.Enabled = true;
            tool_xoa.Enabled = true;
            tool_sua.Enabled = true;
            tool_luu.Enabled = false;
            tool_thoat.Visible = false;
            tool_sua1.Enabled = true;
            tool_luuphai.Enabled = false;
            tool_them1.Enabled = true;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;
        }

        private void tool_them_Click(object sender, EventArgs e)
        {
            LapBaoCaoDaiLyBuuDien frm = new LapBaoCaoDaiLyBuuDien();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                promaubaocao.ListMauBaoCao(dataGridViewX2, bindingNavigator1);
                probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);

                txtTenbaocao.ReadOnly = true;
                cmbNambaocao.Enabled = false;
                cmbLoaibaocao.Enabled = false;
                txtdienthoai.ReadOnly = true;
                txtGhichu.ReadOnly = true;
                //
                tool_them.Enabled = true;
                tool_xoa.Enabled = true;
                tool_sua.Enabled = true;
                tool_luu.Enabled = false;
                tool_thoat.Visible = false;
                tool_sua1.Enabled = true;
                tool_luuphai.Enabled = false;
                tool_them1.Enabled = true;

                dataGridViewX1.Enabled = true;
                dataGridViewX2.Enabled = true;
            }
        }

        private void tool_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa báo cáo\" " + txtTenbaocao.Text + " \" này không ?", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                maubaocao.MaMauBaoCaoDaiLyBuuDien = Convert.ToInt32(txtMamaubaocao.Text);
                probaocao.XoaToanBo(txtMamaubaocao.Text);
                promaubaocao.Xoa(maubaocao);
                promaubaocao.ListMauBaoCao(dataGridViewX2, bindingNavigator1);
                probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);
            }
        }

        private void tool_sua_Click(object sender, EventArgs e)
        {
            dataGridViewX1.Enabled = false;
            dataGridViewX2.Enabled = false;

            tool_them.Enabled = false;
            tool_xoa.Enabled = false;
            tool_sua.Enabled = false;
            tool_luu.Enabled = true;
            tool_thoat.Visible = false;
            tool_sua1.Enabled = false;
            tool_luuphai.Enabled = false;

            txtTenbaocao.ReadOnly = false;
            cmbLoaibaocao.Enabled = true;
            cmbNambaocao.Enabled = true;

            txtdienthoai.ReadOnly = true;
            txtGhichu.ReadOnly = true;
        }

        private void tool_luu_Click(object sender, EventArgs e)
        {
            if (promaubaocao.CheckInput(txtTenbaocao))
            {
                if (cmbLoaibaocao.SelectedValue.ToString() == "3" || cmbLoaibaocao.SelectedValue.ToString() == "4")
                {
                    maubaocao.MaMauBaoCaoDaiLyBuuDien = Convert.ToInt32(txtMamaubaocao.Text);
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
                    tool_sua1.Enabled = true;
                    tool_luuphai.Enabled = false;
                    tool_xoa1.Enabled = true;
                    tool_them1.Enabled = true;

                    txtTenbaocao.ReadOnly = true; ;
                    cmbLoaibaocao.Enabled = false;
                    cmbNambaocao.Enabled = false;

                    txtdienthoai.ReadOnly = true;
                    txtGhichu.ReadOnly = true;

                    dataGridViewX1.Enabled = true;
                    dataGridViewX2.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Báo cáo đại lý bưu điện không có loại báo cáo náy");

                }
            }
        }

        private void tool_xemlai_Click(object sender, EventArgs e)
        {
            promaubaocao.ListMauBaoCao(dataGridViewX2, bindingNavigator1);
            probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);
            
            txtTenbaocao.ReadOnly = true;
            cmbLoaibaocao.Enabled = false;
            cmbNambaocao.Enabled = false;

            txtdienthoai.ReadOnly = true;
            txtGhichu.ReadOnly = true;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;
        }

        private void tool_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        bool adding = false;
        bool updating = false;

        private void tool_them1_Click(object sender, EventArgs e)
        {
            adding = true;
            updating = false;

            txtTenbaocao.ReadOnly = true;
            cmbNambaocao.Enabled = false;
            cmbLoaibaocao.Enabled = false;

            txtTendailybuudien.ReadOnly = false;
            cmbXa.Enabled = true;
            txtDiachi.ReadOnly = false;
            txtdienthoai.ReadOnly = false;
            txtGhichu.ReadOnly = false;
            cmbHuyen.Enabled = true;

            dataGridViewX1.Enabled = false;
            dataGridViewX2.Enabled = false;

            txtTendailybuudien.Text = "";
            txtDiachi.Text = "";
            txtdienthoai.Text = "";
            txtGhichu.Text = "";

            tool_them.Enabled = false;
            tool_xoa.Enabled = false;
            tool_sua.Enabled = false;
            tool_luu.Enabled = true;
            tool_thoat.Visible = true;

            tool_sua1.Enabled = false;
            tool_them1.Enabled = false;
            tool_xoa1.Enabled = false;
            tool_luuphai.Enabled = true;  

            txtMadaily.Text = prodaily.LayMaMax().ToString();
        
        }

        private void tool_xoa1_Click(object sender, EventArgs e)
        {
            if (txtMadaily.Text == "")
                MessageBox.Show("Không có dự án để xóa !");
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa đại lý\" " + txtTendailybuudien.Text + " \" này ra khỏi báo cáo không ?", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    baocao.Maubaocao.MaMauBaoCaoDaiLyBuuDien = Convert.ToInt32(txtMamaubaocao.Text);
                    baocao.DaiLyBuuDien.MaDaiLyBuuDien = Convert.ToInt32(txtMadaily.Text);
                    probaocao.Xoa(baocao);
                    probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);
                }

                if (dataGridViewX1.RowCount == 0)
                {
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
            updating = true;
            adding = false;

            tool_them.Enabled = false;
            tool_xoa.Enabled = false;
            tool_sua.Enabled = false;
            tool_luu.Enabled = false;
            tool_thoat.Visible = false;
            tool_sua1.Enabled = false;
            tool_luuphai.Enabled = true;
            tool_xoa1.Enabled = false;
            tool_them1.Enabled = false;

            txtTenbaocao.ReadOnly = true;
            cmbLoaibaocao.Enabled = false;
            cmbNambaocao.Enabled = false;


            txtdienthoai.ReadOnly = false;
            txtGhichu.ReadOnly = false;

            dataGridViewX1.Enabled = false;
            dataGridViewX2.Enabled = false;
        }

        private void tool_luu1_Click(object sender, EventArgs e)
        {
            if (txtdienthoai.Text == "")
            {
                MessageBox.Show("Xin nhập số điện thoại !", "Chú ý", MessageBoxButtons.OK);
                txtdienthoai.Clear();
                txtdienthoai.Focus();
            }
            if (prodaily.Kiemtra(txtTendailybuudien, cmbXa, txtDiachi))
            {
                if (probaocao.CheckInput(txtdienthoai))
                {
                    if (adding)
                    {
                        dailybuudien.MaDaiLyBuuDien = Convert.ToInt32(txtMadaily.Text);
                        dailybuudien.TenDaiLy = txtTendailybuudien.Text;
                        dailybuudien.DiaChi = txtDiachi.Text;
                        dailybuudien.doanhnghiep.MaDoanhNghiep = Convert.ToInt32(txtMadoanhnghiep.Text);
                        dailybuudien.xa.MaXa = Convert.ToInt32(cmbXa.SelectedValue.ToString());
                        dailybuudien.DiaChi = txtDiachi.Text;
                        dailybuudien.huyen.MaHuyen = Convert.ToInt32(cmbHuyen.SelectedValue.ToString());
                        dailybuudien.DienThoai = txtdienthoai.Text;
                        dailybuudien.GhiChu = txtGhichu.Text;
                        prodaily.Them(dailybuudien);

                        baocao.Maubaocao.MaMauBaoCaoDaiLyBuuDien = Convert.ToInt32(txtMamaubaocao.Text);
                        baocao.DaiLyBuuDien.MaDaiLyBuuDien = Convert.ToInt32(txtMadaily.Text);
                        baocao.DienThoai = txtdienthoai.Text;
                        baocao.Ghichu = txtGhichu.Text;

                        probaocao.Them(baocao);
                        probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);
                    }
                    else
                        if (updating)
                        {
                            baocao.Maubaocao.MaMauBaoCaoDaiLyBuuDien = Convert.ToInt32(txtMamaubaocao.Text);
                            baocao.DaiLyBuuDien.MaDaiLyBuuDien = Convert.ToInt32(txtMadaily.Text);
                            baocao.DienThoai = txtdienthoai.Text;
                            baocao.Ghichu = txtGhichu.Text;

                            probaocao.Sua(baocao);
                            probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);
                        }

                    tool_them.Enabled = true;
                    tool_xoa.Enabled = true;
                    tool_sua.Enabled = true;
                    tool_luu.Enabled = false;
                    tool_thoat.Visible = true;
                    tool_sua1.Enabled = true;
                    tool_luuphai.Enabled = false;
                    tool_xoa1.Enabled = true;
                    tool_them1.Enabled = true;

                    txtTenbaocao.ReadOnly = true;
                    cmbLoaibaocao.Enabled = false;
                    cmbNambaocao.Enabled = false;

                    txtTendailybuudien.ReadOnly = true;
                    cmbXa.Enabled = false;
                    txtDiachi.ReadOnly = true;
                    txtdienthoai.ReadOnly = true;
                    txtGhichu.ReadOnly = true;
                    cmbHuyen.Enabled = false;


                    dataGridViewX1.Enabled = true;
                    dataGridViewX2.Enabled = true;
                }
            }
        }

        private void tool_xemlai1_Click(object sender, EventArgs e)
        {
            promaubaocao.ListMauBaoCao(dataGridViewX2, bindingNavigator1);
            probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);
            txtTenbaocao.ReadOnly = true;
            cmbLoaibaocao.Enabled = false;
            cmbNambaocao.Enabled = false;

            txtdienthoai.ReadOnly = true;
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
            txtTenbaocao.Text = row.Cells[1].Value.ToString();
            cmbLoaibaocao.Text = row.Cells[2].Value.ToString();
            cmbNambaocao.Text = row.Cells[3].Value.ToString();

            tool_them.Enabled = true;
            tool_xoa.Enabled = true;
            tool_sua.Enabled = true;
            tool_luu.Enabled = false;
            tool_thoat.Visible = true;

            if (dataGridViewX1.RowCount == 0)
            {
                tool_sua1.Enabled = false;
                tool_xoa1.Enabled = false;
            }
            else
            {
                tool_sua1.Enabled = true;
                tool_xoa1.Enabled = true;
            }
            tool_luuphai.Enabled = false;
            tool_them1.Enabled = true;
        }

        private void txtMamaubaocao_TextChanged(object sender, EventArgs e)
        {
            probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);

        }

        private void dataGridViewX1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewX1.Rows[e.RowIndex];
            txtMadaily.Text = row.Cells["Madaily"].Value.ToString();
            txtTendailybuudien.Text = row.Cells["Tendaily"].Value.ToString();
            txtDiachi.Text = row.Cells["diachi"].Value.ToString();
            cmbHuyen.Text = row.Cells["tenhuyen"].Value.ToString();
            txtMadoanhnghiep.Text = row.Cells["madoanhnghiep"].Value.ToString();

            lbDoanhnghiep.Text = row.Cells["tendoanhnghiep"].Value.ToString();
            QL_DoanhNghiep_InFo dn = prodoanhnghiep.timdoanhnghiep_baocao(lbDoanhnghiep.Text);
            lbDiachi.Text = dn.DiaChi;
            lbDienthoai.Text = dn.DienThoai;
            lbEmail.Text = dn.Email;
            lbFax.Text = dn.Fax;
            lbTrangweb.Text = dn.TrangWeb;

            txtdienthoai.Text = row.Cells["dienthoai"].Value.ToString();
            txtGhichu.Text = row.Cells["ghichu"].Value.ToString();
            cmbXa.Text = row.Cells["xa"].Value.ToString();
        }

        private void cmbHuyen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Xa_Phuong_CTrl huyen = new Xa_Phuong_CTrl();
            huyen.ListXa(cmbXa, Convert.ToInt32(cmbHuyen.SelectedValue));

        }

        private void cmbLoaibaocao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmbLoaibaocao.Text == "Báo cáo quý") || (cmbLoaibaocao.Text == "Báo cáo tháng"))
            {
                MessageBox.Show("Đại lý không tồn tại " + cmbLoaibaocao.Text, "Chú ý", MessageBoxButtons.OK);
                cmbLoaibaocao.Focus();
                tool_luu.Enabled = false;
            }
            else
                tool_luu.Enabled = true;
        }

        private void cmbLoaibaocao_MouseClick(object sender, MouseEventArgs e)
        {
            proloaibaocao.Combobox_Loaibaocao(cmbLoaibaocao);

        }

        private void loạiBáoCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_LoaiBaoCao loaiBC = new QL_LoaiBaoCao();
            loaiBC.ShowDialog();
            proloaibaocao.Combobox_Loaibaocao(cmbLoaibaocao);
        }

        private void huyệnThịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Huyen_Thi h = new QL_Huyen_Thi();
            h.ShowDialog();
            Huyen_Thi_Ctrl pro = new Huyen_Thi_Ctrl();
            pro.ComboBoxHuyen(cmbHuyen);
        }

        private void xãPhườngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Xa_Phuong_ x = new QL_Xa_Phuong_();
            x.ShowDialog();
            Xa_Phuong_CTrl xa = new Xa_Phuong_CTrl();
            xa.ComboBoxXa(cmbXa);
        }

        private void doanhNghiệpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_DoanhNghiep DN = new QL_DoanhNghiep();
            DN.ShowDialog();
        }

        private void đạiLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_DaiLyBuuDien dlbd = new QL_DaiLyBuuDien();
            dlbd.ShowDialog();
        }
    }
}