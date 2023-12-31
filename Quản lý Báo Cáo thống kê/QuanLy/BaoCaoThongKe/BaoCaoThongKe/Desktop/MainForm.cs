using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Controls;
using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.Controller;

namespace BaoCaoThongKe.Desktop
{
    public partial class MainForm : Office2007RibbonForm
    {
        DataService ds = new DataService();
        public MainForm()
        {
            InitializeComponent();
        }

        private void ribbonTab_qlchung_Click(object sender, EventArgs e)
        {
            narbar_QuanLyChung.Expanded = true;
        }

        private void ribbonTab_hethong_Click(object sender, EventArgs e)
        {
            narbar_HeThong.Expanded = true;
        }

        private void BT_Backup_Click(object sender, EventArgs e)
        {
            SaveFileDialog backup = new SaveFileDialog();
            if (backup.ShowDialog() == DialogResult.OK)
            {
                string query = " backup database THONGKE to disk = '" + backup.FileName + "'";
                System.Data.SqlClient.SqlCommand com = new System.Data.SqlClient.SqlCommand(query);
                ds.Load(com);
                MessageBox.Show("Sao lưu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BT_restore_Click(object sender, EventArgs e)
        {
            OpenFileDialog backup = new OpenFileDialog();
            if (backup.ShowDialog() == DialogResult.OK)
            {
                string query = " use master restore database THONGKE from disk = '" + backup.FileName + "'";
                System.Data.SqlClient.SqlCommand com = new System.Data.SqlClient.SqlCommand(query);
                ds.Load(com);
                MessageBox.Show("Phục hồi thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Bạn phải khởi động lại phần mềm sau khi phục hồi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
       
        QL_Huyen_Thi formhuyen = null;
        private void button_huyen_Click(object sender, EventArgs e)
        {
            if (formhuyen == null || formhuyen.IsDisposed)
            {
                formhuyen = new QL_Huyen_Thi();
                formhuyen.MdiParent = this;
                formhuyen.Show();
            }
            else
                formhuyen.Activate();
        }
        QL_Xa_Phuong_ formxa = null;
        private void button_xa_Click(object sender, EventArgs e)
        {
            if (formxa == null || formxa.IsDisposed)
            {
                formxa = new QL_Xa_Phuong_();
                formxa.MdiParent = this;
                formxa.Show();
            }
            else
                formxa.Activate();
        }
        QL_DuAn formDuAn = null;
        private void button_duan_Click(object sender, EventArgs e)
        {
            if (formDuAn == null || formDuAn.IsDisposed)
            {
                formDuAn = new QL_DuAn();
                formDuAn.MdiParent = this;
                formDuAn.Show();
            }
            else
                formDuAn.Activate();
        }
        QL_LoaiDuAn formLoaiDuAn = null;
        private void button_loaiduan_Click(object sender, EventArgs e)
        {
            if (formLoaiDuAn == null || formLoaiDuAn.IsDisposed)
            {
                formLoaiDuAn = new QL_LoaiDuAn();
                formLoaiDuAn.MdiParent = this;
                formLoaiDuAn.Show();
            }
            else
                formLoaiDuAn.Activate();
        }
        QL_CongTrinhVienThong formCTVT = null;
        private void button_congtrinh_Click(object sender, EventArgs e)
        {
            if (formCTVT == null || formCTVT.IsDisposed)
            {
                formCTVT = new QL_CongTrinhVienThong();
                formCTVT.MdiParent = this;
                formCTVT.Show();
            }
            else
                formCTVT.Activate();
        }
        QL_LoaiCongTrinh formLoaiCongTrinh = null;
        private void button_loaicongtrinh_Click(object sender, EventArgs e)
        {
            if (formLoaiCongTrinh == null || formLoaiCongTrinh.IsDisposed)
            {
                formLoaiCongTrinh = new QL_LoaiCongTrinh();
                formLoaiCongTrinh.MdiParent = this;
                formLoaiCongTrinh.Show();
            }
            else
                formLoaiCongTrinh.Activate();
        }
        QL_DaiLyInternet formDLInternet = null;
        private void button_dlInternet_Click(object sender, EventArgs e)
        {
            if (formDLInternet == null || formDLInternet.IsDisposed)
            {
                formDLInternet = new QL_DaiLyInternet();
                formDLInternet.MdiParent = this;
                formDLInternet.Show();
            }
            else
                formDLInternet.Activate();
        }
        QL_DaiLyBuuDien formDLBD = null;
        private void button_dlbd_Click(object sender, EventArgs e)
        {
            if (formDLBD == null || formDLBD.IsDisposed)
            {
                formDLBD = new QL_DaiLyBuuDien();
                formDLBD.MdiParent = this;
                formDLBD.Show();
            }
            else
                formDLBD.Activate();
        }
        QL_DaiLyBuuDienVHX formDLBDVHX = null;
        private void button_dlbdvhx_Click(object sender, EventArgs e)
        {
            if (formDLBDVHX == null || formDLBDVHX.IsDisposed)
            {
                formDLBDVHX = new QL_DaiLyBuuDienVHX();
                formDLBDVHX.MdiParent = this;
                formDLBDVHX.Show();
            }
            else
                formDLBDVHX.Activate();
        }
        QL_DichVu_BuuChinh_VT formDVBCVT = null;
        private void button_dichvubcvt_Click(object sender, EventArgs e)
        {
            if (formDVBCVT == null || formDVBCVT.IsDisposed)
            {
                formDVBCVT = new QL_DichVu_BuuChinh_VT();
                formDVBCVT.MdiParent = this;
                formDVBCVT.Show();
            }
            else
                formDVBCVT.Activate();
        }
        QL_NguoiDung formNguoiDung = null;
        private void QL_DK_Nguoi_Dung_Click(object sender, EventArgs e)
        {
            if (formNguoiDung == null || formNguoiDung.IsDisposed)
            {
                formNguoiDung = new QL_NguoiDung();
                formNguoiDung.MdiParent = this;
                formNguoiDung.Show();
            }
            else
                formNguoiDung.Activate();
        }
        DoiMatKhau cpass = null;
        private void QL_doimatkhau_Click(object sender, EventArgs e)
        {
            if (cpass == null || cpass.IsDisposed)
            {
                cpass = new DoiMatKhau();
                cpass.MdiParent = this;
                cpass.Show();
            }
            else
                cpass.Activate();
            
        }
        QL_DoanhNghiep formDoanhnghiep = null;
        private void button_doanhnghiep_Click(object sender, EventArgs e)
        {
            if (formDoanhnghiep == null || formDoanhnghiep.IsDisposed)
            {
                formDoanhnghiep = new QL_DoanhNghiep();
                formDoanhnghiep.MdiParent = this;
                formDoanhnghiep.Show();
            }
            else
                formDoanhnghiep.Activate();
        }

        private void ribbonTab_qlbaocao_Click(object sender, EventArgs e)
        {
            narbar_QuanLyBaoCao.Expanded = true;
        }

        private void ribbonTab_thongkebaocao_Click(object sender, EventArgs e)
        {
            narbar_ThongKeBaoCao.Expanded = true;
        }

        private void ribbonTab_timkiemchung_Click(object sender, EventArgs e)
        {
            
        }

        private void ribbonTab_trogiup_Click(object sender, EventArgs e)
        {
            navBar_trogiup.Expanded = true;
        }
        QuanLyBaoCaoTHTHDT formQLTHTHDT = null;
        private void button_QL_BC_ththdautu_Click(object sender, EventArgs e)
        {
            if (formQLTHTHDT == null || formQLTHTHDT.IsDisposed)
            {
                formQLTHTHDT = new QuanLyBaoCaoTHTHDT();
                formQLTHTHDT.MdiParent = this;
                formQLTHTHDT.Show();
            }
            else
                formQLTHTHDT.Activate();
        }
        QuanLyBaoCaoTKTHKD formQLBCCTVT = null;
        private void button_QL_BC_congtrinhvienthong_Click(object sender, EventArgs e)
        {
            if (formQLBCCTVT == null || formQLBCCTVT.IsDisposed)
            {
                formQLBCCTVT = new QuanLyBaoCaoTKTHKD();
                formQLBCCTVT.MdiParent = this;
                formQLBCCTVT.Show();
            }
            else
                formQLBCCTVT.Activate();
        }
        QuanLyBaoCaoTHTHCLDV formQLBCTHTHCLDV = null; 
        private void button_QL_BC_TH_TH_CL_DV_Click(object sender, EventArgs e)
        {
            if (formQLBCTHTHCLDV == null || formQLBCTHTHCLDV.IsDisposed)
            {
                formQLBCTHTHCLDV = new QuanLyBaoCaoTHTHCLDV();
                formQLBCTHTHCLDV.MdiParent = this;
                formQLBCTHTHCLDV.Show();
            }
            else
                formQLBCTHTHCLDV.Activate();
        }
        QuanLyBaoCaoDaiLyInternet formQLBCDLINT = null;
        private void button_QL_BC_dlInternet_Click(object sender, EventArgs e)
        {
            if (formQLBCDLINT == null || formQLBCDLINT.IsDisposed)
            {
                formQLBCDLINT = new QuanLyBaoCaoDaiLyInternet();
                formQLBCDLINT.MdiParent = this;
                formQLBCDLINT.Show();
            }
            else
                formQLBCDLINT.Activate();
        }
        QuanLyBaoCaoDaiLyBuuDien formQLBCDLBD = null;
        private void button_QL_BC_dlbd_Click(object sender, EventArgs e)
        {
            if (formQLBCDLBD == null || formQLBCDLBD.IsDisposed)
            {
                formQLBCDLBD = new QuanLyBaoCaoDaiLyBuuDien();
                formQLBCDLBD.MdiParent = this;
                formQLBCDLBD.Show();
            }
            else
                formQLBCDLBD.Activate();
        }
        QuanLyBaoCaoDaiLyBuuDienVHX formQLBCDLBDVHX = null;
        private void button_QL_BC_dlbdvhx_Click(object sender, EventArgs e)
        {
            if (formQLBCDLBDVHX == null || formQLBCDLBDVHX.IsDisposed)
            {
                formQLBCDLBDVHX = new QuanLyBaoCaoDaiLyBuuDienVHX();
                formQLBCDLBDVHX.MdiParent = this;
                formQLBCDLBDVHX.Show();
            }
            else
                formQLBCDLBDVHX.Activate();
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            //Help.ShowHelp(new frmGiupDo(), "THospital Help.chm");
            Help.ShowHelp(this, "HELP.chm");
        }

        private void bar_Backup_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            SaveFileDialog backup = new SaveFileDialog();
            if (backup.ShowDialog() == DialogResult.OK)
            {
                string query = " backup database THONGKE to disk = '" + backup.FileName + "'";
                System.Data.SqlClient.SqlCommand com = new System.Data.SqlClient.SqlCommand(query);
                ds.Load(com);
                MessageBox.Show("Sao lưu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bar_Restore_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            OpenFileDialog backup = new OpenFileDialog();
            if (backup.ShowDialog() == DialogResult.OK)
            {
                string query = " use master restore database THONGKE from disk = '" + backup.FileName + "'";
                System.Data.SqlClient.SqlCommand com = new System.Data.SqlClient.SqlCommand(query);
                ds.Load(com);
                MessageBox.Show("Phục hồi thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Bạn phải khởi động lại phần mềm sau khi phục hồi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        //private void bar_Login_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        //{
        //    if (formDangNhap == null || formDangNhap.IsDisposed)
        //    {
        //        formDangNhap = new DangNhap();
        //        formDangNhap.Show();
        //    }
        //    else
        //        formDangNhap.Activate();
        //}

        private void bar_LogOff_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            LogIn();
            //if (MessageBox.Show("Bạn có chắc chắn thoát không ?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    foreach (Form i in this.MdiChildren)
            //        i.Dispose();
            //}
        }

        private void bar_Thoat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (MessageBox.Show("Chương Trình Sẽ Thoát!!!. Bạn Có Chắc Không?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bar_DaiLyInt_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (formDLInternet == null || formDLInternet.IsDisposed)
            {
                formDLInternet = new QL_DaiLyInternet();
                formDLInternet.MdiParent = this;
                formDLInternet.Show();
            }
            else
                formDLInternet.Activate();
        }

        private void bar_BuuDienVHX_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (formDLBDVHX == null || formDLBDVHX.IsDisposed)
            {
                formDLBDVHX = new QL_DaiLyBuuDienVHX();
                formDLBDVHX.MdiParent = this;
                formDLBDVHX.Show();
            }
            else
                formDLBDVHX.Activate();
        }

        private void bar_DaiLyBuuDien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (formDLBD == null || formDLBD.IsDisposed)
            {
                formDLBD = new QL_DaiLyBuuDien();
                formDLBD.MdiParent = this;
                formDLBD.Show();
            }
            else
                formDLBD.Activate();
        }

        private void bar_DichVuBuuChinh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (formDVBCVT == null || formDVBCVT.IsDisposed)
            {
                formDVBCVT = new QL_DichVu_BuuChinh_VT();
                formDVBCVT.MdiParent = this;
                formDVBCVT.Show();
            }
            else
                formDVBCVT.Activate();
        }

        private void bar_QuanLyDoanhNghiep_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (formDoanhnghiep == null || formDoanhnghiep.IsDisposed)
            {
                formDoanhnghiep = new QL_DoanhNghiep();
                formDoanhnghiep.MdiParent = this;
                formDoanhnghiep.Show();
            }
            else
                formDoanhnghiep.Activate();
        }

        private void bar_CCDV_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        private void bar_TH_TH_DT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (formQLTHTHDT == null || formQLTHTHDT.IsDisposed)
            {
                formQLTHTHDT = new QuanLyBaoCaoTHTHDT();
                formQLTHTHDT.MdiParent = this;
                formQLTHTHDT.Show();
            }
            else
                formQLTHTHDT.Activate();
        }
        //
        QuanLyBaoCaoTKTHKD THKD = null;
        private void bar_CongTrinh_VT_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (THKD == null || THKD.IsDisposed)
            {
                THKD = new QuanLyBaoCaoTKTHKD();
                THKD.MdiParent = this;
                THKD.Show();
            }
            else
                THKD.Activate();
        }

        private void bar_TH_TH_CLDV_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (formQLBCTHTHCLDV == null || formQLBCTHTHCLDV.IsDisposed)
            {
                formQLBCTHTHCLDV = new QuanLyBaoCaoTHTHCLDV();
                formQLBCTHTHCLDV.MdiParent = this;
                formQLBCTHTHCLDV.Show();
            }
            else
                formQLBCTHTHCLDV.Activate();
        }

        private void bar_DSInternet_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (formDLInternet == null || formDLInternet.IsDisposed)
            {
                formDLInternet = new QL_DaiLyInternet();
                formDLInternet.MdiParent = this;
                formDLInternet.Show();
            }
            else
                formDLInternet.Activate();
        }

        private void bar_DSDLBuuDien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (formDLBD == null || formDLBD.IsDisposed)
            {
                formDLBD = new QL_DaiLyBuuDien();
                formDLBD.MdiParent = this;
                formDLBD.Show();
            }
            else
                formDLBD.Activate();
        }

        private void bar_DSBDVHX_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (formDLBDVHX == null || formDLBDVHX.IsDisposed)
            {
                formDLBDVHX = new QL_DaiLyBuuDienVHX();
                formDLBDVHX.MdiParent = this;
                formDLBDVHX.Show();
            }
            else
                formDLBDVHX.Activate();
        }

