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
    public class NguoiDungCtrl
    {
        public void HienThi(ListView list)
        {
            NguoiDungData NguoiDung=new NguoiDungData();
            list.Items.Clear();
            DataTable table = NguoiDung.LayDSNguoiDung();
            foreach (DataRow row in table.Rows)
            {
                NguoiDungInfo info = RowToInfo(row);
                ListViewItem item = new ListViewItem();
                item.Text = info.Ma.ToString();
                item.SubItems.Add(info.HoTen);
                item.SubItems.Add(info.Username);
                item.SubItems.Add(info.Password);
                item.SubItems.Add(info.Quyen.ToString());
                
                item.Tag = info;
                list.Items.Add(item);
            }
            
             //----------------
            
            
        }
        public void RowToControl(ListView list, TextBox ma, TextBox ten,TextBoxX user,TextBoxX pass,ComboBoxEx quyen)
        {
            if (list.SelectedItems.Count > 0)
            {
                NguoiDungInfo NguoiDung = (NguoiDungInfo)list.SelectedItems[0].Tag;
                ma.Text = NguoiDung.Ma.ToString(); ;
                ten.Text = NguoiDung.HoTen;
                user.Text = NguoiDung.Username;
                pass.Text= NguoiDung.Password;
                
                quyen.Text = NguoiDung.Quyen.ToString();
            }

        }
        public NguoiDungInfo ControlToInfo(TextBox ma, TextBox ten, TextBox user, TextBox pass, ComboBox quyen)
        {
            NguoiDungInfo NguoiDung=new NguoiDungInfo();
            NguoiDung.Ma =Convert.ToInt32( ma.Text);
            NguoiDung.HoTen= ten.Text;
            NguoiDung.Username = user.Text;
            NguoiDung.Password = Md5(pass.Text);
            NguoiDung.Quyen = quyen.Text.ToCharArray()[0];                       

            return NguoiDung;

        }
        public NguoiDungInfo RowToInfo(DataRow row)
        {
            NguoiDungInfo NguoiDung = new NguoiDungInfo();

            NguoiDung.Ma= Convert.ToInt32( row["MA"].ToString());

            NguoiDung.HoTen= row["HOTEN"].ToString();
            
            NguoiDung.Username= row["USER"].ToString();

            NguoiDung.Password= row["PASS"].ToString();
            NguoiDung.Quyen= row["QUYEN"].ToString().ToCharArray()[0];
            
            return NguoiDung;
            
        }
        public ListViewItem InfoToItem(NguoiDungInfo NguoiDung)
        {
            ListViewItem item = new ListViewItem();
            item.Text = NguoiDung.Ma.ToString();
            item.SubItems.Add(NguoiDung.HoTen);
            item.SubItems.Add(NguoiDung.Username);
            item.SubItems.Add(NguoiDung.Password);
            item.SubItems.Add(NguoiDung.Quyen.ToString());
            return item;

        }
        /// <summary>
        /// Sửa một dòng trên LISTVIEW có cùng Mã với phòng vừa sửa
        /// </summary>
        /// <param name="list">Listview cần sửa</param>
        /// <param name="NguoiDung">Phòng có khóa cần sửa</param>
        public void SuaListView(ListView list, NguoiDungInfo NguoiDung)
        {
            ListViewItem itemNguoiDung = InfoToItem(NguoiDung);
            for(int i=0;i<list.Items.Count;i++)
            {
                if (list.Items[i].Text == itemNguoiDung.Text)
                {
                    //Thay đổi nội dung từng ô một trên dòng cần sửa
                    for (int j = 1; j < list.Items[i].SubItems.Count; j++)
                    {
                        list.Items[i].SubItems[j] = itemNguoiDung.SubItems[j];
                    }
                }
            }
        }

        public bool KiemTra(TextBox ten, TextBox user, TextBox pass, TextBox repass, ComboBoxEx quyen)
        {   
            if (ten.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên!", "Phòng");
                ten.Focus();
                return false;
            }
            else
            {
                if (ten.Text.Length > 30)
                {
                    MessageBox.Show("Tên không thể lớn hơn 30 kí tự!", "Nguoi dung");
                    ten.Focus();
                    return false;
                }
            }
            if (pass.Text != "")
            {
                if (pass.Text != repass.Text)
                {
                    MessageBox.Show("password không khớp", "Nguoi dung");
                    pass.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập password", "Nguoi dung");
                pass.Focus();
                return false;
            }
            return true;
        }
        public bool Them(NguoiDungInfo NguoiDung)
        {
            NguoiDungData data=new NguoiDungData();
            return data.Them(NguoiDung);
        }
        public bool Xoa(NguoiDungInfo NguoiDung)
        {
            NguoiDungData data=new NguoiDungData();
            return data.Xoa(NguoiDung);
        }
        public bool Sua(NguoiDungInfo NguoiDung)
        {
            NguoiDungData data = new NguoiDungData();
            return data.Sua(NguoiDung);
        }
        public void LayDuLieuLenComboBox(ComboBoxEx cmb)
        {
            NguoiDungData hd = new NguoiDungData();
            DataTable table=hd.LayDSNguoiDung();
            cmb.DataSource = table; 
            cmb.DisplayMember = "TENPHG";
            cmb.ValueMember = "MAPHG";
            
        }
        public void LayDuLieuLenComboBoxItem(ComboBoxItem cmb)
        {
            NguoiDungData hd = new NguoiDungData();
            DataTable table =hd.LayDSNguoiDung();
            foreach (DataRow row in table.Rows)
                cmb.Items.Add(row["TenPHG"]);
            //cmb.DisplayMember = "TENPHG";
            //cmb.ValueMember = "MAPHG";

        }        
        public void LayDuLieuLenComboBox_DK_DAY(ComboBox cmb,string maday)
        {
            NguoiDungData hd = new NguoiDungData();
            cmb.DataSource = hd.LayDSNguoiDung_DK_DAY(maday);
            cmb.DisplayMember = "TENPHG";
            cmb.ValueMember = "MAPHG";
            
        }

        public int LayMaMax()
        {
            NguoiDungData data = new NguoiDungData();
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
        public string Md5(string str)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            string pass = "";
            byte[] m_byte = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            foreach (byte b in m_byte)
            {
                pass = pass + b.ToString("X");
            }
            return pass;
        }
    }
}
