using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DevComponents.DotNetBar.Controls;
using QLKTX.DataLayer;
using System.Windows.Forms;

namespace QLKTX.Controller
{
    public class NhapKWDienCtrl
    {
        NhapKWDienData data = new NhapKWDienData();
        public void ThemPhieuKWDien(ComboBoxEx day, ComboBoxEx namhoc,ComboBoxEx thang)
        {
            QLKTX.DataLayer.PhongData phg = new QLKTX.DataLayer.PhongData();
            DataTable table =  phg.LayDSPhong_DK_DAY(day.SelectedValue.ToString());
            foreach (DataRow r in table.Rows)
            {
                string maphg = r["MAPHG"].ToString();
                DataTable tables_KWDien = data.layPhieuKWDien(maphg, namhoc.SelectedValue.ToString(), thang.Text);
                if(tables_KWDien.Rows.Count==0)
                    data.ThemPhieuKWDien(maphg, namhoc.SelectedValue.ToString(), thang.Text);
            }
        }
        public void LayDSPhieuKWDien(DataGridViewX dt)
        {
            dt.DataSource = data.layDSPhieuKWDien();
        }
        public void CapNhatDSPhieuKWDien(DataGridViewX dt)
        {
            data = new NhapKWDienData();
            foreach (DataGridViewRow r in dt.Rows)
            {
                data.CapNhatPhieuKWDien(r.Cells["maphg"].Value.ToString(), r.Cells["manamhoc"].Value.ToString(), r.Cells["colthang"].Value.ToString(), r.Cells["colKWDien"].Value.ToString());
            }
        }
        public void CapNhatDSPhieuKWDienSua(DataGridViewX dt)
        {
            data.layDSPhieuKWDienSua();
        }

    }
}
