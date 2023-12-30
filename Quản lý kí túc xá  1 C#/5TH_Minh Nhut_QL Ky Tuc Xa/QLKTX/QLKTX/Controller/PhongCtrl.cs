using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLKTX.DataLayer;
using QLKTX.BusinessObject;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;

namespace QLKTX.Controller
{
    public class PhongCtrl
    {
        public void HienThi(ListView list, ComboBox day, ComboBox trangthai)
        {
            PhongData phong=new PhongData();
            list.Items.Clear();
            DataTable table = phong.LayDSPhong();
            foreach (DataRow row in table.Rows)
            {
                PhongInfo info = RowToInfo(row);
                ListViewItem item = new ListViewItem();
                item.Text = info.MaPhong;
                item.SubItems.Add(info.TenPhong);
                item.SubItems.Add(info.Day.TenDay);
                item.SubItems.Add(info.SoLuongToiDa.ToString());
                item.SubItems.Add(info.TrangThai.TenTrangThai);
                item.SubItems.Add((info.PhongNam==true?"Nam":"Nữ"));
                item.Tag = info;
                list.Items.Add(item);
            }
            
             //----------------
            DayCtrl dayctrl=new DayCtrl();
            dayctrl.LayDuLieuLenComboBox(day);
            TrangThaiPhongCtrl dayctrl1 = new TrangThaiPhongCtrl();
            dayctrl1.LayDuLieuLenComboBox(trangthai);
            
        }
        public void RowToControl(ListView list, TextBox ma, TextBox ten, TextBox Sl, CheckBoxX phgNam, ComboBox day, ComboBox trangthai)
        {
            if (list.SelectedItems.Count > 0)
            {
                PhongInfo phong = (PhongInfo)list.SelectedItems[0].Tag;
                ma.Text = phong.MaPhong;
                ten.Text = phong.TenPhong;
                Sl.Text = phong.SoLuongToiDa.ToString();
                phgNam.Checked = phong.PhongNam;
                day.Text = phong.Day.TenDay;
                trangthai.Text = phong.TrangThai.TenTrangThai;
            }

        }
        public PhongInfo ControlToInfo(TextBox ma, TextBox ten, TextBox Sl, CheckBoxX phgNam, ComboBox day, ComboBox trangthai)
        {
            PhongInfo phong=new PhongInfo();
            phong.MaPhong = ma.Text;
            phong.TenPhong = ten.Text;
            phong.SoLuongToiDa=Convert.ToInt32(Sl.Text);
            phong.PhongNam = phgNam.Checked;
            
            DayInfo d=new DayInfo();
            d.MaDay=day.SelectedValue.ToString();
            d.TenDay=day.Text;
            phong.Day=d;

            TrangThaiPhongInfo th=new TrangThaiPhongInfo();
            th.MaTrangThai=Convert.ToInt32(trangthai.SelectedValue.ToString());
            th.TenTrangThai =trangthai.Text;

            phong.TrangThai = th;

            return phong;

        }
        public PhongInfo RowToInfo(DataRow row)
        {
            PhongInfo phong = new PhongInfo();

            phong.MaPhong = row["MAPHG"].ToString();

            phong.TenPhong = row["TENPHG"].ToString();
            
            phong.SoLuongToiDa = Convert.ToInt32(row["SOLUONGTOIDA"].ToString());
            
            phong.PhongNam = Convert.ToBoolean(row["PhongNam"].ToString());
            
            DayInfo day = new DayInfo();               
            day.MaDay = row["MADAY"].ToString();
            day.TenDay = row["TENDAY"].ToString();
            
            phong.Day = day;
            TrangThaiPhongInfo trangthai = new TrangThaiPhongInfo();
            
            trangthai.MaTrangThai = Convert.ToInt32(row["MATRANGTHAI"].ToString());
            trangthai.TenTrangThai = row["TENTRANGTHAI"].ToString();
            
            phong.TrangThai = trangthai;

            return phong;
            
        }
        public ListViewItem InfoToItem(PhongInfo phong)
        {
            ListViewItem item = new ListViewItem();
            item.Text = phong.MaPhong;
            item.SubItems.Add(phong.TenPhong);
            item.SubItems.Add(phong.Day.TenDay);
            item.SubItems.Add(phong.SoLuongToiDa.ToString());
            item.SubItems.Add(phong.TrangThai.TenTrangThai);
            item.SubItems.Add((phong.PhongNam == true ? "Nam" : "Nữ"));
            item.Tag = phong;
            return item;

        }
        /// <summary>
        /// Sửa một dòng trên LISTVIEW có cùng Mã với phòng vừa sửa
        /// </summary>
        /// <param name="list">Listview cần sửa</param>
        /// <param name="phong">Phòng có khóa cần sửa</param>
        public void SuaListView(ListView list, PhongInfo phong)
        {
            ListViewItem itemPhong = InfoToItem(phong);
            for(int i=0;i<list.Items.Count;i++)
            {
                if (list.Items[i].Text == itemPhong.Text)
                {
                    //Thay đổi nội dung từng ô một trên dòng cần sửa
                    for (int j = 1; j < list.Items[i].SubItems.Count; j++)
                    {
                        list.Items[i].SubItems[j] = itemPhong.SubItems[j];
                    }
                }
            }
        }

