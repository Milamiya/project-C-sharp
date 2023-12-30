using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using GiaoDienCuaHang.Controller;

namespace GiaoDienCuaHang
{
    public partial class FormMain : Form
    {
        frmTonKho tonk = null;
        frmThongKeTonKho tktkho = null;
        fKhachHang kh = null;
        fNhaCungCap ncc = null;
        fHangHoa hh = null;
        frmDonViTinh dvt = null;
        fLapPhieuBanHang pbh = null;
        frmLapPhieuDatHang pdh = null;
        frmLapPhieuNhanHang pnh = null;
        frmLapPhieuSuCo psc = null;
        FormTTPM ttpm = null;
        frmTimKiemKhachHang tkkh = null;
        frmTimKiemNhaCungCap tkncc = null;
        frmTimKiemHangHoa tkhh = null;
        frmTimKiemDVT tkdvt = null;
        frmTimKiemPhieuBanHang tkpbh = null;
        frmTimKiemPhieuDatHang tkpdh = null;
        frmTimKiemPhieuNhanHang tkpnh = null;
        fNhanVien nv = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void DNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap dangnhap = new frmDangNhap();
            dangnhap.textBoxU.Text = "";
            dangnhap.textBoxP.Text = "";
            if (dangnhap.ShowDialog() == DialogResult.OK)
            {
                string username = dangnhap.textBoxU.Text;
                string password = dangnhap.textBoxP.Text;
                NhanVienController nv = new NhanVienController();
                int ketqua = nv.Dangnhap(username, password);
                if (ketqua == 0)
                {
                    MessageBox.Show("Không tồn tại người dùng này!");
                    disable_menu();
                }
                else
                {
                    if (ketqua == 1)
                    {
                        MessageBox.Show("Sai mật khẩu!");
                        disable_menu();
                    }
                    else
                    {
                        phanquyen(Utilities.nhanvien.loainv.MaloaiNV);

                    }
                }
            }
        }

