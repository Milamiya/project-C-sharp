using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.Business.EntitiesClass;

namespace QuanLyCafe.DataAccess
{
    class SQL_tb_Congdung
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtra(string macongdung)
        {
            return cn.kiemtra("select count(*) from [tb_Congdung] where macongdung=N'" + macongdung + "'");
        }
        public void themmoi(EC_tb_Congdung q)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Congdung
                      (macongdung, tencongdung) VALUES   (N'" + q.MACONGDUNG  + "',N'" + q.TENCONGDUNG  + "')");
        }
        public void xoa(EC_tb_Congdung q)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_Congdung] WHERE [macongdung] = N'" + q.MACONGDUNG  + "'");
        }

        public void sua(EC_tb_Congdung q)
        {
            string sql = (@"UPDATE tb_Congdung
            SET tencongdung =N'" + q.MACONGDUNG  + "' where  macongdung =N'" + q.TENCONGDUNG  + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
