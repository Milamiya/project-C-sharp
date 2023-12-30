using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLDiemSoHocSinhTHPT.Controller;

namespace QLDiemSoHocSinhTHPT.GiaoDien
{
    public partial class frmDSGiaoVien : Form
    {
        #region Controller
        private GiaoVienController m_Controller;

        public GiaoVienController Controller
        {
            get { return m_Controller; }
            set { m_Controller = value; }
        }

        #endregion

        #region MonHocController
        private MonHocController m_MonHocController;

        public MonHocController MonHocController
        {
            get { return m_MonHocController; }
            set { m_MonHocController = value; }
        }

        #endregion

        
        public frmDSGiaoVien()
        {
            InitializeComponent();
        }

        private void frmDSGiaoVien_Load(object sender, EventArgs e)
        {
            //Khoi tao doi tuong m_Controller
            if (this.Controller == null)
            {
                this.Controller = new GiaoVienController();
            }

            //Khoi tao doi tuong m_MonHocController
            if (this.MonHocController == null)
            {
                this.MonHocController = new MonHocController();
            }

            this.MonHocController.HienThiDataGridComboBoxColumn(this.colMonHoc);
            this.Controller.HienThiDS(this.dgvDS);

        }

    }
}