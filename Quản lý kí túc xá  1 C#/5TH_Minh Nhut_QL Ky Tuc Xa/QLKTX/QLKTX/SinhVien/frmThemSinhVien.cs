using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using QLKTX.Controller;
using QLKTX.BusinessObject;

namespace QLKTX
{
    public partial class frmThemSinhVien : Form
    {
        

        
        private SinhVienCtrl SVCtrl = new SinhVienCtrl();
        
        public frmThemSinhVien()
        {            
            InitializeComponent();
        }

        private void textBoxX5_TextChanged(object sender, EventArgs e)
        {
            txtDiaChi.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiem Tra tai day
         if(SVCtrl.KiemTra(txtHoTen,dateNgaySinh,txtDiaChi,txtMSSV,txtCMND,txtDienThoai,cmbQuocTich,cmbDanToc,cmbTonGiao)) 
         {
            SinhVienInfo SV = new SinhVienInfo();
            SV.CamTinhDang = chkCamTinhDang.Checked;
            SV.SoCMDN = txtCMND.Text;
            SV.DangVien = chkDangVien.Checked;

            DanTocInfo dantoc = new DanTocInfo();
            dantoc.MaDanToc=(int)cmbDanToc.SelectedValue;
            dantoc.TenDanToc=cmbDanToc.Text;
            SV.DanToc=dantoc;

            SV.DiaChi = txtDiaChi.Text;
            SV.DienThoai = txtDienThoai.Text;
            SV.DoanVien = chkDoanVien.Checked;
            SV.GioiTinh = chkGioiTinh.Checked;
            SV.HoTen = txtHoTen.Text;
            SV.MaKTX = txtMaKTX.Text;
            SV.MSSV = txtMSSV.Text;
            SV.Namsinh = dateNgaySinh.Value;

            QuocTichInfo quoctich = new QuocTichInfo();
            quoctich.MaQuocTich = (int)cmbQuocTich.SelectedValue;
            quoctich.TenQuocTich = cmbQuocTich.Text;
            SV.QuocTich = quoctich;

            TonGiaoInfo tongiao = new TonGiaoInfo();
            tongiao.MaTonGiao =  (int)cmbTonGiao.SelectedValue;
            tongiao.TenTonGiao=cmbTonGiao.Text;
            SV.TonGiao = tongiao;
            if (picHinh.ImageLocation == null)
            {
                SV.HinhAnh = "";
            }
            else
                SV.HinhAnh = picHinh.ImageLocation.ToString();

            IEnumerator ds = listDSThanNhan.Items.GetEnumerator();
            while(ds.MoveNext())
            {
                ListViewItem item= (ListViewItem)ds.Current;
                ThanNhanInfo tn = (ThanNhanInfo)item.Tag;// (ThanhNhanInfo)item.Tag;
                tn.SinhVien = SV;
                SV.DSThanNhan.Add(tn);
            }

            ListViewItem row= new ListViewItem();
            row.Text = SV.HoTen;
            row.SubItems.Add(SV.GioiTinh==true?"Nam":"Nữ");
            row.Tag = SV;
            listSinhVien.Items.Add(row);
            

            //Xoa Du Lieu tren Form
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtHoTen.Text = "";
            txtHoTen.Text = "";
            txtMaKTX.Text = "";
            txtMSSV.Text = "";
            chkCamTinhDang.Checked = false;
            chkDangVien.Checked = false;
            chkDoanVien.Checked = false;
            chkGioiTinh.Checked = false;

            listDSThanNhan.Items.Clear();//Xóa ListView DS Thân nhân

            ///Lay MSSV tu dong
            txtMaKTX.Text = SVCtrl.LayMaKTXTuDanhSach(listSinhVien);
            picHinh.Image = null;
        }
        }

        private void dtDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
        }

