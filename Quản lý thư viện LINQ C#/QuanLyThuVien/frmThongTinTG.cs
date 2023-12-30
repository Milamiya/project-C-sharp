using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Resources;
using DevComponents.DotNetBar.Validator;
using QuanLyThuVien.Properties;
namespace QuanLyThuVien
{
    public partial class frmThongTinTG : DevComponents.DotNetBar.Office2007Form
    {
        public frmThongTinTG()
        {
            InitializeComponent();
        }

        QLTVDataContext db = new QLTVDataContext();
        tbTG tbtg = new tbTG();

  



        private void frmThongTinTG_Load(object sender, EventArgs e)
        {
          
            txtReadOnly(true);
            DataLoadOptions dlo = new DataLoadOptions();
            dlo.LoadWith<tbTG>(tg => tg.tbDauSaches);
            db.LoadOptions = dlo;
            var query=from tg in db.tbTGs
                      select tg;
            dataGridViewX1.DataSource = query;

            txtMa.Text = dataGridViewX1.Rows[0].Cells[0].Value.ToString().Trim();
            txtTen.Text = dataGridViewX1.Rows[0].Cells[1].Value.ToString().Trim();
            txtDC.Text = dataGridViewX1.Rows[0].Cells[2].Value.ToString().Trim();
            txtTel.Text = dataGridViewX1.Rows[0].Cells[3].Value.ToString().Trim();
            txtEmail.Text = dataGridViewX1.Rows[0].Cells[4].Value.ToString().Trim();
            labelX1.Focus();
        }

        int dong;
        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;
                txtMa.Text = dataGridViewX1.Rows[dong].Cells[0].Value.ToString().Trim();
                txtTen.Text = dataGridViewX1.Rows[dong].Cells[1].Value.ToString().Trim();
                txtDC.Text = dataGridViewX1.Rows[dong].Cells[2].Value.ToString().Trim();
                txtTel.Text = dataGridViewX1.Rows[dong].Cells[3].Value.ToString().Trim();
                txtEmail.Text = dataGridViewX1.Rows[dong].Cells[4].Value.ToString().Trim();
                
            }
            catch 
            {
                return;
            }
        }

    

        private void btncle_Click(object sender, EventArgs e)
        {
            txtReadOnly(false);
            foreach (Control ctr in groupBox1.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                    labelX1.Focus();
                }
            }
        }


        void txtReadOnly(bool a)
        {
            txtMa.ReadOnly=a;
            txtTen.ReadOnly=a;
            txtDC.ReadOnly=a;
            txtTel.ReadOnly=a;
            txtEmail.ReadOnly=a;
        }

        void BtnThem(bool a)
        {
           // btncle.Enabled = a;
            btnupdate.Enabled = a;
            btndel.Enabled = a;
        }


        void BtnSua(bool a)
        {
           // btncle.Enabled = a;
            btninsert.Enabled = a;
            btndel.Enabled = a;
        }


        private void btninsert_Click(object sender, EventArgs e)
        {
            txtMa.Focus();
            buttonX1.Enabled = true;
            btninsert.Image = Resources.Cancel;
            txtReadOnly(false);
            BtnThem(false);
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                
                tbTG tg = db.tbTGs.Where(n => n.MaTG == txtMa.Text).SingleOrDefault<tbTG>();
                if (tg==null)
                {
                    MessageBox.Show("Mã Tác Giả Không Tồn Tại");
                    txtMa.Focus();
                    return;
                }
                if (MessageBox.Show("Bạn Có Muốn Xóa Không ?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                      if (db.CRUDTacGia('x', txtMa.Text, String.Empty, String.Empty, String.Empty, String.Empty) == 1)
                    {
                        db.SubmitChanges();
                        MessageBox.Show("Xóa Thành Công");
                    }
                    else
                        MessageBox.Show("Xóa Thất Bại");
                }
                frmThongTinTG_Load(sender, e);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"Quản Lý Thư Viên");
            }
        }

        

    


  

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
                btnupdate.Image = Resources.Cancel;
                buttonX1.Enabled = true;
                txtReadOnly(false);
                txtMa.ReadOnly = true;
                BtnSua(false); 
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (btnupdate.Enabled == false)
            {
                try
                {
                    if (txtMa.Text == "" || txtTen.Text == "")
                    {
                        MessageBox.Show("Bạn Phải Nhập Đầy Đủ Thông Tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    tbTG tg = db.tbTGs.Where(n => n.MaTG == txtMa.Text).SingleOrDefault<tbTG>();
                    if (tg != null)
                    {
                        MessageBox.Show("Mã Tác Giả Đã Tồn Tại", "Quản Lý Thư Viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMa.Focus();
                        return;
                    }
                    if (db.CRUDTacGia('t', txtMa.Text, txtTen.Text, txtDC.Text, txtTel.Text, txtEmail.Text) == 1)
                    {
                        db.SubmitChanges();
                        MessageBox.Show("Thêm Thành Công");

                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Quản Lý Thư Viên");
                }
                finally
                {
                    BtnThem(true);
                    btninsert.Image = Resources.add1_;
                    frmThongTinTG_Load(sender, e);
                    buttonX1.Enabled = false;
                    
                }
            }
            if (btninsert.Enabled == false)
            {
                try
                {

                    tbTG tg = db.tbTGs.Where(n => n.MaTG == txtMa.Text.Trim()).SingleOrDefault<tbTG>();
                    if (tg != null)
                    {
                        tg.TenTG = txtTen.Text.Trim();
                        tg.DiaChi = txtDC.Text.Trim();
                        tg.SDT = txtTel.Text.Trim();
                        tg.Email = txtEmail.Text.Trim();
                        if (MessageBox.Show("Bạn có muốn sửa không", "Quản Lý Thư Viện", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.SubmitChanges();
                            MessageBox.Show("Sửa Thành Công");
                        }
                        else
                            MessageBox.Show("Sửa Thất Bại");

                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Quản Lý Thhư Viện");
                }
                finally
                {
                    frmThongTinTG_Load(sender, e);
                    btnupdate.Enabled = true;
                    BtnSua(true);
                    buttonX1.Enabled = false;
                    btnupdate.Image = Resources.edit;
                }
            }
          
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            BtnSua(true);
            BtnThem(true);
            frmThongTinTG_Load(sender, e);
            btninsert.Image = Resources.add1_;
            btnupdate.Image = Resources.edit;
            buttonX1.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmThongTinTG_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
        }
    }
}
