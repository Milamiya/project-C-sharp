using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;


namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class TaiKhoanController
    {
        TaiKhoanPlayer TKlayer = new TaiKhoanPlayer();
         BindingSource bs = new BindingSource();
        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenTaiKhoan";
            cmb.ValueMember = "MaTaiKhoan";
        }

       public void HienThiDataGridViewDSTK(DataGridView dg, BindingNavigator bn)
       {
           BindingSource bs = new BindingSource();
           bs.DataSource = TKlayer.DanhSachTaiKhoan();
           bn.BindingSource = bs;
           dg.DataSource = bs;
       }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenTaiKhoan";
            cmb.ValueMember = "MaTaiKhoan";
            cmb.DataPropertyName = "Ma_TaiKhoan";
            cmb.HeaderText = "TaiKhoan";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn,TextBox txtMaTaiKhoan,TextBox txtTenTaiKhoan,ComboBox cmbMaNV,ComboBox cmbMaCap)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = TKlayer.DanhSachTaiKhoan();
            bn.BindingSource = bs;
            dg.DataSource = bs;

            txtMaTaiKhoan.DataBindings.Clear();
            txtMaTaiKhoan.DataBindings.Add("Text", bs, "MaTaiKhoan");

            txtTenTaiKhoan.DataBindings.Clear();
            txtTenTaiKhoan.DataBindings.Add("Text", bs, "TenTaiKhoan");

            cmbMaNV.DataBindings.Clear();
            cmbMaNV.DataBindings.Add("SelectedValue", bs, "MaNV");

            cmbMaCap.DataBindings.Clear();
            cmbMaCap.DataBindings.Add("SelectedValue", bs, "MaCap");
        }

        public TaiKhoan LayTaiKhoan(String ma)
        {
            DataTable tbl = new DataTable();
            TaiKhoan tk = null;

            if (tbl.Rows.Count > 0)
                tk = new TaiKhoan(Convert.ToString(tbl.Rows[0]["MaTaiKhoan"]), Convert.ToString(tbl.Rows[0]["TenTaiKhoan"]));

            return tk;
        }

        public void TimMaTaiKhoan(String mataikhoan)
        {
            TKlayer.TimTaiKhoanTheoMa(mataikhoan);
        }

        public void TimTenTaiKhoan(String tentaikhoan)
        {
            TKlayer.TimTaiKhoanTheoTen(tentaikhoan);
        }



        public bool Save()
        {
            return TKlayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = TKlayer.DanhSachTaiKhoan();
            cmb.DisplayMember = "MaTaiKhoan";
            cmb.ValueMember = "MaTaiKhoan";

        }

       public void HienThiComboboxTheoMaKheuoc(NumericUpDown numConLai,NumericUpDown numDuocPhep,ComboBox cmbSoTaiKhoan,ComboBox cmbTKNo, String MaSoKU)
       {
           DataTable tbl = new HoSoKheUocLayer().LayHoSoKheUocTheoMa(MaSoKU);
           //DataTable tbl1 = new LaiSuatPlayer().LayLaiSuat();
           if (tbl.Rows.Count > 0)
           {
               cmbSoTaiKhoan.Text = tbl.Rows[0]["TKChoVay"].ToString();
               numDuocPhep.Text = tbl.Rows[0]["SoTienHienTai"].ToString();
               numConLai.Text = tbl.Rows[0]["SoTienHienTai"].ToString();
               cmbTKNo.Text = tbl.Rows[0]["TKChoVay"].ToString();
               //cmbTKCo.Text = tbl.Rows[0]["TKChoVay"].ToString();
              
           }
           //catch { }
       }

       //public void HienThiComboboxTheoMaKheuoc(NumericUpDown numSoTienLaiTH,NumericUpDown numSoTienLaiQH, String MaSoKU)
       //{
       //    DataTable tbl = new HoSoKheUocLayer().LayHoSoKheUocTheoMa(MaSoKU);
       //    //DataTable tbl1 = new LaiSuatPlayer().LayLaiSuat(MaLaiSuat);
       //    if (tbl.Rows.Count > 0)
       //    {
       //        //cmbSoTaiKhoan.Text = tbl.Rows[0]["TKChoVay"].ToString();
       //        dtpNgayTinhLai.Text = tbl.Rows[0]["NgayTinhLai"].ToString();
       //        numSoTienGoc.Text = tbl.Rows[0]["SoTienHienTai"].ToString();
       //        cmbTaiKhoanNo.Text = tbl.Rows[0]["ThuLai"].ToString();
       //        cmbTaiKhoanCo.Text = tbl.Rows[0]["ThuLai"].ToString();

       //    }
       //    //catch { }
       //}

       public void HienThiComboboxTheoMaKheuocTL(TextBox txtSoTienLaiQH, TextBox txtSoTienLaiTH, DateTimePicker dtpNgayTinhLai, NumericUpDown numSoTienGoc, ComboBox cmbTaiKhoanNo, ComboBox cmbTaiKhoanCo, String MaSoKU)
       {
           DataTable tbl = new HoSoKheUocLayer().LayHoSoKheUocTheoMa(MaSoKU);
           if (tbl.Rows.Count > 0)
           {
               //cmbSoTaiKhoan.Text = tbl.Rows[0]["TKChoVay"].ToString();
                dtpNgayTinhLai.Text = tbl.Rows[0]["NgayTinhLai"].ToString();
               numSoTienGoc.Text = tbl.Rows[0]["SoTienHienTai"].ToString();
               cmbTaiKhoanNo.SelectedValue = tbl.Rows[0]["ThuLai"].ToString();
               cmbTaiKhoanCo.SelectedValue = tbl.Rows[0]["ThuLai"].ToString();
               //ThuLaiController tl = new ThuLaiController();
               //String tinhlai = Convert.ToString(tl.TinhLai(MaSoKU));
               //numSoTienLaiTH.Value = Convert.ToInt64(tinhlai);
               ThuLaiController tlctrol = new ThuLaiController();
               //String s_MaSoKU = Convert.ToString(cm).Trim();
               txtSoTienLaiTH.Text = Convert.ToString(tlctrol.TinhLai(MaSoKU));
               txtSoTienLaiQH.Text = Convert.ToString(tlctrol.TinhLaiQH(MaSoKU));

           }
           //catch { }
       }

       public void HienThiComboboxTheoMaKheuocTV( NumericUpDown numSoTienGoc, ComboBox cmbTaiKhoanNo, ComboBox cmbTaiKhoanCo, String MaSoKU)
       {
           DataTable tbl = new HoSoKheUocLayer().LayHoSoKheUocTheoMa(MaSoKU);
           if (tbl.Rows.Count > 0)
           {
               //cmbSoTaiKhoan.Text = tbl.Rows[0]["TKChoVay"].ToString();
              // dtpNgayTinhLai.Text = tbl.Rows[0]["NgayTinhLai"].ToString();
               numSoTienGoc.Text = tbl.Rows[0]["SoTienHienTai"].ToString();
               cmbTaiKhoanNo.SelectedValue = tbl.Rows[0]["ThuLai"].ToString();
               cmbTaiKhoanCo.SelectedValue = tbl.Rows[0]["ThuLai"].ToString();

           }
           //catch { }
       }

       public void Update()
       {

           bs.MoveNext();
           TKlayer.Save();
       }

       public DataRow NewRow()
       {
           return TKlayer.NewRow();
       }
       public void Add(DataRow row)
       {
           TKlayer.Add(row);
       }
      



    }
}
