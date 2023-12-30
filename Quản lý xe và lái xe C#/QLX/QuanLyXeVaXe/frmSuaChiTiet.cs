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
    public partial class frmSuaChiTiet : Form
    {
        public frmSuaChiTiet()
        {
            InitializeComponent();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            try
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();

                con.Open();
                SqlCommand cmd1 = new SqlCommand("update tb_Xe set tb_Xe.TinhTrangXe = 'NOT BUSY' where MaXe = '" + txtMaXe.Text + "'", con);
                cmd1.ExecuteNonQuery();
                con.Close();

                con.Open();
                SqlCommand cmd5 = new SqlCommand("update tb_LaiXe set tb_LaiXe.TinhTrangLaiXe = 'NOT BUSY' where Malaixe = '" + txtMaLaiXe.Text + "'", con);
                cmd5.ExecuteNonQuery();
                con.Close();


                con.Open();
                SqlCommand cmd = new SqlCommand("delete tb_ChiTietHopDong where MaChiTietHopDong = '" + txtMaChiTietHD.Text + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();





                SqlDataAdapter da = new SqlDataAdapter("select MaChiTietHopDong as [Mã chi tiết HĐ], tb_ChiTietHopDong.MaHopDong as [Mã hợp đồng], tb_ChiTietHopDong.MaXe as [Mã xe], tb_ChiTietHopDong.MaLaiXe as [Mã lái xe], TinhTrangHD as [Tình trạng hợp đồng], HanTraXe as [Hạn trả xe] from tb_ChiTietHopDong ", con);
                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                dtgChiTietHopDong.DataSource = dt;
                con.Close();
                da.Dispose();
                MessageBox.Show("Nhấn <Tiếp..> để tiếp tục việc sửa hợp đồng", "Quản lý hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Sửa thất bại, Lỗi CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaChiTietHD_TextChanged(object sender, EventArgs e)
        {
            //DBAccess db = new DBAccess();
            //SqlConnection con = db.GetCon();
            //con.Open();
            //DataTable dt = new DataTable();
            //SqlDataAdapter sqlda = new SqlDataAdapter("select MaXe from tb_ChiTietHopDong where MaChiTietHopDong = '" + txtMaChiTietHD.Text + "' ", con);
            //sqlda.Fill(dt);
            //txtMaXe.DataSource = dt;
            //txtMaXe.DisplayMember = "MaXe";

            //DataTable dt1 = new DataTable();
            //SqlDataAdapter sqlda1 = new SqlDataAdapter("select MaLaiXe from tb_ChiTietHopDong where MaChiTietHopDong = '" + txtMaChiTietHD.Text + "' ", con);
            //sqlda1.Fill(dt1);
            //txtMaLaiXe.DataSource = dt1;
            //txtMaLaiXe.DisplayMember = "MaLaiXe";

            //DataTable dt2 = new DataTable();
            //SqlDataAdapter sqlda2 = new SqlDataAdapter("select MaHopDong from tb_ChiTietHopDong where MaChiTietHopDong = '" + txtMaChiTietHD.Text + "' ", con);
            //sqlda2.Fill(dt2);
            //txtMaHD.DataSource = dt2;
            //txtMaHD.DisplayMember = "MaHopDong";

            //DataTable dt3 = new DataTable();
            //SqlDataAdapter sqlda3 = new SqlDataAdapter("select TinhTrangHD from tb_ChiTietHopDong where MaChiTietHopDong = '" + txtMaChiTietHD.Text + "' ", con);
            //sqlda3.Fill(dt3);
            //txtTinhTrangHopDong.DataSource = dt3;
            //txtTinhTrangHopDong.DisplayMember = "TinhTrangHD";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmChiTietHopDong f = new frmChiTietHopDong();
            f.Show();
            this.Hide();
            
        }

        private void frmSuaChiTiet_Load(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection con = db.GetCon();
            con.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("select MaChiTietHopDong as [Mã chi tiết HĐ], tb_ChiTietHopDong.MaHopDong as [Mã hợp đồng], tb_ChiTietHopDong.MaXe as [Mã xe], tb_ChiTietHopDong.MaLaiXe as [Mã lái xe], TinhTrangHD as [Tình trạng hợp đồng], HanTraXe as [Hạn trả xe] from tb_ChiTietHopDong ", con);
            DataTable dt2 = new DataTable();
            dt2.Clear();
            da2.Fill(dt2);
            dtgChiTietHopDong.DataSource = dt2;
            con.Close();
            da2.Dispose();
        }

        private void dtgChiTietHopDong_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtMaChiTietHD.Text = dtgChiTietHopDong.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMaHD.Text = dtgChiTietHopDong.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMaXe.Text = dtgChiTietHopDong.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMaLaiXe.Text = dtgChiTietHopDong.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTinhTrangHopDong.Text = dtgChiTietHopDong.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtpHanTraXe.Text = dtgChiTietHopDong.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        }
    }

