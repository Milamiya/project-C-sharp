using System;
using System.Collections.Generic;
using System.Text;

namespace BaoCaoThongKe.BusinessObject
{
    public class Xa_Phuong_InFo
    {
        public Xa_Phuong_InFo(){}
        public Xa_Phuong_InFo(int MaXa, string TenXa)
        {
            MaXa = M_MaXa;
            TenXa = M_TenXa;
        }
        private int M_MaXa;

        public int MaXa
        {
            get { return M_MaXa; }
            set { M_MaXa = value; }
        }

        private string M_TenXa;

        public string TenXa
        {
            get { return M_TenXa; }
            set { M_TenXa = value; }
        }

        private int M_MaHuyen;

        public int MaHuyen
        {
            get { return M_MaHuyen; }
            set { M_MaHuyen = value; }
        }

    }
}
