using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYHOSONHANVIEN.GiaoDien;
using QUANLYHOSONHANVIEN.BusinessObject;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;

namespace QUANLYHOSONHANVIEN
{
    public partial class frmMainChinh : DevComponents .DotNetBar .Office2007Form
    {
        public frmMainChinh()
        {
            InitializeComponent();
        }
        DangNhapInfo thongtindn = null;
        frmDangNhap fdangnhap = new frmDangNhap();

        private void frmMainChinh_Load(object sender, EventArgs e)
        {
            txtHienThiGio.Text = System.DateTime.Now.ToLongTimeString();
            ribbonTabItemQuanLy.Checked = true;

            ribbonBarQuantrihethong.Enabled = true;
            ribbonBarquanlyhoso.Enabled = true;
            ribbonBarThongtin.Enabled = true;
            ribbonBarTimkiem.Enabled = true;
            expandablePanelThanhChucNang.Visible = true;
            btnDoimatkhau.Enabled = true;
            btnDanhSachnguoidung.Enabled = true;
            loadData();            
        }

        private void loadData()
        {            
            this.Text = "QUẢN LÝ HỒ SƠ NHÂN SỰ - ver 1.0";
            //MessageBox.Show(frmDangNhap.TenDangNhap);
            if (frmDangNhap.TenDangNhap != "")
            {
                btnHienthiUser.Text = "  Chào " + frmDangNhap.TenDangNhap + "  ";
                thongtindn = ThamSo.LayTTDangNhap(frmDangNhap.TenDangNhap.Trim());
                int i = Convert.ToInt32(thongtindn.quyen);
                //MessageBox.Show(i.ToString ());
                switch (i)
                {
                    case 1:
                        {
                            ribbonBarQuantrihethong.Enabled = true;
                            ribbonBarquanlyhoso.Enabled = true;
                            ribbonBarThongtin.Enabled = true;
                            ribbonBarTimkiem.Enabled = true;
                            expandablePanelThanhChucNang.Visible = true;
                            btnDoimatkhau.Enabled = true;
                            btnDanhSachnguoidung.Enabled = true;
                            sideBarPanelItemQuantrihethong.Visible = true ;
                            break;
                        }
                    case 2:
                        {
                            btnDanhSachnguoidung.Enabled = false;
                            btnThongtinCT.Enabled = false;
                            ribbonBarQuantrihethong.Enabled = false;
                            sideBarPanelItemQuantrihethong.Visible = false;
                            break;
                        }
                }
            }
            else
            {
                btnHienthiUser.Text = "  Bạn Chưa đăng nhập  ";
                ribbonBarQuantrihethong.Enabled = false;
                ribbonBarquanlyhoso.Enabled = false;
                ribbonBarThongtin.Enabled = false;
                ribbonBarTimkiem.Enabled = false;
                expandablePanelThanhChucNang.Visible = false;
                btnDoimatkhau.Enabled = false;
                btnDanhSachnguoidung.Enabled = false;

            }
        }
        frmThongTinNhanSu fthongtinns = null;

        private bool m_ColorSelected = false;
        private eOffice2007ColorScheme m_BaseColorScheme = eOffice2007ColorScheme.Blue;

        private void colorPickerDropDown1_ColorPreview(object sender, DevComponents.DotNetBar.ColorPreviewEventArgs e)
        {
            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, m_BaseColorScheme, e.Color);
        }

        private void colorPickerDropDown1_SelectedColorChanged(object sender, EventArgs e)
        {
            m_ColorSelected = true; // Indicate that color was selected for buttonStyleCustom_ExpandChange method
            colorPickerDropDown1.CommandParameter = colorPickerDropDown1.SelectedColor;
        }

        private void btnBlueSkin_Click(object sender, EventArgs e)
        {
            ribbonControl1.Office2007ColorTable = eOffice2007ColorScheme.Blue;
        }

        private void btnBlackSkin_Click(object sender, EventArgs e)
        {
            ribbonControl1.Office2007ColorTable = eOffice2007ColorScheme.Black;
        }

        private void btnSilverSkin_Click(object sender, EventArgs e)
        {
            ribbonControl1.Office2007ColorTable = eOffice2007ColorScheme.Silver;
        }

        private void btnThongtinCT_Click(object sender, EventArgs e)
        {
            frmCongTy fcongty = new frmCongTy();
            fcongty.ShowDialog();
        }

        private void btnSaoluuDL_Click(object sender, EventArgs e)
        {
            frmSaoLuuDuLieu f = new frmSaoLuuDuLieu();
            f.Show();
        }

        private void btnPhuchoidulieu_Click(object sender, EventArgs e)
        {
            frmPhucHoiDuLieu f = new frmPhucHoiDuLieu();
            f.ShowDialog();
            MessageBoxEx.Show("Bạn phải khởi động lại phần mềm sau khi phục hồi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            frmDangNhap fdangnhap = new frmDangNhap();
            fdangnhap.ShowDialog();
            loadData();
        }

        private void btnDanhSachnguoidung_Click(object sender, EventArgs e)
        {
            frmNguoiDung fnguoidung = new frmNguoiDung(frmDangNhap.TenDangNhap);
            fnguoidung.ShowDialog();
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau fdoimk = new frmDoiMatKhau(frmDangNhap.TenDangNhap);
            fdoimk.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtHienThiGio.Text = System.DateTime.Now.ToLongTimeString();
        }

        private void btnDanhsachphongban_Click(object sender, EventArgs e)
        {
            frmPhongBan fphongban = new frmPhongBan();
            fphongban.ShowDialog();
            //loadData();
        }

        private void btnThemphongbanmoi_Click(object sender, EventArgs e)
        {
            frmThemPhongBan fthempb = new frmThemPhongBan();
            fthempb.ShowDialog();
            //loadData();
        }

        private void btnHosonhansu_Click(object sender, EventArgs e)
        {
            if (fthongtinns == null || fthongtinns.IsDisposed)
            {
                fthongtinns = new frmThongTinNhanSu();
                fthongtinns.MdiParent = this;
                fthongtinns.Show();
            }
            else
                fthongtinns.Activate();
        }

        private void buttonItemBaoCaoDSNV_Click(object sender, EventArgs e)
        {
            frmBaoCao fBcao = new frmBaoCao(true);
            fBcao.ShowDialog();
        }
        //frmDanhSachDanhMuc fdsdm = null;
        private void buttonItemDanhMuc_Click(object sender, EventArgs e)
        {
            frmDanhSachDanhMuc fdsdm = new frmDanhSachDanhMuc();
            fdsdm.ShowDialog();
            loadData();
        }

        private void buttonItemBaoCaoTHCQT_Click(object sender, EventArgs e)
        {
            frmBaoCao fBcao = new frmBaoCao(false);
            fBcao.ShowDialog();
        }
    }
}
