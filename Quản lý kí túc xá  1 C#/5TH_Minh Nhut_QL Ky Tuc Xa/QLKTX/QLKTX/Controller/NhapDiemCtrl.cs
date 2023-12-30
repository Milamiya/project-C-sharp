using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DevComponents.DotNetBar.Controls;
using QLKTX.DataLayer;
using System.Windows.Forms;

namespace QLKTX.Controller
{
    public class NhapDiemCtrl
    {
        NhapDiemData data = new NhapDiemData();
        public void ThemPhieuDiem(ComboBoxEx day, ComboBoxEx namhoc,ComboBoxEx thang)
        {
            QLKTX.DataLayer.PhongData phg = new QLKTX.DataLayer.PhongData();
            DataTable table =  phg.LayDSPhong_DK_DAY(day.SelectedValue.ToString());
            foreach (DataRow r in table.Rows)
            {
                string maphg = r["MAPHG"].ToString();
                DataTable tables_Diem = data.layPhieuDiem(maphg, namhoc.SelectedValue.ToString(), thang.Text);
                if(tables_Diem.Rows.Count==0)
                    data.ThemPhieuDiem(maphg, namhoc.SelectedValue.ToString(), thang.Text);
            }
        }
        public void LayDSPhieuDiem(DataGridViewX dt)
        {
            dt.DataSource = data.layDSPhieuDiem();
        }
        public void CapNhatDSPhieuDiem(DataGridViewX dt)
        {
            data = new NhapDiemData();
            foreach (DataGridViewRow r in dt.Rows)
            {
                data.CapNhatPhieuDiem(r.Cells["maphg"].Value.ToString(), r.Cells["manamhoc"].Value.ToString(), r.Cells["colthang"].Value.ToString(), r.Cells["coldiem"].Value.ToString());
            }
        }
        public void CapNhatDSPhieuDiemSua(DataGridViewX dt)
        {
            data.layDSPhieuDiemSua();
        }

    }
}
