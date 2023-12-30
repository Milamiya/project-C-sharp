using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCafe.Business.EntitiesClass
{
    class EC_tb_Nhanvien
    {
        private string manv;
        private string tennv;
        private string diachi;
        private string gioitinh;
        private string ngaysinh;
        private string maque;
        private string sdt;

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
                    throw new Exception("Mã không để trống");
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
        public string MAQUE
        {
            get
            {
                return maque;
            }
            set
            {
                maque = value;
                if (maque == "")
                {
                    throw new Exception("Mã không được để trống");
                }
            }
        }
        public string SDT
        {
            get
            {
                return sdt;
            }
            set
            {
                sdt = value;
            }
        }
    }
}
