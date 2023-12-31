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
    public partial class LapBaoCaoChiTietTKTHKD : Office2007Form
    {
        bool adding = false;
        bool updating = false;
        bool deleting = false;

        BaoCaoChiTietCTVT_InFo baocao = new BaoCaoChiTietCTVT_InFo();

        CongTrinhVienThong_Ctrl procongtrinh = new CongTrinhVienThong_Ctrl();
        LoaiBaoCao_Ctrl proloaibaocao = new LoaiBaoCao_Ctrl();
        MauBaoCaoTKTHKD_InFo info1 = new MauBaoCaoTKTHKD_InFo();
        BaoCaoTKTHKD_InFo info = new BaoCaoTKTHKD_InFo();
        MauBaoCaoTKTHKD_Ctrl promaubaocao = new MauBaoCaoTKTHKD_Ctrl();
        BaoCaoTKTHKD_Ctrl probaocao = new BaoCaoTKTHKD_Ctrl();
        BaoCaoChiTietCTVT_Ctrl probaocaochitiet = new BaoCaoChiTietCTVT_Ctrl();
        BaoCaoChiTietCTVT_InFo info2 = new BaoCaoChiTietCTVT_InFo();
        string ma;        
        public LapBaoCaoChiTietTKTHKD()
        {
            InitializeComponent();
        }

        public LapBaoCaoChiTietTKTHKD(string m_mabaocao)
        {
            InitializeComponent();
            ma = m_mabaocao;
            txtMamaubaocao.Text = ma;
        }
        private void LapBaoCaoChiTietTKTHKD_Load(object sender, EventArgs e)
        {
            probaocao.ListBaoCao(txtMamaubaocao.Text, dataGridViewX1, bindingNavigator1);
            probaocaochitiet.ListBaoCao(txtMamaubaocao.Text, txtMacongtrinh.Text, dataGridViewX2, bindingNavigator2);

            tool_them.Enabled = true;
            tool_xoa.Enabled = true;
            tool_sua.Enabled = true;
            tool_save.Enabled = false;
            tool_xemlai.Visible = false;
            tool_thoat.Visible = true;

            txtMachitiet.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            txtDaitanso.ReadOnly = true;
            txtMota.ReadOnly = true;
            dateThoidiem.Enabled = false;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;
        }

        private void tool_them_Click(object sender, EventArgs e)
        {
            adding = true;
            deleting = false;
            updating = false;

            tool_xoa.Enabled = false;
            tool_them.Enabled = false;
            tool_sua.Enabled = false;
            tool_save.Enabled = true;
            tool_xemlai.Visible = true;
            tool_thoat.Visible = false;

            dataGridViewX1.Enabled = false;
            dataGridViewX2.Enabled = false;


            txtMachitiet.ReadOnly = true;
            txtDiachi.ReadOnly = false;
            txtDaitanso.ReadOnly = false;
            txtMota.ReadOnly = false;
            dateThoidiem.Enabled = true;

            txtMachitiet.Clear();
            txtDaitanso.Clear();
            txtDiachi.Clear();
            txtMota.Clear();

            txtMachitiet.Text = probaocaochitiet.LayMaMax().ToString();
        }

        private void tool_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa chi tiết công trình ở \" " + txtDiachi.Text + " \" không ?", "chú ý", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                info2.Mabaocao.Maubaocao.Mamaubaocao = Convert.ToInt32(txtMamaubaocao.Text);
                info2.Macongtrinh.MaCongTrinh = Convert.ToInt32(txtMacongtrinh.Text);
                info2.Machitiet = Convert.ToInt32(txtMachitiet.Text);

                probaocaochitiet.Xoa(info2);
                probaocaochitiet.ListBaoCao(txtMamaubaocao.Text, txtMacongtrinh.Text, dataGridViewX2, bindingNavigator2);
            }
        }

        private void tool_sua_Click(object sender, EventArgs e)
        {
            adding = false;
            updating = true;
            deleting = false;

            tool_them.Enabled = false;
            tool_xoa.Enabled = false;
            tool_sua.Enabled = false;
            tool_save.Enabled = true;
            tool_xemlai.Visible = true;
            tool_thoat.Visible = false;

            txtMachitiet.ReadOnly = false;
            txtDiachi.ReadOnly = false;
            txtDaitanso.ReadOnly = false;
            txtMota.ReadOnly = false;
            dateThoidiem.Enabled = true;

            dataGridViewX1.Enabled = false;
            dataGridViewX2.Enabled = false;
        }

        private void tool_save_Click(object sender, EventArgs e)
        {
            if (probaocaochitiet.CheckInput(txtDiachi, txtDaitanso))
            {
                if (adding)
                {
                    info2.Mabaocao.Maubaocao.Mamaubaocao = Convert.ToInt32(txtMamaubaocao.Text);
                    info2.Macongtrinh.MaCongTrinh = Convert.ToInt32(txtMacongtrinh.Text);
                    info2.Machitiet = Convert.ToInt32(txtMachitiet.Text);
                    info2.Diadiem = txtDiachi.Text;
                    info2.Daitanso = txtDaitanso.Text;
                    info2.Thoidiem = dateThoidiem.Value;
                    info2.Mota = txtMota.Text;

                    probaocaochitiet.Them(info2);
                    probaocaochitiet.ListBaoCao(txtMamaubaocao.Text, txtMacongtrinh.Text, dataGridViewX2, bindingNavigator2);

                    adding = false;
                }
                else
                    if (updating)
                    {
                        info2.Mabaocao.Maubaocao.Mamaubaocao = Convert.ToInt32(txtMamaubaocao.Text);
                        info2.Macongtrinh.MaCongTrinh = Convert.ToInt32(txtMacongtrinh.Text);
                        info2.Machitiet = Convert.ToInt32(txtMachitiet.Text);
                        info2.Diadiem = txtDiachi.Text;
                        info2.Daitanso = txtDaitanso.Text;
                        info2.Thoidiem = dateThoidiem.Value;
                        info2.Mota = txtMota.Text;

                        probaocaochitiet.Sua(info2);
                        probaocaochitiet.ListBaoCao(txtMamaubaocao.Text, txtMacongtrinh.Text, dataGridViewX2, bindingNavigator2);

                        updating = false;
                    }
                tool_them.Enabled = true;
                tool_xoa.Enabled = true;
                tool_sua.Enabled = true;
                tool_save.Enabled = false;
                tool_xemlai.Visible = false;
                tool_thoat.Visible = true;

                txtMachitiet.ReadOnly = true;
                txtDiachi.ReadOnly = true;
                txtDaitanso.ReadOnly = true;
                txtMota.ReadOnly = true;
                dateThoidiem.Enabled = false;

                dataGridViewX1.Enabled = true;
                dataGridViewX2.Enabled = true;
            }
        }

        private void tool_xemlai_Click(object sender, EventArgs e)
        {
            tool_them.Enabled = true;
            tool_xoa.Enabled = true;
            tool_sua.Enabled = true;
            tool_save.Enabled = false;
            tool_xemlai.Visible = false;
            tool_thoat.Visible = true;

            txtMachitiet.ReadOnly = true;
            txtDiachi.ReadOnly = true;
            txtDaitanso.ReadOnly = true;
            txtMota.ReadOnly = true;
            dateThoidiem.Enabled = false;

            dataGridViewX1.Enabled = true;
            dataGridViewX2.Enabled = true;
        }

        private void tool_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewX1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewX1.Rows[e.RowIndex];
            txtMacongtrinh.Text = row.Cells["macongtrinh"].Value.ToString();
            txtTencongtrinh.Text = row.Cells["tencongtrinh"].Value.ToString();
            txtSoluong.Text = row.Cells["soluong"].Value.ToString();
            txtGhichu.Text = row.Cells["ghichu"].Value.ToString();
            cmbLoaicongtrinh.Text = row.Cells["tenloaicongtrinh"].Value.ToString();

            if (dataGridViewX2.RowCount == 0)
            {
                txtMachitiet.Text = "";
                txtDiachi.Text = "";
                txtDaitanso.Text = "";
                txtMota.Text = "";
                dateThoidiem.Value = DateTime.Now;

                tool_xoa.Enabled = false;
                tool_sua.Enabled = false;
            }
        }

        private void dataGridViewX2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewX2.Rows[e.RowIndex];

            txtMachitiet.Text = row.Cells["machitiet"].Value.ToString();
            txtDaitanso.Text = row.Cells["daitanso"].Value.ToString();
            txtDiachi.Text = row.Cells["diachi"].Value.ToString();
            txtMota.Text = row.Cells["mota"].Value.ToString();
            if (row.Cells["thoidiem"].Value.ToString() == "")
                dateThoidiem.Value = DateTime.Now;
            else
                dateThoidiem.Value = Convert.ToDateTime(row.Cells["thoidiem"].Value.ToString());
        
        }

        private void txtMacongtrinh_TextChanged(object sender, EventArgs e)
        {
            probaocaochitiet.ListBaoCao(txtMamaubaocao.Text, txtMacongtrinh.Text, dataGridViewX2, bindingNavigator2);

        }

        private void côngTrìnhViễnThôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_CongTrinhVienThong ctvt = new QL_CongTrinhVienThong();
            ctvt.ShowDialog();
        }

        private void loạiCôngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_LoaiCongTrinh loaiCT = new QL_LoaiCongTrinh();
            loaiCT.ShowDialog();
            CongTrinhVienThong_Ctrl pro = new CongTrinhVienThong_Ctrl();
            pro.ComboBoxCTVT(cmbLoaicongtrinh);
        }
    }
}