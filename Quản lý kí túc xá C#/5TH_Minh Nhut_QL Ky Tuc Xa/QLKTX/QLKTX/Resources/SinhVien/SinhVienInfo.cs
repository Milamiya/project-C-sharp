using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace QLKTX
{
    public class SinhVienInfo
    {
        public ArrayList dsThanhNhan = new ArrayList();
        private string maKTX;
        private string hoTen;
        private bool gioiTinh;
        private DateTime ngaySinh;
        private string cMDN;
        private string dienThoai;
        private string mSSV;
        private string diaChi;
        private int maQuocTich;
        private int maTonGiao;
        private int maDanToc;
        private bool doanVien;
        private bool dangVien;
        private bool camTinhDang;
        private DateTime ngayvaoKTX;
        private DateTime ngayRaKTX;        
        private string hinh;

        public SinhVienInfo()
        {
            this.camTinhDang = false;
            this.cMDN = "";
            this.dangVien = false;
            this.diaChi = "";
            this.dienThoai = "";
            this.doanVien = false;
            this.gioiTinh = false;
            this.hinh = "";
            this.hoTen = "";
            this.maDanToc = 0;
            this.maKTX = "";
            this.maQuocTich = 0;
            this.maTonGiao = 0;
            this.mSSV = "";
            this.ngayRaKTX = DateTime.Now;
            this.ngaySinh = DateTime.Now;
            this.ngayvaoKTX = DateTime.Now;
            this.hinh = "";
        }

        public string MaKTX
        {   get{return maKTX;}
            set{maKTX = value;}
        }

        public bool CamTinhDang
        {
            get { return this.camTinhDang; }
            set { this.camTinhDang = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public bool GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

       
        //public string MaKTX
        //{
        //    get { return maKTX; }
        //    set { maKTX = value; }
        //}

        //public string MaKTX
        //{
        //    get { return maKTX; }
        //    set { maKTX = value; }
        //}

        //public string MaKTX
        //{
        //    get { return maKTX; }
        //    set { maKTX = value; }
        //}

        //public string MaKTX
        //{
        //    get { return maKTX; }
        //    set { maKTX = value; }
        //}


        //public string MaKTX
        //{
        //    get { return maKTX; }
        //    set { maKTX = value; }
        //}

        //public string MaKTX
        //{
        //    get { return maKTX; }
        //    set { maKTX = value; }
        //}

    }
}
