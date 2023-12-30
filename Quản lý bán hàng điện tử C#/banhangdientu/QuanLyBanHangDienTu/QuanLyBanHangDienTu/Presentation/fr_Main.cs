using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHangDienTu.Presentation
{
    public partial class fr_Main : Form
    {
        public fr_Main()
        {
            InitializeComponent();
        }
        private Form kiemtratontai(Type formtype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == formtype)
                    return f;
            }
            return null;
        }
        private void caLàmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Calam));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Calam fr = new fr_Calam();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void côngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Congviec));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Congviec fr = new fr_Congviec();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Nhanvien));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Nhanvien fr = new fr_Nhanvien();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_NCC));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_NCC fr = new fr_NCC();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Khachhang));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Khachhang fr = new fr_Khachhang();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void sảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Hanghoa));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Hanghoa fr = new fr_Hanghoa();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void chấtLIệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Chatlieu));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Chatlieu fr = new fr_Chatlieu();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void đơnVịTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Donvitinh));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Donvitinh fr = new fr_Donvitinh();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Loaihang));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Loaihang fr = new fr_Loaihang();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void nhómHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Nhomhang));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Nhomhang fr = new fr_Nhomhang();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void nướcSXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Nuocsx));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Nuocsx fr = new fr_Nuocsx();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_Dangnhap fr = new fr_Dangnhap();
            this.Hide();
            fr.Show();
        }

        private void hóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_HDN));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_HDN fr = new fr_HDN();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void hóaĐơnXuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_HDB));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_HDB fr = new fr_HDB();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void sẳnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_TK));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_TK fr = new fr_TK();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_TKHDN));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_TKHDN fr = new fr_TKHDN();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void nhânViênToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_BC_NV));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_BC_NV fr = new fr_BC_NV();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void nhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_BC_NCC));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_BC_NCC fr = new fr_BC_NCC();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void báoCáoQuýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_BC_Quy));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_BC_Quy fr = new fr_BC_Quy();
                fr.MdiParent = this;
                fr.Show();
            }
        }
    }
}
