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
    public partial class FrmHocSinh : XtraForm
    {
        private readonly HocSinhBUS _hocSinhBUS;
        private readonly KhoiBUS _khoiBUS;
        private readonly LopBUS _lopBUS;
        private readonly NamHocBUS _namHocBUS;
        private readonly PhanLopBUS _phanLopBUS;
        private readonly QuyDinhBUS _quyDinhBUS;
        private int _currentRowEdit;
        private HocSinhDTO _hocSinhDTO;
        private bool _isAddButton;
        private bool _isDeleteButton;

        public FrmHocSinh()
        {
            InitializeComponent();
            _namHocBUS = new NamHocBUS();
            _khoiBUS = new KhoiBUS();
            _lopBUS = new LopBUS();
            _hocSinhBUS = new HocSinhBUS();
            _quyDinhBUS = new QuyDinhBUS();
            _phanLopBUS = new PhanLopBUS();
            _isAddButton = true;
            _isDeleteButton = true;
        }

        // Access from frmSearchHocSinh
        public string MaLop { get; set; }
        public string MaHocSinh { get; set; }

        /// <summary>
        /// Hiển thị lại form học sinh khi có yêu cầu từ form tìm kiếm
        /// </summary>
        public void HienThiLai_FrmHocSinh_TuFormTimKiem()
        {
            if (MaLop != null)
            {
                string maNamHoc = ObjectUtil.LayMaNamHocTuMaLop(MaLop);
                string maKhoi = ObjectUtil.LayMaKhoiLopTuMaLop(MaLop);
                // Chọn lại năm học
                CboUtil.SelectedItem(comboBoxEditNamHoc, maNamHoc);
                // Chọn lại khối
                CboUtil.SelectedItem(comboBoxEditKhoi, maKhoi);
                // Chọn lại lớp
                CboUtil.SelectedItem(comboBoxEditLop, MaLop);
                // Bỏ check Tiếp nhận hồ sơ mới
                checkEditChuaPhanLop.Checked = false;
            }
            else
            {
                checkEditChuaPhanLop.Checked = true;
            }
            // Tìm vị trí học sinh trên GridView có mã là MaHocSinh truyền từ formSearch
            int foundSelectHandler = -1;
            for (int i = 0; i < gridViewDSHocSinh.RowCount; i++)
            {
                if (gridViewDSHocSinh.GetRowCellValue(i, "MaHocSinh").ToString() == MaHocSinh)
                {
                    foundSelectHandler = i;
                    break;
                }
            }
            // Chọn học sinh
            if (foundSelectHandler != -1)
                gridViewDSHocSinh.FocusedRowHandle = foundSelectHandler;
            else
                MsgboxUtil.Error("Không tìm thấy hồ sơ học sinh có mã: " + MaHocSinh);
        }

        /// <summary>
        /// Load lại combobox lớp học theo năm và khối
        /// </summary>
        private void LoadComboboxLopHoc(object sender, EventArgs e)
        {
            CboUtil.SetDataSource(comboBoxEditLop, _lopBUS.LayDTLop_MaNam_MaKhoi(
                CboUtil.GetValueItem(comboBoxEditNamHoc),
                CboUtil.GetValueItem(comboBoxEditKhoi)
                                                       ), "MaLop", "TenLop", 0);
            comboBoxEditLop_SelectedIndexChanged(sender, e);
            HienThiHoSoHocSinh(gridViewDSHocSinh.GetRowCellValue(0, "MaHocSinh"));
        }

        /// <summary>
        /// Hiển thị chi tiết hồ sơ học sinh
        /// </summary>
        /// <param name="maHocSinh"></param>
        private void HienThiHoSoHocSinh(object maHocSinh = null)
        {
            if (maHocSinh == null)
            {
                _hocSinhDTO = new HocSinhDTO();
                panelControlHoSo.Enabled = false;
                _Reset_Control();
            }
            else
            {
                _hocSinhDTO = _hocSinhBUS.LayHoSo_HocSinh(maHocSinh.ToString());
                panelControlHoSo.Enabled = true;
                spinEditSTTSoDiem.Value = _hocSinhDTO.STT;
                dateEditNgaySinh.EditValue = _hocSinhDTO.NgaySinh;
                textEditmaHocSinh.Text = _hocSinhDTO.MaHocSinh;
                textEditTenHocSinh.Text = _hocSinhDTO.TenHocSinh;
                radioGroupGioiTinh.SelectedIndex = _hocSinhDTO.GioiTinh;
                textEditNoiSinh.Text = _hocSinhDTO.NoiSinh;
                textEditDiaChi.Text = _hocSinhDTO.DiaChi;
                textEditEmail.Text = _hocSinhDTO.Email;
            }
        }

        /// <summary>
        /// Ẩn hiện các control cho thao tác thêm/không thêm
        /// </summary>
        /// <param name="isAdding">is_adding: Thêm/Không thêm</param>
        public void _Diable_Control(bool isAdding)
        {
            simpleButtonDong.Enabled = !isAdding;
            gridControlDSHocSinh.Enabled = !isAdding;

            if (!checkEditChuaPhanLop.Checked)
            {
                comboBoxEditNamHoc.Enabled = !isAdding;
                comboBoxEditKhoi.Enabled = !isAdding;
                comboBoxEditLop.Enabled = !isAdding;
                simpleButtonSXLaiSTT.Enabled = !isAdding;
            }
            else
            {
                comboBoxEditNamHoc.Enabled = false;
                comboBoxEditKhoi.Enabled = false;
                comboBoxEditLop.Enabled = false;
                simpleButtonSXLaiSTT.Enabled = false;
            }

            checkEditChuaPhanLop.Enabled = !isAdding;

            _isAddButton = !isAdding;
            _isDeleteButton = !isAdding;

            simpleButtonThemMoi.Text = isAdding ? "Không nhập (Alt+&N)" : "Thêm mới (Alt+&N)";
            simpleButtonXoa.Text = isAdding ? "Nhập lại (Alt+&D)" : "Xóa (Alt+&D)";
            simpleButtonGhiDuLieu.Text = isAdding ? "Lưu hồ sơ (Enter)" : "Cập nhật (Enter)";

            // Mac dinh cac control nay deu duoc bat
            panelControlHoSo.Enabled = true;
            simpleButtonXoa.Enabled = true;
            simpleButtonGhiDuLieu.Enabled = true;

            if (gridViewDSHocSinh.RowCount > 0)
            {
                // Neu khong them moi chon hoc sinh
                if (!isAdding)
                {
                    gridViewDSHocSinh.FocusedRowHandle = _currentRowEdit;
                    gridViewDSHocSinh_FocusedRowChanged(this,
                                                        new FocusedRowChangedEventArgs(
                                                            0, _currentRowEdit));
                }
            }
            else // TH Grid ko co hoc sinh nao
            {
                simpleButtonGhiDuLieu.Enabled = isAdding; // An nut Cap Nhat, Hien nut Luu
                simpleButtonXoa.Enabled = isAdding;
                panelControlHoSo.Enabled = isAdding;
                _Reset_Control();
            }
        }

        /// <summary>
        /// Xóa dữ liệu control, chuẩn bị thêm mới hồ sơ
        /// </summary>
        private void _Reset_Control()
        {
            if (gridViewDSHocSinh.RowCount == 0)
                spinEditSTTSoDiem.Value = 1;
            textEditmaHocSinh.Text = "";
            textEditTenHocSinh.Text = "";
            textEditDiaChi.Text = "";
            textEditEmail.Text = "";
            textEditNoiSinh.Text = "";
            textEditTenHocSinh.Focus();
        }

        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            CboUtil.SetDataSource(comboBoxEditNamHoc, _namHocBUS.LayDTNamHoc(), "MaNamHoc", "TenNamHoc", 0);
            CboUtil.SetDataSource(comboBoxEditKhoi, _khoiBUS.LayDT_Khoi(),
                                  "MaKhoi", "TenKhoi", 0);
        }

        private void comboBoxEditNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboUtil.CheckSelectedNull(comboBoxEditKhoi) ||
                CboUtil.CheckSelectedNull(comboBoxEditNamHoc))
                return;
            LoadComboboxLopHoc(sender, e);
        }

        private void comboBoxEditKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboUtil.CheckSelectedNull(comboBoxEditNamHoc))
                return;
            LoadComboboxLopHoc(sender, e);
        }

        private void comboBoxEditLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboUtil.CheckSelectedNull(comboBoxEditLop))
            {
                gridControlDSHocSinh.DataSource = null;
                return;
            }
            LoadLai_GridControl_HocSinh();
        }

        private void gridViewDSHocSinh_FocusedRowChanged(object sender,
                                                         FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0)
                return;
            object maHocSinh = gridViewDSHocSinh.GetRowCellValue(e.FocusedRowHandle, "MaHocSinh").ToString();
            HienThiHoSoHocSinh(maHocSinh);
        }

        private void simpleButtonDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Load lại GridControl học sinh
        /// </summary>
        private void LoadLai_GridControl_HocSinh(bool chuaPhanLop = false)
        {
            if (chuaPhanLop)
                gridControlDSHocSinh.DataSource = _hocSinhBUS.LayDT_HocSinh("", true);
            else
                gridControlDSHocSinh.DataSource = _hocSinhBUS.LayDT_HocSinh(
                    CboUtil.GetValueItem(comboBoxEditLop)
                    );
            if (gridViewDSHocSinh.RowCount > 0)
            {
                object maHocSinh = gridViewDSHocSinh.GetRowCellValue(0, "MaHocSinh").ToString();
                HienThiHoSoHocSinh(maHocSinh);
            }
            _Diable_Control(isAdding: false);
        }

        private void simpleButtonGhiDuLieu_Click(object sender, EventArgs e)
        {
            _currentRowEdit = _isAddButton ? gridViewDSHocSinh.FocusedRowHandle : 0;

            var hocSinhDTO = new HocSinhDTO
                                 {
                                     NgaySinh = Convert.ToDateTime(dateEditNgaySinh.EditValue),
                                     MaHocSinh = textEditmaHocSinh.Text,
                                     TenHocSinh = textEditTenHocSinh.Text.Replace("'", "''"),
                                     GioiTinh = radioGroupGioiTinh.SelectedIndex,
                                     NoiSinh = textEditNoiSinh.Text.Replace("'", "''"),
                                     DiaChi = textEditDiaChi.Text.Replace("'", "''"),
                                     Email = textEditEmail.Text
                                 };

            string maLop = null;
            // neu co phan lop
            if (!checkEditChuaPhanLop.Checked)
            {
                hocSinhDTO.STT = Convert.ToInt32(spinEditSTTSoDiem.Value);
                maLop = CboUtil.GetValueItem(comboBoxEditLop);
            }
            if (hocSinhDTO.TenHocSinh.Length < 3 || !hocSinhDTO.TenHocSinh.Contains(" "))
            {
                MsgboxUtil.Error("Họ tên học sinh không hợp lệ (không chứa khoảng trắng) hoặc nhỏ hơn 3 ký tự!");
                textEditTenHocSinh.Focus();
                return;
            }
            if (hocSinhDTO.NoiSinh.Length < 3)
            {
                MsgboxUtil.Error("Nơi sinh không hợp lệ (nhỏ hơn 3 ký tự)!");
                textEditNoiSinh.Focus();
                return;
            }
            if (hocSinhDTO.DiaChi.Length < 3)
            {
                MsgboxUtil.Error("Địa chỉ không hợp lệ (nhỏ hơn 3 ký tự)!");
                textEditDiaChi.Focus();
                return;
            }
            try
            {
                _hocSinhBUS.LuuHoSo_HocSinh(hocSinhDTO, maLop);
                MsgboxUtil.Success("Lưu hồ sơ học sinh " + hocSinhDTO.TenHocSinh + " thành công!");
            }
            catch (Exception ex)
            {
                MsgboxUtil.Error(ex);
                return;
            }
            LoadLai_GridControl_HocSinh(checkEditChuaPhanLop.Checked);
            _Diable_Control(isAdding: false);
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            if (!_isDeleteButton)
            {
                _Reset_Control();
                return;
            }

            if (textEditmaHocSinh.Text == "")
            {
                MsgboxUtil.Error("Bạn chưa chọn học sinh để thực hiện xóa!");
                return;
            }
            if (
                MsgboxUtil.YesNo("Bạn có chắc chắn muốn xóa toàn bộ hồ sơ học sinh \"" + textEditTenHocSinh.Text +
                                 "\" hay không?") == DialogResult.No)
            {
                return;
            }
            _hocSinhBUS.Xoa_HoSo_HocSinh(textEditmaHocSinh.Text);
            MsgboxUtil.Success("Xóa hồ sơ học sinh thành công!");
            LoadLai_GridControl_HocSinh(checkEditChuaPhanLop.Checked);
        }

        private void simpleButtonThemMoi_Click(object sender, EventArgs e)
        {
            // Không thêm
            if (!_isAddButton)
            {
                _Diable_Control(isAdding: false);
                return;
            }
            // Thêm

            // Neu co phan lop
            if (!checkEditChuaPhanLop.Checked)
            {
                string maNamHocHT = _quyDinhBUS.LayMaNamHoc_HienTai();
                string maNamHoc = CboUtil.GetValueItem(comboBoxEditNamHoc);
                string tenNamHT = _namHocBUS.LayTenNamHoc_MaNamHoc(maNamHocHT);

                if (maNamHoc != maNamHocHT)
                {
                    if (MsgboxUtil.YesNo("Chương trình chỉ được phép tiếp nhận học sinh trong năm " + tenNamHT
                                         + "\nĐể thực hiện chức năng này, bạn có muốn di chuyển đến năm " +
                                         tenNamHT + " hay không?")
                        == DialogResult.Yes)
                    {
                        string maKhoiHT = CboUtil.GetValueItem(comboBoxEditKhoi);
                        CboUtil.SelectedItem(comboBoxEditNamHoc, maNamHocHT);
                        CboUtil.SelectedItem(comboBoxEditKhoi, maKhoiHT);
                        MsgboxUtil.Info("Đã chuyển đến năm " + tenNamHT
                                        + ", bạn hãy chọn lớp để thực hiện tiếp nhận hồ sơ mới!");
                    }

                    return;
                }

                string maLop = (CboUtil.GetValueItem(comboBoxEditLop));
                int siSoCanTren = _quyDinhBUS.LaySiSo_CanTren();
                if (_phanLopBUS.Dem_SiSo_Lop(maLop) >= siSoCanTren)
                {
                    MsgboxUtil.Error("Lớp " + CboUtil.GetDisplayItem(comboBoxEditLop)
                                     + " đã đủ học sinh theo quy định "
                                     + " (" + siSoCanTren + " học sinh / 1 lớp)!");
                    return;
                }
                spinEditSTTSoDiem.Value = _phanLopBUS.LaySTT_TiepTheo(maLop);
            }
            _Diable_Control(isAdding: true);
            _Reset_Control();
        }

        private void dateEditNgaySinh_InvalidValue(object sender,
                                                   InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = "Ngày sinh không hợp lệ";
        }

        private void textEditEmail_InvalidValue(object sender,
                                                InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = "Email không hợp lệ! (Ấn ESC để trở lại)";
        }

        private void simpleButtonSXLaiSTT_Click(object sender, EventArgs e)
        {
            if (checkEditChuaPhanLop.Checked)
            {
                MsgboxUtil.Error("Danh sách hiện tại chưa được phân lớp nên không thể sắp xếp STT!");
                return;
            }
            if (CboUtil.CheckSelectedNull(comboBoxEditLop))
            {
                MsgboxUtil.Error("Bạn chưa chọn lớp để thực hiện");
                return;
            }
            _phanLopBUS.CapNhapSTT_HocSinh_Lop(CboUtil.GetValueItem(comboBoxEditLop));
            MsgboxUtil.Success("Cập nhật số thự tự cho lớp thành công!");
            // Load lại gridcontrol học sinh
            LoadLai_GridControl_HocSinh();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxEditNamHoc.Enabled = !checkEditChuaPhanLop.Checked;
            comboBoxEditKhoi.Enabled = !checkEditChuaPhanLop.Checked;
            comboBoxEditLop.Enabled = !checkEditChuaPhanLop.Checked;
            spinEditSTTSoDiem.Enabled = !checkEditChuaPhanLop.Checked;
            LoadLai_GridControl_HocSinh(checkEditChuaPhanLop.Checked);
        }
    }
}