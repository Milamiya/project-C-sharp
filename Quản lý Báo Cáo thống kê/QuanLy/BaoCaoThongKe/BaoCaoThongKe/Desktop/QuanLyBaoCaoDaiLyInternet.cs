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
    public partial class QuanLyBaoCaoDaiLyInternet : Office2007Form
    {
        bool adding = false;
        bool updating = false;
        LoaiBaoCao_Ctrl proloaibaocao = new LoaiBaoCao_Ctrl();
        Huyen_Thi_Ctrl prohuyen = new Huyen_Thi_Ctrl();
        Xa_Phuong_CTrl proxa = new Xa_Phuong_CTrl();
        NhomThueBao_Ctrl prothuebao = new NhomThueBao_Ctrl();
        MauBaoCaoDaiLyInternet_Ctrl promaubaocao = new MauBaoCaoDaiLyInternet_Ctrl();
        BaoCaoDaiLyInternet_Ctrl probaocao = new BaoCaoDaiLyInternet_Ctrl();
        MauBaoCaoDaiLyInternet_InFo maubaocao = new MauBaoCaoDaiLyInternet_InFo();
        BaoCaoDaiLyInternet_InFo baocao = new BaoCaoDaiLyInternet_InFo();
        DaiLyInternet_InFo dailybuudien = new DaiLyInternet_InFo();
        DaiLyInternet_Ctrl prodaily = new DaiLyInternet_Ctrl();
        QL_DoanhNghiep_Ctrl prodoanhnghiep = new QL_DoanhNghiep_Ctrl();

        public QuanLyBaoCaoDaiLyInternet()
        {
            InitializeComponent();
        }

        private void QuanLyBaoCaoDaiLyInternet_Load(object sender, EventArgs e)
        {
            proloaibaocao.Combobox_Loaibaocao(cmbLoaibaocao);
            prohuyen.ComboBoxHuyen(cmbHuyen);
            proxa.ComboBoxXa(cmbXa);
            prothuebao.ComboBoxThueBao(cmbthuebao);
            promaubaocao.ListMauBaoCao_Int(dataGridViewX2, bindingNavigator1);
            probaocao.ListBaoCao_Int(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);

            txtTenbaocao.ReadOnly = true;
            cmbNambaocao.Enabled = false;
            cmbLoaibaocao.Enabled = false;
            txtsohieu.ReadOnly = true;
            cmbthuebao.Enabled = false;
            txtdienthoai.ReadOnly = true;
            txtGhichu.ReadOnly = true;

            tool_them.Enabled = true;
            tool_xoa.Enabled = true;
            tool_sua.Enabled = true;
            tool_luu.Enabled = false;
            tool_thoat.Enabled = true;
            tool_xemlai.Enabled = false;
            tool_sua1.Enabled = true;
            tool_luu1.Enabled = false;
            tool_xemlai1.Enabled = false;
            tool_them1.Enabled = true;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;
        }

        private void tool_them_Click(object sender, EventArgs e)
        {
            LapBaoCaoDaiLyInternet frm = new LapBaoCaoDaiLyInternet();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                promaubaocao.ListMauBaoCao_Int(dataGridViewX2, bindingNavigator1);
                probaocao.ListBaoCao_Int(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);
            }

            txtTenbaocao.ReadOnly = true;
            cmbNambaocao.Enabled = false;
            cmbLoaibaocao.Enabled = false;
            cmbthuebao.Enabled = false;
            txtsohieu.ReadOnly = true;
            txtdienthoai.ReadOnly = true;
            txtGhichu.ReadOnly = true;

            tool_them.Enabled = true;
            tool_xoa.Enabled = true;
            tool_sua.Enabled = true;
            tool_luu.Enabled = false;
            tool_thoat.Enabled = true;
            tool_xemlai.Enabled = true;
            tool_sua1.Enabled = true;
            tool_luu1.Enabled = false;
            tool_xemlai1.Enabled = false;
            tool_them1.Enabled = true;
        }

        private void tool_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có xóa báo cáo\" " + txtTenbaocao.Text + " \" này không", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                maubaocao.MaMauBaoCaoDaiLyInt = Convert.ToInt32(txtMamaubaocao.Text);
                probaocao.XoaToanBo_Int(txtMamaubaocao.Text);
                promaubaocao.Xoa_Int(maubaocao);
                promaubaocao.ListMauBaoCao_Int(dataGridViewX2, bindingNavigator1);
                probaocao.ListBaoCao_Int(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);
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
            tool_thoat.Enabled = false;
            tool_xemlai.Enabled = true;
            tool_sua1.Enabled = false;
            tool_luu1.Enabled = false;
            tool_xemlai1.Enabled = false;

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
                    maubaocao.MaMauBaoCaoDaiLyInt = Convert.ToInt32(txtMamaubaocao.Text);
                    // maubaocao.MaMauBaoCaoDaiLyInternet = Convert.ToInt32(txtMamaubaocao.Text);
                    maubaocao.LoaibaocaoInt.MaLoaiBaoCao = Convert.ToInt32(cmbLoaibaocao.SelectedValue.ToString());
                    //    maubaocao.Loaibaocao_Int.Maloaibaocao = Convert.ToInt32(cmbLoaibaocao.SelectedValue.ToString());
                    maubaocao.TenbaocaoInt = txtTenbaocao.Text;
                    maubaocao.NambaocaoInt = Convert.ToInt32(cmbNambaocao.Text);

                    promaubaocao.Sua_Int(maubaocao);
                    promaubaocao.ListMauBaoCao_Int(dataGridViewX2, bindingNavigator1);

                    tool_them.Enabled = true;
                    tool_xoa.Enabled = true;
                    tool_sua.Enabled = true;
                    tool_luu.Enabled = false;
                    tool_thoat.Enabled = true;
                    tool_xemlai.Enabled = false;
                    tool_sua1.Enabled = true;
                    tool_luu1.Enabled = true;
                    tool_xemlai1.Enabled = true;
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
                    MessageBox.Show("Báo cáo đại lý Internet không có loại báo cáo này");
            }
        }

        private void tool_xemlai_Click(object sender, EventArgs e)
        {
            tool_them.Enabled = true;
            tool_xoa.Enabled = true;
            tool_sua.Enabled = true;
            tool_luu.Enabled = false;
            tool_thoat.Enabled = true;
            tool_xemlai.Enabled = false;
            tool_sua1.Enabled = true;
            tool_luu1.Enabled = true;
            tool_xemlai1.Enabled = true;

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
            txtsohieu.ReadOnly = false;
            cmbthuebao.Enabled = true;
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
            tool_luu.Enabled = false;
            tool_thoat.Enabled = true;
            tool_xemlai.Enabled = false;
            tool_sua1.Enabled = false;
            tool_luu1.Enabled = true;
            tool_xemlai1.Enabled = true;
            tool_them1.Enabled = false;
            tool_xoa1.Enabled = false;

            txtMadaily.Text = prodaily.LayMaMax().ToString();
        }

        private void tool_xoa1_Click(object sender, EventArgs e)
        {
            if (txtMadaily.Text == "")
                MessageBox.Show("Không có dự án để xóa!");
            else
            {
                if (MessageBox.Show("bạn có xóa dự án\" " + txtMadaily.Text + " \" này ra khỏi báo cáo không?", "Chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    baocao.MaubaocaoInt.MaMauBaoCaoDaiLyInt = Convert.ToInt32(txtMamaubaocao.Text);
                    baocao.DaiLyInt.MaDaiLyInt = Convert.ToInt32(txtMadaily.Text);
                    //probaocao.Xoa_Int(baocao);
                    probaocao.Xoa_Int(baocao);
                    probaocao.ListBaoCao_Int(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);
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

            dataGridViewX1.Enabled = false;
            dataGridViewX2.Enabled = false;

            tool_them.Enabled = false;
            tool_xoa.Enabled = false;
            tool_sua.Enabled = false;
            tool_luu.Enabled = false;
            tool_thoat.Enabled = false;
            tool_xemlai.Enabled = false;
            tool_sua1.Enabled = false;
            tool_luu1.Enabled = true;
            tool_xemlai1.Enabled = true;
            tool_xoa1.Enabled = false;
            tool_them1.Enabled = false;

            txtTenbaocao.ReadOnly = true;
            cmbLoaibaocao.Enabled = false;
            cmbNambaocao.Enabled = false;

            txtsohieu.ReadOnly = true;
            cmbthuebao.Enabled = true;
            txtdienthoai.ReadOnly = false;
            txtGhichu.ReadOnly = false;
        }

        private void tool_luu1_Click(object sender, EventArgs e)
        {
            if (prodaily.CheckInput(txtTendailybuudien, cmbXa, txtDiachi, txtsohieu))
            {
                if (probaocao.CheckInput(txtdienthoai))
                {
                    if (adding)
                    {
                        dailybuudien.MaDaiLyInt = Convert.ToInt32(txtMadaily.Text);
                        dailybuudien.TenDaiLyInt = txtTendailybuudien.Text;
                        dailybuudien.DiaChiInt = txtDiachi.Text;
                        dailybuudien.doanhnghiepInt.MaDoanhNghiep = Convert.ToInt32(txtMadoanhnghiep.Text);
                        dailybuudien.xaInt.MaXa = Convert.ToInt32(cmbXa.SelectedValue.ToString());
                        dailybuudien.DiaChiInt = txtDiachi.Text;
                        dailybuudien.huyenInt.MaHuyen = Convert.ToInt32(cmbHuyen.SelectedValue.ToString());
                        dailybuudien.SoHieu = txtsohieu.Text;
                        prodaily.Them_Int(dailybuudien);

                        baocao.MaubaocaoInt.MaMauBaoCaoDaiLyInt = Convert.ToInt32(txtMamaubaocao.Text);
                        baocao.DaiLyInt.MaDaiLyInt = Convert.ToInt32(txtMadaily.Text);
                        baocao.ThueBao.MaThueBao = Convert.ToInt32(cmbthuebao.SelectedValue.ToString());
                        baocao.DienThoaiInt = txtdienthoai.Text;
                        baocao.GhichuInt = txtGhichu.Text;

                        probaocao.Them_Int(baocao);
                        probaocao.ListBaoCao_Int(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);
                    }
                    else
                        if (updating)
                        {
                            baocao.MaubaocaoInt.MaMauBaoCaoDaiLyInt = Convert.ToInt32(txtMamaubaocao.Text);
                            baocao.DaiLyInt.MaDaiLyInt = Convert.ToInt32(txtMadaily.Text);
                            baocao.ThueBao.MaThueBao = Convert.ToInt32(cmbthuebao.SelectedValue.ToString());
                            baocao.DienThoaiInt = txtdienthoai.Text;
                            baocao.GhichuInt = txtGhichu.Text;

                            probaocao.Sua_Int(baocao);
                            probaocao.ListBaoCao_Int(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);
                        }

                    tool_them.Enabled = true;
                    tool_xoa.Enabled = true;
                    tool_sua.Enabled = true;
                    tool_luu.Enabled = false;
                    tool_thoat.Enabled = true;
                    tool_xemlai.Enabled = false;
                    tool_sua1.Enabled = true;
                    tool_luu1.Enabled = false;
                    tool_xemlai1.Enabled = false;
                    tool_xoa1.Enabled = true;
                    tool_them1.Enabled = true;

                    txtTenbaocao.ReadOnly = true;
                    cmbLoaibaocao.Enabled = false;
                    cmbNambaocao.Enabled = false;

                    txtTendailybuudien.ReadOnly = true;
                    cmbXa.Enabled = false;
                    txtDiachi.ReadOnly = true;
                    txtsohieu.ReadOnly = true;
                    cmbthuebao.Enabled = false;
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
            tool_them.Enabled = true;
            tool_xoa.Enabled = true;
            tool_sua.Enabled = true;
            tool_luu.Enabled = false;
            tool_thoat.Enabled = true;
            tool_xemlai.Enabled = false;
            tool_sua1.Enabled = true;
            tool_luu1.Enabled = false;
            tool_xemlai1.Enabled = false;
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
            txtsohieu.ReadOnly = true;
            cmbthuebao.Enabled = false;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;
        }

        private void tool_thoat1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewX2_CellClick(object sender, DataGridViewCellEventArgs e)
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
            tool_thoat.Enabled = true;
            tool_xemlai.Enabled = false;

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
            tool_luu1.Enabled = false;
            tool_xemlai1.Enabled = false;
            tool_them1.Enabled = true;
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewX1.Rows[e.RowIndex];
            txtMadaily.Text = row.Cells["Madaily"].Value.ToString();
            txtTendailybuudien.Text = row.Cells["Tendaily"].Value.ToString();
            txtDiachi.Text = row.Cells["diachi"].Value.ToString();
            cmbHuyen.Text = row.Cells["tenhuyen"].Value.ToString();
            cmbthuebao.Text = row.Cells["tenthuebao"].Value.ToString();
            txtsohieu.Text = row.Cells["sohieu"].Value.ToString();
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

        private void txtMamaubaocao_TextChanged(object sender, EventArgs e)
        {
            probaocao.ListBaoCao_Int(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator2);

        }

        private void txtdienthoai_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < txtdienthoai.Text.Length; i++)

                if (!char.IsNumber(txtdienthoai.Text[i]) & (txtdienthoai.Text[i] >= 10))
                {
                    MessageBox.Show("Điện thoại phải là số !", "Chú ý", MessageBoxButtons.OK);
                    txtdienthoai.Clear();
                    txtdienthoai.Focus();
                    break;
                }
                else if (txtdienthoai.Text.Length < 6)
                {
                    MessageBox.Show("Điện thoại phải lớn hơn 6", "Chú ý ", MessageBoxButtons.OK);
                    txtdienthoai.Clear();
                    txtdienthoai.Focus();
                }

                else if (txtdienthoai.Text.Length > 11)
                {
                    MessageBox.Show("Điện thoại phải nhỏ hơn 11 số", "Chú ý ", MessageBoxButtons.OK);
                    txtdienthoai.Clear();
                    txtdienthoai.Focus();
                }
                else if (txtdienthoai.Text == "")
                {
                    MessageBox.Show("Hãy nhập số điện thoại của đại lý", "Chú ý ", MessageBoxButtons.OK);
                    txtdienthoai.Clear();
                    txtdienthoai.Focus();
                    tool_luu1.Enabled = false;
                }
                else
                    tool_luu1.Enabled = true;
        }

        private void cmbHuyen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            proxa.ListXa(cmbXa, Convert.ToInt32(cmbHuyen.SelectedValue));

        }

        private void txtsohieu_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < txtsohieu.Text.Length; i++)

                if (!char.IsNumber(txtsohieu.Text[i]) & (txtsohieu.Text[i] >= 10))
                {
                    MessageBox.Show("Số hiệu đại lý phải là số !", "Chú ý", MessageBoxButtons.OK);
                    txtsohieu.Clear();
                    txtsohieu.Focus();
                    break;
                }
        }

        private void btnThemThueBao_Click(object sender, EventArgs e)
        {
            QL_NhomThueBao ThueBao = new QL_NhomThueBao();
            ThueBao.ShowDialog();
            prothuebao.ComboBoxThueBao(cmbthuebao);
        }

        private void cmbXa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Xa_Phuong_CTrl ctrl = new Xa_Phuong_CTrl();
                cmbHuyen.SelectedValue = ctrl.LayMaHuyen(cmbXa.SelectedValue.ToString());
            }
            catch
            {
            }
        }
    }
}