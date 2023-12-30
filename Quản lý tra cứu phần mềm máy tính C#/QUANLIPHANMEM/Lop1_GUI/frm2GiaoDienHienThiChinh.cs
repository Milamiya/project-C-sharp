using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.OleDb;
using Lop2_BUS;
using Enities;

namespace Lop1_GUI
{
    public partial class frm2HienThiChinh : Form
    {
        public frm2HienThiChinh()
        {
            
            InitializeComponent();
            tbHeDieuHanh = objhdh.gettb_HEDIEUHANH();

            tbLoaiPM = objPL.gettbLoaiPM_Theo_maHDH(strhdh);
            
        }
        B_LoaiPM objPL = new B_LoaiPM();
        B_PhanMiem objPM = new B_PhanMiem();
        B_HeDieuHanh objhdh = new B_HeDieuHanh();
        B_HuongDan objHD = new B_HuongDan();

        DataTable tbHeDieuHanh;
        DataTable tbpm;
        DataTable tbLoaiPM;

        public static string strhdh = "";



        BindingSource bs = new BindingSource(); //?? CÁI NÀY LÀM J??? _ _!
        bool danap = false;
        private void loaddanhmuc()
        {
            lstLoadDauTien.DataSource = tbHeDieuHanh;
            lstLoadDauTien.DisplayMember = "TenHDH";
            lstLoadDauTien.ValueMember = "maHDH";
            danap = true;
            bs.DataSource = tbHeDieuHanh;
            tbpm = objPM.gettbPhanMem();
            dgwSanPham.DataSource = tbpm;
        }
        private void Form1_Load(object sender, EventArgs e)
        { //ĐỂ LOAD LẠI COBOTIM HỆ ĐIỀU HÀNH //{
            cbotimHDH.DataSource = tbHeDieuHanh;
            cbotimHDH.DisplayMember = "TenHDH";
            cbotimHDH.ValueMember = "maHDH";
            //}
            loaddanhmuc();

        }
        private void btnChinhSua_Click(object sender, EventArgs e) // click hiển thị lên bảng frmChinhSua
        {
            try
            {

                frm4Admin f = new frm4Admin();
                f.Show();
                this.Hide();
            }
            catch (Exception)
            {

                MessageBox.Show("Chọn Hệ Điều Hành ");
            }
        }
        private void lstLoadDauTien_SelectedValueChanged(object sender, EventArgs e) ///OK
        {  
            if (lstLoadDauTien.SelectedItems.Count > 0)
            {
                string strmaHDH = lstLoadDauTien.SelectedValue.ToString();
                tbLoaiPM = objPL.gettbLoaiPM_Theo_maHDH(strmaHDH);
                cboLoaiPM.DataSource = tbLoaiPM;
                cboLoaiPM.DisplayMember = "TenLoaiPM"; //Hiện THị
                cboLoaiPM.ValueMember = "MaPL";  // lấy giá trị

             
           }

        }
        private void cboLoaiPM_SelectedIndexChanged(object sender, EventArgs e)//OK
        {
            string strmapl = cboLoaiPM.SelectedValue.ToString();
            tbpm = objPM.gettbPhanMem_Theo_maPhanLoai(strmapl);
            dgwSanPham.DataSource = tbpm;
        }

        private void dgwSanPham_CellClick(object sender, DataGridViewCellEventArgs e) //OK
        {
            try
            {
                string strMaPM = dgwSanPham.CurrentRow.Cells[0].Value.ToString();
                DataTable tbpm = objHD.gettbHuongDan_Theo_maphanmem(strMaPM);
                richTextBox1.Text = tbpm.Rows[0]["HuongDan"].ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Rỗng !");
            }

        }
  
        private void lstLoadDauTien_Click(object sender, EventArgs e)
        {
            string strMasp = lstLoadDauTien.SelectedValue.ToString();
            DataTable tbsp = objhdh.getHEDIEUHANH_theo_maHEDIEUHANH(strMasp);
        }
#region Tìm Kiếm
//        private void timkiem_MAPHANMEM()
//         {
//             string strtimkiem = txtTIM.Text;
//             tbpm = objPM.get_timkiem_PhanMem_THEO_MAPM(strtimkiem);
// 
//             bs.DataSource = tbpm; // cos dde xoa
//             dgwSanPham.DataSource = tbpm;
//         }
       private void timkiem_TENPHANMEM()
       {
           string strtimkiem = txtTIM.Text;
           tbpm = objPM.get_timkiem_PhanMem_THEO_TENPHANMEM(strtimkiem);

           bs.DataSource = tbpm; // cos dde xoa
           dgwSanPham.DataSource = tbpm;
       }

//         private void timkiem_HEDIEUHANH()
//         {
//             string strtimkiem = txtTIM.Text;
//             tbpm = objPM.get_timkiem_PhanMem_THEO_HDH(strtimkiem);
//     
//             bs.DataSource = tbpm; // cos dde xoa
//             dgwSanPham.DataSource = tbpm;
//         }

        private void PIC_TIMKIEM_Click(object sender, EventArgs e)
        {
            if(txtTIM.Text=="")
            {
                MessageBox.Show("Nhập Dữ Liệu Cần Tìm !");
            }
           
            else{

              timkiem_TENPHANMEM();
            //  timkiem_MAPHANMEM();                           
            //  timkiem_HEDIEUHANH();

        }}

#endregion

        private void lstLoadDauTien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (danap)
                bs.Position = lstLoadDauTien.SelectedIndex;
        }

        private void PIC_EXIT_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn muốn thoát chương trình?", "Exit Windowns", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (re == DialogResult.OK)
            {
                Close();
            }
        }

        private void cbotimHDH_SelectedIndexChanged(object sender, EventArgs e) // khi chọn vào CboHĐH
        {
            txtTIM.Clear();
            cbotimHDH.DataSource = tbHeDieuHanh;
            cbotimHDH.DisplayMember = "TenHDH";
            cbotimHDH.ValueMember = "maHDH";
            tbpm = objhdh.gettb_HEDIEUHANH();
            dgwSanPham.DataSource = tbpm;

           string s = cbotimHDH.SelectedValue.ToString();
            tbpm = objPM.gettbPhanMem_Theo_maPhanLoai(s);
            dgwSanPham.DataSource = tbpm;
        }

        private void dgwSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTIM_DoubleClick(object sender, EventArgs e)
        {
            txtTIM.Clear();
        }
        private void frm2HienThiChinh_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState==FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frm6Report fr = new frm6Report();
            fr.ShowDialog();
        }

 











    }
}    
