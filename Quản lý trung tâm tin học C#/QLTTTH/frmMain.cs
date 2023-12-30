using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLTTTH
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Kiem tra form hien

        Boolean Kiemtraform(string frmName)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals(frmName))
                {
                    frm.Activate();
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region mo cac bang chinh

        private void thôngTinHọcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Kiemtraform("frmHocvien") == false)
            {
                frmHocvien frmHV = new frmHocvien();
                frmHV.Name = "frmHocvien";
                frmHV.MdiParent = this;
                frmHV.Show();
            }
        }

        private void thôngTinLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Kiemtraform("frmLophoc") == false)
            {
                frmLophoc frmLH = new frmLophoc();
                frmLH.Name = "frmLophoc";
                frmLH.MdiParent = this;
                frmLH.Show();
            }
        }

        private void thôngTinMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Kiemtraform("frmMonhoc") == false)
            {
                frmMonhoc frmMH = new frmMonhoc();
                frmMH.Name = "frmMonhoc";
                frmMH.MdiParent = this;
                frmMH.Show();
            }
        }

        private void kếtQuảHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Kiemtraform("frmKetqua") == false)
            {
                frmKetqua frmKQ = new frmKetqua();
                frmKQ.Name = "frmKetqua";
                frmKQ.MdiParent = this;
                frmKQ.Show();
            }
        }

        #endregion

        #region menu thoat

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult.No == d)
                e.Cancel = true;
        }

        #endregion

        #region Hieu chinh form
        private void xếpTầngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void xếpNgangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void xếpDọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form Childclose in MdiChildren)
            {
                Childclose.Close();
            }
        }
        #endregion

        #region hien form cac tim kiem

        private void xemKếtQuảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Kiemtraform("frmTimKQ") == false)
            {
                frmTimKQ frmk = new frmTimKQ();
                frmk.Name = "frmTimKQ";
                frmk.MdiParent = this;
                frmk.Show();
            }
        }

        private void họcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Kiemtraform("frmTimcobanHV") == false)
            {
                frmTimHV frmTimhv = new frmTimHV();
                frmTimhv.Name = "frmTimcobanHV";
                frmTimhv.MdiParent = this;
                frmTimhv.Show();
            }
        }

        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Kiemtraform("frmTimcobanLH") == false)
            {
                frmTimLH frmTimlh = new frmTimLH();
                frmTimlh.Name = "frmTimcobanLH";
                frmTimlh.MdiParent = this;
                frmTimlh.Show();
            }
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Kiemtraform("frmTimcobanMH") == false)
            {
                frmTimMH frmTimmh = new frmTimMH();
                frmTimmh.Name = "frmTimcobanMH";
                frmTimmh.MdiParent = this;
                frmTimmh.Show();
            }
        }

        #endregion

        #region goi form bao cao va thong ke

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Kiemtraform("frmBaocao") == false)
            {
                frmBaocao frmr = new frmBaocao();
                frmr.Name = "frmBaocao";
                frmr.MdiParent = this;
                frmr.Show();
            }
        }

        private void chọnLọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Kiemtraform("frmDSKQ") == false)
            {
                frmDSKQ frm = new frmDSKQ();
                frm.Name = "frmDSKQ";
                frm.MdiParent = this;
                frm.Show();
            }
        }

        #endregion

        #region Load file tro giup

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Help.pdf");
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("AboutWin.pdf");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("About.pdf");
        }
        #endregion

    }
}