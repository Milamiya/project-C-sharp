using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLKTX.DataLayer;
using DevComponents.DotNetBar.Controls;
using System.Data;

namespace QLKTX.Controller
{
    public class TonGiaoCtrl
    {
        

        public void LayDSTonGiao(DataGridView dg)
        {
            TonGiaoData data = new TonGiaoData();
            dg.DataSource = data.LayDSTonGiao();
        }
        public void Update()
        {
            TonGiaoData data = new TonGiaoData();
            data.Update();
        }
        public void LayComboboxTonGiao(ComboBoxEx cmb)
        {
            TonGiaoData data = new TonGiaoData();
            cmb.DataSource = data.LayDSTonGiao();
            cmb.DisplayMember = "TENTONGIAO";
            cmb.ValueMember = "MATONGIAO";

        }
        public int LayMaMax()
        {
            QLKTX.DataLayer.TonGiaoData data = new TonGiaoData();
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
        public void Them(QLKTX.BusinessObject.TonGiaoInfo info)
        {
            TonGiaoData data = new TonGiaoData();
            data.Them(info);
        }
        public void Xoa(QLKTX.BusinessObject.TonGiaoInfo info)
        {
            TonGiaoData data = new TonGiaoData();
            data.Xoa(info);
        }
        public void Sua(QLKTX.BusinessObject.TonGiaoInfo info)
        {
            TonGiaoData data = new TonGiaoData();
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
