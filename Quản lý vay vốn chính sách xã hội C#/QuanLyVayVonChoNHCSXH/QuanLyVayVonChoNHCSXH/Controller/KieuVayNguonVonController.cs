using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
    class KieuVayNguonVonController
    {
        KieuVayNguonVonPlayer KVNVplayer = new KieuVayNguonVonPlayer();

        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenKVNV";
            cmb.ValueMember = "MaKVNV";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenKVNV";
            cmb.ValueMember = "MaKVNV";
            cmb.DataPropertyName = "Ma_KVNV";
            cmb.HeaderText = "KVNV";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = KVNVplayer.DanhSachKieuVayNguonVon();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public KVNV LayKieuVayNguonVon(String ma)
        {
            DataTable tbl = new DataTable();
            KVNV kvnv = null;

            if (tbl.Rows.Count > 0)
                kvnv = new KVNV(Convert.ToString(tbl.Rows[0]["MaKVNV"]), Convert.ToString(tbl.Rows[0]["TenKVNV"]));

            return kvnv;
        }

        public void TimMaKieuVayNguonVon(String makvnv)
        {
            KVNVplayer.TimKieuVayNguonVonTheoMa(makvnv);
        }

        public void TimTenKieuVayNguonVon(String tenkvnv)
        {
            KVNVplayer.TimKieuVayNguonVonTheoTen(tenkvnv);
        }



        public bool Save()
        {
            return KVNVplayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = KVNVplayer.DanhSachKieuVayNguonVon();
            cmb.DisplayMember = "TenKVNV";
            cmb.ValueMember = "MaKVNV";

        }
    }
}
