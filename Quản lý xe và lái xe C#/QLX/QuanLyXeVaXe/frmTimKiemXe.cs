using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyXeVaXe
{
    public partial class frmTimKiemXe : Form
    {
        public frmTimKiemXe()
        {
            InitializeComponent();
        }

        /*
        private void txtTimKiemXe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (rbTimKiemTheoMa.Checked == true)
                {
                    DBAccess db = new DBAccess();
                    SqlConnection con = db.GetCon();
                    SqlDataAdapter da = new SqlDataAdapter("select MaXe as [Mã xe], TenXe as [Tên Xe], NgaySanXuat as [Ngày sản xuất], HangXe as [Hãng xe], BienKiemSoat as [ Biển kiểm soát], SucChua as [SucChua], LoaiXe as [Loại xe], NgayMuaXe as [Ngày Mua Xe]  from tb_Xe, tb_LaiXe where tb_LaiXe.MaXe = tb_Xe.MaXe  and Sole like '%" + txtTimKiemXe.Text + "%'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tb_Xe");
                    dtgTimKiemXe.DataSource = ds.Tables["tb_Xe"].DefaultView;
                    
                }
                if (rbTimKiemTheoTen.Checked == true)
                {
                    DBAccess db = new DBAccess();
                    SqlConnection con = db.GetCon();
                    SqlDataAdapter da = new SqlDataAdapter("select MaXe as [Mã xe], TenXe as [Tên Xe], NgaySanXuat as [Ngày sản xuất], HangXe as [Hãng xe], BienKiemSoat as [ Biển kiểm soát], SucChua as [SucChua], LoaiXe as [Loại xe], NgayMuaXe as [Ngày Mua Xe] from tb_Xe where MaXe like '%" + txtTimKiemXe.Text + "%'", con);
                    DataSet ds = new DataSet ();
                    da.Fill(ds, "tb_Xe");
                    dtgTimKiemXe.DataSource = ds.Tables["tb_Xe"].DefaultView;
                }
                if (rbTimKiemTheoNgayMuaXe.Checked == true)
                {
                    DBAccess db = new DBAccess();
                    SqlConnection con = db.GetCon();
                    SqlDataAdapter da = new SqlDataAdapter("select MaXe as [Mã xe], TenXe as [Tên Xe], NgaySanXuat as [Ngày sản xuất], HangXe as [Hãng xe], BienKiemSoat as [ Biển kiểm soát], SucChua as [SucChua], LoaiXe as [Loại xe], NgayMuaXe as [Ngày Mua Xe] from tb_Xe where NgayMuaXe like '%" + txtTimKiemXe.Text + "%'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tb_Xe");
                    dtgTimKiemXe.DataSource = ds.Tables["tb_Xe"].DefaultView;
                }
                if (rbTimKiemTheoMaLaiXe.Checked == true)
                {
                    DBAccess db = new DBAccess();
                    SqlConnection con = db.GetCon();
                    SqlDataAdapter da = new SqlDataAdapter("select MaXe as [Mã xe], TenXe as [Tên Xe], NgaySanXuat as [Ngày sản xuất], HangXe as [Hãng xe], BienKiemSoat as [ Biển kiểm soát], SucChua as [SucChua], LoaiXe as [Loại xe], NgayMuaXe as [Ngày Mua Xe] from tb_Xe,t b_LaiXe where tb_LaiXe.MaLaiXe and Sole  like '%" + txtTimKiemXe.Text + "%'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tb_Xe");
                    dtgTimKiemXe.DataSource = ds.Tables["tb_Xe"].DefaultView;
                }
            }

        }
        */
   
        private void cmdTimKiemXe_Click(object sender, EventArgs e)
        {
          
                if (rbTimKiemTheoMa.Checked == true)
                {
                    DBAccess db = new DBAccess();
                    SqlConnection con = db.GetCon();
                    SqlDataAdapter da = new SqlDataAdapter("select MaXe as [Mã xe], TenXe as [Tên Xe], NgaySanXuat as [Ngày sản xuất], HangXe as [Hãng xe], BienKiemSoat as [ Biển kiểm soát], SucChua as [SucChua], LoaiXe as [Loại xe], NgayMuaXe as [Ngày Mua Xe], TinhTrangXe as [Tình trạng xe] from tb_Xe where MaXe like '%" + txtTimKiemXe.Text + "%'", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tb_Xe");
                    dtgTimKiemXe.DataSource = ds.Tables["tb_Xe"].DefaultView;
                    
                }
               
                   
               
            
            
            if (rbTimKiemTheoTen.Checked == true)
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                SqlDataAdapter da = new SqlDataAdapter("select MaXe as [Mã xe], TenXe as [Tên Xe], NgaySanXuat as [Ngày sản xuất], HangXe as [Hãng xe], BienKiemSoat as [ Biển kiểm soát], SucChua as [SucChua], LoaiXe as [Loại xe], NgayMuaXe as [Ngày Mua Xe], TinhTrangXe as [Tình trạng xe] from tb_Xe where TenXe like '%" + txtTimKiemXe.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds,"tb_Xe");
                dtgTimKiemXe.DataSource = ds.Tables["tb_Xe"].DefaultView;
            }




            if (rbTimKiemTheoNgayMuaXe.Checked == true)
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                SqlDataAdapter da = new SqlDataAdapter("select MaXe as [Mã xe], TenXe as [Tên Xe], NgaySanXuat as [Ngày sản xuất], HangXe as [Hãng xe], BienKiemSoat as [ Biển kiểm soát], SucChua as [SucChua], LoaiXe as [Loại xe], NgayMuaXe as [Ngày Mua Xe] ,TinhTrangXe as [Tình trạng xe] from tb_Xe where NgayMuaXe like '%" + txtTimKiemXe.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds,"tb_Xe");
                dtgTimKiemXe.DataSource = ds.Tables["tb_Xe"].DefaultView;
            }



            if (rbTimKiemTheoMaLaiXe.Checked == true)
            {
                DBAccess db = new DBAccess();
                SqlConnection con = db.GetCon();
                SqlDataAdapter da = new SqlDataAdapter("select tb_Xe.MaXe as [Mã xe], tb_Xe.TenXe as [Tên Xe], tb_Xe.NgaySanXuat as [Ngày sản xuất], tb_Xe.HangXe as [Hãng xe], tb_Xe.BienKiemSoat as [ Biển kiểm soát], tb_Xe.SucChua as [Súc chứa], tb_Xe.LoaiXe as [Loại xe], NgayMuaXe as [Ngày Mua Xe], TinhTrangXe as [Tình trạng xe], tb_ChiTietHopDong.MaLaiXe as [Mã Lái Xe] from tb_Xe,tb_ChiTietHopDong where tb_Xe.MaXe = tb_ChiTietHopDong.MaXe And tb_ChiTietHopDong.MaLaiXe like '%" + txtTimKiemXe.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds,"tb_Xe");
                dtgTimKiemXe.DataSource = ds.Tables["tb_Xe"].DefaultView;
            }
        }
    }
}
