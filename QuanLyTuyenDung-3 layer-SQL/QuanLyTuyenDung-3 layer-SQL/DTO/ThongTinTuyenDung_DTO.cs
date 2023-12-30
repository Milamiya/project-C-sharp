using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinTuyenDung_DTO
    {
        private string _maTT;

        public string MaTT
        {
            get { return _maTT; }
            set { _maTT = value; }
        }
        private string _tenTT;

        public string TenTT
        {
            get { return _tenTT; }
            set { _tenTT = value; }
        }
        private int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
        private DateTime _ngayYeuCau;

        public DateTime NgayYeuCau
        {
            get { return _ngayYeuCau; }
            set { _ngayYeuCau = value; }
        }
        private DateTime _ngayHetHan;

        public DateTime NgayHetHan
        {
            get { return _ngayHetHan; }
            set { _ngayHetHan = value; }
        }
        private string _moTaCongViec;

        public string MoTaCongViec
        {
            get { return _moTaCongViec; }
            set { _moTaCongViec = value; }
        }
        private float _mucLuong;

        public float MucLuong
        {
            get { return _mucLuong; }
            set { _mucLuong = value; }
        }
        private string _noiLamViec;

        public string NoiLamViec
        {
            get { return _noiLamViec; }
            set { _noiLamViec = value; }
        }
        private string _maNganh;

        public string MaNganh
        {
            get { return _maNganh; }
            set { _maNganh = value; }
        }
        private string _maMucDo;

        public string MaMucDo
        {
            get { return _maMucDo; }
            set { _maMucDo = value; }
        }
        private string _maTrinhDo;

        public string MaTrinhDo
        {
            get { return _maTrinhDo; }
            set { _maTrinhDo = value; }
        }
        private string _maViTri;

        public string MaViTri
        {
            get { return _maViTri; }
            set { _maViTri = value; }
        }
        /*
        public ThongTinTuyenDung_DTO(string matt,string tentt,int soluong,DateTime ngayyeucau,DateTime ngayhethan,string motacongviec,float mucluong,string noilamviec,string manganh,string mamucdo,string matrinhdo,string mavitri)
        {
            MaTT = matt;
            TenTT = tentt;
            SoLuong = soluong;
            NgayYeuCau = ngayyeucau;
            NgayHetHan = ngayhethan;
            MoTaCongViec = motacongviec;
            MucLuong = mucluong;
            NoiLamViec = noilamviec;
            MaNganh = manganh;
            MaMucDo = mamucdo;
            MaTrinhDo = matrinhdo;
            MaViTri = mavitri;
        }
         */
    }
}
