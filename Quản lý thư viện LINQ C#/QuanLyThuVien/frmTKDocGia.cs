using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
namespace QuanLyThuVien
{
    public partial class frmSearchDocGia : DevComponents.DotNetBar.Office2007Form
    {
        public frmSearchDocGia()
        {
            InitializeComponent();
        }

        void AutoComplete(int i)
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            if (i==1)
            {
                var tbDOCGIA = (
                                from tb in db.tbDGs
                                join tbTHE in db.tbThes on tb.MaDG equals tbTHE.MaDG
                                select tb.TenDG);
                if (tbDOCGIA!=null)
                {
                    foreach (var item in tbDOCGIA)
                    {
                        auto.Add(item.Trim());
                    }
                }
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = auto;
            }
            if (i==2)
            {
                var tbDOCGIA = (
                                from tb in db.tbDGs
                                join tbTHE in db.tbThes on tb.MaDG equals tbTHE.MaDG
                                select tb.MaDG);
                if (tbDOCGIA != null)
                {
                    foreach (var item in tbDOCGIA)
                    {
                        auto.Add(item.Trim());
                    }
                }
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = auto;
            }
            if (i==3)
            {
                var tbDOCGIA = (
                                from tb in db.tbDGs
                                join tbTHE in db.tbThes on tb.MaDG equals tbTHE.MaDG
                                select tbTHE.MaThe);
                if (tbDOCGIA != null)
                {
                    foreach (var item in tbDOCGIA)
                    {
                        auto.Add(item.Trim());
                    }
                }
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = auto;
            }
        }

        QLTVDataContext db = new QLTVDataContext();

        private void frmSearchDocGia_Load(object sender, EventArgs e)
        {

        }

        private void rdbTen_CheckedChanged(object sender, EventArgs e)
        {
            AutoComplete(1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdbMa_CheckedChanged(object sender, EventArgs e)
        {
            AutoComplete(2);
        }

        private void rdbMaThe_CheckedChanged(object sender, EventArgs e)
        {
            AutoComplete(3);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rdbTen.Checked==true)
            {
                var tbDOCGIA = (
                                from tb in db.tbDGs
                                join tbTHE in db.tbThes on tb.MaDG equals tbTHE.MaDG
                                where tb.TenDG.Contains(txtSearch.Text)
                                select new
                                {
                                    tb.MaDG,
                                    tb.TenDG,
                                    tb.Lop,
                                    tbTHE.MaThe,
                                });
                dataGridViewX1.DataSource=tbDOCGIA;
                             
            }
            if (rdbMa.Checked==true)
            {
                var tbDOCGIA = (
                               from tb in db.tbDGs
                               join tbTHE in db.tbThes on tb.MaDG equals tbTHE.MaDG
                               where tb.MaDG.Contains(txtSearch.Text)
                               select new
                               {
                                   tb.MaDG,
                                   tb.TenDG,
                                   tb.Lop,
                                   tbTHE.MaThe,
                               });
                dataGridViewX1.DataSource = tbDOCGIA;
            }
            if (rdbMaThe.Checked==true)
            {
                var tbDOCGIA = (
                               from tb in db.tbDGs
                               join tbTHE in db.tbThes on tb.MaDG equals tbTHE.MaDG
                               where tbTHE.MaThe.Contains(txtSearch.Text)
                               select new
                               {
                                   tb.MaDG,
                                   tb.TenDG,
                                   tb.Lop,
                                   tbTHE.MaThe,
                               });
                dataGridViewX1.DataSource = tbDOCGIA;
            }
          
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
