using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using QLHS.BUS;
using QLHS.Report;
using Util;

namespace QLHS
{
    public partial class FrmBcTongKetMon : XtraForm
    {
        private readonly BangDiemBUS _bangDiemBUS;
        private readonly HocKyBUS _hocKyBUS;
        private readonly KhoiBUS _khoiBUS;
        private readonly MonHocBUS _monHocBUS;
        private readonly NamHocBUS _namHocBUS;
        private List<TongKetMonDTO> _dsBaocaoTongKetMonHoc;
        private frmReportView _frmReportViewTongKetMon;
        private rptTongKetMon _rptTongKetMon;

        public FrmBcTongKetMon()
        {
            InitializeComponent();
            _khoiBUS = new KhoiBUS();
            _namHocBUS = new NamHocBUS();
            _bangDiemBUS = new BangDiemBUS();
            _hocKyBUS = new HocKyBUS();
            _monHocBUS = new MonHocBUS();
            _dsBaocaoTongKetMonHoc = null;
        }

        /// <summary>
        /// Hiển thị bảng tổng kết môn
        /// </summary>
        private void HienThi_Bang_TongKetMon()
        {
            if (treeMonHoc.FocusedNode == null)
            {
                gridControlTongKetMonHoc.DataSource = null;
                return;
            }

            //Chắc chắn chọn được node
            string maMonHoc = treeMonHoc.FocusedNode.GetValue("MaMonHoc").ToString();
            _dsBaocaoTongKetMonHoc = _bangDiemBUS.LayList_BangTongKet_MonHoc_Khoi_HocKy(maMonHoc,
                                                                                        CboUtil.GetValueItem(
                                                                                            comboBoxEditKhoiLop),
                                                                                        CboUtil.GetValueItem(
                                                                                            comboBoxEditHocKy),
                                                                                        CboUtil.GetValueItem(
                                                                                            comboBoxEditNamHoc));
            gridControlTongKetMonHoc.DataSource = _dsBaocaoTongKetMonHoc;


            labelControlNamHoc.Text = CboUtil.GetDisplayItem(comboBoxEditNamHoc);
            labelControlHocKy.Text = CboUtil.GetValueItem(comboBoxEditHocKy);
            labelControlKhoiLop.Text = CboUtil.GetValueItem(comboBoxEditKhoiLop);
            labelControlMonHocTT.Text = treeMonHoc.FocusedNode.GetValue("TenMonHoc").ToString().ToUpper();
        }

        private void frmBC_TongKetMon_Load(object sender, EventArgs e)
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

            treeMonHoc.ParentFieldName = "MaMonHoc";
            treeMonHoc.PreviewFieldName = "TenMonHoc";
            treeMonHoc.DataSource = _monHocBUS.LayDT_DanhSach_MonHoc();
        }

        private void comboBoxEditNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThi_Bang_TongKetMon();
        }

        private void comboBoxEditHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThi_Bang_TongKetMon();
        }

        private void comboBoxEditKhoiLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThi_Bang_TongKetMon();
        }

        private void treeMonHoc_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            HienThi_Bang_TongKetMon();
        }

        private void simpleButtonXuatBD_Click(object sender, EventArgs e)
        {
            if (_dsBaocaoTongKetMonHoc.Count == 0)
            {
                MsgboxUtil.Error("Không tồn tại lớp để thực hiện báo cáo!");
                return;
            }
            if (_rptTongKetMon == null)
                _rptTongKetMon = new rptTongKetMon();
            _rptTongKetMon.SetDataSource(_dsBaocaoTongKetMonHoc);
            // Set parameter
            _rptTongKetMon.SetParameterValue("paramTenMonHoc",
                                             treeMonHoc.FocusedNode.GetValue("TenMonHoc").ToString().ToUpper());
            _rptTongKetMon.SetParameterValue("paramTenNamHoc",
                                             CboUtil.GetDisplayItem(comboBoxEditNamHoc));
            _rptTongKetMon.SetParameterValue("paramMaHocKy",
                                             CboUtil.GetValueItem(comboBoxEditHocKy));
            _rptTongKetMon.SetParameterValue("paramMaKhoi",
                                             CboUtil.GetValueItem(comboBoxEditKhoiLop));

            if (_frmReportViewTongKetMon == null || _frmReportViewTongKetMon.IsDisposed)
                _frmReportViewTongKetMon = new frmReportView();
            _frmReportViewTongKetMon.crystalReportViewer.ReportSource = _rptTongKetMon;
            _frmReportViewTongKetMon.ShowDialog();
        }
    }
}