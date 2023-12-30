using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    class KhoCTRL
    {
        KhoDATA data = new KhoDATA();
        public void HienThiKho(TextBox txtMaKho,TextBox txtTenKho, TextBox txtDiaDiem,DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.LayDSKho();
            dg.DataSource = bs;
            bn.BindingSource = bs;
            txtMaKho.DataBindings.Add("Text", bs, "MAKHO");
            txtTenKho.DataBindings.Add("Text", bs, "TENKHO");
            txtDiaDiem.DataBindings.Add("Text", bs, "DIADIEM");


        }
        public void Update()
        {
            data.Update();
        }
    }
}
