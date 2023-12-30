using System;
using System.Collections.Generic;
using System.Text;
using QLKTX.DataLayer;
using DevComponents.DotNetBar.Controls;
using System.Data;

namespace QLKTX.Controller
{
    public class ChuyenPhongCtrl
    {        
        public void LayDSSVThuocKTX(ComboBoxEx cmb,DataGridViewX datag)
        {
            if (cmb.SelectedIndex >= 0)
            {
                ChuyenPhongData data = new ChuyenPhongData();
                datag.DataSource= data.LayDSSVThuocKTX(cmb.SelectedValue.ToString());
                datag.Columns["MAPHG"].Visible = false;
            }
        }
        public void LayDSSVThuocPhong(ComboBoxEx cmb, DataGridViewX datag)
        {
            if (cmb.SelectedIndex >= 0)
            {
                ChuyenPhongData data = new ChuyenPhongData();
                datag.DataSource = data.LayDSSVThuocPhong(cmb.SelectedValue.ToString());
                datag.Columns["MAPHG"].Visible = false;
            }
        }
        public void LayDSSVThuocDay(ComboBoxEx cmb, DataGridViewX datag)
        {
            if (cmb.SelectedIndex >= 0)
            {
                ChuyenPhongData data = new ChuyenPhongData();
                datag.DataSource = data.LayDSSVThuocDay(cmb.SelectedValue.ToString());
                datag.Columns["MAPHG"].Visible = false;
            }
        }
        public void ChuyenPhong(string MaKTX,string MaPHGCu,string MaPHGMoi)
        {
            if (KiemTraGioiTinh(MaKTX, MaPHGMoi))
            {
                if (MaPHGCu != MaPHGMoi)
                {
                    if (SoSVTrongPhong(MaPHGMoi) < SoSVToiDaTrongPhong(MaPHGMoi))
                    {
                        ChuyenPhongData data = new ChuyenPhongData();
                        data.ChuyenPhong(MaKTX, MaPHGCu, MaPHGMoi);
                    }
                    else System.Windows.Forms.MessageBox.Show("phòng đầy! " + SoSVTrongPhong(MaPHGMoi));
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("cùng một phòng!");
                }
            }
            else
                System.Windows.Forms.MessageBox.Show("Giới tính không phù hợp!");
        }
        public int SoSVTrongPhong(string MAPHG)
        {
            ChuyenPhongData data = new ChuyenPhongData();
            DataTable table = data.SoSVTrongPhong(MAPHG);
            int i=0;
            if (table.Columns.Count > 0 && table.Rows.Count > 0)
            {
            if (table.Rows[0]["so"].ToString() != "")
                i = Convert.ToInt32(table.Rows[0]["so"].ToString());
            else
                i = 0;
            }
            return i;
        }
        public int SoSVToiDaTrongPhong(string MAPHG)
        {
            ChuyenPhongData data = new ChuyenPhongData();
            DataTable table = data.SoSVToiDaTrongPhong(MAPHG);
            int i = 0;
            if (table.Columns.Count > 0 && table.Rows.Count > 0)
            {
                if (table.Rows[0]["SOLUONGTOIDA"].ToString() != "")
                    i = Convert.ToInt32(table.Rows[0]["SOLUONGTOIDA"].ToString());
                else
                    i = 0;
            }
            return i;
        }
        public bool KiemTraGioiTinh(string MAKTX,string MAPHG)
        {
            ChuyenPhongData data = new ChuyenPhongData();
            DataTable table = data.KiemTraGioiTinh(MAKTX,MAPHG);
            if (table.Columns.Count > 1 && table.Rows.Count > 0)
            {
                if (table.Rows[0]["PHONGNAM"].ToString() != table.Rows[0]["GIOITINH"].ToString())
                    return false;
                else return true;
                
            }
                return true;

        }
        
    }
}
