using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.Business.EntitiesClass;
using QuanLyCafe.DataAccess;
using System.Windows.Forms;

namespace QuanLyCafe.Business.Component
{
    class E_tb_Khachhang
    {
        SQL_tb_Khachhang khsql = new SQL_tb_Khachhang();
        public void themoikh(EC_tb_Khachhang kh)
        {
            if (!khsql.kiemtra(kh.MAKH))
            {
                khsql.themmoi(kh);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suakh(EC_tb_Khachhang kh)
        {
            khsql.sua(kh);
        }
        public void xoakh(EC_tb_Khachhang kh)
        {
            khsql.xoa(kh);
        }
    } 
}
