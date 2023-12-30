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
using QuanLyThuVien.Properties;
namespace QuanLyThuVien
{
    public partial class frmQlDocGia : DevComponents.DotNetBar.Office2007Form
    {
        public frmQlDocGia()
        {
            InitializeComponent();
        }


        QLTVDataContext db = new QLTVDataContext();
        tbDG tbDocGia = new tbDG();





        #region "LoadComBox"
        void LoadCB()
        {
            tbDocGia.LoadComBoBox(cbxChucVu, 0);
        }

        void BtnAdd(bool a)
        {
            btnEdit.Enabled=a;
            btndel.Enabled=a;
    
        }

        void BtnEdit(bool a)
        {
            btnAdd.Enabled=a;
            btndel.Enabled=a;
           // btnclear.Enabled=a;
        }

        void TxtReadOnly(bool a)
        {
            txtMaDG.ReadOnly=a;
            txtTenDG.ReadOnly=a;
            txtLop.ReadOnly=a;
            txtKhoa.ReadOnly=a;
            mktNgaySinh.ReadOnly=a;
            txtGhiChu.ReadOnly=a;
        }

        void LoadDau(int i)
        {
            try
            {
                cbxChucVu.Text = dataGridViewX1.Rows[i].Cells[2].Value.ToString().Trim();
                txtMaDG.Text = dataGridViewX1.Rows[i].Cells[0].Value.ToString().Trim();
                txtTenDG.Text = dataGridViewX1.Rows[i].Cells[1].Value.ToString().Trim();
                txtLop.Text = dataGridViewX1.Rows[i].Cells[3].Value.ToString().Trim();
                txtKhoa.Text = dataGridViewX1.Rows[i].Cells[4].Value.ToString().Trim();
                mktNgaySinh.Text = dataGridViewX1.Rows[i].Cells[5].Value.ToString().Trim();
                cbxGioiTinh.Text = dataGridViewX1.Rows[i].Cells[6].Value.ToString().Trim();
                txtGhiChu.Text = dataGridViewX1.Rows[i].Cells[7].Value.ToString().Trim();
            }
            catch
            { return; }
        }
        #endregion
        private void frmQlDocGia_Load(object sender, EventArgs e)
        {
            DataLoadOptions dlo = new DataLoadOptions();
            dlo.LoadWith<tbDG>(t => t.tbThes);
            db.LoadOptions = dlo;
            LoadCB();
            tbDocGia.LoadGridView(dataGridViewX1);
            labelX1.Focus();
            LoadDau(0);

            lblTong.Text = ( dataGridViewX1.Rows.Count -2).ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            TxtReadOnly(false);
            foreach (Control ctr in groupBox1.Controls)
            {
                if (ctr is TextBox || ctr is ComboBox || ctr is MaskedTextBox)
                {
                    ctr.Text = "";
                    cbxChucVu.Focus();
                }
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            BtnEdit(true);
            BtnAdd(true);
            TxtReadOnly(true);
            btnAdd.Image = Resources.add1_;
            btnEdit.Image = Resources.edit;
        }

        private void cbxChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaDG.Focus();
        }
        int dong;
        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;
                cbxChucVu.Text = dataGridViewX1.Rows[dong].Cells[2].Value.ToString().Trim();
                txtMaDG.Text = dataGridViewX1.Rows[dong].Cells[0].Value.ToString().Trim();
                txtTenDG.Text = dataGridViewX1.Rows[dong].Cells[1].Value.ToString().Trim();
                txtLop.Text = dataGridViewX1.Rows[dong].Cells[3].Value.ToString().Trim();
                txtKhoa.Text = dataGridViewX1.Rows[dong].Cells[4].Value.ToString().Trim();
                mktNgaySinh.Text = dataGridViewX1.Rows[dong].Cells[5].Value.ToString().Trim();
                cbxGioiTinh.Text = dataGridViewX1.Rows[dong].Cells[6].Value.ToString().Trim();
                txtGhiChu.Text = dataGridViewX1.Rows[dong].Cells[7].Value.ToString().Trim();
            }
            catch
            {
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnEdit.Enabled==false)
            {
                try
                {
                    tbDG tbdgnew = db.tbDGs.Where(tb => tb.MaDG == txtMaDG.Text).SingleOrDefault<tbDG>();
                    if (tbdgnew == null)
                    {
                        if (db.CRUDDocGia('t', txtMaDG.Text, txtTenDG.Text, cbxChucVu.Text, txtLop.Text, txtKhoa.Text, mktNgaySinh.Text, cbxGioiTinh.Text, txtGhiChu.Text) == 1)
                        {
                            db.SubmitChanges();
                            MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Thêm Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã Độc Giả Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Quản Lý Thư Viện");
                }
                finally
                {
                    tbDocGia.LoadGridView(dataGridViewX1);
                    btnAdd.Image = Resources.add1_;
                    btnSave.Enabled = false;
                    TxtReadOnly(true);
                    BtnAdd(true);
                }
            }
            if (btnAdd.Enabled==false)
            {
                try
                {
                    txtMaDG.ReadOnly = true;
                    if (MessageBox.Show("Bạn Có Muốn Sửa Không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        tbDG tbdgnew = db.tbDGs.Where(tb => tb.MaDG == txtMaDG.Text).SingleOrDefault<tbDG>();
                        if (tbdgnew != null)
                        {
                            tbdgnew.TenDG = txtTenDG.Text.Trim();
                            tbdgnew.ChucVu = cbxChucVu.Text.Trim();
                            tbdgnew.Lop = txtLop.Text.Trim();
                            tbdgnew.Khoa = txtKhoa.Text.Trim();
                            tbdgnew.NgaySinh = mktNgaySinh.Text.Trim();
                            tbdgnew.GioiTinh = cbxGioiTinh.Text.Trim();
                            tbdgnew.GhiChu = txtGhiChu.Text.Trim();
                            db.SubmitChanges();
                            MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Không Sửa Được", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }


                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông Báo");
                }
                finally
                {
                    var query = (from tb in db.tbDGs select tb);
                    dataGridViewX1.DataSource = query;
                    btnEdit.Image = Resources.edit;
                    btnSave.Enabled = false;
                    TxtReadOnly(true);
                    BtnEdit(true);
                }
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa Không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tbDG tbdgnew = db.tbDGs.Where(tb => tb.MaDG == txtMaDG.Text).SingleOrDefault<tbDG>();
                    if (tbdgnew!=null)
                    {
                        if (db.CRUDDocGia('x', txtMaDG.Text, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty) == 1)
                        {
                            db.SubmitChanges();
                            MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không Xóa Được", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    } 
                    else
                    {
                        MessageBox.Show("Mã Độc Giả Không Tồn Tại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Question);
                    }
                    
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
            finally
            {
                tbDocGia.LoadGridView(dataGridViewX1);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Image = Resources.Cancel;
            BtnAdd(false);
            btnSave.Enabled = true;
            TxtReadOnly(false);
            cbxChucVu.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Image = Resources.Cancel;
            BtnEdit(false);
            btnSave.Enabled = true;
            TxtReadOnly(false);
            txtMaDG.ReadOnly = true;
        }
        int row = 0;
        private void btnfirst_Click(object sender, EventArgs e)
        {
            row = 0;
            LoadDau(row);
            lblrow.Text = row.ToString();
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            if (row != 0)
            {
                row--;
                LoadDau(row);
                lblrow.Text = row.ToString();
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (row<dataGridViewX1.Rows.Count-2)
            {
                 row++;
                 LoadDau(row);
                 lblrow.Text = row.ToString();
            }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            row = dataGridViewX1.Rows.Count - 2;
            LoadDau(row);
            lblrow.Text = (dataGridViewX1.Rows.Count - 2).ToString();
        }

        private void frmQlDocGia_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
        }

      

    

      
    }
}
