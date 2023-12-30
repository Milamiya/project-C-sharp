using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class LaiSuatController
    {
        LaiSuatPlayer LSlayer = new LaiSuatPlayer();
        BindingSource bs = new BindingSource();
        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenLaiSuat";
            cmb.ValueMember = "MaLaiSuat";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "LaiSuat";
            cmb.ValueMember = "MaLaiSuat";
            cmb.DataPropertyName = "Ma_LaiSuat";
            cmb.HeaderText = "LaiSuat";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn,TextBox txtMaLaiSuat,TextBox txtLaiSuat,TextBox txtLSQuaHan,TextBox txtLSTren,TextBox txtTenLoaiLS)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = LSlayer.DanhSachLaiSuat();
            bn.BindingSource = bs;
            dg.DataSource = bs;

            txtMaLaiSuat.DataBindings.Clear();
            txtMaLaiSuat.DataBindings.Add("Text", bs, "MaLaiSuat");

            txtLaiSuat.DataBindings.Clear();
            txtLaiSuat.DataBindings.Add("Text", bs, "LaiSuat");

            txtLSQuaHan.DataBindings.Clear();
            txtLSQuaHan.DataBindings.Add("Text", bs, "LSQuaHan");

            txtLSTren.DataBindings.Clear();
            txtLSTren.DataBindings.Add("Text", bs, "LSTren");

            txtTenLoaiLS.DataBindings.Clear();
            txtTenLoaiLS.DataBindings.Add("Text", bs, "TenLoaiLS");

          
        }

        public LaiSuat LayLaiSuat(String ma)
        {
            DataTable tbl = new DataTable();
            LaiSuat tk = null;

            if (tbl.Rows.Count > 0)
                tk = new LaiSuat(Convert.ToString(tbl.Rows[0]["MaLaiSuat"]), Convert.ToInt32(tbl.Rows[0]["LaiSuat"]));

            return tk;
        }

        public void TimMaLaiSuat(String malaisuat)
        {
            LSlayer.TimLaiSuatTheoMa(malaisuat);
        }

        public void TimTenLaiSuat(String laisuat)
        {
            LSlayer.TimLaiSuatTheoTen(laisuat);
        }



        public bool Save()
        {
            return LSlayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = LSlayer.DanhSachLaiSuat();
            cmb.DisplayMember = "LaiSuat";
            cmb.ValueMember = "MaLaiSuat";

        }
        public DataRow NewRow()
        {
            return LSlayer.NewRow();
        }
        public void Add(DataRow row)
        {
            LSlayer.Add(row);
        }       

       public void Update()
       {
           bs.MoveNext();
           LSlayer.Save();
       }

    }
}
