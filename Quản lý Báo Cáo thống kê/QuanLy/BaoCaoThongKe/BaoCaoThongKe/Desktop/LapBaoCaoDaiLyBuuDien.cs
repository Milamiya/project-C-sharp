using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BaoCaoThongKe.Controller;
using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.Desktop
{
    public partial class LapBaoCaoDaiLyBuuDien : Office2007Form
    {
        QL_DoanhNghiep_Ctrl prodoanhnghiep = new QL_DoanhNghiep_Ctrl();
        Huyen_Thi_Ctrl prohuyen = new Huyen_Thi_Ctrl();
        LoaiBaoCao_Ctrl proloaibaocao = new LoaiBaoCao_Ctrl();
        DaiLyBuuDien_Ctrl prodailybuudien = new DaiLyBuuDien_Ctrl();
        MauBaoCaoDaiLyBuuDien_Ctrl promaubaocao = new MauBaoCaoDaiLyBuuDien_Ctrl();
        MauBaoCaoDaiLyBuuDien_InFo info1 = new MauBaoCaoDaiLyBuuDien_InFo();
        BaoCaoDaiLyBuuDien_InFo info = new BaoCaoDaiLyBuuDien_InFo();
        BaoCaoDaiLyBuuDien_Ctrl probaocao = new BaoCaoDaiLyBuuDien_Ctrl();

        private MauBaoCaoDaiLyBuuDien_InFo m_Maubaocao = new MauBaoCaoDaiLyBuuDien_InFo();
        public MauBaoCaoDaiLyBuuDien_InFo Maubaocao
        {
            get { return m_Maubaocao; }
            set { m_Maubaocao = value; }
        }
        public LapBaoCaoDaiLyBuuDien()
        {
            InitializeComponent();
        }

        private void LapBaoCaoDaiLyBuuDien_Load(object sender, EventArgs e)
        {
            cmbHuyen.Enabled = false;
            prodoanhnghiep.ComboBoxDN(cmbDoanhnghiep);
            prohuyen.ComboBoxHuyen(cmbHuyen);
            proloaibaocao.Combobox_Loaibaocao(cmbLoaibaocao);

            if (checkbox_huyen.Checked)
                prodailybuudien.ListDaiLy_Huyen(dataGridViewX1, bindingNavigator1, cmbHuyen, cmbDoanhnghiep);
            else
                prodailybuudien.ListDaiLy_Doanhnghiep(dataGridViewX1, bindingNavigator1, cmbDoanhnghiep);

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;
            txtMamaubaocao.Text = promaubaocao.LayMaMax().ToString();
        }

        private void cmbDoanhnghiep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkbox_huyen.Checked)
                prodailybuudien.ListDaiLy_Huyen(dataGridViewX1, bindingNavigator1, cmbHuyen, cmbDoanhnghiep);
            else
                prodailybuudien.ListDaiLy_Doanhnghiep(dataGridViewX1, bindingNavigator1, cmbDoanhnghiep);
        }

        private void tool_luu_Click(object sender, EventArgs e)
        {
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Xin hãy nhập số điện thoại !", "Chú ý", MessageBoxButtons.OK);
                txtDienThoai.Clear();
                txtDienThoai.Focus();
            }
            if (txtMaDaiLy.Text == "")
                ToString();
            else
                for (int i = 0; i < dataGridViewX2.RowCount; i++)
                {
                    DataGridViewRow row = dataGridViewX2.Rows[i];
                    //txttam.Text = row.Cells["Madaily1"].Value.ToString();
                    if (txtMaDaiLy.Text == txttam.Text)
                    {
                        row.Cells["Dienthoai"].Value = txtDienThoai.Text;
                        row.Cells["Ghichu"].Value = txtGhichu.Text;
                        break;
                    }
                }

            tool_them.Enabled = true;
            tool_xoa.Enabled = false;
            tool_lapbaocao.Enabled = false;
            tool_sua.Enabled = false;
            tool_thoat.Visible = true;
            tool_luu.Enabled = false;

            dataGridViewX2.Enabled = true;
            dataGridViewX1.Enabled = true;
           
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewX1.Rows[e.RowIndex];

            txtMaDaiLy.Text = row.Cells["Madaily"].Value.ToString();
            txtTenDaily.Text = row.Cells["Tendaily"].Value.ToString();
            cmbXa.Text = row.Cells["xa"].Value.ToString();
            txtDiaChi.Text = row.Cells["Diachi"].Value.ToString();
            cmbHuyen.Text = row.Cells["Huyen"].Value.ToString();

            txtGhichu.ReadOnly = false;
            txtDienThoai.ReadOnly = false;

            txtGhichu.Text = "";
            txtDienThoai.Text = "";

            tool_them.Enabled = true;
            if (dataGridViewX2.RowCount == 1)
            {
                tool_lapbaocao.Enabled = false;
                tool_xoa.Enabled = false;
                tool_sua.Enabled = false;
            }
            else
            {
                tool_lapbaocao.Enabled = true;
                tool_xoa.Enabled = true;
                tool_sua.Enabled = true;
            }
            tool_lapbaocao.Enabled = false;
            tool_thoat.Visible = true;
            tool_luu.Enabled = false;
        }

        private void txtDienThoai_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < txtDienThoai.Text.Length; i++)
            {
                if (!char.IsNumber(txtDienThoai.Text[i]) & (txtDienThoai.Text[i] >= 10))
                {
                    MessageBox.Show("Điện thoại phải là số !", "Chú ý", MessageBoxButtons.OK);
                    txtDienThoai.Clear();
                    txtDienThoai.Focus();
                    break;
                }
                else if (txtDienThoai.Text.Length < 6)
                {
                    MessageBox.Show("Điện thoại phải lớn hơn 6 !", "Chú ý ", MessageBoxButtons.OK);
                    txtDienThoai.Clear();
                    txtDienThoai.Focus();
                }

                else if (txtDienThoai.Text.Length > 11)
                {
                    MessageBox.Show("Điện thoại phải nhỏ hơn 11 số !", "Chú ý ", MessageBoxButtons.OK);
                    txtDienThoai.Clear();
                    txtDienThoai.Focus();
                }
                else if (txtDienThoai.Text == "")
                {
                    MessageBox.Show("Hãy nhập số điện thoại của đại lý !", "Chú ý ", MessageBoxButtons.OK);
                    txtDienThoai.Clear();
                    txtDienThoai.Focus();
                    tool_luu.Enabled = false;
                }
                else
                    tool_luu.Enabled = true;
            }
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
                tool_luu.Enabled = false;
        }

        private void cmbLoaibaocao_MouseClick(object sender, MouseEventArgs e)
        {
            proloaibaocao.Combobox_Loaibaocao(cmbLoaibaocao);
        }

        private void checkbox_huyen_CheckedChanged(object sender, EventArgs e)
        {
            cmbHuyen.Enabled = true;
            if (checkbox_huyen.Checked)
            {
                cmbHuyen.Enabled = true;
                cmbDoanhnghiep.Enabled = false;
                prodailybuudien.ListDaiLy_Huyen(dataGridViewX1, bindingNavigator1, cmbHuyen, cmbDoanhnghiep);
            }
            else
            {
                checkbox_huyen.Checked = false;
                cmbHuyen.Enabled = false;
                cmbDoanhnghiep.Enabled = true;
                prodailybuudien.ListDaiLy_Doanhnghiep(dataGridViewX1, bindingNavigator1, cmbDoanhnghiep);
            }
        }

        private void dataGridViewX2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row1 = dataGridViewX2.Rows[e.RowIndex];
            if (row1.Cells["Madaily1"].Value == null)
            {
                txtDiaChi.Text = "";
                txtGhichu.Text = "";
                txtTenDaily.Text = "";
                txtMaDaiLy.Text = "";
                cmbXa.Text = "";
                txtDienThoai.Text = "";
            }
            else
            {
                txtMaDaiLy.Text = row1.Cells["Madaily1"].Value.ToString();
                txtTenDaily.Text = row1.Cells["Tendaily1"].Value.ToString();
                txtDiaChi.Text = row1.Cells["Diachi1"].Value.ToString();
                cmbXa.Text = row1.Cells["Xa1"].Value.ToString();
                cmbHuyen.Text = row1.Cells["Huyen1"].Value.ToString();
                txtDienThoai.Text = row1.Cells["Dienthoai"].Value.ToString();
                txtGhichu.Text = row1.Cells["Ghichu"].Value.ToString();
            }

            txtGhichu.ReadOnly = true;
            txtDienThoai.ReadOnly = true;

            tool_them.Enabled = false;
            tool_xoa.Enabled = true;
            tool_lapbaocao.Enabled = true;
            tool_sua.Enabled = true;
            tool_thoat.Visible = true;
            tool_luu.Enabled = false;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;
        }

        private void cmbHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkbox_huyen.Checked)
                prodailybuudien.ListDaiLy_Huyen(dataGridViewX1, bindingNavigator1, cmbHuyen, cmbDoanhnghiep);
            else
                prodailybuudien.ListDaiLy_Doanhnghiep(dataGridViewX1, bindingNavigator1, cmbDoanhnghiep);

        }

        private void tool_lapbaocao_Click(object sender, EventArgs e)
        {
            if (txtTenbaocao.Text == "")
                MessageBox.Show("Xin nhập tên của báo cáo !", "Chú ý", MessageBoxButtons.OK);
            else
            {
                if (cmbLoaibaocao.SelectedValue.ToString() == "3" || cmbLoaibaocao.SelectedValue.ToString() == "4")
                {
                    //luu du lieu vao mau bao cao  
                    info1.MaMauBaoCaoDaiLyBuuDien = Convert.ToInt32(txtMamaubaocao.Text);
                    info1.Tenbaocao = txtTenbaocao.Text;
                    info1.Loaibaocao.MaLoaiBaoCao = Convert.ToInt32(cmbLoaibaocao.SelectedValue);
                    info1.Nambaocao = Convert.ToInt32(cmbnambaocao.Text);
                    info1.MaMauBaoCaoDaiLyBuuDien = Convert.ToInt32(txtMamaubaocao.Text);
                    info1.Tenbaocao = txtTenbaocao.Text;
                    info1.Loaibaocao.MaLoaiBaoCao = Convert.ToInt32(cmbLoaibaocao.SelectedValue);
                    info1.Nambaocao = Convert.ToInt32(cmbnambaocao.Text);
                    promaubaocao.Them(info1);

                    MessageBox.Show("Thêm mẫu Báo Cáo thành công !", "Báo Cáo", MessageBoxButtons.OK);
                    //luu chi tiet cua mau bao cao                
                    for (int i = 0; i < dataGridViewX2.RowCount - 1; i++)
                    {
                        DataGridViewRow row = dataGridViewX2.Rows[i];
                        info.Maubaocao.MaMauBaoCaoDaiLyBuuDien = Convert.ToInt32(txtMamaubaocao.Text);
                        info.DaiLyBuuDien.MaDaiLyBuuDien = Convert.ToInt32(row.Cells["Madaily1"].Value.ToString());
                        info.DienThoai = row.Cells["Dienthoai"].Value.ToString();
                        info.Ghichu = row.Cells["Ghichu"].Value.ToString();
                        probaocao.Them(info);
                    }

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Báo cáo đại lý bưu điện không có loại báo cáo náy");
                }
            }
        }

        private void tool_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tool_xoa_Click(object sender, EventArgs e)
        {
            int tam = 0;
            if (txtMaDaiLy.Text == "")
                ToString();
            else
            {
                for (int i = 0; i < dataGridViewX2.RowCount; i++)
                {
                    DataGridViewRow row = dataGridViewX2.Rows[i];

                    txttam.Text = row.Cells["Madaily1"].Value.ToString();
                    if (txtMaDaiLy.Text == txttam.Text)
                    {
                        if (MessageBox.Show("Bạn có chắc chắn xóa đại lý \" " + row.Cells["Tendaily1"].Value.ToString() + " \" này ra khỏi báo cáo không ?", "chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            row.Cells["Madaily1"].Value = null;
                            row.Cells["Tendaily1"].Value = "";
                            row.Cells["xa1"].Value = "";
                            row.Cells["Diachi1"].Value = "";
                            row.Cells["Dienthoai"].Value = "";
                            row.Cells["Ghichu"].Value = "";
                            tam = i;
                            break;
                        }
                    }
                }
                for (int i = tam; i < dataGridViewX2.RowCount; i++)
                {
                    DataGridViewRow row = dataGridViewX2.Rows[i];
                    for (int j = i + 1; j < dataGridViewX2.RowCount; j++)
                    {
                        DataGridViewRow row1 = dataGridViewX2.Rows[j];
                        if (row1.Cells["Madaily1"].Value != null)
                        {
                            row.Cells["Madaily1"].Value = row1.Cells["Madaily1"].Value.ToString();
                            row.Cells["Tendaily1"].Value = row1.Cells["Tendaily1"].Value.ToString();
                            row.Cells["Diachi1"].Value = row1.Cells["Diachi1"].Value.ToString();
                            row.Cells["Xa1"].Value = row1.Cells["Xa1"].Value.ToString();
                            row.Cells["Dienthoai"].Value = row1.Cells["Dienthoai"].Value.ToString();
                            row.Cells["Ghichu"].Value = row1.Cells["Ghichu"].Value.ToString();

                            break;
                        }
                        else
                        {
                            dataGridViewX2.RowCount = dataGridViewX2.RowCount - 1;
                            break;
                        }
                    }
                }
                if (dataGridViewX2.RowCount == 1)
                {
                    tool_lapbaocao.Enabled = false;
                    tool_xoa.Enabled = false;
                    tool_sua.Enabled = false;
                }
                else
                {
                    tool_lapbaocao.Enabled = true;
                    tool_xoa.Enabled = true;
                    tool_sua.Enabled = true;
                }
            }
        }

        private void tool_sua_Click(object sender, EventArgs e)
        {
            txtGhichu.ReadOnly = false;
            txtDienThoai.ReadOnly = false;

            tool_them.Enabled = false;
            tool_xoa.Enabled = false;
            tool_lapbaocao.Enabled = false;
            tool_sua.Enabled = false;
            tool_thoat.Visible = false;
            tool_luu.Enabled = true;

            dataGridViewX1.Enabled = false;
            dataGridViewX2.Enabled = false;
        }

        private void tool_them_Click(object sender, EventArgs e)
        {
            int tam = 0;
            dataGridViewX2.RowCount = dataGridViewX2.RowCount + 1;
            if (txtMaDaiLy.Text == "")
            {
                MessageBox.Show("Xin chọn lại đại lý cần đưa vào báo cáo !", "Chú ý");
                dataGridViewX2.RowCount = dataGridViewX2.RowCount - 1;
            }
            else
            {
                for (int i = 0; i < dataGridViewX2.RowCount; i++)
                {
                    DataGridViewRow row = dataGridViewX2.Rows[i];
                    if (row.Cells["Madaily1"].Value == null)
                        break;
                    if (row.Cells["DoanhNghiep"].Value.ToString() != cmbDoanhnghiep.Text)
                    {
                        MessageBox.Show("Không thể đưa đại lý của doanh nghiệp này vào báo cáo !");
                        tam = 1;
                        dataGridViewX2.RowCount = dataGridViewX2.RowCount - 1;
                        break;
                    }
                    else
                    {
                        txttam.Text = row.Cells["Madaily1"].Value.ToString();
                        if (txtMaDaiLy.Text == txttam.Text)
                        {
                            dataGridViewX2.RowCount = dataGridViewX2.RowCount - 1;
                            MessageBox.Show("Đại lý này  đã được bạn đưa vào báo cáo rồi !");
                            row.Cells["Madaily1"].Value = null;
                            row.Cells["Tendaily1"].Value = "";
                            row.Cells["Xa1"].Value = "";
                            row.Cells["Huyen1"].Value = "";
                            row.Cells["Mabaocao"].Value = "";
                            row.Cells["DoanhNghiep"].Value = "";

                            txtDienThoai.Text = row.Cells["Dienthoai"].Value.ToString();

                            row.Cells["Dienthoai"].Value = "";
                            row.Cells["Ghichu"].Value = "";
                            break;
                        }
                    }
                }
                if (tam == 0)
                {
                    for (int j = 0; j < dataGridViewX2.RowCount; j++)
                    {
                        DataGridViewRow row1 = dataGridViewX2.Rows[j];
                        if (row1.Cells["Madaily1"].Value == null)
                        {
                            if (probaocao.CheckInput(txtDienThoai))
                            {

                                row1.Cells["Madaily1"].Value = txtMaDaiLy.Text;
                                row1.Cells["Xa1"].Value = cmbXa.Text;
                                row1.Cells["Tendaily1"].Value = txtTenDaily.Text;
                                row1.Cells["Huyen1"].Value = cmbHuyen.SelectedValue.ToString();
                                row1.Cells["Diachi1"].Value = txtDiaChi.Text;
                                row1.Cells["DoanhNghiep"].Value = cmbDoanhnghiep.Text;
                                row1.Cells["Dienthoai"].Value = txtDienThoai.Text;
                                row1.Cells["Ghichu"].Value = txtGhichu.Text;
                                break;
                            }
                            else
                                dataGridViewX2.RowCount = dataGridViewX2.RowCount - 1;
                        }
                    }
                }

                txtGhichu.ReadOnly = false;
                txtDienThoai.ReadOnly = false;

                txtGhichu.Text = "";
                txtDienThoai.Text = "";

                tool_them.Enabled = true;
                tool_xoa.Enabled = false;
                tool_lapbaocao.Enabled = true;
                tool_sua.Enabled = false;
                tool_thoat.Visible = true;
                tool_luu.Enabled = false;

                dataGridViewX1.Enabled = true;
                dataGridViewX2.Enabled = true;
            }
        }

        private void tool_xemlai_Click(object sender, EventArgs e)
        {
            txtGhichu.ReadOnly = true;
            txtDienThoai.ReadOnly = true;


            tool_them.Enabled = true;
            tool_xoa.Enabled = false;
            tool_lapbaocao.Enabled = false;
            tool_sua.Enabled = false;
            tool_xemlai.Enabled = false;
            tool_thoat.Enabled = true;
            tool_luu.Enabled = false;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;
        }

        private void doanhNghiệpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_DoanhNghiep DN = new QL_DoanhNghiep();
            DN.ShowDialog();
            QL_DoanhNghiep_Ctrl pro = new QL_DoanhNghiep_Ctrl();
            pro.ComboBoxDN(cmbDoanhnghiep);
        }

        private void huyệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Huyen_Thi h = new QL_Huyen_Thi();
            h.ShowDialog();
            Huyen_Thi_Ctrl pro = new Huyen_Thi_Ctrl();
            pro.ComboBoxHuyen(cmbHuyen);
        }

        private void xãToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Xa_Phuong_ x = new QL_Xa_Phuong_();
            x.ShowDialog();
            Xa_Phuong_CTrl xa = new Xa_Phuong_CTrl();
            xa.ComboBoxXa(cmbXa);
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_DaiLyBuuDien dlbd = new QL_DaiLyBuuDien();
            dlbd.ShowDialog();
        }

        private void loạiBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_LoaiBaoCao loaiBC = new QL_LoaiBaoCao();
            loaiBC.ShowDialog();
            proloaibaocao.Combobox_Loaibaocao(cmbLoaibaocao);
        }
     
    }
}