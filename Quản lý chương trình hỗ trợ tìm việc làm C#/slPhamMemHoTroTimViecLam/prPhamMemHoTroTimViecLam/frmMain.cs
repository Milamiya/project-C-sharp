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
    public partial class frmMain : Form
    {
        B_NganhNghe ObjNN = new B_NganhNghe();
        B_DoanhNghiep ObjDN = new B_DoanhNghiep();

        DataTable tbNganhNghe;
        public static string strMaDoanhNghiep_chon = "";
        BindingSource bs = new BindingSource();
        bool danap = false;

        public frmMain()
        {
            InitializeComponent();
            tbNganhNghe = ObjNN.gettbnganhnghe();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lstdanhsachnghe.DataSource = tbNganhNghe;
            lstdanhsachnghe.DisplayMember = "Ten";
            lstdanhsachnghe.ValueMember = "Ma";
            danap = true;
            bs.DataSource = tbNganhNghe;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có thật sự muốn thoát ?", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }
        private void lstdanhsachnghe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (danap)
            {
                bs.Position = lstdanhsachnghe.SelectedIndex;
                string s = lstdanhsachnghe.SelectedValue.ToString();
                DataTable tbdn = ObjDN.gettbdoanhnghieptheomanganhnghe(s);
                lvwdanhsachdoanhnghiep.Items.Clear();
                int i = 1;
                foreach (DataRow dr in tbdn.Rows)
                {
                    ListViewItem li = lvwdanhsachdoanhnghiep.Items.Add(i + "");
                    i++;
                    li.SubItems.Add(dr["Ten"].ToString());
                    li.SubItems.Add(dr["DiaChi"].ToString());
                    li.SubItems.Add(dr["SDT"].ToString());
                    li.SubItems.Add(dr["Email"].ToString());
                    li.SubItems.Add(dr["ChuDN"].ToString());
                    li.SubItems.Add(dr["MaNganhNghe"].ToString());

                    li.Tag = dr["Ma"];
                }
            }
        }
        private void lvwdanhsachdoanhnghiep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwdanhsachdoanhnghiep.SelectedItems.Count > 0)
            {
                string strmadn = lvwdanhsachdoanhnghiep.SelectedItems[0].Tag.ToString();
                DataTable dttb = ObjDN.gettbdoanhnghieptheomadoanhnghiep(strmadn);
                DataRow dr = dttb.Rows[0];
                txtmadn.Text = dr["Ma"].ToString();
                txttendn.Text = dr["Ten"].ToString();
                txtdiachi.Text = dr["DiaChi"].ToString();
                txtsdt.Text = dr["SDT"].ToString();
                txtemail.Text = dr["Email"].ToString();
                txtchudn.Text = dr["ChuDN"].ToString();
                txtmann.Text = dr["MaNganhNghe"].ToString();
            }
        }

        private void btnyeucau_Click(object sender, EventArgs e)
        {
            LyLichCaNhan f = new LyLichCaNhan();
            f.ShowDialog();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Trường Đại Học Công Nghiệp Thành Phố Hồ Chí Minh\n Khoa : Công Nghệ Thông Tin \n Chuyên Ngành Công Nghệ Phần Mềm \n Đồ Án Môn Học \nCHƯƠNG TRÌNH HỖ TRỢ NGƯỜI TÌM VIỆC LÀM\n GIẢNG VIÊN HƯỚNG DẪN :TRẦN THỊ ANH THI \n SVTH : Đoàn Văn Duy \n SVTH :Trần Bá Công \n LỚP :NCTH4A -KHÓA HỌC :2010-2013");
        }

        private void thayĐổiDoanhNghiệpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DangNhap.admin == true)
            {
                DoanhNghiep frm = new DoanhNghiep();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chỉ Administrator mới có quyền thay đổi");
            }
        }

        private void thayĐổiNgànhNghềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DangNhap.admin == true)
            {
                NganhNghe frm = new NganhNghe();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chỉ Administrator mới có quyền thay đổi");
            }
            
        }

        private void thayĐổiLýLịchCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LyLichCaNhan f = new LyLichCaNhan();
            f.ShowDialog();
            
        }

        private void thayĐổiThôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ThayDoiMatKhau frm = new ThayDoiMatKhau();
            frm.ShowDialog();
        }

        private void tìmKiếmDoanhNghiệpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiem frm = new TimKiem();
            frm.ShowDialog();
        }
        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimKiem frm = new TimKiem();
            frm.ShowDialog();
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HuongDan frm = new HuongDan();
            frm.ShowDialog();
        }

        private void liênLạcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t\tTHÔNG TIN LIÊN LẠC\nMọi thông tin thắc mắc về việc làm cũng như ý kiến góp ý về phần mềm quý khách hàng có thể liên lạc với công ty chúng tôi theo địa chỉ :\n Email : tuanduy_mc2006@yahoo.com hoặc ctranba29@yahoo.com\n SDT : 0985431797 hoặc 01287545399.");
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
