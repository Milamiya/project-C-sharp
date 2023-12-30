using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCafe.Presentation
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

        private void quêQuánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Que));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Que fr = new fr_Que();
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

        private void loạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Loai));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Loai fr = new fr_Loai();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void côngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Congdung));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Congdung fr = new fr_Congdung();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void chiTiếtCafeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Sanpham));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Sanpham fr = new fr_Sanpham();
                fr.MdiParent = this;
                fr.Show();
            }
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

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_TKHDB));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_TKHDB fr = new fr_TKHDB();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void điệnThoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_TK_SP));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_TK_SP fr = new fr_TK_SP();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_DangNhap fr = new fr_DangNhap();
            this.Hide();
            fr.Show();
        }
        private void quýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_BC_Quy_HDB));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_BC_Quy_HDB fr = new fr_BC_Quy_HDB();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void quýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_BC_Quy_KH));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_BC_Quy_KH fr = new fr_BC_Quy_KH();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void quýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_BC_Quy_SP));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_BC_Quy_SP fr = new fr_BC_Quy_SP();
                fr.MdiParent = this;
                fr.Show();
            }
        }
    }
}



