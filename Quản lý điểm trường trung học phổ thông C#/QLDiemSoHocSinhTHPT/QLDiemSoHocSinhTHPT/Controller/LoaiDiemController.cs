using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Data;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Controller
{
    public class LoaiDiemController
    {
        #region Data
        private LoaiDiemData m_Data;

        public LoaiDiemData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }

        #endregion

        public LoaiDiemController()
        {
            this.Data = new LoaiDiemData();
        }
       

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="bn"></param>
        public void HienThiDS(DataGridView dg, BindingNavigator bn)
        {
            if (this.Data == null)
            {
                this.Data = new LoaiDiemData();
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = this.Data.LayDS();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="col"></param>
        public void HienThiDataGridComboBoxColumnLoaiDiem(DataGridViewComboBoxColumn col)
        {
            if (this.Data == null)
            {
                this.Data = new LoaiDiemData();
            }
            col.DataSource = this.Data.LayDS();
            col.DisplayMember = "TenLoai";
            col.ValueMember = "MaLoai";
            col.DataPropertyName = "MaLoai";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cmb"></param>
        public void HienThiCombobox(ComboBox cmb)
        {
            if (this.Data == null)
            {
                this.Data = new LoaiDiemData();
            }
            cmb.DataSource = this.Data.LayDS();
            cmb.DisplayMember = "TenLoai";
            cmb.ValueMember = "MaLoai";
        }

        /// <summary>
        /// v10.1
        /// </summary>
        /// <param name="maLoaiDiem"></param>
        /// <returns></returns>
        public LoaiDiemInfo LayTuMa(string maLoai)
        {
            if (this.Data == null)
            {
                this.Data = new LoaiDiemData();
            }
            DataTable tbl = this.Data.LayTuMa(maLoai);
            if (tbl.Rows.Count > 0)
            {
                LoaiDiemInfo info = new LoaiDiemInfo();
                info.MaLoai = tbl.Rows[0]["MaLoai"].ToString();
                info.TenLoai = tbl.Rows[0]["TenLoai"].ToString();
                info.HeSo = int.Parse(tbl.Rows[0]["HeSo"].ToString());
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
                this.Data = new LoaiDiemData();
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
