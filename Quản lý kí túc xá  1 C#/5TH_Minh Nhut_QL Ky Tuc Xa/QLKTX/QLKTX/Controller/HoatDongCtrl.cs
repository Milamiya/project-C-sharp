using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using QLKTX.DataLayer;
using QLKTX.BusinessObject;
using System.Windows.Forms;
namespace QLKTX.Controller
{
    public class HoatDongCtrl
    {
        HoatDongData data = new HoatDongData();
        public void LayDuLieuLenDataGridViewComboBoxColumn(DataGridViewComboBoxColumn com)
        {
            HoatDongData data = new HoatDongData();
            com.DataSource = data.LayDSHoatDong();
            com.DisplayMember = "TENHOATDONG";
            com.ValueMember = "MAHOATDONG";
            com.DataPropertyName = "MAHOATDONG";
            com.HeaderText = "Hoạt động";
        }
        public void LayDuLieuLenComboBox(ComboBox com)
        {
            HoatDongData data = new HoatDongData();
            com.DataSource = data.LayDSHoatDong();
            com.DisplayMember = "TENHOATDONG";
            com.ValueMember = "MAHOATDONG";

        }
        public HoatDongInfo ListViewItemToInfo(ListViewItem item)
        {
            HoatDongInfo hd = new HoatDongInfo();
            hd.MaHoatDong = Convert.ToInt32(item.Text);
            hd.TenHoatDong = item.SubItems[1].Text;
            return hd;
        }
        public void ListViewToControl(ListView list, TextBox txtMa, TextBox txtTen)
        {
            if (list.SelectedItems.Count > 0)
            {
                ListViewItem item = list.SelectedItems[0];
                txtMa.Text = item.Text;
                txtTen.Text = item.SubItems[1].Text;
            }
        }
        public HoatDongInfo ControlToInfo(TextBox txtMa, TextBox txtTen)
        {
            HoatDongInfo hd = new HoatDongInfo();
            hd.MaHoatDong = Convert.ToInt32(txtMa.Text);
            hd.TenHoatDong = txtTen.Text;
            return hd;
        }
        public bool Them(HoatDongInfo phong)
        {
            return data.Them(phong);
        }
        public bool Xoa(HoatDongInfo phong)
        {
            return data.Xoa(phong);
        }
        public bool Sua(HoatDongInfo phong)
        {
            return data.Sua(phong);
        }
        public bool KiemTra(TextBox txtMa, TextBox txtTen)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Chưa nhập Mã Số", "Tình trạng Phòng");
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
                        MessageBox.Show("Chỉ nhập Số Nguyên dương", "Tình trạng Phòng");
                        txtMa.Focus();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Chỉ nhập Số", "Tình trạng Phòng");
                    txtMa.Focus();
                    return false;
                }

            }
            if (txtTen.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên", "Tình trạng Phòng");
                txtTen.Focus();
                return false;
            }
            else
            {
                if (txtTen.Text.Length > 30)
                {
                    MessageBox.Show("Không nhập quá 30 kí tự!", "Tình trạng Phòng");
                    txtTen.Focus();
                    return false;
                }
            }
            return true;

        }
        public ListViewItem DataRowToListViewItem(DataRow row)
        {
            ListViewItem item = new ListViewItem();
            item.Text = row["MAHOATDONG"].ToString();
            item.SubItems.Add(row["TENHOATDONG"].ToString());

            HoatDongInfo info = ListViewItemToInfo(item);
            item.Tag = info;
            return item;
        }
        public void LayLenListView(ListView list)
        {
            list.Items.Clear();
            HoatDongData d = new HoatDongData();
            DataTable table = d.LayDSHoatDong();
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
        public void Tim(DataGridView dg, string ma)
        {
            HoatDongData data = new HoatDongData();
            dg.DataSource = data.Tim(ma);
        }
    }
}
