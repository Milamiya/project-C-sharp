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
    public class BaiHat_BUS
    {
        BaiHat_DATA objBaiHat = new BaiHat_DATA();

        #region khai báo đối tượng BaiHat và kiểm tra hợp lệ

        private string mabaihat;
        private string tenbaihat;
        private string matheloai;
        private string maalbum;
        private string macasi;
        private string matacgia;
        private string mahangsanxuat;
        private string loibaihat;

        public string MABAIHAT
        {
            get { return mabaihat; }

            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập mã bài hát !");
                else
                    mabaihat = value;
            }
        }

        public string TENBAIHAT
        {
            get { return tenbaihat; }

            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập tên bài hát !");
                else
                    tenbaihat = value;
            }
        }
        public string LOIBAIHAT
        {
            get { return loibaihat; }

            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Chưa nhập lời cho bài hát !");
                else
                    if (value == "Chưa có lời cho bài hát !! == > bấm [Đồng ý] lần nữa để lưu bài hát này !")
                        loibaihat = "";
                    else
                        loibaihat = value;
            }
        }
        #endregion

        #region các hàm khởi tạo (contructor)
        public BaiHat_BUS() { }

        public BaiHat_BUS(string ma, string ten, string matheloai, string maalbum, string macasi, string matacgia, string mahangsanxuat, string loibaihat)
        {
            this.MABAIHAT = ma;
            this.TENBAIHAT = ten;
            this.matheloai = matheloai;
            this.maalbum = maalbum;
            this.macasi = macasi;
            this.matacgia = matacgia;
            this.mahangsanxuat = mahangsanxuat;
            this.LOIBAIHAT = loibaihat;
        }

        public BaiHat_BUS(string ma)
        {
            this.mabaihat = ma;
        }

        #endregion

        #region các phương thức xử lý
        public int themBaiHat()
        {
            return objBaiHat.themBaiHat(mabaihat, tenbaihat, matheloai, maalbum, macasi, matacgia, mahangsanxuat, loibaihat);
        }
        public int xoaBaiHat()
        {
            return objBaiHat.xoaBaiHat(mabaihat);
        }
        public int capnhatBaiHat()
        {
            return objBaiHat.capnhatBaiHat(mabaihat, tenbaihat, matheloai, maalbum, macasi, matacgia, mahangsanxuat, loibaihat);
        }
        #endregion

        #region các hàm lấy dử liệu bài hát (table)

        /// <summary>
        /// hàm lấy tất cả bảng BaiHat
        /// </summary>
        /// <returns>trả về bảng bài hát</returns>
        public DataTable getBaiHat()
        {
            return objBaiHat.getBaiHat();
        }

        /// <summary>
        /// lấy bảng bài hát có tên album, tên thể loại,... (dùng cho tab Home)
        /// </summary>
        /// <returns>trả về bảng có đầy đủ tên album, tên thể loại (nối bảng)</returns>
        public DataTable getBaiHat_home()
        {
            return objBaiHat.getBaiHat_Home();
        }

        /// <summary>
        /// lấy bài hát theo mã album
        /// </summary>
        /// <param name="maalbum">mã album cần lấy bài hát</param>
        /// <returns>trả về bảng bài hát của album đc truyền vào</returns>
        public DataTable getBaiHat_by_album(string maalbum)
        {
            return objBaiHat.getBaiHat_by_Album(maalbum);
        }

        /// <summary>
        /// lấy bài hát theo mã thể loại
        /// </summary>
        /// <param name="matheloai">mã thể loại cần lấy bài hát trong nó</param>
        /// <returns>trả về bảng các bài hát thuộc 1 thểloại đc truyền vào</returns>
        public DataTable getBaiHat_by_TheLoai(string matheloai)
        {
            return objBaiHat.getBaiHat_by_TheLoai(matheloai);
        }

        /// <summary>
        /// lấy thông tin bài hát dựa vào mã bài hát
        /// </summary>
        /// <param name="mabaihat">mã bài hát cần lấy</param>
        /// <returns>trả về bảng thông tin của bài hát đc truyền vào</returns>
        public DataTable getBaiHat_by_mabaihat(string mabaihat)
        {
            return objBaiHat.getBaiHat_by_mabaihat(mabaihat);
        }

        
        public DataTable getBaiHat_cbo(string matheloai, string maalbum, string macasi, string matacgia, string mahangsanxuat)
        {
            return objBaiHat.getBaiHat_by_cbo(matheloai, maalbum, macasi, matacgia, mahangsanxuat);
        }

        public DataTable getBaiHat_cbo(string matheloai, string maalbum)
        {
            return objBaiHat.getBaiHat_by_cbo(matheloai, maalbum);
        }
        #endregion


    }
}
