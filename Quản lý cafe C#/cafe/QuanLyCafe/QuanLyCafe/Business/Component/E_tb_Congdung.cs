using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.Business.EntitiesClass;
using QuanLyCafe.DataAccess;
using System.Windows.Forms;


namespace QuanLyCafe.Business.Component
{
    class E_tb_Congdung
    {
        SQL_tb_Congdung nvsql = new SQL_tb_Congdung();
        public void themoinv(EC_tb_Congdung nv)
        {
            if (!nvsql.kiemtra(nv.MACONGDUNG))
            {
                nvsql.themmoi(nv);
            }
            else
            {
                MessageBox.Show("Mã này đã tồn tại,xin chọn Mã khác", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void suanv(EC_tb_Congdung nv)
        {
            nvsql.sua(nv);
        }
        public void xoanv(EC_tb_Congdung nv)
        {
            nvsql.xoa(nv);
        }
    }
}
