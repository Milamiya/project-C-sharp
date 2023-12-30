using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TruyXuatFile
{
    public partial class frmMain : Form
    {
        public string ext;
        public int CopyV=0;
        public int MoveV=0;

        public frmMain()
        {
            InitializeComponent();
        }


        public void btnDuyetFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = txtDuongDan.Text;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDuongDan.Text = openFileDialog1.FileName;
            }
        }
     
        public void ThongTinHienThi(string ThongTin)
        {
            FileInfo ThongTinTruyXuat = new FileInfo(ThongTin); // FileInfo thuộc thư viện System.IO
            if (!ThongTinTruyXuat.Exists)
            {
                throw new FileNotFoundException("Không tìm thấy tập tin cần thiết: " + ThongTin);
            }
            txtTenTapTin.Text = ThongTinTruyXuat.Name;
            txtThoiGianTao.Text = ThongTinTruyXuat.CreationTime.ToLongTimeString();
            txtTruyXuatLanCuoi.Text = ThongTinTruyXuat.LastWriteTime.ToLongDateString();
            txtChinhSua.Text = ThongTinTruyXuat.LastAccessTime.ToLongDateString();
            txtKichThuocTapTin.Text = ThongTinTruyXuat.Length.ToString() + " bytes";
            
            ext = ThongTinTruyXuat.Extension;
            
        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            try
            {

                string DuongDan = txtDuongDan.Text;
                FileInfo ThongTinTruyXuat = new FileInfo(DuongDan);
                if (ThongTinTruyXuat.Exists)
                {
                    ThongTinHienThi(DuongDan);
                }
            }
            catch 
            {
                MessageBox.Show("Lỗi thông tin đường dẫn", "Thông Báo", MessageBoxButtons.OK);
            }
        }
                
        private void btnXemNoiDung_Click(object sender, EventArgs e)
        {
                string FilePath = txtDuongDan.Text;
                if (FilePath=="")
                {
                     MessageBox.Show("Bạn phải nhập thông tin đường dẫn", "Thông báo", MessageBoxButtons.OK);
                     txtDuongDan.Focus();

                }
                else
                {
                    ThongTinHienThi(FilePath);
                    ext = ext.ToLower();
                    if (ext == ".txt" )
                    {
                        frmVanBan FormVB = new frmVanBan();
                        FormVB.GetPathVB(FilePath);
                        FormVB.Getext(ext);
                        FormVB.Show();
                      
                    }
                    else if (ext == ".xls")
                    {
                        frmExcel FormExcel = new frmExcel();
                        FormExcel.GetPathExcel(FilePath);
                        FormExcel.Show();
                    }
                    else if (ext == ".doc")
                    {
                        frmWord FormWord = new frmWord();
                        FormWord.GetPathWord(FilePath);
                        FormWord.Show();
                    }
                    else if (ext == ".jpg" || ext == ".gif" || ext == ".bmp" || ext == ".ico" || ext == ".psd")
                    {
                        frmHinhAnh FormHinhAnh = new frmHinhAnh();
                        FormHinhAnh.GetPathHA(FilePath);
                        FormHinhAnh.Show();
                    }
                    else if (ext == ".mp3" || ext == ".mp4" || ext == ".wmv" || ext == ".3gp" || ext == ".avi")
                    {
                        frmNhac FormNhac = new frmNhac();
                        FormNhac.GetPathMedia(FilePath);
                        FormNhac.Show();
                    }
                    else
                        MessageBox.Show("Định dạng này chúng tôi chưa hỗ trợ để có thể mở !", "Thông Báo", MessageBoxButtons.OK);
                }           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string FilePath = txtDuongDan.Text;
                string Query = "Bạn có chắc chắn muốn xóa tập tin không ? \n" + FilePath + "?";
                if (MessageBox.Show(Query, "THÔNG BÁO", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    File.Delete(FilePath);
                    txtDuongDan.Text = "";
                    txtTenTapTin.Text = "";
                    txtThoiGianTao.Text = "";
                    txtTruyXuatLanCuoi.Text = "";
                    txtChinhSua.Text = "";
                    txtKichThuocTapTin.Text = "";

                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Không thể xóa file này vì :"
                    + " xảy ra:\n" + ex.Message, "Thất bại!");
            }
        }


        public  void btnMove_Click(object sender, EventArgs e)
        {
            MoveV = 1;
            frmOpenFile FormOpenFile = new frmOpenFile();
            FormOpenFile.GetMove(MoveV);
            FormOpenFile.Show();           
            FormOpenFile.GetDuongDan(txtDuongDan.Text);
            FormOpenFile.GetTenFile(txtTenTapTin.Text);

           
        }

        public  void btnCopy_Click(object sender, EventArgs e)
        {
            CopyV=1;
            frmOpenFile FormOpenFile = new frmOpenFile();
            FormOpenFile.GetCopy(CopyV);
            FormOpenFile.Show();
            FormOpenFile.GetDuongDan(txtDuongDan.Text);
            FormOpenFile.GetTenFile(txtTenTapTin.Text);
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            frmWord FormWord = new frmWord();
            FormWord.Show();
        }

        private void btntxt_Click(object sender, EventArgs e)
        {
            frmVanBan FormVanBan = new frmVanBan();
            FormVanBan.Show();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            frmNhac FormNhac = new frmNhac();
            FormNhac.Show();
                
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            frmHinhAnh FormHinhAnh = new frmHinhAnh();
            FormHinhAnh.Show();
        }

        private void txtDuongDan_TextChanged(object sender, EventArgs e)
        {
            if (txtDuongDan.Text.Length!=0)
                        {
                btnCopy.Enabled = true;
                btnDelete.Enabled = true;
                btnMove.Enabled = true;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
                btnCopy.Enabled = false;
                btnDelete.Enabled = false;
                btnMove.Enabled = false;
            
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            frmExcel FormExcel = new frmExcel();
            FormExcel.Show();
        }

             

     }
               
    
}