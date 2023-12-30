using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLKTX.DataLayer;
using QLKTX.BusinessObject;
using DevComponents.DotNetBar.Controls;

namespace QLKTX.Controller
{
    public class HocKiCtrl
    {
        HocKiData Data = new HocKiData();
        public HocKiCtrl()
        {
        }
        
        public void HienThi(DataGridView dg, BindingNavigator bn, TextBox ma,TextBox ten,ComboBox nam)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = Data.LayDSHocKi();
            bn.BindingSource = bs;
            dg.DataSource = bs;
            if (ma.DataBindings.Count > 0)
            {
                ma.DataBindings.RemoveAt(0);
                ten.DataBindings.RemoveAt(0);
                nam.DataBindings.RemoveAt(0);
            }

            NamHocCtrl ctrlnam = new NamHocCtrl();
            dg.Columns.Add(ctrlnam.ColumnNamHoc());
            dg.Columns.RemoveAt(2);


            ma.DataBindings.Add("Text", bs, "MAHOCKI");
            ten.DataBindings.Add("Text", bs, "TENHOCKI");
            
            NamHocData dataNam = new NamHocData();

            nam.DataSource = dataNam.LayDSNamHoc();
            nam.DisplayMember = "TENNAMHOC";
            nam.ValueMember = "MANAMHOC";

            nam.DataBindings.Add("SelectedValue", bs, "MANAM");

        }
        public void LayDSHocKiLenComboBox(ComboBoxEx cmb)
        {
            HocKiData hocki = new HocKiData();
            cmb.DataSource = hocki.LayDSHocKi();
            cmb.DisplayMember = "TENHOCKI";
            cmb.ValueMember = "MAHOCKI";
        }
        public void LayDSHocKiLenComboBox_DK_NamHoc(ComboBoxEx cmb,string MaNamHoc )
        {
            HocKiData hocki = new HocKiData();
            cmb.DataSource = hocki.LayDSHocKi_DK_NamHoc(MaNamHoc);
            cmb.DisplayMember = "TENHOCKI";
            cmb.ValueMember = "MAHOCKI";
        }
        public void Update()
        {
            Data.Update();
        }

        public int GetMaSo(DataGridView grid)
        {
            HocKiData Dat = new HocKiData();
            int i = Dat.GetMaxMaSo();
            int j = MaxMaSoInGridView(grid);
            if (i < j)
            {
                return ++j;
            }
            else
            {
                return ++i;
            }
           
        }
        private int MaxMaSoInGridView(DataGridView grid)
        {
            int max = 0;
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                if (grid.Rows[i].Cells.Count > 0)
                {
                    try
                    {
                        if (max < Convert.ToInt32(grid.Rows[i].Cells[0].Value.ToString()))
                            max = Convert.ToInt32(grid.Rows[i].Cells[0].Value.ToString());
                    }
                    catch (Exception e)
                    {
                        e.ToString();
                    }
                }
            }
            return max;
        }

    }
}
