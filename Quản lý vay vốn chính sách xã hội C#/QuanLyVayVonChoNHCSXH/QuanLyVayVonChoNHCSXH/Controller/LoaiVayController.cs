using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class LoaiVayController
    {
        LoaiVayPlayer LVplayer = new LoaiVayPlayer();

        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenLoaiVay";
            cmb.ValueMember = "MaLoaiVay";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenLoaiVay";
            cmb.ValueMember = "MaLoaiVay";
            cmb.DataPropertyName = "Ma_LoaiVay";
            cmb.HeaderText = "LoaiVay";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = LVplayer.DanhSachLoaiVay();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public LoaiVay LayLoaiVay(String ma)
        {
            DataTable tbl = new DataTable();
            LoaiVay lv = null;

            if (tbl.Rows.Count > 0)
                lv = new LoaiVay(Convert.ToString(tbl.Rows[0]["MaLoaiVay"]), Convert.ToString(tbl.Rows[0]["TenLoaiVay"]));

            return lv;
        }

        public void TimMaLoaiVay(String maloaivay)
        {
            LVplayer.TimLoaiVayTheoMa(maloaivay);
        }

        public void TimTenLoaiVay(String tenloaivay)
        {
            LVplayer.TimLoaiVayTheoTen(tenloaivay);
        }



        public bool Save()
        {
            return LVplayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = LVplayer.DanhSachLoaiVay();
            cmb.DisplayMember = "TenLoaiVay";
            cmb.ValueMember = "MaLoaiVay";

        }
    }
}
