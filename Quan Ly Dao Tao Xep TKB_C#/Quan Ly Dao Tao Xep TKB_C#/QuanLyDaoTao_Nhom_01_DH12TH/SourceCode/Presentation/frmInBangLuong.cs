using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using QuanLyDaoTao.DTO;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.Reports;

namespace QuanLyDaoTao.Presentation
{
    public partial class frmInBangLuong : XtraForm
    {
        private rptThanhToanGioDayDTO nguon;

        public rptThanhToanGioDayDTO Nguon
        {
            get { return nguon; }
            set 
            { 
                nguon = value; 
            }
        }

        public frmInBangLuong()
        {
            InitializeComponent();
        }

        public frmInBangLuong(rptThanhToanGioDayDTO source)
        {
            try
            {
                InitializeComponent();
                nguon = source;
                this.Text = string.Format("Bảng lương {0}:{1}", nguon.MaGV, nguon.TenGV);
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }

        private void frmInBangLuong_Load(object sender, EventArgs e)
        {
            try
            {
                rptThanhToan rpt = new rptThanhToan(nguon);
                printControl1.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument();
            }
            catch (Exception ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.Message);
            }
        }
    }
}