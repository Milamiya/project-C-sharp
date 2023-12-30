
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DATA_Tier;

namespace BUS_Tier
{
    public class TheLoai_BUS
    {
        TheLoai_DATA objTheLoai = new TheLoai_DATA();
        #region khai báo đối tượng và kiểm tra hợp lệ
        private string matheloai;
        private string tentheloai;
        private string matheloaiđangcchon;

        public TheLoai_BUS() { }
        public TheLoai_BUS(string ma, string ten)
        {
            this.MATHELOAI = ma;
            this.TENTHELOAI = ten;
        }

        public TheLoai_BUS(string matheloai)
        {
            // TODO: Complete member initialization
            this.matheloai = matheloai;
        }

        public string MATHELOAI
        {
            get { return matheloai; }
            
            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập mã thể loại !");
                else
                    matheloai = value;
            }
        }

        public string TENTHELOAI
        {
            get { return tentheloai; }

            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập tên thể loại !");
                else
                    tentheloai = value;
            }
        }
        #endregion

        #region các hàm lấy dử liệu bảng
        public DataTable getTheLoai()
        {
            return objTheLoai.getTheLoai();
        }
        public DataTable getTheLoai_by_ma(string matheloai)
        {
            return objTheLoai.getTheLoai_by_ma(matheloai);
        }
        public DataTable getTheLoai_by_mabaihat(string mabaihat)
        {
            return objTheLoai.getTheLoai_by_mabaihat(mabaihat);
        }
        #endregion

        #region các phương thức xử lý
        public int themTheLoai()
        {
            return objTheLoai.themTheLoai(matheloai, tentheloai);
        }
        public int xoaTheLoai()
        {
            return objTheLoai.xoaTheLoai(matheloai);
        }
        public int capnhatTheLoai()
        {
            return objTheLoai.capnhatTheLoai(matheloai, tentheloai);
        }
        #endregion
    }
}
