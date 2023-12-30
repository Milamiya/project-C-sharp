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
    public partial class frmTraXeThoi : Form
    {
        public frmTraXeThoi()
        {
            InitializeComponent();
        }
        //public void Load_MaCT()
        //{
        //    DBAccess db = new DBAccess();
        //    SqlConnection con = db.GetCon();
        //    con.Open();
        //    SqlDataAdapter da = new SqlDataAdapter("select MaChiTietHopDong from tb_ChiTietHopDOng", con);
        //    DataTable dt = new DataTable();
        //    dt.Clear();
        //    da.Fill(dt);
        //    txtMaNhanVien.DataSource = dt;
        //    txtMaNhanVien.DisplayMember = "MaChiTietHopDong";
        //    txtMaNhanVien.ValueMember = "MaChiTietHopDong";
        //    con.Close();
        //    da.Dispose();
        //}
        private void frmTraXeThoi_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = frmTraTien.tb.Text;
            //Load_MaCT;
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tb_ChiTietHopDong where MaHopDong = '"+txtMaHD.Text+"'" , con);
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
            if (rbTraXeCoLai.Checked == true)
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from tb_ChiTietHopDong where MaHopDong = '" + txtMaHD.Text + "' and TinhTrangLaiXe='True'", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                da.Dispose();
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtChiTiet.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMaHopDong.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtXe.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //cbTinhTrangLaiXe.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtLaiXe.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            //cbTinhTrangHD.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtpHanTraXe.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            //txtTienThue.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            //txtTienDatCoc.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            if (rbTraXeCoLai.Checked == true)
            {
                try
                {
                    DBAccess db = new DBAccess();
                    SqlConnection con = db.GetCon();
                    con.Open();
                    if (dtpNgayTraThucTe.Value <= dtpHanTraXe.Value)
                    {
                        SqlCommand cmd = new SqlCommand("insert into tb_ChiTietPhieuTra (MaChiTietPhieuTra, MaHopDong, MaLaiXe, MaXe, NgayTraXeThucTe, TinhTrangHongHoc, ChiPhiBoiThuong, TinhTrangTraXe) values ('" + txtChiTiet.Text + "', '" + txtMaHopDong.Text + "', '" + txtLaiXe.Text + "', '" + txtXe.Text + "', '" + dtpNgayTraThucTe.Value + "', '" + txtTinhTrangHong.Text + "', '" + txtChiPhiBoiThuong.Text + "', '" + cbTinhTrangHD.Checked + "')   ", con);
                        cmd.ExecuteNonQuery();
                        SqlCommand cmd1 = new SqlCommand("update tb_ChiTietHopDong set TinhTrangHD = 'True' where MaChiTietHopDong = '" + txtChiTiet.Text + "'", con);
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd2 = new SqlCommand("update tb_LaiXe set TinhTrangLaiXe = 'NOT BUSY' where MaLaiXe = '" + txtLaiXe.Text + "'", con);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Lái Xe trở về tình trạng NOT BUSY ","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SqlCommand cmd3 = new SqlCommand("update tb_Xe set TinhTrangXe = 'NOT BUSY' where MaXe = '" + txtXe.Text + "'", con);
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show(" Xe trở về tình trạng NOT BUSY ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                        SqlCommand cmd = new SqlCommand("insert into Tb_ChiTietPhieuTra (MaChiTietPhieuTra, MaHopDong, MaLaiXe, MaXe, NgayTraXeThucTe, TienTraXeMuonTheoNgay, TinhTrangHongHoc, ChiPhiBoiThuong, TinhTrangTraXe) values ('" + txtChiTiet.Text + "', '" + txtMaHopDong.Text + "', '" + txtLaiXe.Text + "', '" + txtXe.Text + "', '" + dtpNgayTraThucTe.Value + "', '" + txtTienMuonTheoNgay.Text + "', '" + txtTinhTrangHong.Text + "', '" + txtChiPhiBoiThuong.Text + "', '" + cbTinhTrangHD.Checked + "')   ", con);
                        //SqlCommand cmd = new SqlCommand("insert into Tb_ChiTietPhieuTra (MaChiTietPhieuTra, MaHopDong, MaXe, NgayTraXeThucTe, TienTraXeMuonTheoNgay, TinhTrangHongHoc, ChiPhiBoiThuong, TinhTrangTraXe) values ('" + txtChiTiet.Text + "', '" + txtMaHopDong.Text + "', '" + txtXe.Text + "', '" + dtpNgayTraThucTe.Value + "', '" + txtTienMuonTheoNgay.Text + "', '" + txtTinhTrangHong.Text + "', '" + txtChiPhiBoiThuong.Text + "', '" + cbTinhTrangHD.Checked + "')   ", con);
                        cmd.ExecuteNonQuery();
                        SqlCommand cmd1 = new SqlCommand("update tb_ChiTietHopDong set TinhTrangHD = 'True' where MaChiTietHopDong = '" + txtChiTiet.Text + "'", con);
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd2 = new SqlCommand("update tb_LaiXe set TinhTrangLaiXe = 'NOT BUSY' where MaLaiXe = '" + txtLaiXe.Text + "'", con);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Lái Xe trở về tình trạng NOT BUSY ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SqlCommand cmd3 = new SqlCommand("update tb_Xe set TinhTrangXe = 'NOT BUSY' where MaXe = '" + txtXe.Text + "'", con);
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show(" Xe trở về tình trạng NOT BUSY ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                catch
                {
                   MessageBox.Show("HĐ đã thanh toán, Vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }
        }

        private void dtpNgayTraThucTe_ValueChanged(object sender, EventArgs e)
        {
            if (dtpHanTraXe.Value < dtpNgayTraThucTe.Value)
            {
                txtTienMuonTheoNgay.Visible = true;
                lbTienTraXeMuonTheoNgay.Visible = true;
                MessageBox.Show("Khách hàng trả xe quá hạn, Khách hàng bị phạt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtTienMuonTheoNgay.Visible = false;
                lbTienTraXeMuonTheoNgay.Visible = false;
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

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tb_ChiTietHopDong where TinhTrangLaiXe = 'True' and MaHopDong = '"+txtMaHopDong.Text+"'", con);
            DataTable dt2 = new DataTable();
            dt2.Clear();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            con.Close();
            da2.Dispose();

            SqlDataAdapter da3 = new SqlDataAdapter("select * from tb_ChiTietPhieuTra", con);
            DataTable dt3 = new DataTable();
            dt3.Clear();
            da3.Fill(dt3);
            dataGridView2.DataSource = dt3;
            con.Close();
            da3.Dispose();
        }

        private void cbTinhTrangHD_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTraXeCoLai.Checked == true)
            {
                if (cbTinhTrangHD.Checked == true)
                {
                    cmdHoanTatThanhToa.Visible = true;
                }
                else
                {
                    cmdHoanTatThanhToa.Visible = false;
                    cmdHoanTatKoLaiXe.Visible = false;
                }
            }
            else
            {
                if (rbTraXeKoLai.Checked == true)
                {
                    if (cbTinhTrangHD.Checked == true)
                    {
                        cmdHoanTatKoLaiXe.Visible = true;
                    }
                    else
                    {
                        cmdHoanTatKoLaiXe.Visible = false;
                        cmdHoanTatThanhToa.Visible = false;
                    }
                }
            }
        }

        private void cmdDong_Click(object sender, EventArgs e)
        {

        }

        private void rbTraXeCoLai_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTraXeCoLai.Checked == true)
            {
                cmdRefresh.Visible = true;
                cmdChiTiet.Visible = true;
                button5.Visible = true;

            }
            else
            {
                cmdRefresh.Visible = false;
                cmdChiTiet.Visible = false;
                button5.Visible = false;
            }
        }

        private void rbTraXeKoLai_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTraXeKoLai.Checked == true)
            {
                cmdRefreshKoLaiXe.Visible = true;
                cmdXemChiTietKoLaiXe.Visible = true;
                button6.Visible = true;
            }
            else
            {
                cmdRefreshKoLaiXe.Visible = false;
                cmdXemChiTietKoLaiXe.Visible = false;
                button6.Visible = false;
            }
        }

        private void cmdRefreshKoLaiXe_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tb_ChiTietHopDong where TinhTrangLaiXe = 'False' and MaHopDong = '"+txtMaHopDong.Text+"'" , con);
            DataTable dt2 = new DataTable();
            dt2.Clear();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            con.Close();
            da2.Dispose();

            SqlDataAdapter da3 = new SqlDataAdapter("select * from tb_ChiTietPhieuTra ", con);
            DataTable dt3 = new DataTable();
            dt3.Clear();
            da3.Fill(dt3);
            dataGridView2.DataSource = dt3;
            con.Close();
            da3.Dispose();
        }

        private void cmdHoanTatKoLaiXe_Click(object sender, EventArgs e)
        {
            if (rbTraXeKoLai.Checked == true)
            {
                try
                {
                    DBAccess db = new DBAccess();
                    SqlConnection con = db.GetCon();
                    con.Open();
                    if (dtpNgayTraThucTe.Value <= dtpHanTraXe.Value)
                    {
                        SqlCommand cmd = new SqlCommand("insert into tb_ChiTietPhieuTra (MaChiTietPhieuTra, MaHopDong, MaXe, NgayTraXeThucTe, TinhTrangHongHoc, ChiPhiBoiThuong, TinhTrangTraXe) values ('" + txtChiTiet.Text + "', '" + txtMaHopDong.Text + "', '" + txtXe.Text + "', '" + dtpNgayTraThucTe.Value + "', '" + txtTinhTrangHong.Text + "', '" + txtChiPhiBoiThuong.Text + "', '" + cbTinhTrangHD.Checked + "')   ", con);
                        cmd.ExecuteNonQuery();
                        SqlCommand cmd1 = new SqlCommand("update tb_ChiTietHopDong set TinhTrangHD = 'True' where MaChiTietHopDong = '" + txtChiTiet.Text + "'", con);
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd3 = new SqlCommand("update tb_Xe set TinhTrangXe = 'NOT BUSY' where MaXe = '" + txtXe.Text + "'", con);
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show(" Xe trở về tình trạng NOT BUSY ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        SqlDataAdapter da = new SqlDataAdapter("select MaChiTietPhieuTra, MaHopDong, MaXe, NgayTraXeThucTe, TinhTrangHongHoc, ChiPhiBoiThuong, TinhTrangTraXe from tb_ChiTietPhieuTra", con);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);
                        dataGridView2.DataSource = dt;
                        con.Close();
                        da.Dispose();
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("insert into Tb_ChiTietPhieuTra (MaChiTietPhieuTra, MaHopDong, MaXe, NgayTraXeThucTe, TienTraXeMuonTheoNgay, TinhTrangHongHoc, ChiPhiBoiThuong, TinhTrangTraXe) values ('" + txtChiTiet.Text + "', '" + txtMaHopDong.Text + "', '" + txtXe.Text + "', '" + dtpNgayTraThucTe.Value + "', '" + txtTienMuonTheoNgay.Text + "', '" + txtTinhTrangHong.Text + "', '" + txtChiPhiBoiThuong.Text + "', '" + cbTinhTrangHD.Checked + "')   ", con);
                        //SqlCommand cmd = new SqlCommand("insert into Tb_ChiTietPhieuTra (MaChiTietPhieuTra, MaHopDong, MaXe, NgayTraXeThucTe, TienTraXeMuonTheoNgay, TinhTrangHongHoc, ChiPhiBoiThuong, TinhTrangTraXe) values ('" + txtChiTiet.Text + "', '" + txtMaHopDong.Text + "', '" + txtXe.Text + "', '" + dtpNgayTraThucTe.Value + "', '" + txtTienMuonTheoNgay.Text + "', '" + txtTinhTrangHong.Text + "', '" + txtChiPhiBoiThuong.Text + "', '" + cbTinhTrangHD.Checked + "')   ", con);
                        cmd.ExecuteNonQuery();
                        SqlCommand cmd1 = new SqlCommand("update tb_ChiTietHopDong set TinhTrangHD = 'True' where MaChiTietHopDong = '" + txtChiTiet.Text + "'", con);
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd3 = new SqlCommand("update tb_Xe set TinhTrangXe = 'NOT BUSY' where MaXe = '" + txtXe.Text + "'", con);
                        cmd3.ExecuteNonQuery();
                        MessageBox.Show(" Xe trở về tình trạng NOT BUSY ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SqlDataAdapter da = new SqlDataAdapter("select MaChiTietPhieuTra, MaHopDong, MaXe, NgayTraXeThucTe, TienTraXeMuonTheoNgay, TinhTrangHongHoc, ChiPhiBoiThuong, TinhTrangTraXe from Tb_ChiTietPhieuTra", con);
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);
                        dataGridView2.DataSource = dt;
                        con.Close();
                        da.Dispose();
                    }
                    MessageBox.Show("Thanh toán thành công, Xin cảm ơn", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                       MessageBox.Show(" HĐ Đã thanh toán, Vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbTraXeKoLai.Checked == true)
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from tb_ChiTietHopDong where MaHopDong = '" + txtMaHD.Text + "' and TinhTrangLaiXe = 'False'", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                da.Dispose();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tb_ChiTietPhieuTra where MaChiTietPhieuTra = '" + txtChiTiet.Text + "'", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
            da.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmReTraXeCoNguoiLai f = new frmReTraXeCoNguoiLai();
            f.a = txtMaHopDong.Text;
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmReKoLaiXe f = new frmReKoLaiXe();
            f.a = txtMaHopDong.Text;
            f.Show();
        }

       
    }
}