        private void dtDanhSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {            
            SinhVienCtrl sv = new SinhVienCtrl();
            if (MessageBox.Show("Xóa chứ!", "Sinh Vien", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sv.LayDiSinhVienTuDanhSach(listSinhVien);
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

        private void buttonX1_Click(object sender, EventArgs e)
        {
            digHinh.ShowDialog(this);
            
            try
            {
                picHinh.Load(digHinh.FileName.ToString());
            }catch(Exception d ){
            }
        }

       

        private void frmThemSinhVien_Load(object sender, EventArgs e)
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

            txtMaKTX.Text = SVCtrl.LayMaKTX();
            
        }

       /// <summary>
       /// Thêm một thân nhân
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnThemThanNhan_Click(object sender, EventArgs e)
        {
            if (txtHoTenThanNhan.Text != "" && txtHoTenThanNhan != null)
            {
                ListViewItem row = new ListViewItem();
                row.Text = Convert.ToString(listDSThanNhan.Items.Count + 1);
                row.SubItems.Add(txtHoTenThanNhan.Text.ToString());
                row.SubItems.Add(cmbQuanHeThanNhan.Text);
                row.SubItems.Add(cmbNgheNghiepThanNhan.Text);


                ThanNhanInfo thannhan = new ThanNhanInfo();


                thannhan.MaThanNhan = listDSThanNhan.Items.Count + 1;
                SinhVienInfo sv = new SinhVienInfo();
                sv.MaKTX = txtMaKTX.Text;
                sv.HoTen = txtHoTen.Text;

                thannhan.SinhVien = sv;
                thannhan.HoTenThanNhan = row.SubItems[1].Text;
                QuanHeInfo qh = new QuanHeInfo();
                qh.MaQuanHe = (int)cmbQuanHeThanNhan.SelectedValue;
                qh.TenQuanHe = row.SubItems[2].Text;
                thannhan.QuanHe = qh;

                NgheNghiepInfo nn = new NgheNghiepInfo();
                nn.MaNgheNghiep = Convert.ToInt32(cmbNgheNghiepThanNhan.SelectedValue);
                nn.TenNgheNghep = cmbNgheNghiepThanNhan.Text;
                thannhan.NgheNghiep = nn;

                row.Tag = thannhan;

                listDSThanNhan.Items.Add(row);
                //
                txtHoTenThanNhan.Text = "";
                cmbQuanHeThanNhan.SelectedIndex = 0;
                cmbNgheNghiepThanNhan.SelectedIndex = 0;
            }
            else{
                MessageBox.Show("Chưa nhập đủ thông tin của Thân nhân", "Thân nhân", MessageBoxButtons.OK);
            }
        }
        private void listDSThanNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDSThanNhan.SelectedItems.Count > 0)
            {
                btnXoaThanNhan.Enabled = true;
                mnuXoaThanNhan.Enabled = true;
                mnuSuaThongTin.Enabled = true;
            }
            else
            {
                btnXoaThanNhan.Enabled = false;
                mnuXoaThanNhan.Enabled = false;
                mnuSuaThongTin.Enabled = false;
            }
        }

        private void btnXoaThanNhan_Click(object sender, EventArgs e)
        {
            QLKTX.Controller.ThanNhanCtrl tn = new ThanNhanCtrl();
            tn.XoaThanNhan(listDSThanNhan);
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
            if(qh.Index>-1)
                cmbQuanHeThanNhan.SelectedIndex = qh.Index;
        }
        /// <summary>
        /// Sửa Thông tin Thân Nhân
        /// --> Lay từ ListView đưa qua TextBox và ComboBox để chỉnh sửa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuSuaThongTin_Click(object sender, EventArgs e)
        {
            QLKTX.Controller.ThanNhanCtrl tn = new ThanNhanCtrl();
            tn.SuaThongTinThanNhan(listDSThanNhan, txtHoTenThanNhan, cmbQuanHeThanNhan, cmbNgheNghiepThanNhan);
        }

        private void mnuXoaThanNhan_Click(object sender, EventArgs e)
        {
            QLKTX.Controller.ThanNhanCtrl tn = new ThanNhanCtrl();
            tn.XoaThanNhan(listDSThanNhan);
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (listSinhVien.Items.Count > 0)
            {
                QLKTX.Controller.SinhVienCtrl sv = new SinhVienCtrl();
                sv.CapNhatDSSV(listSinhVien);
                txtMaKTX.Text = SVCtrl.LayMaKTX();
            }
            else
            {
                MessageBox.Show("Không có Sinh viên để cập nhật!", "Sinh Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       

        private void btnSua_Click(object sender, EventArgs e)
        {
            QLKTX.Controller.SinhVienCtrl svCtrl = new SinhVienCtrl();
            SinhVienInfo sv=new SinhVienInfo();
            sv=svCtrl.LayDiSinhVienTuDanhSach(listSinhVien);


            //dien thong tin cua Sinh vien            
            txtCMND.Text = sv.SoCMDN;
            txtDiaChi.Text = sv.DiaChi;
            txtDienThoai.Text = sv.DienThoai;
            txtHoTen.Text = sv.HoTen;
            txtMaKTX.Text = sv.MaKTX;
            txtMSSV.Text = sv.MSSV;

            cmbDanToc.Text = sv.DanToc.TenDanToc;
            cmbQuocTich.Text = sv.QuocTich.TenQuocTich;
            cmbTonGiao.Text = sv.TonGiao.TenTonGiao;

            dateNgaySinh.Value = sv.Namsinh;

            chkDoanVien.Checked = sv.DoanVien;            
            chkCamTinhDang.Checked = sv.CamTinhDang;
            chkDangVien.Checked = sv.DangVien;

            chkGioiTinh.Checked = sv.GioiTinh;

            try
            {
                picHinh.Load(sv.HinhAnh);
            }
            catch(Exception i) { i.ToString(); }

            listDSThanNhan.Items.Clear();
            for (int i = 0; i < sv.DSThanNhan.Count;i++ )
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

        private void listSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Có chọn hơn một dòng trên LítView
            if (listSinhVien.SelectedItems.Count > 0)
            {
                mnu_SinhVien_Sua.Enabled = true;
                mnu_SinhVien_Xoa.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                mnu_SinhVien_Sua.Enabled = false;
                mnu_SinhVien_Xoa.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
        }

        private void listSinhVien_Click(object sender, EventArgs e)
        {
            
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
            
            if(qh.Index>-1)
                cmbNgheNghiepThanNhan.SelectedIndex = qh.Index;
        }

        private void mnu_SinhVien_Sua_Click(object sender, EventArgs e)
        {

        }

        private void mnu_SinhVien_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

       
    }
}