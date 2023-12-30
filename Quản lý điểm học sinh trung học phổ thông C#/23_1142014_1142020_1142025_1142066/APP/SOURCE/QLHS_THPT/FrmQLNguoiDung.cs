using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using QLHS.BUS;
using QLHS.DTO;
using Util;

namespace QLHS
{
    public partial class FrmQLNguoiDung : XtraForm
    {
        private readonly GiaoVienBUS _giaoVienBUS;
        private readonly LoaiNguoiDungBUS _loaiNguoiDungBUS;
        private readonly NguoiDungBUS _nguoiDungBUS;
        private int _currentRowEdit;
        private bool _isAddButton;
        private bool _isDeleteButton;

        public FrmQLNguoiDung()
        {
            InitializeComponent();
            _nguoiDungBUS = new NguoiDungBUS();
            _giaoVienBUS = new GiaoVienBUS();
            _loaiNguoiDungBUS = new LoaiNguoiDungBUS();
            _isAddButton = _isDeleteButton = true;
        }

        private void frmQLNguoiDung_Load(object sender, EventArgs e)
        {
            CboUtil.SetDataSource(comboBoxEditNguoiDung, _giaoVienBUS.LayDT_DanhSachGiaoVien(),
                                  "MaGiaoVien", "TenGiaoVien", 0);
            CboUtil.SetDataSource(comboBoxEditQuyenSuDung, _loaiNguoiDungBUS.LayDT_LoaiNguoiDung(),
                                  "MaLoaiND", "TenLoaiND", 0);
            // load gridview
            _Load_Lai_Gridview();
        }

        private void _Load_Lai_Gridview(int row = 0)
        {
            gridControlNguoiDung.DataSource = _nguoiDungBUS.LayDT_NguoiDung();
            if (gridViewNguoiDung.RowCount > 0)
            {
                gridViewNguoiDung_FocusedRowChanged(this,
                                                    new FocusedRowChangedEventArgs(0, row));
                gridViewNguoiDung.FocusedRowHandle = row;
            }
            else
            {
                _Reset_Control();
            }
        }

        private void _Reset_Control()
        {
            comboBoxEditNguoiDung.SelectedIndex = 0;
            textEditMatKhau.Text = "";
            textEdittenTruyCap.Text = "";
            radioGroupTrangThai.SelectedIndex = 1;
        }

        public void _Disable_Controls(bool editing)
        {
            simpleButtonDong.Enabled = !editing;
            gridControlNguoiDung.Enabled = !editing;
            comboBoxEditNguoiDung.Enabled = editing;

            _isAddButton = !editing;
            _isDeleteButton = !editing;

            if (editing)
            {
                simpleButtonThemMoi.Text = @"Không nhập (Alt+&N)";
                simpleButtonXoa.Text = @"Nhập lại (Alt+&D)";
            }
            else
            {
                simpleButtonThemMoi.Text = @"Thêm mới (Alt+&N)";
                simpleButtonXoa.Text = @"Xóa (Alt+&D)";
            }
            if (!editing)
            {
                if (gridViewNguoiDung.RowCount > 0)
                    gridViewNguoiDung_FocusedRowChanged(this,
                                                        new FocusedRowChangedEventArgs(
                                                            0, 0));
                else
                {
                    _Reset_Control();
                }
            }
        }

        private void simpleButtonThemMoi_Click(object sender, EventArgs e)
        {
            if (_isAddButton)
            {
                _Disable_Controls(true);
                _Reset_Control();
            }
            else
            {
                // Bỏ ẩn control
                _Disable_Controls(false);
            }
        }

