using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Data;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Controller
{
    public class PhanCongController
    {
        #region Data
        private PhanCongData m_Data;

        public PhanCongData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }
	
        #endregion

        public PhanCongController()
        {
            this.Data = new PhanCongData();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dgvDS"></param>
        /// <param name="bnDS"></param>
        public void HienThiDS(DataGridView dgvDS, BindingNavigator bnDS, ComboBox cmbMonHoc, ComboBox cmbGiaoVien)
        {
            if (this.Data == null)
            {
                this.Data = new PhanCongData();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Data.LayDS();
            bnDS.BindingSource = bs;
            dgvDS.DataSource = bs;            
            cmbMonHoc.DataBindings.Add("SelectedValue", bs, "MaLopMonHoc");
            cmbGiaoVien.DataBindings.Add("SelectedValue", bs, "MaGiaoVien");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dgvDS"></param>
        /// <param name="bnDS"></param>
        /// <param name="maLop"></param>
        public void HienThiDS(DataGridView dgvDS, BindingNavigator bnDS, LopInfo lopInfo)
        {
            if (this.Data == null)
            {
                this.Data = new PhanCongData();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Data.LayDS(lopInfo);
            bnDS.BindingSource = bs;
            dgvDS.DataSource = bs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dgvDS"></param>
        /// <param name="bnDS"></param>
        /// <param name="maMonHoc"></param>
        public void HienThiDS(DataGridView dgvDS, BindingNavigator bnDS, MonHocInfo monHocInfo)
        {
            if (this.Data == null)
            {
                this.Data = new PhanCongData();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Data.LayDS(monHocInfo);
            bnDS.BindingSource = bs;
            dgvDS.DataSource = bs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dgvDS"></param>
        /// <param name="bnDS"></param>
        /// <param name="maGiaoVien"></param>
        public void HienThiDS(DataGridView dgvDS, BindingNavigator bnDS, GiaoVienInfo giaoVienInfo)
        {
            if (this.Data == null)
            {
                this.Data = new PhanCongData();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Data.LayDS(giaoVienInfo);
            bnDS.BindingSource = bs;
            dgvDS.DataSource = bs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lopInfo"></param>
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn col, LopInfo lopInfo)
        {
            if (this.Data == null)
            {
                this.Data = new PhanCongData();
            }
            col.DataSource = this.Data.LayDS(lopInfo);
            col.DisplayMember = "TenLop";
            col.ValueMember = "MaLop";
            col.DataPropertyName = "MaLop";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        /// <param name="monHocInfo"></param>
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn col, MonHocInfo monHocInfo)
        {
            if (this.Data == null)
            {
                this.Data = new PhanCongData();
            }
            col.DataSource = this.Data.LayDS(monHocInfo);
            col.DisplayMember = "TenLop";
            col.ValueMember = "MaLop";
            col.DataPropertyName = "MaLop";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        /// <param name="lopInfo"></param>
        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn col, GiaoVienInfo giaoVienInfo)
        {
            if (this.Data == null)
            {
                this.Data = new PhanCongData();
            }
            col.DataSource = this.Data.LayDS(giaoVienInfo);
            col.DisplayMember = "TenLop";
            col.ValueMember = "MaLop";
            col.DataPropertyName = "MaLop";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maPhanCong"></param>
        /// <returns></returns>
        public PhanCongInfo LayTuMa(int maPhanCong)
        {
            if (this.Data == null)
            {
                this.Data = new PhanCongData();
            }
            DataTable table = this.Data.LayTuMa(maPhanCong);
            if (table.Rows.Count > 0)
            {
                PhanCongInfo info = new PhanCongInfo();
                info.MaPhanCong = int.Parse(table.Rows[0]["MaPhanCong"].ToString());
                LopMonHocController lopMonHocCtrl = new LopMonHocController();
                info.LopMonHoc = lopMonHocCtrl.LayTuMa(int.Parse(table.Rows[0]["MaLopMonHoc"].ToString()));
                GiaoVienController giaoVienCtrl = new GiaoVienController();
                info.GiaoVien = giaoVienCtrl.LayTuMa(table.Rows[0]["MaGiaoVien"].ToString());
                return info;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maPhanCong"></param>
        /// <returns></returns>
        public bool XoaTuMa(string maPhanCong)
        {
            if (this.Data == null)
            {
                this.Data = new PhanCongData();
            }
            return this.Data.XoaTuMa(maPhanCong);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="monHoc"></param>
        /// <returns></returns>
        public bool Xoa(LopMonHocInfo lopMonHoc)
        {
            if (this.Data == null)
            {
                this.Data = new PhanCongData();
            }
            return this.Data.Xoa(lopMonHoc);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Update()
        {
            return this.Data.Update();
        }
    }
}
