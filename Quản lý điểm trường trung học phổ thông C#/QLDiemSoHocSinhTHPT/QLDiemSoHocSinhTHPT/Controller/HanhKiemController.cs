using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Data;

namespace QLDiemSoHocSinhTHPT.Controller
{
    public class HanhKiemController
    {
        #region Data
        private HanhKiemData m_Data;

        public HanhKiemData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }

        #endregion

        public HanhKiemController()
        {
            this.Data = new HanhKiemData();
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
                this.Data = new HanhKiemData();
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
                this.Data = new HanhKiemData();
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
                this.Data = new HanhKiemData();
            }
            col.DataSource = this.Data.LayDS();
            col.DisplayMember = "TenHanhKiem";
            col.ValueMember = "MaHanhKiem";
            col.DataPropertyName = "MaHanhKiem";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string LayMaCuoi()
        {
            if (this.Data == null)
            {
                this.Data = new HanhKiemData();
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
