using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyBanHangDienTu.Business.EntitiesClass
{
    class EC_tb_Khachhang
    {
        private string makh;
        private string tenkh;
        private string diachi;
        private string dienthoai;

        public string MAKH
        {
            get
            {
                return makh;
            }
            set
            {
                makh = value;
                if (makh == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string TENKH
        {
            get
            {
                return tenkh;
            }
            set
            {
                tenkh = value;
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
    }
}
