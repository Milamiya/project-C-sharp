using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Data;
using System.Windows.Forms;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class QuaTrinhCongTacCtr
    {
        QuaTrinhCongTacData data = new QuaTrinhCongTacData();
        ChucVuData data_chucvu = new ChucVuData();
        public void HienthiQuaTrinhCTGridview(System.Windows.Forms.DataGridView dg, string manv)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachQuaTrinhCT(manv);
            bs.DataSource = tbl;
            //bn.BindingSource = bs;
            dg.DataSource = bs;
        }
        public void HienthiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataSource = data_chucvu.DanhsachChucVu();
            cmb.DisplayMember = "TENCV";
            cmb.ValueMember = "MACV";
            cmb.DataPropertyName = "CHUCVUCAONHAT";
            cmb.AutoComplete = true;
        }
    }
}
