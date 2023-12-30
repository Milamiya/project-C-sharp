
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DATA_Tier;

namespace BUS_Tier
{
    public class NhaSanXuat_BUS
    {
        NhaSanXuat_DATA objNhaSanXUat = new NhaSanXuat_DATA();

        #region khai báo đối tượng , kiểm tra hợp lệ
        private string mahangsanxuat;
        private string tenhangsanxuat;
        private string thongtinnhasanxuat;

        public NhaSanXuat_BUS() { }
        public NhaSanXuat_BUS(string ma)
        {
            this.mahangsanxuat = ma;
        }
        public NhaSanXuat_BUS(string ma, string ten, string thongtin)
        {
            this.MAHANGSANXUAT = ma;
            this.TENHANGSANXUAT = ten;
            this.THONGTINHANGSANXUAT = thongtin;
        }

        public string MAHANGSANXUAT
        {
            get { return mahangsanxuat; }

            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập mã hãng sản xuất !");
                else
                    mahangsanxuat = value;
            }
        }
        public string TENHANGSANXUAT
        {
            get { return tenhangsanxuat; }

            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập tên hãng sản xuất !");
                else
                    tenhangsanxuat = value;
            }
        }
        public string THONGTINHANGSANXUAT
        {
            get { return thongtinnhasanxuat; }

            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Chưa nhập thông tin hãng sản xuất !");
                else
                    if (value == "Chưa có thông tin cho hãng sản xuất !! == > bấm [Đồng ý] lần nữa để lưu hãng sản xuất này !")
                        thongtinnhasanxuat = "";
                    else
                        thongtinnhasanxuat = value;
            }
        }
        #endregion

        #region lấy bảng dử liệu và các phươnng thức xử lý
        public DataTable getNhaSanXuat()
        {
            return objNhaSanXUat.getNhaSanXuat();
        }

        public int themNhaSX()
        {
            return objNhaSanXUat.themHangSX(mahangsanxuat, tenhangsanxuat, thongtinnhasanxuat);
        }
        public int xoaNhaSX()
        {
            return objNhaSanXUat.xoaHangSanXuat(mahangsanxuat);
        }
        public int capnhapHangSX()
        {
            return objNhaSanXUat.capnhatHangSX(mahangsanxuat, tenhangsanxuat, thongtinnhasanxuat);
        }
        #endregion
    }
}
