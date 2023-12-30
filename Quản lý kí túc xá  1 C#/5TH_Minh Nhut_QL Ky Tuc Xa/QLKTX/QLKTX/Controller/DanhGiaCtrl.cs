using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLKTX.DataLayer;
using DevComponents.DotNetBar.Controls;
using System.Data;

namespace QLKTX.Controller
{
    public class DanhGiaCtrl
    {
        

        public void LayDSDanhGia(DataGridView dg)
        {
            DanhGiaData data = new DanhGiaData();
            dg.DataSource = data.LayDSDanhGia();
        }
        public void Update()
        {
            DanhGiaData data = new DanhGiaData();
            data.Update();
        }
        public void LayComboboxDanhGia(ComboBoxEx cmb)
        {
            DanhGiaData data = new DanhGiaData();
            cmb.DataSource = data.LayDSDanhGia();
            cmb.DisplayMember = "TENDanhGia";
            cmb.ValueMember = "MADanhGia";

        }
        public int LayMaMax()
        {
            QLKTX.DataLayer.DanhGiaData data = new DanhGiaData();
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
        public void Them(QLKTX.BusinessObject.DanhGiaInfo info)
        {
            DanhGiaData data = new DanhGiaData();
            data.Them(info);
        }
        public void Xoa(QLKTX.BusinessObject.DanhGiaInfo info)
        {
            DanhGiaData data = new DanhGiaData();
            data.Xoa(info);
        }
        public void Sua(QLKTX.BusinessObject.DanhGiaInfo info)
        {
            DanhGiaData data = new DanhGiaData();
            data.Sua(info);
        }
        public bool KiemTra(TextBox ma, TextBox ten)
        {
            if (ma.Text == "")
            {
                MessageBox.Show("Chưa nhập Mã số!", "Đánh Giá", MessageBoxButtons.OK);
                ma.Focus();
                return false;
            }
            else
            {

                int i = 0;
                try
                {
                    i = Convert.ToInt32(ma.Text);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Mã số không được nhập kí tự!", "Đánh Giá", MessageBoxButtons.OK);
                    ma.Focus();
                    return false;
                }
            }
            if (ten.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên!", "Đánh Giá", MessageBoxButtons.OK);
                ten.Focus();
                return false;
            }
            else
            {
                if (ten.Text.Length > 30)
                {
                    MessageBox.Show("Tên không quá 30 kí tự!", "Quốc tịch", MessageBoxButtons.OK);
                    ten.Focus();
                    return false;
                }
            }
            return true;
        }
    }
}
