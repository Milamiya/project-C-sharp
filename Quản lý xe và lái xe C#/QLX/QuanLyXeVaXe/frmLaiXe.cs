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
    public partial class frmLaiXe : Form
    {
        public frmLaiXe()
        {
            InitializeComponent();
        }

        private void cmdTimKiemLaiXe_Click(object sender, EventArgs e)
        {
            {

                if (rbTimKiemLaiXeTheoMa.Checked == true)
                {
                    DBAccess db = new DBAccess();
                    SqlConnection con = db.GetCon();
                    SqlDataAdapter da = new SqlDataAdapter("select MaLaiXe as [Mã lái xe], TenLaiXe as [Tên lái xe], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, NgayNhanViec as [Ngày nhận vệc] from tb_LaiXe where MaLaiXe like '%" + txtTimKiemLaiXe.Text + "%'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tb_LaiXe");
                    dgvTimKiemLaiXe.DataSource = ds.Tables["tb_LaiXe"].DefaultView;

                }



                if (rbTimKiemLaiXeTheoTen.Checked == true)
                {
                    DBAccess db = new DBAccess();
                    SqlConnection con = db.GetCon();
                    SqlDataAdapter da = new SqlDataAdapter("select MaLaiXe as [Mã lái xe], TenLaiXe as [Tên lái xe], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, NgayNhanViec as [Ngày nhận vệc] from tb_LaiXe where TenLaiXe like '%" + txtTimKiemLaiXe.Text + "%'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tb_LaiXe");
                    dgvTimKiemLaiXe.DataSource = ds.Tables["tb_LaiXe"].DefaultView;
                }




                if (rbTimKiemLaiXeTheoDiaChi.Checked == true)
                {
                    DBAccess db = new DBAccess();
                    SqlConnection con = db.GetCon();
                    SqlDataAdapter da = new SqlDataAdapter("select MaLaiXe as [Mã lái xe], TenLaiXe as [Tên lái xe], NgaySinh as [Ngày sinh], GioiTinh as [Giới tính], DiaChi as [ Địa chỉ], DienThoai as [Điện thoại], CMND, Email, NgayNhanViec as [Ngày nhận vệc] from tb_LaiXe where DiaChi like '%" + txtTimKiemLaiXe.Text + "%'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tb_LaiXe");
                    dgvTimKiemLaiXe.DataSource = ds.Tables["tb_LaiXe"].DefaultView;
                }



                if (rbTimKiemLaiXeTheoMaXe.Checked == true)
                {
                    DBAccess db = new DBAccess();
                    SqlConnection con = db.GetCon();
                    SqlDataAdapter da = new SqlDataAdapter("select tb_LaiXe.MaLaiXe as [Mã lái xe], tb_ChiTietHopDong.MaXe as [Mã xe], tb_LaiXe.TenLaiXe as [Tên lái xe], tb_LaiXe.NgaySinh as [Ngày sinh], tb_LaiXe.GioiTinh as [Giới tính], tb_LaiXe.DiaChi as [ Địa chỉ], tb_LaiXe.DienThoai as [Điện thoại], tb_LaiXe.CMND, tb_LaiXe.Email, tb_LaiXe.NgayNhanViec as [Ngày nhận vệc] from tb_LaiXe, tb_ChiTietHopDong where tb_LaiXe.MaLaiXe = tb_ChiTietHopDong.MaLaiXe And tb_ChiTietHopDong.MaXe like '%" + txtTimKiemLaiXe.Text + "%'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tb_LaiXe");
                    dgvTimKiemLaiXe.DataSource = ds.Tables["tb_LaiXe"].DefaultView;
                }
            }
        }
    }
}
