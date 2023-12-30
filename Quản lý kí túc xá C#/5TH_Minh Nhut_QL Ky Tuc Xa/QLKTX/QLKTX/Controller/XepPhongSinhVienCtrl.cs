using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DevComponents.DotNetBar.Controls;
using QLKTX.DataLayer;
using System.Windows.Forms;

namespace QLKTX.Controller
{
    public class XepPhongSinhVienCtrl
    {
        public void LayDSSinhVien_ChuaXepPhong(DataGridViewX data)
        {
            XepPhongSinhVienData XepPhongdata = new XepPhongSinhVienData();
            data.DataSource = XepPhongdata.LayDSSinhVien_ChuaXepPhong();
        }
        public void LayDSSinhVien_ThuocPhong(DataGridViewX data,ComboBoxEx cmb)
        {
            if (cmb.SelectedIndex >= 0)
            {
                XepPhongSinhVienData XepPhongdata = new XepPhongSinhVienData();
                data.DataSource = XepPhongdata.LayDSSinhVien_ThuocPhong(cmb.SelectedValue.ToString());
            }
        }
        public void LayDSSinhVien_ThuocDay(DataGridViewX data, ComboBoxEx cmb)
        {
            if (cmb.SelectedIndex >= 0)
            {
                XepPhongSinhVienData XepPhongdata = new XepPhongSinhVienData();
                data.DataSource = XepPhongdata.LayDSSinhVien_ThuocDay(cmb.SelectedValue.ToString());
            }
        }
        public void LayDSSinhVien_ThuocKTX(DataGridViewX data, ComboBoxEx cmb)
        {
            if (cmb.SelectedIndex >= 0)
            {
                XepPhongSinhVienData XepPhongdata = new XepPhongSinhVienData();
                data.DataSource = XepPhongdata.LayDSSinhVien_ThuocPhong(cmb.SelectedValue.ToString());
            }
        }
        public void LayDSSinhVien_XepPhong(DataGridViewX data, ComboBoxEx cmb)
        {
            XepPhongSinhVienData XepPhongdata = new XepPhongSinhVienData();
            for (int i = 0; i < data.SelectedRows.Count; i++)
            {
                XepPhongdata.LayDSSinhVien_XepPhong(data.SelectedRows[i].Cells["colDSSinhVien_Maktx"].Value.ToString(), cmb.SelectedValue.ToString());
            }
        }
        public void LayDSSinhVien_XoaPhong(DataGridViewX data, ComboBoxEx cmb)
        {
            XepPhongSinhVienData XepPhongdata = new XepPhongSinhVienData();
            for (int i = 0; i < data.SelectedRows.Count; i++)
            {
                XepPhongdata.LayDSSinhVien_XoaPhong(data.SelectedRows[i].Cells["colDSSinhVien_Phong_Maktx"].Value.ToString(), cmb.SelectedValue.ToString());
            }
        }
        public void LayDSSinhVien_XepPhong(DataGridViewSelectedRowCollection rows, ComboBoxEx cmb)
        {
            XepPhongSinhVienData XepPhongdata = new XepPhongSinhVienData();
            for (int i = 0; i < rows.Count; i++)
            {
                XepPhongdata.LayDSSinhVien_XepPhong(rows[i].Cells["colDSSinhVien_Maktx"].Value.ToString(), cmb.SelectedValue.ToString());
            }
        }


    }
}
