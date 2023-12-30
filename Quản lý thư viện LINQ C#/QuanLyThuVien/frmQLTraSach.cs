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
    public partial class frmQLTraSach : DevComponents.DotNetBar.Office2007Form
    {
        public frmQLTraSach()
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
                             tbSACH.MaDauSach,
                             tbSACH.MaSach,
                             tbTHE.MaThe,
                             tbTHE.tbDG.TenDG,
                             tbPM.NgayMuon,
                             tbPM.NgayTra,

                         });

            dataGridViewX1.DataSource = query;
        }
        #endregion

        QLTVDataContext db = new QLTVDataContext();
        tbDauSach tbDS = new tbDauSach();
        tbSach tbs = new tbSach();
        tbThe tbthe = new tbThe();
        tbDG tbdoc = new tbDG();
        private void frmQLTraSach_Load(object sender, EventArgs e)
        {
            DataLoadOptions dlo = new DataLoadOptions();
            dlo.LoadWith<tbPhieuMuon>(tb => tb.tbSach);
            dlo.LoadWith<tbPhieuMuon>(tb => tb.tbThe);
            db.LoadOptions = dlo;
            LoadGridView();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in groupBox1.Controls)
            {
                if (ctr is TextBox || ctr is ComboBox || ctr is MaskedTextBox)
                {
                    ctr.Text = "";
                }
            }
            cbxTenSach.Focus();
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
        DateTime CatLayNgayThang(string s)
        {
            s = s.Trim();
            string ngay = s.Substring(0, s.IndexOf('/'));
            string thang = s.Substring(s.IndexOf('/') + 1, s.LastIndexOf('/') - ngay.Length - 1);
            string nam = s.Substring(s.LastIndexOf('/') + 1);
            DateTime dt = new DateTime(int.Parse(nam), int.Parse(thang), int.Parse(ngay));
            return dt;
        }
           
        DateTime date = new DateTime(DateTime.Now.Year,DateTime.Now.Month, DateTime.Now.Day);
        private void buttonX2_Click(object sender, EventArgs e)
        {     
            try
            {
                if (MessageBox.Show("Bạn Có Muốn Trả Sách Không","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    CatLayNgayThang(txtTra.Text);
                    TimeSpan songay = date - CatLayNgayThang(txtTra.Text);
                    int ngay = Convert.ToInt32(songay.TotalDays);
                    if (ngay > 0)
                    {
                        MessageBox.Show("Bạn Trả Sách Không Đúng Hạn", "Nhắc Nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (db.CRUDPhieuMuon('x',cbxMaSach.Text,cbxMaThe.Text,txtMuon.Text,String.Empty)==1)
                    {  
                        db.SubmitChanges();
                        MessageBox.Show("Trả Sách Thành Công");
                    }
                    else
                        MessageBox.Show("Trả Sách Thất Bại");
                    LoadGridView();
                    btnclear.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Quản Lý Thư Viện");
            }

        }

        private void cbxTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