        private void simpleButtonGhi_Click(object sender, EventArgs e)
        {
            if (CboUtil.CheckSelectedNull(comboBoxEditNguoiDung)
                || CboUtil.CheckSelectedNull(comboBoxEditQuyenSuDung))

            {
                MsgboxUtil.Error("Bạn chưa chọn người dùng hoặc chưa có giáo viên nào trong danh sách!");
                return;
            }
            if (textEdittenTruyCap.Text == "")
            {
                MsgboxUtil.Error("Bạn chưa nhập tên đăng nhập");
                return;
            }
            if (!_isAddButton &&
                _nguoiDungBUS.KiemTraTonTai_TaiKhoan(textEdittenTruyCap.Text.Replace("'", "''").Trim()))
            {
                MsgboxUtil.Error("Tài khoản: " + textEdittenTruyCap.Text + " đã tồn tại. Hãy chọn tài khoản khác!");
                return;
            }


            bool checkExistsUser = _nguoiDungBUS.KiemTraTonTai_NguoiDung(
                CboUtil.GetValueItem(comboBoxEditNguoiDung));

            // không tồn tại và mk rỗng
            if (!checkExistsUser && textEditMatKhau.Text == "")
            {
                MsgboxUtil.Error("Bạn chưa nhập mật khẩu!");
                return;
            }
            // nếu đang thêm
            if (!_isAddButton)
            {
                if (checkExistsUser)
                {
                    if (MsgboxUtil.YesNo("Giáo viên: " + CboUtil.GetDisplayItem(comboBoxEditNguoiDung)
                                         +
                                         " đã được tạo tài khoản.\nBạn có muốn cập nhật lại thông tin tài khoản cho giáo viên này?")
                        == DialogResult.No
                        )
                        return;
                }
            }

            // Lay tt nguoi dung
            var user = new NguoiDungDTO();
            user.MaND = CboUtil.GetValueItem(comboBoxEditNguoiDung);
            user.LoaiNguoiDung.MaLoai = CboUtil.GetValueItem(comboBoxEditQuyenSuDung);
            user.TenDNhap = textEdittenTruyCap.Text.Replace("'", "''");
            user.MatKhau = (textEditMatKhau.Text == "") ? "" : textEditMatKhau.Text.Replace("'", "''");
            user.TrangThai = radioGroupTrangThai.SelectedIndex;
            // Check nguoi dung ton tai hay chua
            if (!checkExistsUser)
            {
                // thêm
                if (_nguoiDungBUS.Them_NguoiDung(user))
                {
                    MsgboxUtil.Success("Thêm thành công user: " +
                                       CboUtil.GetDisplayItem(comboBoxEditNguoiDung) + " !");
                }
                _Load_Lai_Gridview();
            }
            else
            {
                _currentRowEdit = gridViewNguoiDung.FocusedRowHandle;
                // Sửa
                if (_nguoiDungBUS.Sua_NguoiDung(user))
                {
                    MsgboxUtil.Success("Sửa thành công user: " + CboUtil.GetDisplayItem(comboBoxEditNguoiDung) +
                                       " !");
                }
                _Load_Lai_Gridview(_currentRowEdit);
            }
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            if (_isDeleteButton)
            {
                if (!_nguoiDungBUS.KiemTraTonTai_NguoiDung(CboUtil.GetValueItem(comboBoxEditNguoiDung)))
                {
                    _Reset_Control();
                    return;
                }
                string tenNguoiDung = CboUtil.GetDisplayItem(comboBoxEditNguoiDung);
                if (MsgboxUtil.YesNo("Bạn có muốn xóa người dùng "
                                     + tenNguoiDung + " hay không?") == DialogResult.Yes)
                {
                    if (_nguoiDungBUS.Xoa_NguoiDung(CboUtil.GetValueItem(comboBoxEditNguoiDung)))
                    {
                        MsgboxUtil.Success("Xóa người dùng "
                                           + tenNguoiDung + " thành công!");
                        gridControlNguoiDung.DataSource = _nguoiDungBUS.LayDT_NguoiDung();
                        return;
                    }
                }
            }
            else
            {
                _Reset_Control();
                return;
            }
        }

        private void simpleButtonDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridViewNguoiDung_FocusedRowChanged(object sender,
                                                         FocusedRowChangedEventArgs e)
        {
            // Chac chan chon duoc 1 dong nao do
            if (gridViewNguoiDung.FocusedRowHandle < 0 ||
                gridViewNguoiDung.FocusedRowHandle >= gridViewNguoiDung.RowCount)
                return;
            textEdittenTruyCap.Text = gridViewNguoiDung.GetRowCellValue(e.FocusedRowHandle, "TenDNhap").ToString();
            CboUtil.SelectedItem(comboBoxEditNguoiDung,
                                 gridViewNguoiDung.GetRowCellValue(e.FocusedRowHandle, "MaND").ToString());
            CboUtil.SelectedItem(comboBoxEditQuyenSuDung,
                                 gridViewNguoiDung.GetRowCellValue(e.FocusedRowHandle, "MaLoaiND").ToString());
            radioGroupTrangThai.SelectedIndex =
                (bool) gridViewNguoiDung.GetRowCellValue(e.FocusedRowHandle, "TrangThai") ? 1 : 0;
            textEditMatKhau.Text = "";
        }
    }
}