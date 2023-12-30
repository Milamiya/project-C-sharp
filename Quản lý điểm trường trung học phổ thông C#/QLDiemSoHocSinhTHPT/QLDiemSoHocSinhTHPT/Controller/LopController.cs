using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Data;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Controller
{
    public class LopController
    {
        #region Data
        private LopData m_Data;

        public LopData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }
	
        #endregion

        public LopController()
        {
            this.Data = new LopData();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="txtMaLop"></param>
        /// <param name="txtTenLop"></param>
        /// <param name="txtSiSo"></param>
        /// <param name="cmbKhoiLop"></param>
        /// <param name="cmbNamHoc"></param>
        /// <param name="cmbMaGiaoVien"></param>
        /// <param name="dgvDS"></param>
        /// <param name="bnDS"></param>
        public void HienThiDS(TextBox txtMaLop, TextBox txtTenLop, TextBox txtSiSo, ComboBox cmbKhoiLop, ComboBox cmbNamHoc,ComboBox cmbMaGiaoVien, DataGridView dgvDS, BindingNavigator bnDS)
        {
            if (this.Data == null)
            {
                this.Data = new LopData();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Data.LayDS();
            bnDS.BindingSource = bs;
            dgvDS.DataSource = bs;
            txtMaLop.DataBindings.Add("Text", bs, "MaLop");
            txtTenLop.DataBindings.Add("Text", bs, "TenLop");
            txtSiSo.DataBindings.Add("Text", bs, "SiSo");
            cmbKhoiLop.DataBindings.Add("SelectedValue", bs, "MaKhoiLop");
            cmbNamHoc.DataBindings.Add("SelectedValue", bs, "MaNamHoc");
            cmbMaGiaoVien.DataBindings.Add("SelectedValue", bs, "MaGiaoVien");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        public void HienThiDataGridComboBoxColumn(DataGridViewComboBoxColumn col)
        {
            if (this.Data == null)
            {
                this.Data = new LopData();
            }
            col.DataSource = this.Data.LayDS();
            col.DisplayMember = "TenLop";
            col.ValueMember = "MaLop";
            col.DataPropertyName = "MaLop";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        /// <param name="khoiLop"></param>
        /// <param name="maNamHoc"></param>
        public void HienThiDataGridComboBoxColumn(DataGridViewComboBoxColumn col, string maKhoi, string maNamHoc)
        {
            if (this.Data == null)
            {
                this.Data = new LopData();
            }
            col.DataSource = this.Data.LayDS(maKhoi, maNamHoc);
            col.DisplayMember = "TenLop";
            col.ValueMember = "MaLop";
            col.DataPropertyName = "MaLop";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmb"></param>
        public void HienThiCombobox(ComboBox cmb)
        {
            if (this.Data == null)
            {
                this.Data = new LopData();
            }
            cmb.DataSource = this.Data.LayDS();
            cmb.DisplayMember = "TenLop";
            cmb.ValueMember = "MaLop";
            cmb.SelectedValue = "MaLop";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="maKhoi"></param>
        /// <param name="maNamHoc"></param>
        public void HienThiCombobox(ComboBox cmb, string maKhoi, string maNamHoc)
        {
            if (this.Data == null)
            {
                this.Data = new LopData();
            }
            cmb.DataSource = this.Data.LayDS(maKhoi, maNamHoc);
            cmb.DisplayMember = "TenLop";
            cmb.ValueMember = "MaLop";
            cmb.SelectedValue = "MaLop";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="maKhoi"></param>
        /// <param name="maNamHoc"></param>
        /// <param name="maGiaoVien"></param>
        public void HienThiCombobox(ComboBox cmb, string maKhoi, string maNamHoc, string maGiaoVien)
        {
            if (this.Data == null)
            {
                this.Data = new LopData();
            }
            cmb.DataSource = this.Data.LayDS(maKhoi, maNamHoc, maGiaoVien);
            cmb.DisplayMember = "TenLop";
            cmb.ValueMember = "MaLop";
            cmb.SelectedValue = "MaLop";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="maKhoi"></param>
        /// <param name="maNamHoc"></param>
        public void HienThiCombobox(ComboBox cmb, string maNamHoc)
        {
            if (this.Data == null)
            {
                this.Data = new LopData();
            }
            cmb.DataSource = this.Data.LayDS(maNamHoc);
            cmb.DisplayMember = "TenLop";
            cmb.ValueMember = "MaLop";
            cmb.SelectedValue = "MaLop";
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="maLop"></param>
        /// <returns></returns>
        public LopInfo LayTuMa(string maLop)
        {
            if (this.Data == null)
            {
                this.Data = new LopData();
            }
            DataTable table = this.Data.LayTuMa(maLop);
            if (table.Rows.Count > 0)
            {
                LopInfo info = new LopInfo();
                info.MaLop = table.Rows[0]["MaLop"].ToString();
                info.TenLop = table.Rows[0]["TenLop"].ToString();
                info.KhoiLop = new KhoiLopController().LayTuMa(table.Rows[0]["MaKhoiLop"].ToString());
                info.NamHoc = new NamHocController().LayTuMa(table.Rows[0]["MaNamHoc"].ToString());
                info.SiSo = int.Parse(table.Rows[0]["SiSo"].ToString());
                info.GiaoVien = new GiaoVienController().LayTuMa(table.Rows[0]["MaGiaoVien"].ToString());
                return info;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string LayMaCuoi()
        {
            if (this.Data == null)
            {
                this.Data = new LopData();
            }
            return Convert.ToString(this.Data.LayMaCuoi());
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Update()
        {
            return this.Data.Update();
        }
    }
}
