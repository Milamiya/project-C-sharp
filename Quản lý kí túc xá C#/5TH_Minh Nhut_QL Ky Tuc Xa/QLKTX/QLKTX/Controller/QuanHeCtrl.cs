using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Data;
using QLKTX.DataLayer;
using QLKTX.BusinessObject;
using System.Windows.Forms;

namespace QLKTX.Controller
{
    public class QuanHeCtrl
    {
        QuanHeData data = new QuanHeData();
        public void LayComboboxQuanHe(ComboBoxEx cmb)
        {
            cmb.DataSource = data.DSQuanHe();
            cmb.DisplayMember = "TENQUANHE";
            cmb.ValueMember = "MAQUANHE";
        }
        public void DataTableToListView(ListViewEx list)
        {
            list.Items.Clear();
            DataTable table= data.DSQuanHe();
            foreach (DataRow r in table.Rows)
            {

                ListViewItem item = new ListViewItem();
                item.Text = r["MAQUANHE"].ToString();
                item.SubItems.Add(r["TENQUANHE"].ToString());

                QuanHeInfo qh = new QuanHeInfo();
                qh.MaQuanHe = Convert.ToInt32(r["MAQUANHE"]);
                qh.TenQuanHe = r["TENQUANHE"].ToString();
                item.Tag = qh;

                list.Items.Add(item);               

            }
            
        }
        public int LayMaMax()
        {
            QLKTX.DataLayer.QuanHeData data = new QuanHeData();
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
        public bool ThemQuanHe(QuanHeInfo qh)
        {
            QuanHeData qhdt=new QuanHeData();
            return qhdt.ThemQuanHe(qh);
        }
        public bool XoaQuanHe(QuanHeInfo qh)
        {
            QuanHeData qhdt = new QuanHeData();
            return qhdt.XoaQuanHe(qh);
        }
        public bool SuaQuanHe(QuanHeInfo qh)
        {
            QuanHeData qhdt = new QuanHeData();
            return qhdt.CapNhatQuanHe(qh);
        }
    }
}
