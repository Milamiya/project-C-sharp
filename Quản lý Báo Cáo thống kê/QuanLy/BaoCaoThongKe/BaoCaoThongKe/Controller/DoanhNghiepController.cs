using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors;
using DevComponents.DotNetBar.Controls;
using BaoCaoThongKe.DataLayer;

namespace BaoCaoThongKe.Controller
{
    public class DoanhNghiepController
    {
        
        DoanhNghiepData data = new DoanhNghiepData();

        public void ComboBoxDoanhNghiep(ComboBoxEx lookUpEdit5)
        {
            lookUpEdit5.DataSource = data.HienThiDoanhNghiep();
            lookUpEdit5.DisplayMember = "TenDoanhNghiep";
            lookUpEdit5.ValueMember = "MaDoanhNghiep";
        }

        public void Update()
        {
            data.Update();
        }
    }
}
