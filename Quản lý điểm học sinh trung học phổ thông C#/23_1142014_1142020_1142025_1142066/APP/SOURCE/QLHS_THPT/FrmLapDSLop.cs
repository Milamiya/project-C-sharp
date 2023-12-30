using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using QLHS.BUS;
using QLHS.DTO;
using Util;

namespace QLHS
{
    public partial class FrmLapDsLop : XtraForm
    {
        private readonly GiaoVienBUS _giaoVienBUS;
        private readonly KhoiBUS _khoiBUS;
        private readonly LopBUS _lopBUS;
        private readonly NamHocBUS _namHocBUS;
        private bool _isAddButton;
        private bool _isDeleteButton;

        public FrmLapDsLop()
        {
            InitializeComponent();
            _giaoVienBUS = new GiaoVienBUS();
            _namHocBUS = new NamHocBUS();
            _khoiBUS = new KhoiBUS();
            _lopBUS = new LopBUS();
            _isAddButton = true;
            _isDeleteButton = true;
        }

        private void HienThi_DSLop()
        {
            gridControlDSLop.DataSource = _lopBUS.LayDTLop_MaNam_MaKhoi(CboUtil.GetValueItem(comboBoxEditNamHoc),
                                                                        CboUtil.GetValueItem(comboBoxEditKhoi));
            DisableControls(editing: false);
        }

        private void frmLapDSLop_Load(object sender, EventArgs e)
        {
            CboUtil.SetDataSource(comboBoxEditNamHoc,
                                  _namHocBUS.LayDTNamHoc(),
                                  "MaNamHoc", "TenNamHoc", 0);
            CboUtil.SetDataSource(comboBoxEditKhoi,
                                  _khoiBUS.LayDT_Khoi(),
                                  "MaKhoi", "TenKhoi", 0);
            CboUtil.SetDataSource(comboBoxEditGVCN,
                                  _giaoVienBUS.LayDT_DanhSachGiaoVien(),
                                  "MaGiaoVien", "TenGiaoVien", 0);
        }

        private void comboBoxEditNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThi_DSLop();
        }

