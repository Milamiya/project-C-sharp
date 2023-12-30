using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class KieuTraController
    {
        KieuTraPlayer KTplayer = new KieuTraPlayer();

        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenKieuTra";
            cmb.ValueMember = "MaKieuTra";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenKieuTra";
            cmb.ValueMember = "MaKieuTra";
            cmb.DataPropertyName = "Ma_KieuTra";
            cmb.HeaderText = "KieuTra";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = KTplayer.DanhSachKieuTra();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public KieuTra LayKieuTra(String ma)
        {
            DataTable tbl = new DataTable();
            KieuTra kt = null;

            if (tbl.Rows.Count > 0)
                kt = new KieuTra(Convert.ToString(tbl.Rows[0]["MaKieuTra"]), Convert.ToString(tbl.Rows[0]["TenKieuTra"]));

            return kt;
        }

        public void TimMaKieuTra(String makieutra)
        {
            KTplayer.TimKieuTraTheoMa(makieutra);
        }

        public void TimTenKieuTra(String tenkieutra)
        {
            KTplayer.TimKieuTraTheoTen(tenkieutra);
        }



        public bool Save()
        {
            return KTplayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = KTplayer.DanhSachKieuTra();
            cmb.DisplayMember = "TenKieuTra";
            cmb.ValueMember = "MaKieuTra";

        }
    }
}
