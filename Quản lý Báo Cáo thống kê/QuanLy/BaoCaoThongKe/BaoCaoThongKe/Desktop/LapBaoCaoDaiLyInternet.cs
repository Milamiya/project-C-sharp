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
using BaoCaoThongKe.DataLayer;

namespace BaoCaoThongKe.Desktop
{
    public partial class LapBaoCaoDaiLyInternet : Office2007Form
    {
        QL_DoanhNghiep_Ctrl prodoanhnghiep = new QL_DoanhNghiep_Ctrl();
        Huyen_Thi_Ctrl prohuyen = new Huyen_Thi_Ctrl();
        NhomThueBao_Ctrl prothuebao = new NhomThueBao_Ctrl();
        LoaiBaoCao_Ctrl proloaibaocaoInt = new LoaiBaoCao_Ctrl();
        DaiLyInternet_Ctrl prodailyInt = new DaiLyInternet_Ctrl();
        MauBaoCaoDaiLyInternet_InFo info1 = new MauBaoCaoDaiLyInternet_InFo();
        BaoCaoDaiLyInternet_InFo info = new BaoCaoDaiLyInternet_InFo();
        MauBaoCaoDaiLyInternet_Ctrl promaubaocaoInt = new MauBaoCaoDaiLyInternet_Ctrl();
        BaoCaoDaiLyInternet_Ctrl probaocaoInt = new BaoCaoDaiLyInternet_Ctrl();

        public LapBaoCaoDaiLyInternet()
        {
            InitializeComponent();
        }

        private void LapBaoCaoDaiLyInternet_Load(object sender, EventArgs e)
        {
            cmbHuyen.Enabled = false;
            prodoanhnghiep.ComboBoxDN(cmbDoanhnghiep);
            prohuyen.ComboBoxHuyen(cmbHuyen);
            proloaibaocaoInt.Combobox_Loaibaocao(cmbLoaibaocao);
            prothuebao.ComboBoxThueBao(cmbThuebao);

            if (checkbox_huyen.Checked)
            {
                prodailyInt.ListInt_Huyen(dataGridViewX1, bindingNavigator1, cmbHuyen, cmbDoanhnghiep);
            }
            else
                prodailyInt.ListInt_Doanhnghiep(dataGridViewX1, bindingNavigator1, cmbDoanhnghiep);

            tool_them.Enabled = true;
            tool_xoa.Enabled = false;
            tool_lapbaocao.Enabled = false;
            tool_sua.Enabled = false;
            tool_xemlai.Visible = false;
            tool_thoat.Visible = true;
            tool_save.Enabled = false;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;

            txtMamaubaocao.Text = promaubaocaoInt.LayMaMax().ToString();
        }

