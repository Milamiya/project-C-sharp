using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Data;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class QuaTrinhKtCtr
    {
        QuaTrinhKhenThuongData data = new QuaTrinhKhenThuongData();
        public void HienthiDataGridviewTheoMaNV(DevComponents.DotNetBar.Controls.DataGridViewX dg, System.Windows.Forms.BindingNavigator bn, DevComponents.DotNetBar.Controls.ComboBoxEx hinhthuckhenthuong, DevComponents.DotNetBar.Controls.TextBoxX namkt, DevComponents.DotNetBar.Controls.ComboBoxEx lydokt, DevComponents.DotNetBar.Controls.TextBoxX capkt, string str)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            bs.DataSource = data.DanhsachQuaTrinhKT(str);
            bn.BindingSource = bs;
            dg.DataSource = bs;

            hinhthuckhenthuong.DataBindings.Clear();
            hinhthuckhenthuong.DataBindings.Add("SelectedValue", bs, "mahinhthuc");

            namkt.DataBindings.Clear();
            namkt.DataBindings.Add("text", bs, "nam");

            capkt.DataBindings.Clear();
            capkt.DataBindings.Add("text", bs, "capquyetdinh");

            lydokt.DataBindings.Clear();
            lydokt.DataBindings.Add("SelectedValue", bs, "malydo");
        }

        public DataRow NewRow()
        {
            return data.NewRow();
        }
        public void Add(DataRow row)
        {
            data.Add(row);
        }
        public bool Save()
        {
            return data.Save();
        }

    }
}
