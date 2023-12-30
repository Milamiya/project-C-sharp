using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLKTX.DataLayer;
using DevComponents.DotNetBar.Controls;
using System.Data;

namespace QLKTX.Controller
{
    public class DanTocCtrl
    {
        DanTocData data = new DanTocData();

        public void LayDSDanToc(DataGridView dg)
        {
            dg.DataSource = data.LayDSDanToc();
        }
        public void Update()
        {
            data.Update();
        }
        public void LayComboboxDanToc(ComboBoxEx cmb)
        {

            cmb.DataSource = data.LayDSDanToc();
            cmb.DisplayMember = "TENDANTOC";
            cmb.ValueMember = "MADANTOC";

        }
        public int LayMaMax()
        {
            QLKTX.DataLayer.DanTocData data = new DanTocData();
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
        public void Them(QLKTX.BusinessObject.DanTocInfo info)
        {
            data.Them(info);
        }
        public void Xoa(QLKTX.BusinessObject.DanTocInfo info)
        {
            data.Xoa(info);
        }
        public void Sua(QLKTX.BusinessObject.DanTocInfo info)
        {
            data.Sua(info);
        }
        public bool KiemTra(TextBox ma, TextBox ten)
        {
            if (ma.Text == "")
            {
                MessageBox.Show("Chưa nhập Mã số!", "Dân tộc", MessageBoxButtons.OK);
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
                    MessageBox.Show("Mã số không được nhập kí tự!", "Dân tộc", MessageBoxButtons.OK);
                    ma.Focus();
                    return false;
                }
            }
            if (ten.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên!", "Dân tộc", MessageBoxButtons.OK);
                ten.Focus();
                return false;
            }
            else
            {
                if (ten.Text.Length > 30)
                {
                    MessageBox.Show("Tên không quá 30 kí tự!", "Dân tộc", MessageBoxButtons.OK);
                    ten.Focus();
                    return false;
                }
            }
            return true;
        }

    }
}
