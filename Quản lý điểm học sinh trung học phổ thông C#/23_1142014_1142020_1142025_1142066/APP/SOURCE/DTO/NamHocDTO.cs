namespace QLHS.DTO
{
    public class NamHocDTO
    {
        public NamHocDTO()
        {
        }

        public NamHocDTO(string MaNamHoc, string TenNamHoc)
        {
            this.MaNamHoc = MaNamHoc;
            this.TenNamHoc = TenNamHoc;
        }

        public string MaNamHoc { get; set; }
        public string TenNamHoc { get; set; }

        public override string ToString()
        {
            return MaNamHoc + " " + TenNamHoc;
        }
    }
}