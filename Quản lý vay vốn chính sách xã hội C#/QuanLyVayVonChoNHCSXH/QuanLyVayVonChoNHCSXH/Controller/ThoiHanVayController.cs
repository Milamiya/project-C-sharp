using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class ThoiHanVayController
    {
        ThoiHanVayPlayer THVplayer = new ThoiHanVayPlayer();

        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenThoiHanVay";
            cmb.ValueMember = "MaThoiHanVay";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenThoiHanVay";
            cmb.ValueMember = "MaThoiHanVay";
            cmb.DataPropertyName = "Ma_ThoiHanVay";
            cmb.HeaderText = "ThoiHanVay";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = THVplayer.DanhSachThoiHanVay();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public ThoiHanVay LayThoiHanVay(String ma)
        {
            DataTable tbl = new DataTable();
            ThoiHanVay thv = null;

            if (tbl.Rows.Count > 0)
                thv = new ThoiHanVay(Convert.ToString(tbl.Rows[0]["MaThoiHanVay"]), Convert.ToString(tbl.Rows[0]["TenThoiHanVay"]));

            return thv;
        }

        public void TimMaThoiHanVay(String mathoihanvay)
        {
            THVplayer.TimThoiHanVayTheoMa(mathoihanvay);
        }

        public void TimTenThoiHanVay(String tenthoihanvay)
        {
            THVplayer.TimThoiHanVayTheoTen(tenthoihanvay);
        }



        public bool Save()
        {
            return THVplayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = THVplayer.DanhSachThoiHanVay();
            cmb.DisplayMember = "MaThoiHanVay";
            cmb.ValueMember = "MaThoiHanVay";

        }
    }
}
