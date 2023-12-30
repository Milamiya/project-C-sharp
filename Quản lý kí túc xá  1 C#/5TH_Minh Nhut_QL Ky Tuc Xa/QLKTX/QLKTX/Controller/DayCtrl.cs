using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using System.Windows.Forms;
using QLKTX.DataLayer;
using System.Data;
using QLKTX.BusinessObject;

namespace QLKTX.Controller
{
    public class DayCtrl
    {
        DayData data = new DayData();
        /// <summary>
        /// Hiển Thị Dữ liệu lên Form
        /// </summary>
        /// <param name="da"></param>
        /// <param name="bin"></param>
        public void HienThi(DataGridViewX da, BindingNavigator bin, TextBox ma, TextBox ten, TextBox soluong, ComboBoxEx ktx, ComboBoxEx codo)
        {
            #region Bingding
            BindingSource source = new BindingSource();
            source.DataSource = data.LayDSDay();

            da.DataSource = source;
            bin.BindingSource = source;
            #endregion

           
            da.Columns.RemoveAt(3);
            da.Columns.RemoveAt(3);
           

            #region Cột Ký túc xá
            DataGridViewComboBoxColumn comKTX = new DataGridViewComboBoxColumn();
            comKTX.HeaderText = "Ký túc xá";
            comKTX.Name = "CotKTX";
            new KTXCtrl().LayDataGridViewComboBoxColumnTuDSKTX(comKTX);
            da.Columns.Add(comKTX);
            
            #endregion

            #region Cột Cờ đỏ
            DataGridViewComboBoxColumn comCoDo = new DataGridViewComboBoxColumn();
            comCoDo.HeaderText = "Cờ đỏ";
            comCoDo.Name = "CotCoDo";
            new SinhVienCtrl().LayDataGridViewComboBoxColumn_CoDo(comCoDo);
            da.Columns.Add(comCoDo);
            
            
            #endregion


            if (ktx.DataBindings.Count > 0)//Kiểm tra xem các control dá được Binding chưa
            {
                ktx.DataBindings.RemoveAt(0);
                codo.DataBindings.RemoveAt(0);
                ma.DataBindings.RemoveAt(0);
                ten.DataBindings.RemoveAt(0);
                soluong.DataBindings.RemoveAt(0);
            }
            

            new KTXCtrl().LayDSKTXLenComboBox(ktx);
            ktx.DataBindings.Add("SelectedValue", source, "KTX");

            new SinhVienCtrl().LayDSSinhVienLenComboBox(codo);
            codo.DataBindings.Add("SelectedValue", source, "MACODO");

            ma.DataBindings.Add("Text", source, "MADAY");
            ten.DataBindings.Add("Text", source, "TENDAY");
            soluong.DataBindings.Add("Text", source, "SOLUONGPHG");
        }
        public bool Sua(DayInfo day)
        {
            return data.Sua(day);            
        }
        public bool Them(DayInfo day)
        {
            return data.Them(day);            
        }
        public bool Xoa(DayInfo day)
        {
            return data.Xoa(day);
            

        }

        public DayInfo DuLieuToDay(TextBox ma, TextBox ten, TextBox soluong, ComboBoxEx cmbKTX, ComboBoxEx cmbCoDo)
        {
            DayInfo day = new DayInfo();
            day.MaDay = ma.Text;
            day.TenDay = ten.Text;
            day.SoLuongPhong = Convert.ToInt32(soluong.Text);

            SinhVienInfo codo = new SinhVienInfo();
            codo.MaKTX = (cmbCoDo.SelectedValue==null?"":cmbCoDo.SelectedValue.ToString());
            codo.HoTen = (cmbCoDo.Text==null?"":cmbCoDo.Text);

            KTXInfo ktx = new KTXInfo();
            ktx.MaKTX = cmbKTX.SelectedValue.ToString();
            ktx.TenKTX = cmbKTX.Text;

            day.KTX = ktx;
            day.CoDo = codo;
            return day;
        }

        public void LayDuLieuLenComboBox(ComboBox com)
        {
            DayData day=new DayData();
            com.DataSource = day.LayDSDay();
            com.DisplayMember = "TENDAY";
            com.ValueMember = "MADAY";
        }
        public void LayDuLieuLenComboBoxItem(ComboBoxItem cmb)
        {
            DayData hd = new DayData();
            DataTable table = hd.LayDSDay();
            foreach (DataRow row in table.Rows)
                cmb.Items.Add(row["TenDay"]);
            //cmb.DisplayMember = "TENPHG";
            //cmb.ValueMember = "MAPHG";

        }      
        public void LayDuLieuLenComboBox_DK_KTX(ComboBox com,string maktx)
        {
            DayData day = new DayData();
            com.DataSource = day.LayDSDay_DK_KTX(maktx);
            com.DisplayMember = "TENDAY";
            com.ValueMember = "MADAY";
        }
        public void LayDuLieuLenDataGridViewComboBoxColumn(DataGridViewComboBoxColumn col)
        {
            DayData day = new DayData();
            col.DataSource = day.LayDSDay();
            col.DisplayMember = "TENDAY";
            col.ValueMember = "MADAY";
            col.DataPropertyName = "MADAY";
            col.HeaderText = "Dãy";
        }
        public bool KiemTra(TextBox ma, TextBox ten, TextBox soluong, ComboBoxEx cmbKTX, ComboBoxEx cmbCoDo)
        {
            if (ma.Text == "")
            {
                MessageBox.Show("Chưa nhập Mã số!", "Dãy", MessageBoxButtons.OK);
                ma.Focus();
                return false;
            }
            else
            {
                if (ma.Text.Length > 4)
                {
                    MessageBox.Show("Mã số không quá 4 kí tự!", "Dãy", MessageBoxButtons.OK);
                    ma.Focus();
                    return false;
                }
            }
            if (ten.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên!", "Dãy", MessageBoxButtons.OK);
                ten.Focus();
                return false;
            }
            else
            {
                if (ma.Text.Length > 30)
                {
                    MessageBox.Show("Tên không quá 30 kí tự!", "Dãy", MessageBoxButtons.OK);
                    ma.Focus();
                    return false;
                }
            }
            if (soluong.Text == "")
            {
                MessageBox.Show("Chưa nhập Số lượng Phòng!", "Dãy", MessageBoxButtons.OK);
                soluong.Focus();
                return false;
            }
            else
            {
                try
                {
                    int.Parse(soluong.Text);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Số lượng Phòng không thể nhập kí tự!", "Dãy", MessageBoxButtons.OK);
                    soluong.Focus();
                    return false;
                }
            }
            if (cmbKTX.SelectedValue == null)
            {
                MessageBox.Show("Chưa chọn KTX!", "Dãy", MessageBoxButtons.OK);
                ten.Focus();
                return false;
            }
            if (cmbCoDo.SelectedValue == null)
            {
                MessageBox.Show("Chưa chọn Cờ Đỏ cho dãy!", "Dãy", MessageBoxButtons.OK);
                
            }
            return true;
        }
    }
}

