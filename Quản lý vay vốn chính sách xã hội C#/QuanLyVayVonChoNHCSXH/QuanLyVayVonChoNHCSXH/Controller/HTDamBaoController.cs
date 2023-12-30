using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class HTDamBaoController
    {
        HTDamBaoPlayer HTDBplayer = new HTDamBaoPlayer();

        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenHTDamBao";
            cmb.ValueMember = "MaHTDamBao";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenHTDamBao";
            cmb.ValueMember = "MaHTDamBao";
            cmb.DataPropertyName = "Ma_HTDamBao";
            cmb.HeaderText = "HTDamBao";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = HTDBplayer.DanhSachHTDamBao();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public HTDamBao LayHTDamBao(String ma)
        {
            DataTable tbl = new DataTable();
            HTDamBao htdb = null;

            if (tbl.Rows.Count > 0)
                htdb = new HTDamBao(Convert.ToString(tbl.Rows[0]["MaHTDamBao"]), Convert.ToString(tbl.Rows[0]["TenHTDamBao"]));

            return htdb;
        }

        public void TimMaHTDamBao(String mahtdambao)
        {
            HTDBplayer.TimHTDamBaoTheoMa(mahtdambao);
        }

        public void TimTenHTDamBao(String tenhtdambao)
        {
            HTDBplayer.TimHTDamBaoTheoTen(tenhtdambao);
        }



        public bool Save()
        {
            return HTDBplayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = HTDBplayer.DanhSachHTDamBao();
            cmb.DisplayMember = "TenHTDamBao";
            cmb.ValueMember = "MaHTDamBao";

        }
    }
}
