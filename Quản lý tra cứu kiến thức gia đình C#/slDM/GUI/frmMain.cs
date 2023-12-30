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
    public partial class frmMain : Form
    {
        bChuyenMuc objcm = new bChuyenMuc();
        bMeoVat objmv = new bMeoVat();
        DataTable dtCm;
        DataTable dtMv;
        public static string Tenanhpic="";
        public frmMain()
        {
            InitializeComponent();
          
        }
        Boolean Co_btn = true;
        private void btnThem_MouseHover(object sender, EventArgs e)
        {
            if (Co_btn == true)
            {
                DongMoButton();
            }
            

        }
        public void DongMoButton()
        {
            Timer tmr = new Timer();
            tmr.Interval = 1;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start();
        }
        void tmr_Tick(object sender, EventArgs e)
        {
            Timer tmr = (Timer)sender;
            if (Co_btn == true)
            {
                Point a = new Point(-34, 90);
                if (btnThem.Location.X < a.X)
                {
                    btnThem.Left += 6;
                }
                if (btnXoa.Location.X < a.X)
                {
                    btnXoa.Left += 4;
                }
                if (btnCapNhap.Location.X < a.X)
                {
                    btnCapNhap.Left += 3;
                }
                if (btnHuy.Location.X < a.X)
                {
                    btnHuy.Left += 2;
                }
                else
                {
                    tmr.Stop();
                    Co_btn = false;
                }
            }
            else
            {
                Point a = new Point(-105, 90);
                if (btnThem.Location.X > a.X)
                {
                    btnThem.Left -= 6;
                }
                if (btnXoa.Location.X >a.X)
                {
                    btnXoa.Left -= 4;
                }
                if (btnCapNhap.Location.X > a.X)
                {
                    btnCapNhap.Left -= 3;
                }
                if (btnHuy.Location.X > a.X)
                {
                    btnHuy.Left -= 2;
                }
                else
                {
                    tmr.Stop();
                    Co_btn = true;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            DongMoButton();
            MoFormThem();
          
           
        }
        public void MoFormThem()
        {
            frmThem frm = new frmThem();
            frm.Text = "Thêm mới kiến thức";
            frm.btnThemmoi.Visible = true;
            frm.ShowDialog();
            
          
        }
        public void MoFormCapNhap()
        {
            frmThem frm = new frmThem();
            frm.Text = "Cập nhập kiến thức";
            frm.btnThemmoi.Visible = false;
            frm.ShowDialog();
          
          
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DongMoButton();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DongMoButton();
            if (lvwMeoVat.SelectedItems.Count > 0)
            {
                DialogResult dl= MessageBox.Show("Bạn chắc chắn muốn xóa mẹo vặt \"" + lvwMeoVat.SelectedItems[0].Text + "\"","Xóa ?",MessageBoxButtons.YesNo);
                if(dl==DialogResult.Yes)
                {
                    string ma = lvwMeoVat.SelectedItems[0].Tag.ToString();
                    int n = objmv.XoaMeoVat(ma);
                    if (n != 0)
                    {
                        if (picAnh.Tag.ToString() != "macdinh.png")
                        {
                            File.Delete(Application.StartupPath + @"\Picture\" + picAnh.Tag.ToString());
                        }
                        MessageBox.Show("Xóa thành công!");
                        btnSearch_Click(sender,e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mẹo vặt cần xóa!");
            }
        }
        public static string mamv;
        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            DongMoButton();
            if (lvwMeoVat.SelectedItems.Count > 0)
            {
                mamv = lvwMeoVat.SelectedItems[0].Tag.ToString();
                MoFormCapNhap();
                frmMain_Load(sender, e);
                dtMv = objmv.getTable_MeoVat_Ma_Tendm(mamv);
                LoadNoidung(dtMv);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mẹo vặt cần cập nhập!");
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dtsearch = objmv.getTable_MeoVat_forsearch();
            DataView dv = new DataView(dtsearch);
            if (cboChuyenmuc.SelectedValue.ToString() == "0")
            {
                if (txtTimkiem.Text == "")
                {             
                    HienThiListView(dv);                       
                }
                else
                {              
                    dv.RowFilter = "Tenmv like '%"+txtTimkiem.Text+"%'";
                    HienThiListView(dv);
                }
            }
            else
            {
                if (txtTimkiem.Text == "")
                {
                    dv.RowFilter = "Macm='"+cboChuyenmuc.SelectedValue.ToString()+"'";
                    HienThiListView(dv);
                }
                else
                {        
                    dv.RowFilter = "Macm='" + cboChuyenmuc.SelectedValue.ToString() + "' and Tenmv like '%" + txtTimkiem.Text + "%'";
                    HienThiListView(dv);
                }
            }
            if (lvwMeoVat.Items.Count == 0)
            {
                MessageBox.Show("Không tìm thấy ! \nLưu ý : Cần gõ tiếng việt có dấu.");
                
            }
            
        }
        public void HienThiListView(DataView dv)
        {
            lvwMeoVat.Items.Clear();
            foreach (DataRowView r in dv)
            {
                ListViewItem li = lvwMeoVat.Items.Add(r[1].ToString());
                li.Tag = r[0].ToString();
                li.ImageIndex = 0;
            }
        }

        private void lvwMeoVat_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnNoiDung.Visible = true;
            if (lvwMeoVat.SelectedItems.Count > 0)
            {
                string ma=lvwMeoVat.SelectedItems[0].Tag.ToString();
                dtMv = objmv.getTable_MeoVat_Ma_Tendm(ma);
                DongmoPNnoidung();
                DongmoPNnoidung();
            }
        }
        public void DongmoPNnoidung()
        {
            Timer tmrP = new Timer();
            tmrP.Interval = 1;
            tmrP.Tick += new EventHandler(tmrP_Tick);
            tmrP.Start();
        }
        Boolean dong_mo = true;
        void tmrP_Tick(object sender, EventArgs e)
        {
           
            Timer t = (Timer)sender;
            if (dong_mo == true)
            {
                Point a = new Point(-310, 50);
                pnNoiDung.Top -= 20;
                if (pnNoiDung.Location.Y < a.X)
                {

                    t.Stop();
                    dong_mo = false;
                    LoadNoidung(dtMv);
                }
            }
            else
            {
                Point a = new Point(-310, 50);
                pnNoiDung.Top += 10;
                if (pnNoiDung.Location.Y > a.Y)
                {

                    t.Stop();
                    dong_mo = true;
                }
            }
        }
        public void LoadNoidung(DataTable dt)
        {
            if (lvwMeoVat.SelectedItems.Count > 0)
            {
                foreach (DataRow r in dt.Rows)
                {
                    lblTieuDe.Tag = lvwMeoVat.SelectedItems[0].Tag.ToString();
                    lblTieuDe.Text = r["Tenmv"].ToString();
                    lblNguon.Text = "Nguồn: " + r["Nguon"].ToString();
                    string a = r["Ngaynhap"].ToString();
                    DateTime Ngay = DateTime.Parse(a);
                    lblNgay.Text = "Ngày đăng: " + Ngay.ToString("dd/MM/yyyy");
                    lblChuyenMuc.Text = "Chuyên mục: " + r["Tencm"].ToString();
                    richTextNoidung.Text =r["Noidung"].ToString();
                    string Tenanh = r["Hinhanh"].ToString();
                    Tenanhpic = Tenanh;
                    string duongdan = Application.StartupPath + @"\Picture\" + Tenanh;
                    picAnh.ImageLocation = duongdan;
                    picAnh.Tag = Tenanh;
                    danhgia = Int32.Parse(r["Danhgia"].ToString());

                    Loadsao();

                }
            }
            
        }

       
        private void frmMain_Load(object sender, EventArgs e)
        {

            dtCm = objcm.getTable_ChuyenMuc();
            DataRow r = dtCm.NewRow();
            r[0] = 0;
            r[1] = "- - -Tất cả- - - ";
            dtCm.Rows.Add(r);
            cboChuyenmuc.DataSource = dtCm;
            cboChuyenmuc.DisplayMember = "Tencm";
            cboChuyenmuc.ValueMember = "Macm";
            cboChuyenmuc.SelectedValue = 0;  
        }
        
        int danhgia = 0;

        private void sao1_Click(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            int luu = danhgia;
            danhgia = Int32.Parse(a.Tag.ToString());
            Loadsao();
            DialogResult dl = MessageBox.Show( "Lưu đánh giá ?","",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {

                string ma = lblTieuDe.Tag.ToString();
                int n = objmv.UpdateDanhgia(ma, danhgia);

            }
            else
            {
                danhgia = luu;
                Loadsao();
            }
            
        }

        private void sao1_MouseHover(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            int sao = Int32.Parse(a.Tag.ToString());

            foreach (PictureBox p in pnDanhgia.Controls)
            {
                int i = Int32.Parse(p.Tag.ToString());
                if (i <= sao)
                {
                    p.ImageLocation = Application.StartupPath + @"\Image\sang.png";
                }
                else
                {
                    p.ImageLocation = Application.StartupPath + @"\Image\toi.png";
                }
            }
        }

        private void sao1_MouseLeave(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            int sao = Int32.Parse(a.Tag.ToString());

            foreach (PictureBox p in pnDanhgia.Controls)
            {
                int i = Int32.Parse(p.Tag.ToString());
                if (i <= sao)
                {
                    p.ImageLocation = Application.StartupPath + @"\Image\toi.png";
                }
                else
                {
                    p.ImageLocation = Application.StartupPath + @"\Image\sang.png";
                }
            }
            Loadsao();
        }
        
        public void Loadsao()
        {
            foreach (PictureBox p in pnDanhgia.Controls)
            {
                int i = Int32.Parse(p.Tag.ToString());
                if (i <= danhgia)
                {
                    p.ImageLocation = Application.StartupPath + @"\Image\sang.png";
                }
                else
                {
                    p.ImageLocation = Application.StartupPath + @"\Image\toi.png";
                }
            }
        }

   

        private void picAnh_MouseHover(object sender, EventArgs e)
        {
            if (Tenanhpic != "")
            {
                frmXemanh frm = new frmXemanh();
                frm.Show();
            }
        }

        private void picIn_Click(object sender, EventArgs e)
        {
            DataTable dt = objmv.getTable_MeoVat_Ma_Tendm(lblTieuDe.Tag.ToString());
            new frmReport(dt).ShowDialog();
        }

        private void picIn_MouseDown(object sender, MouseEventArgs e)
        {
            picIn.BorderStyle = BorderStyle.Fixed3D;
        }

        private void picIn_MouseUp(object sender, MouseEventArgs e)
        {
            picIn.BorderStyle = BorderStyle.None;
        }

   

     
    }
}
