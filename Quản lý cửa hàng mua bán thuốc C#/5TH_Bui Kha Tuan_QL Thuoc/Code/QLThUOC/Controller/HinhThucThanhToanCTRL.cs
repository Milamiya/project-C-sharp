using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLThUOC.DataLayer;

namespace QLThUOC.Controller
{
    public class HinhThucThanhToanCTRL
    {
        HinhThucThanhToanDATA data = new HinhThucThanhToanDATA();
        public void HienThiHinhThucThanhToan(TextBox txtMaHT,TextBox txtTenHT,DataGridView dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.LayDSHinhThucThanhToan();
            dg.DataSource = bs;
            bn.BindingSource = bs;
            txtMaHT.DataBindings.Add("Text", bs, "MAHT");
            txtTenHT.DataBindings.Add("Text", bs, "TENHT");
        }
        public void Update()
        {
            data.Update();
        }
    }
}
