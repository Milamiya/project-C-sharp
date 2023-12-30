using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class XaController
    {
        XaPlayer Xplayer = new XaPlayer();

        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenXa";
            cmb.ValueMember = "MaXa";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenXa";
            cmb.ValueMember = "MaXa";
            cmb.DataPropertyName = "Ma_Xa";
            cmb.HeaderText = "Xa";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Xplayer.DanhSachXa();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public Xa LayXa(String ma)
        {
            DataTable tbl = new DataTable();
            Xa x = null;

            if (tbl.Rows.Count > 0)
                x = new Xa(Convert.ToString(tbl.Rows[0]["MaXa"]), Convert.ToString(tbl.Rows[0]["TenXa"]));

            return x;
        }

        public void TimMaXa(String maxa)
        {
            Xplayer.TimXaTheoMa(maxa);
        }

        public void TimTenXa(String tenxa)
        {
            Xplayer.TimXaTheoTen(tenxa);
        }



        public bool Save()
        {
            return Xplayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = Xplayer.DanhSachXa();
            cmb.DisplayMember = "MaXa";
            cmb.ValueMember = "MaXa";

        }

       public void HienThiComboboxTheoHuyen(ComboBox cmb, String MaHuyen)
       {
           cmb.DataSource = Xplayer.DanhSachXa(MaHuyen);
           cmb.DisplayMember = "TenXa";
           cmb.ValueMember = "MaXa";

       }
    }
}
