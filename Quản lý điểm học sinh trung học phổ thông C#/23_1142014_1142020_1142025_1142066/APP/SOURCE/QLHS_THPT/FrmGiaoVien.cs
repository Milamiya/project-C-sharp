using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using QLHS.BUS;
using QLHS.DTO;
using Util;

namespace QLHS
{
    public partial class FrmGiaoVien : XtraForm
    {
        private readonly GiaoVienBUS _giaoVienBUS;
        private int _currentRowEdit;
        private bool _isAddButton;
        private bool _isDeleteButton;

        public FrmGiaoVien()
        {
            InitializeComponent();
            _giaoVienBUS = new GiaoVienBUS();
            _isAddButton = true;
            _isDeleteButton = true;
        }

        private void _Diable_Control(bool isAdding)
        {
            simpleButtonDong.Enabled = !isAdding;
            gridcontrolGiaoVien.Enabled = !isAdding;

            _isAddButton = !isAdding;
            _isDeleteButton = !isAdding;

            simpleButtonThem.Text = isAdding ? "Không nhập (Alt+&N)" : "Thêm mới (Alt+&N)";
            simpleButtonXoa.Text = isAdding ? "Nhập lại (Alt+&D)" : "Xóa (Alt+&D)";
            simpleButtonLuu.Text = isAdding ? "Lưu hồ sơ (Enter)" : "Cập nhật (Enter)";
            if (!isAdding)
            {
                if (gridViewGiaoVien.RowCount > 0)
                {
                    gridViewGiaoVien.FocusedRowHandle = _currentRowEdit;
                    gridViewGiaoVien_FocusedRowChanged(this,
                                                       new FocusedRowChangedEventArgs(0, _currentRowEdit));
                }
                else
                {
                    _Reset_Control();
                }
            }
        }

        private void _Reset_Control()
        {
            textEditMaGiaoVien.Text = "";
            textEditTenGiaoVien.Text = "";
        }

        private void simpleButtonThemGiaoVien_Click(object sender, EventArgs e)
        {
            if (_isAddButton)
            {
                _Diable_Control(isAdding: true);
                _Reset_Control();
            }
            else
            {
                // Bỏ ẩn control
                _Diable_Control(isAdding: false);
            }
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            _Load_GridView();
        }

        private void _Load_GridView()
        {
            gridcontrolGiaoVien.DataSource = _giaoVienBUS.LayDT_DanhSachGiaoVien();
            _Diable_Control(isAdding: false);
        }


        private void simpleButtonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButtonXoaGiaovien_Click(object sender, EventArgs e)
        {
            if (_isDeleteButton)
            {
                if (_giaoVienBUS.KiemTonTai_HoSo_GiaoVien(textEditMaGiaoVien.Text))
                {
                    if (MsgboxUtil.YesNo("Bạn có muốn xóa hồ sơ giáo viên: "
                                         + textEditTenGiaoVien.Text + " hay không?")
                        == DialogResult.No)
                    {
                        return;
                    }

                    _giaoVienBUS.Xoa_HoSo_GiaoVien(textEditMaGiaoVien.Text);
                    MsgboxUtil.Success("Đã xóa hồ sơ giáo viên: "
                                       + textEditTenGiaoVien.Text + " thành công!");
                    _Load_GridView();
                }
            }
            else // reset button
            {
                _Reset_Control();
                return;
            }
        }

        private void simpleButtonLuuGiaoVien_Click(object sender, EventArgs e)
        {
            _currentRowEdit = _isAddButton ? gridViewGiaoVien.FocusedRowHandle : 0;

            if (textEditTenGiaoVien.Text.Length <= 3 || !textEditTenGiaoVien.Text.Contains(" "))
            {
                MsgboxUtil.Error("Tên giáo viên không hợp lệ hoặc nhỏ hơn 3 ký tự!");
                textEditTenGiaoVien.Focus();
                return;
            }

            var giaoVienDTO = new GiaoVienDTO
                                  {
                                      MaGiaoVien = textEditMaGiaoVien.Text,
                                      TenGiaoVien = textEditTenGiaoVien.Text.Replace("'", "''")
                                  };

            // Sửa
            if (_giaoVienBUS.KiemTonTai_HoSo_GiaoVien(giaoVienDTO.MaGiaoVien))
            {
                _giaoVienBUS.CapNhat_HoSo_GiaoVien(giaoVienDTO);
                MsgboxUtil.Success("Đã cập nhật hồ sơ giáo viên: " + giaoVienDTO.TenGiaoVien + " thành công!");
            }
            else // thêm
            {
                if (_giaoVienBUS.Them_HoSo_GiaoVien(giaoVienDTO))
                    MsgboxUtil.Success("Đã tạo hồ sơ giáo viên: " + giaoVienDTO.TenGiaoVien + " thành công!");
            }
            _Load_GridView();
            _Diable_Control(isAdding: false);
        }

        private void gridViewGiaoVien_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            // Chac chan chon duoc 1 dong nao do
            if (gridViewGiaoVien.FocusedRowHandle < 0 || gridViewGiaoVien.FocusedRowHandle >= gridViewGiaoVien.RowCount)
                return;
            textEditMaGiaoVien.Text =
                gridViewGiaoVien.GetRowCellValue(gridViewGiaoVien.FocusedRowHandle, "MaGiaoVien").ToString();
            textEditTenGiaoVien.Text =
                gridViewGiaoVien.GetRowCellValue(gridViewGiaoVien.FocusedRowHandle, "TenGiaoVien").ToString();
        }
    }
}