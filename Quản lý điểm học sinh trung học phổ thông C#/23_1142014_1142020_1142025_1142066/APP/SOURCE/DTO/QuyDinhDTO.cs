using System;

namespace QLHS.DTO
{
    public class QuyDinhDTO
    {
        public string TenTruong { get; set; }
        public string DiaChiTruong { get; set; }
        public int SoLuongLop { get; set; }
        public int SiSoCanTren { get; set; }
        public int TuoiCanTren { get; set; }
        public int TuoiCanDuoi { get; set; }
        public double DiemChuan { get; set; }
        public DateTime NgayApDung { get; set; }
        public string MaNamHoc { get; set; }
    }
}