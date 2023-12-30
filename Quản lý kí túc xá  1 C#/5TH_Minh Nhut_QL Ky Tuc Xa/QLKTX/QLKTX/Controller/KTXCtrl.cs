using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;

namespace QLKTX.Controller
{
    public class KTXCtrl
    {
        QLKTX.DataLayer.KTXData data = new QLKTX.DataLayer.KTXData();

        /// <summary>
        /// Lấy dữ liệu đưa vào ComboBoxEX
        /// </summary>        
        public void LayDataGridViewComboBoxColumnTuDSKTX(DataGridViewComboBoxColumn com)
        {
            com.DataSource = data.LayDSKTX();
            com.DisplayMember = "TENKTX";
            com.ValueMember = "KTX";
            com.DataPropertyName = "KTX";
        }
        public void LayDSKTXLenComboBox(ComboBoxEx com)
        {
            com.DataSource = data.LayDSKTX();
            com.DisplayMember = "TENKTX";
            com.ValueMember = "KTX";
        }
        /// <summary>
        /// Hiển thi nội dung của KTX lên From
        /// </summary>
        /// <param name="da">Lưới dữ liệu</param>
        /// <param name="bin">Thanh công cụ</param>
        /// <param name="ma">TextBox Mã số</param>
        /// <param name="ten">TextBox Tên</param>
        public void HienThi(DataGridView da, BindingNavigator bin, TextBox ma, TextBox ten, TextBox soday)
        {
            BindingSource source = new BindingSource();
            source.DataSource = data.LayDSKTX();
            da.DataSource = source;
            bin.BindingSource = source;
            if (ten.DataBindings.Count > 0)
            {
                ten.DataBindings.RemoveAt(0);
                ma.DataBindings.RemoveAt(0);
                soday.DataBindings.RemoveAt(0);
            }
            ten.DataBindings.Add("Text", source, "TENKTX");
            ma.DataBindings.Add("Text", source, "KTX");
            soday.DataBindings.Add("Text", source, "SOLUONGDAY");
        }
        /// <summary>
        /// Thêm KTX vào CSDL
        /// </summary>
        /// <param name="ktx">KTX cần thêm</param>
        public void Them(QLKTX.BusinessObject.KTXInfo ktx)
        {
            data.Them(ktx);
        }
        /// <summary>
        /// Xóa KTX ra khỏi CSDL
        /// </summary>
        /// <param name="ktx">KTX cần xóa</param>
        public void Xoa(QLKTX.BusinessObject.KTXInfo ktx)
        {
            data.Xoa(ktx);
        }
        /// <summary>
        /// Sửa Thông tin  KTX ra khỏi CSDL
        /// </summary>
        /// <param name="ktx">KTX cần Sửa</param>
        public void Sua(QLKTX.BusinessObject.KTXInfo ktx)
        {
            data.Sua(ktx);
        }
        public bool KiemTra(TextBox ma, TextBox ten,TextBox soluong)
        {
            if (ma.Text == "")
            {
                MessageBox.Show("Chưa nhập Mã số!", "Dân tộc", MessageBoxButtons.OK);
                ma.Focus();
                return false;
            }
            else
            {
                if (ma.Text.Length > 4)
                {
                    MessageBox.Show("Mã số không quá 4 kí tự!", "Kí túc xá", MessageBoxButtons.OK);
                    ma.Focus();
                    return false;
                }
            }
            if (ten.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên!", "Kí túc xá", MessageBoxButtons.OK);
                ten.Focus();
                return false;
            }
            else
            {
                if (ten.Text.Length > 30)
                {
                    MessageBox.Show("Tên không quá 30 kí tự!", "Kí túc xá", MessageBoxButtons.OK);
                    ten.Focus();
                    return false;
                }
            }
            if (soluong.Text == "")
            {
                MessageBox.Show("Chưa nhập số lượng Dãy!", "Kí túc xá", MessageBoxButtons.OK);
                soluong.Focus();
                return false;
            }
            else
            {
                int i = 0;
                try
                {
                    i = Convert.ToInt32(soluong.Text);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Số lượng không được nhập kí tự!", "Kí túc xá", MessageBoxButtons.OK);
                    soluong.Focus();
                    return false;
                }
            }
            return true;
        }
            
    }
}
