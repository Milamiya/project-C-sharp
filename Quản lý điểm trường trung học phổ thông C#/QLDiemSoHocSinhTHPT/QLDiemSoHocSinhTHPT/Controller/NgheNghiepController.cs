using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Data;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Controller
{
    public class NgheNghiepController
    {
        #region Data
        private NgheNghiepData m_Data;

        public NgheNghiepData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }
	
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dgvDS"></param>
        /// <param name="bnDS"></param>
        public void HienThiDS(DataGridView dgvDS, BindingNavigator bnDS)
        {
            if (this.Data == null)
            {
                this.Data = new NgheNghiepData();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Data.LayDS();
            bnDS.BindingSource = bs;
            dgvDS.DataSource = bs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmb"></param>
        public void HienThiCombobox(ComboBox cmb)
        {
            if (this.Data == null)
            {
                this.Data = new NgheNghiepData();
            }
            cmb.DataSource = this.Data.LayDS();
            cmb.DisplayMember = "TenNghe";
            cmb.ValueMember = "MaNghe";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        /// <param name="dataPropertyName"></param>
        public void HienThiDataGridComboBoxColumn(DataGridViewComboBoxColumn col, String dataPropertyName)
        {
            if (this.Data == null)
            {
                this.Data = new NgheNghiepData();
            }
            col.DataSource = this.Data.LayDS();
            col.DisplayMember = "TenNghe";
            col.ValueMember = "MaNghe";
            col.DataPropertyName = dataPropertyName;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int LayMaCuoi()
        {
            if (this.Data == null)
            {
                this.Data = new NgheNghiepData();
            }
            return Convert.ToInt16(this.Data.LayMaCuoi());
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
