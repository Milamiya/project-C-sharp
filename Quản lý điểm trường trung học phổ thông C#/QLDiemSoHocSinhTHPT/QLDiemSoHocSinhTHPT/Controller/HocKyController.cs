using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Data;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Controller
{
    public class HocKyController
    {
        #region Data
        private HocKyData m_Data;

        public HocKyData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }

        #endregion

        public HocKyController()
        {
            this.Data = new HocKyData();
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
                this.Data = new HocKyData();
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
                this.Data = new HocKyData();
            }
            cmb.DataSource = this.Data.LayDS();
            cmb.DisplayMember = "TenHocKy";
            cmb.ValueMember = "MaHocKy";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        public void HienThiDataGridComboBoxColumn(DataGridViewComboBoxColumn col)
        {
            if (this.Data == null)
            {
                this.Data = new HocKyData();
            }
            col.DataSource = this.Data.LayDS();
            col.DisplayMember = "TenHocKy";
            col.ValueMember = "MaHocKy";
            col.DataPropertyName = "MaHocKy";
        }

        public HocKyInfo LayTuMa(string maHocKy)
        {
            if (this.Data == null)
            {
                this.Data = new HocKyData();
            }
            DataTable table = this.Data.LayTuMa(maHocKy);
            if (table.Rows.Count > 0)
            {
                HocKyInfo hocKyInfo = new HocKyInfo();
                hocKyInfo.MaHocKy = table.Rows[0]["MaHocKy"].ToString();
                hocKyInfo.TenHocKy = table.Rows[0]["TenHocKy"].ToString();
                hocKyInfo.HeSo = int.Parse(table.Rows[0]["HeSo"].ToString());
                return hocKyInfo;
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
                this.Data = new HocKyData();
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
