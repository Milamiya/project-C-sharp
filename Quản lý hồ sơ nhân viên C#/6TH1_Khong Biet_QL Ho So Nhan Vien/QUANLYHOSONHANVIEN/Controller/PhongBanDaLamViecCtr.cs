using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Windows.Forms;
using System.Data;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class PhongBanDaLamViecCtr
    {
        PhongBanDaLamViecData data = new PhongBanDaLamViecData();
        PhongBanData dataphongban = new PhongBanData();
        ChucVuData datachucvu = new ChucVuData();
        public void HienthiPHONGBANDALAMVIECDataGridview(System.Windows.Forms.DataGridView dg,string manv)
        {
            System.Windows.Forms.BindingSource bs = new System.Windows.Forms.BindingSource();
            DataTable tbl = data.DANHSACHPHONGBANDALAMVIEC(manv);
            bs.DataSource = tbl;
            dg.DataSource = bs;

        }

        public void HienthiDataGridViewComboBoxColumn1(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataSource = dataphongban.DanhsachPhongBan();
            cmb.DisplayMember = "TENPB";
            cmb.ValueMember = "MAPB";
            cmb.DataPropertyName = "PHONGBAN";
            cmb.AutoComplete = true;
            //cmb.HeaderText = "";
        }
        public void HienthiDataGridViewComboBoxColumn2(DataGridViewComboBoxColumn cmb)
        {
            cmb.DataSource = datachucvu.DanhsachChucVu();
            cmb.DisplayMember = "TENCV";
            cmb.ValueMember = "MACV";
            cmb.DataPropertyName = "CHUCDANH";
            cmb.AutoComplete = true;
            //cmb.HeaderText = "";
        }

        public void HienThiAutoCombobox1(ComboBox cmb)
        {
            DataTable tbl = dataphongban.DanhsachPhongBan();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENPB";
            cmb.ValueMember = "MAPB";
        }
        public void HienThiAutoCombobox2(ComboBox cmb)
        {
            DataTable tbl = datachucvu.DanhsachChucVu();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "TENCV";
            cmb.ValueMember = "MACV";
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
