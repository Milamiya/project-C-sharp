using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLKTX.DataLayer;

namespace QLKTX.Controller
{    
    public class CanBoCtrl
    {
        CanBoData Data = new CanBoData();
        public CanBoCtrl()
        {
        }
        public void LayDSCanBoQuanLy(DataGridView dg)
        {   
            dg.DataSource = Data.LayDSCanBo();
        }
        public void Update()
        {
            Data.Update();
        }
        public int LayMaMax()
        {
            QLKTX.DataLayer.CanBoData data = new CanBoData();
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
        public void Them(QLKTX.BusinessObject.CanBoInfo info)
        {
            CanBoData data = new CanBoData();
            data.Them(info);
        }
        public void Xoa(QLKTX.BusinessObject.CanBoInfo info)
        {
            CanBoData data = new CanBoData();
            data.Xoa(info);
        }
        public void Sua(QLKTX.BusinessObject.CanBoInfo info)
        {
            CanBoData data = new CanBoData();
            data.Sua(info);
        }
        public bool KiemTra(TextBox ma,TextBox ten, TextBox diachi)
        {
            if (ma.Text == "")
            {
                MessageBox.Show("Chưa nhập Mã số!", "Cán Bộ", MessageBoxButtons.OK);
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
                    MessageBox.Show("Mã số không được nhập kí tự!", "Cán Bộ", MessageBoxButtons.OK);
                    ma.Focus();
                    return false;
                }
            }
            if (ten.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên!", "Cán Bộ", MessageBoxButtons.OK);
                ten.Focus();
                return false;
            }
            else
            {
                if (ten.Text.Length > 30)
                {
                    MessageBox.Show("Tên không quá 30 kí tự!", "Cán Bộ", MessageBoxButtons.OK);
                    ten.Focus();
                    return false;
                }
            }
            if (diachi.Text == "")
            {
                MessageBox.Show("Chưa nhập Địa chỉ!", "Cán Bộ", MessageBoxButtons.OK);
                diachi.Focus();
                return false;
            }
            else
            {
                if (diachi.Text.Length > 100)
                {
                    MessageBox.Show("Tên không quá 100 kí tự!", "Cán Bộ", MessageBoxButtons.OK);
                    diachi.Focus();
                    return false;
                }
            }
            return true;
        }
        public void LayDuLieuLenComboBox(ComboBox com)
        {
            CanBoData data = new CanBoData();
            com.DataSource = data.LayDSCanBo();
            com.DisplayMember = "TENCBQL";
            com.ValueMember = "MACBQL";

        }
    }
}
