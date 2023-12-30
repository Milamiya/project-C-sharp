using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessTier;
using Entities;
using System.IO;


namespace GUI
{
    public partial class frmThem : Form
    {
        bChuyenMuc objcm = new bChuyenMuc();
        bMeoVat objmv = new bMeoVat();
        DataTable dtcm;
        public string tenanh="";
        public string tenanhofopendialog = "";
        public string duongdanAnh = "";
        public frmThem()
        {
            InitializeComponent();
            dtcm = objcm.getTable_ChuyenMuc();

        }
        private void frmThem_Load(object sender, EventArgs e)
        {
            DataRow r = dtcm.NewRow();
            r[0] = 0;
            r[1] = "Khác";
            dtcm.Rows.Add(r);
            cboChuyenMuc.DataSource = dtcm;
            cboChuyenMuc.DisplayMember = "Tencm";
            cboChuyenMuc.ValueMember="Macm";

            if (btnThemmoi.Visible == false)
            {
                Loadnoidungcapnhap();
            }
           
        }
        public void Loadnoidungcapnhap()
        {
            string ma = frmMain.mamv;
            DataTable dtmv = objmv.getTable_MeoVat_Ma(ma);
            foreach (DataRow rr in dtmv.Rows)
            {
                txtTieuDe.Text = rr["Tenmv"].ToString();
                txtNguon.Text = rr["Nguon"].ToString();
                dateTimePickerNgayNhap.Value = DateTime.Parse(rr["Ngaynhap"].ToString());
                cboChuyenMuc.SelectedValue = rr["Macm"].ToString();
                txtNoidung.Text = rr["Noidung"].ToString();
                tenanh = rr["Hinhanh"].ToString();
                string duongdan = Application.StartupPath + @"\Picture\" + tenanh;
                picAnhThem.ImageLocation = duongdan;

            }
        }
        
