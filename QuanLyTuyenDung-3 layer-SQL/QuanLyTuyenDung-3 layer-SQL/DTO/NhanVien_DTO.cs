using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string _maNV;

        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }
        private string _tenNV;

        public string TenNV
        {
            get { return _tenNV; }
            set { _tenNV = value; }
        }
        private DateTime _ngaySinh;

        public DateTime NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }
        private string _chucVu;

        public string ChucVu
        {
            get { return _chucVu; }
            set { _chucVu = value; }
        }
        private string _maHuyen;

        public string MaHuyen
        {
            get { return _maHuyen; }
            set { _maHuyen = value; }
        }
        private string _maQG;

        public string MaQG
        {
            get { return _maQG; }
            set { _maQG = value; }
        }
        private string _maTT;

        public string MaTT
        {
            get { return _maTT; }
            set { _maTT = value; }
        }
        private string _maPB;

        public string MaPB
        {
            get { return _maPB; }
            set { _maPB = value; }
        }
        private string _maTB;

        public string MaTB
        {
            get { return _maTB; }
            set { _maTB = value; }
        }

        private string _maTinh;

        public string MaTinh
        {
            get { return _maTinh; }
            set { _maTinh = value; }
        }
        /*
        public NhanVien_DTO(string manv, string tennv, DateTime ngaysinh, string chucvu, string mahuyen, string maqg, string matinh, string matt, string mapb, string matb)
        {
            MaNV = manv;
            TenNV = tennv;
            NgaySinh = ngaysinh;
            ChucVu = chucvu;
            MaHuyen = mahuyen;
            MaQG = maqg;
            MaTinh = matinh;
            MaTT = matt;
            MaPB = MaPB;
            MaTB = matb;            
        }
         */ 
    }
}
