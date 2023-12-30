namespace QLHS.DTO
{
    public class NguoiDungDTO
    {
        private LoaiNguoiDungDTO m_LoaiNguoiDung = new LoaiNguoiDungDTO();
        public string MaND { get; set; }

        public int TrangThai { get; set; }

        public LoaiNguoiDungDTO LoaiNguoiDung
        {
            get { return m_LoaiNguoiDung; }
            set { m_LoaiNguoiDung = value; }
        }

        public string TenND { get; set; }

        public string TenDNhap { get; set; }

        public string MatKhau { get; set; }
    }
}