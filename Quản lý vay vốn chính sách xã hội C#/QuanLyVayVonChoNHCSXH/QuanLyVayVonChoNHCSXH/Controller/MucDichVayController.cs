using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class MucDichVayController
    {
        MucDichVayPlayer MDVplayer = new MucDichVayPlayer();

        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenMucDichVay";
            cmb.ValueMember = "MaMucDichVay";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenMucDichVay";
            cmb.ValueMember = "MaMucDichVay";
            cmb.DataPropertyName = "Ma_MucDichVay";
            cmb.HeaderText = "MucDichVay";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = MDVplayer.DanhSachMucDichVay();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public MucDichVay LayMucDichVay(String ma)
        {
            DataTable tbl = new DataTable();
            MucDichVay mdv = null;

            if (tbl.Rows.Count > 0)
                mdv = new MucDichVay(Convert.ToString(tbl.Rows[0]["MaMucDichVay"]), Convert.ToString(tbl.Rows[0]["TenMucDichVay"]));

            return mdv;
        }

        public void TimMaMucDichVay(String mamucdichvay)
        {
            MDVplayer.TimMucDichVayTheoMa(mamucdichvay);
        }

        public void TimTenMucDichVay(String tenmucdichvay)
        {
            MDVplayer.TimMucDichVayTheoTen(tenmucdichvay);
        }



        public bool Save()
        {
            return MDVplayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = MDVplayer.DanhSachMucDichVay();
            cmb.DisplayMember = "TenMucDichVay";
            cmb.ValueMember = "MaMucDichVay";

        }
    }
}