        private void comboBoxEditKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            textEditTenLop.Properties.Mask.EditMask = CboUtil.GetValueItem(comboBoxEditKhoi)
                                                      + @"[A-H][0-9]{1,2}";
            HienThi_DSLop();
        }

        private void DisableControls(bool editing)
        {
            simpleButtonDong.Enabled = !editing;
            gridControlDSLop.Enabled = !editing;
            //comboBoxEditGVCN.Enabled = is_adding;
            //textEditTenLop.Enabled = is_adding;
            comboBoxEditNamHoc.Enabled = !editing;
            comboBoxEditKhoi.Enabled = !editing;


            _isAddButton = !editing;
            _isDeleteButton = !editing;

            simpleButtonThemMoi.Text = editing ? "Không nhập (Alt+&N)" : "Thêm mới (Alt+&N)";
            simpleButtonXoa.Text = editing ? "Nhập lại (Alt+&D)" : "Xóa (Alt+&D)";

            if (!editing)
            {
                if (gridViewLop.RowCount > 0)
                    gridViewLop_FocusedRowChanged(this,
                                                  new FocusedRowChangedEventArgs(0, 0));
                else
                {
                    textEditMaLop.Text = "";
                    textEditTenLop.Text = "";
                }
            }
        }


        private void ResetControl()
        {
            comboBoxEditGVCN.SelectedIndex = 0;
            textEditTenLop.Text = "";
            textEditMaLop.Text = "";
        }

        private void simpleButtonThemMoi_Click(object sender, EventArgs e)
        {
            if (CboUtil.CheckSelectedNull(comboBoxEditNamHoc))
            {
                MsgboxUtil.Error("Bạn chưa chọn năm học để thêm mới lớp!");
                return;
            }
            if (_isAddButton) // button them moi
            {
                DisableControls(true);
                ResetControl();
            }
            else // button khong nhap
            {
                // Bỏ ẩn control
                DisableControls(false);
            }
        }

        private void gridViewLop_FocusedRowChanged(object sender,
                                                   FocusedRowChangedEventArgs e)
        {
            // Chac chan chon duoc 1 dong nao do
            if (gridViewLop.FocusedRowHandle < 0 || gridViewLop.FocusedRowHandle >= gridViewLop.RowCount) return;
            textEditMaLop.Text = gridViewLop.GetRowCellValue(gridViewLop.FocusedRowHandle, "MaLop").ToString();
            textEditTenLop.Text = gridViewLop.GetRowCellValue(gridViewLop.FocusedRowHandle, "TenLop").ToString();
            CboUtil.SelectedItem(comboBoxEditGVCN,
                                 gridViewLop.GetRowCellValue(gridViewLop.FocusedRowHandle, "MaGiaoVien").ToString()
                );
        }

        private void textEditTenLop_InvalidValue(object sender,
                                                 InvalidValueExceptionEventArgs e)
        {
            string maKhoi = CboUtil.GetValueItem(comboBoxEditKhoi);
            e.ErrorText = "Tên lớp không hợp lệ. Tên lớp có dạng " + maKhoi + "[A-H][0-9][0-9]. VD: " + maKhoi + "B02";
        }

        private void simpleButtonGhiDuLieu_Click(object sender, EventArgs e)
        {
            if (textEditTenLop.Text == "")
            {
                MsgboxUtil.Error("Bạn chưa nhập tên lớp!");
                return;
            }
            if (CboUtil.CheckSelectedNull(comboBoxEditGVCN))
            {
                MsgboxUtil.Error("Bạn chưa chọn GVCN!");
                return;
            }
            var lopDTO = new LopDTO();
            lopDTO.GiaoVien.MaGiaoVien = CboUtil.GetValueItem(comboBoxEditGVCN);

            string tenLop = textEditTenLop.Text;
            string tTenLop = tenLop.Substring(0, 3); // 10A
            int hTenLop = Convert.ToInt32(tenLop.Substring(3, tenLop.Length - 3)); // 1
            tenLop = tTenLop + ((hTenLop < 10) ? "0" + hTenLop.ToString() : hTenLop.ToString()); // 10A01

            lopDTO.MaNamHoc = CboUtil.GetValueItem(comboBoxEditNamHoc);
            lopDTO.MaLop = tenLop + lopDTO.MaNamHoc;
            lopDTO.TenLop = textEditTenLop.Text;
            lopDTO.MaKhoiLop = Convert.ToInt16(CboUtil.GetValueItem(comboBoxEditKhoi));


            if (_lopBUS.KiemTraTonTai_MaLop(lopDTO.MaLop))
            {
                _lopBUS.CapNhat_GiaoVienCN_Lop(lopDTO);
                MsgboxUtil.Success("Đã cập nhật lớp " + lopDTO.TenLop + " thành công!");
            }
            else
            {
                if (_lopBUS.Them_Lop(lopDTO))
                    MsgboxUtil.Success("Đã tạo lớp " + lopDTO.TenLop + " thành công!");
            }
            HienThi_DSLop();
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            if (!_isDeleteButton) // button nhap lai 
            {
                ResetControl();
                return;
            }
            if (_lopBUS.KiemTraTonTai_MaLop(textEditMaLop.Text))
            {
                if (MsgboxUtil.YesNo("Bạn có muốn xóa toàn bộ danh sách học sinh, "
                                     + "bảng điểm học sinh và toàn bộ thông tin liên quan đến lớp " +
                                     textEditTenLop.Text + " hay không?")
                    == DialogResult.No)
                {
                    return;
                }

                _lopBUS.Xoa_Lop(textEditMaLop.Text);
                MsgboxUtil.Success("Đã xóa lớp " + textEditTenLop.Text + " thành công!");
                HienThi_DSLop();
            }
        }

        private void simpleButtonDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // Hiển thị frmNamHoc
            var frmMain = ParentForm as FrmMain;
            if (frmMain != null) frmMain.ShowMdiChildForm<FrmNamHoc>();
        }
    }
}