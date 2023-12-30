using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using GiaoDienCuaHang.DataLayer;

namespace GiaoDienCuaHang.Controller
{
   public class TonKhoController
    {
       TonKhoData data = new TonKhoData();
       public void HienThiDataGridView(TextBox txtThang, TextBox txtNam,ComboBox cmbMSP, TextBox txtSLT, DataGridView dgv, BindingNavigator bn)
       {
           BindingSource bs = new BindingSource();
           bs.DataSource = data.LayDSTonKho();
           dgv.DataSource = bs;
           bn.BindingSource = bs;
           txtThang.DataBindings.Add("Text", bs, "THANG");
           txtNam.DataBindings.Add("Text", bs, "NAM");
           cmbMSP.DataBindings.Add("SelectedValue", bs, "MASP");
           txtSLT.DataBindings.Add("Text", bs, "SLTON");

           HangHoaController hhCtrl = new HangHoaController();
           dgv.Columns.Add(hhCtrl.LoadComboBoxColumn());
           dgv.Columns.Remove("MASP");

           hhCtrl.LoadComboBoxHangHoa(cmbMSP);
       }
       public void Update()
       {
           data.Update();
       }
    }

}
