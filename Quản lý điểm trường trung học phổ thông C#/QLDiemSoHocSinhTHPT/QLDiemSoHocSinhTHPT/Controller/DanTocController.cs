using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Data;

namespace QLDiemSoHocSinhTHPT.Controller
{
    public class DanTocController
    {
        #region Data
        private DanTocData m_Data;

        public DanTocData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }
            
        #endregion

        public DanTocController()
        {
            this.Data = new DanTocData();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="bn"></param>
        public void HienThiDS(DataGridView dgvDS, BindingNavigator bnDS)
        {
            if (this.Data == null)
            {
                this.Data = new DanTocData();
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
                this.Data = new DanTocData();
            }
            cmb.DataSource = this.Data.LayDS();
            cmb.DisplayMember = "TenDanToc";
            cmb.ValueMember = "MaDanToc";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        public void HienThiDataGridComboBoxColumn(DataGridViewComboBoxColumn col)
        {
            if (this.Data == null)
            {
                this.Data = new DanTocData();
            }
            col.DataSource = this.Data.LayDS();
            col.DisplayMember = "TenDanToc";
            col.ValueMember = "MaDanToc";
            col.DataPropertyName = "MaDanToc";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int LayMaCuoi()
        {
            if (this.Data == null)
            {
                this.Data = new DanTocData();
            }
            return Convert.ToInt16(this.Data.LayMaCuoi());
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
