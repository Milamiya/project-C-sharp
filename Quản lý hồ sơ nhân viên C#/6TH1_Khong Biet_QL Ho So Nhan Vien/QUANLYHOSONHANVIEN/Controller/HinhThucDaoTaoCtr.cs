using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Windows.Forms;
using System.Data;

namespace QUANLYHOSONHANVIEN.Controller
{
    public  class HinhThucDaoTaoCtr
    {
        HinhThucDaoTaoData  data = new HinhThucDaoTaoData();
        public void HienthiHINHTHUCDTDataGridview(System.Windows.Forms.DataGridView dg)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachHINHTHUCDAOTAO();
            bs.DataSource = tbl;
            dg.DataSource = bs;

        }
        public void HienThiAutoCombobox(ComboBox cmb)
        {
            DataTable tbl = data.DanhsachHINHTHUCDAOTAO();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENHTDT";
            cmb.ValueMember = "MAHTDT";
        }
    }
}
