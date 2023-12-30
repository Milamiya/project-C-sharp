using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.DataLayer;
using QuanLyVayVonChoNHCSXH.BusinessObject;

namespace QuanLyVayVonChoNHCSXH.Controller
{
    public class VungController
    {
        VungLayer Vlayer = new VungLayer();       

        public void HienThiAutoComboBox(ComboBox cmb)
        {
            DataTable tbl = new DataTable();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenVung";
            cmb.ValueMember = "MaVung";
        }

        public DataGridViewComboBoxColumn HienThiDataGridViewComboBoxColumn()
        {
            DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            DataTable tbl = new DataTable();

            cmb.DataSource = tbl;
            cmb.DisplayMember = "TenVung";
            cmb.ValueMember = "MaVung";
            cmb.DataPropertyName = "Ma_Vung";
            cmb.HeaderText = "VungChoVay";

            return cmb;
        }

        public void HienThiDataGridView(DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Vlayer.DanhSachVung();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public Vung LayVung(String ma)
        {
            DataTable tbl = new DataTable();
            Vung v = null;

            if (tbl.Rows.Count > 0)
                v = new Vung(Convert.ToString(tbl.Rows[0]["MaVung"]), Convert.ToString(tbl.Rows[0]["TenVung"]));

            return v;
        }

        public void TimMaVung(String mavung)
        {
            Vlayer.TimVungTheoMa(mavung);
        }

        public void TimTenVung(String tenvung)
        {

            Vlayer.TimVungTheoTen(tenvung);
        }

        public bool Save()
        {
            return Vlayer.Save();
        }

        public void HienThiCombobox(ComboBox cmb)
        {
            cmb.DataSource = Vlayer.DanhSachVung();
            cmb.DisplayMember = "MaVung";
            cmb.ValueMember = "MaVung";
        }



    }
}