        private void tool_them_Click(object sender, EventArgs e)
        {
            int tam = 0;
            txtMathuebao.Text = cmbThuebao.SelectedValue.ToString();
            dataGridViewX2.RowCount = dataGridViewX2.RowCount + 1;
            if (txtMaDaiLy.Text == "")
            {
                MessageBox.Show("Xin chọn lại đại lý cần đưa vào báo cáo! ", "Chú ý");
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
                        MessageBox.Show("Không thể đưa đại lý của doanh nghiệp này vào báo cáo !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tam = 1;
                        dataGridViewX2.RowCount = dataGridViewX2.RowCount - 1;
                        break;
                    }
                    else
                    {
                        //txttam.Text = row.Cells["Madaily1"].Value.ToString();
                        if (txtMaDaiLy.Text == txttam.Text)
                        {
                            dataGridViewX2.RowCount = dataGridViewX2.RowCount - 1;
                            MessageBox.Show("Đại lý này  đã được bạn đưa vào báo cáo rồi!");
                            row.Cells["Madaily1"].Value = null;
                            row.Cells["Tendaily1"].Value = "";
                            row.Cells["Xa1"].Value = "";
                            row.Cells["Huyen1"].Value = "";
                            row.Cells["Mabaocao"].Value = "";
                            row.Cells["DoanhNghiep"].Value = "";

                            txtDienThoai.Text = row.Cells["Dienthoai"].Value.ToString();
                            row.Cells["thuebao"].Value = "";
                            row.Cells["Dienthoai"].Value = "";
                            row.Cells["Ghichu"].Value = "";
                            row.Cells["mathuebao"].Value = "";
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
                            if (probaocaoInt.CheckInput(txtDienThoai))
                            {

                                row1.Cells["Madaily1"].Value = txtMaDaiLy.Text;
                                row1.Cells["Xa1"].Value = cmbXa.Text;
                                row1.Cells["Tendaily1"].Value = txtTenDaily.Text;
                                row1.Cells["Huyen1"].Value = cmbHuyen.SelectedValue.ToString();
                                row1.Cells["sohieu1"].Value = txtsohieu.Text;
                                row1.Cells["Diachi1"].Value = txtDiaChi.Text;
                                row1.Cells["DoanhNghiep"].Value = cmbDoanhnghiep.Text;
                                row1.Cells["thuebao"].Value = cmbThuebao.Text;
                                row1.Cells["Dienthoai"].Value = txtDienThoai.Text;
                                row1.Cells["Ghichu"].Value = txtGhichu.Text;
                                row1.Cells["mathuebao"].Value = txtMathuebao.Text;
                                break;
                            }
                            else
                                dataGridViewX2.RowCount = dataGridViewX2.RowCount - 1;
                        }
                    }
                }

                cmbThuebao.Enabled = false;
                txtGhichu.ReadOnly = false;
                txtDienThoai.ReadOnly = false;

                txtGhichu.Text = "";
                txtDienThoai.Text = "";

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
                            row.Cells["sohieu1"].Value = "";
                            row.Cells["Diachi1"].Value = "";
                            row.Cells["thuebao"].Value = "";
                            row.Cells["Dienthoai"].Value = "";
                            row.Cells["Ghichu"].Value = "";
                            row.Cells["mathuebao"].Value = "";
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
                            row.Cells["sohieu1"].Value = row1.Cells["sohieu1"].Value.ToString();
                            row.Cells["Diachi1"].Value = row1.Cells["Diachi1"].Value.ToString();
                            row.Cells["Xa1"].Value = row1.Cells["Xa1"].Value.ToString();
                            row.Cells["thuebao"].Value = row1.Cells["thuebao"].Value.ToString();
                            row.Cells["Dienthoai"].Value = row1.Cells["Dienthoai"].Value.ToString();
                            row.Cells["Ghichu"].Value = row1.Cells["Ghichu"].Value.ToString();
                            row.Cells["mathuebao"].Value = row1.Cells["mathuebao"].Value.ToString();

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
                    tool_xoa.Enabled = false;
                    tool_lapbaocao.Enabled = false;
                    tool_sua.Enabled = false;
                }
                else
                {
                    tool_xoa.Enabled = true;
                    tool_lapbaocao.Enabled = true;
                    tool_sua.Enabled = true;
                }
            }
        }

        private void tool_sua_Click(object sender, EventArgs e)
        {
            cmbThuebao.Enabled = true;
            txtGhichu.ReadOnly = false;
            txtDienThoai.ReadOnly = false;

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
            if (txtMaDaiLy.Text == "")
                ToString();
            else
                for (int i = 0; i < dataGridViewX2.RowCount; i++)
                {
                    DataGridViewRow row = dataGridViewX2.Rows[i];
                    txttam.Text = row.Cells["Madaily1"].Value.ToString();
                    if (txtMaDaiLy.Text == txttam.Text)
                    {
                        row.Cells["thuebao"].Value = cmbThuebao.SelectedValue.ToString();
                        row.Cells["Dienthoai"].Value = txtDienThoai.Text;
                        row.Cells["Ghichu"].Value = txtGhichu.Text;
                        break;
                    }
                }

            cmbThuebao.Enabled = false;
            txtGhichu.ReadOnly = true;
            txtDienThoai.ReadOnly = true;

            tool_them.Enabled = true;
            tool_xoa.Enabled = false;
            tool_lapbaocao.Enabled = true;
            tool_sua.Enabled = false;
            tool_xemlai.Visible = false;
            tool_thoat.Visible = true;
            tool_save.Enabled = false;

            dataGridViewX2.Enabled = true;
            dataGridViewX1.Enabled = true;
        }

        private void tool_xemlai_Click(object sender, EventArgs e)
        {
            cmbThuebao.Enabled = false;
            txtGhichu.ReadOnly = true;
            txtDienThoai.ReadOnly = true;


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

        private void tool_lapbaocao_Click(object sender, EventArgs e)
        {
            if (txtTenbaocao.Text == "")
                MessageBox.Show("Xin nhập tên của báo cáo !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (cmbLoaibaocao.SelectedValue.ToString() == "3" || cmbLoaibaocao.SelectedValue.ToString() == "4")
                {
                    //luu du lieu vao mau bao cao
                    info1.MaMauBaoCaoDaiLyInt = Convert.ToInt32(txtMamaubaocao.Text);
                    info1.TenbaocaoInt = txtTenbaocao.Text;
                    info1.LoaibaocaoInt.MaLoaiBaoCao = Convert.ToInt32(cmbLoaibaocao.SelectedValue);
                    info1.NambaocaoInt = Convert.ToInt32(cmbnambaocao.Text);
                    promaubaocaoInt.Them_Int(info1);

                    MessageBox.Show("Thêm mẫu báo cáo thành công !", "Thông báo");
                    //luu chi tiet cua mau bao cao                
                    for (int i = 0; i < dataGridViewX2.RowCount - 1; i++)
                    {

                        DataGridViewRow row = dataGridViewX2.Rows[i];
                        //info.MabaocaoInt.tiép
                        info.MaubaocaoInt.MaMauBaoCaoDaiLyInt = Convert.ToInt32(txtMamaubaocao.Text);
                        info.DaiLyInt.MaDaiLyInt = Convert.ToInt32(row.Cells["Madaily1"].Value.ToString());
                        info.ThueBao.MaThueBao = Convert.ToInt32(row.Cells["mathuebao"].Value.ToString());
                        info.DienThoaiInt = row.Cells["Dienthoai"].Value.ToString();
                        info.GhichuInt = row.Cells["Ghichu"].Value.ToString();
                        probaocaoInt.Them_Int(info);
                    }

                    this.DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Báo cáo đại lý Internet không có loại báo cáo này");
            }
        }

        private void tool_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewX1.Rows[e.RowIndex];

            txtMaDaiLy.Text = row.Cells["Madaily"].Value.ToString();
            txtTenDaily.Text = row.Cells["Tendaily"].Value.ToString();
            txtDiaChi.Text = row.Cells["Diachi"].Value.ToString();
            txtsohieu.Text = row.Cells["sohieu"].Value.ToString();
            cmbDoanhnghiep.Text = row.Cells["tendoanhnghiep"].Value.ToString();
            cmbXa.Text = row.Cells["xa"].Value.ToString();
            cmbHuyen.Text = row.Cells["Huyen"].Value.ToString();

            cmbThuebao.Enabled = true;
            txtGhichu.ReadOnly = false;
            txtDienThoai.ReadOnly = false;

            txtGhichu.Text = "";
            txtDienThoai.Text = "";

            tool_them.Enabled = true;
            tool_xoa.Enabled = false;
            tool_lapbaocao.Enabled = false;
            tool_sua.Enabled = false;
            tool_xemlai.Visible = false;
            tool_thoat.Visible = true;
            tool_save.Enabled = false;
        }

        private void dataGridViewX2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row1 = dataGridViewX2.Rows[e.RowIndex];
            if (row1.Cells["Madaily1"].Value == null)
            {
                txtsohieu.Text = "";
                txtDiaChi.Text = "";
                txtGhichu.Text = "";
                txtTenDaily.Text = "";
                txtMaDaiLy.Text = "";
                cmbXa.Text = "";
                cmbThuebao.Text = "";
                txtDienThoai.Text = "";
            }
            else
            {
                txtMaDaiLy.Text = row1.Cells["Madaily1"].Value.ToString();
                txtTenDaily.Text = row1.Cells["Tendaily1"].Value.ToString();
                txtsohieu.Text = row1.Cells["sohieu1"].Value.ToString();
                txtDiaChi.Text = row1.Cells["Diachi1"].Value.ToString();
                cmbXa.Text = row1.Cells["Xa1"].Value.ToString();
                cmbHuyen.Text = row1.Cells["Huyen1"].Value.ToString();
                cmbThuebao.Text = row1.Cells["thuebao"].Value.ToString();
                txtDienThoai.Text = row1.Cells["Dienthoai"].Value.ToString();
                txtGhichu.Text = row1.Cells["Ghichu"].Value.ToString();
                txtMathuebao.Text = row1.Cells["mathuebao"].Value.ToString();
            }

            txtGhichu.ReadOnly = true;
            txtDienThoai.ReadOnly = true;

            tool_them.Enabled = false;

            if (dataGridViewX2.RowCount == 1)
            {
                tool_xoa.Enabled = false;
                tool_lapbaocao.Enabled = false;
                tool_sua.Enabled = false;
            }
            else
            {
                tool_xoa.Enabled = true;
                tool_lapbaocao.Enabled = true;
                tool_sua.Enabled = true;
            }
            tool_xemlai.Visible = false;
            tool_thoat.Visible = true;
            tool_save.Enabled = false;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;
        }

        private void cmbDoanhnghiep_SelectedValueChanged(object sender, EventArgs e)
        {
            if (checkbox_huyen.Checked)
                prodailyInt.ListInt_Huyen(dataGridViewX1, bindingNavigator1, cmbHuyen, cmbDoanhnghiep);
            else
                prodailyInt.ListInt_Doanhnghiep(dataGridViewX1, bindingNavigator1, cmbDoanhnghiep);

        }

        private void cmbHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbHuyen.Enabled = true;
            if (checkbox_huyen.Checked)
            {
                cmbHuyen.Enabled = true;
                cmbDoanhnghiep.Enabled = false;
                prodailyInt.ListInt_Huyen(dataGridViewX1, bindingNavigator1, cmbHuyen, cmbDoanhnghiep);
            }
            else
                cmbHuyen.Enabled = false;
            cmbDoanhnghiep.Enabled = true;
            prodailyInt.ListInt_Doanhnghiep(dataGridViewX1, bindingNavigator1, cmbDoanhnghiep);
        
        }

        private void checkbox_huyen_CheckedChanged(object sender, EventArgs e)
        {
            cmbHuyen.Enabled = true;
            if (checkbox_huyen.Checked)
            {
                cmbHuyen.Enabled = true;
                cmbDoanhnghiep.Enabled = false;
                prodailyInt.ListInt_Huyen(dataGridViewX1, bindingNavigator1, cmbHuyen, cmbDoanhnghiep);
            }
            else
            {
                cmbHuyen.Enabled = false;
                cmbDoanhnghiep.Enabled = true;
                prodailyInt.ListInt_Doanhnghiep(dataGridViewX1, bindingNavigator1, cmbDoanhnghiep);
            }
        }

        private void cmbThuebao_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMathuebao.Text = cmbThuebao.SelectedValue.ToString();

        }

        private void btnThueBao_Click(object sender, EventArgs e)
        {
            QL_NhomThueBao ThueBao = new QL_NhomThueBao();
            ThueBao.ShowDialog();
            prothuebao.ComboBoxThueBao(cmbThuebao);
        }

        private void txtDienThoai_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < txtDienThoai.Text.Length; i++)

                if (!char.IsNumber(txtDienThoai.Text[i]) & (txtDienThoai.Text[i] >= 10))
                {
                    MessageBox.Show("Điện thoại phải là số !", "Chú ý", MessageBoxButtons.OK);
                    txtDienThoai.Clear();
                    txtDienThoai.Focus();
                    break;
                }
                else if (txtDienThoai.Text.Length < 6)
                {
                    MessageBox.Show("Điện thoại phải lớn hơn 6 ", "Chú ý ", MessageBoxButtons.OK);
                    txtDienThoai.Clear();
                    txtDienThoai.Focus();
                }

                else if (txtDienThoai.Text.Length > 11)
                {
                    MessageBox.Show("Điện thoại phải nhỏ hơn 11 số", "Chú ý ", MessageBoxButtons.OK);
                    txtDienThoai.Clear();
                    txtDienThoai.Focus();
                }
                else if (txtDienThoai.Text == "")
                {
                    MessageBox.Show("Hãy nhập số điện thoại của đại lý", "Chú ý ", MessageBoxButtons.OK);
                    txtDienThoai.Clear();
                    txtDienThoai.Focus();
                    tool_them.Enabled = false;
                }
                else
                    tool_them.Enabled = true;
        }
    }
}