        private void DXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disable_menu();
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kh == null || kh.IsDisposed)
                kh = new fKhachHang();
            kh.MdiParent = this;
            kh.Show();
        }

        private void NCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ncc == null || ncc.IsDisposed)
                ncc = new fNhaCungCap();
            ncc.MdiParent = this;
            ncc.Show();
        }

        private void HHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hh == null || hh.IsDisposed)
                hh = new fHangHoa();
            hh.MdiParent = this;
            hh.Show();
        }

        private void DVTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dvt == null || dvt.IsDisposed)
                dvt = new frmDonViTinh();
            dvt.MdiParent = this;
            dvt.Show();
        }

        private void toolStripButtonKH_Click(object sender, EventArgs e)
        {
            if (kh == null || kh.IsDisposed)
                kh = new fKhachHang();
            kh.MdiParent = this;
            kh.Show();
        }

        private void toolStripButtonNCC_Click(object sender, EventArgs e)
        {
            if (ncc == null || ncc.IsDisposed)
                ncc = new fNhaCungCap();
            ncc.MdiParent = this;
            ncc.Show();
        }

        private void toolStripButtonHH_Click(object sender, EventArgs e)
        {
            if (hh == null || hh.IsDisposed)
                hh = new fHangHoa();
            hh.MdiParent = this;
            hh.Show();
        }

        private void taskItemKH_Click(object sender, EventArgs e)
        {
            if (kh == null || kh.IsDisposed)
                kh = new fKhachHang();
            kh.MdiParent = this;
            kh.Show();
        }

        private void taskItemNCC_Click(object sender, EventArgs e)
        {
            if (ncc == null || ncc.IsDisposed)
                ncc = new fNhaCungCap();
            ncc.MdiParent = this;
            ncc.Show();
        }

        private void taskItemHH_Click(object sender, EventArgs e)
        {
            if (hh == null || hh.IsDisposed)
                hh = new fHangHoa();
            hh.MdiParent = this;
            hh.Show();
        }

        private void taskItemDVT_Click(object sender, EventArgs e)
        {
            if (dvt == null || dvt.IsDisposed)
                dvt = new frmDonViTinh();
            dvt.MdiParent = this;
            dvt.Show();
        }

        private void BHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pbh == null || pbh.IsDisposed)
                pbh = new fLapPhieuBanHang();
            pbh.MdiParent = this;
            pbh.Show();
        }

        private void DHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pdh == null || pdh.IsDisposed)
                pdh = new frmLapPhieuDatHang();
            pdh.MdiParent = this;
            pdh.Show();
        }

        private void NHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pnh == null || pnh.IsDisposed)
                pnh = new frmLapPhieuNhanHang();
            pnh.MdiParent = this;
            pnh.Show();
        }

        private void SCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (psc == null || psc.IsDisposed)
                psc = new frmLapPhieuSuCo();
            psc.MdiParent = this;
            psc.Show();
        }

        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ttpm == null || ttpm.IsDisposed)
                ttpm = new FormTTPM();
            ttpm.MdiParent = this;
            ttpm.Show();
        }

        private void toolStripButtonPBH_Click(object sender, EventArgs e)
        {
            if (pbh == null || pbh.IsDisposed)
                pbh = new fLapPhieuBanHang();
            pbh.MdiParent = this;
            pbh.Show();
        }

        private void toolStripButtonPDH_Click(object sender, EventArgs e)
        {
            if (pdh == null || pdh.IsDisposed)
                pdh = new frmLapPhieuDatHang();
            pdh.MdiParent = this;
            pdh.Show();
        }

        private void toolStripButtonPNH_Click(object sender, EventArgs e)
        {
            if (pnh == null || pnh.IsDisposed)
                pnh = new frmLapPhieuNhanHang();
            pnh.MdiParent = this;
            pnh.Show();
        }

        private void taskItemBH_Click(object sender, EventArgs e)
        {
            if (pbh == null || pbh.IsDisposed)
                pbh = new fLapPhieuBanHang();
            pbh.MdiParent = this;
            pbh.Show();
        }

        private void taskItemDH_Click(object sender, EventArgs e)
        {
            if (pdh == null || pdh.IsDisposed)
                pdh = new frmLapPhieuDatHang();
            pdh.MdiParent = this;
            pdh.Show();
        }

        private void taskItemNH_Click(object sender, EventArgs e)
        {
            if (pnh == null || pnh.IsDisposed)
                pnh = new frmLapPhieuNhanHang();
            pnh.MdiParent = this;
            pnh.Show();
        }

        private void taskItemSC_Click(object sender, EventArgs e)
        {
            if (psc == null || psc.IsDisposed)
                psc = new frmLapPhieuSuCo();
            psc.MdiParent = this;
            psc.Show();
        }



        private void TKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tkkh == null || tkkh.IsDisposed)
                tkkh = new frmTimKiemKhachHang();
            tkkh.MdiParent = this;
            tkkh.Show();
        }

        private void TNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tkncc == null || tkncc.IsDisposed)
                tkncc = new frmTimKiemNhaCungCap();
            tkncc.MdiParent = this;
            tkncc.Show();
        }

        private void THHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tkhh == null || tkhh.IsDisposed)
                tkhh = new frmTimKiemHangHoa();
            tkhh.MdiParent = this;
            tkhh.Show();
        }

        private void TDVTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tkdvt == null || tkdvt.IsDisposed)
                tkdvt = new frmTimKiemDVT();
            tkdvt.MdiParent = this;
            tkdvt.Show();
        }

        private void TPBHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tkpbh == null || tkpbh.IsDisposed)
                tkpbh = new frmTimKiemPhieuBanHang();
            tkpbh.MdiParent = this;
            tkpbh.Show();
        }

        private void TPDHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tkpdh == null || tkpdh.IsDisposed)
                tkpdh = new frmTimKiemPhieuDatHang();
            tkpdh.MdiParent = this;
            tkpdh.Show();
        }

        private void TPNHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tkpnh == null || tkpnh.IsDisposed)
                tkpnh = new frmTimKiemPhieuNhanHang();
            tkpnh.MdiParent = this;
            tkpnh.Show();
        }

        private void toolStripButtonTKH_Click(object sender, EventArgs e)
        {
            if (tkkh == null || tkkh.IsDisposed)
                tkkh = new frmTimKiemKhachHang();
            tkkh.MdiParent = this;
            tkkh.Show();
        }

        private void toolStripButtonTNCC_Click(object sender, EventArgs e)
        {
            if (tkncc == null || tkncc.IsDisposed)
                tkncc = new frmTimKiemNhaCungCap();
            tkncc.MdiParent = this;
            tkncc.Show();
        }

        private void HienThitaskPaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HienThitaskPaneToolStripMenuItem.Checked == true)
            {
                HienThitaskPaneToolStripMenuItem.Checked = false;
                taskPane1.Visible = false;
            }
            else
            {
                HienThitaskPaneToolStripMenuItem.Checked = true;
                taskPane1.Visible = true;
            }
        }

        private void thongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeKhachHang tkkh1 = new frmThongKeKhachHang();
            tkkh1.Show();

        }

        private void TKHHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeHangHoatheoDVT tkhh = new frmThongKeHangHoatheoDVT();
            tkhh.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nv == null || nv.IsDisposed)
                nv = new fNhanVien();
            nv.MdiParent = this;
            nv.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            frmDangNhap dangnhap = new frmDangNhap();
            dangnhap.textBoxU.Text = "";
            dangnhap.textBoxP.Text = "";
            if (dangnhap.ShowDialog() == DialogResult.OK)
            {
                string username = dangnhap.textBoxU.Text;
                string password = dangnhap.textBoxP.Text;
                NhanVienController nv = new NhanVienController();
                int ketqua = nv.Dangnhap(username, password);
                if (ketqua == 0)
                {
                    MessageBox.Show("Không tồn tại người dùng này!","Thong bao",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    disable_menu();
                    
                }
                else
                {
                    if (ketqua == 1)
                    {
                        MessageBox.Show("Sai mật khẩu!");
                        disable_menu();
                    }
                    else
                    {
                        phanquyen(Utilities.nhanvien.loainv.MaloaiNV);
                        //dangnhap.Dispose();
                    }
                }
            }
        }

        private void disable_menu()
        {
            int i = 0;
            foreach (ToolStripMenuItem menuitem in menuStrip1.Items)
            {

                if ( i == 1 || i == 2 || i == 3 || i == 5 || i==4||i == 6)
                    menuitem.Enabled = false;
                else
                    menuitem.Enabled = true;
                i++;
            }
            i = 0;
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.Enabled = false;
            }
            i = 0;
            foreach (ToolStripMenuItem mnuitem in ToolStripMenuItemCT.DropDownItems)
            {

                if (i == 0)
                    mnuitem.Enabled = true;
                else
                    mnuitem.Enabled = false;
                i++;
            }
            foreach (XPExplorerBar.TaskItem item in expandoQL.Items)
            {
                item.Enabled = false;
            }

            foreach (XPExplorerBar.TaskItem item in expandoLP.Items)
            {
                item.Enabled = false;
            }

        }

        private void phanquyen(string Phanquyen)
        {
            switch (Phanquyen)
            {
                case "MNV001": QUANLY();
                    break;
                case "MNV002": BANHANG();
                    break;
                default:
                    disable_menu();
                    break;
            }
        }

        private void BANHANG()
        {
            
            int i = 0;
            foreach (ToolStripMenuItem mnuitem in menuStrip1.Items)
            {


                if (i == 4)
                    mnuitem.Enabled = false;
                else
                    mnuitem.Enabled = true;
                i++;


            }
            i = 0;
            foreach (ToolStripMenuItem mnuitem in TTToolStripMenuItem.DropDownItems)
            {

                if (i == 7 || i == 8 || i == 9 || i == 10 || i == 11 || i == 12 || i == 13 || i == 14 || i == 15 || i == 16)
                    mnuitem.Enabled = false;
                else
                    mnuitem.Enabled = true;
                i++;
            }
            i = 0;
            foreach (ToolStripMenuItem mnuitem in QLToolStripMenuItem.DropDownItems)
            {

                if (i == 1 || i == 2 || i == 4||i==5)
                    mnuitem.Enabled = false;
                else
                    mnuitem.Enabled = true;
                i++;
            }
            i = 0;
            foreach (ToolStripMenuItem mnuitem in LPToolStripMenuItem.DropDownItems)
            {

                if (i == 1 || i == 2)
                    mnuitem.Enabled = false;
                else
                    mnuitem.Enabled = true;
                i++;
            }
            i = 0;
            foreach (ToolStripMenuItem mnuitem in ToolStripMenuItemCT.DropDownItems)
            {

                if (i == 1||i==4)
                    mnuitem.Enabled = true;
                else
                    mnuitem.Enabled = false;
                i++;
            }


            i = 0;
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                if (i == 1 || i == 2 || i == 4 || i == 5 || i == 7)
                {
                    item.Enabled = false;
                }
                else
                    item.Enabled = true;
                i++;
            }
            i = 0;
            foreach (XPExplorerBar.TaskItem item in expandoQL.Items)
            {
                if (i == 1 || i == 2 )
                {
                    item.Enabled = false;
                }
                else
                    item.Enabled = true;
                i++;
                
            }

            foreach (XPExplorerBar.TaskItem item in expandoLP.Items)
            {
                if (i == 0 || i == 3)
                {
                    item.Enabled = true;
                }
                else
                    item.Enabled = false;
                i++;
                //item.Enabled = true;
            }

        }

        private void QUANLY()
        {
            foreach (ToolStripMenuItem menuItem in menuStrip1.Items)
            {
                menuItem.Enabled = true;

            }
            int i = 0;
            foreach (ToolStripMenuItem mnuitem in ToolStripMenuItemCT.DropDownItems)
            {

                if (i == 0)
                    mnuitem.Enabled = false;
                else
                    mnuitem.Enabled = true;
                i++;
            }
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.Enabled = true;

            }
            foreach (XPExplorerBar.TaskItem item in expandoQL.Items)
            {
                item.Enabled = true;
            }
            foreach (XPExplorerBar.TaskItem item in expandoLP.Items)
            {
                item.Enabled = true;
            }

        }

        private void tknvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeNhanVien tknv1 = new frmThongKeNhanVien();
            tknv1.Show();

        }

        private void TKNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeNhaCungCap tkncc1 = new frmThongKeNhaCungCap();
            tkncc1.Show();
        }

        private void TKTKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tktkho == null || tktkho.IsDisposed)
                tktkho = new frmThongKeTonKho();
            tktkho.MdiParent = this;
            tktkho.Show();
        }

        private void thốngKêĐơnVịTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeDonViTinh tkdvt = new frmThongKeDonViTinh();
            tkdvt.Show();
        }

        private void thốngKêPhiếuBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKePhieuBanHang tkpbh = new frmThongKePhieuBanHang();
            tkpbh.Show();
        }

        private void thốngKêPhiếuNhậnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKePhieuNhanHang tkpnh = new frmThongKePhieuNhanHang();
            tkpnh.Show();
        }

        private void thốngKêPhiếuĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKePhieuDatHang tkpdh = new frmThongKePhieuDatHang();
            tkpdh.Show();
        }

        private void thốngKêPhiếuSựCốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKePhieuSuCo tkpsc = new frmThongKePhieuSuCo();
            tkpsc.Show();
        }

        private void saoChépDựPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            if (s.ShowDialog() == DialogResult.OK)
            {

                string sql = " backup database QLCHmoi to disk='" + s.FileName.ToString() + "'";
                DataService dt = new DataService();
                SqlCommand cm = new SqlCommand(sql);
                dt.Load(cm);
                MessageBox.Show("Sao Lưu thành công");
            }
        }

        private void khôiPhụcDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                string sql = " use master restore database QLCHmoi from disk='" + op.FileName.ToString() + "'";
                DataService dt = new DataService();
                SqlCommand cm = new SqlCommand(sql);
                dt.Load(cm);
                MessageBox.Show("Phục hồi dữ liệu thành công");
            }
        }

        private void tồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tonk == null || tonk.IsDisposed)
                tonk = new frmTonKho();
            tonk.MdiParent = this;
            tonk.Show();
        }

        private void HDSDToolStripMenuItem_Click(object sender, EventArgs e)
        {

           Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }

        private void TGToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}