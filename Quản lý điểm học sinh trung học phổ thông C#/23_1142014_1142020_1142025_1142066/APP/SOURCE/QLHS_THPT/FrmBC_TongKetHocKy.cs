using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using QLHS.BUS;
using QLHS.Report;
using Util;

namespace QLHS
{
    public partial class FrmBcTongKetHocKy : XtraForm
    {
        private readonly BangDiemBUS _bangDiemBUS;
        private readonly HocKyBUS _hocKyBUS;
        private readonly KhoiBUS _khoiBUS;
        private readonly NamHocBUS _namHocBUS;
        private IList<TongKetHocKyDTO> _dsBaocaoTongKetHocKy;
        private frmReportView _frmReportViewTongKetHocKy;
        private rptTongKetHocKy _rptTongKetHocKy;

        public FrmBcTongKetHocKy()
        {
            InitializeComponent();
            _khoiBUS = new KhoiBUS();
            _namHocBUS = new NamHocBUS();
            _bangDiemBUS = new BangDiemBUS();
            _hocKyBUS = new HocKyBUS();
            _dsBaocaoTongKetHocKy = null;
        }

        /// <summary>
        /// Hiển thị bảng tổng kết học kỳ
        /// </summary>
        private void HienThi_Bang_TongKetHocKy()
        {
            string maKhoi = CboUtil.GetValueItem(comboBoxEditKhoiLop);
            string maHocKy = CboUtil.GetValueItem(comboBoxEditHocKy);
            string maNamHoc = CboUtil.GetValueItem(comboBoxEditNamHoc);

            _dsBaocaoTongKetHocKy = _bangDiemBUS.LayList_BangTongKet_Khoi_HocKy(maKhoi, maHocKy, maNamHoc);

            gridControlTongKetHocKy.DataSource = _dsBaocaoTongKetHocKy;

            labelControlNamHoc.Text = CboUtil.GetDisplayItem(comboBoxEditNamHoc);
            labelControlHocKyTT.Text = maHocKy;
            labelControlKhoiLop.Text = maKhoi;
        }

        private void frmBC_TongKetHocKy_Load(object sender, EventArgs e)
        {
            CboUtil.SetDataSource(comboBoxEditNamHoc,
                                  _namHocBUS.LayDTNamHoc(),
                                  "MaNamHoc", "TenNamHoc", 0);
            CboUtil.SetDataSource(comboBoxEditHocKy,
                                  _hocKyBUS.LayDT_HocKy(),
                                  "MaHocKy", "TenHocKy", 0);
            CboUtil.SetDataSource(comboBoxEditKhoiLop,
                                  _khoiBUS.LayDT_Khoi(),
                                  "MaKhoi", "TenKhoi", 0);
        }

        private void comboBoxEditNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThi_Bang_TongKetHocKy();
        }

        private void comboBoxEditHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThi_Bang_TongKetHocKy();
        }

        private void comboBoxEditKhoiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThi_Bang_TongKetHocKy();
        }

        private void simpleButtonXuatBD_Click(object sender, EventArgs e)
        {
            if (_dsBaocaoTongKetHocKy.Count == 0)
            {
                MsgboxUtil.Error("Không tồn tại lớp để thực hiện báo cáo!");
                return;
            }
            if (_rptTongKetHocKy == null)
                _rptTongKetHocKy = new rptTongKetHocKy();
            _rptTongKetHocKy.SetDataSource(_dsBaocaoTongKetHocKy);
            // Set parameter
            _rptTongKetHocKy.SetParameterValue("paramTenNamHoc",
                                               CboUtil.GetDisplayItem(comboBoxEditNamHoc));
            _rptTongKetHocKy.SetParameterValue("paramMaHocKy",
                                               CboUtil.GetValueItem(comboBoxEditHocKy));
            _rptTongKetHocKy.SetParameterValue("paramMaKhoi",
                                               CboUtil.GetValueItem(comboBoxEditKhoiLop));

            if (_frmReportViewTongKetHocKy == null || _frmReportViewTongKetHocKy.IsDisposed)
                _frmReportViewTongKetHocKy = new frmReportView();
            _frmReportViewTongKetHocKy.crystalReportViewer.ReportSource = _rptTongKetHocKy;
            _frmReportViewTongKetHocKy.ShowDialog();
        }
    }
}