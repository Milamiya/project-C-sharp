using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKTX.BusinessObject;
using QLKTX.Controller;
using QLKTX.DataLayer;
namespace QLKTX
{
    public partial class frmSuaSinhVien : Form
    {
        SinhVienCtrl ctrl = new SinhVienCtrl();
        public frmSuaSinhVien()
        {
            InitializeComponent();
        }

        private void chkDoanVien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDoanVien.Checked == true)
            {
                chkDangVien.Checked = false;
                chkDangVien.Enabled = false;
            }
            else
            {
                chkDangVien.Enabled = true;
                chkCamTinhDang.Checked = false;
            }
        }

        private void chkDangVien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDangVien.Checked == true)
            {
                chkDoanVien.Checked = false;
                chkCamTinhDang.Checked = false;
                chkDoanVien.Enabled = false;
                chkCamTinhDang.Enabled = false;

            }
            else
            {
                chkDoanVien.Enabled = true;
                chkCamTinhDang.Enabled = true;
            }
        }

        private void chkCamTinhDang_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCamTinhDang.Checked == true)
            {
                chkDoanVien.Checked = true;
                chkDangVien.Checked = false;
                chkDangVien.Enabled = false;
            }
            else
            {
                chkDangVien.Enabled = true;
                chkDoanVien.Enabled = true;
            }
        }

        private void btnSuaSinhVien_Click(object sender, EventArgs e)
        {
            QLKTX.Controller.SinhVienCtrl svCtrl = new SinhVienCtrl();
            SinhVienInfo sv = new SinhVienInfo();
            sv = svCtrl.LayDiSinhVienTuDanhSach(listSinhVien);


            //dien thong tin cua Sinh vien            
            txtCMND.Text = sv.SoCMDN;
            txtDiaChi.Text = sv.DiaChi;
            txtDienThoai.Text = sv.DienThoai;
            txtHoTen.Text = sv.HoTen;
            txtMaKTX.Text = sv.MaKTX;
            txtMSSV.Text = sv.MSSV;

            cmbDanToc.SelectedValue = sv.DanToc.MaDanToc;
            cmbQuocTich.SelectedValue = sv.QuocTich.MaQuocTich;
            cmbTonGiao.SelectedValue = sv.TonGiao.MaTonGiao;

            dateNgaySinh.Value = sv.Namsinh;

            chkDoanVien.Checked = sv.DoanVien;
            chkCamTinhDang.Checked = sv.CamTinhDang;
            chkDangVien.Checked = sv.DangVien;

            chkGioiTinh.Checked = sv.GioiTinh;

            try
            {
                picHinh.Load(sv.HinhAnh);
            }
            catch (Exception i) { i.ToString(); }

            listDSThanNhan.Items.Clear();
            for (int i = 0; i < sv.DSThanNhan.Count; i++)
            {
                ThanNhanInfo tn = sv.DSThanNhan[i];
                ListViewItem item = new ListViewItem();
                item.Text = ((ThanNhanInfo)tn).MaThanNhan.ToString();
                item.SubItems.Add(((ThanNhanInfo)tn).HoTenThanNhan);
                item.SubItems.Add(((ThanNhanInfo)tn).QuanHe.TenQuanHe);
                item.SubItems.Add(((ThanNhanInfo)tn).NgheNghiep.TenNgheNghep);
                item.Tag = ((ThanNhanInfo)tn);
                listDSThanNhan.Items.Add(item);
            }



            //dien thong tin cua than nhan
        }

        private void frmSuaSinhVien_Load(object sender, EventArgs e)
        {
            QuocTichCtrl QT = new QuocTichCtrl();
            TonGiaoCtrl TG = new TonGiaoCtrl();
            DanTocCtrl DT = new DanTocCtrl();

            QuanHeCtrl QH = new QuanHeCtrl();
            NgheNghiepCtrl NN = new NgheNghiepCtrl();

            QT.LayComboboxQuocTich(cmbQuocTich);
            TG.LayComboboxTonGiao(cmbTonGiao);
            DT.LayComboboxDanToc(cmbDanToc);

            QH.LayComboboxQuanHe(cmbQuanHeThanNhan);
            NN.LayComboboxNgheNghiep(cmbNgheNghiepThanNhan);
            
            ctrl.LayDSSVLenListView_Sua(listSinhVien);
        }

        private void listSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Có chọn hơn một dòng trên LítView
            if (listSinhVien.SelectedItems.Count > 0)
            {
                mnu_SinhVien_Sua.Enabled = true;
                mnu_SinhVien_Xoa.Enabled = true;
                btnSuaSinhVien.Enabled = true;
                btnSuaSinhVien.Enabled = true;
            }
            else
            {
                mnu_SinhVien_Sua.Enabled = false;
                mnu_SinhVien_Xoa.Enabled = false;
                btnSuaSinhVien.Enabled = false;
                
            }
        }

        private void btnThemQuocTich_Click(object sender, EventArgs e)
        {
            QuocTichCtrl QT = new QuocTichCtrl();
            QLKTX.Dialog.DiaLog_ThemQuocTich t = new QLKTX.Dialog.DiaLog_ThemQuocTich();
            t.StartPosition = FormStartPosition.Manual;
            //t.Location = p;
            t.Left = this.Location.X + groupThongTin.Location.X + groupXaHoi.Location.X + btnThemQuocTich.Location.X + btnThemQuocTich.Height + 12;
            t.Top = this.Location.Y + groupThongTin.Location.Y + groupXaHoi.Location.Y + btnThemQuocTich.Location.Y + btnThemQuocTich.Width + 12;

            t.ShowDialog();


            if (t.DialogResult == DialogResult.Yes)
            {
                QT.LayComboboxQuocTich(cmbQuocTich);
                cmbQuocTich.Text = t.TenQT;
            }

        }

        private void btnThemDanToc_Click(object sender, EventArgs e)
        {
            DanTocCtrl DT = new DanTocCtrl();
            QLKTX.Dialog.DiaLog_ThemDanToc t = new QLKTX.Dialog.DiaLog_ThemDanToc();
            t.StartPosition = FormStartPosition.Manual;
            //t.Location = p;
            t.Left = this.Location.X + groupThongTin.Location.X + groupXaHoi.Location.X + btnThemDanToc.Location.X + btnThemDanToc.Height + 12;
            t.Top = this.Location.Y + groupThongTin.Location.Y + groupXaHoi.Location.Y + btnThemDanToc.Location.Y + btnThemDanToc.Width + 12;

            t.ShowDialog();


            if (t.DialogResult == DialogResult.Yes)
            {
                DT.LayComboboxDanToc(cmbDanToc);
                cmbDanToc.Text = t.TenDT;
            }
        }

        private void btnThemTonGiao_Click(object sender, EventArgs e)
        {

            TonGiaoCtrl TG = new TonGiaoCtrl();
            QLKTX.Dialog.DiaLog_ThemTonGiao t = new QLKTX.Dialog.DiaLog_ThemTonGiao();
            t.StartPosition = FormStartPosition.Manual;

            t.Left = this.Location.X + groupThongTin.Location.X + groupXaHoi.Location.X + btnThemTonGiao.Location.X + btnThemTonGiao.Height + 12;
            t.Top = this.Location.Y + groupThongTin.Location.Y + groupXaHoi.Location.Y + btnThemTonGiao.Location.Y + btnThemTonGiao.Width + 12;

            t.ShowDialog();


            if (t.DialogResult == DialogResult.Yes)
            {
                TG.LayComboboxTonGiao(cmbTonGiao);
                cmbTonGiao.Text = t.TenTG;
            }
        
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            QuanHeCtrl QH = new QuanHeCtrl();
            QLKTX.Dialog.DiaLog_Them_Sua_QuanHe qh = new QLKTX.Dialog.DiaLog_Them_Sua_QuanHe();

            qh.StartPosition = FormStartPosition.Manual;
            qh.Left = this.Location.X + groupThongTin.Location.X + groupThanNhan.Location.X + btnThemTonGiao.Location.X;
            qh.Top = this.Location.Y + groupThongTin.Location.Y + groupThanNhan.Location.Y;

            qh.ShowDialog();

            QH.LayComboboxQuanHe(cmbQuanHeThanNhan);
            cmbQuanHeThanNhan.SelectedIndex = qh.Index;
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            NgheNghiepCtrl NN = new NgheNghiepCtrl();
            QLKTX.Dialog.DiaLog_Them_Sua_NgheNghiep qh = new QLKTX.Dialog.DiaLog_Them_Sua_NgheNghiep();

            qh.StartPosition = FormStartPosition.Manual;
            qh.Left = this.Location.X + groupThongTin.Location.X + groupThanNhan.Location.X + btnThemTonGiao.Location.X;
            qh.Top = this.Location.Y + groupThongTin.Location.Y + groupThanNhan.Location.Y;

            qh.ShowDialog();
            Graphics f = this.CreateGraphics();
            NN.LayComboboxNgheNghiep(cmbNgheNghiepThanNhan);
            cmbNgheNghiepThanNhan.SelectedIndex = qh.Index;
        }

        private void mnuXoaThanNhan_Click(object sender, EventArgs e)
        {
            QLKTX.Controller.ThanNhanCtrl tn = new ThanNhanCtrl();
            tn.XoaThanNhan(listDSThanNhan);
        }

        private void mnuSuaThongTin_Click(object sender, EventArgs e)
        {
            QLKTX.Controller.ThanNhanCtrl tn = new ThanNhanCtrl();
            tn.SuaThongTinThanNhan(listDSThanNhan, txtHoTenThanNhan, cmbQuanHeThanNhan, cmbNgheNghiepThanNhan);
        }

        
    }
}