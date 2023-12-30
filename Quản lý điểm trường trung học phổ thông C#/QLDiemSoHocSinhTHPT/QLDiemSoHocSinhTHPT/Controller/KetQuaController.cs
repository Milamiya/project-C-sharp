using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Data;

namespace QLDiemSoHocSinhTHPT.Controller
{
    public class KetQuaController
    {
        #region Data
        private KetQuaData m_Data;

        public KetQuaData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }

        #endregion

        public KetQuaController()
        {
            this.Data = new KetQuaData();
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
                this.Data = new KetQuaData();
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
                this.Data = new KetQuaData();
            }
            cmb.DataSource = this.Data.LayDS();
            cmb.DisplayMember = "TenKetQua";
            cmb.ValueMember = "MaKetQua";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        public void HienThiDataGridComboBoxColumn(DataGridViewComboBoxColumn col)
        {
            if (this.Data == null)
            {
                this.Data = new KetQuaData();
            }
            col.DataSource = this.Data.LayDS();
            col.DisplayMember = "TenKetQua";
            col.ValueMember = "MaKetQua";
            col.DataPropertyName = "MaKetQua";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string LayMaCuoi()
        {
            if (this.Data == null)
            {
                this.Data = new KetQuaData();
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
