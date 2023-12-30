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
namespace QuanLyThuVien
{
    public partial class frmSach : DevComponents.DotNetBar.Office2007Form
    {
        public frmSach()
        {
            InitializeComponent();
        }


        QLTVDataContext db = new QLTVDataContext();



        #region "LoadComboBox Tên Sách"
        void LoadCBTenSach()
        {
            cbxtensach.Items.Clear();
            //var sach = (from tbs in db.tbSaches
            //              join tbds in db.tbDauSaches on tbs.MaDauSach equals tbds.MaDauSach
            //              group tbs by tbs.tbDauSach.TenSach into gb 
            //              select new
            //              {
            //                  Name=gb.Key
                             
            //              }).ToArray();
            //foreach (var i in sach)
            //{
            //    cbxtensach.Items.Add(i.Name.Trim());
            //}

            var sach = (from tbds in db.tbDauSaches
                        select tbds.TenSach);
            foreach (var item in sach)
            {
                cbxtensach.Items.Add(item.Trim());
            }

        }
        void LoadCBMaSach()
        {
            cbxmadausach.Items.Clear();
            var sach = (from tbs in db.tbSaches
                        join tbds in db.tbDauSaches on tbs.MaDauSach equals tbds.MaDauSach
                        group tbs by tbs.tbDauSach.MaDauSach into gb 
                          select new
                          {
                              Name=gb.Key
                             
                          }).ToArray();
            foreach (var i in sach)
            {
                cbxmadausach.Items.Add(i.Name.Trim());
            }
        }
        #endregion

        #region "Lấy Giá Trị"
        void LayTongSach()
        {
            
        }
        #endregion


        private void frmSach_Load(object sender, EventArgs e)
        {
            DataLoadOptions dlo = new DataLoadOptions();
            dlo.LoadWith<tbSach>(tbs => tbs.tbDauSach);
            db.LoadOptions = dlo;
            LoadCBTenSach();
            var query=from tbs in db.tbSaches
                      join tbds in db.tbDauSaches 
                      on tbs.MaDauSach equals tbds.MaDauSach
                      select new
                      {
                        tbds.TenSach,
                        tbds.MaDauSach,
                        tbs.MaSach
                      };
                      
            dataGridViewX1.DataSource = query;
         //   LoadCBMaSach();


       
        }

        private void labelX1_Click(object sender, EventArgs e)
        {
            



            
        }

        private void labelX7_Click(object sender, EventArgs e)
        {

        }

        private void labelX9_Click(object sender, EventArgs e)
        {

        }

        private void btninsert_Click(object sender, EventArgs e)
        {

                if (int.Parse(lblTong.Text) > int.Parse(lblCoMa.Text))
                {
                    tbSach tbs = new tbSach();
                    tbs.MaDauSach = cbxmadausach.Text;
                    tbs.MaSach = txtmasach.Text;
                    try
                    {
                        db.tbSaches.InsertOnSubmit(tbs);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm Thành Công","Thông Báo");
                        cbxmadausach_SelectedIndexChanged(sender, e);
            
                    }
                    catch
                    {
                        MessageBox.Show("Không Thêm Được","Thông Báo");
                    }
                  
                }
                else
                    MessageBox.Show("Hết Sách","Thông Báo");
          
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in groupBox1.Controls)
            {
                if (ctr is TextBox && ctr is ComboBox)
                {
                    ctr.Text = "";
                }
            }
            cbxtensach.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbxtensach_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbxmadausach.Items.Clear();
            var tbds = from ds in db.tbDauSaches
                       where ds.TenSach == cbxtensach.Text
                       select new
                       {
                           ds.MaDauSach,
                         
                       };
            foreach (var item in tbds)
            {
                cbxmadausach.Items.Add(item.MaDauSach.Trim());
                
            }
            cbxmadausach.Focus();
           
        }

        private void cbxmadausach_SelectedIndexChanged(object sender, EventArgs e)
        {

            var tbds = from ds in db.tbDauSaches
                       where ds.MaDauSach == cbxmadausach.Text
                       select ds;
            var tbs = from ds in db.tbSaches
                                   where ds.MaDauSach == cbxmadausach.Text
                                   select ds;
            foreach (var item in tbds)
            {
                lblTong.Text = item.SoLuong.ToString();
                lblChuaCoMa.Text = (item.SoLuong - Convert.ToInt32(tbs.Count())).ToString();
                txtmasach.Text = (item.MaDauSach + "  " + Convert.ToString(tbs.Count() + 1));
            }
            lblCoMa.Text = tbs.Count().ToString();
            
        }

        int dong;
        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            try
            {
                cbxtensach.Text = dataGridViewX1.Rows[dong].Cells[0].Value.ToString().Trim();
                cbxmadausach.Text = dataGridViewX1.Rows[dong].Cells[1].Value.ToString().Trim();
                txtmasach.Text = dataGridViewX1.Rows[dong].Cells[2].Value.ToString().Trim();
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
                tbSach tbs = (from s in db.tbSaches
                          where s.MaSach == txtmasach.Text
                          select s).Single<tbSach>();
                if (tbs!=null)
                {
                   
                    db.tbPhieuMuons.DeleteAllOnSubmit(tbs.tbPhieuMuons);
                    db.tbSaches.DeleteOnSubmit(tbs);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa Thành Công", "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   
                }
                else
                    MessageBox.Show("Không Xóa Được","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                var query = from tb in db.tbSaches
                            join tbds in db.tbDauSaches
                            on tb.MaDauSach equals tbds.MaDauSach
                            select new
                            {
                                tbds.TenSach,
                                tbds.MaDauSach,
                                tb.MaSach
                            };

                dataGridViewX1.DataSource = query;

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message,"Quản Lý Thư Viện");
            }

        }

        private void frmSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
        }
    }
}
