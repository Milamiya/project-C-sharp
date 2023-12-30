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
using System.Data.Linq;
namespace QuanLyThuVien
{
    public partial class frmQLDauSach : DevComponents.DotNetBar.Office2007Form
    {
        public frmQLDauSach()
        {
            InitializeComponent();
        }

    #region "ReadOnly"
        void txtReadOnly(bool a)
        {
            txtNam.ReadOnly=a;
            txtTen.ReadOnly=a;
            txtMa.ReadOnly=a;
            txtChuyenNganh.ReadOnly=a;
            txtSoLuong.ReadOnly=a;
            txtGhiChu.ReadOnly=a;
        }
#endregion
    #region "Enable Button"

        void BtnThem(bool a)
        {
          
            btnupdate.Enabled = a;
            btndel.Enabled = a;
        }


        void BtnSua(bool a)
        {
  
            btninsert.Enabled = a;
            btndel.Enabled = a;
        }
#endregion


        QLTVDataContext db = new QLTVDataContext();
        tbTG tg = new tbTG();
        tbNXB tbnxb = new tbNXB();
        tbDauSach tbDS = new tbDauSach();
        private void frmQLDauSach_Load(object sender, EventArgs e)
        {
            DataLoadOptions dlo = new DataLoadOptions();
            dlo.LoadWith<tbDauSach>(tgs => tgs.tbTG);
            dlo.LoadWith<tbDauSach>(nxb => nxb.tbNXB);
            dlo.LoadWith<tbDauSach>(sach => sach.tbSaches);
            db.LoadOptions = dlo;
            tbDS.LoadGridView(dataGridViewX1);
            tg.LoadComBoBox(cbxTG);
            tbnxb.LoadCBNXB(cbxNXB);
            lblCount.Text = tbDS.DemSach().ToString();
            LoadDau(0);
            lbltime.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second +"     " +DateTime.Now.Day+"//"+DateTime.Now.Month+"//"+DateTime.Now.Year;
            
        }