        private void cboChuyenMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboChuyenMuc.SelectedValue.ToString() == "0")
            {
                txtChuyenmuckhac.Visible = true;
                txtChuyenmuckhac.Focus();
            }
            else
            {
                txtChuyenmuckhac.Visible = false;
            }
        }
    

        private void rbMacdinh_Click(object sender, EventArgs e)
        {
            if (rbMacdinh.Checked)
            {
                //string tenfile = System.IO.Path.GetFileName(openFileDialogMoAnh.FileName);//lấy tên file
                string duongdan = Application.StartupPath + @"\Picture\" + "macdinh.png";//Lấy địa chỉ nơi chạy file exe
                picAnhThem.ImageLocation = duongdan;
            }
            else if (rbTaitumaytinh.Checked)
            {
                picAnhThem.Image = null;
                openFileDialogMoAnh.Filter = "JPG File|*.jpg|PNG File|*.png|All File|*.*";
            
                    if (openFileDialogMoAnh.ShowDialog() == DialogResult.OK)
                    {
                        duongdanAnh = openFileDialogMoAnh.FileName;
                        picAnhThem.ImageLocation = duongdanAnh;
                        tenanhofopendialog = System.IO.Path.GetFileName(openFileDialogMoAnh.FileName);
                    }
                 
              

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Kiemtradulieu())
            {
                if (btnThemmoi.Visible == false)
                {
                    CapNhap();
                }
                else
                {
                    Them();
                }
            }
        }
        public void CapNhap()
        {
            MeoVat mvCapnhap = new MeoVat();
            mvCapnhap.Mameovat = frmMain.mamv;
            mvCapnhap.Temeovat = txtTieuDe.Text;
            mvCapnhap.Noidung = txtNoidung.Text;
            mvCapnhap.Ngaynhap = dateTimePickerNgayNhap.Value;
            mvCapnhap.Nguon = txtNguon.Text;
          

            if (cboChuyenMuc.SelectedValue.ToString() == "0")
            {
                objcm.ThemChuyenMuc(txtChuyenmuckhac.Text);
                DataTable dt = objcm.getTable_ChuyenMuc();
                foreach (DataRow r in dt.Rows)
                {
                    if (r[1].ToString() == txtChuyenmuckhac.Text)
                    {
                        mvCapnhap.Machuyenmuc = r[0].ToString();
                        break;
                    }
                }
            }
            else
            {
                mvCapnhap.Machuyenmuc = cboChuyenMuc.SelectedValue.ToString();
            }

            if (rbMacdinh.Checked == true)
            {
                mvCapnhap.HinhAnh = "macdinh.png";
                if (tenanh != "macdinh.png")
                    File.Delete(Application.StartupPath + @"\Picture\" + tenanh);
            }
            else if (rbTaitumaytinh.Checked == true)
            {
                int n = Int32.Parse(frmMain.mamv);
                string anh = n + "_" + tenanhofopendialog;
                mvCapnhap.HinhAnh = anh;
                picAnhThem.Image.Save(Application.StartupPath + @"\Picture\" + anh);
                if (tenanh!="macdinh.png")
                     File.Delete(Application.StartupPath + @"\Picture\" + tenanh);
                         
            }
            else
            {
                mvCapnhap.HinhAnh = tenanh;
            }

            int i = objmv.CapnhapMeoVat(mvCapnhap);
            if (i != 0)
            {
                MessageBox.Show("Cập nhập thành công ! ");
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhập thất bại !");
            }
 
        }
        public void Them()
        {
            MeoVat mvThem = new MeoVat();
            mvThem.Mameovat ="";
            mvThem.Temeovat = txtTieuDe.Text;
            mvThem.Noidung = txtNoidung.Text;
            mvThem.Ngaynhap = dateTimePickerNgayNhap.Value;
            mvThem.Nguon = txtNguon.Text;
            mvThem.Danhgia = 0;
            if (cboChuyenMuc.SelectedValue.ToString() == "0")
            {
                objcm.ThemChuyenMuc(txtChuyenmuckhac.Text);
                DataTable dt = objcm.getTable_ChuyenMuc();
                foreach (DataRow r in dt.Rows)
                {
                    if (r[1].ToString() == txtChuyenmuckhac.Text)
                    {
                        mvThem.Machuyenmuc = r[0].ToString();
                        break;
                    }
                }
            }
            else
            {
                mvThem.Machuyenmuc = cboChuyenMuc.SelectedValue.ToString();
            }

            if (rbMacdinh.Checked == true)
            {
                mvThem.HinhAnh = "macdinh.png";
            }
            else if (rbTaitumaytinh.Checked == true)
            {
                int n = objmv.getMamv_cuoi_tblMeovat();
                n++;
                string anh=n+"_"+ tenanhofopendialog;
                mvThem.HinhAnh = anh;
                picAnhThem.Image.Save(Application.StartupPath + @"\Picture\"+anh);
                
            }
            int i = objmv.Themmeovat(mvThem);
            if (i != 0)
            {
                MessageBox.Show("Thêm thành công !");
            }
            else
            {
                MessageBox.Show("Thêm thất bại !");
            }

        }
        public Boolean Kiemtradulieu()
        {
            if (txtTieuDe.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tiêu đề cho mẹo vặt !");
                txtTieuDe.Focus();
                return false;

            }
            else if (txtNguon.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nguồn cho mẹo vặt !");
                txtNguon.Focus();
                return false;
            }
            else if (txtChuyenmuckhac.Visible == true && txtChuyenmuckhac.Text == "")
            {
                MessageBox.Show("Vui lòng nhập chuyên mục mẹo vặt !");
                txtChuyenmuckhac.Focus();
                return false;
            }
            else if (txtNoidung.Text == "")
            {
                MessageBox.Show("Vui lòng nhập nội dung mẹo vặt !");
                txtNoidung.Focus();
                return false;

            }
            else if (picAnhThem.Image == null)
            {
                MessageBox.Show("Chưa chọn ảnh! \n Bạn có thể chọn mặc định hoặc tải ảnh từ máy tính.");
                return false;
            }
            return true;

        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            txtTieuDe.Text = "";
            txtNguon.Text = "";
            txtNoidung.Text = "";
            txtChuyenmuckhac.Text = "";
            rbMacdinh.Checked = false;
            rbTaitumaytinh.Checked = false;
            picAnhThem.Image = null;
            frmThem_Load(sender, e);
            txtChuyenmuckhac.Visible = false;
            cboChuyenMuc.SelectedIndex = 0;
        }

 

        

      

      
       


     
    }
}
