using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class LoaiHinhController
    {
        LoaiHinhPlayer LHplayer = new LoaiHinhPlayer();

        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenLoaiHinh";
            cmb.ValueMember = "MaLoaiHinh";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenLoaiHinh";
            cmb.ValueMember = "MaLoaiHinh";
            cmb.DataPropertyName = "Ma_LoaiHinh";
            cmb.HeaderText = "LoaiHinh";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = LHplayer.DanhSachLoaiHinh();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public LoaiHinh LayLoaiHinh(String ma)
        {
            DataTable tbl = new DataTable();
            LoaiHinh lh = null;

            if (tbl.Rows.Count > 0)
                lh = new LoaiHinh(Convert.ToString(tbl.Rows[0]["MaLoaiHinh"]), Convert.ToString(tbl.Rows[0]["TenLoaiHinh"]));

            return lh;
        }

        public void TimMaLoaiHinh(String maloaihinh)
        {
            LHplayer.TimLoaiHinhTheoMa(maloaihinh);
        }

        public void TimTenLoaiHinh(String tenloaihinh)
        {
            LHplayer.TimLoaiHinhTheoTen(tenloaihinh);
        }



        public bool Save()
        {
            return LHplayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = LHplayer.DanhSachLoaiHinh();
            cmb.DisplayMember = "TenLoaiHinh";
            cmb.ValueMember = "MaLoaiHinh";

        }
    }
}
