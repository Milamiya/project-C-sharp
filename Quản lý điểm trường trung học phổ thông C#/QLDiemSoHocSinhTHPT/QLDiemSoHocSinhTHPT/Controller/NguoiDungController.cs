using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Data;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Controller
{
    public class NguoiDungController
    {
        #region Data
        private NguoiDungData m_Data;

        public NguoiDungData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }
        #endregion

        public void HienThiDS(DataGridView dgv, BindingNavigator bn, TextBox txtTenDangNhap, TextBox txtMatKhau, ComboBox cmbLoaiNguoiDung, TextBox txtTenNguoiDung, ComboBox cmbGiaoVien)
        {
            if (this.Data == null)
            {
                this.Data = new NguoiDungData();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Data.LayDS();
            bn.BindingSource = bs;
            dgv.DataSource = bs;
            txtTenDangNhap.DataBindings.Add("Text", bs, "TenDangNhap");
            txtMatKhau.DataBindings.Add("Text", bs, "MatKhau");
            cmbLoaiNguoiDung.DataBindings.Add("SelectedValue", bs, "MaLoai");
            txtTenNguoiDung.DataBindings.Add("Text", bs, "TenNguoiDung");
            cmbGiaoVien.DataBindings.Add("SelectedValue", bs, "MaGiaoVien");
        }

        public void HienThiComboBox(ComboBox cmb)
        {
            if (this.Data == null)
            {
                this.Data = new NguoiDungData();
            }
            cmb.DataSource = this.Data.LayDS();
            cmb.DisplayMember = "TenNguoiDung";
            cmb.ValueMember = "MaNguoiDung";
        }

        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cmb)
        {
            if (this.Data == null)
            {
                this.Data = new NguoiDungData();
            }
            cmb.DataSource = this.Data.LayDS();
            cmb.DisplayMember = "TenNguoiDung";
            cmb.ValueMember = "MaNguoiDung";
            cmb.DataPropertyName = "MaNguoiDung";
        }

        public NguoiDungInfo LayNguoiDung(string tendangnhap)
        {
            if (this.Data == null)
            {
                this.Data = new NguoiDungData();
            }
            DataTable tbl = this.Data.LayNguoiDung(tendangnhap);
            if (tbl.Rows.Count >= 1)
            {
                DataRow row = tbl.Rows[0];
                LoaiNguoiDungController LoaiNguoiDungCtrl = new LoaiNguoiDungController();
                GiaoVienController GiaoVienCtrl = new GiaoVienController();
                return new NguoiDungInfo(int.Parse(row["MaNguoiDung"].ToString()), LoaiNguoiDungCtrl.LayTuMa(int.Parse(row["MaLoai"].ToString())), row["TenNguoiDung"].ToString(), row["TenDangNhap"].ToString(), row["MatKhau"].ToString(), GiaoVienCtrl.LayTuMa(row["MaGiaoVien"].ToString()));
            }
            else
            {
                return null;
            }
        }


        public bool Update()
        {
            return this.Data.Update();
        }

        public bool Update( NguoiDungInfo info, string newPassword)
        {
            if (this.m_Data== null)
            {
                this.m_Data= new NguoiDungData();
            }

            return this.m_Data.Update(info.MaNguoiDung, newPassword);
        }
    }
}
