using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Validator;
using QuanLyThuVien.Properties;

namespace QuanLyThuVien
{
    public partial class frmThongTinNXB : DevComponents.DotNetBar.Office2007Form
    {
        QLTVDataContext db = new QLTVDataContext();
        tbNXB tb = new tbNXB();
        public frmThongTinNXB()
        {
            InitializeComponent();
        }

        private void frmThongTinNXB_Load(object sender, EventArgs e)
        {
            TextBoxReadOnly(true);
 
            DataLoadOptions dlo = new DataLoadOptions();
            dlo.LoadWith<tbNXB>(nxb => nxb.tbDauSaches);
            db.LoadOptions = dlo;
            var query = from nxb in db.tbNXBs
                        select nxb;
            dataGridViewX1.DataSource = query;

        }

        void TextBoxReadOnly(bool a)
        {
            txtMaNXB.ReadOnly = a;
            txtTenNXB.ReadOnly = a;
            txtDiaChi.ReadOnly = a;
            txtSDT.ReadOnly = a;

        }

        int dong;
        private void dataGridViewX1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;
                txtMaNXB.Text= dataGridViewX1.Rows[dong].Cells[0].Value.ToString().Trim();
                txtTenNXB.Text = dataGridViewX1.Rows[dong].Cells[1].Value.ToString().Trim();
                txtDiaChi.Text = dataGridViewX1.Rows[dong].Cells[2].Value.ToString().Trim();
                txtSDT.Text = dataGridViewX1.Rows[dong].Cells[3].Value.ToString().Trim();
            }
            catch 
            {
                return;
            }

        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                tbNXB tbNXBnew=db.tbNXBs.Where(tb=>tb.MaNXB==txtMaNXB.Text).SingleOrDefault<tbNXB>();

                if (tbNXBnew != null)
                {
                    char? kieu = 'x';

                    if (MessageBox.Show("Bạn có muốn xóa không", "Quản Lý Thư Viện", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && db.uspThemNXb(kieu, txtMaNXB.Text.Trim(), "", "", "") == 1)
                    {
                        db.SubmitChanges();
                        MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Xóa Thất Bại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Mã Nhà Xuất Bản Không Tồn Tại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Question);
       
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Quản Lý Thư Viện");
            }
            finally
            {
                         frmThongTinNXB_Load(sender, e);

            }
        
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            buttonX3.Enabled = true;
            TextBoxReadOnly(false);
            txtMaNXB.ReadOnly = true;
            BtnSua(false);
            btnupdate.Image = Resources.Cancel;
        }


        void BtnSua(bool a)
        {
           // btnclea.Enabled=a;
            btninsert.Enabled=a;
            btndel.Enabled=a;
        }

        void BtnThem(bool a)
        {
           // btnclea.Enabled = a;
            btnupdate.Enabled = a;
            btndel.Enabled = a;
        }

     

        private void txtSDT_KeyPress_1(object sender, KeyPressEventArgs e)
        {
        }

        

        private void btnclea_Click(object sender, EventArgs e)
        {
            TextBoxReadOnly(false);
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    labelX1.Focus();
                    labelX1.TabIndex = 0;
                }

            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            txtMaNXB.Focus();
            buttonX3.Enabled = true;
            btninsert.Image = Resources.Cancel;
            TextBoxReadOnly(false);
            BtnThem(false);
            
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (btnupdate.Enabled==false)
            {

                try
                {

                    char? kieu = 't';
                    tbNXB txb = db.tbNXBs.Where(n => n.MaNXB == txtMaNXB.Text.Trim()).SingleOrDefault<tbNXB>();
                    if (txb != null)
                    {
                        MessageBox.Show("Mã Nhà Xuất Bản Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaNXB.Focus();
                        return;

                    }

                    if (db.uspThemNXb(kieu, txtMaNXB.Text.Trim(), txtTenNXB.Text.Trim(), txtDiaChi.Text.Trim(), txtSDT.Text.Trim()) == 1)
                    {
                        db.SubmitChanges();
                        MessageBox.Show("Thêm Thành Công");
                    }
                    else
                        MessageBox.Show("Thêm Thất Bại");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Quản Lý Thư Viện");
                }
                finally
                {
                    frmThongTinNXB_Load(sender, e);
                    BtnThem(true);
                    btninsert.Image = Resources.add1_;
                    buttonX3.Enabled = false;
                }
            }
            if (btninsert.Enabled==false)
            {
                try
                {
                    tbNXB nxb = db.tbNXBs.Where(n => n.MaNXB == txtMaNXB.Text.Trim()).SingleOrDefault<tbNXB>();
                    if (nxb != null)
                    {
                        nxb.TenNXB = txtTenNXB.Text.Trim();
                        nxb.DiaChi = txtDiaChi.Text.Trim();
                        nxb.SDT = txtSDT.Text.Trim();
                        db.SubmitChanges();
                        MessageBox.Show("Sửa Thành Công");

                    }
                    else
                        MessageBox.Show("Sửa Thất Bại");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Quản Lý Thư Viện");
                }
                finally
                {
                    frmThongTinNXB_Load(sender, e);
                    BtnSua(true);
                    btnupdate.Image = Resources.edit;
                    buttonX3.Enabled = false;
                }
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            TextBoxReadOnly(true);
            BtnThem(true);
            BtnSua(true);
            btninsert.Image = Resources.add1_;
            btnupdate.Image = Resources.edit;
            buttonX3.Enabled = false;
            frmThongTinNXB_Load(sender, e);
        }

        private void frmThongTinNXB_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
        }

   

      

    }
}
