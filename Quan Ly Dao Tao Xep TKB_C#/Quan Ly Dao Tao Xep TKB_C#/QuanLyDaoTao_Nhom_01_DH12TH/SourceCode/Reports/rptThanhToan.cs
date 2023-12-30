using System;
using DevExpress.XtraReports.UI;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.DTO;

namespace QuanLyDaoTao.Reports
{
    public partial class rptThanhToan : XtraReport
    {
        private rptThanhToanGioDayDTO source;

        public rptThanhToanGioDayDTO Source
        {
            get { return source; }
            set
            {
                source = value;
                CreateReport();
            }
        }

        public rptThanhToan(rptThanhToanGioDayDTO source)
        {
            InitializeComponent();
            this.source = source;
            CreateReport();
        }

        private void CreateReport()
        {
            try
            {
                maPC.DataBindings.Clear();
                maPC.DataBindings.Add("Text", source.NguonDuLieu, "MaPC");
                maMH.DataBindings.Clear();
                maMH.DataBindings.Add("Text", source.NguonDuLieu, "MaMH");
                tenMH.DataBindings.Clear();
                tenMH.DataBindings.Add("Text", source.NguonDuLieu, "TenMH");
                maLop.DataBindings.Clear();
                maLop.DataBindings.Add("Text", source.NguonDuLieu, "MaLop");
                phong.DataBindings.Clear();
                phong.DataBindings.Add("Text", source.NguonDuLieu, "MaPhong");
                ngay.DataBindings.Clear();
                ngay.DataBindings.Add("Text", source.NguonDuLieu, "Ngay");
                tietBD.DataBindings.Clear();
                tietBD.DataBindings.Add("Text", source.NguonDuLieu, "TietBatDau");
                soTiet.DataBindings.Clear();
                soTiet.DataBindings.Add("Text", source.NguonDuLieu, "SoTiet");

                title.Text = String.Format("BẢNG THANH TOÁN GIỜ DẠY TỪ {0:dd/MM/yyyy} ĐẾN {1:dd/MM/yyyy}", source.NgayBD, source.NgayKT);
                maGV.Text = source.MaGV;
                hoTen.Text = source.TenGV;
                trinhDo.Text = source.TrinhDo;

                DateTime toDay = DateTime.Today;
                ngayLap.Text = "Long Xuyên, ngày " + toDay.Day + " tháng " + toDay.Month + " năm " + toDay.Year;
                nguoiLap.Text = StaticClass.User.TenNguoiDung;
                thoiGianIn.Text = "In lúc " + DateTime.Now.ToString("HH:mm:ss") + ", ngày " + toDay.ToString("dd/MM/yyyy");
                giangVien.Text = source.TenGV;

                thucDay.Text = String.Format("{0:#,#}", source.ThucDay);
                luongTiet.Text = String.Format("{0:#,#}", source.ThuLao);
                thanhTien.Text = String.Format("{0:#,#}", source.ThuLao * source.ThucDay);
                bangChu.Text = UtilitiesClass.DocSo((source.ThuLao * source.ThucDay).ToString())+" đồng";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
