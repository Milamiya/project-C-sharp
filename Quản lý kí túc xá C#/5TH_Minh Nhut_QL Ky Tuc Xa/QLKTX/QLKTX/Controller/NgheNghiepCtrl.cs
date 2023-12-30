using System;
using System.Collections.Generic;
using System.Text;
using QLKTX.DataLayer;
using DevComponents.DotNetBar.Controls;
using QLKTX.BusinessObject;
using System.Data;
using System.Windows.Forms;
namespace QLKTX.Controller
{
    public class NgheNghiepCtrl
    {
        NgheNghiepData data = new NgheNghiepData();
        public void LayComboboxNgheNghiep(ComboBoxEx cmb)
        {
            cmb.DataSource = data.DSNgheNghiep();
            cmb.DisplayMember = "TENNGHENGHIEP";
            cmb.ValueMember = "MANGHENGHIEP";
        }

        public void DataTableToListView(ListViewEx list)
        {
            list.Items.Clear();
            DataTable table = data.DSNgheNghiep();
            foreach (DataRow r in table.Rows)
            {

                ListViewItem item = new ListViewItem();
                item.Text = r["MANGHENGHIEP"].ToString();
                item.SubItems.Add(r["TENNGHENGHIEP"].ToString());

                NgheNghiepInfo qh = new NgheNghiepInfo();
                qh.MaNgheNghiep = Convert.ToInt32(r["MANGHENGHIEP"]);
                qh.TenNgheNghep = r["TENNGHENGHIEP"].ToString();
                item.Tag = qh;

                list.Items.Add(item);

            }

        }
        public int LayMaMax()
        {
            QLKTX.DataLayer.NgheNghiepData data = new NgheNghiepData();
            DataTable table = data.LayMaMax();

            try
            {
                int i = Convert.ToInt32(table.Rows[0][0].ToString());
                return ++i;
            }
            catch (Exception e)
            {
                e.ToString();
                return 1;
            }

        }
        public bool ThemNgheNghiep(NgheNghiepInfo nn)
        {
            NgheNghiepData qhdt = new NgheNghiepData();
            return qhdt.ThemNgheNghiep(nn);
        }
        public bool XoaNgheNghiep(NgheNghiepInfo nn)
        {
            NgheNghiepData qhdt = new NgheNghiepData();
            return qhdt.XoaNgheNghiep(nn);
        }
        public bool SuaNgheNghiep(NgheNghiepInfo nn)
        {
            NgheNghiepData qhdt = new NgheNghiepData();
            return qhdt.CapNhatNgheNghiep(nn);
        }
    }
}
