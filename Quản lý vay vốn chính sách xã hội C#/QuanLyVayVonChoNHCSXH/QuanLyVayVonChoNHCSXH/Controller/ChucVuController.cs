using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class ChucVuController
    {
        ChucVuPlayer CVplayer = new ChucVuPlayer();

        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenChucVu";
            cmb.ValueMember = "MaChucVu";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenChucVu";
            cmb.ValueMember = "MaChucVu";
            cmb.DataPropertyName = "Ma_ChucVu";
            cmb.HeaderText = "ChucVu";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = CVplayer.DanhSachChucVu();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public ChucVu LayChucVu(String ma)
        {
            DataTable tbl = new DataTable();
            ChucVu cv = null;

            if (tbl.Rows.Count > 0)
                cv = new ChucVu(Convert.ToString(tbl.Rows[0]["MaChucVu"]), Convert.ToString(tbl.Rows[0]["TenChucVu"]));

            return cv;
        }

        public void TimMaChucVu(String machucvu)
        {
            CVplayer.TimChucVuTheoMa(machucvu);
        }

        public void TimTenChucVu(String tenchucvu)
        {
            CVplayer.TimChucVuTheoTen(tenchucvu);
        }



        public bool Save()
        {
            return CVplayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = CVplayer.DanhSachChucVu();
            cmb.DisplayMember = "MaChucVu";
            cmb.ValueMember = "MaChucVu";

        }
    }
}
