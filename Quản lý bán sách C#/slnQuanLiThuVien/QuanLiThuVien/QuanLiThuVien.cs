using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using QuanLiThuVien.Control;
using System.Windows.Forms;

namespace QuanLiThuVien
{
    public partial class QuanLiThuVien : Form
    {
#region Hàm khởi tạo
        public QuanLiThuVien()
        {
            InitializeComponent();
        }
#endregion
       
#region user control
        
            

        /// <summary>
        /// tâp hợp các hàm load usercontrl
        /// </summary>
        public void LoadUserconTrol()
        {
            LoaduscDanhMucSach();
            LoaduscTraCuuTheoNXB_TacGia();
            LoaduscTraCuuTheoDauSach_TheLoai_TuaSach();
            LoaduscThongKe();
            LoaduscMuonSach();
            LoaduscDocGia();
           
        }

        /// <summary>
        /// load user danh mục sách
        /// </summary>
        void LoaduscDanhMucSach()
        {
            Usc_DanhMucSach usc = new Usc_DanhMucSach();
            tabDanhMucSach.Controls.Clear();
            tabDanhMucSach.Controls.Add(usc);
        }

       
        void LoaduscMuonSach()
        {
            Usc_Muon_TraSach usc = new Usc_Muon_TraSach();
            tabMuon_TraSach.Controls.Clear();
            tabMuon_TraSach.Controls.Add(usc);
        }

        void LoaduscThongKe()
        {
            Usc_ThongKe usc = new Usc_ThongKe();
            tabThongKe.Controls.Clear();
            tabThongKe.Controls.Add(usc);
        }

        void LoaduscTraCuuTheoDauSach_TheLoai_TuaSach()
        {
            Usc_TraCuuTheoTheloai_TuaSach usc = new Usc_TraCuuTheoTheloai_TuaSach();
            tabTraCuuTheoDauSach_TheLoai_TuaSach.Controls.Clear();
            tabTraCuuTheoDauSach_TheLoai_TuaSach.Controls.Add(usc);
        }

        void LoaduscTraCuuTheoNXB_TacGia()
        {
            Usc_TraCuuTheoNXB_TacGia usc = new Usc_TraCuuTheoNXB_TacGia();
            tabTraCuu_NhaSX_TacGia.Controls.Clear();
            tabTraCuu_NhaSX_TacGia.Controls.Add(usc);
        }

        

        void LoaduscDocGia()
        {
            Usc_DocGia usc = new Usc_DocGia();
            tabDocGia.Controls.Clear();
            tabDocGia.Controls.Add(usc);
        }

       
#endregion

        
        /// <summary>
        /// main chính của chương trình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuanLiThuVien_Load(object sender, EventArgs e)
        {
            LoadUserconTrol();
        }


      

        #region menustrip
        /// <summary>
        /// nút thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl;
            dl = MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                this.Close();
        }

        /// <summary>
        /// hàm kết tab đọc giả
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DocGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabChucNang.SelectedIndex = 0;
        }

        /// <summary>
        /// hàm kết tab mượn sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MuonSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabChucNang.SelectedIndex = 1;
        }

       

        /// <summary>
        /// hàm kết tab danh mục sách
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DanhMucSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabChucNang.SelectedIndex = 2;
        }

        /// <summary>
        /// hàm kết tab tra cứu nxb_tg
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TraCuuTheoNXBTacGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabChucNang.SelectedIndex = 3;
        }

        /// <summary>
        /// hàm kết tab tra cứu DS_TL_TS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TraCuuTheoDS_TL_TSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabChucNang.SelectedIndex = 4;
        }

        /// <summary>
        /// hàm kết tab thống kê
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThongKeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabChucNang.SelectedIndex = 5;
        }

        /// <summary>
        /// hàm kết tab tra cứu đọc giả
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TraCuuĐocGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabChucNang.SelectedIndex = 6;
        }

        /// <summary>
        /// hàm trợ giúp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolTroGiup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liên hê nhóm phát triển phần mềm lớp NCTH4A trường DH Cong Nghiệp. ","Trợ giúp",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void thưViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinThuVien frm = new frmThongTinThuVien();
            frm.Show();
        }
        #endregion

        private void toolNhanVien_Click(object sender, EventArgs e)
        {
           
        }

        private void inDocGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInDocGia frm = new frmInDocGia();
            frm.Show();
        }

        private void inDanhMucSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInDanhMucSach frm = new frmInDanhMucSach();
            frm.Show();
        }

        private void inThêLoaiSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInTheLoai frm = new frmInTheLoai();
            frm.Show();
        }

        private void inDanhSachTacGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInTacGia frm = new frmInTacGia();
            frm.Show();
         
        }

        private void inNhaSanXuâtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInNhaXuatBan frm = new frmInNhaXuatBan();
            frm.Show();
        }

        private void inDSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInChiTietPhieuMuon frm = new frmInChiTietPhieuMuon();
            frm.Show();
        }

       
        
       

       

        
        

    }
}
