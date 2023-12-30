using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data.Linq;
using QuanLyThuVien.Properties;
namespace QuanLyThuVien
{
    public partial class frmQLThe : DevComponents.DotNetBar.Office2007Form
    {
        public frmQLThe()
        {
            InitializeComponent();
        }

        #region "Hàm Xử Lý"
        void BtnSua(bool a)
        {
           
            btninsert.Enabled = a;
            btndel.Enabled = a;
        }

        void BtnThem(bool a)
        {
            
            btnupdate.Enabled = a;
            btndel.Enabled = a;
        }

        void LoadDau(int i)
        {
            cbxMaDG.Text = dataGridViewX1.Rows[i].Cells[0].Value.ToString().Trim();
            txtTenDG.Text = dataGridViewX1.Rows[i].Cells[1].Value.ToString().Trim();
            cbxChucVu.Text = dataGridViewX1.Rows[i].Cells[2].Value.ToString().Trim();
            txtMaThe.Text = dataGridViewX1.Rows[i].Cells[3].Value.ToString().Trim();
            mklNgayCap.Text = dataGridViewX1.Rows[i].Cells[4].Value.ToString().Trim();
            mktHan.Text = dataGridViewX1.Rows[i].Cells[5].Value.ToString().Trim();
        }


    #endregion


        QLTVDataContext db = new QLTVDataContext();
        tbThe tbTHE = new tbThe();
        tbDG tbDOCGIA = new tbDG();

        DateTime date = DateTime.Now;
        private void frmQLThe_Load(object sender, EventArgs e)
        {
            DataLoadOptions dlo = new DataLoadOptions();
            dlo.LoadWith<tbThe>(tb => tb.tbDG);
            dlo.LoadWith<tbThe>(tb => tb.tbPhieuMuons);
            db.LoadOptions = dlo;

            tbTHE.LoadGridView(dataGridViewX1);

            labelX1.Focus();
            tbDOCGIA.LoadComBoBox(cbxMaDG, 1);
 
            LoadDau(0);
            mklNgayCap.Text = date.ToString("dd/MM/yyyy");
            mktHan.Text = date.AddYears(1).ToString("dd/MM/yyyy");
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
            cbxMaDG.Focus();
            txtMaThe.ReadOnly = false;
            mklNgayCap.Text = date.ToString("dd/MM/yyyy");
            mktHan.Text = date.AddYears(1).ToString("dd/MM/yyyy");
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            btninsert.Image = Resources.Cancel;
            BtnThem(false);
            btnSave.Enabled = true;
            txtMaThe.ReadOnly = false;
            cbxMaDG.Focus();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            btnupdate.Image = Resources.Cancel;
            BtnSua(false);
            btnSave.Enabled = true;
            txtMaThe.ReadOnly = true;
            mklNgayCap.ReadOnly = false;
            mktHan.ReadOnly = false;
            cbxMaDG.Focus();
 
        }

        int dong;
        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;
                cbxMaDG.Text = dataGridViewX1.Rows[dong].Cells[0].Value.ToString().Trim();
                txtTenDG.Text = dataGridViewX1.Rows[dong].Cells[1].Value.ToString().Trim();
                cbxChucVu.Text = dataGridViewX1.Rows[dong].Cells[2].Value.ToString().Trim();
                txtMaThe.Text = dataGridViewX1.Rows[dong].Cells[3].Value.ToString().Trim();
                mklNgayCap.Text = dataGridViewX1.Rows[dong].Cells[4].Value.ToString().Trim();
                mktHan.Text = dataGridViewX1.Rows[dong].Cells[5].Value.ToString().Trim();
            }
            catch 
            {
                return;
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            BtnThem(true);
            BtnSua(true);
            btninsert.Image = Resources.add1_;
            btnupdate.Image = Resources.edit;
            txtMaThe.ReadOnly = true;
            cbxMaDG.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnupdate.Enabled==false)
            {
                try
                {
                    tbThe test = (db.tbThes.Where(t => t.MaThe == txtMaThe.Text).SingleOrDefault<tbThe>());
                    if (test!=null)
                    {
                        MessageBox.Show("Mã Thẻ Đã Tòn Tại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    } 
                    else
                    {
                        if (db.CRUDThe('t', txtMaThe.Text, cbxMaDG.Text, mklNgayCap.Text, mktHan.Text) == 1)
                        {
                           db.SubmitChanges();
                           MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Thêm Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Quản Lý Thư Viện");
                }
                finally
                {
                    tbTHE.LoadGridView(dataGridViewX1);
                    btninsert.Image = Resources.add1_;
                    BtnThem(true);
                    txtMaThe.ReadOnly = true;
                    btnSave.Enabled = false;
                }
            }
            if (btninsert.Enabled==false)
            {
                try
                {
                    if (MessageBox.Show("Bạn Có Muốn Sửa Không","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        tbThe test = (db.tbThes.Where(t => t.MaThe == txtMaThe.Text).SingleOrDefault<tbThe>());
                        if (test != null)
                        {
                            if (db.CRUDThe('t',txtMaThe.Text,cbxMaDG.Text,mklNgayCap.Text,mktHan.Text)==1)
                            {
                                db.SubmitChanges();
                                MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Sửa Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                            MessageBox.Show("Mã Thẻ Không Tòn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Quản Lý Thư Viện");
                }
                finally
                {

                    //var query = (from tbTHE in db.tbThes
                    //             join tbDOCGIA in db.tbDGs
                    //             on tbTHE.MaDG equals tbDOCGIA.MaDG
                    //             select new
                    //             {
                    //                 tbDOCGIA.MaDG,
                    //                 tbDOCGIA.TenDG,
                    //                 tbDOCGIA.ChucVu,
                    //                 tbTHE.MaThe,
                    //                 tbTHE.NgayCap,
                    //                 tbTHE.Han
                    //             });
                    //dataGridViewX1.DataSource = query;
                    tbThe tbthenew = new tbThe();
                    tbthenew.LoadGridView(dataGridViewX1);
                    BtnThem(true);
                    txtMaThe.ReadOnly = true;
                    mklNgayCap.ReadOnly = true;
                    mktHan.ReadOnly = false;
                    btnupdate.Image = Resources.edit;
                    btnSave.Enabled = false;
                }
            }
        }

        private void cbxMaDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenDG.Text=tbDOCGIA.GetTenDG2(cbxMaDG.Text);
            tbDOCGIA.LoadComBoBoxTheoMa(cbxChucVu,cbxMaDG.Text,0);
            cbxChucVu.Focus();
        }

        private void cbxChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaThe.Focus();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa Không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (db.CRUDThe('x', txtMaThe.Text, String.Empty, String.Empty, String.Empty) == 1)
                    {

                        db.SubmitChanges();
                        MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Quản Lý Thư Viện");
            }
            finally
            {
                tbTHE.LoadGridView(dataGridViewX1);

            }
        }

        private void frmQLThe_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
        }

       
    }
}
