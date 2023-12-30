using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using QLHS.BUS;
using QLHS.DTO;
using QLHS.Report;
using Util;

namespace QLHS
{
    public partial class FrmBcBangDiemHocKy : XtraForm
    {
        private readonly BangDiemBUS _bangDiemBUS;
        private readonly HocKyBUS _hocKyBUS;
        private readonly KhoiBUS _khoiBUS;
        private readonly LopBUS _lopBUS;
        private readonly NamHocBUS _namHocBUS;
        private List<BangDiemHocKyDTO> _bangDiemHocKyDTO;
        private frmReportView _frmReportView;
        private rptBangDiemHocKy _rptTongKetHocKy;

        public FrmBcBangDiemHocKy()
        {
            InitializeComponent();

            _khoiBUS = new KhoiBUS();
            _lopBUS = new LopBUS();
            _namHocBUS = new NamHocBUS();
            _bangDiemBUS = new BangDiemBUS();
            _hocKyBUS = new HocKyBUS();
            _bangDiemHocKyDTO = null;
        }

        private void frmBangDiemMonHoc_Load(object sender, EventArgs e)
        {
            treeListLopHoc.ParentFieldName = "MaKhoi";
            treeListLopHoc.PreviewFieldName = "TenKhoi";
            treeListLopHoc.DataSource = _khoiBUS.LayDT_Khoi();

            CboUtil.SetDataSource(comboBoxEditNamHoc,
                                  _namHocBUS.LayDTNamHoc(),
                                  "MaNamHoc", "TenNamHoc", 0);
            CboUtil.SetDataSource(comboBoxEditHocKy,
                                  _hocKyBUS.LayDT_HocKy(),
                                  "MaHocKy", "TenHocKy", 0);

            CapNhatListLop();
        }

        /// <summary>
        /// Cập nhật lại list lớp theo khối
        /// </summary>
        private void CapNhatListLop()
        {
            // Duyệt từng khối
            foreach (TreeListNode item in treeListLopHoc.Nodes)
            {
                item.Nodes.Clear();
                IEnumerable<LopDTO> listLopNode = _lopBUS.LayListLop_MaNam_MaKhoi(
                    CboUtil.GetValueItem(comboBoxEditNamHoc),
                    item.GetValue("MaKhoi").ToString()
                    );
                // add các lớp vào khối item
                foreach (LopDTO lopNode in listLopNode)
                {
                    treeListLopHoc.AppendNode(new object[] {lopNode.MaLop, lopNode.TenLop}, item);
                }
            }
            treeListLopHoc.ExpandAll(); // Expand all nodes
        }

        /// <summary>
        /// Hiển thị lại bảng điểm
        /// </summary>
        private void HienThi_Lai_BangDiem()
        {
            // Chắc chắn chọn được node
            if (treeListLopHoc.FocusedNode == null)
            {
                // gridControlTongKetNamHoc.DataSource = null;
                return;
            }

            string maLop = treeListLopHoc.FocusedNode.GetValue("MaKhoi").ToString();
            _bangDiemHocKyDTO = _bangDiemBUS.LayList_BangDiem_Lop_HocKy(maLop,
                                                                        CboUtil.GetValueItem(comboBoxEditHocKy));
            gridControlBangDiemHocKy.DataSource = _bangDiemHocKyDTO;
            labelControlNamHoc.Text = CboUtil.GetDisplayItem(comboBoxEditNamHoc);
            labelControlLop.Text = treeListLopHoc.FocusedNode.GetValue("TenKhoi").ToString();
            labelControlHocKy.Text = CboUtil.GetValueItem(comboBoxEditHocKy);
            labelControlGVCN.Text = _lopBUS.LayTenGiaoVien_MaLop(maLop);
        }

        private void comboBoxEditNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatListLop();
            HienThi_Lai_BangDiem();
        }

        private void comboBoxEditHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThi_Lai_BangDiem();
        }

        private void treeListLopHoc_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            HienThi_Lai_BangDiem();
        }

        private void simpleButtonXuatBD_Click(object sender, EventArgs e)
        {
            if (_rptTongKetHocKy == null)
                _rptTongKetHocKy = new rptBangDiemHocKy();
            if (_frmReportView == null || _frmReportView.IsDisposed)
                _frmReportView = new frmReportView();
            _rptTongKetHocKy.SetDataSource(_bangDiemHocKyDTO);
            // Set parameter
            _rptTongKetHocKy.SetParameterValue("paramTenNam", labelControlNamHoc.Text);
            _rptTongKetHocKy.SetParameterValue("paramHocKy", labelControlHocKy.Text);
            _rptTongKetHocKy.SetParameterValue("paramGVCN", labelControlGVCN.Text);
            _rptTongKetHocKy.SetParameterValue("paramTenLop", labelControlLop.Text);


            _frmReportView.crystalReportViewer.ReportSource = _rptTongKetHocKy;
            _frmReportView.ShowDialog();
        }
    }
}