using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Data;

namespace QLDiemSoHocSinhTHPT.Controller
{
    public class HocLucController
    {
        #region Data
        private HocLucData m_Data;

        public HocLucData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }

        #endregion

        public HocLucController()
        {
            this.Data = new HocLucData();
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
                this.Data = new HocLucData();
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
                this.Data = new HocLucData();
            }
            cmb.DataSource = this.Data.LayDS();
            cmb.DisplayMember = "TenHocLuc";
            cmb.ValueMember = "MaHocLuc";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        public void HienThiDataGridComboBoxColumn(DataGridViewComboBoxColumn col)
        {
            if (this.Data == null)
            {
                this.Data = new HocLucData();
            }
            col.DataSource = this.Data.LayDS();
            col.DisplayMember = "TenHocLuc";
            col.ValueMember = "MaHocLuc";
            col.DataPropertyName = "MaHocLuc";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string LayMaCuoi()
        {
            if (this.Data == null)
            {
                this.Data = new HocLucData();
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
