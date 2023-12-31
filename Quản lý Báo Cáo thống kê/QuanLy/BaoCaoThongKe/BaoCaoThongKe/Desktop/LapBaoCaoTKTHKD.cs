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
    public partial class LapBaoCaoTKTHKD : Office2007Form
    {

        public LapBaoCaoTKTHKD()
        {
            InitializeComponent();
        }

        CongTrinhVienThong_Ctrl procongtrinh = new CongTrinhVienThong_Ctrl();
        LoaiBaoCao_Ctrl proloaibaocao = new LoaiBaoCao_Ctrl();
        MauBaoCaoTKTHKD_InFo info1 = new MauBaoCaoTKTHKD_InFo();
        BaoCaoTKTHKD_InFo info = new BaoCaoTKTHKD_InFo();
        MauBaoCaoTKTHKD_Ctrl promaubaocao = new MauBaoCaoTKTHKD_Ctrl();
        BaoCaoTKTHKD_Ctrl probaocao = new BaoCaoTKTHKD_Ctrl();
        QL_DoanhNghiep_Ctrl prodoanhnghiep = new QL_DoanhNghiep_Ctrl();
        LoaiCongTrinh_Ctrl proloaicongtrinh = new LoaiCongTrinh_Ctrl();

        private void LapBaoCaoTKTHKD_Load(object sender, EventArgs e)
        {
            prodoanhnghiep.ComboBoxDN(cmbDoanhnghiep);
            proloaicongtrinh.ComboBoxLoaiCongTrinh(cmbLoaicongtrinh);
            proloaibaocao.Combobox_Loaibaocao(cmbLoaibaocao);
            procongtrinh.ListCongTrinh_Doanhnghiep(dataGridViewX1, bindingNavigator1, cmbDoanhnghiep, cmbLoaicongtrinh);

            tool_them.Enabled = true;
            tool_xoa.Enabled = false;
            tool_lapbaocao.Enabled = false;
            tool_sua.Enabled = false;
            tool_xemlai.Enabled = false;
            tool_thoat.Enabled = true;
            tool_save.Enabled = false;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;

            txtMamaubaocao.Text = promaubaocao.LayMaMax().ToString();
        }

        private void tool_them_Click(object sender, EventArgs e)
        {
            int tam = 0;
            dataGridViewX2.RowCount = dataGridViewX2.RowCount + 1;
            if (txtMacongtrinh.Text == "")
            {
                MessageBox.Show("Xin chọn lại công trình cần đưa vào báo cáo!");
                dataGridViewX2.RowCount = dataGridViewX2.RowCount - 1;
            }
            else
            {
                for (int i = 0; i < dataGridViewX2.RowCount; i++)
                {
                    DataGridViewRow row = dataGridViewX2.Rows[i];
                    if (row.Cells["macongtrinh1"].Value == null)
                        break;
                    if (row.Cells["tendoanhnghiep1"].Value.ToString() != cmbDoanhnghiep.Text || row.Cells["tenloaicongtrinh1"].Value.ToString() != cmbLoaicongtrinh.Text)
                    {
                        MessageBox.Show("Bạn không thể đưa công trình này vào báo cáo được");
                        tam = 1;
                        dataGridViewX2.RowCount = dataGridViewX2.RowCount - 1;
                        break;
                    }
                    else
                    {
                        txttam.Text = row.Cells["macongtrinh1"].Value.ToString();
                        if (txtMacongtrinh.Text == txttam.Text)
                        {
                            dataGridViewX2.RowCount = dataGridViewX2.RowCount - 1;
                            MessageBox.Show("Công trình này đã được bạn đưa vào báo cáo rồi!");
                            row.Cells["macongtrinh1"].Value = null;
                            row.Cells["tencongtrinh1"].Value = "";
                            row.Cells["mabaocao"].Value = "";
                            row.Cells["tendoanhnghiep1"].Value = "";
                            row.Cells["tenloaicongtrinh1"].Value = "";

                            txtSoluong.Text = row.Cells["soluong1"].Value.ToString();

                            row.Cells["soluong1"].Value = "";
                            row.Cells["ghichu1"].Value = "";
                            break;
                        }
                    }
                }
                if (tam == 0)
                {
                    for (int j = 0; j < dataGridViewX2.RowCount; j++)
                    {
                        DataGridViewRow row1 = dataGridViewX2.Rows[j];
                        if (row1.Cells["macongtrinh1"].Value == null)
                        {
                            if (probaocao.CheckInput(txtSoluong))
                            {
                                //row1.Cells["Mabaocao"].Value=txtMabaocao.Text;
                                row1.Cells["macongtrinh1"].Value = txtMacongtrinh.Text;
                                row1.Cells["tenloaicongtrinh1"].Value = cmbLoaicongtrinh.Text;
                                row1.Cells["tencongtrinh1"].Value = txtTencongtrinh.Text;
                                row1.Cells["tendoanhnghiep1"].Value = cmbDoanhnghiep.Text;
                                row1.Cells["soluong1"].Value = txtSoluong.Text;
                                row1.Cells["ghichu1"].Value = txtGhichu.Text;
                                break;
                            }
                            else
                                dataGridViewX2.RowCount = dataGridViewX2.RowCount - 1;
                        }
                    }
                }

                txtSoluong.ReadOnly = false;
                txtGhichu.ReadOnly = false;

                txtGhichu.Text = "";
                txtSoluong.Text = "";

                tool_them.Enabled = true;
                tool_xoa.Enabled = false;
                tool_lapbaocao.Enabled = true;
                tool_sua.Enabled = false;
                tool_xemlai.Enabled = false;
                tool_thoat.Enabled = true;
                tool_save.Enabled = false;

                dataGridViewX1.Enabled = true;
                dataGridViewX2.Enabled = true;
            }
        }

        private void tool_xoa_Click(object sender, EventArgs e)
        {
            int tam = 0;
            if (txtMacongtrinh.Text == "")
                ToString();
            else
            {
                for (int i = 0; i < dataGridViewX2.RowCount; i++)
                {
                    DataGridViewRow row = dataGridViewX2.Rows[i];

                    txttam.Text = row.Cells["macongtrinh1"].Value.ToString();
                    if (txtMacongtrinh.Text == txttam.Text)
                    {
                        if (MessageBox.Show("Bạn có chắc chắn xóa công trình\" " + row.Cells["tencongtrinh1"].Value.ToString() + " \" này ra khỏi báo cáo không ?", "chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            row.Cells["macongtrinh1"].Value = null;
                            row.Cells["tencongtrinh1"].Value = "";
                            row.Cells["tenloaicongtrinh1"].Value = "";
                            row.Cells["soluong1"].Value = "";
                            row.Cells["ghichu1"].Value = "";
                            row.Cells["tendoanhnghiep1"].Value = "";
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
                        if (row1.Cells["macongtrinh1"].Value != null)
                        {
                            row.Cells["macongtrinh1"].Value = row1.Cells["macongtrinh1"].Value.ToString();
                            row.Cells["tencongtrinh1"].Value = row1.Cells["tencongtrinh1"].Value.ToString();
                            row.Cells["tenloaicongtrinh1"].Value = row1.Cells["tenloaicongtrinh1"].Value.ToString();
                            row.Cells["soluong1"].Value = row1.Cells["soluong1"].Value.ToString();
                            row.Cells["tendoanhnghiep1"].Value = row1.Cells["tendoanhnghiep1"].Value.ToString();
                            row.Cells["ghichu1"].Value = row1.Cells["ghichu1"].Value.ToString();

                            break;
                        }
                        else
                        {
                            dataGridViewX2.RowCount = dataGridViewX2.RowCount - 1;
                            break;
                        }
                    }
                }
            }
            if (dataGridViewX2.RowCount == 1)
            {
                tool_lapbaocao.Enabled = false;
                tool_sua.Enabled = false;
                tool_xoa.Enabled = false;
            }
            else
            {
                tool_lapbaocao.Enabled = true;
                tool_sua.Enabled = true;
                tool_xoa.Enabled = true;
            }
        }

        private void tool_sua_Click(object sender, EventArgs e)
        {
            txtSoluong.ReadOnly = false;
            txtGhichu.ReadOnly = false;

            tool_them.Enabled = false;
            tool_xoa.Enabled = false;
            tool_lapbaocao.Enabled = false;
            tool_sua.Enabled = false;
            tool_xemlai.Enabled = true;
            tool_thoat.Enabled = false;
            tool_save.Enabled = true;
            btn_ok.Enabled = false;

            dataGridViewX1.Enabled = false;
            dataGridViewX2.Enabled = false;
        }

        private void tool_save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewX2.RowCount; i++)
            {
                DataGridViewRow row = dataGridViewX2.Rows[i];
                txttam.Text = row.Cells["macongtrinh1"].Value.ToString();
                if (txtMacongtrinh.Text == txttam.Text)
                {
                    row.Cells["soluong1"].Value = txtSoluong.Text;
                    row.Cells["ghichu1"].Value = txtGhichu.Text;
                    break;
                }
            }

            tool_them.Enabled = true;
            tool_xoa.Enabled = false;
            tool_lapbaocao.Enabled = false;
            tool_sua.Enabled = false;
            tool_xemlai.Enabled = false;
            tool_thoat.Enabled = true;
            tool_save.Enabled = false;
            btn_ok.Enabled = true;

            txtSoluong.ReadOnly = true;
            txtGhichu.ReadOnly = true;

            dataGridViewX2.Enabled = true;
            dataGridViewX1.Enabled = true;
        }

        private void tool_xemlai_Click(object sender, EventArgs e)
        {
            txtSoluong.ReadOnly = true;
            txtGhichu.ReadOnly = true;

            tool_them.Enabled = true;
            tool_xoa.Enabled = false;
            tool_lapbaocao.Enabled = false;
            tool_sua.Enabled = false;
            tool_xemlai.Enabled = false;
            tool_thoat.Enabled = true;
            tool_save.Enabled = false;
            btn_ok.Enabled = true;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;
       }

        private void tool_lapbaocao_Click(object sender, EventArgs e)
        {
            if (txtTenbaocao.Text == "")
                MessageBox.Show("Xin nhập tên của báo cáo");
            else
            {
                if (cmbLoaibaocao.SelectedValue.ToString() == "3" || cmbLoaibaocao.SelectedValue.ToString() == "4")
                {
                    //luu du lieu vao mau bao cao  
                    info1.Mamaubaocao = Convert.ToInt32(txtMamaubaocao.Text);
                    info1.Tenbaocao = txtTenbaocao.Text;
                    info1.Loaibaocao.MaLoaiBaoCao = Convert.ToInt32(cmbLoaibaocao.SelectedValue);
                    info1.Nambaocao = Convert.ToInt32(cmbnambaocao.Text);
                    promaubaocao.Them(info1);
                    MessageBox.Show("Them mau bao cao thanh cong");
                    //luu chi tiet cua mau bao cao                
                    for (int i = 0; i < dataGridViewX2.RowCount - 1; i++)
                    {
                        DataGridViewRow row = dataGridViewX2.Rows[i];

                        info.Maubaocao.Mamaubaocao = Convert.ToInt32(txtMamaubaocao.Text);
                        info.Congtrinh.MaCongTrinh = Convert.ToInt32(row.Cells["macongtrinh1"].Value.ToString());
                        info.Soluong = Convert.ToInt32(row.Cells["soluong1"].Value.ToString());
                        info.Ghichu = row.Cells["ghichu1"].Value.ToString();
                        probaocao.Them(info);
                    }

                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Báo cáo Thống Kê Các Công Trình Viễn Thông không có loại báo cáo này!");
            }
        }

        private void tool_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            procongtrinh.ListCongTrinh_Doanhnghiep(dataGridViewX1, bindingNavigator1, cmbDoanhnghiep, cmbLoaicongtrinh);

        }

        private void txtSoluong_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < txtSoluong.Text.Length; i++)
                if (!char.IsNumber(txtSoluong.Text[i]))
                {
                    MessageBox.Show("Số lượng công trình phải là số !", "Chú ý", MessageBoxButtons.OK);
                    txtSoluong.Clear();
                    txtSoluong.Focus();
                    break;
                }
        }

        private void dataGridViewX2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewX2.Rows[e.RowIndex];

            if (row.Cells["macongtrinh1"].Value == null)
            {
                txtMacongtrinh.Text = "";
                txtTencongtrinh.Text = "";
                txtSoluong.Text = "";
                txtGhichu.Text = "";

                tool_them.Enabled = false;
                tool_xoa.Enabled = false;
                tool_lapbaocao.Enabled = false;
                tool_sua.Enabled = false;
                tool_xemlai.Enabled = false;
                tool_thoat.Enabled = true;
                tool_save.Enabled = false;
            }
            else
            {
                txtMacongtrinh.Text = row.Cells["macongtrinh1"].Value.ToString();
                txtTencongtrinh.Text = row.Cells["tencongtrinh1"].Value.ToString();
                txtGhichu.Text = row.Cells["ghichu1"].Value.ToString();
                txtSoluong.Text = row.Cells["soluong1"].Value.ToString();

                tool_them.Enabled = false;
                tool_xoa.Enabled = true;
                tool_lapbaocao.Enabled = true;
                tool_sua.Enabled = true;
                tool_xemlai.Enabled = false;
                tool_thoat.Enabled = true;
                tool_save.Enabled = false;
            }

            txtSoluong.ReadOnly = true;
            txtGhichu.ReadOnly = true;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewX1.Rows[e.RowIndex];

            txtMacongtrinh.Text = row.Cells["macongtrinh"].Value.ToString();
            txtTencongtrinh.Text = row.Cells["tencongtrinh"].Value.ToString();

            txtSoluong.ReadOnly = false;
            txtGhichu.ReadOnly = false;

            txtGhichu.Text = "";
            txtSoluong.Text = "";

            tool_them.Enabled = true;

            if (dataGridViewX2.RowCount == 1)
            {
                tool_lapbaocao.Enabled = false;
                tool_sua.Enabled = false;
                tool_xoa.Enabled = false;
            }
            else
            {
                tool_lapbaocao.Enabled = true;
                tool_sua.Enabled = true;
                tool_xoa.Enabled = true;
            }
            tool_xemlai.Enabled = false;
            tool_thoat.Enabled = true;
            tool_save.Enabled = false;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;
        }
    }
}