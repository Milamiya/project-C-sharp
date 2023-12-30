namespace QLHS.Report
{
    public class DTO_TongKetMon
    {
        public string MaNamHoc { get; set; }
        public string TenNamHoc { get; set; }
        public int MaKhoi { get; set; }
        public int MaHocKy { get; set; }

        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public int SiSo { get; set; }

        public string MaHocSinh { get; set; }
        public string TenHocSinh { get; set; }
        public string NgaySinh { get; set; }

        public string MaGiaoVien { get; set; }
        public string TenGiaoVien { get; set; }

        public string MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }

        public int STT { get; set; }
        public int SoLuongDat { get; set; }
        public double TyLe { get; set; }
    }
}