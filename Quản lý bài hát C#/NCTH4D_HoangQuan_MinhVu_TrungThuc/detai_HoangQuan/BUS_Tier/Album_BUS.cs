/*
 * sv thực hiện: Lê Hữu Hoàng Quân - 10258441
 * ngày bắt đầu đề tài : 26/10/2012
 * lần cuối update ngày: 02/11/2012
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DATA_Tier;

namespace BUS_Tier
{
    public class Album_BUS
    {
        Album_DATA objAlbum = new Album_DATA();

        #region khai báo đối tương album và kiểm tra hợp lệ
        private string maalbum;
        private string tenalbum;
        private string namphathanh;

        public Album_BUS(string ma,string ten,string namphathanh) 
        {
            this.MAALBUM = ma;
            this.TENALBUM = ten;
            this.NAMPHATHANH = namphathanh;
        }
        public Album_BUS() { }
        public Album_BUS(string ma)
        {
            this.maalbum = ma;
        }

        public string MAALBUM
        {
            get
            {
                return maalbum;
            }
            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập mã album !");
                else
                    maalbum = value;
            }
        }

        public string TENALBUM
        {
            get
            {
                return tenalbum;
            }
            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập tên album !");
                else
                    tenalbum = value;
            }
        }

        public string NAMPHATHANH
        {
            get
            {
                return namphathanh;
            }
            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập năm phát hành !");
                else
                    namphathanh = value;
            }
        }

        #endregion

        #region các hàm lấy dử liệu bảng album và các phương thức xử lý
        public DataTable getAlbum()
        {
            return objAlbum.getAlbum();
        }
        public DataTable getAlbum_by_ma(string maalbum)
        {
            return objAlbum.getAlbum_by_ma(maalbum);
        }
        public int themAlbum()
        {
            return objAlbum.themAlbum(maalbum, tenalbum, namphathanh);
        }
        public int xoaAlbum()
        {
            return objAlbum.xoaAlbum(maalbum);
        }
        public int capnhatalbum()
        {
            return objAlbum.capnhatAlbum(maalbum, tenalbum, namphathanh);
        }
        public int xoaBaiHat_by_Album()
        {
            return objAlbum.xoaBaiHatKhoiAlBum(maalbum);
        }
        #endregion
    }
}
