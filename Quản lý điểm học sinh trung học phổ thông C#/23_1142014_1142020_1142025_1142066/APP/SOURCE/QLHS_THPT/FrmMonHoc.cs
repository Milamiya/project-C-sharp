using System;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using QLHS.BUS;
using QLHS.DTO;
using Util;

namespace QLHS
{
    public partial class FrmMonHoc : XtraForm
    {
        private readonly MonHocBUS _monHocBUS;
        private int _currentRowEdit;

        public FrmMonHoc()
        {
            InitializeComponent();
            _monHocBUS = new MonHocBUS();
        }

        private void _Diable_Control(bool editing)
        {
            simpleButtonDong.Enabled = !editing;
            textEditMaMonHoc.Enabled = editing;
            gridcontrolMonHoc.Enabled = !editing;

            if (!editing)
            {
                if (gridViewMonHoc.RowCount > 0)
                {
                    gridViewMonHoc.FocusedRowHandle = _currentRowEdit;
                    gridViewMonHoc_FocusedRowChanged(this,
                                                     new FocusedRowChangedEventArgs(0,
                                                                                    _currentRowEdit));
                }
                else
                {
                    _Reset_Control();
                }
            }
        }

        private void _Reset_Control()
        {
            textEditMaMonHoc.Text = "";
            textEditTenMonHoc.Text = "";
            spinEditSoTiet.Value = 30;
            spinEditHeSo.Value = 1;
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            _Load_GridView();
        }

        private void gridViewMonHoc_FocusedRowChanged(object sender,
                                                      FocusedRowChangedEventArgs e)
        {
            // Chac chan chon duoc 1 dong nao do
            if (gridViewMonHoc.FocusedRowHandle < 0 || gridViewMonHoc.FocusedRowHandle >= gridViewMonHoc.RowCount)
                return;
            textEditMaMonHoc.Text =
                gridViewMonHoc.GetRowCellValue(gridViewMonHoc.FocusedRowHandle, "MaMonHoc").ToString();
            textEditTenMonHoc.Text =
                gridViewMonHoc.GetRowCellValue(gridViewMonHoc.FocusedRowHandle, "TenMonHoc").ToString();
            spinEditSoTiet.Text = gridViewMonHoc.GetRowCellValue(gridViewMonHoc.FocusedRowHandle, "SoTiet").ToString();
            spinEditHeSo.Text = gridViewMonHoc.GetRowCellValue(gridViewMonHoc.FocusedRowHandle, "HeSo").ToString();
            radioGroupTrangThai.SelectedIndex =
                Convert.ToInt32(gridViewMonHoc.GetRowCellValue(gridViewMonHoc.FocusedRowHandle, "TrangThai").ToString());
        }

        private void _Load_GridView()
        {
            gridcontrolMonHoc.DataSource = _monHocBUS.LayDT_DanhSach_MonHoc(false);
            using (var fCheckEdit = new RepositoryItemCheckEdit())
            {
                fCheckEdit.ValueChecked = 1;
                fCheckEdit.ValueUnchecked = 0;
                gridColumnTrangThai.ColumnEdit = fCheckEdit;
            }
            gridColumnTrangThai.FieldName = "TrangThai";

            _Diable_Control(editing: false);
        }

        private void simpleButtonDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButtonLuu_Click(object sender, EventArgs e)
        {
            _currentRowEdit = gridViewMonHoc.FocusedRowHandle;

            // Sửa
            if (spinEditHeSo.Value < 1 || spinEditHeSo.Value > 3)
            {
                MsgboxUtil.Error("Hệ số của môn học "
                                 + textEditTenMonHoc.Text + " không được quá 3.");
                spinEditHeSo.Focus();
                return;
            }
            if (spinEditSoTiet.Value < 15 || spinEditSoTiet.Value > 120)
            {
                MsgboxUtil.Error("Số tiết của môn học không hợp lệ " +
                                 "(không thể nhỏ hơn 15 và quá 120)!");
                spinEditSoTiet.Focus();
                return;
            }

            var monHocDTO = new MonHocDTO
                                {
                                    MaMonHoc = textEditMaMonHoc.Text,
                                    TenMonHoc = textEditTenMonHoc.Text.Replace("'", "''"),
                                    SoTiet = Convert.ToInt32(spinEditSoTiet.Value),
                                    HeSo = Convert.ToInt32(spinEditHeSo.Value),
                                    TrangThai = Convert.ToInt32(radioGroupTrangThai.SelectedIndex)
                                };

            _monHocBUS.CapNhat_MonHoc(monHocDTO);
            MsgboxUtil.Success("Đã cập nhật môn học: " + monHocDTO.TenMonHoc + " thành công!");
            _Load_GridView();
        }
    }
}