        public bool KiemTra(TextBox ma, TextBox ten, TextBox Sl, CheckBoxX phgNam, ComboBox day, ComboBox trangthai)
        {
            #region Kiểm tra Mã Phòng
            if (ma.Text == "")
            {
                MessageBox.Show("Chưa nhập Mã Phòng!", "Phòng");
                ma.Focus();
                return false;
            }
            else
            {
                if (ma.Text.Length > 4)
                {
                    MessageBox.Show("Mã Phòng không thể lớn hơn 4 kí tự!", "Phòng");
                    ma.Focus();
                    return false;
                }
            } 
            #endregion
            #region Kiểm tra Tên Phòng
            if (ten.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên Phòng!", "Phòng");
                ten.Focus();
                return false;
            }
            else
            {
                if (ten.Text.Length > 30)
                {
                    MessageBox.Show("Tên Phòng không thể lớn hơn 30 kí tự!", "Phòng");
                    ten.Focus();
                    return false;
                }
            } 
            #endregion
            #region Kiểm tra Số Lượng Sinh viên tối đa trong phòng
            if (Sl.Text == "")
            {
                MessageBox.Show("Chưa nhập Số lượng Sinh viên tối đa của Phòng!", "Phòng");
                Sl.Focus();
                return false;
            }
            else
            {
                int i=-1;
                try
                {
                    i = Convert.ToInt32(Sl.Text);
                }
                catch (Exception e) { }
                if (i>8 || i<1)
                {
                    MessageBox.Show("Số lượng Sinh viên trong phòng phải từ 1 đến 8!", "Phòng");
                    Sl.Focus();
                    return false;
                }
            } 
            #endregion
            #region Kiểm Tra Dãy của phòng được thêm
            if (day.Text == "")
            {
                MessageBox.Show("Chưa chọn dãy của Phòng!", "Phòng");
                day.Focus();
                return false;
            }
            else
            {

                if (day.SelectedValue==null)
                {
                    MessageBox.Show("Dãy \"" + day.Text + "\" chưa có Trong Kí túc xá!\nBạn nên tạo dãy mới (chọn nút bên cạnh) trước khi thêm phòng này.", "Phòng");
                    day.Focus();
                    return false;
                }
            } 
            #endregion
            #region Kiểm Tra Trạng thái của phòng được thêm
            if (trangthai.Text == "")
            {
                MessageBox.Show("Chưa chọn Trạng thái của Phòng!", "Phòng");
                trangthai.Focus();
                return false;
            }
            else
            {

                if (trangthai.SelectedValue == null)
                {
                    MessageBox.Show("Trạng thái \"" + trangthai.Text + "\" chưa có!\nBạn nên tạo Trạng thái phòng mới (chọn nút bên cạnh) trước khi thêm phòng này.", "Phòng");
                    trangthai.Focus();
                    return false;
                }
            }
            #endregion

            MessageBox.Show("Bạn chọn phòng này dành cho: " + (phgNam.Checked == true ? "Nam" : "Nữ"));
            return true;
        }
        public bool Them(PhongInfo phong)
        {
            PhongData data=new PhongData();
            return data.Them(phong);
        }
        public bool Xoa(PhongInfo phong)
        {
            PhongData data=new PhongData();
            return data.Xoa(phong);
        }
        public bool Sua(PhongInfo phong)
        {
            PhongData data = new PhongData();
            return data.Sua(phong);
        }
        public void LayDuLieuLenComboBox(ComboBoxEx cmb)
        {
            PhongData hd = new PhongData();
            DataTable table=hd.LayDSPhong();
            cmb.DataSource = table; 
            cmb.DisplayMember = "TENPHG";
            cmb.ValueMember = "MAPHG";
            
        }
        public void LayDuLieuLenComboBoxItem(ComboBoxItem cmb)
        {
            PhongData hd = new PhongData();
            DataTable table =hd.LayDSPhong();
            foreach (DataRow row in table.Rows)
                cmb.Items.Add(row["TenPHG"]);
            //cmb.DisplayMember = "TENPHG";
            //cmb.ValueMember = "MAPHG";

        }        
        public void LayDuLieuLenComboBox_DK_DAY(ComboBox cmb,string maday)
        {
            PhongData hd = new PhongData();
            cmb.DataSource = hd.LayDSPhong_DK_DAY(maday);
            cmb.DisplayMember = "TENPHG";
            cmb.ValueMember = "MAPHG";
            
        }
        
    }
}
