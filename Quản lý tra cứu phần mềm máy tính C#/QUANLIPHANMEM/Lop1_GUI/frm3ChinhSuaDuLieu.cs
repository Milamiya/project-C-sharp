using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Lop2_BUS;
using Enities;

namespace Lop1_GUI
{
    public partial class frm3ChinhSuaDuLieu : Form
    {
        B_LoaiPM objPL = new B_LoaiPM();
        B_PhanMiem objPM = new B_PhanMiem();
        B_HeDieuHanh objHDH = new B_HeDieuHanh();
        B_HuongDan objHD = new B_HuongDan();

        BindingSource bs = new BindingSource();
        DataTable tbLoaiPM, tbHeDieuHanh, tbPM,tbHuongDan;
        bool danap = false;
       

        public frm3ChinhSuaDuLieu()
        {
            InitializeComponent();
            tbHeDieuHanh = objHDH.gettb_HEDIEUHANH();
        }
        private void LOADHEDIEUHANH()
        {
            
            danap = true;
            bs.DataSource = tbHeDieuHanh;
            tbPM = objPM.gettbPhanMem();
            dgwSanPham.DataSource = tbPM;

            txtMaHDH.Enabled = false;
            txtTenHDH.Enabled = false;
            txtMaPL.Enabled = false;
            txtTenLoaiPM.Enabled = false;
            txtMaLoaiHDH.Enabled = false;
            //dgvPhanMem :
            cboMaPhamMem.Enabled = false;
            txtTENPM.Enabled = false;
            txtHEDIEUHANH.Enabled = false;
            txtLINKDOWN.Enabled = false;
            cboMaPhanLoai.Enabled = false;
            rtbSUaThongTinPhanMem.Enabled = false;

            tbHeDieuHanh = objHDH.gettb_HEDIEUHANH();
            bs.DataSource = tbHeDieuHanh; // cos dde xoa
            dgvHIENCHUDE.DataSource = tbHeDieuHanh;
        }
        private void frmChinhSua_Load(object sender, EventArgs e) // Load 
        {
            LOADHEDIEUHANH();
            string strmapl = frm2HienThiChinh.strhdh;
             cboMaPhanLoai.Text = strmapl;
             txtMaLoaiHDH.Enabled = false;
             

            
        } // FormChinhSUaPhanMem        
#region Thêm ,Xóa, Sửa, Lưu Phần Mềm
        private void dgwSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string strMaPM = dgwSanPham.CurrentRow.Cells[0].Value.ToString();
                DataTable tbPM = objPM.gettbPhanMem_Theo_maPhanMem(strMaPM);
                cboMaPhamMem.Text = tbPM.Rows[0]["MaPhanMem"].ToString();
                txtTENPM.Text = tbPM.Rows[0]["TenPhanMem"].ToString();
                txtHEDIEUHANH.Text = tbPM.Rows[0]["HeDieuHanh"].ToString();
                txtLINKDOWN.Text = tbPM.Rows[0]["LinkDown"].ToString();
                cboMaPhanLoai.Text = tbPM.Rows[0]["MaPL"].ToString();

           
                DataTable tbHuongDan = objHD.gettbHuongDan_Theo_maphanmem(strMaPM);
                rtbSUaThongTinPhanMem.Text = tbHuongDan.Rows[0]["HuongDan"].ToString();
                //đưa txt hệ Điều hành qua dgvChinhSua phần mềm
                DataTable tbHeDieuHanh =objHDH.gettb_HEDIEUHANH();
                txtHEDIEUHANH.Text=tbHeDieuHanh.Rows[0]["TenHDH"].ToString();
                if (danap)
                    bs.Position = dgwSanPham.CurrentRow.Index;

               
               
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR !");

            }
                } //dgvPhanMem
        private void PIC_THEM_Click(object sender, EventArgs e)
        {
            cboMaPhamMem.Enabled = true;
            txtTENPM.Enabled=true;
            txtLINKDOWN.Enabled = true;
            rtbSUaThongTinPhanMem.Enabled = true;
            txtLINKDOWN.Text = "";
            cboMaPhamMem.Text = "";
            txtTENPM.Text = "";
            rtbSUaThongTinPhanMem.Text = "";
            cboMaPhamMem.Focus();

        } //Thêm Phần Mềm
        private void pic_Xoa_Click(object sender, EventArgs e)
        {
            //             if (dgwSanPham.SelectedRows.Count == 0)
            //             {
            //                 MessageBox.Show("Không Có Dữ Liệu Xóa !");
            //             }
            //             else
            {
                DialogResult re = MessageBox.Show("Bạn muốn xóa Phần Mềm  Này?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (re == DialogResult.OK)
                {
                    tbPM.Rows[bs.Position].Delete();
                    if (objPM.CapNhatDULIEU(tbPM) == 0)
                    {
                        MessageBox.Show("Xóa Thất Bại !");

                    }
                    else MessageBox.Show("Xóa Thành Công !");
                    objPM.CapNhatDULIEU(tbPM);
                }
            }
        } //Xóa Phần Mềm
        private void PIC_LUU_Click(object sender, EventArgs e)
        {

            if (txtHEDIEUHANH.Text == "" || txtLINKDOWN.Text == "" || cboMaPhanLoai.Text == "" || cboMaPhamMem.Text == "" || txtTENPM.Text == "")
            {
                MessageBox.Show("Kiểm Tra Lại Dữ Liệu Nhập !!");
            }
            else
            {
                DataRow r = tbPM.NewRow();
               r[0] = cboMaPhamMem.Text;
                r[1] = txtTENPM.Text;
                r[2] = txtHEDIEUHANH.Text;
                r[3] = txtLINKDOWN.Text;
                r[4] = cboMaPhanLoai.Text;

//               string hUONGDAN = rtbSUaThongTinPhanMem.Text;
//               tbHuongDan = objHD.gettbHuongDan_Theo_maphanmem(cboMaPhamMem.Text);
//               objHD.CapNhattb_HUONGDAN(tbHuongDan);

                if (objPM.kiemtratrung(r["MaPhanMem"].ToString())) // them duoc
                {
                    tbPM.Rows.Add(r);
                    MessageBox.Show("Lưu Thành Công Phần Mềm !");
                    objPM.CapNhatDULIEU(tbPM);
                }
                else
                { MessageBox.Show("Trùng Mã Phần Mềm !"); }

            }
        }//Lưu Phần Mềm
        private void PIC_CHINHSUA_Click(object sender, EventArgs e) //SỬa Phần Mềm
        {
            cboMaPhamMem.Enabled = true;
            txtTENPM.Enabled = true;
            txtLINKDOWN.Enabled = true;
            rtbSUaThongTinPhanMem.Enabled = true;
        }
#endregion
#region XÓA,SỬA,LƯU Hệ Điều Hành    
        private void dgvHIENCHUDE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHDH.Focus();
            try
            {
                string strTHemHDH = dgvHIENCHUDE.CurrentRow.Cells[0].Value.ToString();
                DataTable tbHeDieuHanh = objHDH.getHEDIEUHANH_theo_maHEDIEUHANH(strTHemHDH);
                txtMaHDH.Text = tbHeDieuHanh.Rows[0]["MaHDH"].ToString();
                txtTenHDH.Text = tbHeDieuHanh.Rows[0]["TenHDH"].ToString();


                tbLoaiPM = objPL.gettbLoaiPM_Theo_maHDH(strTHemHDH);
                dgvSuaLoaiPhanMem.DataSource = tbLoaiPM;

                if (danap)
                    bs.Position = dgvHIENCHUDE.CurrentRow.Index;

                //Đưa Mã Chủ Đề Xuống Làm Mã Hệ Điều Hành (Cho Mặc Định Đó MÀ....:))
                txtMaLoaiHDH.Text = strTHemHDH;
                txtHEDIEUHANH.Text = tbHeDieuHanh.Rows[0]["TenHDH"].ToString();

                //Khóa Lại Các TxtNhapVao{

                txtMaHDH.Enabled = false;
                txtTenHDH.Enabled = false;
                txtMaPL.Enabled = false;
                txtTenLoaiPM.Enabled = false;
                txtMaLoaiHDH.Enabled = false;
                //} 

            }
            catch (Exception)
            {

                MessageBox.Show("RỖNG !");
            }
        }
        private void pic_xoaHDH_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(bs.Position.ToString());// hienej thi dong nao thoi
            DialogResult re = MessageBox.Show("Bạn muốn Xóa Hệ Điều Hành Này?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (re == DialogResult.OK)
            {
                tbHeDieuHanh.Rows[bs.Position].Delete();
                objHDH.capNhattb_HEDIEUHANH(tbHeDieuHanh);
                MessageBox.Show("Xóa Thành Công !");
            }
        } //Xóa Hệ Điều Hành
        private void PIC_LUUHDH_Click(object sender, EventArgs e)
        {
            DataRow r = tbHeDieuHanh.NewRow();
            r[0] = txtMaHDH.Text;
            r[1] = txtTenHDH.Text;
            if (objHDH.kiemtratrung(r["MaHDH"].ToString()))
            {
                tbHeDieuHanh.Rows.Add(r);
                MessageBox.Show("Lưu Thành Công !");
                objHDH.capNhattb_HEDIEUHANH(tbHeDieuHanh);
            }
            else
            {
                MessageBox.Show("Trùng Mã Hệ Điều Hành !");
            }
        } //Lưu Hệ Điều Hành
        private void PIC_SUAHDH_Click(object sender, EventArgs e)
        {
            txtMaHDH.Enabled = true;
            txtTenHDH.Enabled = true;

        } //Sửa Hệ Điều Hành
        private void PIC_THOAT_Click(object sender, EventArgs e) //Thoát
        {
            frm2HienThiChinh F = new frm2HienThiChinh();
            F.Show();
            this.Close();
        }
