using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Controller;
using QLDiemSoHocSinhTHPT.BusinessObject;
using QLDiemSoHocSinhTHPT.Report;

namespace QLDiemSoHocSinhTHPT.GiaoDien
{
    public partial class frmDSHocSinh_Lop : Form
    {
        public frmDSHocSinh_Lop()
        {
            InitializeComponent();
            this.NamHocController = new NamHocController();
            this.KhoiLopController = new KhoiLopController();
            this.LopController = new LopController();
        }
        #region Controller
        private HocSinhController m_HocSinhController;

        public HocSinhController HocSinhController
        {
            get { return m_HocSinhController; }
            set { m_HocSinhController = value; }
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

        #region PhanLopController
        private PhanLopController m_PhanLopController;

        public PhanLopController PhanLopController
        {
            get { return m_PhanLopController; }
            set { m_PhanLopController = value; }
        }

        #endregion

        private void cmbChonNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbChonNam.SelectedIndex != -1)
            {
                if (this.cmbKhoiLop.SelectedIndex != -1)
                {
                    this.LopController.HienThiCombobox(this.cmbLop, ((DataRowView)this.cmbKhoiLop.SelectedItem).Row.ItemArray[0].ToString(), ((DataRowView)this.cmbChonNam.SelectedItem).Row.ItemArray[0].ToString());
                    this.cmbLop.SelectedIndex = 0;
                }
            }

        }

        private void cmbKhoiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbKhoiLop.SelectedIndex != -1)
            {
                if (this.cmbChonNam.SelectedIndex != -1)
                {
                    this.LopController.HienThiCombobox(this.cmbLop, ((DataRowView)this.cmbKhoiLop.SelectedItem).Row.ItemArray[0].ToString(), ((DataRowView)this.cmbChonNam.SelectedItem).Row.ItemArray[0].ToString());

                    if (this.cmbLop.Items.Count != -1)
                    {
                        this.cmbLop.SelectedIndex = 0;
                    }
                }
            }
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbLop.SelectedIndex != -1)
            {
                this.PhanLopController.HienThiDS(this.lvDSLopHoc, ((DataRowView)this.cmbLop.SelectedItem).Row.ItemArray[0].ToString());
                LopInfo lop = new LopController().LayTuMa(((DataRowView)this.cmbLop.SelectedItem).Row.ItemArray[0].ToString());
                
            }
        }

        private void frmDSHocSinh_Lop_Load(object sender, EventArgs e)
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

            if (this.PhanLopController == null)
            {
                this.PhanLopController = new PhanLopController();
            }
            
            this.KhoiLopController.HienThiCombobox(this.cmbKhoiLop);
            this.NamHocController.HienThiCombobox(this.cmbChonNam);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btReport_Click(object sender, EventArgs e)
        {
            rptFromDSHS frm_DSHS = new rptFromDSHS();
            frm_DSHS.Show();
        }
    }
}