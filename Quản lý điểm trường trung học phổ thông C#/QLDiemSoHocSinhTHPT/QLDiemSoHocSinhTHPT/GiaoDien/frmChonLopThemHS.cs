using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Controller;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.GiaoDien
{
    public partial class frmChonLopThemHS : Form
    {
        #region NamHocInfo
        private NamHocInfo m_NamHocInfo;

        public NamHocInfo NamHocInfo
        {
            get { return m_NamHocInfo; }
            set { m_NamHocInfo = value; }
        }

        #endregion

        #region KhoiLopController
        private KhoiLopController m_KhoiLopController;

        public KhoiLopController KhoiLopController
        {
            get { return m_KhoiLopController; }
            set { m_KhoiLopController = value; }
        }
	
        #endregion

        #region LopController
        private LopController m_LopController;

        public LopController LopController
        {
            get { return m_LopController; }
            set { m_LopController = value; }
        }

        #endregion

        #region NamHocController
        private NamHocController m_NamHocController;

        public NamHocController NamHocController
        {
            get { return m_NamHocController; }
            set { m_NamHocController = value; }
        }

        #endregion

        #region Info
        private LopInfo m_Info;

        public LopInfo Info
        {
            get { return m_Info; }
            set { m_Info = value; }
        }
	
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public frmChonLopThemHS()
        {
            InitializeComponent();

            this.NamHocInfo = new NamHocController().LayTuMa(new NamHocController().LayMaCuoi());
            //this.NamHocController = new NamHocController();
            this.KhoiLopController = new KhoiLopController();
            this.LopController = new LopController();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmChonLopThemHS_Load(object sender, EventArgs e)
        {
            if (this.KhoiLopController == null)
            {
                this.KhoiLopController = new KhoiLopController();
            }

            if (this.LopController == null)
            {
                this.LopController = new LopController();
            }

            if (this.NamHocController == null)
            {
                this.NamHocController = new NamHocController();
            }

            this.lbNamHoc.Text += this.NamHocInfo.TenNamHoc;
            this.KhoiLopController.HienThiCombobox(this.cmbKhoiLop);
            //this.NamHocController.HienThiCombobox(this.cmbChonNam);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbChon_Click(object sender, EventArgs e)
        {
            this.Info = new LopInfo();
            String maLop = ((DataRowView)this.cmbLop.SelectedItem).Row.ItemArray[0].ToString();
            this.Info = this.LopController.LayTuMa(maLop);
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbKhoiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbKhoiLop.SelectedIndex != -1)
            {
                this.LopController.HienThiCombobox(this.cmbLop, ((DataRowView)this.cmbKhoiLop.SelectedItem).Row.ItemArray[0].ToString(), this.NamHocInfo.MaNamHoc);
                //this.LopController.HienThiCombobox(this.cmbLop, ((DataRowView)this.cmbKhoiLop.SelectedItem).Row.ItemArray[0].ToString(), this.cmb);
                if (this.cmbLop.Items.Count > 0)
                {
                    this.cmbLop.SelectedIndex = 0;
                }
            }


            //if (this.cmbKhoiLop.SelectedIndex != -1)
            //{
            //    if (this.cmbChonNam.SelectedIndex != -1)
            //    {
            //        this.LopController.HienThiCombobox(this.cmbLop, ((DataRowView)this.cmbKhoiLop.SelectedItem).Row.ItemArray[0].ToString(), ((DataRowView)this.cmbChonNam.SelectedItem).Row.ItemArray[0].ToString());

            //        if (this.cmbLop.Items.Count != -1)
            //        {
            //            this.cmbLop.SelectedIndex = 0;
            //        }
            //    }
            //}

        }

        //private void cmbChonNam_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //if (this.cmbChonNam.SelectedIndex != -1)
        //    //{
        //    //    if (this.cmbKhoiLop.SelectedIndex != -1)
        //    //    {
        //    //        this.LopController.HienThiCombobox(this.cmbLop, ((DataRowView)this.cmbKhoiLop.SelectedItem).Row.ItemArray[0].ToString(), ((DataRowView)this.cmbChonNam.SelectedItem).Row.ItemArray[0].ToString());
        //    //        this.cmbLop.SelectedIndex = 0;
        //    //    }
        //    //}

        //    if (this.cmbChonNam.SelectedIndex != -1)
        //    {
        //        if (this.cmbKhoiLop.SelectedIndex != -1)
        //        {
        //            this.LopController.HienThiCombobox(this.cmbLop, ((DataRowView)this.cmbKhoiLop.SelectedItem).Row.ItemArray[0].ToString(), ((DataRowView)this.cmbChonNam.SelectedItem).Row.ItemArray[0].ToString());
        //            this.cmbLop.SelectedIndex = 0;
        //        }
        //    }
        //}
    }
}