#endregion               
#region Thêm Xóa Lưu Loại Phần Mềm
             private void dgvSuaLoaiPhanMem_CellClick(object sender, DataGridViewCellEventArgs e)
             {
                 txtMaPL.Focus();
                 try
                 {
                     string strA = dgvSuaLoaiPhanMem.CurrentRow.Cells[0].Value.ToString();
                     DataTable tbLoaiPM = objPL.gettbLoaiPM_Theo_maPL(strA);
                     txtMaPL.Text = tbLoaiPM.Rows[0]["MaPL"].ToString();
                     txtTenLoaiPM.Text = tbLoaiPM.Rows[0]["TenLoaiPM"].ToString();
                     txtMaLoaiHDH.Text = tbLoaiPM.Rows[0]["MaHDH"].ToString();

                     if (danap)
                         bs.Position = dgvSuaLoaiPhanMem.CurrentRow.Index;
                     //KHÚC HIỆN LÊN BẢNG SẢN PHẨM
                     string strMAPL = txtMaPL.Text.ToString();
                     tbPM = objPM.gettbPhanMem_Theo_maPhanLoai(strMAPL);
                     bs.DataSource = tbPM;
                     dgwSanPham.DataSource = tbPM;
                     if (danap)
                         bs.Position = dgvSuaLoaiPhanMem.CurrentRow.Index;
                     danap = true;
                     
                     //cho giá trị dgvLoai sang dgvPhanMem
                     try
                     {
                         cboMaPhanLoai.Text = tbLoaiPM.Rows[0]["MaPL"].ToString();
                     }
                     catch (Exception)
                     {

                         MessageBox.Show("Thêm Loại Phần Mềm Cho Hệ Điều Hành !");
                     }

                 }
                 catch (Exception)
                 {

                     MessageBox.Show("ERROR !");

                 }
             } 
             private void btnThemMoi_Click(object sender, EventArgs e) //Thêm Mới LoaiPM
             {
                 txtMaPL.Enabled = true;
                 txtTenLoaiPM.Enabled = true;
                 txtTenLoaiPM.Text = "";
                 txtMaPL.Text = "";
             }
             private void btnChinhSua_Click(object sender, EventArgs e)
             {
                 txtTenLoaiPM.Enabled = true;
             }//Sửa LoạiPM
             private void btnXOA_Click(object sender, EventArgs e)
             {
                 DialogResult re = MessageBox.Show("Bạn muốn xóa Loại Phần Mềm Này?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                 if (re == DialogResult.OK)
                 {
                     tbLoaiPM.Rows[dgvSuaLoaiPhanMem.CurrentRow.Index].Delete();
                     objPL.CapNhattb_LoaiPM(tbLoaiPM);
                     MessageBox.Show("Xóa Thành Công !");
                 }
             } 
             private void btnLuu_Click(object sender, EventArgs e)
             {
                 if (txtMaPL.Text == "" || txtTenLoaiPM.Text == "" || txtMaLoaiHDH.Text == "")
                 {
                     MessageBox.Show("Kiểm Tra Lại Dữ Liệu Nhập !!");
                 }
                 else
                 {
                     DataRow r = tbLoaiPM.NewRow();
                     r[0] = txtMaPL.Text;
                     r[1] = txtTenLoaiPM.Text;
                     r[2] = txtMaLoaiHDH.Text;
                     if (objPL.kiemtratrung(r["MaPL"].ToString())) // them duoc
                     {
                         tbLoaiPM.Rows.Add(r);
                         MessageBox.Show("LƯU THÀNH CÔNG ");
                         objPL.CapNhattb_LoaiPM(tbLoaiPM);
                     }
                     else
                         MessageBox.Show("Trùng Mã PL");
                 }
             }

             private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
             {
                 frm5HuongDanSuDungAdmin f = new frm5HuongDanSuDungAdmin();
                 f.ShowDialog();

             }

          
#endregion

             private void dgwSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
             {

             }


          

           
            
            }
      
        }
        

        


    
        
        
        
    

