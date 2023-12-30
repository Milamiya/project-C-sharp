using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
namespace QuanLyThuVien
{
    public partial class frmQlMuonSach : DevComponents.DotNetBar.Office2007Form
    {
        public frmQlMuonSach()
        {
            InitializeComponent();
        }
        #region "Load lên GridView"
        void LoadGridView()
        {
            var query = (from tbPM in db.tbPhieuMuons
                         join tbTHE in db.tbThes on tbPM.MaThe equals tbTHE.MaThe
                         join tbSACH in db.tbSaches on tbPM.MaSach equals tbSACH.MaSach
                         select new
                         {
                             tbSACH.tbDauSach.TenSach,
                             tbSACH.tbDauSach.ChuyenNganh,
                             //TENSACH = (from tbSACHNew in tbSACH.MaDauSach
                             //           join tbDAUSACH in db.tbDauSaches
                             //               on tbSACHNew equals tbDAUSACH.MaDauSach
                             //           select tbDAUSACH.TenSach),
                             //TêNSácH = (from tbDAUSACH in db.tbDauSaches
                             //             where  tbDAUSACH.MaDauSach==tbSACH.MaDauSach
                             //             select tbDAUSACH.TenSach),
                             //CHUYENNGANH = (from tbSACHNew in tbSACH.MaDauSach
                             //               join tbDAUSACH in db.tbDauSaches
                             //                   on tbSACHNew equals tbDAUSACH.MaDauSach
                             //               select tbDAUSACH.ChuyenNganh),
                             //CHUYENNGANH=(from tbDAUSACH in db.tbDauSaches
                             //                 where tbDAUSACH.MaDauSach==tbSACH.MaDauSach
                             //                 select tbDAUSACH.ChuyenNganh),
                             tbSACH.MaDauSach,
                             tbSACH.MaSach,
                             tbTHE.MaThe,
                             tbTHE.tbDG.TenDG,
                             tbPM.NgayMuon,
                             tbPM.NgayTra,
                             
                             //TENDOCGIA=(from tbTHENew in tbTHE.MaDG
                             //               join tbDOCGIA in db.tbDGs
                             //                   on tbTHENew equals tbDOCGIA.MaDG
                             //               select tbDOCGIA.TenDG)
                             //TENDOCGIA = (from tbDOCGIA in db.tbDGs
                             //             where tbDOCGIA.MaDG == tbTHE.MaDG
                             //             select tbDOCGIA.TenDG),
                          
                         });

            dataGridViewX1.DataSource = query;
        }
        #endregion
        
        QLTVDataContext db = new QLTVDataContext();
        tbDauSach tbDS = new tbDauSach();
        tbSach tbs = new tbSach();
        tbThe tbthe = new tbThe();
        tbDG tbdoc = new tbDG();
        DateTime date = DateTime.Now;
        private void frmQlMuonSach_Load(object sender, EventArgs e)
        {
            DataLoadOptions dlo = new DataLoadOptions();
            dlo.LoadWith<tbPhieuMuon>(tb => tb.tbSach);
            dlo.LoadWith<tbPhieuMuon>(tb => tb.tbThe);
            db.LoadOptions = dlo;
            labelX1.Focus();
            tbDS.LoadComBoBox(cbxTenSach,cbxao,1);
            tbthe.LoadCBX(cbxMaThe);
            
            LoadGridView();
            LoadDau();
            txtMuon.Text=date.ToString("dd/MM/yyyy");
            txtTra.Text=date.AddDays(7).ToString("dd/MM/yyyy");
            
        }



