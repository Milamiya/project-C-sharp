using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHangDienTu.Business.EntitiesClass
{
    class EC_tb_Nhanvien
    {
        private string manv;
        private string tennv;
        private string gioitinh;
        private string ngaysinh;
        private string dienthoai;
        private string diachi;
        private string ghichu;
        private string maca;
        private string macv;

        public string MANV
        {
            get
            {
                return manv;
            }
            set
            {
                manv = value;
                if (manv == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string TENNV
        {
            get
            {
                return tennv;
            }
            set
            {
                tennv = value;
            }
        }
        public string GIOITINH
        {
            get
            {
                return gioitinh;
            }
            set
            {
                gioitinh = value;
            }
        }
        public string NGAYSINH
        {
            get
            {
                return ngaysinh;
            }
            set
            {
                ngaysinh = value;
            }
        }
        public string DIENTHOAI
        {
            get
            {
                return dienthoai;
            }
            set
            {
                dienthoai = value;
            }
        }
        public string DIACHI
        {
            get
            {
                return diachi;
            }
            set
            {
                diachi = value;
            }
        }
        public string GHICHU
        {
            get
            {
                return ghichu;
            }
            set
            {
                ghichu = value;
            }
        }
        public string MACA
        {
            get
            {
                return maca;
            }
            set
            {
                maca = value;
                if (maca == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string MACV
        {
            get
            {
                return macv;
            }
            set
            {
                macv = value;
                if (macv == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
    }
}
