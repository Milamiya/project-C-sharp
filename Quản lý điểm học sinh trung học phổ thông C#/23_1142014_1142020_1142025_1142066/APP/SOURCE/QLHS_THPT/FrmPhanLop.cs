using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using QLHS.BUS;
using QLHS.DTO;
using Util;

namespace QLHS
{
    public partial class FrmPhanLop : XtraForm
    {
        private readonly ChuyenLopBUS _chuyenLopBUS;
        private readonly HocSinhBUS _hocSinhBUS;
        private readonly KhoiBUS _khoiBUS;
        private readonly LopBUS _lopBUS;
        private readonly string _maNamHocHienTai;
        private readonly NamHocBUS _namHocBUS;
        private readonly PhanLopBUS _phanLopBUS;
        private readonly QuyDinhBUS _quyDinhBUS;

        public FrmPhanLop()
        {
            InitializeComponent();
            _namHocBUS = new NamHocBUS();
            _khoiBUS = new KhoiBUS();
            _lopBUS = new LopBUS();
            _hocSinhBUS = new HocSinhBUS();
            _phanLopBUS = new PhanLopBUS();
            _quyDinhBUS = new QuyDinhBUS();
            _chuyenLopBUS = new ChuyenLopBUS();
            _maNamHocHienTai = _quyDinhBUS.LayMaNamHoc_HienTai();
        }


        private void _Show_Control(YeuCau yc)
        {
            // Disable all control
            dateEditTu.Enabled = false;
            dateEditDen.Enabled = false;
            simpleButtonLayHSo.Enabled = false;

            checkEditChuyenBangDiem.Enabled = false;
            textEditLyDoChuyen.Enabled = false;

            groupControlLopCu.Enabled = true;

            simpleButtonXoaPL.Enabled = true;
            simpleButtonChuyenTatCa.Enabled = true;
            //hiển thị control bị ẩn khi gặp lỗi
            if (gridControlDSHocSinh.Enabled == false)
            {
                groupControlLopCu.Enabled = true;
                groupControlLopMoi.Enabled = true;
                gridControlDSHocSinh.Enabled = true;
                gridControlDSHocSinhMoi.Enabled = true;
            }
            // Show control
            if (yc == YeuCau.PhanLopHoSoChuaPhanLop)
            {
                dateEditTu.Enabled = true;
                dateEditDen.Enabled = true;
                simpleButtonLayHSo.Enabled = true;
                groupControlLopCu.Enabled = false;
            }
            else if (yc == YeuCau.PhanLopHoSoNamCu)
            {
            }
            else if (yc == YeuCau.ChuyenLopCungKhoi)
            {
                checkEditChuyenBangDiem.Enabled = true;
                textEditLyDoChuyen.Enabled = true;
                simpleButtonXoaPL.Enabled = false;
                simpleButtonChuyenTatCa.Enabled = false;
            }
        }

        private void _LoadGridcontrolDSHocSinhMoi()
        {
            gridControlDSHocSinhMoi.DataSource = _hocSinhBUS.LayDT_HocSinh(
                CboUtil.GetValueItem(comboBoxEditLopMoi)
                );
        }

        private void _LoadGridcontrolDSHocSinh()
        {
            // Chưa phân lớp
            if (radioButtonPhanLopHoSo_ChuaPhanLop.Checked)
            {
                gridControlDSHocSinh.DataSource = _hocSinhBUS.LayDT_HocSinh_ChuaPhanLop(
                    Convert.ToDateTime(dateEditTu.EditValue),
                    Convert.ToDateTime(dateEditDen.EditValue)
                    );
            }
                // phân lớp từ năm cũ || chuyển lớp cùng khối
            else if (radioButtonPhanLopHocSinh_NamTruoc.Checked ||
                     radioButtonChuyenLopCungKhoi.Checked)
            {
                gridControlDSHocSinh.DataSource = _hocSinhBUS.LayDT_HocSinh(
                    CboUtil.GetValueItem(comboBoxEditLop)
                    );
            }
        }

