using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
  public class TinhController
    {
        TinhPlayer Tplayer = new TinhPlayer();

        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenTinh";
            cmb.ValueMember = "MaTinh";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenTinh";
            cmb.ValueMember = "MaTinh";
            cmb.DataPropertyName = "Ma_Tinh";
            cmb.HeaderText = "Tinh";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Tplayer.DanhSachTinh();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public Tinh LayTinh(String ma)
        {
            DataTable tbl = new DataTable();
            Tinh t = null;

            if (tbl.Rows.Count > 0)
                t = new Tinh(Convert.ToString(tbl.Rows[0]["MaTinh"]), Convert.ToString(tbl.Rows[0]["TenTinh"]));

            return t;
        }

        public void TimMaTinh(String matinh)
        {
            Tplayer.TimTinhTheoMa(matinh);
        }

        public void TimTenTinh(String tentinh)
        {
            Tplayer.TimTinhTheoTen(tentinh);
        }



        public bool Save()
        {
            return Tplayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = Tplayer.DanhSachTinh();
            cmb.DisplayMember = "TenTinh";
            cmb.ValueMember = "MaTinh";

        }
    }
}
