using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYHOSONHANVIEN.GiaoDien;

namespace QUANLYHOSONHANVIEN.GiaoDien
{
    public partial class frmDanhSachDanhMuc : DevComponents.DotNetBar.Office2007Form
    {
        public frmDanhSachDanhMuc()
        {
            InitializeComponent();
        }

        private void frmDanhSachDanhMuc_Load(object sender, EventArgs e)
        {

        }
        frmThemCongViec fthemcviec = null;
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            if (fthemcviec == null || fthemcviec.IsDisposed)
            {
                fthemcviec = new frmThemCongViec();
                fthemcviec.MdiParent = this;
                fthemcviec.Show();
            }
            else
                fthemcviec.Activate();
        }
        frmThemChucVu fthemcvu = null;
        private void buttonItem2_Click(object sender, EventArgs e)
        {
            if (fthemcvu == null || fthemcvu.IsDisposed)
            {
                fthemcvu = new frmThemChucVu();
                fthemcvu.MdiParent = this;
                fthemcvu.Show();
            }
            else
                fthemcvu.Activate();
        }
        frmThemChuyenNganh fthemcnganh = null;
        private void buttonItem3_Click(object sender, EventArgs e)
        {
            if (fthemcnganh == null || fthemcnganh.IsDisposed)
            {
                fthemcnganh = new frmThemChuyenNganh();
                fthemcnganh.MdiParent = this;
                fthemcnganh.Show();
            }
            else
                fthemcnganh.Activate();
        }
        frmThemDotDaoTao fthemddtao = null;
        private void buttonItem6_Click(object sender, EventArgs e)
        {
            if (fthemddtao == null || fthemddtao.IsDisposed)
            {
                fthemddtao = new frmThemDotDaoTao();
                fthemddtao.MdiParent = this;
                fthemddtao.Show();
            }
            else
                fthemddtao.Activate();
        }
        frmThemHinhThucKyLuat fthemhtkluat = null;
        private void buttonItem8_Click(object sender, EventArgs e)
        {
            if (fthemhtkluat == null || fthemhtkluat.IsDisposed)
            {
                fthemhtkluat = new frmThemHinhThucKyLuat();
                fthemhtkluat.MdiParent = this;
                fthemhtkluat.Show();
            }
            else
                fthemhtkluat.Activate();
        }
        frmThemDotDanhGia fthemddgia = null;
        private void buttonItem9_Click(object sender, EventArgs e)
        {
            if (fthemddgia == null || fthemddgia.IsDisposed)
            {
                fthemddgia = new frmThemDotDanhGia();
                fthemddgia.MdiParent = this;
                fthemddgia.Show();
            }
            else
                fthemddgia.Activate();
        }
        frmThemNganhHoc fthemnhoc = null;
        private void buttonItem11_Click(object sender, EventArgs e)
        {
            if (fthemnhoc == null || fthemnhoc.IsDisposed)
            {
                fthemnhoc = new frmThemNganhHoc();
                fthemnhoc.MdiParent = this;
                fthemnhoc.Show();
            }
            else
                fthemnhoc.Activate();
        }
        frmThemNgheghiep fthemnnghiep = null;
        private void buttonItem12_Click(object sender, EventArgs e)
        {
            if (fthemnnghiep == null || fthemnnghiep.IsDisposed)
            {
                fthemnnghiep = new frmThemNgheghiep();
                fthemnnghiep.MdiParent = this;
                fthemnnghiep.Show();
            }
            else
                fthemnnghiep.Activate();
        }
        frmThemNgoaiNgu fthemnngu = null;
        private void buttonItem13_Click(object sender, EventArgs e)
        {
            if (fthemnngu == null || fthemnngu.IsDisposed)
            {
                fthemnngu = new frmThemNgoaiNgu();
                fthemnngu.MdiParent = this;
                fthemnngu.Show();
            }
            else
                fthemnngu.Activate();
        }
        frmThemTrinhDoTinHoc fthemthoc = null;
        private void buttonItem14_Click(object sender, EventArgs e)
        {
            if (fthemthoc == null || fthemthoc.IsDisposed)
            {
                fthemthoc = new frmThemTrinhDoTinHoc();
                fthemthoc.MdiParent = this;
                fthemthoc.Show();
            }
            else
                fthemthoc.Activate();
        }
        frmThemTrinhDo fthemtDO = null;
        private void buttonItem15_Click(object sender, EventArgs e)
        {
            if (fthemtDO == null || fthemtDO.IsDisposed)
            {
                fthemtDO = new frmThemTrinhDo();
                fthemtDO.MdiParent = this;
                fthemtDO.Show();
            }
            else
                fthemtDO.Activate();
        }
        frmThemVanBang fthemvbang = null;
        private void buttonItem16_Click(object sender, EventArgs e)
        {
            if (fthemvbang == null || fthemvbang.IsDisposed)
            {
                fthemvbang = new frmThemVanBang();
                fthemvbang.MdiParent = this;
                fthemvbang.Show();
            }
            else
                fthemvbang.Activate();
        }
        frmThemLoaiHopDong fthemlhdong = null;
        private void buttonItemLoaiHD_Click(object sender, EventArgs e)
        {
            if (fthemlhdong == null || fthemlhdong.IsDisposed)
            {
                fthemlhdong = new frmThemLoaiHopDong();
                fthemlhdong.MdiParent = this;
                fthemlhdong.Show();
            }
            else
                fthemlhdong.Activate();
        }
        frmThemHinhThucDaoTao fthemhtdtao = null;
        private void buttonItem7_Click(object sender, EventArgs e)
        {
            if (fthemhtdtao == null || fthemhtdtao.IsDisposed)
            {
                fthemhtdtao = new frmThemHinhThucDaoTao();
                fthemhtdtao.MdiParent = this;
                fthemhtdtao.Show();
            }
            else
                fthemhtdtao.Activate();
        }
        frmThemHinhThucKhenThuong fthemhtkthuong = null;
        private void buttonItemKhenThuong_Click(object sender, EventArgs e)
        {
            if (fthemhtkthuong == null || fthemhtkthuong.IsDisposed)
            {
                fthemhtkthuong = new frmThemHinhThucKhenThuong();
                fthemhtkthuong.MdiParent = this;
                fthemhtkthuong.Show();
            }
            else
                fthemhtkthuong.Activate();
        }
        frmThemPhuCap fthempcap = null;
        private void buttonItemPhuCap_Click(object sender, EventArgs e)
        {
            if (fthempcap == null || fthempcap.IsDisposed)
            {
                fthempcap = new frmThemPhuCap(true);
                fthempcap.MdiParent = this;
                fthempcap.Show();
            }
            else
                fthempcap.Activate();
        }


    }
}
