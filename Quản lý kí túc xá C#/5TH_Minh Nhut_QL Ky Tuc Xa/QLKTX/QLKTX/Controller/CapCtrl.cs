using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QLKTX.BusinessObject;
using QLKTX.Controller;
using QLKTX.DataLayer;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;

namespace QLKTX.Controller
{
    public class CapCtrl
    {
        CapData data = new CapData();
        public void DataTableToListView(ListViewEx list)
        {
            list.Items.Clear();
            DataTable table = data.LayDSCap();
            foreach (DataRow r in table.Rows)
            {

                ListViewItem item = new ListViewItem();
                item.Text = r["MACAP"].ToString();
                item.SubItems.Add(r["TENCAP"].ToString());

                CapInfo qh = new CapInfo();
                qh.MaCap= Convert.ToInt32(r["MACAP"]);
                qh.TenCap = r["TENCAP"].ToString();
                item.Tag = qh;

                list.Items.Add(item);

            }

        }
        public int LayMaMax()
        {
            QLKTX.DataLayer.CapData data = new CapData();
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
        
        public void LayDuLieuLenDataGridViewComboBoxColumn(DataGridViewComboBoxColumn com)
        {
            CapData data = new CapData();
            com.DataSource = data.LayDSCap();
            com.DisplayMember = "TENCAP";
            com.ValueMember = "MACAP";
            com.DataPropertyName = "MACAP";
            com.HeaderText = "Cấp";
        }
        public void LayDuLieuLenComboBox(ComboBox com)
        {
            CapData data = new CapData();
            com.DataSource = data.LayDSCap();
            com.DisplayMember = "TENCAP";
            com.ValueMember = "MACAP";

        }
        public CapInfo ListViewItemToInfo(ListViewItem item)
        {
            CapInfo ttp = new CapInfo();
            ttp.MaCap = Convert.ToInt32(item.Text);
            ttp.TenCap = item.SubItems[1].Text;
            return ttp;
        }
        /// <summary>
        /// Hiển Thi Danh sách lên TextBox từ ListView
        /// </summary>
        /// <param name="list">ListView chứa danh sách</param>
        /// <param name="txtMa">TextBox chứa mã</param>
        /// <param name="txtTen">TextBox chứa tên</param>
        public void ListViewToControl(ListView list, TextBox txtMa, TextBox txtTen)
        {
            if (list.SelectedItems.Count > 0)
            {
                ListViewItem item = list.SelectedItems[0];
                txtMa.Text = item.Text;
                txtTen.Text = item.SubItems[1].Text;
            }
        }
        public CapInfo ControlToInfo(TextBox txtMa, TextBox txtTen)
        {
            CapInfo ttp = new CapInfo();
            ttp.MaCap = Convert.ToInt32(txtMa.Text);
            ttp.TenCap = txtTen.Text;
            return ttp;
        }
        public bool Them(CapInfo cap)
        {
            return data.Them(cap);
        }
        public bool Xoa(CapInfo cap)
        {
            return data.Xoa(cap);
        }
        public bool Sua(CapInfo cap)
        {
            return data.Sua(cap);
        }
        public bool KiemTra(TextBox txtMa, TextBox txtTen)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Chưa nhập Mã Số", "Cấp");
                txtMa.Focus();
                return false;
            }
            else
            {
                int i = -1;
                try
                {
                    i = Convert.ToInt32(txtMa.Text);
                    if (i < 1)
                    {
                        MessageBox.Show("Chỉ nhập Số Nguyên dương", "Cấp");
                        txtMa.Focus();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Chỉ nhập Số", "Cấp");
                    txtMa.Focus();
                    return false;
                }

            }
            if (txtTen.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên", "Cấp");
                txtTen.Focus();
                return false;
            }
            else
            {
                if (txtTen.Text.Length > 30)
                {
                    MessageBox.Show("Không nhập quá 30 kí tự!", "Cấp");
                    txtTen.Focus();
                    return false;
                }
            }
            return true;

        }
        public ListViewItem DataRowToListViewItem(DataRow row)
        {
            ListViewItem item = new ListViewItem();
            item.Text = row["MACAP"].ToString();
            item.SubItems.Add(row["TENCAP"].ToString());

            CapInfo info = ListViewItemToInfo(item);
            item.Tag = info;
            return item;
        }
        public void LayLenListView(ListView list)
        {
            list.Items.Clear();
            CapData d = new CapData();
            DataTable table = d.LayDSCap();
            foreach (DataRow row in table.Rows)
            {
                list.Items.Add(DataRowToListViewItem(row));
            }
        }
        public int LayMaLonNhat()
        {
            DataTable table = data.LayMaLonNhat();
            try
            {
                int i = Convert.ToInt32(table.Rows[0][0].ToString());
                return ++i;
            }
            catch (Exception e)
            {
                return 1;
            }
        }
        public bool ThemCap(CapInfo cap)
        {
            CapData qhdt = new CapData();
            return qhdt.ThemCap(cap);
        }
        public bool XoaCap(CapInfo cap)
        {
            CapData qhdt = new CapData();
            return qhdt.XoaCap(cap);
        }
        public bool SuaCap(CapInfo cap)
        {
            CapData qhdt = new CapData();
            return qhdt.CapNhatCap(cap);
        }
    }
}
