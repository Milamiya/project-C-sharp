using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class ChuongTrinhController
    {

        ChuongTrinhPlayer CTplayer = new ChuongTrinhPlayer();

        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenChuongTrinh";
            cmb.ValueMember = "MaChuongTrinh";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenChuongTrinh";
            cmb.ValueMember = "MaChuongTrinh";
            cmb.DataPropertyName = "Ma_ChuongTrinh";
            cmb.HeaderText = "ChuongTrinh";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = CTplayer.DanhSachChuongTrinh();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public ChuongTrinh LayChuongTrinh(String ma)
        {
            DataTable tbl = new DataTable();
            ChuongTrinh ct = null;

            if (tbl.Rows.Count > 0)
                ct = new ChuongTrinh(Convert.ToString(tbl.Rows[0]["MaChuongTrinh"]), Convert.ToString(tbl.Rows[0]["TenChuongTrinh"]));

            return ct;
        }

        public void TimMaChuongTrinh(String machuongtrinh)
        {
            CTplayer.TimChuongTrinhTheoMa(machuongtrinh);
        }

        public void TimTenChuongTrinh(String tenchuongtrinh)
        {
            CTplayer.TimChuongTrinhTheoTen(tenchuongtrinh);
        }



        public bool Save()
        {
            return CTplayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = CTplayer.DanhSachChuongTrinh();
            cmb.DisplayMember = "TenChuongTrinh";
            cmb.ValueMember = "MaChuongTrinh";

        }
    }
}
