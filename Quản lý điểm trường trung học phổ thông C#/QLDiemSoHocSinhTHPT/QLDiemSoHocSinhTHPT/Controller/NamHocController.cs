using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Data;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Controller
{
    public class NamHocController
    {
        #region Data
        private NamHocData m_Data;

        public NamHocData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }
	
        #endregion

        public NamHocController()
        {
            this.Data = new NamHocData();
        }

        public void HienThiDS(DataGridView dgvDS, BindingNavigator bnDS)
        {
            if (this.Data == null)
            {
                this.Data = new NamHocData();
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
                this.Data = new NamHocData();
            }
            col.DataSource = this.Data.LayDS();
            col.DisplayMember = "TenNamHoc";
            col.ValueMember = "MaNamHoc";
            col.DataPropertyName = "MaNamHoc";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmb"></param>
        public void HienThiCombobox(ComboBox cmb)
        {
            if (this.Data == null)
            {
                this.Data = new NamHocData();
            }
            cmb.DataSource = this.Data.LayDS();
            cmb.DisplayMember = "TenNamHoc";
            cmb.ValueMember = "MaNamHoc";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maNamHoc"></param>
        /// <returns></returns>
        public NamHocInfo LayTuMa(string maNamHoc)
        {
            if (this.Data == null)
            {
                this.Data = new NamHocData();
            }
            DataTable table = this.Data.LayTuMa(maNamHoc);
            NamHocInfo info = new NamHocInfo();
            if (table.Rows.Count > 0)
            {
                info.MaNamHoc = table.Rows[0]["MaNamHoc"].ToString();
                info.TenNamHoc = table.Rows[0]["TenNamHoc"].ToString();
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
                this.Data = new NamHocData();
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
                this.Data = new NamHocData();
            }
            return Convert.ToString(this.Data.LayMaTruoc(maNamHoc));
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
