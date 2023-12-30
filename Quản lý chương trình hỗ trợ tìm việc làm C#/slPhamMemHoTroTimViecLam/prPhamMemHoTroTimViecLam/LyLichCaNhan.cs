using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Tier;
using Entities;


namespace prPhamMemHoTroTimViecLam
{
    public partial class LyLichCaNhan : Form
    {
        B_LyLich ObjLL = new B_LyLich();
        B_NganhNghe objNN = new B_NganhNghe();
        B_DoanhNghiep objDN = new B_DoanhNghiep();
        DataTable dtb,tbDoanhNghiep,tbEmail,tbMaDN,tbll;
        public string tentk;
        bool danap = false;
        public LyLichCaNhan()
        {
            InitializeComponent();
            tbDoanhNghiep = objDN.getAllDoanhNghiep();
        }
        private void NapComboBox()
        {
            cmbGuiDN.DataSource = tbDoanhNghiep;
            cmbGuiDN.DisplayMember = "email";
            cmbGuiDN.ValueMember = "Ma";
            danap = true;
        }
        private void LyLichCaNhan_Load(object sender, EventArgs e)
        {
            txtmatk.Text = DangNhap.tendangnhap;
            Napdulieuvao_ListBox();
            //this.reportViewer1.RefreshReport();
        }
        private void Napdulieuvao_ListBox()
        {
            NapComboBox();
           // NapEmail_TheoMaDN();
            lstthem.Items.Clear();
            tbll = ObjLL.gettblylich_TheoTaiKhoan(DangNhap.tendangnhap);
            
            foreach (DataRow dr in tbll.Rows)
            {
                ListViewItem li = lstthem.Items.Add(dr["Ma"].ToString());
                li.SubItems.Add(dr["Ten"].ToString());
                li.SubItems.Add(dr["QueQuan"].ToString());
                li.SubItems.Add(dr["DiaChiThuongTru"].ToString());
                li.SubItems.Add(dr["DiaChiTamTru"].ToString());
                li.SubItems.Add(dr["SDT"].ToString());
                li.SubItems.Add(dr["CMND"].ToString());
                li.SubItems.Add(dr["TinhHinhSucKhoe"].ToString());
                li.SubItems.Add(dr["TenTK"].ToString());
                li.SubItems.Add(dr["MaDN"].ToString());
                li.Tag = dr["Ma"].ToString();
            }
        }
        private void LayEmail_TheoMaDN(string maDN)
        {
            tbEmail = objDN.getEmail_TheoMaDN(maDN);
            DataRow dr = tbEmail.Rows[0];
            cmbGuiDN.Text = dr["email"].ToString();


        }
        private void lvwLyLich_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstthem.SelectedItems.Count > 0) {
                string s = lstthem.SelectedItems[0].Tag.ToString();
                DataTable dtll = ObjLL.gettblylich_theoma(s);
                DataRow dr = dtll.Rows[0];
                txtmalylich.Text = dr["Ma"].ToString();
                txttenll.Text = dr["Ten"].ToString();
                txtquequan.Text = dr["QueQuan"].ToString();
                txtdcthtru.Text = dr["DiaChiThuongTru"].ToString();
                txtdctamtru.Text = dr["DiaChiTamTru"].ToString();
                txtsdt.Text = dr["SDT"].ToString();
                txtcmnd.Text = dr["CMND"].ToString();
                txtsuckhoe.Text = dr["TinhHinhSucKhoe"].ToString();
                txtmatk.Text = dr["TenTK"].ToString();
                LayEmail_TheoMaDN(dr["MaDN"].ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (KiemTra_txt())
            {

                int loi = ObjLL.XoaLyLich(txtmalylich.Text);
                if (loi == 0)
                {
                    MessageBox.Show("Xóa lý lịch thành công");
                    Napdulieuvao_ListBox();
                }
                else if(loi==2)
                {
                    MessageBox.Show("Không có lý lịch trong csdl");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }
        private bool KiemTra_txt()
        {
            if (txtmalylich.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Mã");
                return false;
            }
            else if (txttenll.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Tên");
                return false;
            }
            else if (txtquequan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Que Quan");
                return false;
            }
            else if (txtdcthtru.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Địa chỉ thường trú");
                return false;
            }
            else if (txtdctamtru.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ tạm chú");
                return false;
            }
            else if (txtsuckhoe.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tình hình sức khỏe");
                return false;
            }
            else if (txtcmnd.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập CMND");
                return false;
            }
            else return true;

        }
        private void btnthemlylich_Click(object sender, EventArgs e)
        {
            if(KiemTra_txt())
            {
            string maDN = "";
            tbMaDN = objDN.getMa_TheoEmail(cmbGuiDN.Text);
            DataRow dr = tbMaDN.Rows[0];
            maDN = dr["ma"].ToString();       
            Ly_Lich obj = new Ly_Lich(txtmalylich.Text,txttenll.Text,txtquequan.Text,txtdcthtru.Text,txtdctamtru.Text,txtsdt.Text,txtcmnd.Text,txtsuckhoe.Text,DangNhap.tendangnhap,maDN);
            int loi = ObjLL.Them_LyLich(obj);
            if (loi==0)
            {
                MessageBox.Show("Thêm lý lịch thành công");
                Napdulieuvao_ListBox();
            } 
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có thật sự muốn thoát ?", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (KiemTra_txt())
            {
                string maDN = "";
                tbMaDN = objDN.getMa_TheoEmail(cmbGuiDN.Text);
                DataRow dr = tbMaDN.Rows[0];
                maDN = dr["ma"].ToString();
                Ly_Lich obj = new Ly_Lich(txtmalylich.Text, txttenll.Text, txtquequan.Text, txtdcthtru.Text, txtdctamtru.Text, txtsdt.Text, txtcmnd.Text, txtsuckhoe.Text, DangNhap.tendangnhap, maDN);
                int loi = ObjLL.CapNhatLyLich(obj);
                if (loi == 0)
                {
                    MessageBox.Show("Cập nhật lý lịch thành công");
                    Napdulieuvao_ListBox();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnGuiMail_Click(object sender, EventArgs e)
        {
    
        }

    }
}
