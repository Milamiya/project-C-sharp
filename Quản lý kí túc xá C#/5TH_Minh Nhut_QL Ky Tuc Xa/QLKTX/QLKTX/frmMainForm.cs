using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevComponents.DotNetBar;
using XPExplorerBar;
using QLKTX.Controller;
using QLKTX.Dialog;



namespace QLKTX
{
    public partial class frmMainForm : Form
    {

        public frmMainForm()
        {
            FormChung.flash = new frmFlashScreen();
            FormChung.flash.Show();
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {            
            //SinhVien -> TraCuu -> Phong
                PhongCtrl phg=new PhongCtrl();
                phg.LayDuLieuLenComboBoxItem(cmbQLSV_TraCuu_Phong);
                phg.LayDuLieuLenComboBoxItem(cmbQLPhong_DanhGiaPhong);                
                phg.LayDuLieuLenComboBoxItem(cmb_QLPHG_ThongKe_Phong);                

            //-----------------------------
           //SinhVien -> TraCuu -> Phong
                DayCtrl day = new DayCtrl();
                day.LayDuLieuLenComboBoxItem(cmbQLSV_TraCuu_Day);
                day.LayDuLieuLenComboBoxItem(comboBoxItem15);
                

           //-----------------------------
           //SinhVien -> TraCuu -> Phong
              //  cmbQLSV_ThongKe.Items.AddRange(new string[] { "Phòng", "Dãy", "KTX" });
           //-----------------------------
           // tat cua so FlaskScreen
         VoHieuHoa();
                FormChung.flash.Dispose();
            
        }

        private void expandablePanel2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void ribbonBar1_ItemClick(object sender, EventArgs e)
        {

        }

        

       
       
        private void taskItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void taskItem12_Click(object sender, EventArgs e)
        {
            //tabMainTool.SelectedTabIndex = 4;
            btnHeThong_NguoiDung.Focus();
            NguoiDung();
        }

        private void taskItem13_Click(object sender, EventArgs e)
        {
            mnuMainMenu.Visible = true;
            XPExplorer.Visible = true;
            toolMenuBar.Visible = true;

            tabMainTool.Visible = false;
            tabExplorer.Visible = false;
        }

       

        private void taskItem14_Click_1(object sender, EventArgs e)
        {
            tabMainTool.Visible = true;
            tabExplorer.Visible = true;

            mnuMainMenu.Visible = false;
            XPExplorer.Visible = false;
            toolMenuBar.Visible = false;
        }

        private void ngangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void docToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            GioiThieu();
        }

        private void btnHeThong_DangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuHeThong_DangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void taskTab_ĐăngNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void taskXP_DangNhap_Click(object sender, EventArgs e)
        {
            DangNhap(); 
        }

        private void btnMainTool_DangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuQLSV_ThemSV_Click(object sender, EventArgs e)
        {
            ThemSinhVien();
        }

        private void btnQLSV_ThemSinhVien_Click(object sender, EventArgs e)
        {
            ThemSinhVien();
        }

        private void btnQLSV_XoaSinhVien_Click(object sender, EventArgs e)
        {
            XoaSinhVien();
        }

        private void mnuQLSV_XoaSinhVien_Click(object sender, EventArgs e)
        {
            XoaSinhVien();
        }

        private void mnuQLSV_SuaSV_Click(object sender, EventArgs e)
        {
            SuaSinhVien();
        }

        private void btnQLSV_SuaSinhVien_Click(object sender, EventArgs e)
        {
            SuaSinhVien();
        }

        private void btnHeThong_Ngang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void btnHeThong_Doc_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cmbQLSV_TraCuu_Phong_Click(object sender, EventArgs e)
        {
            TraCuuSinhVien();
        }

        

        private void cmdQLSV_TraCuu_Day_Click(object sender, EventArgs e)
        {
          
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            btnNormal.Visible = true;
            btnFull.Visible = false;
            tabMainTool.Height = 27;
            tabExplorer.Expanded = false;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            btnFull.Visible = true;
            btnNormal.Visible = false;
            tabMainTool.Height = 118;
            tabExplorer.Expanded = true;
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }


        private void hiêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabMainTool.Visible = true;
            tabExplorer.Visible = true;

            mnuMainMenu.Visible = false;
            XPExplorer.Visible = false;
            toolMenuBar.Visible = false;
        }

        private void btnHeThong_NamHoc_Click(object sender, EventArgs e)
        {
            NamHoc();
        }

        private void btnHeThong_HocKy_Click(object sender, EventArgs e)
        {
            HocKy();
        }

