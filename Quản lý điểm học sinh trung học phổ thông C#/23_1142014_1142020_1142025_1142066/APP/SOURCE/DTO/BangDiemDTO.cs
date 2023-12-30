namespace QLHS.DTO
{
    public class BangDiemDTO
    {
        private HocSinhDTO _HocSinhDTO = new HocSinhDTO();
        private LopDTO _LopDTO = new LopDTO();

        private MonHocDTO _MonHocDTO = new MonHocDTO();

        public HocSinhDTO HocSinh
        {
            get { return _HocSinhDTO; }
            set { _HocSinhDTO = value; }
        }

        public MonHocDTO MonHoc
        {
            get { return _MonHocDTO; }
            set { _MonHocDTO = value; }
        }

        public LopDTO LopDTO
        {
            get { return _LopDTO; }
            set { _LopDTO = value; }
        }

        public int MaHocKy { get; set; }

        public double DM_1 { get; set; }
        public double DM_2 { get; set; }
        public double D15_1 { get; set; }
        public double D15_2 { get; set; }
        public double D15_3 { get; set; }
        public double D15_4 { get; set; }
        public double D1T_1 { get; set; }
        public double D1T_2 { get; set; }
        public double DThi { get; set; }

        public double DTB { get; set; }
    }
}