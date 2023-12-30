using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class KeToanDoController
    {
        KeToanDoPlayer KTDplayer = new KeToanDoPlayer();

        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "MaCap";
            cmb.ValueMember = "MaCap";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenCap";
            cmb.ValueMember = "MaCap";
            cmb.DataPropertyName = "Ma_Cap";
            cmb.HeaderText = "Ma Cap";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = KTDplayer.DanhSachKeToanDo();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public KeToanDo LayKeToanDo(String ma)
        {
            DataTable tbl = new DataTable();
            KeToanDo ktd = null;

            if (tbl.Rows.Count > 0)
                ktd = new KeToanDo(Convert.ToString(tbl.Rows[0]["MaKeToanDo"]), Convert.ToString(tbl.Rows[0]["TenKeToanDo"]));

            return ktd;
        }

        public void TimMaKeToanDo(String macap)
        {
            KTDplayer.TimKeToanDoTheoMa(macap);
        }

        public void TimTenKeToanDo(String tencap)
        {
            KTDplayer.TimKeToanDoTheoTen(tencap);
        }



        public bool Save()
        {
            return KTDplayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = KTDplayer.DanhSachKeToanDo();
            cmb.DisplayMember = "MaCap";
            cmb.ValueMember = "MaCap";

        }
    }
}
