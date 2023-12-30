using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class HuyenController
    {
        HuyenPlayer Hplayer = new HuyenPlayer();

        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenHuyen";
            cmb.ValueMember = "MaHuyen";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenHuyen";
            cmb.ValueMember = "MaHuyen";
            cmb.DataPropertyName = "Ma_Huyen";
            cmb.HeaderText = "Huyen";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Hplayer.DanhSachHuyen();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public Huyen LayHuyen(String ma)
        {
            DataTable tbl = new DataTable();
            Huyen h = null;

            if (tbl.Rows.Count > 0)
                h = new Huyen(Convert.ToString(tbl.Rows[0]["MaHuyen"]), Convert.ToString(tbl.Rows[0]["TenHuyen"]));

            return h;
        }

        public void TimMaHuyen(String mahuyen)
        {
            Hplayer.TimHuyenTheoMa(mahuyen);
        }

        public void TimTenHuyen(String tenhuyen)
        {
            Hplayer.TimHuyenTheoTen(tenhuyen);
        }



        public bool Save()
        {
            return Hplayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource= Hplayer.DanhSachHuyen();
            cmb.DisplayMember = "MaHuyen";
            cmb.ValueMember = "MaHuyen";

        }

       public void HienThiComboboxTheoTinh(ComboBox cmb, String MaTinh)
       {
           cmb.DataSource = Hplayer.DanhSachHuyen(MaTinh);
           cmb.DisplayMember = "TenHuyen";
           cmb.ValueMember = "MaHuyen";

       }
    }
}
