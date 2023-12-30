using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHangDienTu.Business.EntitiesClass
{
    class EC_tb_Hanghoa
    {
        private string mahang;
        private string tenhang;
        private string manhom;
        private string maloai;
        private string madonvi;
        private string machatlieu;
        private string manuoc;
        private string soluong;
        private string dongianhap;
        private string dongiaban;
        private string thoaigianbh;
        private byte[] hinhanh;
        private string ghichu;

        public string MAHANG
        {
            get
            {
                return mahang;
            }
            set
            {
                mahang = value;
                if (mahang == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string TENHANG
        {
            get
            {
                return tenhang;
            }
            set
            {
                tenhang = value;
            }
        }
        public string MANHOM
        {
            get
            {
                return manhom;
            }
            set
            {
                manhom = value;
                if (manhom == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string MALOAI
        {
            get
            {
                return maloai;
            }
            set
            {
                maloai = value;
                if (maloai == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string MADONVI
        {
            get
            {
                return madonvi;
            }
            set
            {
                madonvi = value;
                if (madonvi == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string MACHATLIEU
        {
            get
            {
                return machatlieu;
            }
            set
            {
                machatlieu = value;
                if (machatlieu == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string MANUOC
        {
            get
            {
                return manuoc;
            }
            set
            {
                manuoc = value;
                if (manuoc == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string SOLUONG
        {
            get
            {
                return soluong;
            }
            set
            {
                soluong = value;
            }
        }
        public string DONGIANHAP
        {
            get
            {
                return dongianhap;
            }
            set
            {
                dongianhap = value;
            }
        }
        public string DONGIABAN
        {
            get
            {
                return dongiaban;
            }
            set
            {
                dongiaban = value;
            }
        }
        public string THOAIGIANBH
        {
            get
            {
                return thoaigianbh;
            }
            set
            {
                thoaigianbh = value;
            }
        }
        public byte[] HINHANH
        {
            get
            {
                return hinhanh;
            }
            set
            {
                hinhanh = value;
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
    }
}
