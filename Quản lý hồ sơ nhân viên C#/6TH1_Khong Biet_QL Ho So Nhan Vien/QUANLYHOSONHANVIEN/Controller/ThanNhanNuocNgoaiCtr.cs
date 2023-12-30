using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Data;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class ThanNhanNuocNgoaiCtr
    {
        ThanNhanNuocNgoaiData data = new ThanNhanNuocNgoaiData();
        public void HienthiTHANNHANNUOCNGOAIDataGridview(System.Windows.Forms.DataGridView dg, string manv)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DanhsachTHANNHANNUOCNGOAI(manv);
            bs.DataSource = tbl;
            dg.DataSource = bs;

        }

        public DataRow NewRow()
        {
            return data.NewRow();
        }
        public void Add(DataRow row)
        {
            data.Add(row);
        }
        public bool Save()
        {
            return data.Save();
        }
    }
}
