using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLKTX.DataLayer;
using QLKTX.BusinessObject;
namespace QLKTX.Controller
{
    public class TrangThaiPhongCtrl
    {
        TrangThaiPhongData data = new TrangThaiPhongData();
        public void LayDuLieuLenDataGridViewComboBoxColumn(DataGridViewComboBoxColumn com)
        {
            TrangThaiPhongData data = new TrangThaiPhongData();
            com.DataSource = data.LayDSTinhTrangPhong();
            com.DisplayMember = "TENTRANGTHAI";
            com.ValueMember="MATRANGTHAI";
            com.DataPropertyName="TRANGTHAI";
            com.HeaderText = "Trạng Thái";
        }
        public void LayDuLieuLenComboBox(ComboBox com)
        {
            TrangThaiPhongData data = new TrangThaiPhongData();
            com.DataSource = data.LayDSTinhTrangPhong();
            com.DisplayMember = "TENTRANGTHAI";
            com.ValueMember = "MATRANGTHAI";
                        
        }
        public TrangThaiPhongInfo ListViewItemToInfo(ListViewItem item)
        {
            TrangThaiPhongInfo ttp = new TrangThaiPhongInfo();
            ttp.MaTrangThai = Convert.ToInt32(item.Text);
            ttp.TenTrangThai = item.SubItems[1].Text;
            return ttp;
        }
        /// <summary>
        /// Hiển Thi Danh sách lên TextBox từ ListView
        /// </summary>
        /// <param name="list">ListView chứa danh sách</param>
        /// <param name="txtMa">TextBox chứa mã</param>
        /// <param name="txtTen">TextBox chứa tên</param>
        public void ListViewToControl(ListView list, TextBox txtMa,TextBox txtTen)
        {
            if (list.SelectedItems.Count > 0)
            {
                ListViewItem item = list.SelectedItems[0];
                txtMa.Text = item.Text;
                txtTen.Text = item.SubItems[1].Text;
            }
        }
        public TrangThaiPhongInfo ControlToInfo(TextBox txtMa,TextBox txtTen)
        {
            TrangThaiPhongInfo ttp = new TrangThaiPhongInfo();            
            ttp.MaTrangThai = Convert.ToInt32(txtMa.Text);
            ttp.TenTrangThai = txtTen.Text;
            return ttp;
        }
        public bool Them(TrangThaiPhongInfo phong)
        {
            return data.Them(phong);
        }
        public bool Xoa(TrangThaiPhongInfo phong)
        {
            return data.Xoa(phong);
        }
        public bool Sua(TrangThaiPhongInfo phong)
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
            item.Text = row["MATRANGTHAI"].ToString();
            item.SubItems.Add(row["TENTRANGTHAI"].ToString());
            
            TrangThaiPhongInfo info = ListViewItemToInfo(item);
            item.Tag = info;
            return item;
        }
        public void LayLenListView(ListView list)
        {
            list.Items.Clear();
            TrangThaiPhongData d = new TrangThaiPhongData();
            DataTable table = d.LayDSTinhTrangPhong();
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
    }
}
