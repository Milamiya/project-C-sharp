using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Data;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Controller
{
    public class KhoiLopController
    {
        #region Data
        private KhoiLopData m_Data;

        public KhoiLopData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }
	
        #endregion

        public KhoiLopController()
        {
            this.Data = new KhoiLopData();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dgvDS"></param>
        /// <param name="bnDS"></param>
        public void HienThiDS(DataGridView dgvDS, BindingNavigator bnDS)
        {
            if (this.Data == null)
            {
                this.Data = new KhoiLopData();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Data.LayDS();
            bnDS.BindingSource = bs;
            dgvDS.DataSource = bs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        public void HienThiDataGridComboBoxColumn(DataGridViewComboBoxColumn col)
        {
            if (this.Data == null)
            {
                this.Data = new KhoiLopData();
            }
            col.DataSource = this.Data.LayDS();
            col.DisplayMember = "TenKhoiLop";
            col.ValueMember = "MaKhoiLop";
            col.DataPropertyName = "MaKhoiLop";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmb"></param>
        public void HienThiCombobox(ComboBox cmb)
        {
            if (this.Data == null)
            {
                this.Data = new KhoiLopData();
            }
            cmb.DataSource = this.Data.LayDS();
            cmb.DisplayMember = "TenKhoiLop";
            cmb.ValueMember = "MaKhoiLop";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string LayMaCuoi()
        {
            if (this.Data == null)
            {
                this.Data = new KhoiLopData();
            }
            return Convert.ToString(this.Data.LayMaCuoi());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maNamHoc"></param>
        /// <returns></returns>
        public string LayMaTruoc(string maNamHoc)
        {
            if (this.Data == null)
            {
                this.Data = new KhoiLopData();
            }
            return Convert.ToString(this.Data.LayMaTruoc(maNamHoc));
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="maKhoiLop"></param>
        /// <returns></returns>
        public KhoiLopInfo LayTuMa(string maKhoiLop)
        {
            if (this.Data == null)
            {
                this.Data = new KhoiLopData();
            }
            DataTable table = this.Data.LayTuMa(maKhoiLop);
            if (table.Rows.Count > 0)
            {
                KhoiLopInfo info = new KhoiLopInfo();
                info.MaKhoiLop = table.Rows[0]["MaKhoiLop"].ToString();
                info.TenKhoiLop = table.Rows[0]["TenKhoiLop"].ToString();
                return info;
            }
            return null;
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
