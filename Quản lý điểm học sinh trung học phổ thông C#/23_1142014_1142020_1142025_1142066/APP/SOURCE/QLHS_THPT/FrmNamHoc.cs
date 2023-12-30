using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using QLHS.BUS;
using QLHS.DTO;
using Util;

namespace QLHS
{
    public partial class FrmNamHoc : XtraForm
    {
        private readonly NamHocBUS _namHocBUS;
        private bool _isAddButton;
        private bool _isDeleteButton;

        public FrmNamHoc()
        {
            InitializeComponent();
            _namHocBUS = new NamHocBUS();
            _isAddButton = true;
            _isDeleteButton = true;
        }

        private void frmNamHoc_Load(object sender, EventArgs e)
        {
            CboUtil.SetDataSource(comboBoxEdit1, _namHocBUS.LayDT_NamHoc_ThemMoi(),
                                  "MaNamHoc", "TenNamHoc", 0);
            _Load_Lai_GridView();
        }

        private void gridView1_FocusedRowChanged(object sender,
                                                 FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0)
                return;
            string maNamHoc = gridViewNamHoc.GetRowCellValue(e.FocusedRowHandle, "MaNamHoc").ToString();
            CboUtil.SelectedItem(comboBoxEdit1, maNamHoc);
        }

        private void _Load_Lai_GridView()
        {
            gridControlNamHoc.DataSource = _namHocBUS.LayDTNamHoc();
            _Disable_Control(editing: false);
        }

        private void _Disable_Control(bool editing)
        {
            _isAddButton = !editing;
            _isDeleteButton = !editing;

            simpleButtonThem.Text = editing ? "Lưu (Enter)" : "Thêm (Enter)";
            simpleButtonXoa.Text = editing ? "Không thêm (Alt+&D)" : "Xóa (Alt+&D)";

            comboBoxEdit1.Enabled = editing;
            gridControlNamHoc.Enabled = !editing;
            if (!editing)
            {
                if (gridViewNamHoc.RowCount > 0)
                    gridView1_FocusedRowChanged(this,
                                                new FocusedRowChangedEventArgs(0, 0));
            }
        }

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            if (_isAddButton)
            {
                _Disable_Control(editing: true);
            }
            else
            {
                var namHocDTO = new NamHocDTO
                                    {
                                        MaNamHoc = CboUtil.GetValueItem(comboBoxEdit1),
                                        TenNamHoc = CboUtil.GetDisplayItem(comboBoxEdit1)
                                    };
                // check & save
                if (_namHocBUS.KiemTraTonTai_NamHoc(namHocDTO.MaNamHoc))
                {
                    MsgboxUtil.Error("Năm học " + namHocDTO.TenNamHoc
                                     + " đã tồn tại. Hãy chọn 1 năm học khác!");
                    return;
                }
                _namHocBUS.Them_NamHoc(namHocDTO);
                MsgboxUtil.Success("Đã tạo năm học mới thành công."
                                   + "\nTiếp theo bạn hãy tạo danh sách lớp cho năm học này!");
                _Load_Lai_GridView();
            }
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            string maNamHoc = CboUtil.GetValueItem(comboBoxEdit1);
            string tenNamHoc = CboUtil.GetDisplayItem(comboBoxEdit1);

            if (_isDeleteButton)
            {
                if (_namHocBUS.KiemTraTonTai_NamHoc(maNamHoc))
                {
                    // xóa
                    if (MsgboxUtil.YesNo("Bạn có chắc chắn muốn xóa năm học"
                                         + tenNamHoc +
                                         " và tất cả hồ sơ: Lớp học, phân lớp, bảng điểm,... liên quan đến năm học này?")
                        == DialogResult.Yes)
                    {
                        _namHocBUS.Xoa_NamHoc(maNamHoc);
                        MsgboxUtil.Success("Đã xóa năm học " + tenNamHoc + " thành công!");
                        _Load_Lai_GridView();
                    }
                }
                else
                {
                    MsgboxUtil.Error("Không tồn tại năm học " + tenNamHoc);
                }
            }
            else // Không thêm
            {
                _Disable_Control(editing: false);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}