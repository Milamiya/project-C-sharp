using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class DanTocController
    {

        DanTocPlayer DTplayer = new DanTocPlayer();

        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenDanToc";
            cmb.ValueMember = "MaDanToc";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenDanToc";
            cmb.ValueMember = "MaDanToc";
            cmb.DataPropertyName = "Ma_DanToc";
            cmb.HeaderText = "DanToc";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DTplayer.DanhSachDanToc();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public DanToc LayDanToc(String ma)
        {
            DataTable tbl = new DataTable();
            DanToc dt = null;

            if (tbl.Rows.Count > 0)
                dt = new DanToc(Convert.ToString(tbl.Rows[0]["MaDanToc"]), Convert.ToString(tbl.Rows[0]["TenDanToc"]));

            return dt;
        }

        public void TimMaDanToc(String madantoc)
        {
            DTplayer.TimDanTocTheoMa(madantoc);
        }

        public void TimTenDanToc(String tendantoc)
        {
            DTplayer.TimDanTocTheoTen(tendantoc);
        }



        public bool Save()
        {
            return DTplayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = DTplayer.DanhSachDanToc();
            cmb.DisplayMember = "TenDanToc";
            cmb.ValueMember = "MaDanToc";

        }

       
    }
}