        private bool _KiemTraCbThongTinLopCu()
        {
            bool flag = true;
            if (CboUtil.CheckSelectedNull(comboBoxEditNamHoc))
            {
                MsgboxUtil.Error("Không có năm học sau năm học hiện tại, bạn hãy chọn chức năng khác");
                flag = false;
            }
            if (CboUtil.CheckSelectedNull(comboBoxEditKhoi))
            {
                if (flag)
                {
                    MsgboxUtil.Error("Năm học này không tồn tại lớp học");
                    flag = false;
                }
            }
            if (flag == false)
            {
                groupControlLopCu.Enabled = false;
                groupControlLopMoi.Enabled = false;
                gridControlDSHocSinh.Enabled = false;
                gridControlDSHocSinhMoi.Enabled = false;
            }
            return flag;
        }

        private bool _KiemTraKhoiLop_ChuyenLop(string maNamHoc)
        {
            return _khoiBUS.LayDT_Khoi(maNamHoc).Rows.Count > 0;
        }

        private void _Load_Form()
        {
            simpleButtonPhanLop.Enabled = false;
            simpleButtonXoaPL.Enabled = false;
            simpleButtonChuyenTatCa.Enabled = false;
        }

        private void comboBoxEditNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboUtil.CheckSelectedNull(comboBoxEditNamHoc))
            {
                return;
            }
            CboUtil.SetDataSource(comboBoxEditKhoi, _khoiBUS.LayDT_Khoi(
                CboUtil.GetValueItem(comboBoxEditNamHoc)), "MaKhoi", "TenKHoi", 0);
        }

        private void LoadComboboxLopHoc(object sender, EventArgs e)
        {
            CboUtil.SetDataSource(comboBoxEditLop, _lopBUS.LayDTLop_MaNam_MaKhoi(
                CboUtil.GetValueItem(comboBoxEditNamHoc),
                CboUtil.GetValueItem(comboBoxEditKhoi)
                                                       ), "MaLop", "TenLop", 0);

            comboBoxEditLop_SelectedIndexChanged(sender, e);
        }

        private void loadComboboxLopHoc_Moi()
        {
            if (radioButtonChuyenLopCungKhoi.Checked)
            {
                CboUtil.SetDataSource(comboBoxEditLopMoi, _phanLopBUS.LayDTLop_MaNam_MaKhoi_KhacMaLop(
                    CboUtil.GetValueItem(comboBoxEditNamHocMoi),
                    CboUtil.GetValueItem(comboBoxEditKhoiMoi),
                    CboUtil.GetValueItem(comboBoxEditLop)), "MaLop", "TenLop", 0);
            }
            else
            {
                CboUtil.SetDataSource(comboBoxEditLopMoi, _lopBUS.LayDTLop_MaNam_MaKhoi(
                    CboUtil.GetValueItem(comboBoxEditNamHocMoi),
                    CboUtil.GetValueItem(comboBoxEditKhoiMoi)), "MaLop", "TenLop", 0);
            }
        }

        private void comboBoxEditLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboUtil.CheckSelectedNull(comboBoxEditLop))
            {
                gridControlDSHocSinh.DataSource = null;
                return;
            }
            _LoadGridcontrolDSHocSinh();
            if (radioButtonChuyenLopCungKhoi.Checked)
            {
                loadComboboxLopHoc_Moi();
            }
        }

        private void comboBoxEditKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboUtil.CheckSelectedNull(comboBoxEditNamHoc) || CboUtil.CheckSelectedNull(comboBoxEditKhoi))
                return;
            LoadComboboxLopHoc(sender, e);
            if (radioButtonChuyenLopCungKhoi.Checked)
            {
                CboUtil.SetDataSource(comboBoxEditKhoiMoi,
                                      _khoiBUS.LayDT_Khoi_ChuyenLop(CboUtil.GetValueItem(comboBoxEditNamHocMoi),
                                                                    CboUtil.GetValueItem(comboBoxEditKhoi)), "MaKhoi",
                                      "TenKhoi", 0);
            }
            else
            {
                CboUtil.SetDataSource(
                    comboBoxEditKhoiMoi, _khoiBUS.LayDT_Khoi_PhanLop(CboUtil.GetValueItem(comboBoxEditKhoi)), "MaKhoi",
                    "TenKhoi", 0);
            }
        }

        private void frmChuyenLop_Load(object sender, EventArgs e)
        {
            string tb = "";
            if (_namHocBUS.LayDT_NamHocHienTai().Rows.Count > 0)
            {
                if (_KiemTraKhoiLop_ChuyenLop(_maNamHocHienTai))
                {
                    _Load_Form();
                }
                else
                    tb = tb + "Chưa có lớp trong năm học, bạn hãy tạo lớp trước khi sử dụng chức năng này";
            }
            else
            {
                tb = tb +
                     "Trong dữ liệu chưa có năm học = năm học hiện tại trong quy định, bạn hãy tạo năm học trước khi sử dụng chức năng này";
            }
            if (tb != "")
            {
                MsgboxUtil.Error(tb);
                groupControlLopCu.Enabled = false;
                groupControlLopMoi.Enabled = false;
                gridControlDSHocSinh.Enabled = false;
                gridControlDSHocSinhMoi.Enabled = false;
                groupBoxPhanLop.Enabled = false;
                radioButtonPhanLopHoSo_ChuaPhanLop.Checked = false;
                return;
            }
            // khoi tao 2 input datetime từ và đến
            var dateTu = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 1);
            dateEditTu.Properties.MaxValue = DateTime.Now;
            dateEditDen.Properties.MaxValue = DateTime.Now;
            dateEditTu.EditValue = dateTu;
            dateEditDen.EditValue = DateTime.Now;
            radioButtonPhanLopHocSinhMoi_CheckedChanged(this, new EventArgs());
        }

        private void comboBoxEditLopMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboUtil.CheckSelectedNull(comboBoxEditLopMoi))
            {
                gridControlDSHocSinhMoi.DataSource = null;
                return;
            }
            _LoadGridcontrolDSHocSinhMoi();
        }

        private void comboBoxEditNamHocMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButtonPhanLopHoSo_ChuaPhanLop.Checked)
            {
                CboUtil.SetDataSource(comboBoxEditKhoiMoi,
                                      _khoiBUS.LayDT_Khoi10(CboUtil.GetValueItem(comboBoxEditNamHocMoi)),
                                      "MaKhoi", "TenKHoi", 0);
            }
            if (radioButtonChuyenLopCungKhoi.Checked)
            {
                CboUtil.SetDataSource(comboBoxEditKhoiMoi,
                                      _khoiBUS.LayDT_Khoi_ChuyenLop(CboUtil.GetValueItem(comboBoxEditNamHocMoi),
                                                                    CboUtil.GetValueItem(comboBoxEditKhoi)), "MaKhoi",
                                      "TenKhoi", 0);
            }
            if (radioButtonPhanLopHocSinh_NamTruoc.Checked)
                CboUtil.SetDataSource(comboBoxEditKhoiMoi,
                                      _khoiBUS.LayDT_Khoi_PhanLop(CboUtil.GetValueItem(comboBoxEditKhoi)), "MaKhoi",
                                      "TenKhoi", 0);
        }

        private void comboBoxEditKhoiMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadComboboxLopHoc_Moi();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridViewDSHocSinh_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0)
                return;
        }

        private void simpleButtonChuyenLop_Click(object sender, EventArgs e)
        {
            if (!_KiemTra_LopMoi_DaChon())
            {
                return;
            }

            var dsHocSinhChon = new Dictionary<string, string>();
            for (int i = 0; i < gridViewDSHocSinh.RowCount; i++)
            {
                if (Convert.ToBoolean(gridViewDSHocSinh.GetRowCellValue(i, "Check")))
                {
                    dsHocSinhChon.Add(gridViewDSHocSinh.GetRowCellValue(i, "MaHocSinh").ToString(),
                                      gridViewDSHocSinh.GetRowCellValue(i, "TenHocSinh").ToString());
                }
            }
            if (dsHocSinhChon.Count == 0)
            {
                MsgboxUtil.Error("Bạn chưa chọn học sinh để chuyển!");
                return;
            }

            int siSoToiDa = _quyDinhBUS.LaySiSo_CanTren();


            // Chuyển cùng khối, chuyển và xóa hồ sơ cũ
            int siSoLopMoi;
            if (radioButtonChuyenLopCungKhoi.Checked)
            {
                string maLop = CboUtil.GetValueItem(comboBoxEditLop),
                       tenLop = CboUtil.GetDisplayItem(comboBoxEditLop),
                       maLopMoi = CboUtil.GetValueItem(comboBoxEditLopMoi),
                       tenLopMoi = CboUtil.GetDisplayItem(comboBoxEditLopMoi);

                siSoLopMoi = _phanLopBUS.Dem_SiSo_Lop(maLopMoi);
                if (siSoLopMoi >= siSoToiDa)
                {
                    MsgboxUtil.Error("Không thể thực hiện vì lớp " +
                                     tenLopMoi + " (" + siSoLopMoi + " hs) đã đủ sỉ số học sinh quy định (" + siSoToiDa +
                                     " hs/Lớp)!");
                    return;
                }

                var chuyenLopDTO = new ChuyenLopDTO();
                chuyenLopDTO.TuLop = maLop;
                chuyenLopDTO.DenLop = maLopMoi;
                chuyenLopDTO.NgayChuyen = DateTime.Now;
                chuyenLopDTO.LyDoChuyen = textEditLyDoChuyen.Text.Replace("'", "''");
                chuyenLopDTO.GiuLaiBangDiem = checkEditChuyenBangDiem.Checked;


                if (_chuyenLopBUS.ChuyenLop_HocSinh_Lop(dsHocSinhChon, chuyenLopDTO))
                {
                    MsgboxUtil.Success("Đã chuyển toàn bộ hồ sơ học sinh từ lớp "
                                       + tenLop + " sang lớp " + tenLopMoi + " thành công!");
                }
                else
                {
                    MsgboxUtil.Info("Có lỗi trong quá trình chuyển!");
                }
            }
            else // phân lớp 
            {
                string maLopMoi = CboUtil.GetValueItem(comboBoxEditLopMoi),
                       tenLopMoi = CboUtil.GetDisplayItem(comboBoxEditLopMoi),
                       tenNamHocMoi = CboUtil.GetDisplayItem(comboBoxEditNamHocMoi),
                       tenKhoiMoi = CboUtil.GetDisplayItem(comboBoxEditKhoiMoi);


                siSoLopMoi = _phanLopBUS.Dem_SiSo_Lop(maLopMoi);
                int siSoDSChuyen = dsHocSinhChon.Count;
                if ((siSoDSChuyen + siSoLopMoi) >= siSoToiDa)
                {
                    MsgboxUtil.Error("Không thể thực hiện vì sau khi chuyển học sinh đến lớp " +
                                     tenLopMoi + " (" + siSoLopMoi + " hs) sẽ vượt quá quy định (" + siSoToiDa + ")!");
                    return;
                }

                if (MsgboxUtil.YesNo(
                    "Lưu ý: Các học sinh đã chọn nếu đã được phân lớp vào " + tenKhoiMoi
                    + " trong năm học " + tenNamHocMoi
                    + " sẽ được giữ nguyên hồ sơ.\nChương trình chỉ chuyển những học sinh chưa được phân lớp vào " +
                    tenKhoiMoi + " năm này."
                    + "\n\nBạn có muốn chuyển các học sinh đã chọn"
                    + " sang lớp: " + tenLopMoi + " năm học: " + tenNamHocMoi + " hay không?") == DialogResult.No)
                {
                    return;
                }
                List<PhanLopDTO> dsHsTonTai;
                if (_phanLopBUS.PhanLop_DSHocSinh_Lop(dsHocSinhChon, maLopMoi, out dsHsTonTai)
                    && dsHsTonTai.Count == 0)
                {
                    MsgboxUtil.Success("Đã phân lớp danh sách học sinh đến lớp mới: " + tenLopMoi + ".");
                }
                else
                {
                    string dsHocsinhTonTai = "";
                    foreach (PhanLopDTO item in dsHsTonTai)
                    {
                        dsHocsinhTonTai = "\n" + item.STT + ". "
                                          + item.TenHocSinh + " (" + item.MaHocSinh + ") lớp: " + item.TenLop
                                          + dsHocsinhTonTai;
                    }
                    MsgboxUtil.Info("Các học sinh sau đã tồn tại trong năm " + tenNamHocMoi + ":"
                                    + dsHocsinhTonTai);
                }
            }
            // Cập nhật lại danh sách lớp mới
            comboBoxEditLopMoi_SelectedIndexChanged(sender, e);
            _LoadGridcontrolDSHocSinh();
            _LoadGridcontrolDSHocSinhMoi();
            // Cập nhật lại danh sách lớp cũ
            if (radioButtonPhanLopHoSo_ChuaPhanLop.Checked || radioButtonChuyenLopCungKhoi.Checked)
            {
                _LoadGridcontrolDSHocSinh();
            }

            _HienThi_Button();
        }

        private void gridViewDSHocSinhMoi_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0)
                return;
        }

        private void simpleButtonXoaPLMoi_Click(object sender, EventArgs e)
        {
            if (!_KiemTra_LopMoi_DaChon())
            {
                return;
            }

            string maLopMoi = CboUtil.GetValueItem(comboBoxEditLopMoi),
                   tenLopMoi = CboUtil.GetDisplayItem(comboBoxEditLopMoi),
                   tenNamHocMoi = CboUtil.GetDisplayItem(comboBoxEditNamHocMoi);

            var dsHocSinhChon = new Dictionary<string, string>();
            for (int i = 0; i < gridViewDSHocSinhMoi.RowCount; i++)
            {
                if (Convert.ToBoolean(gridViewDSHocSinhMoi.GetRowCellValue(i, "Check")))
                {
                    dsHocSinhChon.Add(gridViewDSHocSinhMoi.GetRowCellValue(i, "MaHocSinh").ToString(),
                                      gridViewDSHocSinhMoi.GetRowCellValue(i, "TenHocSinh").ToString());
                }
            }
            if (dsHocSinhChon.Count == 0)
            {
                MsgboxUtil.Error("Bạn chưa chọn học sinh để xóa!");
                return;
            }

            if (radioButtonPhanLopHoSo_ChuaPhanLop.Checked || radioButtonPhanLopHocSinh_NamTruoc.Checked)
            {
                if (MsgboxUtil.YesNo("Bạn có muốn xóa các hồ sơ học sinh đã chọn thuộc lớp " + maLopMoi
                                     + " năm học " + tenNamHocMoi + " hay không?")
                    == DialogResult.No)
                {
                    return;
                }

                if (_phanLopBUS.Xoa_DSHocSinh_Lop(dsHocSinhChon, maLopMoi))
                {
                    MsgboxUtil.Success("Đã xóa các hồ sơ trong lớp: " + tenLopMoi + " thành công!");
                }
                else
                {
                    MsgboxUtil.Info("Không có hồ sơ học sinh nào được xóa!");
                }

                _LoadGridcontrolDSHocSinhMoi();

                if (radioButtonPhanLopHoSo_ChuaPhanLop.Checked)
                {
                    _LoadGridcontrolDSHocSinh();
                }
            }
            _HienThi_Button();
        }


        private void gridViewDSHocSinh_MouseEnter(object sender, EventArgs e)
        {
            simpleButtonChuyenTatCa.Enabled = true;
            simpleButtonPhanLop.Enabled = true;
            simpleButtonXoaPL.Enabled = false;
            _HienThi_Button();
        }

        private void gridViewDSHocSinhMoi_MouseEnter(object sender, EventArgs e)
        {
            simpleButtonPhanLop.Enabled = false;
            simpleButtonChuyenTatCa.Enabled = false;
            simpleButtonXoaPL.Enabled = !radioButtonChuyenLopCungKhoi.Checked;
            _HienThi_Button();
        }

        private void _HienThi_Button()
        {
            if (gridViewDSHocSinh.RowCount == 0)
            {
                simpleButtonPhanLop.Enabled = false;
                simpleButtonChuyenTatCa.Enabled = false;
            }
            if (gridViewDSHocSinhMoi.RowCount == 0)
            {
                simpleButtonXoaPL.Enabled = false;
                if (gridViewDSHocSinh.RowCount > 0)
                {
                    simpleButtonXoaPL.Enabled = !radioButtonChuyenLopCungKhoi.Checked;
                }
            }
        }

        public bool _KiemTra_LopMoi_DaChon()
        {
            if (CboUtil.CheckSelectedNull(comboBoxEditLopMoi))
            {
                MsgboxUtil.Error(
                    "Chưa có lớp trong năm học này, hoặc khối chỉ tồn tại 1 lớp, bạn cần phải tạo lớp trước khi muốn chuyển");
                return false;
            }
            return true;
        }


        private void simpleButtonChuyenHet_Click(object sender, EventArgs e)
        {
            // Chọn tất cả các hs bên trái
            chonTatCaToolStripMenuItem_Click(this, new EventArgs());
            // phân lớp
            simpleButtonChuyenLop_Click(this, new EventArgs());
        }

        private void radioButtonChuyenLop_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonChuyenLopCungKhoi.Checked)
            {
                _Show_Control(YeuCau.ChuyenLopCungKhoi);
            }
            // Load combobox 2 bên chuyển lớp
            CboUtil.SetDataSource(comboBoxEditNamHoc, _namHocBUS.LayDT_NamHocHienTai(), "MaNamHoc", "TenNamHoc", 0);
            CboUtil.SetDataSource(comboBoxEditNamHocMoi, _namHocBUS.LayDT_NamHocHienTai(), "MaNamHoc", "TenNamHoc", 0);
        }

        private void radioButtonPhanLopHocSinhMoi_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPhanLopHoSo_ChuaPhanLop.Checked)
            {
                _Show_Control(YeuCau.PhanLopHoSoChuaPhanLop);
            }
            CboUtil.SetDataSource(comboBoxEditNamHocMoi,
                                  _namHocBUS.LayDT_NamHocHienTai(), "MaNamHoc", "TenNamHoc", 0);

            _LoadGridcontrolDSHocSinh();
        }

        private void radioButtonPhanLopHocSinhCu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPhanLopHocSinh_NamTruoc.Checked)
            {
                _Show_Control(YeuCau.PhanLopHoSoNamCu);

                // Load năm học trước
                CboUtil.SetDataSource(comboBoxEditNamHoc, _namHocBUS.LayDT_NamHocTruoc(), "MaNamHoc", "TenNamHoc", 0);

                if (_KiemTraCbThongTinLopCu())
                {
                    CboUtil.SetDataSource(comboBoxEditNamHocMoi,
                                          _namHocBUS.LayDT_NamHocHienTai(), "MaNamHoc", "TenNamHoc", 0);
                }
            }
        }

        private void simpleButtonLayHSo_Click(object sender, EventArgs e)
        {
            _LoadGridcontrolDSHocSinh();
        }

        private void gridViewDSHocSinh_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            gridViewDSHocSinh.SetRowCellValue(e.RowHandle, "Check",
                                              !Convert.ToBoolean(gridViewDSHocSinh.GetRowCellValue(e.RowHandle, "Check"))
                );
        }

        private void gridViewDSHocSinhMoi_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            gridViewDSHocSinhMoi.SetRowCellValue(e.RowHandle, "Check",
                                                 !Convert.ToBoolean(gridViewDSHocSinhMoi.GetRowCellValue(e.RowHandle,
                                                                                                         "Check"))
                );
        }

        private void chonTatCaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridViewDSHocSinh.RowCount; i++)
            {
                gridViewDSHocSinh.SetRowCellValue(i, "Check", true);
            }
        }

        private void chonTatCaDSLopDenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridViewDSHocSinhMoi.RowCount; i++)
            {
                gridViewDSHocSinhMoi.SetRowCellValue(i, "Check", true);
            }
        }

        private void xoaPhanLopMoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            simpleButtonXoaPLMoi_Click(this, new EventArgs());
        }

        private void phanLopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            simpleButtonChuyenLop_Click(this, new EventArgs());
        }

        #region Nested type: YeuCau

        private enum YeuCau
        {
            PhanLopHoSoChuaPhanLop,
            PhanLopHoSoNamCu,
            ChuyenLopCungKhoi
        };

        #endregion
    }
}