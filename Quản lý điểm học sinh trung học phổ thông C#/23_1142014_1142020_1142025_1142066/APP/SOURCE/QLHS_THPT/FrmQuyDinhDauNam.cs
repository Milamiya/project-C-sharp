using System;
using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using QLHS.BUS;
using QLHS.DTO;
using Util;

namespace QLHS
{
    public partial class FrmQuyDinhDauNam : XtraForm
    {
        private readonly NamHocBUS _namHocBUS;
        private readonly QuyDinhBUS _quyDinhBUS;

        public FrmQuyDinhDauNam()
        {
            InitializeComponent();
            _namHocBUS = new NamHocBUS();
            _quyDinhBUS = new QuyDinhBUS();
        }

        private void frmQuyDinhDauNam_Load(object sender, EventArgs e)
        {
            CboUtil.SetDataSource(comboBoxEditNamHoc, _namHocBUS.LayDTNamHoc(),
                                  "MaNamHoc", "TenNamHoc", 0);
            QuyDinhDTO quyDinh = _quyDinhBUS.LayDS_QuyDinh();
            textEdittenTruong.Text = quyDinh.TenTruong;
            textEditDiaChi.Text = quyDinh.DiaChiTruong;
            spinEditSoLuongLop.Value = quyDinh.SoLuongLop;
            spinEditSiSoToiDa.Value = quyDinh.SiSoCanTren;
            spinEditDoTuoiDen.Value = quyDinh.TuoiCanTren;
            spinEditDoTuoiTu.Value = quyDinh.TuoiCanDuoi;
            spinEditDiemDat.Value = Convert.ToDecimal(quyDinh.DiemChuan);
            dateEditNgayAD.EditValue = quyDinh.NgayApDung;
            CboUtil.SelectedItem(comboBoxEditNamHoc, quyDinh.MaNamHoc);
        }

        private void simpleButtonApDung_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (textEdittenTruong.Text.Length < 3)
            {
                msg = "\nTên trường không hợp lệ! (lớn hơn 3 ký tự)";
            }
            if (textEditDiaChi.Text.Length < 3)
            {
                msg = "\nĐịa chỉ không hợp lệ! (lớn hơn 3 ký tự)";
            }
            if (spinEditSoLuongLop.Value <= 0)
            {
                msg = "\nSố lượng lớp tối đa không hợp lệ! (lớn hơn 0)";
            }
            if (spinEditSiSoToiDa.Value <= 0)
            {
                msg = "\nSỉ số lớp tối đa không hợp lệ! (lớn hơn 0)";
            }
            if (spinEditDoTuoiTu.Value <= 13 || spinEditDoTuoiDen.Value < 13)
            {
                msg = "\nTuổi cận trên hoặc tuổi cận dưới không hợp lệ! (lớn hơn 13)";
            }
            else if (spinEditDoTuoiTu.Value >= spinEditDoTuoiDen.Value)
            {
                msg = "\nTuổi cận dưới phải nhỏ hơn tuổi cận trên!";
            }
            if (spinEditDiemDat.Value < 5 || spinEditDiemDat.Value > 10)
            {
                msg = "\nĐiểm đạt môn không hợp lệ (trong khoảng 5 đến 10)!";
            }
            if (msg != "")
            {
                MsgboxUtil.Error(msg);
                return;
            }
            var quyDinh = new QuyDinhDTO
                              {
                                  TenTruong = textEdittenTruong.Text.Replace("'", "''"),
                                  DiaChiTruong = textEditDiaChi.Text.Replace("'", "''"),
                                  SoLuongLop = Convert.ToInt32(spinEditSoLuongLop.Value),
                                  SiSoCanTren = Convert.ToInt32(spinEditSiSoToiDa.Value),
                                  TuoiCanTren = Convert.ToInt32(spinEditDoTuoiDen.Value),
                                  TuoiCanDuoi = Convert.ToInt32(spinEditDoTuoiTu.Value),
                                  DiemChuan = Convert.ToDouble(spinEditDiemDat.Value),
                                  NgayApDung = Convert.ToDateTime(dateEditNgayAD.EditValue),
                                  MaNamHoc = CboUtil.GetValueItem(comboBoxEditNamHoc)
                              };
            if (_quyDinhBUS.CapNhat_QuyDinh(quyDinh))
                MsgboxUtil.Success("Cập nhật quy định năm học thành công!");
            else
                MsgboxUtil.Error("Có lỗi trong quá trình cập nhật!");
        }

        private void simpleButtonDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void spinEditDiemDat_Properties_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                double ddat = Convert.ToDouble(spinEditDiemDat.Value);
                if (ddat < 0 || ddat > 10)
                    e.Cancel = true;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void spinEditDiemDat_InvalidValue(object sender, InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = "Điểm nhập không hợp lệ. Điểm có giá trị từ 0 -> 10";
        }
    }
}