using System;
using System.Collections.Generic;
using System.Text;

namespace BaoCaoThongKe.BusinessObject
{
    public class NhomThueBao_InFo
    {
        public NhomThueBao_InFo() { }
        public NhomThueBao_InFo(int MaThueBao, string TenThueBao)
        {
            MaThueBao = M_MaThueBao;
            TenThueBao = M_TenThueBao;
        }
        private int M_MaThueBao;

        public int MaThueBao
        {
            get { return M_MaThueBao; }
            set { M_MaThueBao = value; }
        }

        private string M_TenThueBao;

        public string TenThueBao
        {
            get { return M_TenThueBao; }
            set { M_TenThueBao = value; }
        }
        	
	
    }
}
