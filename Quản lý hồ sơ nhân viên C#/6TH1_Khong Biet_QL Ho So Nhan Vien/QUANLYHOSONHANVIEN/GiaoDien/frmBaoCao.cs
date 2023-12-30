using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYHOSONHANVIEN.Controller;
using QUANLYHOSONHANVIEN.Report;

namespace QUANLYHOSONHANVIEN.GiaoDien
{
    public partial class frmBaoCao : DevComponents.DotNetBar .Office2007Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }
        public frmBaoCao(bool d):this()
        {
            if (d == true)
            {
                buttonItemDanhSachNV.Checked = true;
            }
            else
            {
                buttonItemTongHopQuaTrinh.Checked = true;
            }
        }
        BaoCaoCtr ctr = new BaoCaoCtr();
        int i = 0;
        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            loadDataNV();
            loadDataTongHop();
            cmb.SelectedIndexChanged += new EventHandler(cmb_SelectedIndexChanged);
        }

        void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmb.SelectedValue.ToString ());
        }
        
        private void loadDataTongHop()
        {
            labelItemTen.Text = "Tên Ngoại Ngữ :";
            ctr.HienThiAutoComboboxNGOAINGU(cmb);
            cmb.SelectedValue = "%";     
        }

        private void loadDataNV()
        {
            ctr.HienThiPhongBanComBoBox(cmbPhongban);
            cmbPhongban.SelectedValue = "%";            
        }
        frmInDanhSachNhanVien inDSNV = null;
        frmInNhanVienNgoaiNgu inNVNN = null;
        frmInDanhSachDotDaoTao inDSDDT = null;
        frmInDanhSachDanhGia inDSDDG = null;
        frmBaoCaoNhanVienChuyenMon inBCNVCM = null;
        frmInNhanVienTheoNgheNghiep inBCTHEONN = null;
        frmBaoCaoNhanVienPhongBan inBCNVPHONGBAN = null;

        private void buttonItemBaocaoNV_Click(object sender, EventArgs e)
        {
                        //if (inDSNV == null || inDSNV.IsDisposed)
            //{
                inDSNV = new frmInDanhSachNhanVien(cmbPhongban.SelectedValue.ToString());
                inDSNV.MdiParent = this;
                inDSNV.Show();
            //}
            //else
            //    inDSNV.Activate();
        }

        private void buttonItemBaoCaoTongHop_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    {
                        inNVNN = new frmInNhanVienNgoaiNgu(cmb.SelectedValue.ToString());
                        inNVNN.MdiParent = this;
                        inNVNN.Show();
                        break;
                    }
                case 1:
                    {
                        inDSDDT = new frmInDanhSachDotDaoTao(cmb.SelectedValue.ToString());
                        inDSDDT.MdiParent = this;
                        inDSDDT.Show();
                        break;
                    }
                case 2:
                    {
                        inDSDDG = new frmInDanhSachDanhGia(cmb.SelectedValue.ToString());
                        inDSDDG.MdiParent = this;
                        inDSDDG.Show();
                        break;
                    }
                case 3:
                    {
                        inBCNVCM = new frmBaoCaoNhanVienChuyenMon(cmb.SelectedValue.ToString());
                        inBCNVCM.MdiParent = this;
                        inBCNVCM.Show();
                        break;
                    }
                case 4:
                    {
                        inBCTHEONN = new frmInNhanVienTheoNgheNghiep(cmb.SelectedValue.ToString());
                        inBCTHEONN.MdiParent = this;
                        inBCTHEONN.Show();
                        break;

                    }
                case 5:
                    {
                        inBCNVPHONGBAN = new frmBaoCaoNhanVienPhongBan(cmb.SelectedValue.ToString());
                        inBCNVPHONGBAN.MdiParent = this;
                        inBCNVPHONGBAN.Show();
                        break;
                    }
            }
            
        }

        private void buttonItemNgoaingu_Click(object sender, EventArgs e)
        {            
            labelItemTen.Text = "Tên Ngoại Ngữ :";
            ctr.HienThiAutoComboboxNGOAINGU(cmb);
            cmb.SelectedValue = "%";
            i = 0;
        }

        private void buttonItemDotdaotao_Click(object sender, EventArgs e)
        {
            labelItemTen.Text = "Tên Đợt Đào Tạo :";
            ctr.HienThiAutoComboboxDotDaoTao(cmb);
            cmb.SelectedValue = "%";
            i = 1;
        }

        private void buttonItemDotDanhGia_Click(object sender, EventArgs e)
        {
            labelItemTen.Text = "Tên Đợt Giá :";
            ctr.HienThiAutoComboboxDotDanhGia(cmb);
            cmb.SelectedValue = "%";
            i = 2;
        }

        private void buttonItemChuyenmon_Click(object sender, EventArgs e)
        {
            labelItemTen.Text = "Tên Chuyên Môn :";
            ctr.HienThiAutoComboboxChuyenMon(cmb);
            cmb.SelectedValue = "%";
            i = 3;
        }

        private void buttonItemNgheNghiep_Click(object sender, EventArgs e)
        {
            labelItemTen.Text = "Tên Nghề Nghiệp :";
            ctr.HienThiAutoComboboxNgheNghiep(cmb);
            cmb.SelectedValue = "%";
            i = 4;
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            labelItemTen.Text = "Tên Phòng Ban :";
            ctr.HienThiAutoComboboxPHONGBAN(cmb);
            cmb.SelectedValue = "%";
            i = 5;
        }
    }
}
