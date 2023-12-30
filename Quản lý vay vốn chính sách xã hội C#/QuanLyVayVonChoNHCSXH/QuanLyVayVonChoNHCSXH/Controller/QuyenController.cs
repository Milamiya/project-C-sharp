using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class QuyenController
    {
        QuyenPlayer Qplayer = new QuyenPlayer();

        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenQuyen";
            cmb.ValueMember = "MaQuyen";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenQuyen";
            cmb.ValueMember = "MaQuyen";
            cmb.DataPropertyName = "Ma_Quyen";
            cmb.HeaderText = "Quyen";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Qplayer.DanhSachQuyen();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public Quyen LayQuyen(String ma)
        {
            DataTable tbl = new DataTable();
            Quyen q = null;

            if (tbl.Rows.Count > 0)
                q = new Quyen(Convert.ToString(tbl.Rows[0]["MaQuyen"]), Convert.ToString(tbl.Rows[0]["TenQuyen"]));

            return q;
        }

        public void TimMaQuyen(String maquyen)
        {
            Qplayer.TimQuyenTheoMa(maquyen);
        }

        public void TimTenQuyen(String tenquyen)
        {
            Qplayer.TimQuyenTheoTen(tenquyen);
        }



        public bool Save()
        {
            return Qplayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = Qplayer.DanhSachQuyen();
            cmb.DisplayMember = "TenQuyen";
            cmb.ValueMember = "MaQuyen";

        }
    }
}
