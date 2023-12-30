using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.Business.EntitiesClass;
using QuanLyCafe.DataAccess;
using System.Windows.Forms;

namespace QuanLyCafe.Business.Component
{
    class E_tb_Loai
    {
        SQL_tb_Loai lgsql = new SQL_tb_Loai();
        public void themoilg(EC_tb_Loai lg)
        {
            if (!lgsql.Equals(lg.MALOAI))
            {
                lgsql.themmoi(lg);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void sualg(EC_tb_Loai lg)
        {
            lgsql.sua(lg);
        }
        public void xoalg(EC_tb_Loai lg)
        {
            lgsql.xoa(lg);
        }
    }
}
