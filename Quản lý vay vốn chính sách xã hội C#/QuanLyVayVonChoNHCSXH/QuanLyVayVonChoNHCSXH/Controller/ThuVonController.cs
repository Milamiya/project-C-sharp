using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class ThuVonController
    {
        ThuVonPlayer TVplayer = new ThuVonPlayer();
        BindingSource bs = new BindingSource();
        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "SoButToan";
            cmb.ValueMember = "SoButToan";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "SoButToan";
            cmb.ValueMember = "SoButToan";
            cmb.DataPropertyName = "SoButToan";
            cmb.HeaderText = "ThuVon";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn,TextBox txtSoButToan,DateTimePicker dtpNgayTV,ComboBox cmbMaSoKU,NumericUpDown numSoTienThu,NumericUpDown numSoTienGoc,NumericUpDown numSoTienConLai,ComboBox cmbMaLoaiChungTu,ComboBox cmbTaiKhoanNo,ComboBox cmbTaiKhoanCo)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = TVplayer.DanhSachThuVon();
            bn.BindingSource = bs;
            dg.DataSource = bs;


            txtSoButToan.DataBindings.Clear();
            txtSoButToan.DataBindings.Add("Text", bs, "SoButToan");

            try{
            dtpNgayTV.DataBindings.Clear();
            dtpNgayTV.DataBindings.Add("Value", bs, "NgayTV");
            }
            catch{}

            
            cmbMaSoKU.DataBindings.Clear();
            cmbMaSoKU.DataBindings.Add("SelectedValue", bs, "MaSoKU");


            try
            {
                numSoTienThu.DataBindings.Clear();
                numSoTienThu.DataBindings.Add("Value", bs, "SoTienThu");
            }
            catch { };

            numSoTienGoc.DataBindings.Clear();
            numSoTienGoc.DataBindings.Add("Value", bs, "SoTienGoc");

            numSoTienConLai.DataBindings.Clear();
            numSoTienConLai.DataBindings.Add("Value", bs, "SoTienConLai");

         
            cmbMaLoaiChungTu.DataBindings.Clear();
            cmbMaLoaiChungTu.DataBindings.Add("SelectedValue", bs, "MaLoaiChungTu");

            cmbTaiKhoanNo.DataBindings.Clear();
            cmbTaiKhoanNo.DataBindings.Add("SelectedValue", bs, "TaiKhoanNo");

            cmbTaiKhoanCo.DataBindings.Clear();
            cmbTaiKhoanCo.DataBindings.Add("SelectedValue", bs, "TaiKhoanCo");

           

            
            
        }

        public ThuVon LayThuVon(String ma)
        {
            DataTable tbl = new DataTable();
            tbl = TVplayer.LayThuVon(ma);
            ThuVon TV = null;
            if (tbl.Rows.Count > 0)
            {
                TV = new ThuVon();
                TV.sobuttoan = Convert.ToString(tbl.Rows[0]["SoButToan"]);
                TV.ngaytv = Convert.ToDateTime(tbl.Rows[0]["NgayTV"]);
                TV.masoku = Convert.ToString(tbl.Rows[0]["MaSoKU"]);
                TV.sotienthu = Convert.ToDouble(tbl.Rows[0]["SoTienThu"]);
                TV.sotiengoc = Convert.ToDouble(tbl.Rows[0]["SoTienGoc"]);
                TV.sotienconlai = Convert.ToDouble(tbl.Rows[0]["SoTienConLai"]);
                TV.maloaichungtu= Convert.ToString(tbl.Rows[0]["MaLoaiChungTu"]);
                TV.taikhoanno = Convert.ToString(tbl.Rows[0]["TaiKhoanNo"]);
                TV.taikhoanco = Convert.ToString(tbl.Rows[0]["TaiKhoanCo"]);
               
            }         

            return TV;
        }

       public void TimMaThuVon(DataGridView dg, BindingNavigator bn, TextBox txtSoButToan, DateTimePicker dtpNgayTV, ComboBox cmbMaSoKU, NumericUpDown numSoTienThu, NumericUpDown numSoTienGoc, NumericUpDown numSoTienConLai, ComboBox cmbMaLoaiChungTu, ComboBox cmbTaiKhoanNo, ComboBox cmbTaiKhoanCo, String SoButToan)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = TVplayer.TimThuVonTheoMa(SoButToan);
            bn.BindingSource = bs;
            dg.DataSource = bs;


            txtSoButToan.DataBindings.Clear();
            txtSoButToan.DataBindings.Add("Text", bs, "SoButToan");

            try
            {
                dtpNgayTV.DataBindings.Clear();
                dtpNgayTV.DataBindings.Add("Value", bs, "NgayTV");
            }
            catch { }


            cmbMaSoKU.DataBindings.Clear();
            cmbMaSoKU.DataBindings.Add("SelectedValue", bs, "MaSoKU");



            numSoTienThu.DataBindings.Clear();
            numSoTienThu.DataBindings.Add("Value", bs, "SoTienThu");

            numSoTienGoc.DataBindings.Clear();
            numSoTienGoc.DataBindings.Add("Value", bs, "SoTienGoc");

            numSoTienConLai.DataBindings.Clear();
            numSoTienConLai.DataBindings.Add("Value", bs, "SoTienConLai");


            cmbMaLoaiChungTu.DataBindings.Clear();
            cmbMaLoaiChungTu.DataBindings.Add("SelectedValue", bs, "MaLoaiChungTu");

            cmbTaiKhoanNo.DataBindings.Clear();
            cmbTaiKhoanNo.DataBindings.Add("SelectedValue", bs, "TaiKhoanNo");

            cmbTaiKhoanCo.DataBindings.Clear();
            cmbTaiKhoanCo.DataBindings.Add("SelectedValue", bs, "TaiKhoanCo");

           
        }

       public void TimMaSoKUThuVon(DataGridView dg, BindingNavigator bn, TextBox txtSoButToan, DateTimePicker dtpNgayTV, ComboBox cmbMaSoKU, NumericUpDown numSoTienThu, NumericUpDown numSoTienGoc, NumericUpDown numSoTienConLai, ComboBox cmbMaLoaiChungTu, ComboBox cmbTaiKhoanNo, ComboBox cmbTaiKhoanCo, String masoku)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = TVplayer.TimThuVonTheoMaSoKU(masoku);
            bn.BindingSource = bs;
            dg.DataSource = bs;


            txtSoButToan.DataBindings.Clear();
            txtSoButToan.DataBindings.Add("Text", bs, "SoButToan");

            try
            {
                dtpNgayTV.DataBindings.Clear();
                dtpNgayTV.DataBindings.Add("Value", bs, "NgayTV");
            }
            catch { }


            cmbMaSoKU.DataBindings.Clear();
            cmbMaSoKU.DataBindings.Add("SelectedValue", bs, "MaSoKU");



            numSoTienThu.DataBindings.Clear();
            numSoTienThu.DataBindings.Add("Value", bs, "SoTienThu");

            numSoTienGoc.DataBindings.Clear();
            numSoTienGoc.DataBindings.Add("Value", bs, "SoTienGoc");

            numSoTienConLai.DataBindings.Clear();
            numSoTienConLai.DataBindings.Add("Value", bs, "SoTienConLai");


            cmbMaLoaiChungTu.DataBindings.Clear();
            cmbMaLoaiChungTu.DataBindings.Add("SelectedValue", bs, "MaLoaiChungTu");

            cmbTaiKhoanNo.DataBindings.Clear();
            cmbTaiKhoanNo.DataBindings.Add("SelectedValue", bs, "TaiKhoanNo");

            cmbTaiKhoanCo.DataBindings.Clear();
            cmbTaiKhoanCo.DataBindings.Add("SelectedValue", bs, "TaiKhoanCo");

          
        }

       
        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = TVplayer.DanhSachThuVon();
            cmb.DisplayMember = "SoButToan";
            cmb.ValueMember = "SoButToan";

        }

       public void Update()
       {

           bs.MoveNext();
           TVplayer.Save();
       }

        public DataRow NewRow()
        {
            return TVplayer.NewRow();
        }
        public void Add(DataRow row)
        {
            TVplayer.Add(row);
        }
        public bool Save()
        {
            return TVplayer.Save();
        }
    }
}
