using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shop_Manager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            string select = "select MaMatH Mã_hàng,TenMatH Tên_hàng,SoLuong Số_lượng,DonGia Đơn_giá,GiaBan Giá_bán from tblMatHang where MaMatH=N'" + values + "'";
            //string select = "select MaMatH Mã_hàng,TenMatH Tên_hàng,SoLuong Số_lượng,DonGia Đơn_giá from tblMatHang";
            //string select = "select * from v_GiaBan where [Tên mặt hàng]=N'" + cboMaMatH.Text + "'";
            try
            {
                if (cboMaMatH.Text == "")
                {
                    throw new NotEnoughInfoException();
                }
                DataSet ds = DataConn.GrdSource(select);
                grdKetQua.DataSource = ds.Tables[0];
                grdKetQua.Refresh();
            }
            catch (FormatException)
            {
                MessageBox.Show("Không đúng định dạng cần thiết! Hãy xem trợ giúp!");
            }
            catch (NotEnoughInfoException)
            {
                MessageBox.Show("Bạn hãy chọn một mặt hàng nào đó!");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string select = "select* from tblMatHang";
            DataSet ds = DataConn.GrdSource(select);
            cboMaMatH.DataSource = ds.Tables[0];
            cboMaMatH.DisplayMember = "TenMatH";
            cboMaMatH.ValueMember = "MaMatH";
            //txtMaMatH.Text = "";

            //Ẩn 1 số Menu khi không phải admin
            mặtHàngToolStripMenuItem.Enabled = false;
            //hóaĐơnNhậpToolStripMenuItem.Enabled = false;
            //hoáĐơnToolStripMenuItem.Enabled = false;
            nhânVienToolStripMenuItem.Enabled = false;
            nhàCungCấpToolStripMenuItem.Enabled = false;
            đăngNhậpToolStripMenuItem.Enabled = true;
            nhậpHàngToolStripMenuItem1.Enabled = false;
            xuấtHàngToolStripMenuItem1.Enabled = false;
            doanhThuToolStripMenuItem.Enabled = false;
            tồnKhoToolStripMenuItem.Enabled = false;
            đăngXuấtToolStripMenuItem.Enabled = false;
            đổiMậtKhẩuToolStripMenuItem.Enabled = false;
            thêmNgườiDùngToolStripMenuItem.Enabled = false;
            khôiPhụcToolStripMenuItem.Enabled = false;

            hóaĐơnNhậpToolStripMenuItem.Enabled = true;
            danhSáchHóaĐơnToolStripMenuItem.Enabled = false;
            hóaĐơnXuấtToolStripMenuItem.Enabled = true;
            danhSáchHóađơnToolStripMenuItem1.Enabled = false;

            phiếuĐặtHàngToolStripMenuItem.Enabled = true;
            danhSáchPhiếuToolStripMenuItem.Enabled = false;
        }

        string values = "";
        private void cboMaMatH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMaMatH.ValueMember != null)
            {
                values = cboMaMatH.SelectedValue.ToString();
                btnThongTin_Click(sender, e);
            }
        }

        //private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmNhap nhaphang = new frmNhap();
        //    nhaphang.ShowDialog();
        //}

        //private void xuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmXuatHang xuathang = new frmXuatHang();
        //    xuathang.ShowDialog();
        //}

        //private void đặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmDatHang dathang = new frmDatHang();
        //    dathang.ShowDialog();
        //}

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMatHang mathang = new frmMatHang();
            mathang.ShowDialog();

            string select = "select* from tblMatHang";
            DataSet ds = DataConn.GrdSource(select);
            cboMaMatH.DataSource = ds.Tables[0];
            cboMaMatH.DisplayMember = "TenMatH";
            cboMaMatH.ValueMember = "MaMatH";
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmHDN hoadonnhap = new frmHDN();
            //hoadonnhap.ShowDialog();
        }

        private void hoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmHDX hoadonxuat = new frmHDX();
            //hoadonxuat.ShowDialog();
        }

        private void nhânVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien nhanvien = new frmNhanVien();
            nhanvien.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap nhacungcap = new frmNhaCungCap();
            nhacungcap.ShowDialog();
        }

        private void cáchSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Application.ExecutablePath;
            path = path.Substring(0, path.LastIndexOf(@"\")) + @"\Shop_Manager-Help.chm";
            Help.ShowHelp(this, path);
        }

        private void nhậpHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBaocaoHDN baocaoHDN = new frmBaocaoHDN();
            baocaoHDN.ShowDialog();
        }

        private void xuấtHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBaocaoHDX baocaoHDX = new frmBaocaoHDX();
            baocaoHDX.ShowDialog();
        }

        private void tồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaocaoTonkho baocaoTK = new frmBaocaoTonkho();
            baocaoTK.ShowDialog();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmDoanhThu dt = new frmDoanhThu();
            //dt.ShowDialog();
            frmHoTroThongBaoDoanhThu ht = new frmHoTroThongBaoDoanhThu();
            ht.ShowDialog();
        }

        private void grdKetQua_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.grdKetQua.RowCount > 0)
            {
                if (this.grdKetQua.CurrentCell == null)
                {
                    return;
                }
                if (this.grdKetQua.CurrentCell.RowIndex < this.grdKetQua.RowCount)
                {
                    int hang = this.grdKetQua.CurrentCell.RowIndex;
                    string select = "select TenMatH from tblMatHang where MaMatH=N'" + this.grdKetQua.Rows[hang].Cells[0].Value.ToString() + "'";
                    DataSet ds = DataConn.GrdSource(select);
                    cboMaMatH.Text = ds.Tables[0].Rows[0]["TenMatH"].ToString();
                }
                else
                    return;
            }
        }

        public void DisplayAll()
        {
            mặtHàngToolStripMenuItem.Enabled = true;
            //hóaĐơnNhậpToolStripMenuItem.Enabled = true;
            //hoáĐơnToolStripMenuItem.Enabled = true;
            nhânVienToolStripMenuItem.Enabled = true;
            nhàCungCấpToolStripMenuItem.Enabled = true;
            đăngNhậpToolStripMenuItem.Enabled = true;
            nhậpHàngToolStripMenuItem1.Enabled = true;
            xuấtHàngToolStripMenuItem1.Enabled = true;
            doanhThuToolStripMenuItem.Enabled = true;
            tồnKhoToolStripMenuItem.Enabled = true;
            đăngXuấtToolStripMenuItem.Enabled = true;
            đổiMậtKhẩuToolStripMenuItem.Enabled = true;
            thêmNgườiDùngToolStripMenuItem.Enabled = true;
            khôiPhụcToolStripMenuItem.Enabled = true;

            hóaĐơnNhậpToolStripMenuItem.Enabled = true;
            danhSáchHóaĐơnToolStripMenuItem.Enabled = true;
            hóaĐơnXuấtToolStripMenuItem.Enabled = true;
            danhSáchHóađơnToolStripMenuItem1.Enabled = true;

            phiếuĐặtHàngToolStripMenuItem.Enabled = true;
            danhSáchPhiếuToolStripMenuItem.Enabled = true;
        }

        public void NotDisplayAll()
        {
            mặtHàngToolStripMenuItem.Enabled = false;
            //hóaĐơnNhậpToolStripMenuItem.Enabled = false;
            //hoáĐơnToolStripMenuItem.Enabled = false;
            nhânVienToolStripMenuItem.Enabled = false;
            nhàCungCấpToolStripMenuItem.Enabled = false;
            đăngNhậpToolStripMenuItem.Enabled = true;
            nhậpHàngToolStripMenuItem1.Enabled = false;
            xuấtHàngToolStripMenuItem1.Enabled = false;
            doanhThuToolStripMenuItem.Enabled = false;
            tồnKhoToolStripMenuItem.Enabled = false;
            đăngXuấtToolStripMenuItem.Enabled = false;
            đổiMậtKhẩuToolStripMenuItem.Enabled = false;
            thêmNgườiDùngToolStripMenuItem.Enabled = false;
            khôiPhụcToolStripMenuItem.Enabled = false;

            hóaĐơnNhậpToolStripMenuItem.Enabled = true;
            danhSáchHóaĐơnToolStripMenuItem.Enabled = false;
            hóaĐơnXuấtToolStripMenuItem.Enabled = true;
            danhSáchHóađơnToolStripMenuItem1.Enabled = false;

            phiếuĐặtHàngToolStripMenuItem.Enabled = true;
            danhSáchPhiếuToolStripMenuItem.Enabled = false;
        }

        private void DangNhaptoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap dangnhap = new frmDangNhap(this);
            dangnhap.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap dangnhap = new frmDangNhap(this);
            dangnhap.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap dangnhap = new frmDangNhap(this);
            dangnhap.btnThoatDN_Click(sender, e);
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiPass doipass = new frmDoiPass();
            doipass.ShowDialog();
        }

        private void thêmNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemNguoiDung themuser = new frmThemNguoiDung();
            themuser.ShowDialog();
        }

        private void khôiPhụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string backup = "USE Northwind RESTORE DATABASE qlbh FROM DISK=N'D:\\qlbh_saoluu' WITH REPLACE";
                if (MessageBox.Show("Khi khôi phục dữ liệu, tất cả các dữ liệu đã bị thay đổi sẽ trở lại như cũ. Bạn có chắc chắn muốn khôi phục dữ liệu không?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataConn.ThucHienCmd(backup);
                    MessageBox.Show("Đã khôi phục dữ liệu!","Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex.Message);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void nhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhap nhaphang = new frmNhap();
            nhaphang.ShowDialog();
        }

        private void xuấtHàngToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmXuatHang xuathang = new frmXuatHang();
            xuathang.ShowDialog();
        }

        private void đặtHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDatHang dathang = new frmDatHang();
            dathang.ShowDialog();
        }

        private void trợGiúpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string path = Application.ExecutablePath;
            path = path.Substring(0, path.LastIndexOf(@"\")) + @"\Shop_Manager-Help.chm";
            Help.ShowHelp(this, path);
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmNhap nhaphang = new frmNhap();
            nhaphang.ShowDialog();
        }

        private void hóaĐơnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXuatHang xuathang = new frmXuatHang();
            xuathang.ShowDialog();
        }

        private void danhSáchHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachHDN ds = new frmDanhSachHDN();
            ds.ShowDialog();
        }

        private void danhSáchHóađơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDanhSachHDX ds = new frmDanhSachHDX();
            ds.ShowDialog();
        }

        private void phiếuĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatHang dathang = new frmDatHang();
            dathang.ShowDialog();
        }

        private void danhSáchPhiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachPhieuDatHang ds = new frmDanhSachPhieuDatHang();
            ds.ShowDialog();
        }
    }
    public class NotEnoughInfoException : ApplicationException
    {
        public NotEnoughInfoException()
            : base()
        {
        }
    }
    public class SameKeyException : ApplicationException
    {
        public SameKeyException()
            : base()
        {
        }
    }
    public class OutOfQuantityException : ApplicationException
    {
        public OutOfQuantityException()
            : base()
        {
        }
    }
    public class TimeLogicException : ApplicationException
    {
        public TimeLogicException()
            : base()
        {
        }
    }
    public class SameProductKey : ApplicationException
    {
        public SameProductKey()
            : base()
        {
        }
    }
}