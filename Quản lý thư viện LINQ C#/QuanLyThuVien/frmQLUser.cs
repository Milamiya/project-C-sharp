using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyThuVien.Properties;
namespace QuanLyThuVien
{
    public partial class frmQLUser : DevComponents.DotNetBar.Office2007Form
    {
        public frmQLUser()
        {
            InitializeComponent();


        }

    #region 
        void BtnInSert(bool a)
        {
            btnupdate.Enabled=a;
            btndel.Enabled=a;
        }

        void BtnUpdate(bool a)
        {
            btninsert.Enabled=a;
            btndel.Enabled=a;
        }

        void TxTReadOnly(bool a)
        {
            txtusername.ReadOnly=a;
            txtpass.ReadOnly=a;
        }

        void LoadDau(int i)
        {
            txtusername.Text = dataGridViewX1.Rows[i].Cells[0].Value.ToString().Trim();
            txtpass.Text = dataGridViewX1.Rows[i].Cells[1].Value.ToString().Trim();
            txtquyen.Text = dataGridViewX1.Rows[i].Cells[2].Value.ToString().Trim();
        }
    #endregion

        QLTVDataContext db = new QLTVDataContext();
        tbUser tbUSER = new tbUser();
        private void frmQLUser_Load(object sender, EventArgs e)
        {
            tbUSER.LoadGridView(dataGridViewX1);
            LoadDau(0);
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in groupBox1.Controls)
            {
                if (ctr is TextBox)
                    ctr.Text = "";
            }
            TxTReadOnly(false);
            txtusername.Focus();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            btninsert.Image = Resources.Cancel;
            BtnInSert(false);
            TxTReadOnly(false);
            btnSave.Enabled = true;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            btnupdate.Image = Resources.Cancel;
            BtnUpdate(false);
            TxTReadOnly(false);
            btnSave.Enabled = true;
            txtusername.ReadOnly = true;
            txtquyen.ReadOnly = false;
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa Không", "Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    tbUser tbusnew=(db.tbUsers.Where(t=>t.TenDN==txtusername.Text).SingleOrDefault<tbUser>());
                    if (tbusnew!=null)
                    {
                        if (db.CRUDUser('x',txtusername.Text,txtpass.Text)==1)
                        {
                            db.SubmitChanges();
                            MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Xóa Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
	                 }
                     else
                        MessageBox.Show("Tên Không Tồn Tại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Question);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Quản Lý Thư Viện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                tbUSER.LoadGridView(dataGridViewX1);

            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            BtnInSert(true);
            BtnUpdate(true);
            TxTReadOnly(true);
            btninsert.Image = Resources.add1_;
            btnupdate.Image = Resources.edit;
            btnSave.Enabled = false;
        }
        int dong;
        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;
                txtusername.Text = dataGridViewX1.Rows[dong].Cells[0].Value.ToString().Trim();
                txtpass.Text = dataGridViewX1.Rows[dong].Cells[1].Value.ToString().Trim();
                txtquyen.Text = dataGridViewX1.Rows[dong].Cells[2].Value.ToString().Trim();
            }
            catch 
            {
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (btnupdate.Enabled==false)
            {
                try
                {
                    tbUser tbUSERNEW = (db.tbUsers.Where(t => t.TenDN == txtusername.Text).SingleOrDefault<tbUser>());
                    if (tbUSERNEW!=null)
                    {
                        MessageBox.Show("Tên Người Dùng Đã Tồn Tại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    } 
                    else
                    {
                        if (db.CRUDUser('t',txtusername.Text,txtpass.Text)==1)
                        {
                            db.SubmitChanges();
                            MessageBox.Show("Thêm Thành Công","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
                    tbUSER.LoadGridView(dataGridViewX1);
                    BtnInSert(true);
                    TxTReadOnly(true);
                    btnSave.Enabled = false;
                    btninsert.Image = Resources.add1_;
                }
            }
            if (btninsert.Enabled==false)
            {
                tbUser tbUSERNEW = (db.tbUsers.Where(t => t.TenDN == txtusername.Text).SingleOrDefault<tbUser>());
                try
                {
                    
                    if (tbUSERNEW != null)
                    {
                        tbUSERNEW.pass = txtpass.Text;
                        tbUSERNEW.Quyen =int.Parse( txtquyen.Text);
                        db.SubmitChanges();
                        MessageBox.Show("Sửa Thành Công","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Quản Lý Thư Viện");
                }
                finally
                {
                    tbUSERNEW.LoadGridView(dataGridViewX1);
                    BtnUpdate(true);
                    TxTReadOnly(true);
                    btnSave.Enabled = false;
                    btnupdate.Image = Resources.edit;
                }
            }
        }

        private void frmQLUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
        }
    }
}
