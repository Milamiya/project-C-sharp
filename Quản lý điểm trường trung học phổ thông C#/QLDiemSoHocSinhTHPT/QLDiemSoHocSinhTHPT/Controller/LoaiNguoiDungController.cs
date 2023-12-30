using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Data;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Controller
{
    public class LoaiNguoiDungController
    {
        #region Data
        private LoaiNguoiDungData m_Data;

        public LoaiNguoiDungData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }
        #endregion

        public void HienThiComboBox(ComboBox cmb)
        {
            if (this.Data == null)
            {
                this.Data = new LoaiNguoiDungData();
            }
            cmb.DataSource = this.Data.LayDS();
            cmb.ValueMember = "MaLoai";
            cmb.DisplayMember = "TenLoai";
        }

        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmb)
        {
            if (this.Data == null)
            {
                this.Data = new LoaiNguoiDungData();
            }
            cmb.DataSource = this.Data.LayDS();
            cmb.DisplayMember = "TenLoai";
            cmb.ValueMember = "MaLoai";
            cmb.DataPropertyName = "MaLoai";
        }

        public LoaiNguoiDungInfo LayTuMa(int loaiNguoiDung)
        {
            if (this.Data == null)
            {
                this.Data = new LoaiNguoiDungData();
            }
            DataTable tbl = this.Data.LayLoaiNguoiDung(loaiNguoiDung);
            if (tbl.Rows.Count >= 1)
            {
                return new LoaiNguoiDungInfo(int.Parse(tbl.Rows[0][0].ToString()), tbl.Rows[0][1].ToString());
                //int.Parse(row[3].ToString())), row["TenNguoiDung"].ToString(), row["TenDangNhap"].ToString(), row["MatKhau"].ToString()
            }
            else
            {
                return null;
            }
        }
    }
}
