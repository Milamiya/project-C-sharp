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
    public partial class frmChiTietHopDong : Form
    {
        public frmChiTietHopDong()
        {
            InitializeComponent();
        }
        private void LoadCTHD()
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select MaChiTietHopDong from tb_ChiTietHopDong", con);
            DataTable dt1 = new DataTable();
            dt1.Clear();
            da1.Fill(dt1);
            txtMaChiTietHD.DataSource = dt1;
            txtMaChiTietHD.DisplayMember = "MaChiTietHopDong";
            txtMaChiTietHD.ValueMember = "MaChiTietHopDong";
            con.Close();
            da1.Dispose();
        }

        private void LoadMaxe()
        {
            if (rbDuLich.Checked == true)
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select tb_Xe.MaXe from tb_Xe Where TinhTrangXe = 'NOT BUSY'", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                txtMaXe.DataSource = dt;
                txtMaXe.DisplayMember = "MaXe";
                txtMaXe.ValueMember = "MaXe";
                con.Close();
                da.Dispose();
            }
        }
        private void LoadSuc()
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select SucChua from tb_Xe Where LoaiXe = 'Du Lich'", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            txtSucChua.DataSource = dt;
            txtSucChua.DisplayMember = "SucChua";
            txtSucChua.ValueMember = "SucChua";
            con.Close();
            da.Dispose();
        }

        private void LoadMaLaiXe()
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaLaiXe from tb_LaiXe where TinhTrangLaiXe = 'NOT BUSY'", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            txtMaLaiXe.DataSource = dt;
            txtMaLaiXe.DisplayMember = "MaLaiXe";
            txtMaLaiXe.ValueMember = "MaLaiXe";
            con.Close();
            da.Dispose();
        }
        private void frmChiTietHopDong_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = frmThemHopDong.tb1.Text;
            dtpNgayLapHD.Text = frmThemHopDong.tb2.Text;

            LoadMaxe();
            LoadMaLaiXe();
            LoadMaxe();
            LoadCTHD();
            LoadSuc();
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tb_ChiTietHopDong ", con);
            DataTable dt2 = new DataTable();
            dt2.Clear();
            da2.Fill(dt2);
            dtgChiTietHopDong.DataSource = dt2;
            con.Close();
            da2.Dispose();
         
            SqlDataAdapter da4 = new SqlDataAdapter("select MaXe as [Mã xe], TenXe as [Tên Xe], NgaySanXuat as [Ngày sản xuất], HangXe as [Hãng xe], BienKiemSoat as [ Biển kiểm soát], SucChua as [SucChua], LoaiXe as [Loại xe], NgayMuaXe as [Ngày Mua Xe] , TinhTrangXe as [Tình trạng xe] from tb_Xe ", con);
            DataTable dt4 = new DataTable();
            dt4.Clear();
            da4.Fill(dt4);
            dataGridView1.DataSource = dt4;
            con.Close();
            da4.Dispose();

            SqlDataAdapter da5 = new SqlDataAdapter("select MaLaiXe as [Mã lái xe], TenLaiXe as [Tên lái xe], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, NgayNhanViec as [Ngày nhận vệc], TinhTrangLaiXe as [Tình trạng lái xe] from tb_LaiXe ", con);
            DataTable dt5 = new DataTable();
            dt5.Clear();
            da5.Fill(dt5);
            dataGridView2.DataSource = dt5;
            con.Close();
            da5.Dispose();
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            DBAccess db1 = new DBAccess();
            SqlConnection conn = db1.GetCon();
            if (db1.Check_LaiXe(txtMaLaiXe.Text) == true)
            {
                MessageBox.Show("Lái Xe đang bận, hãy chọn lái xe khác!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (db1.CheckBusy(txtMaXe.Text) == true)
            {
                MessageBox.Show("Xe đang bận, hãy chọn xe khác!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpHanTraXe.Value < dtpNgayLapHD.Value)
            {
                MessageBox.Show("Hạn trả xe > Ngày thuê xe", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((Convert.ToInt32(txtTienThueXe.Text) < Convert.ToInt32(txtTienDatCoc.Text)))
            {
                MessageBox.Show("Tiền hợp đồng > Tiền đặt cọc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                //try
                //{
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    if ((cbTinhTrangLaiXe.Checked) == true)
                    {
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("insert into tb_ChiTietHopDong(MaChiTietHopDong, MaHopDong, MaXe, TinhTrangLaiXe, MaLaiXe, TinhTrangHD, HanTraXe, TienThueXe, TienDatCoc, SoTienConNo) values ('" + txtMaChiTietHD.Text + "', '" + txtMaHD.Text + "', '" + txtMaXe.Text + "', '" + cbTinhTrangLaiXe.Checked + "','" + txtMaLaiXe.Text + "', '" + txtTinhTrangHopDong.Text + "','" + dtpHanTraXe.Text + "', '" + txtTienThueXe.Text + "', '" + txtTienDatCoc.Text + "' , '" + txtTienConLai.Text + "') ", con);
                            cmd.ExecuteNonQuery();
                            SqlDataAdapter da = new SqlDataAdapter("select * from tb_ChiTietHopDong ", con);
                            DataTable dt = new DataTable();
                            dt.Clear();
                            da.Fill(dt);
                            dtgChiTietHopDong.DataSource = dt;
                            {
                                if (db.CheckBusy_LaiXe(txtMaLaiXe.Text) == "NOT BUSY")
                                {
                                    SqlCommand cmd5 = new SqlCommand("update tb_LaiXe set tb_LaiXe.TinhTrangLaiXe = 'BUSY' where Malaixe = '" + txtMaLaiXe.Text + "'", con);
                                    cmd5.ExecuteNonQuery();
                                }
                                if (db.CheckBusy_Xe(txtMaXe.Text) == "NOT BUSY")
                                {
                                    SqlCommand cmd1 = new SqlCommand("update tb_Xe set tb_Xe.TinhTrangXe = 'BUSY' where MaXe = '" + txtMaXe.Text + "'", con);
                                    cmd1.ExecuteNonQuery();
                                }
                            }
                            con.Close();
                            da.Dispose();
                            MessageBox.Show("Hợp đồng đã được lập thành công", "Lập hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Lập hợp đồng thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    if ((cbTinhTrangLaiXe.Checked) == false)
                    {
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("insert into tb_ChiTietHopDong(MaChiTietHopDong, MaHopDong, MaXe, TinhTrangLaiXe, TinhTrangHD,HanTraXe,TienThueXe,TienDatCoc, SoTienConNo) values ('" + txtMaChiTietHD.Text + "', '" + txtMaHD.Text + "', '" + txtMaXe.Text + "', '" + cbTinhTrangLaiXe.Checked + "', '" + txtTinhTrangHopDong.Text + "','" + dtpHanTraXe.Text + "','" + txtTienThueXe.Text + "','" + txtTienDatCoc.Text + "','" + txtTienConLai.Text + "') ", con);
                            cmd.ExecuteNonQuery();
                            SqlDataAdapter da = new SqlDataAdapter("select * from tb_ChiTietHopDong ", con);
                            DataTable dt = new DataTable();
                            dt.Clear();
                            da.Fill(dt);
                            dtgChiTietHopDong.DataSource = dt;
                            {
                                if (db.CheckBusy_Xe(txtMaXe.Text) == "NOT BUSY")
                                {
                                    SqlCommand cmd1 = new SqlCommand("update tb_Xe set tb_Xe.TinhTrangXe = 'BUSY' where MaXe = '" + txtMaXe.Text + "'", con);
                                    cmd1.ExecuteNonQuery();
                                }
                            }
                            con.Close();
                            da.Dispose();
                            MessageBox.Show("Hợp đồng đã được lập thành công", "Lập hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Lập hợp đồng thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select tb_Xe.MaXe as [Mã xe], tb_Xe.TenXe as [Tên Xe], tb_Xe.NgaySanXuat as [Ngày sản xuất], tb_Xe.HangXe as [Hãng xe], tb_Xe.BienKiemSoat as [ Biển kiểm soát], tb_Xe.SucChua as [SucChua], tb_Xe.LoaiXe as [Loại xe], tb_Xe.NgayMuaXe as [Ngày Mua Xe], TinhTrangXe as [Tình trạng xe] from tb_Xe where tb_Xe.Maxe = ('" + txtMaXe.Text + "')", con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            da.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select MaLaiXe as [Mã lái xe], TenLaiXe as [Tên lái xe], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, NgayNhanViec as [Ngày nhận vệc], TinhTrangLaiXe as [Tình trạng lái xe] from tb_LaiXe where Malaixe = '"+txtMaLaiXe.Text+"'", con);
            DataTable dt1 = new DataTable();
            dt1.Clear();
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            con.Close();
            da1.Dispose();
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            frmSuaChiTiet f = new frmSuaChiTiet();
            this.Hide();
            f.Show();
         
        }

        private void txtMaChiTietHD_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMaChiTietHD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdIn_Click(object sender, EventArgs e)
        {
            //frmBaoCaoHD f = new frmBaoCaoHD();
            //f.ts = txtMaHD.Text;
            //f.Show();
        }

        private void cbTinhTrangLaiXe_CheckedChanged(object sender, EventArgs e)
        {
            if ((cbTinhTrangLaiXe.Checked) == true)
            {
                txtMaLaiXe.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                txtMaLaiXe.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void dtpHanTraXe_ValueChanged(object sender, EventArgs e)
        {
            if (dtpHanTraXe.Value < dtpNgayLapHD.Value)
            {
                MessageBox.Show("Hạn trả xe > Ngày thuê xe", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTienThueXe_TextChanged(object sender, EventArgs e)
        {
            int a = int.Parse(txtTienDatCoc.Text);
            int b = int.Parse(txtTienThueXe.Text);
            int c = b - a;
            txtTienConLai.Text = c.ToString();
            
        }

        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            if (rbDuLich.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select tb_Xe.MaXe from tb_Xe Where TinhTrangXe = 'NOT BUSY' and LoaiXe = 'Du Lich'", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                txtMaXe.DataSource = dt;
                txtMaXe.DisplayMember = "MaXe";
                txtMaXe.ValueMember = "MaXe";
                con.Close();
                da.Dispose();
            }
            if (rbVanTai.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select tb_Xe.MaXe from tb_Xe Where TinhTrangXe = 'NOT BUSY' and LoaiXe = 'Van Tai'", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                txtMaXe.DataSource = dt;
                txtMaXe.DisplayMember = "MaXe";
                txtMaXe.ValueMember = "MaXe";
                con.Close();
                da.Dispose();
            }
            if (rbTaxi.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select tb_Xe.MaXe from tb_Xe Where TinhTrangXe = 'NOT BUSY' and LoaiXe = 'TaXi'", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                txtMaXe.DataSource = dt;
                txtMaXe.DisplayMember = "MaXe";
                txtMaXe.ValueMember = "MaXe";
                con.Close();
                da.Dispose();
            }

            SqlDataAdapter da1 = new SqlDataAdapter("select tb_LaiXe.MaLaiXe from tb_LaiXe where TinhTrangLaiXe = 'NOT BUSY'", con);
            DataTable dt1 = new DataTable();
            dt1.Clear();
            da1.Fill(dt1);
            txtMaLaiXe.DataSource = dt1;
            txtMaLaiXe.DisplayMember = "MaLaiXe";
            txtMaLaiXe.ValueMember = "MaLaiXe";
            con.Close();
            da1.Dispose();
        }

        private void rbDuLich_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDuLich.Checked == true)
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select tb_Xe.MaXe from tb_Xe Where TinhTrangXe = 'NOT BUSY' and LoaiXe = 'Du Lich'", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                txtMaXe.DataSource = dt;
                txtMaXe.DisplayMember = "MaXe";
                txtMaXe.ValueMember = "MaXe";
                con.Close();
                da.Dispose();

                SqlDataAdapter da1 = new SqlDataAdapter("select SucChua from tb_Xe Where LoaiXe = 'Du Lich'", con);
                DataTable dt1 = new DataTable();
                dt1.Clear();
                da1.Fill(dt1);
                txtSucChua.DataSource = dt1;
                txtSucChua.DisplayMember = "SucChua";
                txtSucChua.ValueMember = "SucChua";
                con.Close();
                da1.Dispose();
            }
        }

        private void rbVanTai_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVanTai.Checked == true)
            {

                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select tb_Xe.MaXe from tb_Xe Where TinhTrangXe = 'NOT BUSY' and LoaiXe = 'Van Tai'", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                txtMaXe.DataSource = dt;
                txtMaXe.DisplayMember = "MaXe";
                txtMaXe.ValueMember = "MaXe";
                con.Close();
                da.Dispose();


                SqlDataAdapter da1 = new SqlDataAdapter("select SucChua from tb_Xe Where LoaiXe = 'Van Tai'", con);
                DataTable dt1 = new DataTable();
                dt1.Clear();
                da1.Fill(dt1);
                txtSucChua.DataSource = dt1;
                txtSucChua.DisplayMember = "SucChua";
                txtSucChua.ValueMember = "SucChua";
                con.Close();
                da1.Dispose();
            }
        }

        private void rbTaxi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTaxi.Checked == true)
            {

                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select tb_Xe.MaXe from tb_Xe Where TinhTrangXe = 'NOT BUSY' and LoaiXe = 'Taxi'", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                txtMaXe.DataSource = dt;
                txtMaXe.DisplayMember = "MaXe";
                txtMaXe.ValueMember = "MaXe";
                con.Close();
                da.Dispose();

                SqlDataAdapter da1 = new SqlDataAdapter("select SucChua from tb_Xe Where LoaiXe = 'Taxi'", con);
                DataTable dt1 = new DataTable();
                dt1.Clear();
                da1.Fill(dt1);
                txtSucChua.DataSource = dt1;
                txtSucChua.DisplayMember = "SucChua";
                txtSucChua.ValueMember = "SucChua";
                con.Close();
                da1.Dispose();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmRelapHopDong f = new frmRelapHopDong();
            f.a = txtMaHD.Text;
            f.Show();
        }


        }

}
          