using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyXeVaXe
{
    public partial class frmTraXeKhongLaiXe : Form
    {
        public frmTraXeKhongLaiXe()
        {
            InitializeComponent();
        }

        private void frmTraXeKhongLaiXe_Load(object sender, EventArgs e)
        {
            //txtMaHD.Text = frmTraXeKhongLaiXe.tb.Text;
            txtMaHD.Text = frmTraTienKhongLaiXe.tb.Text;
            //Load_MaCT;
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tb_ChiTietHopDong where MaHopDong = '" + txtMaHD.Text + "'", con);
            DataTable dt2 = new DataTable();
            dt2.Clear();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            con.Close();
            da2.Dispose();

            SqlDataAdapter da3 = new SqlDataAdapter("select * from tb_ChiTietPhieuTra where TinhTrangTraXe = 'True'", con);
            DataTable dt3 = new DataTable();
            dt3.Clear();
            da3.Fill(dt3);
            dataGridView2.DataSource = dt3;
            con.Close();
            da3.Dispose();
        }

        private void frmChiTiet_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_ChiTietHopDong where MaHopDong = '" + txtMaHD.Text + "' ", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            da.Dispose();
        }

        private void dtpNgayTraThucTe_ValueChanged(object sender, EventArgs e)
        {
            if (dtpHanTraXe.Value < dtpNgayTraThucTe.Value)
            {
                txtTienMuonTheoNgay.Enabled = true;
                MessageBox.Show("Khách hàng trả xe quá hạn, Khách hàng bị phạt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtTienMuonTheoNgay.Enabled = false;
            }
            //if (dtpHanTraXe.Value == dtpNgayTraThucTe.Value)
            //{
            //    txtTienMuonTheoNgay.Enabled = true;
            //    MessageBox.Show("Khách hàng trả xe đúng hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    txtTienMuonTheoNgay.Enabled = false;
            //}
            if (dtpHanTraXe.Value > dtpNgayTraThucTe.Value)
            {
                txtTienMuonTheoNgay.Enabled = true;
                MessageBox.Show("Khách hàng trả xe trước hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbTinhTrangHD_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTinhTrangHD.Checked == true)
            {
                cmdHoanTatThanhToa.Visible = true;
            }
            else
            {
                cmdHoanTatThanhToa.Visible = false;
            }
        }

        private void cmdHoanTatThanhToa_Click(object sender, EventArgs e)
        {
            //try
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                con.Open();
                if (dtpNgayTraThucTe.Value <= dtpHanTraXe.Value)
                {
                    SqlCommand cmd = new SqlCommand("insert into tb_ChiTietPhieuTra (MaChiTietPhieuTra, MaHopDong, MaLaiXe, MaXe, NgayTraXeThucTe, TinhTrangHongHoc, ChiPhiBoiThuong, TinhTrangTraXe) values ('" + txtChiTiet.Text + "', '" + txtMaHopDong.Text + "', '" + txtXe.Text + "', '" + dtpNgayTraThucTe.Value + "', '" + txtTinhTrangHong.Text + "', '" + txtChiPhiBoiThuong.Text + "', '" + cbTinhTrangHD.Checked + "')   ", con);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd1 = new SqlCommand("update tb_ChiTietHopDong set TinhTrangHD = 'True' where MaChiTietHopDong = '" + txtChiTiet.Text + "'", con);
                    cmd1.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter("select MaChiTietPhieuTra, MaHopDong, MaLaiXe, MaXe, NgayTraXeThucTe, TinhTrangHongHoc, ChiPhiBoiThuong, TinhTrangTraXe from tb_ChiTietPhieuTra", con);
                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;
                    con.Close();
                    da.Dispose();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into Tb_ChiTietPhieuTra (MaChiTietPhieuTra, MaHopDong, MaLaiXe, MaXe, NgayTraXeThucTe, TienTraXeMuonTheoNgay, TinhTrangHongHoc, ChiPhiBoiThuong, TinhTrangTraXe) values ('" + txtChiTiet.Text + "', '" + txtMaHopDong.Text + "', '" + txtXe.Text + "', '" + dtpNgayTraThucTe.Value + "', '" + txtTienMuonTheoNgay.Text + "', '" + txtTinhTrangHong.Text + "', '" + txtChiPhiBoiThuong.Text + "', '" + cbTinhTrangHD.Checked + "')   ", con);
                    //SqlCommand cmd = new SqlCommand("insert into Tb_ChiTietPhieuTra (MaChiTietPhieuTra, MaHopDong, MaXe, NgayTraXeThucTe, TienTraXeMuonTheoNgay, TinhTrangHongHoc, ChiPhiBoiThuong, TinhTrangTraXe) values ('" + txtChiTiet.Text + "', '" + txtMaHopDong.Text + "', '" + txtXe.Text + "', '" + dtpNgayTraThucTe.Value + "', '" + txtTienMuonTheoNgay.Text + "', '" + txtTinhTrangHong.Text + "', '" + txtChiPhiBoiThuong.Text + "', '" + cbTinhTrangHD.Checked + "')   ", con);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd1 = new SqlCommand("update tb_ChiTietHopDong set TinhTrangHD = 'True' where MaChiTietHopDong = '" + txtChiTiet.Text + "'", con);
                    cmd1.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter("select MaChiTietPhieuTra, MaHopDong, MaLaiXe, MaXe, NgayTraXeThucTe, TienTraXeMuonTheoNgay, TinhTrangHongHoc, ChiPhiBoiThuong, TinhTrangTraXe from Tb_ChiTietPhieuTra", con);
                    DataTable dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;
                    con.Close();
                    da.Dispose();
                }
                MessageBox.Show("Thanh toán thành công, Xin cảm ơn", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //catch
            //{
            ///MessageBox.Show("Đã thanh toán, Vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tb_ChiTietHopDong where MaHopDong = '" + txtMaHD.Text + "'", con);
            DataTable dt2 = new DataTable();
            dt2.Clear();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            con.Close();
            da2.Dispose();

            SqlDataAdapter da3 = new SqlDataAdapter("select * from tb_ChiTietPhieuTra where TinhTrangTraXe = 'True'", con);
            DataTable dt3 = new DataTable();
            dt3.Clear();
            da3.Fill(dt3);
            dataGridView2.DataSource = dt3;
            con.Close();
            da3.Dispose();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtChiTiet.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMaHopDong.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtXe.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //cbTinhTrangLaiXe.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            //txtLaiXe.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            //cbTinhTrangHD.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtpHanTraXe.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtTienThue.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtTienDatCoc.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
    }
}
