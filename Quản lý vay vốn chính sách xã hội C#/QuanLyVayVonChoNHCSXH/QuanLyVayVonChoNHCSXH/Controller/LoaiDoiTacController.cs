using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class LoaiDoiTacController
    {
        LoaiDoiTacPlayer LDTplayer = new LoaiDoiTacPlayer();

        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenLoaiDoiTac";
            cmb.ValueMember = "MaLoaiDoiTac";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenLoaiDoiTac";
            cmb.ValueMember = "MaLoaiDoiTac";
            cmb.DataPropertyName = "Ma_LoaiDoiTac";
            cmb.HeaderText = "LoaiDoiTac";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = LDTplayer.DanhSachLoaiDoiTac();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public LoaiDoiTac LayLoaiDoiTac(String ma)
        {
            DataTable tbl = new DataTable();
            LoaiDoiTac ldt = null;

            if (tbl.Rows.Count > 0)
                ldt = new LoaiDoiTac(Convert.ToString(tbl.Rows[0]["MaLoaiDoiTac"]), Convert.ToString(tbl.Rows[0]["TenLoaiDoiTac"]));

            return ldt;
        }

        public void TimMaLoaiDoiTac(String maloaidoitac)
        {
            LDTplayer.TimLoaiDoiTacTheoMa(maloaidoitac);
        }

        public void TimTenLoaiDoiTac(String tenloaidoitac)
        {
            LDTplayer.TimLoaiDoiTacTheoTen(tenloaidoitac);
        }



        public bool Save()
        {
            return LDTplayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = LDTplayer.DanhSachLoaiDoiTac();
            cmb.DisplayMember = "TenLoaiDoiTac";
            cmb.ValueMember = "MaLoaiDoiTac";

        }
    }
}
