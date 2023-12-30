using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
    public class GiaiNganController
    {
        GiaiNganLayer GNlayer = new GiaiNganLayer();
        BindingSource bs = new BindingSource();
        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "SoButToan";
            cmb.ValueMember = "SoButToan";
            cmb.DataPropertyName = "SoButToan";
            cmb.HeaderText = "GiaiNgan";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn, TextBox txtsobuttoan, DateTimePicker dtpngaygiaingan, ComboBox cmbmasoku, ComboBox cmbsotaikhoan, NumericUpDown numsotiengiaingan,
            NumericUpDown numconlai, NumericUpDown numduocphep, ComboBox cmbloaichungtu, ComboBox cmbtaikhoanno, ComboBox cmbtaikhoanco)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = GNlayer.DanhSachGiaiNgan();
            bn.BindingSource = bs;
            dg.DataSource = bs;


            txtsobuttoan.DataBindings.Clear();
            txtsobuttoan.DataBindings.Add("Text", bs, "SoButToan");

            dtpngaygiaingan.DataBindings.Clear();
            dtpngaygiaingan.DataBindings.Add("Value", bs, "NgayGiaiNgan");

            cmbmasoku.DataBindings.Clear();
            cmbmasoku.DataBindings.Add("SelectedValue", bs, "MaSoKU");

            cmbsotaikhoan.DataBindings.Clear();
            cmbsotaikhoan.DataBindings.Add("SelectedValue", bs, "SoTaiKhoan");

            numsotiengiaingan.DataBindings.Clear();
            numsotiengiaingan.DataBindings.Add("Value", bs, "SoTienGiaiNgan");

            numduocphep.DataBindings.Clear();
            numduocphep.DataBindings.Add("Value", bs, "DuocPhep");

            numconlai.DataBindings.Clear();
            numconlai.DataBindings.Add("Value", bs, "ConLai");

            cmbloaichungtu.DataBindings.Clear();
            cmbloaichungtu.DataBindings.Add("SelectedValue", bs, "MaLoaiChungTu");


            cmbtaikhoanno.DataBindings.Clear();
            cmbtaikhoanno.DataBindings.Add("Text", bs, "TaiKhoanNo");

            cmbtaikhoanco.DataBindings.Clear();
            cmbtaikhoanco.DataBindings.Add("Text", bs, "TaiKhoanCo");

        }

        public GiaiNgan LayGiaiNgan(String ma)
        {
            DataTable tbl = new DataTable();           
            tbl = GNlayer.LayGiaiNgan(ma);
            GiaiNgan gn = null;
           
            if ((tbl.Rows.Count) > 0)
            {
                gn = new GiaiNgan();

                gn.SOBUTOAN= Convert.ToString(tbl.Rows[0]["SoButToan"]);
                gn.NGAYGIAINGAN= Convert.ToDateTime(tbl.Rows[0]["NgayGiaiNgan"]);
                gn.MASOKU= Convert.ToString(tbl.Rows[0]["MaSoKU"]);
                gn.SOTAIKHOAN= Convert.ToString(tbl.Rows[0]["SoTaiKhoan"]);
                gn.SOTIENGIAINGAN= Convert.ToDouble(tbl.Rows[0]["SoTienGiaiNgan"]);
                gn.DUOCPHEP= Convert.ToDouble(tbl.Rows[0]["DuocPhep"]);
                gn.CONLAI= Convert.ToDouble(tbl.Rows[0]["ConLai"]);
                gn.MALOAICHUNGTU= Convert.ToString(tbl.Rows[0]["MaLoaiChungTu"]);
                gn.TAIKHOANO= Convert.ToString(tbl.Rows[0]["TaiKhoanNo"]);
                gn.TAIKHOANCO= Convert.ToString(tbl.Rows[0]["TaiKhoanCo"]);
            }
            return gn;
        }



        public void TimSoButToan(DataGridView dg, BindingNavigator bn, TextBox txtsobuttoan, DateTimePicker dtpngaygiaingan, ComboBox cmbmasoku, ComboBox cmbsotaikhoan, NumericUpDown numsotiengiaingan,
            NumericUpDown numconlai, NumericUpDown numduocphep, ComboBox cmbloaichungtu, ComboBox cmbtaikhoanno, ComboBox cmbtaikhoanco, String sobuttoan)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = GNlayer.TimGiaiNganTheoSBT(sobuttoan);
            bn.BindingSource = bs;
            dg.DataSource = bs;


            txtsobuttoan.DataBindings.Clear();
            txtsobuttoan.DataBindings.Add("Text", bs, "SoButToan");

            dtpngaygiaingan.DataBindings.Clear();
            dtpngaygiaingan.DataBindings.Add("Value", bs, "NgayGiaiNgan");

            cmbmasoku.DataBindings.Clear();
            cmbmasoku.DataBindings.Add("SelectedValue", bs, "MaSoKU");

            cmbsotaikhoan.DataBindings.Clear();
            cmbsotaikhoan.DataBindings.Add("SelectedValue", bs, "SoTaiKhoan");

            numsotiengiaingan.DataBindings.Clear();
            numsotiengiaingan.DataBindings.Add("Value", bs, "SoTienGiaiNgan");

            numduocphep.DataBindings.Clear();
            numduocphep.DataBindings.Add("Value", bs, "DuocPhep");

            numconlai.DataBindings.Clear();
            numconlai.DataBindings.Add("Value", bs, "ConLai");

            cmbloaichungtu.DataBindings.Clear();
            cmbloaichungtu.DataBindings.Add("SelectedValue", bs, "MaLoaiChungTu");


            cmbtaikhoanno.DataBindings.Clear();
            cmbtaikhoanno.DataBindings.Add("Text", bs, "TaiKhoanNo");

            cmbtaikhoanco.DataBindings.Clear();
            cmbtaikhoanco.DataBindings.Add("Text", bs, "TaiKhoanCo");
        }

        public void TimMaKheUoc(DataGridView dg, BindingNavigator bn, TextBox txtsobuttoan, DateTimePicker dtpngaygiaingan, ComboBox cmbmasoku, ComboBox cmbsotaikhoan, NumericUpDown numsotiengiaingan,
            NumericUpDown numconlai, NumericUpDown numduocphep, ComboBox cmbloaichungtu, ComboBox cmbtaikhoanno, ComboBox cmbtaikhoanco,String masoku)
        {

            BindingSource bs = new BindingSource();
            bs.DataSource = GNlayer.TimGiaiNganTheoMaKU(masoku);
            bn.BindingSource = bs;
            dg.DataSource = bs;


            txtsobuttoan.DataBindings.Clear();
            txtsobuttoan.DataBindings.Add("Text", bs, "SoButToan");

            dtpngaygiaingan.DataBindings.Clear();
            dtpngaygiaingan.DataBindings.Add("Value", bs, "NgayGiaiNgan");

            cmbmasoku.DataBindings.Clear();
            cmbmasoku.DataBindings.Add("SelectedValue", bs, "MaSoKU");

            cmbsotaikhoan.DataBindings.Clear();
            cmbsotaikhoan.DataBindings.Add("SelectedValue", bs, "SoTaiKhoan");

            numsotiengiaingan.DataBindings.Clear();
            numsotiengiaingan.DataBindings.Add("Text", bs, "SoTienGiaiNgan");

            numduocphep.DataBindings.Clear();
            numduocphep.DataBindings.Add("Value", bs, "DuocPhep");

            numconlai.DataBindings.Clear();
            numconlai.DataBindings.Add("Value", bs, "ConLai");

            cmbloaichungtu.DataBindings.Clear();
            cmbloaichungtu.DataBindings.Add("SelectedValue", bs, "MaLoaiChungTu");


            cmbtaikhoanno.DataBindings.Clear();
            cmbtaikhoanno.DataBindings.Add("Text", bs, "TaiKhoanNo");

            cmbtaikhoanco.DataBindings.Clear();
            cmbtaikhoanco.DataBindings.Add("Text", bs, "TaiKhoanCo");
        }

        public void Update()
        {

            bs.MoveNext();
            GNlayer.Save();
        }

        public DataRow NewRow()
        {
            return GNlayer.NewRow();
        }
        public void Add(DataRow row)
        {
            GNlayer.Add(row);
        }
        public bool Save()
        {
            return GNlayer.Save();
        }



    }
}
