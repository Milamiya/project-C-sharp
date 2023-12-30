using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.Business.EntitiesClass;
using QuanLyCafe.DataAccess;
using System.Windows.Forms;

namespace QuanLyCafe.Business.Component
{
    class E_tb_Sanpham
    {
        SQL_tb_Sanpham spsql = new SQL_tb_Sanpham();
        public void themoi(EC_tb_Sanpham lg)
        {
            if (!spsql.Equals(lg.MASP))
            {
                spsql.themmoiHang(lg);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void sua(EC_tb_Sanpham lg)
        {
            spsql.suaHang(lg);
        }
        public void xoa(EC_tb_Sanpham lg)
        {
            spsql.xoaHang(lg);
        }
        //load công việc
        public void loadmal(ComboBox cbl)
        {
            spsql.loadmaloai(cbl);
        }
        public string loadtenl(string Tenl, string Mal)
        {
            Tenl = spsql.Loadtenloai(Tenl, Mal);
            return Tenl;
        }
        //load loại
        public void loadmacd(ComboBox cbcd)
        {
            spsql.loadcd(cbcd);
        }
        public string loadtencd(string Tencd, string Macd)
        {
            Tencd = spsql.Loadtencd(Tencd, Macd);
            return Tencd;
        }
    }
}
