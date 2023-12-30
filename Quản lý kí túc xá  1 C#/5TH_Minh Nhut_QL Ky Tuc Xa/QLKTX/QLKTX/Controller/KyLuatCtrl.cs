using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLKTX.DataLayer;
using DevComponents.DotNetBar.Controls;
using System.Data;

namespace QLKTX.Controller
{
    public class KyLuatCtrl
    {
        

        public void LayDSKyLuat(DataGridView dg)
        {
            KyLuatData data = new KyLuatData();
            dg.DataSource = data.LayDSKyLuat();
        }
        public void Update()
        {
            KyLuatData data = new KyLuatData();
            data.Update();
        }
        public void LayComboboxKyLuat(ComboBoxEx cmb)
        {
            KyLuatData data = new KyLuatData();
            cmb.DataSource = data.LayDSKyLuat();
            cmb.DisplayMember = "TENKyLuat";
            cmb.ValueMember = "MAKyLuat";

        }
        public int LayMaMax()
        {
            QLKTX.DataLayer.KyLuatData data = new KyLuatData();
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
        public void Them(QLKTX.BusinessObject.KyLuatInfo info)
        {
            KyLuatData data = new KyLuatData();
            data.Them(info);
        }
        public void Xoa(QLKTX.BusinessObject.KyLuatInfo info)
        {
            KyLuatData data = new KyLuatData();
            data.Xoa(info);
        }
        public void Sua(QLKTX.BusinessObject.KyLuatInfo info)
        {
            KyLuatData data = new KyLuatData();
            data.Sua(info);
        }
        public bool KiemTra(TextBox ma, TextBox ten)
        {
            if (ma.Text == "")
            {
                MessageBox.Show("Chưa nhập Mã số!", "Tôn giáo", MessageBoxButtons.OK);
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
                    MessageBox.Show("Mã số không được nhập kí tự!", "Tôn giáo", MessageBoxButtons.OK);
                    ma.Focus();
                    return false;
                }
            }
            if (ten.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên!", "Tôn giáo", MessageBoxButtons.OK);
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
