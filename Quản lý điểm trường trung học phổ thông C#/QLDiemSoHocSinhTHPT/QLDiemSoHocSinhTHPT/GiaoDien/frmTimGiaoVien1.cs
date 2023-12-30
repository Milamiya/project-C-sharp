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
    public partial class frmTimGiaoVien1 : Form
    {
        public frmTimGiaoVien1()
        {
            InitializeComponent();
        }

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

        private void frmTimGiaoVien1_Load(object sender, EventArgs e)
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
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            if (this.Controller == null)
            {
                this.Controller = new GiaoVienController();
            }
            this.Controller.TimTheoTen(dgvDS, bnDS, txtTenGiaoVien.Text);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}