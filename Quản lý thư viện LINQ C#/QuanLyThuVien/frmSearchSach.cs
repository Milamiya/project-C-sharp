using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
namespace QuanLyThuVien
{
    public partial class frmSearchSach : DevComponents.DotNetBar.Office2007Form
    {
        public frmSearchSach()
        {
            InitializeComponent();
        }

        private void frmSearchSach_Load(object sender, EventArgs e)
        {
           
        }

        void AutoCompleteChuyenNganh(int i)
        {
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            auto.Clear();
            if (i == 0)
            {
                var tbDS = (from tb in db.tbDauSaches select tb.ChuyenNganh);
                if (tbDS != null)
                {
                    foreach (var item in tbDS)
                    {
                        auto.Add(item.Trim());
                    }
                }
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = auto;
            }
            if (i==1)
            {
                var tbDS = (from tb in db.tbDauSaches select tb.TenSach);
                if (tbDS!=null)
                {
                    foreach (var item in tbDS)
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
                var tbDS = (from tb in db.tbDauSaches
                            join tbtg in db.tbTGs on tb.MaTG equals tbtg.MaTG
                            select tbtg.TenTG);
                if (tbDS !=null)
                {
                    foreach (var item in tbDS)
                    {
                        auto.Add(item.Trim());
                    }
                }
                txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = auto;
            }
            if (i==3)
            {
                var tbDS = (from tb in db.tbDauSaches
                            join tbnxb in db.tbNXBs
                                on tb.MaNXB equals tbnxb.MaNXB
                            select tbnxb.TenNXB);
                if (tbDS != null)
                {
                    foreach (var item in tbDS)
                    {
                        auto.Add(item.Trim());
                    }
                }
                txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSearch.AutoCompleteCustomSource = auto;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        QLTVDataContext db = new QLTVDataContext();
       
        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        
            if (rdbTS.Checked==true ||rdbChuyenNganh .Checked==true)
            {
                var tbDS =(from tb in db.tbDauSaches
                            join tbtg in db.tbTGs on tb.MaTG equals tbtg.MaTG
                            join tbnxb in db.tbNXBs on tb.MaNXB equals tbnxb.MaNXB
                            where tb.ChuyenNganh.Contains(txtSearch.Text)
                            select new
                            {
                                tb.MaDauSach,
                                tb.TenSach,
                                tbtg.TenTG,
                                tbnxb.TenNXB,
                                tb.NamXuatBan,
                                tb.SoLuong
                            });
                dataGridViewX1.DataSource = tbDS;
              
            }
            if (rdbTenTG.Checked == true)
            {
                var tbDS = (from tb in db.tbDauSaches
                            join tbtg in db.tbTGs on tb.MaTG equals tbtg.MaTG
                            join tbnxb in db.tbNXBs on tb.MaNXB equals tbnxb.MaNXB
                            where tbtg.TenTG.Contains(txtSearch.Text)
                            select new
                            {
                                tb.MaDauSach,
                                tb.TenSach,
                                tbtg.TenTG,
                                tbnxb.TenNXB,
                                tb.NamXuatBan,
                                tb.SoLuong
                            });
                dataGridViewX1.DataSource = tbDS;
            }
            if (rdbNXB.Checked==true)
            {
               var tbDS = (from tb in db.tbDauSaches
                                join tbtg in db.tbTGs on tb.MaTG equals tbtg.MaTG
                                join tbnxb in db.tbNXBs on tb.MaNXB equals tbnxb.MaNXB
                                where tbnxb.TenNXB.Contains(txtSearch.Text)
                                select new
                                {
                                    tb.MaDauSach,
                                    tb.TenSach,
                                    tbtg.TenTG,
                                    tbnxb.TenNXB,
                                    tb.NamXuatBan,
                                    tb.SoLuong
                                });
                    dataGridViewX1.DataSource = tbDS;
                }
            }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            frmQlMuonSach frm = new frmQlMuonSach();
            frm.ShowDialog();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            AutoCompleteChuyenNganh(2);
        }

        private void rdbChuyenNganh_CheckedChanged(object sender, EventArgs e)
        {
            AutoCompleteChuyenNganh(0);
        }

        private void rdbTS_CheckedChanged(object sender, EventArgs e)
        {
            AutoCompleteChuyenNganh(1);
        }

        private void rdbNXB_CheckedChanged(object sender, EventArgs e)
        {
            AutoCompleteChuyenNganh(3);
        }
    }
}
