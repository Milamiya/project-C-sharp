using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class LoaiChungTuController
    {
        LoaiChungTuPlayer LCTplayer = new LoaiChungTuPlayer();

        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenLoaiChungTu";
            cmb.ValueMember = "MaLoaiChungTu";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenLoaiChungTu";
            cmb.ValueMember = "MaLoaiChungTu";
            cmb.DataPropertyName = "Ma_LoaiChungTu";
            cmb.HeaderText = "LoaiChungTu";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = LCTplayer.DanhSachLoaiChungTu();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public LoaiChungTu LayLoaiChungTu(String ma)
        {
            DataTable tbl = new DataTable();
            LoaiChungTu lct = null;

            if (tbl.Rows.Count > 0)
                lct = new LoaiChungTu(Convert.ToString(tbl.Rows[0]["MaLoaiChungTu"]), Convert.ToString(tbl.Rows[0]["TenLoaiChungTu"]));

            return lct;
        }

        public void TimMaLoaiChungTu(String maloaichungtu)
        {
            LCTplayer.TimLoaiChungTuTheoMa(maloaichungtu);
        }

        public void TimTenLoaiChungTu(String tenloaichungtu)
        {
            LCTplayer.TimLoaiChungTuTheoTen(tenloaichungtu);
        }



        public bool Save()
        {
            return LCTplayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = LCTplayer.DanhSachLoaiChungTu();
            cmb.DisplayMember = "TenLoaiChungTu";
            cmb.ValueMember = "MaLoaiChungTu";

        }
    }
}
