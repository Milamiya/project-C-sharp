
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DATA_Tier;

namespace BUS_Tier
{
    public class TacGia_BUS
    {
        TacGia_DATA objTacGia = new TacGia_DATA();

        #region khai báo đối tượng, kiểm tra hợp lệ
        private string matacgia;
        private string tentacgia;
        private string thongtintacgia;

        public TacGia_BUS() { }
        public TacGia_BUS(string ma)
        {
            this.matacgia = ma;
        }
        public TacGia_BUS(string ma, string ten, string thongtin)
        {
            this.MATACGIA = ma;
            this.TENTACGIA = ten;
            this.THONGTINTACGIA = thongtin;
        }

        public string MATACGIA
        {
            get { return matacgia; }

            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập mã tác giả !");
                else
                    matacgia = value;
            }
        }
        public string TENTACGIA
        {
            get { return tentacgia; }

            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập tên tác giả !");
                else
                    tentacgia = value;
            }
        }
        public string THONGTINTACGIA
        {
            get { return thongtintacgia; }

            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Chưa nhập thông tin tác giả !");
                else
                    if (value == "Chưa có thông tin cho tác giả !! == > bấm [Đồng ý] lần nữa để lưu tác giả này !")
                        thongtintacgia = "";
                    else
                        thongtintacgia = value;
            }
        }
        #endregion

        #region hàm lấy dử liệu bảng và các phương thức xử lý
        public DataTable getTacGia()
        {
            return objTacGia.getTacGia();
        }

        public int themTacGia()
        {
            return objTacGia.themTacGia(matacgia, tentacgia, thongtintacgia);
        }
        public int xoaTacGia()
        {
            return objTacGia.xoaTacGia(matacgia);
        }
        public int capnhapCaSi()
        {
            return objTacGia.capnhatTacGia(matacgia, tentacgia, thongtintacgia);
        }
        #endregion
    }
}
