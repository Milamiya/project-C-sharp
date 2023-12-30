/*
 * sv thực hiện: Lê Hữu Hoàng Quân - 10258441
 * ngày bắt đầu đề tài : 26/10/2012
 * lần cuối update ngày: 27/10/2012
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DATA_Tier;

namespace BUS_Tier
{
    public class CaSi_BUS
    {
        CaSi_DATA objCaSi = new CaSi_DATA();

        #region khai báo đối tượng , kiểm tra hợp lệ
        private string macasi;
        private string tencasi;
        private string thongtincasi;
        

        public CaSi_BUS() { }
        public CaSi_BUS(string ma, string ten, string thongtin)
        {
            this.MACASI = ma;
            this.TENCASI = ten;
            this.THONGTINCASI = thongtin;
        }

        public CaSi_BUS(string macasi)
        {
            // TODO: Complete member initialization
            this.macasi = macasi;
        }
        public string MACASI
        {
            get { return macasi; }
            
            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập mã ca sĩ !");
                else
                    macasi = value;
            }
        }

        public string TENCASI
        {
            get { return tencasi; }

            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Nhập tên ca sĩ !");
                else
                    tencasi = value;
            }
        }
        public string THONGTINCASI
        {
            get { return thongtincasi; }

            set
            {
                if (value.Trim().Equals(""))
                    throw new Exception("Chưa nhập thông tin ca sĩ !");
                else
                    if (value == "Chưa có thông tin cho ca sĩ !! == > bấm [Đồng ý] lần nữa để lưu ca sĩ này !")
                        thongtincasi = "";
                    else
                        thongtincasi = value;
            }
        }
        #endregion

        #region hàm lấy bảng dử liệu và các phương thức xử lý
        public DataTable getCaSi()
        {
            return objCaSi.getCasi();
        }
        public DataTable getCasi_by_macasi(string macasi)
        {
            return objCaSi.getCaSi_by_macasi(macasi);
        }
        public int themCaSi()
        {
            return objCaSi.themCaSi(macasi,tencasi,thongtincasi);
        }
        public int xoaCasi()
        {
            return objCaSi.xoaCaSi(macasi);
        }
        public int capnhapCaSi()
        {
            
            return objCaSi.capnhatCaSi(macasi, tencasi, thongtincasi);
        }
        #endregion
    }
}
