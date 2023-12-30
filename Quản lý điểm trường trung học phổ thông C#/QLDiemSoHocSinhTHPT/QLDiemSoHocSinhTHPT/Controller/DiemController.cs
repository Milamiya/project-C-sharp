using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Data;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Controller
{
    public class DiemController
    {
        #region Data
        private DiemData m_Data;

        public DiemData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }
	
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public DiemController()
        {
            this.Data = new DiemData();
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
                this.Data = new DiemData();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Data.LayDS();
            dgvDS.DataSource = bs;
            bnDS.BindingSource = bs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dgvDS"></param>
        /// <param name="bnDS"></param>
        /// <param name="monHoc"></param>
        public void HienThiDS(DataGridView dgvDS, BindingNavigator bnDS, MonHocInfo monHoc)
        {
            if (this.Data == null)
            {
                this.Data = new DiemData();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Data.LayDS(monHoc);
            dgvDS.DataSource = bs;
            bnDS.BindingSource = bs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dgvDS"></param>
        /// <param name="bnDS"></param>
        /// <param name="hocKy"></param>
        public void HienThiDS(DataGridView dgvDS, BindingNavigator bnDS, HocKyInfo hocKy)
        {
            if (this.Data == null)
            {
                this.Data = new DiemData();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Data.LayDS(hocKy);
            dgvDS.DataSource = bs;
            bnDS.BindingSource = bs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dgvDS"></param>
        /// <param name="bnDS"></param>
        /// <param name="monHoc"></param>
        /// <param name="hocKy"></param>
        public void HienThiDS(DataGridView dgvDS, BindingNavigator bnDS, MonHocInfo monHoc, HocKyInfo hocKy)
        {
            if (this.Data == null)
            {
                this.Data = new DiemData();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Data.LayDS(monHoc, hocKy);
            dgvDS.DataSource = bs;
            bnDS.BindingSource = bs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dgvDS"></param>
        /// <param name="bnDS"></param>
        /// <param name="phanLop"></param>
        /// <param name="monHoc"></param>
        /// <param name="hocKy"></param>
        public void HienThiDS(DataGridView dgvDS, BindingNavigator bnDS, PhanLopInfo phanLop, MonHocInfo monHoc, HocKyInfo hocKy)
        {
            if (this.Data == null)
            {
                this.Data = new DiemData();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Data.LayDS(phanLop, monHoc, hocKy);
            dgvDS.DataSource = bs;
            bnDS.BindingSource = bs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int LayMaCuoi()
        {
            if (this.Data == null)
            {
                this.Data = new DiemData();
            }
            return Convert.ToInt32(this.Data.LayMaCuoi());
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