        void LoadDau()
        {
            cbxTenSach.Text = dataGridViewX1.Rows[0].Cells[0].Value.ToString().Trim();
            cbxChuyenNganh.Text = dataGridViewX1.Rows[0].Cells[1].Value.ToString().Trim();
            cbxMaDS.Text = dataGridViewX1.Rows[0].Cells[2].Value.ToString().Trim();
            cbxMaSach.Text = dataGridViewX1.Rows[0].Cells[3].Value.ToString().Trim();
            cbxMaThe.Text = dataGridViewX1.Rows[0].Cells[4].Value.ToString().Trim();
            textBoxX1.Text = dataGridViewX1.Rows[0].Cells[5].Value.ToString().Trim();
            txtMuon.Text = dataGridViewX1.Rows[0].Cells[6].Value.ToString().Trim();
            txtTra.Text = dataGridViewX1.Rows[0].Cells[7].Value.ToString().Trim();
        }
        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void cbxTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbDS.LoadComBoBox(cbxTenSach,cbxChuyenNganh, 3);
            cbxChuyenNganh.Focus();
            tbDS.LoadComBoBox(cbxTenSach, cbxMaDS, 2);
        }

        private void cbxMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxMaThe.Focus();
        }

        private void cbxMaDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbs.CBXLoadTheoMaDS(cbxMaSach, cbxMaDS.Text);
            cbxMaSach.Focus();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in  groupBox1.Controls)
            {
                if (ctr is TextBox || ctr is ComboBox)
                {
                    ctr.Text = "";
                    cbxTenSach.Focus();
                    txtMuon.Text = date.ToString("dd/MM/yyyy");
                    txtTra.Text = date.AddDays(7).ToString("dd/MM/yyyy");
                }
            }
        }

        private void cbxMaThe_SelectedIndexChanged(object sender, EventArgs e)
        {
           textBoxX1.Text=  tbdoc.GetTenDG(cbxMaThe.Text);
       
        }

        int dong;
        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;
                cbxTenSach.Text = dataGridViewX1.Rows[dong].Cells[0].Value.ToString().Trim();
                cbxChuyenNganh.Text = dataGridViewX1.Rows[dong].Cells[1].Value.ToString().Trim();
                cbxMaDS.Text = dataGridViewX1.Rows[dong].Cells[2].Value.ToString().Trim();
                cbxMaSach.Text = dataGridViewX1.Rows[dong].Cells[3].Value.ToString().Trim();
                cbxMaThe.Text = dataGridViewX1.Rows[dong].Cells[4].Value.ToString().Trim();
                textBoxX1.Text = dataGridViewX1.Rows[dong].Cells[5].Value.ToString().Trim();
                txtMuon.Text = dataGridViewX1.Rows[dong].Cells[6].Value.ToString().Trim();
                txtTra.Text = dataGridViewX1.Rows[dong].Cells[7].Value.ToString().Trim();
            }
            catch 
            {
                return;
            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.CRUDPhieuMuon('t', cbxMaSach.Text, cbxMaThe.Text, txtMuon.Text, txtTra.Text) == 1)
                {
                    db.SubmitChanges();
                    MessageBox.Show("Mượn Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Mượn Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Quản Lý Thư Viện");
            }
            finally
            {
                LoadGridView();
            }
        }

        private void cbxChuyenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxMaDS.Focus();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.CRUDPhieuMuon('x', cbxMaSach.Text, cbxMaThe.Text, txtMuon.Text, String.Empty) == 1)
                {
                    db.SubmitChanges();
                    MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Xóa Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Quản Lý Thư Viện");
            }
            finally
            {
                LoadGridView();
            }
        }
    
        private void btnIn_Click(object sender, EventArgs e)
        {
            frmInPhieuMuon frm = new frmInPhieuMuon();
            frm.tenDG = textBoxX1.Text;
            frm.maThe = cbxMaThe.Text;
            frm.tenSach = cbxTenSach.Text;
            frm.maSach = cbxMaSach.Text;
            frm.ngayMuon = txtMuon.Text;
            frm.ngayTra = txtTra.Text;
            frm.ShowDialog();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            frmQLTraSach frm = new frmQLTraSach();
            frm.Show();
        }

        private void frmQlMuonSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }
    }
}
