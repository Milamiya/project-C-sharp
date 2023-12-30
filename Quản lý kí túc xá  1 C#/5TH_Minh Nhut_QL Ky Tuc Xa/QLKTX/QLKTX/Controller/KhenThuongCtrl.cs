using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using QLKTX.DataLayer;
using QLKTX.BusinessObject;
using System.Windows.Forms;
namespace QLKTX.Controller
{
    public class KhenThuongCtrl
    {
        KhenThuongData data = new KhenThuongData();
        public void LayDuLieuLenDataGridViewComboBoxColumn(DataGridViewComboBoxColumn com)
        {
            KhenThuongData data = new KhenThuongData();
            com.DataSource = data.LayDSKhenThuong();
            com.DisplayMember = "TENHOATDONG";
            com.ValueMember = "MAHOATDONG";
            com.DataPropertyName = "MAHOATDONG";
            com.HeaderText = "Khen Thuởng";
        }
        public void LayDuLieuLenComboBox(ComboBox com)
        {
            KhenThuongData data = new KhenThuongData();
            com.DataSource = data.LayDSKhenThuong();
            com.DisplayMember = "TENHOATDONG";
            com.ValueMember = "MAHOATDONG";

        }
        public KhenThuongInfo ListViewItemToInfo(ListViewItem item)
        {
            KhenThuongInfo hd = new KhenThuongInfo();
            hd.MaKhenThuong = Convert.ToInt32(item.Text);
            hd.TenKhenThuong = item.SubItems[1].Text;
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
        public KhenThuongInfo ControlToInfo(TextBox txtMa, TextBox txtTen)
        {
            KhenThuongInfo hd = new KhenThuongInfo();
            hd.MaKhenThuong = Convert.ToInt32(txtMa.Text);
            hd.TenKhenThuong = txtTen.Text;
            return hd;
        }
        public bool Them(KhenThuongInfo phong)
        {
            return data.Them(phong);
        }
        public bool Xoa(KhenThuongInfo phong)
        {
            return data.Xoa(phong);
        }
        public bool Sua(KhenThuongInfo phong)
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

            KhenThuongInfo info = ListViewItemToInfo(item);
            item.Tag = info;
            return item;
        }
        public void LayLenListView(ListView list)
        {
            list.Items.Clear();
            KhenThuongData d = new KhenThuongData();
            DataTable table = d.LayDSKhenThuong();
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
            KhenThuongData data = new KhenThuongData();
            dg.DataSource = data.Tim(ma);
        }
    }
}