        void LoadDau(int i)
        {
            txtMa.Text = dataGridViewX1.Rows[i].Cells[0].Value.ToString().Trim();
            txtTen.Text = dataGridViewX1.Rows[i].Cells[1].Value.ToString().Trim();
            cbxNXB.Text = dataGridViewX1.Rows[i].Cells[2].Value.ToString().Trim();
            cbxTG.Text = dataGridViewX1.Rows[i].Cells[3].Value.ToString().Trim();
            txtNam.Text = dataGridViewX1.Rows[i].Cells[4].Value.ToString().Trim();
            txtChuyenNganh.Text = dataGridViewX1.Rows[i].Cells[5].Value.ToString().Trim();
            txtSoLuong.Text = dataGridViewX1.Rows[i].Cells[6].Value.ToString().Trim();
            txtGhiChu.Text = dataGridViewX1.Rows[i].Cells[7].Value.ToString().Trim();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in groupBox1.Controls)
            {
                if (ctr is TextBox || ctr is ComboBox)
                {
                    ctr.Text = "";
                    txtMa.Focus();
                    txtReadOnly(false);
                }
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            txtReadOnly(false);
            btninsert.Image = Resources.Cancel;
            btnSave.Enabled = true;
            BtnThem(false);
            txtMa.Focus();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            txtReadOnly(false);
            txtMa.ReadOnly = true;
            txtTen.Focus();
            btnupdate.Image = Resources.Cancel;
            btnSave.Enabled = true;
            BtnSua(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BtnThem(true);
            BtnSua(true);
            txtReadOnly(true);
            btninsert.Image = Resources.add1_;
            btnupdate.Image = Resources.edit;
            

        }

        public tbDauSach UpdateDauSach(tbDauSach ds)
        {
            ds.TenSach = txtTen.Text.Trim();
            ds.MaTG = tg.GetMaTG(cbxTG.Text);
            return ds;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnupdate.Enabled == false)
            {
                try
                {
                    tbDauSach dausach = db.tbDauSaches.Where(ds => ds.MaDauSach == txtMa.Text).SingleOrDefault<tbDauSach>();
                    if (dausach != null)
                    {
                        MessageBox.Show("Mã Đầu Sách Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMa.Focus();
                        return;
                    }
                    else
                    {
                        if (db.CRUDDauSach('t', txtMa.Text, txtTen.Text, tbnxb.GetMaNXB(cbxNXB.Text), tg.GetMaTG(cbxTG.Text), txtNam.Text, txtChuyenNganh.Text, int.Parse(txtSoLuong.Text), txtGhiChu.Text) == 0)
                        {
                            db.SubmitChanges();
                            MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Thêm Thất Bại");
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "Quản Lý Thư Viện");
                }
                finally
                {
                    btninsert.Image = Resources.add1_;
                    btnSave.Enabled = false;
                    BtnThem(true);
                    txtReadOnly(true);
                    tbDS.LoadGridView(dataGridViewX1);
                    lblCount.Text = tbDS.DemSach().ToString();
                }
            }
            if (btninsert.Enabled==false)
            {
                try
                {
                    // Sửa.
                    tbDauSach dausach = db.tbDauSaches.Where(ds => ds.MaDauSach == txtMa.Text).SingleOrDefault<tbDauSach>();
                    if (dausach != null)
                    {
                        if (db.CRUDDauSach('t', txtMa.Text, txtTen.Text, tbnxb.GetMaNXB(cbxNXB.Text), tg.GetMaTG(cbxTG.Text), txtNam.Text, txtChuyenNganh.Text, int.Parse(txtSoLuong.Text), txtGhiChu.Text) == 0)
                        {
                            db.SubmitChanges();
                            MessageBox.Show("Sửa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                            MessageBox.Show("Không Sửa Được", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Mã Đầu Sách Không Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //db.tbDauSaches.Attach(tbDS);
                    //tbDS.MaDauSach = txtMa.Text.Trim();
                    //tbDS.TenSach = txtTen.Text.Trim();
                    //tbDS.MaNXB = tbnxb.GetMaNXB2(cbxNXB.Text);
                    //tbDS.MaTG = tg.GetMaTG(cbxTG.Text);
                    //tbDS.ChuyenNganh = txtChuyenNganh.Text.Trim();
                    //tbDS.SoLuong = int.Parse(txtSoLuong.Text);
                    //tbDS.NamXuatBan = txtNam.Text.Trim();
                    //db.Refresh(RefreshMode.KeepCurrentValues, tbDS);
                    //  tbDauSach tbdsnew = db.tbDauSaches.Where(ds => ds.MaDauSach == txtMa.Text).SingleOrDefault<tbDauSach>();
                    //var up = (from ds in db.tbDauSaches
                    //          select UpdateDauSach(ds)).ToList();
                    //db.SubmitChanges();
                    ////if (tbdsnew != null)
                    ////{
                    //   tbdsnew.MaNXB = txtMa.Text;



                    //tbdsnew.TenSach = txtTen.Text.Trim();
                    //tbdsnew.NamXuatBan = txtNam.Text.Trim();
                    //tbdsnew.ChuyenNganh = txtChuyenNganh.Text.Trim();
                    //tbdsnew.SoLuong = int.Parse(txtSoLuong.Text.Trim());
                    //tbdsnew.GhiChu = txtGhiChu.Text.Trim();
                    //tbdsnew.MaTG = tg.GetMaTG(cbxTG.Text);
                    //tbdsnew.MaNXB = tbnxb.GetMaNXB2(cbxNXB.Text);

                    //db.tbDauSaches.Attach(tbdsnew);
                    //db.Refresh(RefreshMode.KeepCurrentValues, tbdsnew);


                       // db.SubmitChanges();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Quản Lý Thư Viện");
                }
                finally
                {
                    tbDS.LoadGridView(dataGridViewX1);
                    BtnSua(true);
                    btnSave.Enabled = false;
                    txtReadOnly(true);
                    btnupdate.Image = Resources.edit;
                }
            }
        }

        int dong;
        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dong = e.RowIndex;
                txtMa.Text = dataGridViewX1.Rows[dong].Cells[0].Value.ToString().Trim();
                txtTen.Text = dataGridViewX1.Rows[dong].Cells[1].Value.ToString().Trim();
                cbxNXB.Text = dataGridViewX1.Rows[dong].Cells[2].Value.ToString().Trim();
                cbxTG.Text = dataGridViewX1.Rows[dong].Cells[3].Value.ToString().Trim();
                txtNam.Text = dataGridViewX1.Rows[dong].Cells[4].Value.ToString().Trim();
                txtChuyenNganh.Text = dataGridViewX1.Rows[dong].Cells[5].Value.ToString().Trim();
                txtSoLuong.Text = dataGridViewX1.Rows[dong].Cells[6].Value.ToString().Trim();
                txtGhiChu.Text = dataGridViewX1.Rows[dong].Cells[7].Value.ToString().Trim();
            }
            catch
            {
                return;
            }
        }

        private void cbxTG_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxNXB.Focus();
        }

        private void cbxNXB_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNam.Focus();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Phải Nhập Mã Sách", "Thông Bá", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Bạn Có Muốn Xóa Không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                         tbDauSach dausach = db.tbDauSaches.Where(ds => ds.MaDauSach == txtMa.Text).SingleOrDefault<tbDauSach>();
                        if (dausach !=null)
                        {
                            if (db.CRUDDauSach('x', txtMa.Text, String.Empty, String.Empty, String.Empty, String.Empty, String.Empty, null, String.Empty) == 0)
                            {
                                MessageBox.Show("Xóa Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("Không Xóa Được", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        } 
                        else
                        {
                            MessageBox.Show("Mã Đầu Sách Không Tồn Tại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Question);
                        }
              
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Quản Lý Thư Viện");
                }
                finally
                {
                    tbDS.LoadGridView(dataGridViewX1);
                    lblCount.Text = tbDS.DemSach().ToString();
                    LoadDau(dong - 1);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "     " + DateTime.Now.Day + "//" + DateTime.Now.Month + "//" + DateTime.Now.Year;
        }

        private void frmQLDauSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
        }
    }
}
