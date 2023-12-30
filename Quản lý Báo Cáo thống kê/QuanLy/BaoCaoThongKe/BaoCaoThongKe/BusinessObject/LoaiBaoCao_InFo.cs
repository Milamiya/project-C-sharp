using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BaoCaoThongKe.BusinessObject
{
    public class LoaiBaoCao_InFo
    {
        //public LoaiBaoCao_InFo() { }
        //public LoaiBaoCao_InFo(int MaLoaiBaoCao, string TenLoaiBaoCao)
        //{
        //    MaLoaiBaoCao = M_MaLoaiBaoCao;
        //    TenLoaiBaoCao = M_TenLoaiBaoCao;
        //}
        private  int M_MaLoaiBaoCao;

        public  int MaLoaiBaoCao
        {
            get { return M_MaLoaiBaoCao; }
            set { M_MaLoaiBaoCao = value; }
        }

        private  string M_TenLoaiBaoCao;

        public  string TenLoaiBaoCao
        {
            get { return M_TenLoaiBaoCao; }
            set { M_TenLoaiBaoCao = value; }
        }
        	
	
    }
}
