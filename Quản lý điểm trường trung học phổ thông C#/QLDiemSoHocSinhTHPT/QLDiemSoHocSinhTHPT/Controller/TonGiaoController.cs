using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Data;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Controller
{
    public class TonGiaoController
    {
        #region Data
        private TonGiaoData m_Data;

        public TonGiaoData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }
	
        #endregion

        public TonGiaoController()
        {
            this.Data = new TonGiaoData();
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
                this.Data = new TonGiaoData();
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
                this.Data = new TonGiaoData();
            }
            cmb.DataSource = this.Data.LayDS();
            cmb.DisplayMember = "TenTonGiao";
            cmb.ValueMember = "MaTonGiao";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        public void HienThiDataGridComboBoxColumn(DataGridViewComboBoxColumn col)
        {
            if (this.Data == null)
            {
                this.Data = new TonGiaoData();
            }
            col.DataSource = this.Data.LayDS();
            col.DisplayMember = "TenTonGiao";
            col.ValueMember = "MaTonGiao";
            col.DataPropertyName = "MaTonGiao";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maDanToc"></param>
        /// <returns></returns>
        /*public DanTocController LayTuMa(string maTonGiao)
        {

        }*/

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int LayMaCuoi()
        {
            if (this.Data == null)
            {
                this.Data = new TonGiaoData();
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
