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
    public partial class LapBaoCaoTHTHCLDV : Office2007Form
    {
        LoaiBaoCao_Ctrl proloaibaocao = new LoaiBaoCao_Ctrl();
        TieuChuanChatLuong_Ctrl protieuchuan = new TieuChuanChatLuong_Ctrl();
        QL_DoanhNghiep_Ctrl prodoanhnghiep = new QL_DoanhNghiep_Ctrl();
        DichVuBuuChinhVT_Ctrl prodichvu = new DichVuBuuChinhVT_Ctrl();
        MauBaoCaoTHTHCLDV_InFo info1 = new MauBaoCaoTHTHCLDV_InFo();
        BaoCaoTHTHCLDV_InFo info = new BaoCaoTHTHCLDV_InFo();
        MauBaoCaoTHTHCLDV_Ctrl promaubaocao = new MauBaoCaoTHTHCLDV_Ctrl();
        BaoCaoTHTHCLDV_Ctrl probaocao = new BaoCaoTHTHCLDV_Ctrl();

        public LapBaoCaoTHTHCLDV()
        {
            InitializeComponent();
        }

        private void LapBaoCaoTHTHCLDV_Load(object sender, EventArgs e)
        {
            proloaibaocao.Combobox_Loaibaocao(cmbLoaibaocao);
            protieuchuan.Load_ComboBox_TieuchuanCL(cmbTieuchuan);
            prodoanhnghiep.ComboBoxDN(cmbDoanhnghiep);
            prodichvu.ListDichVu_Doanhnghiep(dataGridViewX1, bindingNavigator1, cmbDoanhnghiep);

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
            if (txtMadichvu.Text == "")
            {
                MessageBox.Show("Xin chọn lại dịch vụ cần đưa vào báo cáo !", "Thông Báo");
                dataGridViewX2.RowCount = dataGridViewX2.RowCount - 1;
            }
            else
            {
                for (int i = 0; i < dataGridViewX2.RowCount; i++)
                {
                    DataGridViewRow row = dataGridViewX2.Rows[i];
                    if (row.Cells["madichvu1"].Value == null)
                        break;
                    if (row.Cells["tendoanhnghiep1"].Value.ToString() != cmbDoanhnghiep.Text)
                    {
                        MessageBox.Show("Bạn không thể đưa dịch vụ của doanh nghiệp này vào được !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tam = 1;
                        dataGridViewX2.RowCount = dataGridViewX2.RowCount - 1;
                        break;
                    }
                    else
                    {
                        //txttam.Text = row.Cells["madichvu1"].Value.ToString();
                        if (txtMadichvu.Text == txttam.Text)
                        {
                            dataGridViewX2.RowCount = dataGridViewX2.RowCount - 1;
                            MessageBox.Show("Dịch vụ này đã được bạn đưa vào báo cáo rồi !", "Thông Báo");
                            row.Cells["madichvu1"].Value = null;

                            txtVanban.Text = row.Cells["vanbancongbo"].Value.ToString();
                            txtTendoanhnghiep.Text = row.Cells["doanhnghiep"].Value.ToString();

                            //row.Cells["tendichvu1"].Value = "";                            
                            //row.Cells["tieuchuanchatluong"].Value = "";
                            //row.Cells["mabaocao"].Value = "";
                            //row.Cells["thuocdanhmuc"].Value = "";
                            //row.Cells["vanbancongbo"].Value = "";
                            //row.Cells["doanhnghiep"].Value = "";
                            //row.Cells["ghichu"].Value = "";

                            break;
                        }
                    }
                }
                if (tam == 0)
                {
                    for (int j = 0; j < dataGridViewX2.RowCount; j++)
                    {
                        DataGridViewRow row1 = dataGridViewX2.Rows[j];
                        if (row1.Cells["madichvu1"].Value == null)
                        {
                            if (probaocao.CheckInput(txtVanban, txtTendoanhnghiep))
                            {
                                txtMatieuchuan.Text = cmbTieuchuan.SelectedValue.ToString();
                                //row1.Cells["Mabaocao"].Value=txtMabaocao.Text;
                                row1.Cells["madichvu1"].Value = txtMadichvu.Text;
                                row1.Cells["tendichvu1"].Value = txtTendichvu.Text;
                                row1.Cells["matieuchuan"].Value = txtMatieuchuan.Text;
                                row1.Cells["tieuchuanchatluong"].Value = cmbTieuchuan.Text;
                                row1.Cells["tendoanhnghiep1"].Value = cmbDoanhnghiep.Text;
                                row1.Cells["vanbancongbo"].Value = txtVanban.Text;
                                row1.Cells["doanhnghiep"].Value = txtTendoanhnghiep.Text;

                                if (chkCo.Checked == true)
                                    row1.Cells["thuocdanhmuc"].Value = "Có";
                                else
                                    row1.Cells["thuocdanhmuc"].Value = "Không";
                                row1.Cells["ghichu"].Value = txtGhichu.Text;
                                break;
                            }
                            else
                                dataGridViewX2.RowCount = dataGridViewX2.RowCount - 1;
                        }
                    }
                }

                txtVanban.ReadOnly = false;
                txtTendichvu.ReadOnly = true;
                cmbTieuchuan.Enabled = true;
                txtGhichu.ReadOnly = false;

                chkCo.Enabled = true;
                chkKhong.Enabled = true;

                txtVanban.Text = "";
                txtTendoanhnghiep.Text = "";
                txtGhichu.Text = "";
                txtTendoanhnghiep.Text = "";

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
            if (txtMadichvu.Text == "")
                ToString();
            else
            {
                for (int i = 0; i < dataGridViewX2.RowCount; i++)
                {
                    DataGridViewRow row = dataGridViewX2.Rows[i];

                    txttam.Text = row.Cells["madichvu1"].Value.ToString();
                    if (txtMadichvu.Text == txttam.Text)
                    {
                        if (MessageBox.Show("Bạn có chắc chắn xóa dịch vụ\" " + row.Cells["tendichvu1"].Value.ToString() + " \" này ra khỏi báo cáo không ?", "chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            row.Cells["madichvu1"].Value = null;
                            row.Cells["tendichvu1"].Value = "";
                            row.Cells["tieuchuanchatluong"].Value = "";
                            row.Cells["matieuchuan"].Value = "";
                            row.Cells["thuocdanhmuc"].Value = "";
                            row.Cells["vanbancongbo"].Value = "";
                            row.Cells["doanhnghiep"].Value = "";
                            row.Cells["ghichu"].Value = "";
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
                        if (row1.Cells["madichvu1"].Value != null)
                        {
                            row.Cells["madichvu1"].Value = row1.Cells["madichvu1"].Value.ToString();
                            row.Cells["tendichvu1"].Value = row1.Cells["tendichvu1"].Value.ToString();
                            row.Cells["tieuchuanchatluong"].Value = row1.Cells["tieuchuanchatluong"].Value.ToString();
                            row.Cells["matieuchuan"].Value = row1.Cells["matieuchuan"].Value.ToString();
                            row.Cells["thuocdanhmuc"].Value = row1.Cells["thuocdanhmuc"].Value.ToString();
                            row.Cells["vanbancongbo"].Value = row1.Cells["vanbancongbo"].Value.ToString();
                            row.Cells["doanhnghiep"].Value = row1.Cells["doanhnghiep"].Value.ToString();
                            row.Cells["ghichu"].Value = row1.Cells["ghichu"].Value.ToString();

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

            if (dataGridViewX2.RowCount == 1)
                tool_lapbaocao.Enabled = false;
            else
                tool_lapbaocao.Enabled = true;
        }

        private void tool_sua_Click(object sender, EventArgs e)
        {
            txtVanban.ReadOnly = false;
            txtTendoanhnghiep.ReadOnly = false;
            txtGhichu.ReadOnly = false;
            cmbTieuchuan.Enabled = true;

            chkCo.Enabled = true;
            chkKhong.Enabled = true;

            tool_them.Enabled = false;
            tool_xoa.Enabled = false;
            tool_lapbaocao.Enabled = false;
            tool_sua.Enabled = false;
            tool_xemlai.Enabled = true;
            tool_thoat.Enabled = false;
            tool_save.Enabled = true;

            dataGridViewX1.Enabled = false;
            dataGridViewX2.Enabled = false;
        }

        private void tool_save_Click(object sender, EventArgs e)
        {
            if (txtMadichvu.Text == "")
                ToString();
            else
                for (int i = 0; i < dataGridViewX2.RowCount; i++)
                {
                    DataGridViewRow row = dataGridViewX2.Rows[i];
                    txttam.Text = row.Cells["madichvu1"].Value.ToString();
                    if (txtMadichvu.Text == txttam.Text)
                    {
                        row.Cells["vanbancongbo"].Value = txtVanban.Text;
                        row.Cells["doanhnghiep"].Value = txtTendoanhnghiep.Text;
                        row.Cells["ghichu"].Value = txtGhichu.Text;
                        row.Cells["madichvu1"].Value = txtMatieuchuan.Text;
                        row.Cells["tieuchuanchatluong"].Value = cmbTieuchuan.Text;

                        if (chkCo.Checked == true)
                            row.Cells["thuocdanhmuc"].Value = "Có";
                        else
                            row.Cells["thuocdanhmuc"].Value = "Không";
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

            txtVanban.ReadOnly = true;
            txtTendoanhnghiep.ReadOnly = true;
            txtGhichu.ReadOnly = true;
            cmbTieuchuan.Enabled = false;

            chkCo.Enabled = false;
            chkKhong.Enabled = false;

            dataGridViewX2.Enabled = true;
            dataGridViewX1.Enabled = true;
        }

        private void tool_xemlai_Click(object sender, EventArgs e)
        {
            txtVanban.ReadOnly = true;
            txtTendoanhnghiep.ReadOnly = true;
            txtGhichu.ReadOnly = true;
            cmbTieuchuan.Enabled = false;

            chkCo.Enabled = false;
            chkKhong.Enabled = false;

            tool_them.Enabled = true;
            tool_xoa.Enabled = false;
            tool_lapbaocao.Enabled = false;
            tool_sua.Enabled = false;
            tool_xemlai.Enabled = false;
            tool_thoat.Enabled = true;
            tool_save.Enabled = false;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;
        }

        private void tool_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    info1.Mamaubaocao = Convert.ToInt32(txtMamaubaocao.Text);
                    info1.Tenbaocao = txtTenbaocao.Text;
                    info1.Loaibaocao.MaLoaiBaoCao = Convert.ToInt32(cmbLoaibaocao.SelectedValue);
                    info1.Nambaocao = Convert.ToInt32(cmbnambaocao.Text);
                    promaubaocao.Them(info1);
                    MessageBox.Show("Thêm Báo Cáo thành công !");
                    //luu chi tiet cua mau bao cao                
                    for (int i = 0; i < dataGridViewX2.RowCount - 1; i++)
                    {
                        DataGridViewRow row = dataGridViewX2.Rows[i];

                        info.Maubaocao.Mamaubaocao = Convert.ToInt32(txtMamaubaocao.Text);
                        info.Dichvubuuchinh.MaDichVuBuuChinhVT = Convert.ToInt32(row.Cells["madichvu1"].Value.ToString());
                        info.Tieuchuanchatluong.MaTieuChuanCL = Convert.ToInt32(row.Cells["matieuchuan"].Value.ToString());
                        info.Thuocdanhmucbuuchinh = row.Cells["thuocdanhmuc"].Value.ToString();
                        info.Doanhnghiepcongbo = row.Cells["doanhnghiep"].Value.ToString();
                        info.Vanbancongbo = row.Cells["vanbancongbo"].Value.ToString();
                        info.Ghichu = row.Cells["Ghichu"].Value.ToString();
                        probaocao.Them(info);
                    }
                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Báo cáo Tình Hình Thực Hiện Chất Lượng Dịch Vụ không có loại báo cáo này");
            }
        }

        private void cmbDoanhnghiep_SelectedIndexChanged(object sender, EventArgs e)
        {
            prodichvu.ListDichVu_Doanhnghiep(dataGridViewX1, bindingNavigator1, cmbDoanhnghiep);

        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewX1.Rows[e.RowIndex];

            txtMadichvu.Text = row.Cells["madichvu"].Value.ToString();
            txtTendichvu.Text = row.Cells["Tendichvu"].Value.ToString();

            txtTendoanhnghiep.ReadOnly = false;
            txtVanban.ReadOnly = false;
            cmbTieuchuan.Enabled = true;
            txtGhichu.ReadOnly = false;
            chkCo.Checked = true;
            chkKhong.Checked = false;

            txtVanban.Text = "";
            txtTendoanhnghiep.Text = "";
            txtGhichu.Text = "";

            tool_them.Enabled = true;
            if (dataGridViewX2.RowCount == 1)
            {
                tool_sua.Enabled = false;
                tool_xoa.Enabled = false;
                tool_lapbaocao.Enabled = false;
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

        private void dataGridViewX2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row1 = dataGridViewX2.Rows[e.RowIndex];
            if (row1.Cells["madichvu1"].Value == null)
            {
                txtMadichvu.Text = "";
                txtTendichvu.Text = "";
                txtTendoanhnghiep.Text = "";
                txtVanban.Text = "";
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
                txtMatieuchuan.Text = row1.Cells["matieuchuan"].Value.ToString();
                txtMadichvu.Text = row1.Cells["madichvu1"].Value.ToString();
                txtTendichvu.Text = row1.Cells["tendichvu1"].Value.ToString();
                txtTendoanhnghiep.Text = row1.Cells["doanhnghiep"].Value.ToString();
                txtVanban.Text = row1.Cells["vanbancongbo"].Value.ToString();
                txtGhichu.Text = row1.Cells["ghichu"].Value.ToString();
                if (row1.Cells["thuocdanhmuc"].Value.ToString() == "Có")
                    //radioCo.Checked = true;
                    chkCo.Checked = true;
                else
                    //radioKhong.Checked = true;
                    chkKhong.Checked = true;

                tool_them.Enabled = false;
                tool_xoa.Enabled = true;
                tool_lapbaocao.Enabled = true;
                tool_sua.Enabled = true;
                tool_xemlai.Enabled = false;
                tool_thoat.Enabled = true;
                tool_save.Enabled = false;
            }
            txtTendoanhnghiep.ReadOnly = true;
            txtVanban.ReadOnly = true;
            cmbTieuchuan.Enabled = false;
            txtGhichu.ReadOnly = true;

            chkKhong.Enabled = false;
            chkCo.Enabled = false;
            chkKhong.Enabled = false;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;
        }

        private void cmbTieuchuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMatieuchuan.Text = cmbTieuchuan.SelectedValue.ToString();

        }

    }
}