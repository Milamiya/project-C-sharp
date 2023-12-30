using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCuaHangTivi.Presentation
{
    public partial class Main : Form
    {
        public Main()
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

        private void chiTiếtNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
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
            Form frm = kiemtratontai(typeof(fr_Khachang));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Khachang fr = new fr_Khachang();
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

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
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

                fr_HDN fr = new fr_HDN();
                fr.MdiParent = this;
                fr.Show();
        }

        private void cỡMànHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Comanhinh));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Comanhinh fr = new fr_Comanhinh();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void hãngSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_HangSX));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_HangSX fr = new fr_HangSX();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void kiểuDángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_KieuDang));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_KieuDang fr = new fr_KieuDang();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void mànHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Manhinh));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Manhinh fr = new fr_Manhinh();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void màuSắcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Mau));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Mau fr = new fr_Mau();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void chiTiếtTiviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_Tivi));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_Tivi fr = new fr_Tivi();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void tìmKiếmTiviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_TK_TV));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_TK_TV fr = new fr_TK_TV();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void tìmKiếmHĐNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_TK_HDN));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_TK_HDN fr = new fr_TK_HDN();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void nhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_BC_BCC));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_BC_BCC fr = new fr_BC_BCC();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void nhàCungCấpGiaoNhiềuHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_BC_NCC_GiaoHang));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_BC_NCC_GiaoHang fr = new fr_BC_NCC_GiaoHang();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void sảnPhẩmKháchMuaNhiềuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_BC_SP_KH_Mua_Nhieu));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_BC_SP_KH_Mua_Nhieu fr = new fr_BC_SP_KH_Mua_Nhieu();
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

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lbh.Text = DateTime.Now.ToShortTimeString();
            lbngay.Text = DateTime.Now.ToShortDateString();
        }

        private void quýToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void nớiSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(fr_NoiSX));
            if (frm != null)
                frm.Activate();
            else
            {
                fr_NoiSX fr = new fr_NoiSX();
                fr.MdiParent = this;
                fr.Show();
            }
        }
    }
}
