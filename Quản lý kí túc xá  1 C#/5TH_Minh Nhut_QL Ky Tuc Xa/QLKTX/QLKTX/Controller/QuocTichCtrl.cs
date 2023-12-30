using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLKTX.DataLayer;
using DevComponents.DotNetBar.Controls;
using System.Data;

namespace QLKTX.Controller
{
    public class QuocTichCtrl
    {
        

        public void LayDSQuocTich(DataGridView dg)
        {
            QuocTichData data = new QuocTichData();
            dg.DataSource = data.LayDSQuocTich();            
        }
        public void Update()
        {
            QuocTichData data = new QuocTichData();
            data.Update();
        }
        public void LayComboboxQuocTich(ComboBoxEx cmb)
        {
            QuocTichData data = new QuocTichData();
            cmb.DataSource = data.LayDSQuocTich();
            cmb.DisplayMember = "TENQUOCTICH";
            cmb.ValueMember = "MAQUOCTICH";
            
        }
        public int LayMaMax() 
        {   QLKTX.DataLayer.QuocTichData data=new QuocTichData();            
            DataTable table = data.LayMaMax();
            
            try{
                int i=Convert.ToInt32(table.Rows[0][0].ToString());
                return ++i;
            }
            catch(Exception e)
            {
                e.ToString();
                return 1;
            }
            
        }
        public void Them(QLKTX.BusinessObject.QuocTichInfo i)
        {
            QuocTichData data = new QuocTichData();
            data.Them(i);
        }
        public void Xoa(QLKTX.BusinessObject.QuocTichInfo i)
        {
            QuocTichData data = new QuocTichData();
            data.Xoa(i);
        }
        public void Sua(QLKTX.BusinessObject.QuocTichInfo i)
        {
            QuocTichData data = new QuocTichData();
            data.Sua(i);
        }
        public bool KiemTra(TextBox ma, TextBox ten)
        {
            if (ma.Text == "")
            {
                MessageBox.Show("Chưa nhập Mã số!", "Quốc tịch", MessageBoxButtons.OK);
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
                    MessageBox.Show("Mã số không được nhập kí tự!", "Quốc tịch", MessageBoxButtons.OK);
                    ma.Focus();
                    return false;
                }
            }
            if (ten.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên!", "Quốc tịch", MessageBoxButtons.OK);
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
