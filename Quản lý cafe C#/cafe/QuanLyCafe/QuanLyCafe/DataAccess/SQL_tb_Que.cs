using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyCafe.Business.EntitiesClass;


namespace QuanLyCafe.DataAccess
{
    class SQL_tb_Que
    {
        ConnectDB cn = new ConnectDB();
        public bool kiemtra(string maque)
        {
            return cn.kiemtra("select count(*) from [tb_que] where tenque=N'" + maque  + "'");
        }
        public void themmoi(EC_tb_Que q)
        {
            cn.ExcuteNonQuery(@"INSERT INTO tb_Que
                      (maque, tenque) VALUES   (N'" + q.MAQUE + "',N'" + q.TENQUE + "')");
        }
        public void xoa(EC_tb_Que q)
        {
            cn.ExcuteNonQuery("DELETE FROM [tb_que] WHERE [maque] = N'" + q.MAQUE + "'");
        }

        public void sua(EC_tb_Que q)
        {
            string sql = (@"UPDATE tb_Que
            SET tenque =N'" + q.TENQUE + "' where  maque =N'" + q.MAQUE + "'");
            cn.ExcuteNonQuery(sql);
        }
    }
}
