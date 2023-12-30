using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoSo_DTO
    {
        private string _maHS;

        public string MaHS
        {
            get { return _maHS; }
            set { _maHS = value; }
        }

        private DateTime _ngayNop;

        public DateTime NgayNop
        {
            get { return _ngayNop; }
            set { _ngayNop = value; }
        }

        private string _maViTri;

        public string MaViTri
        {
            get { return _maViTri; }
            set { _maViTri = value; }
        }

        private string _cMND;

        public string CMND
        {
            get { return _cMND; }
            set { _cMND = value; }
        }

        private string _hoTen;

        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }

        private DateTime _ngaySinh;

        public DateTime NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }
        private string _maLoaiHS;

        public string MaLoaiHS
        {
            get { return _maLoaiHS; }
            set { _maLoaiHS = value; }
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
        private string _maTinh;

        public string MaTinh
        {
            get { return _maTinh; }
            set { _maTinh = value; }
        }
        private string _maNV;

        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }
        /*
        public HoSo_DTO(string mahs, DateTime ngaynop, string mavitri, string cmnd, string hoten, DateTime ngaysinh, string maloaihs, string mahuyen, string maqg, string matinh, string manv)
        {
            MaHS = mahs;
            NgayNop = ngaynop;
            MaViTri = mavitri;
            CMND = cmnd;
            HoTen = hoten;
            NgaySinh = ngaysinh;
            MaLoaiHS = maloaihs;
            MaHuyen = mahuyen;
            MaQG = maqg;
            MaTinh = matinh;
            MaNV = manv;
        }
        */
    }
}
