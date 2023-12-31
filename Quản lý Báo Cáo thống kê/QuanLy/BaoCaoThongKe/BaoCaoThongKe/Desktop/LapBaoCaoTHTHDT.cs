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
    public partial class LapBaoCaoTHTHDT : Office2007Form
    {
        DuAn_Ctrl produan = new DuAn_Ctrl();
        LoaiBaoCao_Ctrl proloaibaocao = new LoaiBaoCao_Ctrl();
        MauBaoCaoTHTHDT_InFo info1 = new MauBaoCaoTHTHDT_InFo();
        BaoCaoTHTHDT_InFo info = new BaoCaoTHTHDT_InFo();
        MauBaoCaoTHTHDT_Ctrl promaubaocao = new MauBaoCaoTHTHDT_Ctrl();
        BaoCaoTHTHDT_Ctrl probaocao = new BaoCaoTHTHDT_Ctrl();
        QL_DoanhNghiep_Ctrl prodoanhnghiep = new QL_DoanhNghiep_Ctrl();


        public LapBaoCaoTHTHDT()
        {
            InitializeComponent();
        }

        private void LapBaoCaoTHTHDT_Load(object sender, EventArgs e)
        {
            prodoanhnghiep.ComboBoxDN(cmbDoanhnghiep);
            proloaibaocao.Combobox_Loaibaocao(cmbLoaibaocao);
            produan.ListDuAn_Doanhnghiep(dataGridViewX1, bindingNavigator1, cmbDoanhnghiep);

            tool_them.Enabled = true;
            tool_xoa.Enabled = false;
            tool_lapbaocao.Enabled = false;
            tool_sua.Enabled = false;
            tool_xemlai.Visible = false;
            tool_thoat.Visible = true;
            tool_save.Enabled = false;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;

            txtMamaubaocao.Text = promaubaocao.LayMaMax().ToString();
        
        }

        private void cmbDoanhnghiep_SelectedIndexChanged(object sender, EventArgs e)
        {
            produan.ListDuAn_Doanhnghiep(dataGridViewX1, bindingNavigator1, cmbDoanhnghiep);
        }

        private void tool_them_Click(object sender, EventArgs e)
        {
            int tam = 0;
            dataGridViewX2.RowCount = dataGridViewX2.RowCount + 1;
            if (txtMaduan.Text == "")
            {
                MessageBox.Show("Xin chọn lại dự án cần đưa vào báo cáo!");
                dataGridViewX2.RowCount = dataGridViewX2.RowCount - 1;
            }
            else
            {
                for (int i = 0; i < dataGridViewX2.RowCount; i++)
                {
                    DataGridViewRow row = dataGridViewX2.Rows[i];
                    if (row.Cells["Maduan1"].Value == null)
                        break;
                    if (row.Cells["Tendoanhnghiep1"].Value.ToString() != cmbDoanhnghiep.Text)
                    {
                        MessageBox.Show("Bạn không thể đưa dự án của doanh nghiệp này vào được");
                        tam = 1;
                        dataGridViewX2.RowCount = dataGridViewX2.RowCount - 1;
                        break;
                    }
                    else
                    {
                        txttam.Text = row.Cells["Maduan1"].Value.ToString();
                        if (txtMaduan.Text == txttam.Text)
                        {
                            dataGridViewX2.RowCount = dataGridViewX2.RowCount - 1;
                            MessageBox.Show("Dự án này đã được bạn đưa vào báo cáo rồi!");
                            row.Cells["Maduan1"].Value = null;
                            row.Cells["Tenduan1"].Value = "";
                            row.Cells["Nangluc1"].Value = "";
                            row.Cells["Mabaocao"].Value = "";
                            row.Cells["Tendoanhnghiep1"].Value = "";
                            row.Cells["Loaiduan1"].Value = "";
                            row.Cells["Diadiem1"].Value = "";
                            row.Cells["Tongvon1"].Value = "";
                            row.Cells["thoigian1"].Value = "";

                            txtVondautu.Text = row.Cells["Vondautu1"].Value.ToString();
                            txtLuykevon.Text = row.Cells["Luykevon1"].Value.ToString();

                            row.Cells["Vondautu1"].Value = "";
                            row.Cells["Luykevon1"].Value = "";
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
                        if (row1.Cells["Maduan1"].Value == null)
                        {
                            if (probaocao.CheckInput(txtVondautu, txtLuykevon))
                            {
                                //row1.Cells["Mabaocao"].Value=txtMabaocao.Text;
                                row1.Cells["Maduan1"].Value = txtMaduan.Text;
                                row1.Cells["Loaiduan1"].Value = cmbLoaiduan.Text;
                                row1.Cells["Tenduan1"].Value = txtTenduan.Text;
                                row1.Cells["Tendoanhnghiep1"].Value = cmbDoanhnghiep.Text;
                                row1.Cells["Diadiem1"].Value = txtDiadiem.Text;
                                row1.Cells["Nangluc1"].Value = txtNanglucthietke.Text;
                                row1.Cells["Tongvon1"].Value = txtTongvon.Text;
                                row1.Cells["Vondautu1"].Value = txtVondautu.Text;
                                row1.Cells["Luykevon1"].Value = txtLuykevon.Text;
                                row1.Cells["Ghichu"].Value = txtGhichu.Text;
                                row1.Cells["thoigian1"].Value = txtThoigian.Text;
                                break;
                            }
                            else
                                dataGridViewX2.RowCount = dataGridViewX2.RowCount - 1;
                        }
                    }
                }

                txtVondautu.ReadOnly = false;
                txtLuykevon.ReadOnly = false;
                txtGhichu.ReadOnly = false;

                txtGhichu.Text = "";
                txtLuykevon.Text = "";
                txtVondautu.Text = "";

                tool_them.Enabled = true;
                tool_xoa.Enabled = false;
                tool_lapbaocao.Enabled = true;
                tool_sua.Enabled = false;
                tool_xemlai.Visible = false;
                tool_thoat.Visible = true;
                tool_save.Enabled = false;

                dataGridViewX1.Enabled = true;
                dataGridViewX2.Enabled = true;
            }     
        }

        private void tool_xoa_Click(object sender, EventArgs e)
        {
            int tam = 0;
            if (txtMaduan.Text == "")
                ToString();
            else
            {
                for (int i = 0; i < dataGridViewX2.RowCount; i++)
                {
                    DataGridViewRow row = dataGridViewX2.Rows[i];

                    txttam.Text = row.Cells["Maduan1"].Value.ToString();
                    if (txtMaduan.Text == txttam.Text)
                    {
                        if (MessageBox.Show("Bạn có chắc chắn xóa dự án\" " + row.Cells["Tenduan1"].Value.ToString() + " \" này ra khỏi báo cáo không ?", "chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            row.Cells["Maduan1"].Value = null;
                            row.Cells["Tenduan1"].Value = "";
                            row.Cells["Loaiduan1"].Value = "";
                            row.Cells["Diadiem1"].Value = "";
                            row.Cells["thoigian1"].Value = "";
                            row.Cells["Nangluc1"].Value = "";
                            row.Cells["Tongvon1"].Value = "";
                            row.Cells["Vondautu1"].Value = "";
                            row.Cells["Luykevon1"].Value = "";
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
                        if (row1.Cells["Maduan1"].Value != null)
                        {
                            row.Cells["Maduan1"].Value = row1.Cells["Maduan1"].Value.ToString();
                            row.Cells["Tenduan1"].Value = row1.Cells["Tenduan1"].Value.ToString();
                            row.Cells["Diadiem1"].Value = row1.Cells["Diadiem1"].Value.ToString();
                            row.Cells["thoigian1"].Value = row1.Cells["thoigian1"].Value.ToString();
                            row.Cells["Loaiduan1"].Value = row1.Cells["Loaiduan1"].Value.ToString();
                            row.Cells["Nangluc1"].Value = row1.Cells["Nangluc1"].Value.ToString();
                            row.Cells["Tongvon1"].Value = row1.Cells["Tongvon1"].Value.ToString();
                            row.Cells["Luykevon1"].Value = row1.Cells["luykevon1"].Value.ToString();
                            row.Cells["Vondautu1"].Value = row1.Cells["Vondautu1"].Value.ToString();
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

        private void tool_sua_Click(object sender, EventArgs e)
        {
            txtVondautu.ReadOnly = false;
            txtLuykevon.ReadOnly = false;
            txtGhichu.ReadOnly = false;

            tool_them.Enabled = false;
            tool_xoa.Enabled = false;
            tool_lapbaocao.Enabled = false;
            tool_sua.Enabled = false;
            tool_xemlai.Visible = true;
            tool_thoat.Visible = false;
            tool_save.Enabled = true;

            dataGridViewX1.Enabled = false;
            dataGridViewX2.Enabled = false;
        }

        private void tool_save_Click(object sender, EventArgs e)
        {
            if (txtMaduan.Text == "")
                ToString();
            else
                for (int i = 0; i < dataGridViewX2.RowCount; i++)
                {
                    DataGridViewRow row = dataGridViewX2.Rows[i];
                    txttam.Text = row.Cells["Maduan1"].Value.ToString();
                    if (txtMaduan.Text == txttam.Text)
                    {
                        row.Cells["Vondautu1"].Value = txtVondautu.Text;
                        row.Cells["Luykevon1"].Value = txtLuykevon.Text;
                        row.Cells["Ghichu"].Value = txtGhichu.Text;
                        break;
                    }
                }

            tool_them.Enabled = true;
            tool_xoa.Enabled = false;
            tool_lapbaocao.Enabled = false;
            tool_sua.Enabled = false;
            tool_xemlai.Visible = false;
            tool_thoat.Visible = true;
            tool_save.Enabled = false;

            txtVondautu.ReadOnly = true;
            txtLuykevon.ReadOnly = true;
            txtGhichu.ReadOnly = true;

            dataGridViewX2.Enabled = true;
            dataGridViewX1.Enabled = true;
        }

        private void tool_xemlai_Click(object sender, EventArgs e)
        {
            txtVondautu.ReadOnly = true;
            txtLuykevon.ReadOnly = true;
            txtGhichu.ReadOnly = true;

            tool_them.Enabled = true;
            tool_xoa.Enabled = false;
            tool_lapbaocao.Enabled = false;
            tool_sua.Enabled = false;
            tool_xemlai.Visible = false;
            tool_thoat.Visible = true;
            tool_save.Enabled = false;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;
        }

        private void tool_lapbaocao_Click(object sender, EventArgs e)
        {
            if (txtTenbaocao.Text == "")
                MessageBox.Show("Xin nhập tên của báo cáo !", "Chú ý");
            else
            {
                if (cmbLoaibaocao.SelectedValue.ToString() == "2" || cmbLoaibaocao.SelectedValue.ToString() == "4")
                {
                    //luu du lieu vao mau bao cao  
                    info1.Mamaubaocao = Convert.ToInt32(txtMamaubaocao.Text);
                    info1.Tenbaocao = txtTenbaocao.Text;
                    info1.Loaibaocao.MaLoaiBaoCao = Convert.ToInt32(cmbLoaibaocao.SelectedValue);
                    info1.Nambaocao = Convert.ToInt32(cmbnambaocao.Text);
                    info1.Quibaocao = Convert.ToInt32(cmbQuibaocao.Text);
                    promaubaocao.Them(info1);
                    MessageBox.Show("Thêm mẫu báo cáo này thành công !");
                    //luu chi tiet cua mau bao cao                
                    for (int i = 0; i < dataGridViewX2.RowCount - 1; i++)
                    {
                        DataGridViewRow row = dataGridViewX2.Rows[i];

                        info.Maubaocao.Mamaubaocao = Convert.ToInt32(txtMamaubaocao.Text);
                        info.Duan.MaDuAn = Convert.ToInt32(row.Cells["Maduan1"].Value.ToString());
                        info.Luykevon = Convert.ToInt32(row.Cells["Luykevon1"].Value.ToString());
                        info.Vondautu = Convert.ToInt32(row.Cells["Vondautu1"].Value.ToString());
                        info.Ghichu = row.Cells["Ghichu"].Value.ToString();
                        probaocao.Them(info);
                    }

                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Báo cáo Tình Hình Thực Hiện Đầu Tư không có loại báo cáo này");
            }
        }

        private void tool_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewX1.Rows[e.RowIndex];

            txtMaduan.Text = row.Cells["Maduan"].Value.ToString();
            txtTenduan.Text = row.Cells["Tenduan"].Value.ToString();
            txtDiadiem.Text = row.Cells["Diadiem"].Value.ToString();
            txtThoigian.Text = row.Cells["thoigian"].Value.ToString();
            cmbLoaiduan.Text = row.Cells["Loaiduan"].Value.ToString();
            txtNanglucthietke.Text = row.Cells["Nangluc"].Value.ToString();
            txtTongvon.Text = row.Cells["Tongvon"].Value.ToString();

            txtGhichu.ReadOnly = false;
            txtLuykevon.ReadOnly = false;
            txtVondautu.ReadOnly = false;

            txtGhichu.Text = "";
            txtLuykevon.Text = "";
            txtVondautu.Text = "";

            tool_them.Enabled = true;
            //tool_xoa.Enabled = false;

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

            //tool_sua.Enabled = false;
            tool_xemlai.Visible = false;
            tool_thoat.Visible = true;
            tool_save.Enabled = false;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;
        }

        private void dataGridViewX2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row1 = dataGridViewX2.Rows[e.RowIndex];
            if (row1.Cells["Maduan1"].Value == null)
            {
                txtDiadiem.Text = "";
                txtGhichu.Text = "";
                txtTenduan.Text = "";
                txtThoigian.Text = "";
                txtMaduan.Text = "";
                txtNanglucthietke.Text = "";
                txtTongvon.Text = "";
                txtVondautu.Text = "";
                txtGhichu.Text = "";
                txtLuykevon.Text = "";
                cmbLoaiduan.Text = "";

                tool_them.Enabled = false;
                tool_xoa.Enabled = false;
                tool_lapbaocao.Enabled = false;
                tool_sua.Enabled = false;
                tool_xemlai.Visible = false;
                tool_thoat.Visible = true;
                tool_save.Enabled = false;
            }
            else
            {
                txtMaduan.Text = row1.Cells["Maduan1"].Value.ToString();
                cmbLoaiduan.Text = row1.Cells["Loaiduan1"].Value.ToString();
                txtTenduan.Text = row1.Cells["Tenduan1"].Value.ToString();
                txtDiadiem.Text = row1.Cells["Diadiem1"].Value.ToString();
                txtThoigian.Text = row1.Cells["thoigian1"].Value.ToString();
                txtNanglucthietke.Text = row1.Cells["Nangluc1"].Value.ToString();
                txtTongvon.Text = row1.Cells["Tongvon1"].Value.ToString();
                txtVondautu.Text = row1.Cells["Vondautu1"].Value.ToString();
                txtLuykevon.Text = row1.Cells["Luykevon1"].Value.ToString();
                txtGhichu.Text = row1.Cells["Ghichu"].Value.ToString();

                tool_them.Enabled = false;
                tool_xoa.Enabled = true;
                tool_lapbaocao.Enabled = true;
                tool_sua.Enabled = true;
                tool_xemlai.Visible = false;
                tool_thoat.Visible = true;
                tool_save.Enabled = false;
            }

            txtVondautu.ReadOnly = true;
            txtLuykevon.ReadOnly = true;
            txtGhichu.ReadOnly = true;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;
        }

        private void txtLuykevon_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < txtLuykevon.Text.Length; i++)
                if (!char.IsNumber(txtLuykevon.Text[i]))
                {
                    MessageBox.Show("Lũy kế vốn phải là số !", "Chú ý", MessageBoxButtons.OK);
                    txtLuykevon.Clear();
                    txtLuykevon.Focus();
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

        private void cmbLoaibaocao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaibaocao.SelectedValue.ToString() == "2")
                cmbQuibaocao.Enabled = true;
            else
                cmbQuibaocao.Enabled = false;
        }

       
    }
}