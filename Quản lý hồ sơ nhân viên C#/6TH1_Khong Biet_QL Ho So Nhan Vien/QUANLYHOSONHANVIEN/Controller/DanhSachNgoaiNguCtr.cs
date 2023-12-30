using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Data;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class DanhSachNgoaiNguCtr
    {
        DanhSachNgoaiNguData data = new DanhSachNgoaiNguData();
        public void HienthiDanhSachNgoainguDataGridview(System.Windows.Forms.DataGridView dg, string manv)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DANHSACHNGOAINGU(manv);
            bs.DataSource = tbl;
            //bn.BindingSource = bs;
            dg.DataSource = bs;
        }
    }
}