        private void Huyen_Thi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (formhuyen == null || formhuyen.IsDisposed)
            {
                formhuyen = new QL_Huyen_Thi();
                formhuyen.MdiParent = this;
                formhuyen.Show();
            }
            else
                formhuyen.Activate();
        }

        private void Xa_Phuong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (formxa == null || formxa.IsDisposed)
            {
                formxa = new QL_Xa_Phuong_();
                formxa.MdiParent = this;
                formxa.Show();
            }
            else
                formxa.Activate();
        }

        private void DuAn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (formDuAn == null || formDuAn.IsDisposed)
            {
                formDuAn = new QL_DuAn();
                formDuAn.MdiParent = this;
                formDuAn.Show();
            }
            else
                formDuAn.Activate();
        }

        private void LoaiDuAn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (formLoaiDuAn == null || formLoaiDuAn.IsDisposed)
            {
                formLoaiDuAn = new QL_LoaiDuAn();
                formLoaiDuAn.MdiParent = this;
                formLoaiDuAn.Show();
            }
            else
                formLoaiDuAn.Activate();
        }

        private void CongTrinh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (formCTVT == null || formCTVT.IsDisposed)
            {
                formCTVT = new QL_CongTrinhVienThong();
                formCTVT.MdiParent = this;
                formCTVT.Show();
            }
            else
                formCTVT.Activate();
        }

        private void LoaiCongtrinh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (formLoaiCongTrinh == null || formLoaiCongTrinh.IsDisposed)
            {
                formLoaiCongTrinh = new QL_LoaiCongTrinh();
                formLoaiCongTrinh.MdiParent = this;
                formLoaiCongTrinh.Show();
            }
            else
                formLoaiCongTrinh.Activate();
        }

        private void bar_trogiup_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Help.ShowHelp(this, "HELP.chm");

        }

        private void bar_lienhe_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (formLienhe == null || formLienhe.IsDisposed)
            {
                formLienhe = new LienHe();
                formLienhe.MdiParent = this;
                formLienhe.Show();
            }
            else
                formLienhe.Activate();
        }
        LienHe formLienhe = null;
        private void button_lienhe_Click(object sender, EventArgs e)
        {
            if (formLienhe == null || formLienhe.IsDisposed)
            {
                formLienhe = new LienHe();
                formLienhe.MdiParent = this;
                formLienhe.Show();
            }
            else
                formLienhe.Activate();
        }        

        private void button_dangxuat_Click(object sender, EventArgs e)
        {
            LogIn();
            //if (MessageBox.Show("Bạn có chắc chắn thoát không ?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    foreach (Form i in this.MdiChildren)
            //        i.Dispose();
            //}
        }

        private void button_thoatHT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chương Trình Sẽ Thoát!!!. Bạn Có Chắc Không?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void _DangNhapShow_(object sender, EventArgs e)
        {
            LogIn();
        }
        void LogIn()
        {
            DangNhap DangNhap_HThong = new DangNhap();
            DangNhap_HThong.ShowDialog();
            if (DangNhap_HThong.DialogResult == DialogResult.OK)
            {
                if (DangNhap_HThong.status == true)
                {                    
                    {
                        LogIn();
                    }
                }
                else
                {
                    if (MessageBox.Show("Chương Trình Sẽ Thoát!. Bạn Có Chắc Không?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else
                    {
                        LogIn();
                    }

                }
            }
        }
        DangNhap DangNhap_HeThong = null;
        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            DangNhap_HeThong = new DangNhap();
            DangNhap_HeThong.MdiParent = this;
            DangNhap_HeThong.Show();
        }

        private void bar_Login_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DangNhap_HeThong = new DangNhap();
            DangNhap_HeThong.MdiParent = this;
            DangNhap_HeThong.Show();
        }
        private void EnterLockMode(bool flag)
        {
            BC_1.Enabled = !flag;
            BC_2.Enabled = !flag;
            BC_3.Enabled = !flag;
            BC_4.Enabled = !flag;
            BC_5.Enabled = !flag;
        }
        BaoCaoHoatDongCungCapDichVu formBCHDCCDV = null;
        private void button_QL_BC_CungCap_DV_Click(object sender, EventArgs e)
        {
            if (formBCHDCCDV == null || formBCHDCCDV.IsDisposed)
            {
                formBCHDCCDV = new BaoCaoHoatDongCungCapDichVu();
                formBCHDCCDV.MdiParent = this;
                formBCHDCCDV.Show();
            }
            else
                formBCHDCCDV.Activate();
        }

        

    }
}