        private void btnQLSV_TraCuu_Phong_Click(object sender, EventArgs e)
        {
            if (cmbQLSV_TraCuu_Phong.SelectedIndex >= 0)
                TraCuuSinhVienTheoPhong(cmbQLSV_TraCuu_Phong.SelectedItem.ToString());
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ThemSinhVien();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHeThong_DangXuat_Click(object sender, EventArgs e)
        {
            DangXuat();
        }

        private void btnToolMenuBar_TraCuu_SinhVien_Click(object sender, EventArgs e)
        {
            TraCuuSinhVien();
        }

        private void btnQLSV_QuanLy_ChuyenPhong_Click(object sender, EventArgs e)
        {
            ChuyenPhongSinhVien();
        }

        private void btnQLSV_DanhGia_Click(object sender, EventArgs e)
        {
            DanhGiaSinhVien();
        }

        private void mnuQLSV_TraCuu_Click(object sender, EventArgs e)
        {
            TraCuuSinhVien();
        }

        private void btnQLPhong_ThemPhong_Click(object sender, EventArgs e)
        {
            Phong();
        }

     
        private void btn_Day_ThemDay_Click(object sender, EventArgs e)
        {
            Day();
        }

        private void btn_Day_ThemKTX_Click(object sender, EventArgs e)
        {
            KTX();
        }

        private void btnHeThong_DanhGia_Click(object sender, EventArgs e)
        {
            Cap();
        }

        private void btnQLSV_TraCuu_Chung_Click(object sender, EventArgs e)
        {
            TraCuuSinhVien();
        }

        private void btnQLPhong_ThemPhong_Click_1(object sender, EventArgs e)
        {
            Phong();
        }

        private void btnQLSV_TraCuu_Day_Click(object sender, EventArgs e)
        {
            if(cmbQLSV_TraCuu_Day.SelectedIndex>=0)
                TraCuuSinhVienTheoDay(cmbQLSV_TraCuu_Day.SelectedItem.ToString());
        }

        private void buttonItem55_Click(object sender, EventArgs e)
        {

        }

        private void btnQLSV_ThongKe_Click(object sender, EventArgs e)
        {
            if (cmbQLSV_ThongKe.SelectedIndex >= 0)
            {

                switch (cmbQLSV_ThongKe.SelectedItem.ToString())
                {
                    case "Phòng":
                        ThongKeSinhVienThuocPhong();
                        break;
                    case "Dãy":
                        ThongKeSinhVienThuocDay();
                        break;
                    case "KTX":
                        ThongKeSinhVienThuocKTX();
                        break;
                    case "":
                        MessageBox.Show("Chua chọn!");
                        break;


                }
            }
            else
            {
                MessageBox.Show("Chưa chọn loại thống kê");
            }

        }

        private void mnuQLPhong_ThongKe_Click(object sender, EventArgs e)
        {
            ThongKeSinhVienThuocPhong();
        }

        private void mnuQLDay_ThongKeDay_Click(object sender, EventArgs e)
        {
            ThongKeSinhVienThuocDay();
        }

        private void mnuQLDay_ThongKeKTX_Click(object sender, EventArgs e)
        {
            ThongKeSinhVienThuocKTX();
        }

        private void mnuQLSV_ChuyenPhong_Click(object sender, EventArgs e)
        {
            ChuyenPhongSinhVien();
        }

        private void mnuQLSV_DiemDanh_Click(object sender, EventArgs e)
        {
            DiemDanhSinhVien();
        }

        private void btnQLSV_QuanLy_DiemDanh_Click(object sender, EventArgs e)
        {

        }

        private void btnQLSV_QuanLy_DiemDanh_Click_1(object sender, EventArgs e)
        {
            DiemDanhSinhVien();
        }

        private void btn_HeThong_TonGiao_Click(object sender, EventArgs e)
        {
            TonGiao();
        }

        private void btn_HeThong_DanToc_Click(object sender, EventArgs e)
        {
            DanToc();
        }

        private void btn_HeThong_QuocTich_Click(object sender, EventArgs e)
        {
            QuocTich();
        }

        private void btnHeThong_CBQL_Click(object sender, EventArgs e)
        {
            CanBo();
        }

        private void mnuQLSV_DanhGia_Click(object sender, EventArgs e)
        {
            DanhGiaSinhVien();
        }

        private void btnHeThong_HoatDong_Click(object sender, EventArgs e)
        {
            HoatDong();
        }

        private void btnHeThong_KyLuat_Click(object sender, EventArgs e)
        {
            KyLuat();
        }

        private void btnHeThong_KhenThuong_Click(object sender, EventArgs e)
        {
            KhenThuong();
        }

        private void buttonItem28_Click(object sender, EventArgs e)
        {
            DanhGia();
        }

        private void buttonItem27_Click(object sender, EventArgs e)
        {
            XepLoai();
        }

        private void btnQLSV_KyLuat_Click(object sender, EventArgs e)
        {
            KyLuatSinhVien();
        }

        private void taskTab_TraCuuSinhVien_Click(object sender, EventArgs e)
        {

        }

        private void mnuTroGiup_TroGiup_Click(object sender, EventArgs e)
        {
            m_Help();
        }

        private void buttonItem61_Click(object sender, EventArgs e)
        {
            m_Help();
        }
        public void m_Help()
        {
            Help.ShowHelp(this, "help.chm");
        }
        private void labelItem17_Click(object sender, EventArgs e)
        {

        }

        private void btnHeThong_SaoLuu_Click(object sender, EventArgs e)
        {
            SaoLuu();
        }

        private void btnHeThong_PhucHoi_Click(object sender, EventArgs e)
        {
            PhucHoi();
        }

        private void tabExplorer_ExpandedChanged(object sender, ExpandedChangeEventArgs e)
        {
            if (tabExplorer.Expanded)
            {
                tabMainTool.Height = 118;
            }
            else
            {
                tabMainTool.Height = 27;
            }
        }

        
        private void tabMainTool_Click(object sender, EventArgs e)
        {
            if (tabMainTool.Height == 27)
            {
                tabExplorer.Expanded = true;
            }
        }

        private void btnQLSV_KhenThuong_Click(object sender, EventArgs e)
        {
            KhenThuongSinhVien();
        }

        private void btnQLSV_HoatDong_Click(object sender, EventArgs e)
        {
            HoatDongSinhVien();
        }

        private void btnQLPhong_DanhGiaPhong_NhapDiem_Click(object sender, EventArgs e)
        {
            NhapDiem();
        }

        private void btnQLSV_QuanLy_XepPhong_Click(object sender, EventArgs e)
        {
            XepPhongSinhVien();
        }

        private void btnQLPhong_DanhGiaPhong_DanhGia_Click(object sender, EventArgs e)
        {

        }

        private void btn_Day_KTX_Click(object sender, EventArgs e)
        {
            KTX();
        }

        private void barHeThong_NguoiDung_ItemClick(object sender, EventArgs e)
        {
            NguoiDung();
            
        }

        private void btnHeThong_NguoiDung_Click(object sender, EventArgs e)
        {

        }

        private void taskXP_NguoiDung_Click(object sender, EventArgs e)
        {
            NguoiDung();
        }

        private void mnuHeThong_NguoiDung_Click(object sender, EventArgs e)
        {

        }

        private void taskTab_DangXuat_Click(object sender, EventArgs e)
        {
            DangXuat();
        }

        private void taskTab_DiemDanh_Click(object sender, EventArgs e)
        {
            DiemDanhSinhVien();
        }

        private void taskTab_ThongTinPhong_Click(object sender, EventArgs e)
        {
            Phong();
        }

        private void taskTab_HoatDongSinhVien_Click(object sender, EventArgs e)
        {
            HoatDong();
        }

        private void taskTab_HoatDong_Click(object sender, EventArgs e)
        {
            HoatDong();
        }

        private void taskTab_DanhGia_Click(object sender, EventArgs e)
        {
            DanhGia();
        }

        private void taskTab_XepLoai_Click(object sender, EventArgs e)
        {
            XepLoai();
        }
        Phong.frmThongKeSinhVienThuocPhong rptPhong = null;
        private void buttonItem60_Click(object sender, EventArgs e)
        {

            if (rptPhong == null || rptPhong.IsDisposed)
                rptPhong = new Phong.frmThongKeSinhVienThuocPhong();
            rptPhong.MdiParent = this;
            rptPhong.Show();
            rptPhong.ThongKe_ThuocPhong(cmb_QLPHG_ThongKe_Phong.Text);
            rptPhong.Focus();
        }

        Day.frmThongKeSinhVienThuocDay rptDay = null;
        private void buttonItem62_Click(object sender, EventArgs e)
        {
            if (rptDay == null || rptDay.IsDisposed)
                rptDay = new Day.frmThongKeSinhVienThuocDay();
            rptDay.MdiParent = this;
            rptDay.Show();
            rptDay.ThongKe_ThuocDay(comboBoxItem15.Text);
            rptDay.Focus();
        }

        KTX.frmThongKeSinhVienThuocKTX rptKTX = null;
        private void buttonItem63_Click(object sender, EventArgs e)
        {
            if (rptKTX == null || rptKTX.IsDisposed)
                rptKTX = new KTX.frmThongKeSinhVienThuocKTX();
            rptKTX.MdiParent = this;
            rptKTX.Show();
            rptKTX.ThongKe_ThuocKTX(comboBoxItem15.Text);
            rptKTX.Focus();
        }

       

    }
}