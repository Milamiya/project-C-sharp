using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class HinhThucVayController
    {

        HinhThucVayPlayer HTVplayer = new HinhThucVayPlayer();

        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenHTVay";
            cmb.ValueMember = "MaHTVay";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenHTVay";
            cmb.ValueMember = "MaHTVay";
            cmb.DataPropertyName = "Ma_HTVay";
            cmb.HeaderText = "Hinh Thuc Vay";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = HTVplayer.DanhSachHinhThucVay();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public HTVay LayHinhThucVay(String ma)
        {
            DataTable tbl = new DataTable();
            HTVay htv = null;

            if (tbl.Rows.Count > 0)
                htv = new HTVay(Convert.ToString(tbl.Rows[0]["MaHinhThucVay"]), Convert.ToString(tbl.Rows[0]["TenHinhThucVay"]));

            return htv;
        }

        public void TimMaHinhThucVay(String mahtvay)
        {
            HTVplayer.TimHinhThucVayTheoMa(mahtvay);
        }

        public void TimTenHinhThucVay(String tenhtvay)
        {
            HTVplayer.TimHinhThucVayTheoTen(tenhtvay);
        }



        public bool Save()
        {
            return HTVplayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = HTVplayer.DanhSachHinhThucVay();
            cmb.DisplayMember = "TenHTVay";
            cmb.ValueMember = "MaHTVay";

        }
    }
}
