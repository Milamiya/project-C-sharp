using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataPlayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class DoiTacController
    {
        DoiTacPlayer DTplayer = new DoiTacPlayer();
       BindingSource bs = new BindingSource();
        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "HoTenDT";
            cmb.ValueMember = "MaDoiTac";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "HoTenDT";
            cmb.ValueMember = "MaDoiTac";
            cmb.DataPropertyName = "Ma_DoiTac";
            cmb.HeaderText = "DoiTac";

            return cmb;
        }


       public void HienThiDataGridViewDSKH(DataGridView dg, BindingNavigator bn)
       {
           BindingSource bs = new BindingSource();
           bs.DataSource = DTplayer.DanhSachDoiTac();
           bn.BindingSource = bs;
           dg.DataSource = bs;
       }
        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn,TextBox txtMaDoiTac,TextBox txtTenDoiTac,CheckBox cbGioiTinh,TextBox txtDiaChi,DateTimePicker dtpNgaySinh,TextBox txtCMND,DateTimePicker dtpNgayCap,TextBox txtNoiCap,ComboBox cmbMaTinh,ComboBox cmbMaHuyen,ComboBox cmbMaXa,ComboBox cmbMaLoaiHinh,ComboBox cmbMaLoaiDoiTac,ComboBox cmbMaDanToc)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DTplayer.DanhSachDoiTac();
            bn.BindingSource = bs;
            dg.DataSource = bs;


            txtMaDoiTac.DataBindings.Clear();
            txtMaDoiTac.DataBindings.Add("Text", bs, "MaDoiTac");

            txtTenDoiTac.DataBindings.Clear();
            txtTenDoiTac.DataBindings.Add("Text", bs, "HoTenDT");

            cbGioiTinh.DataBindings.Clear();
            cbGioiTinh.DataBindings.Add("Checked", bs, "GioiTinh");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bs, "DiaChi");

            try
            {
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Value", bs, "NgaySinh");
            }
        catch { }

            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", bs, "CMND");

            try
            {
            dtpNgayCap.DataBindings.Clear();
            dtpNgayCap.DataBindings.Add("Value", bs, "NgayCap");
        }
        catch { }
            txtNoiCap.DataBindings.Clear();
            txtNoiCap.DataBindings.Add("Text", bs, "NoiCap");

            cmbMaTinh.DataBindings.Clear();
            cmbMaTinh.DataBindings.Add("SelectedValue", bs, "MaTinh");

            cmbMaHuyen.DataBindings.Clear();
            cmbMaHuyen.DataBindings.Add("SelectedValue", bs, "MaHuyen");

            cmbMaXa.DataBindings.Clear();
            cmbMaXa.DataBindings.Add("SelectedValue", bs, "MaXa");

            cmbMaLoaiHinh.DataBindings.Clear();
            cmbMaLoaiHinh.DataBindings.Add("SelectedValue", bs, "MaLoaiHinh");

            cmbMaLoaiDoiTac.DataBindings.Clear();
            cmbMaLoaiDoiTac.DataBindings.Add("SelectedValue", bs, "MaLoaiDoiTac");

            cmbMaDanToc.DataBindings.Clear();
            cmbMaDanToc.DataBindings.Add("SelectedValue", bs, "MaDanToc");
        }

        public DoiTac LayDoiTac(String ma)
        {
            DataTable tbl = new DataTable();
            DoiTac dt = null;

            if (tbl.Rows.Count > 0)
                dt = new DoiTac(Convert.ToString(tbl.Rows[0]["MaDoiTac"]), Convert.ToString(tbl.Rows[0]["HoTenDT"]));

            return dt;
        }


       public void TimMaDoiTacDSKH(String madoitac)
       {

           DTplayer.TimDoiTacTheoMa(madoitac);
          
       }

       public void TimTenDoiTacDSKH(String tendoitac)
       {

           DTplayer.TimDoiTacTheoTen(tendoitac);

       }

       public void TimMaLoaiDoiTacDSKH(String maloaidoitac)
       {

           DTplayer.TimDoiTacTheoMaLoai(maloaidoitac);

       }
        public void TimMaDoiTac(DataGridView dg, BindingNavigator bn,TextBox txtMaDoiTac,TextBox txtTenDoiTac,CheckBox cbGioiTinh,TextBox txtDiaChi,DateTimePicker dtpNgaySinh,TextBox txtCMND,DateTimePicker dtpNgayCap,TextBox txtNoiCap,ComboBox cmbMaTinh,ComboBox cmbMaHuyen,ComboBox cmbMaXa,ComboBox cmbMaLoaiHinh,ComboBox cmbMaLoaiDoiTac,ComboBox cmbMaDanToc,String madoitac)
        {
            
            BindingSource bs = new BindingSource();
            bs.DataSource = DTplayer.TimDoiTacTheoMa(madoitac);
            bn.BindingSource = bs;
            dg.DataSource = bs;


            txtMaDoiTac.DataBindings.Clear();
            txtMaDoiTac.DataBindings.Add("Text", bs, "MaDoiTac");

            txtTenDoiTac.DataBindings.Clear();
            txtTenDoiTac.DataBindings.Add("Text", bs, "HoTenDT");

            cbGioiTinh.DataBindings.Clear();
            cbGioiTinh.DataBindings.Add("Checked", bs, "GioiTinh");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bs, "DiaChi");

            try
            {
                dtpNgaySinh.DataBindings.Clear();
                dtpNgaySinh.DataBindings.Add("Value", bs, "NgaySinh");
            }
            catch { }

            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", bs, "CMND");

            try
            {
                dtpNgayCap.DataBindings.Clear();
                dtpNgayCap.DataBindings.Add("Value", bs, "NgayCap");
            }
            catch { }
            txtNoiCap.DataBindings.Clear();
            txtNoiCap.DataBindings.Add("Text", bs, "NoiCap");

            cmbMaTinh.DataBindings.Clear();
            cmbMaTinh.DataBindings.Add("SelectedValue", bs, "MaTinh");

            cmbMaHuyen.DataBindings.Clear();
            cmbMaHuyen.DataBindings.Add("SelectedValue", bs, "MaHuyen");

            cmbMaXa.DataBindings.Clear();
            cmbMaXa.DataBindings.Add("SelectedValue", bs, "MaXa");

            cmbMaLoaiHinh.DataBindings.Clear();
            cmbMaLoaiHinh.DataBindings.Add("SelectedValue", bs, "MaLoaiHinh");

            cmbMaLoaiDoiTac.DataBindings.Clear();
            cmbMaLoaiDoiTac.DataBindings.Add("SelectedValue", bs, "MaLoaiDoiTac");

            cmbMaDanToc.DataBindings.Clear();
            cmbMaDanToc.DataBindings.Add("SelectedValue", bs, "MaDanToc");
        }

        public void TimTenDoiTac(DataGridView dg, BindingNavigator bn,TextBox txtMaDoiTac,TextBox txtTenDoiTac,CheckBox cbGioiTinh,TextBox txtDiaChi,DateTimePicker dtpNgaySinh,TextBox txtCMND,DateTimePicker dtpNgayCap,TextBox txtNoiCap,ComboBox cmbMaTinh,ComboBox cmbMaHuyen,ComboBox cmbMaXa,ComboBox cmbMaLoaiHinh,ComboBox cmbMaLoaiDoiTac,ComboBox cmbMaDanToc,String tendoitac)
        {
            
            BindingSource bs = new BindingSource();
            bs.DataSource = DTplayer.TimDoiTacTheoTen(tendoitac);
            bn.BindingSource = bs;
            dg.DataSource = bs;


            txtMaDoiTac.DataBindings.Clear();
            txtMaDoiTac.DataBindings.Add("Text", bs, "MaDoiTac");

            txtTenDoiTac.DataBindings.Clear();
            txtTenDoiTac.DataBindings.Add("Text", bs, "HoTenDT");

            cbGioiTinh.DataBindings.Clear();
            cbGioiTinh.DataBindings.Add("Checked", bs, "GioiTinh");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bs, "DiaChi");

            try
            {
                dtpNgaySinh.DataBindings.Clear();
                dtpNgaySinh.DataBindings.Add("Value", bs, "NgaySinh");
            }
            catch { }

            txtCMND.DataBindings.Clear();
            txtCMND.DataBindings.Add("Text", bs, "CMND");

            try
            {
                dtpNgayCap.DataBindings.Clear();
                dtpNgayCap.DataBindings.Add("Value", bs, "NgayCap");
            }
            catch { }
            txtNoiCap.DataBindings.Clear();
            txtNoiCap.DataBindings.Add("Text", bs, "NoiCap");

            cmbMaTinh.DataBindings.Clear();
            cmbMaTinh.DataBindings.Add("SelectedValue", bs, "MaTinh");

            cmbMaHuyen.DataBindings.Clear();
            cmbMaHuyen.DataBindings.Add("SelectedValue", bs, "MaHuyen");

            cmbMaXa.DataBindings.Clear();
            cmbMaXa.DataBindings.Add("SelectedValue", bs, "MaXa");

            cmbMaLoaiHinh.DataBindings.Clear();
            cmbMaLoaiHinh.DataBindings.Add("SelectedValue", bs, "MaLoaiHinh");

            cmbMaLoaiDoiTac.DataBindings.Clear();
            cmbMaLoaiDoiTac.DataBindings.Add("SelectedValue", bs, "MaLoaiDoiTac");

            cmbMaDanToc.DataBindings.Clear();
            cmbMaDanToc.DataBindings.Add("SelectedValue", bs, "MaDanToc");
        }

       public void TimMaLoaiDoiTac(DataGridView dg, BindingNavigator bn,TextBox txtMaDoiTac,TextBox txtTenDoiTac,CheckBox cbGioiTinh,TextBox txtDiaChi,DateTimePicker dtpNgaySinh,TextBox txtCMND,DateTimePicker dtpNgayCap,TextBox txtNoiCap,ComboBox cmbMaTinh,ComboBox cmbMaHuyen,ComboBox cmbMaXa,ComboBox cmbMaLoaiHinh,ComboBox cmbMaLoaiDoiTac,ComboBox cmbMaDanToc,String maloaidt)
       {
           
           BindingSource bs = new BindingSource();
           bs.DataSource = DTplayer.TimDoiTacTheoMaLoai(maloaidt);
           bn.BindingSource = bs;
           dg.DataSource = bs;


           txtMaDoiTac.DataBindings.Clear();
           txtMaDoiTac.DataBindings.Add("Text", bs, "MaDoiTac");

           txtTenDoiTac.DataBindings.Clear();
           txtTenDoiTac.DataBindings.Add("Text", bs, "HoTenDT");

           cbGioiTinh.DataBindings.Clear();
           cbGioiTinh.DataBindings.Add("Checked", bs, "GioiTinh");

           txtDiaChi.DataBindings.Clear();
           txtDiaChi.DataBindings.Add("Text", bs, "DiaChi");

           try
           {
               dtpNgaySinh.DataBindings.Clear();
               dtpNgaySinh.DataBindings.Add("Value", bs, "NgaySinh");
           }
           catch { }

           txtCMND.DataBindings.Clear();
           txtCMND.DataBindings.Add("Text", bs, "CMND");

           try
           {
               dtpNgayCap.DataBindings.Clear();
               dtpNgayCap.DataBindings.Add("Value", bs, "NgayCap");
           }
           catch { }
           txtNoiCap.DataBindings.Clear();
           txtNoiCap.DataBindings.Add("Text", bs, "NoiCap");

           cmbMaTinh.DataBindings.Clear();
           cmbMaTinh.DataBindings.Add("SelectedValue", bs, "MaTinh");

           cmbMaHuyen.DataBindings.Clear();
           cmbMaHuyen.DataBindings.Add("SelectedValue", bs, "MaHuyen");

           cmbMaXa.DataBindings.Clear();
           cmbMaXa.DataBindings.Add("SelectedValue", bs, "MaXa");

           cmbMaLoaiHinh.DataBindings.Clear();
           cmbMaLoaiHinh.DataBindings.Add("SelectedValue", bs, "MaLoaiHinh");

           cmbMaLoaiDoiTac.DataBindings.Clear();
           cmbMaLoaiDoiTac.DataBindings.Add("SelectedValue", bs, "MaLoaiDoiTac");

           cmbMaDanToc.DataBindings.Clear();
           cmbMaDanToc.DataBindings.Add("SelectedValue", bs, "MaDanToc");
       }

      

       

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = DTplayer.DanhSachDoiTac();
            cmb.DisplayMember = "HoTenDT";
            cmb.ValueMember = "MaDoiTac";

        }

        public DataRow NewRow()
        {
            return DTplayer.NewRow();
        }
        public void Add(DataRow row)
        {
            DTplayer.Add(row);
        }
       public bool Save()
       {
           return DTplayer.Save();
       }

       public void Update()
       {

           bs.MoveNext();
           DTplayer.Save();
       }
    }
}
