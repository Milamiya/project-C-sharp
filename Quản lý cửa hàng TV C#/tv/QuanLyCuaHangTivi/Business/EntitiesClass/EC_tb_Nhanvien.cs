using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCuaHangTivi.Business.EntitiesClass
{
    class EC_tb_Nhanvien
    {
        private string manv;
        private string tennv;
        private string gioitinh;
        private string ngaysinh;
        private string dienthoai;
        private string diachi;
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
                    throw new Exception("Mã nhân viên không được để trống. Xin nhập đầy đủ");
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
        public string MACA
        {
            get
            {
                return maca;
            }
            set
            {
                maca = value;
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
            }
        }
    }
}
