using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
   public class DonViUyThacController
    {
        DonViUyThacPlayer DVUTplayer = new DonViUyThacPlayer();

        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenDVUyThac";
            cmb.ValueMember = "MaDVUyThac";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenDVUyThac";
            cmb.ValueMember = "MaDVUyThac";
            cmb.DataPropertyName = "Ma_DV_Uy_Thac";
            cmb.HeaderText = "Don Vi Uy Thac";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DVUTplayer.DanhSachDonViUyThac();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public DonViUyThac LayDonViUyThac(String ma)
        {
            DataTable tbl = new DataTable();
            DonViUyThac dvut = null;

            if (tbl.Rows.Count > 0)
                dvut = new DonViUyThac(Convert.ToString(tbl.Rows[0]["MaDVUyThac"]), Convert.ToString(tbl.Rows[0]["TenDVUyThac"]));

            return dvut;
        }

        public void TimMaDonViUyThac(String madvuythac)
        {
            DVUTplayer.TimDonViUyThacTheoMa(madvuythac);
        }

        public void TimTenDonViUyThac(String tendvuythac)
        {
            DVUTplayer.TimDonViUyThacTheoTen(tendvuythac);
        }



        public bool Save()
        {
            return DVUTplayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = DVUTplayer.DanhSachDonViUyThac();
            cmb.DisplayMember = "MaDVUyThac";
            cmb.ValueMember = "MaDVUyThac";

        }
    }
}
