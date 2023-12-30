using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyCuaHangTivi.Business.EntitiesClass
{
    class EC_tb_Tivi
    {
        private string mativi;
        private string tentivi;
        private string mahangsx;
        private string mamau;
        private string mamanhinh;
        private string maco;
        private string manoisx;
        private string dongianhap;
        private string dongiaban;
        private byte[] anh;
        private string ghichu;
        private string soluong;
        private string thoigianbaohanh;
        private string makieu;

        public string MATIVI
        {
            get
            {
                return mativi;
            }
            set
            {
                mativi = value;
                if (mativi == "")
                {
                    throw new Exception("Mã Không được để trống");
                }
            }
        }
        public string TENTIVI
        {
            get
            {
                return tentivi;
            }
            set
            {
                tentivi = value;
            }
        }
        public string MAHANGSX
        {
            get
            {
                return mahangsx;
            }
            set
            {
                mahangsx = value;
            }
        }
        public string MAMANHINH
        {
            get
            {
                return mamanhinh;
            }
            set
            {
                mamanhinh = value;
            }
        }
        public string MAMAU
        {
            get
            {
                return mamau;
            }
            set
            {
                mamau = value;
            }
        }
        public string MACO
        {
            get
            {
                return maco;
            }
            set
            {
                maco = value;
            }
        }
        public string MANOISX
        {
            get
            {
                return manoisx;
            }
            set
            {
                manoisx = value;
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
        public byte[] ANH
        {
            get
            {
                return anh;
            }
            set
            {
                anh = value;
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
        public string THOIGIANBAOHANH
        {
            get
            {
                return thoigianbaohanh;
            }
            set
            {
                thoigianbaohanh = value;
            }
        }
        public string MAKIEU
        {
            get
            {
                return makieu;
            }
            set
            {
                makieu = value;
            }
        }
    }
}
