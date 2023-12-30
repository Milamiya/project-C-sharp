using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class PhongBanController
    {
        PhongBanPlayer PBplayer = new PhongBanPlayer();

        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenPhongBan";
            cmb.ValueMember = "MaPhongBan";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenPhongBan";
            cmb.ValueMember = "MaPhongBan";
            cmb.DataPropertyName = "Ma_PhongBan";
            cmb.HeaderText = "PhongBan";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = PBplayer.DanhSachPhongBan();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public PhongBan LayPhongBan(String ma)
        {
            DataTable tbl = new DataTable();
            PhongBan pb = null;

            if (tbl.Rows.Count > 0)
                pb = new PhongBan(Convert.ToString(tbl.Rows[0]["MaPhongBan"]), Convert.ToString(tbl.Rows[0]["TenPhongBan"]));

            return pb;
        }

        public void TimMaPhongBan(String maphongban)
        {
            PBplayer.TimPhongBanTheoMa(maphongban);
        }

        public void TimTenPhongBan(String tenphongban)
        {
            PBplayer.TimPhongBanTheoTen(tenphongban);
        }



        public bool Save()
        {
            return PBplayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = PBplayer.DanhSachPhongBan();
            cmb.DisplayMember = "MaPhongBan";
            cmb.ValueMember = "MaPhongBan";

        }
    }
}
